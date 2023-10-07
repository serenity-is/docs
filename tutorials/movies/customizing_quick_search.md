
# Customizing Quick Search

## Adding Multiple Movie Entries

To proceed with the upcoming sections, we require some sample data. You have the option to manually enter this data, or you can save time by using the sample data available in a migration file, which can be found [here](https://gist.github.com/volkanceylan/0b3e71de6247ad9963e33889f85003bc).

If you choose to use the migration file, create a new migration with a suitable name, such as `DefaultDB_20221114_1703_MovieData.cs`. In the `Up` method of this migration, paste the code from the provided gist, like this:

```cs
namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, Migration(20221114_1703)]
public class DefaultDB_20221114_1703_MovieData : AutoReversingMigration
{
    public override void Up()
    {
        Insert.IntoTable("Movie").InSchema("mov")
            .Row(new
            {
                Title = "The Matrix",
        //...
    }
}
```

After creating the migration, restart your application to execute it.

By adding this movie data, you will have a set of sample entries to work with, as shown in the image:

![Movie Data Entered](img/movie-data-entered.png)

If we were to enter "go" into the search box, two movies, "The Good, the Bad and the Ugly" and "The Godfather," would be filtered.

However, if we tried searching for "Gandalf," we wouldn't find any results. This is because, by default, Serenity identifies the first textual field in a table as "the name field", which is used for text searches. In the "Movies" table, the name field is "Title", and this field is marked with the `QuickSearch` attribute to enable text searches.

The name field also determines the initial sorting order and is used in edit dialog titles. Sometimes, the first textual column might not be suitable as the name field. In such cases, you can change it by switching the `[NameProperty]` attribute from the current property, such as "Title", to another property, like "Description". However, in our case, "Title" is indeed the name field, so we leave it as is.

If you want Serenity to search in additional fields, like "Description" and "Storyline", you should add the `QuickSearch` attribute to these fields as well. Here's how it's done:

```cs
//...
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    //...
    [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(1000), QuickSearch]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Storyline"), QuickSearch]
    public string Storyline { get => fields.Storyline[this]; set => fields.Storyline[this] = value; }
    //...
}
```

By adding the `QuickSearch` attribute to the "Description" and "Storyline" fields, you enable text searches in these columns. Now, if you search for "Gandalf", you'll get an entry for "The Lord of the Rings":

![Movies Search Gandalf](img/search-gandalf.png)

QuickSearch attribute, by default, searches with *contains* filter. It has some options to make it match by *starts with* filter or match only exact values.

If we wanted it to show only rows that *starts with* typed text, we would change attribute to:

```cs
[DisplayName("Title"), Size(200), NotNull, QuickSearch(SearchType.StartsWith)]
public string Title
{
    get => fields.Title[this];
    set => fields.Title[this] = value;
}
```

> Here this quick search feature is not very useful, but for values like SSN, serial number, identification number, phone number etc, it might be.

If we wanted to search also in year column, but only exact integer values (1999 matches but not 19):

```cs
[DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
public int? Year
{
    get => fields.Year[this];
    set => fields.Year[this] = value;
}
```

> You might have noticed that we are not writing any C# or SQL code for these basic features to work. We just specify what we want, rather than how to do it. This is what declarative programming is. 

It is also possible to provide user with ability to determine which field (s)he wants to search on.

Open *MovieTutorial.Web/Modules/MovieDB/Movie/MovieGrid.ts* and modify it like:

```ts
import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { MovieColumns, MovieRow, MovieService } from '../../ServerTypes/MovieDB';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('MovieTutorial.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow, any> {
    // ...
    constructor(container: JQuery) {
        super(container);
    }

    protected getQuickSearchFields(): QuickSearchField[] {
        return [
            { name: "", title: "all" },
            { name: "Description", title: "description" },
            { name: "Storyline", title: "storyline" },
            { name: "Year", title: "year" }
        ];
    }
}
```

Once you save that file, we'll have a dropdown in quick search input:

![Movies Quick Search Fields](img/mdb_movie_quicksearchfield.png)

> Unlike prior samples where we modified Server side code, this time we did changes in client side, and modified Javascript (TypeScript) code.


### Running Code Transformations with Sergen

In prior sample we harcoded field names like *Description*, *Storyline* etc. This may lead to typing errors if we forgot actual property names or their casing at server side (javascript is case sensitive).

Sergen generates some code to transfer such information from server side (rows etc in C#) to client side (TypeScript) for intellisense purposes on every build.

It is also possible to open a command prompt in project directory and type `dotnet sergen t` to transform templates manually.

From now on, when we say transform templates, it means either rebuilding the application or running `dotnet sergen t` in rare cases.

> If you are using Premium StartSharp template then your code will be generated in development time with source generators.

### Intellisense on TypeScript Code (After transforming templates)

We can now use intellisense to replace hardcoded field names with compile time checked versions:

```ts
//...
import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { MovieColumns, MovieRow, MovieService } from '../../ServerTypes/MovieDB';

export class MovieGrid extends EntityGrid<MovieRow, any> {
    //...

    constructor(container: JQuery) {
        super(container);
    }

    protected getQuickSearchFields(): QuickSearchField[] {
        const fld = MovieRow.Fields;
        return [
            { name: "", title: "all" },
            { name: fld.Description, title: "description" },
            { name: fld.Storyline, title: "storyline" },
            { name: fld.Year, title: "year" }
        ];
    }
}
```

What about field titles? It is not so critical as field names, but can be useful for localization purposes (if we later decide to translate it):

```ts
import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { text } from '@serenity-is/corelib/q';
import { MovieColumns, MovieRow, MovieService } from '../../ServerTypes/MovieDB';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('MovieTutorial.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow, any> {
   // ...

    constructor(container: JQuery) {
        super(container);
    }

    protected getQuickSearchFields(): QuickSearchField[] {
        const txt = (s) =>
            text(`Db.${MovieRow.localTextPrefix}.${s}`).toLowerCase();
        const fld = MovieRow.Fields;

        return [
            { name: "", title: "all" },
            { name: fld.Description, title: txt(fld.Description) },
            { name: fld.Storyline, title: txt(fld.Storyline) },
            { name: fld.Year, title: txt(fld.Year) }
        ];
    }
}
```

We made use of the local text dictionary (translations) available at client side. It's something like this:

```json
{
   // ...
   "Db.MovieDB.Movie.Description": "Description",
   "Db.MovieDB.Movie.Storyline": "Storyline",
   "Db.MovieDB.Movie.Year": "Year"
   // ...
}
```

Local text keys for row fields are generated from *"Db." + (LocalTextPrefix for Row) + "." + FieldName*.

Their values are generated from [DisplayName] attributes on your fields by but might be something else in another culture if they are translated.

LocalTextPrefix corresponds to *ModuleName + "." + RowClassName* by default, but can be changed in Row fields constructor.


