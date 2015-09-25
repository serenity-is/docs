
# Tutorial: Movie Database

Let's create editing interface for some site similar to IMDB with Serenity.

> You can find source code for this tutorial at: 

> https://github.com/volkanceylan/Serenity-Tutorials/tree/master/MovieTutorial



### Create a new project named *MovieTutorial*

In Visual Studio click File -> New Project. Make sure you choose *Serene* template. Type *MovieTutorial* as name and click *OK*.

In Solution explorer, you should see two projects with names *MovieTutorial.Web* and *MovieTutorial.Script*.

> Make sure *MovieTutorial.Web* is the startup project (it should be bold), if not right click on project name and click *Set As Startup Project*.



### What Are These Project Files?

Serenity applications usually has at least two projects. One for server side code plus static resources like css files, images etc. (MovieTutorial.Web) and one for client side code (MovieTutorial.Script).

MovieTutorial.Script looks like an ordinary C# class library but the code it contains is actualy compiled to Javascript using Saltarelle. 

> Its output (MovieTutorial.Script.js) will be copied to folder *Scripts/site/* under *MovieTutorial.Web*. So at runtime, only MovieTutorial.Web project is used.


### Customizing Field Captions

In our movie grid and form, we have a field named *Runtime*. This field expects an integer number in *minutes*, but in its title there is no sign of this. Let's change its title to Runtime (mins).

There are several ways to do this. Our options include server side form definition, server side columns definition, from script grid code etc. But let's make this change in the central location, the entity itself, so its title changes everywhere.

When Sergen generated code for Movie table, it created a entity class named MovieRow. You can find it at  *MovieTutorial.Web/Modules/MovieDB/Movie/MovieRow.cs*.

Here is an excerpt from its source with our Runtime property:

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movie"), InstanceName("Movie"), TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        // ...
        [DisplayName("Runtime")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }
        //...
    }
}
```

We'll talk about entities (or rows) later, let's now focus on our target and change its DisplayName attribute value to *Runtime (mins)":

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movie"), InstanceName("Movie"), TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        // ...
        [DisplayName("Runtime (mins)")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }
        //...
    }
}
```

Now build solution and run application. You'll see that field title is changed in both grid and dialog. 

> Column title has "..." in it as column is not wide enough, though its hint shows the full title. We'll see how to handle this soon.

![Movies Runtime (Mins)](img/movies_runtime_mins.png)


### Overriding Column Title and Width 


So far so good, what if we wanted to show another title in grid (columns) or dialog (form). We can override it corresponding definition file.

Let's do it on columns first. Next to *MovieRow.cs*, you can find a source file named *MovieColumns.cs*:

```cs
namespace MovieTutorial.MovieDB.Columns
{
    // ...

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        //...
        public Int32 Runtime { get; set; }
    }
}
```

You may notice that this columns definition is based on the Movie entity (BasedOnRow attribute).

Any attribute written here will override attributes defined in the entity class.

Let's add a DisplayName attribute to the *Runtime* property:

```cs
namespace MovieTutorial.MovieDB.Columns
{
    // ...

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        //...
        [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
        public Int32 Runtime { get; set; }
    }
}
```

Now we set column caption to "Runtime in Minutes". 

We actually added two more attributes. 

One to override column width to 150px.

> Serenity applies an automatic width to columns based on field type and character length, unless you set the width explicitly.

And another one to align column to right (AlignCenter, AlignLeft is also available).

Let's build and run again, than we get: 

![Movies Runtime Column](img/movies_runtime_column.png)

Form field title stayed same, while column title changed.

> If we wanted to override form field title instead, we would do similar steps in MovieForm.cs


### Changing Editor Type For Description and Storyline

Description and Storyline fields can be a bit longer compared to Title field, so lets change their editor types to a textarea.

Open *MovieForm.cs* in the same folder with *MovieColumns.cs* and *MovieRow.cs*.

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
    }
}
```

and add TextAreaEditor attributes to both:

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        public String Title { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
        [TextAreaEditor(Rows = 8)]
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
    }
}
```

I left more editing rows for Storyline (8) compared to Description (3) as Storyline should be much longer.

After rebuild and run, we have this:

![Movies TextArea Editors](img/movies_textarea_editors.png)

Serene has several editor types to choose from. Some are automatically picked based on field data type, while you need to explicitly set others.

> You can also develop your own editor types. You can take existing editor types as base classes, or develop your own from stratch. We'll see how in following chapters.

As editors became a bit higher, form height exceeded the default Serenity form height (which is set by Sergen to 260px) and now we have a vertical scroll bar. Let's remove it.

### Setting Initial Dialog Size With CSS (Less)

Sergen generated some CSS for our movie dialog in *MovieTutorial.Web/Content/site/site.less* file.

If you open it, and scroll to bottom, you will see this:

```cs
/* ------------------------------------------------------------------------- */
/* APPENDED BY CODE GENERATOR, MOVE TO CORRECT PLACE AND REMOVE THIS COMMENT */
/* ------------------------------------------------------------------------- */

.s-MovieDialog {
    > .size { .widthAndMin(650px); }
    .dialog-styles(@h: auto, @l: 150px, @e: 400px);
    .s-PropertyGrid .categories { height: 260px; }
}
```

You can safely remove the 3 comment lines (appended by code generator...). This is just a reminder for you to move them to a better place like a *site.movies.less* file specific to this module (recommended).

These rules are applied to elements with *.s-MovieDialog* class. Our Movie dialog has this class by default. 

In the second line it is specified that this dialog is 650px wide (and also its minimum width is 650px, this will get some meaning after we make this dialog resizable).

In third line, we specify that dialog height should be automatic (@h: auto), field labels should be 150px (@l: 150px) and editors should be 400px in width (@e: 400px).

We are using several less mixins here (widthAndMin and dialog-styles).

Our form height is controlled by *s-PropertyGrid .categories { height: 260px; }* line. Let's change it to 400px so it won't require a vertical scroll bar.

```css
.s-MovieDialog {
    > .size { .widthAndMin(650px); }
    .dialog-styles(@h: auto, @l: 150px, @e: 400px);
    .s-PropertyGrid .categories { height: 400px; }
}
```


### Changing Page Title

Our page has title of *Movie*. Let's change it to Movies. 

Open *MovieRow.cs* again. 

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movie"), InstanceName("Movie"), TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
```

Change DisplayName attribute value to *Movies*. This is the name that is used when this table is referenced, and it is usually a plural name. This attribute is used for determining default page title. 

> It is also possible to override the page title in *MoviePage.Index.cshtml* file but as before, we prefer to do it from a central location so that this information can be reused in other places.

InstanceName corresponds to singular name and is used in New Record (New Movie) button of the grid and determines the dialog title (e.g. Edit Movie).

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    [ConnectionKey("Default"), DisplayName("Movies"), InstanceName("Movie"), TwoLevelCached]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
```


### Setting Navigation Item Title and Icon

When Sergen generated code for Movie table, it also created a navigation item entry. In Serene, navigation items are created with special assembly attributes.

Open *MoviePage.cs* in the same folder, on top of it you'll find this line:

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MovieDB/Movie", 
    typeof(MovieTutorial.MovieDB.Pages.MovieController))]

namespace MovieTutorial.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;

```

First argument to this attribute is display order for this navigation item. As we only have one navigation item in Movie category yet, we don't have to mess with ordering yet.

Second parameter is navigation title in "Section Title/Link Title" format. Section and navigation items are seperated with a slash (/).

Lets change it to *Movie Database/Movies*.

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Movie Database/Movies", 
    typeof(MovieTutorial.MovieDB.Pages.MovieController), icon: "icon-camcorder")]

namespace MovieTutorial.MovieDB.Pages
{

//..
```

![Navigation Item Title and Icon](img/movies_navigation_links.png)

We also changed navigation item icon to *icon-camcorder*. Serene template has two sets of font icons, Simple Line Icons and Font Awesome. Here we used a glyph from simple line icons set. 

To see list of simple line icons and their css classes, visit link below:

http://thesabbir.github.io/simple-line-icons/

FontAwesome is available here:

https://fortawesome.github.io/Font-Awesome/icons/


### Ordering Navigation Sections

As our *Movie Database* section is auto generated last, it is displayed at the bottom of navigation menu.

We'll move it before Northwind menu.

As we saw recently, Sergen created a navigation item in *MoviePage.cs*. If navigation items are scattered through pages like this, it would be hard to see the big picture (list of all navigation items) and order them easily.

So we move it to our central location which is at *MovieTutorial.Web/Modules/Common/Navigation/NavigationItems.cs*.

Just cut the below lines from *MoviePage.cs*:

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Movie Database/Movies", 
    typeof(MovieTutorial.MovieDB.Pages.MovieController), icon: "icon-camcorder")]
```

Move it into *NavigationItems.cs* and modify it like this:

```
using Serenity.Navigation;
using Northwind = MovieTutorial.Northwind.Pages;
using Administration = MovieTutorial.Administration.Pages;
using MovieDB = MovieTutorial.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", 
    typeof(MovieDB.MovieController), icon: "icon-camcorder")]

[assembly: NavigationMenu(8000, "Northwind", icon: "icon-anchor")]
[assembly: NavigationLink(8200, "Northwind/Customers", 
    typeof(Northwind.CustomerController), icon: "icon-wallet")]
[assembly: NavigationLink(8300, "Northwind/Products", 
    typeof(Northwind.ProductController), icon: "icon-present")]
// ...
```

Here we also declared a navigation menu (Movie Database) with *film* icon. When you don't have an explicitly defined navigation menu, Serenity implicitly creates one, but in this case you can't order menu yourself, or set menu icon.

We assigned it a display order of *2000* so this menu will display just after Dashboard link (1000) but before Northwind menu (8000).

We assigned our *Movies* link a display order value of *2100* but it doesn't matter right now, as we have only one navigation item under *Movie Database* menu yet.

> First level links and navigation menus are sorted according to their display order first, then second level links among their siblings.

Here is how it looks like after these changes:

![Movie Database Moved](img/movies_navigation_moved.png)


### Troubleshooting Some Issues with Visual Studio

In case you didn't notice already, Visual Studio doesn't let you modify code while your site is running. Also your site stops when you stop debugging, so you can't keep browser window open and refresh after rebuilding.

To solve this issue, we need to disable *Edit And Continue* (have no idea why).

Right Click *MovieTutorial.Web* project, click *Properties*, in the Web tab, uncheck *Enable Edit And Continue* under *Debuggers*.

Also, on your site, top blue progress bar (which is a Pace.js animation), keeps running all the time like it is still loading something. It is thanks to the *Browser Link* feature of Visual Studio. To disable it, locate its button in Visual Studio toolbar that looks like a refresh button (next to play icon with browser name like Chrome), click dropdown and uncheck *Enable Browser Link*.

It's also possible to disable it with a web.config setting 

```xml
<appsettings>
    <add key="vs:EnableBrowserLink" value="false" />
</appsettings>
```

> Serene 1.5.4 and later will have this by default, so you might not experience this issue


### Adding Several Movie Entries

For the following sections, we need some sample data. We can copy and paste some from IMDB.

If you don't want to waste your time entering this sample data, it is available as a migration at the link below:

> https://github.com/volkanceylan/Serenity-Tutorials/blob/master/MovieTutorial/MovieTutorial/MovieTutorial.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20150923_172700_SampleMovies.cs


![7 Movies Entered](img/movies_data_7.png)

If we typed *go* into search box, we would see two movies are filtered: *The Good, the Bad and the Ugly* and *The Godfather*.

If we typed *Gandalf* we wouldn't be able to find anything. 

By default, Sergen determines first textual field of a table as *the name field*. In movies table it is *Title*. This field has a *QuickSearch* attribute on it that specifies that text searches should be performed on it.

> The name field is also determines initial sorting order and shown in edit dialog titles. 

Sometimes, first textual column might not be the name field. If you wanted to change it to another field, you would do it in *MovieRow.cs*:

```cs

namespace MovieTutorial.MovieDB.Entities
{
    //...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        //...
        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }
}
```

Code generator determined that first textual (string) field in our table is Title. So it added a INameRow interface to our Movies row and implemented it by returning Title field. If wanted to use Description as name field, we would just replace it.

Here, *Title* is actually the name field, so we leave it as is. But we want Serenity to search also in *Description* and *Storyline* fields. To do this, you need to add *QuickSearch* attribute to these fields too, as shown below:

```
namespace MovieTutorial.MovieDB.Entities
{
    //...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        //...
        [DisplayName("Title"), Size(200), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Storyline"), QuickSearch]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }
        //...
    }
}
```

Now, if we search for *Gandalf*, we'll get a *The Lord of the Rings* entry:

![Movies Search Gandalf](img/movies_search_gandalf.png)

QuickSearch attribute, by default, searches with *contains* filter. It has some options to make it match by *starts with* filter or match only exact values.

If we wanted it to show only rows that *starts with* typed text, we would change attribute to:

```cs
[DisplayName("Title"), Size(200), NotNull, QuickSearch(SearchType.StartsWith)]
public String Title
{
    get { return Fields.Title[this]; }
    set { Fields.Title[this] = value; }
}
```

> Here this quick search feature is not very useful, but for values like SSN, serial number, identification number, phone number etc, it might be.

If we wanted to search also in year column, but only exact integer values (1999 matches but not 19):

```
[DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
public Int32? Year
{
    get { return Fields.Year[this]; }
    set { Fields.Year[this] = value; }
}
```

> You might have noticed that we are not writing any C# or SQL code for these basic features to work. We just specify what we want, rather than how to do it. This is what declarative programming is. 

It is also possible to provide user with ability to determine which field she wants to search on.

Open *MovieTutorial.Script/MovieDB/Movie/MovieGrid.cs* and modify it like:

```

namespace MovieTutorial.MovieDB
{
    //...
    public class MovieGrid : EntityGrid<MovieRow>
    {
        public MovieGrid(jQueryObject container)
            : base(container)
        {
        }

        protected override List<QuickSearchField> GetQuickSearchFields()
        {
            return new List<QuickSearchField>
            {
                new QuickSearchField { Name = "", Title = "all" },
                new QuickSearchField { Name = "Description", Title = "description" },
                new QuickSearchField { Name = "Storyline", Title = "storyline" },
                new QuickSearchField { Name = "Year", Title = "year" }
            };
        }
    }
    ///...
}
```

Now we have a dropdown in quick search input:

![Movies Quick Search Fields](img/movies_quick_fields.png)

> Unlike prior samples where we modified Server side code, this time we did changes in Script side, and actually modified javascript code.



### Running T4 Templates (.tt files)

In prior sample we harcoded field names like *Description*, *Storyline* etc. This may lead to typing errors if we forgot actual property names at server side.

Serene contains some T4 (.tt) files to transfer such information from server side (rows etc) to client side for intellisense purposes.

Before running these templates, please make sure that your solution builds successfully as templates uses your output DLL files (*MovieTutorial.Web.dll*, *MovieTutorial.Script.dll*) to generate code.

After building your solution, click on *Build* menu, than *Transform All Templates*.

If you try to build your solution now, you will get an error.

```
Error CS0579 Duplicate 'Imported' attribute MovieTutorial.Script ...\MovieDB.MovieRow.cs	
```

on file MovieTutorial.Script/MovieDB/Movie/MovieGrid.cs:

```cs
// Please remove this partial class or the first line below, after you run ScriptContexts.tt
[Imported, Serializable, PreserveMemberCase] 
public partial class MovieRow
{
}
```

This was just a placeholder for MovieRow from server side and our *ServiceContracts.tt* file generated its up to date version at *MovieTutorial.Script/Imports/ServiceContracts.tt/MovieDB.cs*.

Now you can safely remove these lines from *MovieGrid.cs* as specified on comment line.

We can use intellisense to replace hardcoded field names with compile time checked versions:

```cs
namespace MovieTutorial.MovieDB
{
    // ...
    public class MovieGrid : EntityGrid<MovieRow>
    {
        public MovieGrid(jQueryObject container)
            : base(container)
        {
        }

        protected override List<QuickSearchField> GetQuickSearchFields()
        {
            return new List<QuickSearchField>
            {
                new QuickSearchField { Name = "", Title = "all" },
                new QuickSearchField { Name = MovieRow.Fields.Description, 
                    Title = "description" },
                new QuickSearchField { Name = MovieRow.Fields.Storyline, 
                    Title = "storyline" },
                new QuickSearchField { Name = MovieRow.Fields.Year, 
                    Title = "year" }
            };
        }
    }
}
```

> We are planning to introduce support by code generator to produce code compatible with T4 files, so you might not have to delete these lines in later versions.


### Adding a Movie Kind Field

If we wanted to also keep TV series and mini series in our movie table, we would need another field to store it: *MovieKind*.

As we didn't add it while creating the Movie table, now we'll write another migration to add it to our database.

Create another migration file under *MovieTutorial.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20150924_142200_MovieKind.cs*:

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20150924142200)]
    public class DefaultDB_20150924_142200_MovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}
```


### Declaring a MovieKind Enumeration

Now as we added *Kind* column to *Movie* table, we need a set of movie kind values. Let's define it as an enumeration at *MovieTutorial.Web/Modules/MovieDB/Movie/MovieKind.cs*:

```cs
using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieTutorial.MovieDB
{
    [EnumKey("MovieDB.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")]
        Film = 1,
        [Description("TV Series")]
        TvSeries = 2,
        [Description("Mini Series")]
        MiniSeries = 3
    }
}
```


### Adding Kind Field to MovieRow Entity

As we are not using Sergen anymore, we need to add a mapping in our MovieRow.cs for *Kind* column manually. Add following property declaration in MovieRow.cs after *Runtime* property:

```cs
[DisplayName("Runtime (mins)")]
public Int32? Runtime
{
    get { return Fields.Runtime[this]; }
    set { Fields.Runtime[this] = value; }
}

[DisplayName("Kind"), NotNull]
public MovieKind? Kind
{
    get { return (MovieKind?)Fields.Kind[this]; }
    set { Fields.Kind[this] = (Int32?)value; }
}
```

We also need to declare a Int32Field object which is required for Serenity entity system. On the bottom of MovieRow.cs locate *RowFields* class and modify it to add *Kind* field after the *Runtime* field:

```cs
public class RowFields : RowFieldsBase
{
    // ...
    public readonly Int32Field Runtime;
    public readonly Int32Field Kind;

    public RowFields()
        : base("[mov].Movie")
    {
        LocalTextPrefix = "MovieDB.Movie";
    }
}
```


### Adding Kind Selection To Our Movie Form

If we build and run our project now, we'll see that there is no change in the Movie form, even if we added *Kind* field mapping to the *MovieRow*. This is because, fields shown/edited in the form are controlled by declerations in *MovieForm.cs*. 

Modify *MovieForm.cs* as below:

```cs

namespace MovieTutorial.MovieDB.Forms
{
    // ...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        // ...
        public Int32 Runtime { get; set; }
        public MovieKind Kind { get; set; }
    }
}
```

Now, build your solution and run it. When you try to edit a movie or add a new one, nothing will happen. This is an expected situation. If you check developer tools console of your browser (F12, inspect element etc.) you'll see such an error:

```txt
Uncaught Can't find MovieTutorial.MovieDB.MovieKind enum type!
```

This error is caused by MoveKind enumeration not available client side. We should run our T4 templates before executing our program.

Now in Visual Studio, click *Build -> Transform All Templates* again.

Rebuild your solution and execute it. Now we have a nice dropdown in our form to select movie kind.

![Movie Kind Selection](img/movies_kind_selection.png)


### Declaring a Default Value for Movie Kind

As *Kind* is a required field, we need to fill it in *Add Movie* dialog, otherwise we'll get a validation error.

But most movies we'll store are feature films, so its default should be this value.

To add a default value for *Kind* property, add a *DefaultValue* attribute like this:

```cs
[DisplayName("Kind"), NotNull, DefaultValue(1)]
public MovieKind? Kind
{
    get { return (MovieKind?)Fields.Kind[this]; }
    set { Fields.Kind[this] = (Int32?)value; }
}
```

Now, in *Add Movie* dialog, *Kind* field will come prefilled as *Film*.


### Adding Genre Field

To hold Movie genres we need a lookup table. For *Kind* field we used an enumeration but this time genres might not be that *static* to declare them as an enumeration.

As usual, we start with a migration.

*MovieTutorial.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20150924_151600_GenreTable.cs*:

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20150924151600)]
    public class DefaultDB_20150924_151600_GenreTable : Migration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable();
        }

        public override void Down()
        {
        }
    }
}
```

We also added a *GenreId* field to *Movie* table.

> Actually a movie can have multiple genres so we should keep it in a separate *MovieGenres* table. But for now, we think it as single. We'll see how to change it to multiple later.


### Generating Code For Genre Table

Fire sergen.exe using Package Manager Console again and generate code for *Genre* table with the parameters shown below:

![Genre Code Genreation](img/movies_sergen_genre.png)


Rebuild solution and run it. We'll get a new page like this:

![Genre Initial Page](img/movies_genre_first.png)

As you see in screenshot, it is generated under a new section *MovieDB* instead of the one we renamed recently: *Movie Database*.

This is because *Sergen* has no idea of what customizations we performed on our *Movie* page. So we need to movie it under *Movie Database* manually.

Open *MovieTutorial.Web/Modules/Movie/GenrePage.cs*, cut the navigation link shown below:

```cs
[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MovieDB/Genre",
    typeof(MovieTutorial.MovieDB.Pages.GenreController))]

````

And move it to *MovieTutorial.Web/Modules/Common/Navigation/NavigationItems.cs*:

```cs
//...
[assembly: NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", typeof(MovieDB.MovieController), icon: "icon-camcorder")]
[assembly: NavigationLink(2200, "Movie Database/Genres", typeof(MovieDB.GenreController), icon: "icon-pin")]
//...

```


### Adding Several Genre Definitions 

Now let's add some sample genres. I'll do it through migration, to not to repeat it in another PC, but you might want to add them manually through Genre page.

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20150924154100)]
    public class DefaultDB_20150924_154100_SampleGenres : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new
                {
                    Name = "Action"
                })
                .Row(new
                {
                    Name = "Drama"
                })
                .Row(new
                {
                    Name = "Comedy"
                })
                .Row(new
                {
                    Name = "Sci-fi"
                })
                .Row(new
                {
                    Name = "Fantasy"
                })
                .Row(new
                {
                    Name = "Documentary"
                });
        }

        public override void Down()
        {
        }
    }
}
```


### Mapping GenreId Field in MovieRow

As we did with *Kind* field before, *GenreId* field needs to be mapped in *MovieRow.cs*.

```cs

namespace MovieTutorial.MovieDB.Entities
{
    // ...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Kind"), NotNull, DefaultValue(1)]
        public MovieKind? Kind
        {
            get { return (MovieKind?)Fields.Kind[this]; }
            set { Fields.Kind[this] = (Int32?)value; }
        }

        [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Genre"), Expression("g.Name")]
        public String GenreName
        {
            get { return Fields.GenreName[this]; }
            set { Fields.GenreName[this] = value; }
        }

        // ...

        public class RowFields : RowFieldsBase
        {
            // ...
            public readonly Int32Field Kind;
            public readonly Int32Field GenreId;
            public readonly StringField GenreName;

            public RowFields()
                : base("[mov].Movie")
            {
                LocalTextPrefix = "MovieDB.Movie";
            }
        }
    }
}
```

Here we mapped *GenreId* field and also declared that it has a foreign key relation to *GenreId* field in *[mov].Genre* table using *ForeignKey* attribute.

> If we did generate code for Movie table after we added this Genre table, Sergen would understand this relation by checking foreign key definition at database level, and generate similar code for us.

We also added another field, *GenreName* that is not actually a field in *Movie* table, but in *Genre* table. 

Serenity entities is more like SQL views. You can bring in fields from other tables with joins.

By adding *LeftJoin("g")* attribute to MovieId property, we declared that whenever Genre table needs to be joined to, its alias will be *g*.

So when Serenity needs to select from *Movies* table, it will produce an SQL query like this:

```sql
SELECT t0.MovieId, t0.Kind, t0.GenreId, g.Name as GenreName 
FROM Movies t0
LEFT JOIN Genre g on t0.GenreId = g.GenreId 

```

> This join will only be performed if a field from Genre table requested to be selected, e.g. its column is visible in a data grid.

By adding *Expression("g.Name")* on top of *GenreName* property, we specified that this field has an SQL expression of *g.Name*, thus it is a field from our *g* join.

### Adding Genre Selection To Movie Form

Let's add GenreId field to our form in *MovieForm.cs*:

```cs

namespace MovieTutorial.MovieDB.Forms
{
    //...
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieForm
    {
        //...
        public Int32 GenreId { get; set; }
        public MovieKind Kind { get; set; }
    }
}
```

Now if we build and run application, we'll see that a Genre field is added to our form. Problem is it accepts data entry as an integer. We want it to use a dropdown.

It's clear that we need to change editor type for GenreId field.


### Declaring a Lookup Script for Genres

To show an editor for *Genre* field, list of genres in our database should be available at client side.

For enumeration values, it was simple, we just run T4 templates, and they copied enum declaration to script side.

Here we can't do the same. Genre list is a database based dynamic list.

Serenity has notion of *dynamic scripts* to make dynamic data available to script side in the form of runtime generated scripts.

> Dynamic scripts are similar to web services, but their output are dynamic javascript files that can be cached on client side.

To declare a dynamic lookup script for Genre table, open *GenreRow.cs* and modify it like below:

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...

    [ConnectionKey("Default"), DisplayName("Genre"), InstanceName("Genre"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("MovieDB.Genre")]
    public sealed class GenreRow : Row, IIdRow, INameRow
    {
        // ...
    }
```

We just added line with *[LookupScript("MovieDB.Genre")]*.

Rebuild your project, launch it, after logging in, open developer console by *F12*.

Type *Q.getLookup('MovieDB.Genre')

and you will get something like this:

![Movies Genre Lookup from Console](img/movies_genre_lookup_console.png)

Here *MovieDB.Genre* is the lookup key we assigned to this lookup script when declaring it with:

> [LookupScript("MovieDB.Genre")]

This step was just to show how to check if a lookup script is available client side.


### Using LookupEditor for Genre Field

There are two places to set editor type for GenreId field. One is MovieForm.cs, other is MovieRow.cs.

I usually prefer the latter, as it is the central place, but you may choose to set it on a form, if that editor type is specific to that form only.

Open MovieRow.cs and add *LookupEditor* attribute to *GenreId* property as shown below:

```cs
    [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
    [LookupEditor("MovieDB.Genre")]
    public Int32? GenreId
    {
        get { return Fields.GenreId[this]; }
        set { Fields.GenreId[this] = value; }
    }

```

After we build and launch our project, we'll now have a searchable dropdown (Select2.js) on our Genre field.

![Movie Form With Genre Editor](img/movies_form_with_genre_editor.png)

