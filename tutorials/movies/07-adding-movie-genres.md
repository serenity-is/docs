# Adding Movie Genres

## Adding Genre Field

To store movie genres in your database, you should create a lookup table. While an enumeration is suitable for the "Kind" field, genres might change over time and are not static. Therefore, it's better to use a table to manage genres. Let's start by creating a migration to generate the Genre table and add a "GenreId" column to the Movie table.

**Migrations/DefaultDB/DefaultDB_20221114_1836_GenreTable.cs**:

```csharp
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20221114_1836)]
public class DefaultDB_20221114_1836_GenreTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Genre")
            .WithColumn("GenreId").AsInt32().NotNullable()
                .PrimaryKey().Identity()
            .WithColumn("Name").AsString(100).NotNullable();

        Alter.Table("Movie")
            .AddColumn("GenreId").AsInt32().Nullable()
                .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");

        Insert.IntoTable("Genre")
            .Row(new { Name = "Action" })
            .Row(new { Name = "Drama" })
            .Row(new { Name = "Comedy" })
            .Row(new { Name = "Sci-fi" })
            .Row(new { Name = "Fantasy" })
            .Row(new { Name = "Documentary" });
    }
}
```

This migration creates the "Genre" table and adds a "GenreId" column to the "Movie" table. We also add some sample genres.

![Adding Movie Genres Animation](img/07-adding-movie-genres.webp)

> Note: In reality, a movie can have multiple genres, and in such cases, you would typically use a separate "MovieGenres" table. However, for simplicity, we'll consider a single genre per movie for now. We'll explore how to handle multiple genres later.

## Generating Code for the Genre Table

After running the project to execute the migration, you need to generate code for the "Genre" table using Sergen. Run the following command in your project directory:

```bash
dotnet sergen g
```

Specify the following parameters:

- **Connection Key**: Default
- **Table Name**: dbo.Genre
- **Module Name**: MovieDB
- **Class Identifier**: Genre
- **Permission Key**: Administration:General
- **What to Generate**: All

Once you've rebuilt your solution and run it, you'll find a new section in your application named "MovieDB." Within this section, you'll see the "Genres" page, which allows you to manage movie genres.

![Genre Initial Page](img/genre-initial-page.png)

In the screenshot above, you'll notice that the "Genres" page is located under the "MovieDB" section. This organization might differ from the section you recently renamed as "Movie Database." The reason for this distinction is that Sergen isn't aware of the customizations made to your existing navigation items. To rectify the section organization, you'll need to manually move the "Genres" page under the "Movie Database" section.

To accomplish this, navigate to the `Modules/Movie/MovieDBNavigation.cs` file and modify the navigation link for "Genre" as follows:

```csharp
[assembly: NavigationLink(6200, "Movie Database/Genres", typeof(MyPages.GenrePage), icon: "fa-thumb-tack")]
```

By making this adjustment, you ensure that the "Genres" page is placed under the "Movie Database" section, aligning with your desired organization.

## Mapping the GenreId Field in MovieRow

To establish the relationship between movies and genres, we need to map the `GenreId` field within the `MovieRow.cs` file. Here's the code snippet to achieve this:

```csharp
// ...
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    const string jGenre = nameof(jGenre);

    // ...

    [DisplayName("Genre"), ForeignKey(typeof(GenreRow)), LeftJoin(jGenre)]
    public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }

    [DisplayName("Genre"), Expression($"{jGenre}.Name")]
    public string GenreName { get => fields.GenreName[this]; set => fields.GenreName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        // ...
        public Int32Field GenreId;
        public StringField GenreName;
    }
}
```

In the provided code:

- We've defined a new constant, `jGenre`, which will serve as an alias for a Genre table join.

- The `GenreId` field is mapped using the `[ForeignKey]` attribute. We specify `typeof(GenreRow)` to indicate that this field is related to the `GenreRow` entity. This also informs Serenity to determine the name of the table and its ID property from the `GenreRow` entity. This is a recommended approach as it helps prevent typing errors.

- The `[LeftJoin(jGenre)]` attribute declares that when the Genre table needs to be joined, its alias should be set to `jGenre`. In SQL terms, this corresponds to generating queries with a LEFT JOIN between the Movies and Genre tables. This join is only performed when fields from the Genre table are requested, for instance, if its columns are visible in a data grid. The internally generated query could look like below:

    ```sql
    SELECT t0.MovieId, t0.Kind, t0.GenreId, jGenre.Name as GenreName 
    FROM Movies t0
    LEFT JOIN Genre jGenre on t0.GenreId = jGenre.GenreId 
    ```

- We've added a new field, `GenreName`, which is not present in the Movie table but is derived from the Genre table. By using the `Expression` attribute and specifying `$"{jGenre}.Name"`, we indicate that this field represents an SQL expression originating from the `jGenre` join. Alternatively, you could use the `Origin` attribute instead of the `Expression` attribute like this, which is functionally equivalent but recommended to avoid typos:

   ```csharp
    [DisplayName("Genre"), Origin(jGenre, nameof(GenreRow.Name))]
    public string GenreName { get => fields.GenreName[this]; set => fields.GenreName[this] = value; }
   ```

In essence, these code modifications define the relationship between the Movie and Genre tables and ensure that the correct data is retrieved when needed.

It's important to note that Serenity's entities function somewhat like SQL views, allowing you to incorporate fields from other tables through joins. This flexibility enables you to efficiently structure your data and relationships in your application.

Additionally, Serene and StartSharp templates enable SQL query logging by default, allowing you to see the executed queries in the output console. The `appsettings.Development.json` configuration file contains settings for query logging:

```json
{
    // ...
    "Logging": {
        "LogLevel": {
            "Serenity.Data": "Debug"
        }
    }
    // ...
}
```

![SQL logging in debug console](img/sql-logging-debug-console.png)

# Adding Genre Selection to the Movie Form

Let's enhance the Movie form by adding a Genre selection field. To do this, make changes to the `MovieForm.cs` file as follows:

```csharp
//...
public class MovieForm
{
    //...
    public int GenreId { get; set; }
    public MovieKind Kind { get; set; }
}
```

Additionally, add the `GenreName` property to the `MovieColumns` class:

```csharp
//...
public class MovieColumns
{
    //...
    public string GenreName { get; set; }
    public MovieKind Kind { get; set; }
}
```

![Movie Dialog Integer Genre](img/movies-genre-int.png)

These changes add a `GenreId` field to the Movie form. However, if you build and run your application, you'll notice that this field currently accepts data as an integer input. What we actually want is to provide a dropdown selection for movie genres.

To achieve this, we need to specify the editor type for the `GenreId` field.

## Declaring a Lookup Script for Genres

To display a dropdown editor for the Genre field, you need to make the list of available genres from your database accessible on the client side. Unlike enumeration values, which can be easily transferred to the client-side by Sergen, a dynamic list like movie genres isn't as straightforward.

Serenity provides a feature known as "dynamic scripts," which allows you to make dynamic data, such as lists, available on the client side through runtime-generated scripts. You can learn more about dynamic scripts and lookups in [this topic](../../framework/dynamic-scripts/readme.md).

To declare a lookup script for the Genre table, open the `GenreRow.cs` file and modify it as shown below:

```csharp
[LookupScript]
public sealed class GenreRow : Row<GenreRow.RowFields>, IIdRow, INameRow
```

By adding the `[LookupScript]` attribute to the `GenreRow` class, you're specifying that a lookup script is associated with the Genre table.

It's important to note that lookups are recommended for small tables that change rarely. For large or frequently modified tables, it's better not to define a LookupScript and instead use `ServiceLookupEditor` which works via List service calls.

After making this change, rebuild your project and launch the application. Once you've logged in, open the developer console by pressing F12 in your browser.

Inside the console, type `Q.getLookup('MovieDB.Genre')`, and you'll receive an output similar to this:

![Movies Genre Lookup from Console](img/mdb_genre_getlookup.png)

The output displays the lookup data. This step demonstrates how to verify the availability of a lookup script on the client side.

The lookup key is automatically determined based on the module name and the entity class name. 

While you can implicitly specify the lookup key by using `[LookupScript("MovieDB.Genre")]`, it's generally recommended to let Serenity automatically determine the lookup key to prevent potential typing errors.

## Using the LookupEditor for the Genre Field

You have two options to specify the editor type for the `GenreId` field: one is to define it in the `MovieForm.cs` file, and the other is to do it in the `MovieRow.cs` file. While you can set it on the form level, it's generally preferred to define it in the row class because it's a more central location, and the information defined at this level can be reused in various parts of your application.

Keep in mind that the information defined on a form is specific to that form and cannot be reused elsewhere. For example, grids use information from `XYZColumn.cs` or `XYZRow.cs`, while dialogs rely on information in `XYZForm.cs` or `XYZRow.cs`. So, it's usually better to define such details in the `XYZRow.cs` file.

Open the `MovieRow.cs` file and add the `[LookupEditor]` attribute to the `GenreId` property as shown below:

```csharp
[DisplayName("Genre"), ForeignKey(typeof(GenreRow)), LeftJoin(jGenre)]
[LookupEditor(typeof(GenreRow))]
public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }
```

In this code, we specify `typeof(GenreRow)` in the `[LookupEditor]` attribute. This tells Serenity to locate the `LookupScript` attribute on the `GenreRow` class and automatically determine the lookup key.

If the `GenreRow` class does not have a `[LookupScript]` attribute, you'll encounter an error when you start the application. The error message will indicate that the `GenreRow` type doesn't have a `[LookupScript]` attribute, which is necessary for using a LookupEditor. Here's an example of the error message you might encounter:

```
Server Error in '/' Application.

'MovieTutorial.MovieDB.GenreRow' type doesn't have a 
[LookupScript] attribute, so it can't be used with a LookupEditor!

Parameter name: lookupType
```

While it is possible to specify the lookup key implicitly like this: `LookupEditor("MovieDB.Genre")`, it's not recommended because it can lead to typing errors. It's best to let Serenity automatically determine the lookup key as shown in the code above.

After building and launching your project, you'll have a searchable dropdown editor (using Select2.js) for the Genre field in your Movie form.

![Movie Form With Genre Editor](img/movie-form-with-genre-editor.png)

## Allowing In-Place Definition of a New Genre

When selecting a genre for a movie, you might encounter a situation where the desired genre is not available in the Genre dropdown list. In such cases, you'd typically need to switch to the Genres page, add the missing genre, and then return to the movie form, which can be cumbersome and disrupt the workflow.

Serenity provides a convenient way to define a new genre in-place directly from the movie form using lookup editors. To enable this feature, open the `MovieRow.cs` file and modify the `LookupEditor` attribute for the `GenreId` property as follows:

```csharp
[LookupEditor(typeof(GenreRow), InplaceAdd = true)]
public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }
```

By adding `InplaceAdd = true` to the `LookupEditor` attribute, you enable the ability to define a new genre directly from the form. Now, you'll see a star/pen icon next to the genre field, which allows you to define a new genre without leaving the movie form.

![Defining Genre In-Place](img/inplace-genre-dialog.png)

You can also start typing in the genre editor, and it will provide you with the option to add a new genre, making the process more user-friendly.

![Defining Genre by Searching](img/genre_inplace_search.png)

This feature is quite powerful, as it demonstrates that Serenity applications are composed of self-contained, reusable components, including dialogs, grids, editors, formatters, and more. These components are not tied to any specific page, providing flexibility and modularity to your application.

## How the Dialog Type is Determined

When you attempt to add a new genre in-place using the lookup editor, you may not have noticed that a new "GenreDialog" was automatically opened. This happened because the lookup editor followed a convention to determine which dialog type to use.

The lookup editor's lookup key is "MovieDB.Genre," so it searched for a dialog class with full names like this:

- `MovieDB.GenreDialog`
- `MovieTutorial.MovieDB.GenreDialog`

Fortunately, there's a "GenreDialog" class defined in the "Modules/Genre/GenreDialog.ts" file, and its registered full name is "MovieTutorial.MovieDB.GenreDialog":

```typescript
// ...
@Decorators.registerClass('MovieTutorial.MovieDB.GenreDialog')
export class GenreDialog extends EntityDialog<GenreRow, any> {
    // ...
}
```

If the lookup key for "GenreRow" and its dialog class didn't match, you'd get an error in the browser console as soon as you clicked the in-place add button:

```
Uncaught MovieDB.GenreDialog dialog class is not found!
```

To ensure the dialog type matches, either use a compatible lookup key like "*ModuleName*.*RowType*" or specify the dialog type explicitly in the `LookupEditor` attribute:

```csharp
[LookupEditor(typeof(GenreRow), InplaceAdd = true, DialogType = "MovieDB.Genre")]
public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }
```

You don't have to specify the "Dialog" suffix or the full namespace. Serenity automatically searches for them as long as they match the project root namespace. This convention simplifies the configuration process, making it more intuitive and straightforward.

## Adding Quick Filter for Genre in the Grid

As your list of movies grows, you may find it necessary to filter movies based on various criteria. In addition to the quick search functionality, Serenity offers several filtering methods. Let's use the Quick Filter method to filter movies by genre.

Edit the `MovieColumns.cs` file and add the `[QuickFilter]` attribute on top of the `GenreName` field as shown below:

```csharp
public class MovieColumns
{
    //...
    [Width(100), QuickFilter]
    public string GenreName { get; set; }
}
```

After making this change, build your project and navigate to the Movies page. You'll notice that a quick filtering dropdown for the genre field is now available:

![Genre Quick Filter](img/movies-genre-quick-filter.png)

Keep in mind that the field that is filtered is actually `GenreId`, not `GenreName`, even though we attached the `[QuickFilter]` attribute to the `GenreName` field. Serenity is intelligent enough to understand the relationship and determine the correct editor type to use based on the attributes of the `GenreId` property in the `GenreRow.cs` file. This ensures that filtering movies by genre using the genre name works seamlessly.