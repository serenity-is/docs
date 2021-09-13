# Allowing Multiple Genre Selection

It happens. Requirements change. Now we want to allow selecting multiple genres for a movie.

For this, we need a M-N mapping table that will let us link any movie to multiple genres.


### Creating MovieGenres Table

As usual, we start with a migration:

*Migrations/DefaultDB/ DefaultDB_20160528_115400_MovieGenres.cs:*

```cs
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20160528_115400)]
    public class DefaultDB_20160528_115400_MovieGenres : Migration
    {
        public override void Up()
        {
            Create.Table("MovieGenres").InSchema("mov")
                .WithColumn("MovieGenreId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_MovieId", 
                        "mov", "Movie", "MovieId")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_GenreId", 
                        "mov", "Genre", "GenreId");

            Execute.Sql(
              @"INSERT INTO mov.MovieGenres (MovieId, GenreId) 
                    SELECT m.MovieId, m.GenreId 
                    FROM mov.Movie m 
                    WHERE m.GenreId IS NOT NULL");

            Delete.ForeignKey("FK_Movie_GenreId")
                .OnTable("Movie").InSchema("mov");
            Delete.Column("GenreId")
                .FromTable("Movie").InSchema("mov");
        }

        public override void Down()
        {
        }
    }
}
```

I tried to save existing Genre declarations on Movie table, by copying them to our new MovieGenres table. The line above with *Execute.Sql* does this.

Then we should remove GenreId column, by first deleting the foreign key declaration *FK_Movie_GenreId* that we defined on it previously.


### Deleting Mapping for GenreId Column

As soon as you build and open the Movies page, you'll get this error:

![GenreId Error](img/mdb_genreid_error.png)

This is because we still have mapping for GenreId column in our row. Error above is received from AJAX call to *List* service handler for *Movie* table. 

> Repeating of error message originates from SQL server. *MovieId* column name passes several times within the generated dynamic SQL.

Remove GenreId and GenreName properties and their related field objects from *MovieRow.cs*:

```cs
// remove this
public Int32? GenreId
{
    get => fields.GenreId[this];
    set => fields.GenreId[this] = value;
}

// remove this
public String GenreName
{
    get => fields.GenreName[this];
    set => fields.GenreName[this] = value;
}

public class RowFields : RowFieldsBase
{
    // and remove these
    public Int32Field GenreId;
    public StringField GenreName;
}
```

Remove GenreName property from *MovieColumns.cs*:

```cs
// remove this
[Width(100), QuickFilter]
public String GenreName { get; set; }
```

Remove GenreId property from *MovieForm.cs*:

```cs
// remove this
public Int32 GenreId { get; set; }
```

After building, we at least have a working *Movies* page again.


### Generating Code For MovieGenres Table

Fire up sergen and generate code for *MovieGenres* table as usual:

- Connection Key: **Default**
- Table Name: **mov.MovieGenres**
- Module Name: **MovieDB**
- Entity Identifier: **MovieGenres**
- Permission Key: **Administration:General**

As we're not going to edit movie genres from a separate page, you can safely delete the generated files below:

```
MovieGenresColumns.cs
MovieGenresDialog.ts
MovieGenresEndpoint.cs
MovieGenresForm.cs
MovieGenresGrid.cs
MovieGenresIndex.cshtml
MovieGenresPage.cs
```

You also should delete newly generated line for navigation from _MovieDBNavigation.cs_.
You can also remove CSS entries for s-MovieDB-MovieGenresDialog from *site.less*.

Only leave last five files, *MovieGenresRow.cs* and files in *RequestHandlers* folder.

After building, run T4 templates to be sure, no T4 generated files related to *MovieGenresForm* etc. is left behind.

### Adding GenreList Field

As one movie might have multiple genres now, instead of a Int32 property, we need a list of Int32 values, e.g. `List<Int32>`. Add the GenreList property to *MovieRow.cs*:

> You might have to add System.Collections.Generic to usings.

```cs

//...
[DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
public MovieKind? Kind
{
    get => (MovieKind?)fields.Kind[this];
    set => fields.Kind[this] = (Int32?)value;
}

[DisplayName("Genres")]
[LookupEditor(typeof(GenreRow), Multiple = true), NotMapped]
[LinkingSetRelation(typeof(MovieGenresRow), "MovieId", "GenreId")]
public List<Int32> GenreList
{
    get => fields.GenreList[this];
    set => fields.GenreList[this] = value;
}

public class RowFields : RowFieldsBase
{
    //...
    public Int32Field Kind;
    public ListField<Int32> GenreList;
```

Our property has [LookupEditor] attribute just like *GenreId* property had, but with one difference. This one accepts multiple genre selection. We set it with *Multiple = true* argument.

This property also has *NotMapped* flag, which is something similar to *Unmapped* fields in Serenity. It specifies that this property has no matching database column in database. 

We don't have a *GenreList* column in *Movie* table, so we should set it as an unmapped field. Otherwise, Serenity will try to *SELECT* it, and we'll get SQL errors.

In the next line, we use another new attribute, *LinkingSetRelation*:

```cs
[LinkingSetRelation(typeof(MovieGenresRow), "MovieId", "GenreId")]
```

This is an attribute which is specific to M-N releations that links a row in this table to multiple rows from another table.

First argument of it is the type of M-N mapping row, which is *MovieGenresRow* here.

Second argument is the property name of field in that row (MovieGenresRow) that matches this row's ID property, e.g. MovieId.

Third argument is the property name of field in that row (MovieGenresRow) that links multiple Genres by their IDs, e.g. GenreId.

> LinkingSetRelation has a related Serenity service behavior, named *LinkingSetRelationBehavior* that is automatically activated for all fields with a *LinkingSetRelation* attribute. 

> This behavior, will intercept service handlers for *Create*, *Update*, *Delete*, *Retrieve* and *List* and inject code to populate or update our *GenreList* column and its related *MovieGenres* table.

> We'll talk about Serenity service behaviors in following chapters.

### Adding Genre List To Form

Edit *MovieForm.cs* and add *GenreList* property:

```cs
  public class MovieForm
  {
      //...
      public List<Int32> GenreList { get; set; }
      public MovieKind Kind { get; set; }
      public Int32 Runtime { get; set; }
  }
```

Now we can add multiple genres to a Movie:

![Movie Multiple Genres](img/mdb_multiple_genres.png)


### Showing Selected Genres in a Column

Previously, when we had only one Genre per Movie. We could show the selected genre in a column, by adding a view field to MovieRow.cs. It is not going to be so simple this time.

Let's start by adding GenreList property to *MovieColumns.cs*:

```cs
public class MovieColumns
{
    //...
    [Width(200)]
    public List<Int32> GenreList { get; set; }
    [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
    public Int32 Runtime { get; set; }
}
```

This is what we got:

![Movie Multiple Genres](img/mdb_genre_idlist.png)

GenreList column contains a list of Int32 values, which corresponds to an array in Javascript. Luckily, Javascript .toString() method for an array returns items separated by comma, so we got *"1,2"* for *Fight Club* movie.

We would prefer genre names instead of Genre IDs, so it's clear that we need to *format* these values, by converting GenreId to their Genre name equivalents. 


### Creating GenreListFormatter Class

It's time to write a SlickGrid column formatter. Create file *GenreListFormatter.ts* next to *MovieGrid.ts*:

```ts
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerFormatter()
    export class GenreListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            let idList = ctx.value as number[];
            if (!idList || !idList.length)
                return "";

            let byId = GenreRow.getLookup().itemById;

            return idList.map(x => {
                let g = byId[x];
                if (!g)
                    return x.toString();

                return Q.htmlEncode(g.Name);
            }).join(", ");
        }
    }
}
```

Here we define a new formatter, *GenreListFormatter* and register it with Serenity type system, using *@Serenity.Decorators.registerFormatter* decorator. Decorators are similar to .NET attributes.

All formatters should implement Slick.Formatter interface, which has a *format* method that takes a *ctx* parameter of type *Slick.FormatterContext*.

*ctx*, which is the formatting context, is an object with several members. One of them is *value* that contains the column value for current grid row/column being formatted.

As we know that we'll use this formatter on column with a `List<Int32>` value, we start by casting value to *number[]*.

> There is no Int32 type in Javascript. Int32, Double, Single etc. corresponds to number type. Also, generic *`List<>`* type in C# corresponds to an Array in Javascript.

If the array is empty or null, we can safely return an empty string:

```ts
const idList = ctx.value as number[];
if (!idList || !idList.length)
    return "";
```

Then we get a reference to *Genre* lookup, which has a dictionary of *Genre* rows in its *itemById* property:

```ts
const byId = GenreRow.getLookup().itemById;
```

Next, we start mapping these ID values in our *idList* to their Genre name equivalents, using *Array.map* function in Javascript, which is pretty similar to LINQ Select statement:

```ts
return idList.map(x => { 
```

We lookup an ID in our Genre dictionary. It should be in dictionary, but we play safe here, and return its numeric value, if the genre is not found in dictionary.

```ts
const g = byId[x];
if (!g)
    return x.toString();
```

If we could find the genre row, corresponding to this ID, we return its Name value. We should HTML encode the genre name, just in case it contains invalid HTML characters, like `<`, `>` or `&`.

```ts
return Q.htmlEncode(g.Name);
```

> We could also write a generic formatter that works with any type of lookup list, but it's beyond scope of this tutorial.

### Assigning GenreListFormatter to GenreList Column

As we defined a new formatter class, we should build and transform T4 files, so that we can reference *GenreListFormatter* in server side code.

After building and transforming, open MovieColumns.cs and attach this formatter to MovieList property:

```cs
public class MovieColumns
{
    //...
    [Width(200), GenreListFormatter]
    public List<Int32> GenreList { get; set; }
    [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
    public Int32 Runtime { get; set; }
}
```

Now we can see Genre names in Genres column:

![Movie Genre Names](img/mdb_genre_names.png)

