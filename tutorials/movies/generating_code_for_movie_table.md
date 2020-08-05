
# Generating Code For Movie Table

## Serenity Code Generator

After making sure that our table exists in the database, we will use Serenity Code Generator (sergen.exe) to generate initial editing interface.

As ASP.NET Core has cross-platform support, .NET Core version of Sergen also needs to run in OSX / Linux / Windows. Thus, its UI is currently console based.

We first need to open a command prompt at project folder. Right click *MovieTutorial.Web* project and click *Open Folder in File Explorer*.

Click *File* menu in file explorer, and click *Open Windows Powershell* or *Open Command Prompt*.

> You may also install this extension (https://marketplace.visualstudio.com/items?itemName=MadsKristensen.OpenCommandLine) to easily open a command line next time. I can't understand why there is still not such an option in Visual Studio itself.

Make sure you are at `MovieTutorial.Web` directory.

Type `dotnet sergen g` to open Sergen code generation UI (console).

![Dotnet Sergen G](img/dotnetsergeng.png)

> If you receive an error, type `dotnet restore` and `dotnet tool restore` before running sergen.

Sergen will list connections in appsettings.json file.

You can use TAB completion, e.g. type *D* and press *TAB* to complete *Default*.

After pressing Enter you'll get a list of tables in that database:

![Dotnet Sergen G](img/dotnetsergencon.png)

Clear `dbo.` using backspace, and type `mov.Movie` or type `m` and use TAB completion to select `mov.Movie`, then press *ENTER*.

Next, Sergen will ask for a module name, enter *MovieDB*.

> In Serenity terms, a module is a logical group of pages, sharing a common purpose. 
>
>For example, in Serene template, all pages related to *Northwind* sample belongs to *Northwind* module. 
>
>Pages that are related to general management of site, like users, roles etc. belongs to *Administration* module. 
>
>A module usually corresponds to a database schema, or a single database but there is nothing that prevents you from using multiple modules in a single database / schema, or the opposite, multiple databases in one module.
>
>For this tutorial, we will use *MovieDB* (analogous to IMDB) for all pages.
>
>Module name is used in determining namespace and url of generated pages.
>
>For example, our new page will be under *MovieTutorial.MovieDB* namespace and will use */MovieDB* relative url.
>
>#### Please Note!
>
>Module names must be in Pascal case, e.g. something that starts with a CAPITAL letter. `myModule`, `mycoolmodule`, `aModule` are invalid module names. `MyCoolModule` is fine.

When prompted, enter *Movie* as class identifier.

> This usually corresponds to the table name but sometimes table names might have underscores or other invalid characters, so you decide what to name your entity in generated code (a valid identifier name).
>
> Our table name is *Movie* so it is also a valid and fine C# identifier, so let's leave *Movie* as the entity identifier. Our entity class will be named *MovieRow*.
>
> This name is also used in other class names. For example our page controller will be named *MovieController*.
> It also determines the page url, in this sample our editing page will be at URL */MovieDB/Movie*.
>
> #### Please Note!
>
>Identifier must always be in Pascal case, e.g. something that starts with a CAPITAL letter. `myTable`, `mycoolTable`, `aTable` are *invalid* identifier names. `MyCoolTable` is OK.

Leave permission as *Administration:General* and press enter again.

![Dotnet Sergen G](img/dotnetsergenprm.png)

> In Serenity, access control to resources (pages, services etc.) are controlled by permission keys which are simple strings. Users or roles are granted these permissions.
>
>Our Movie page will be only used by administrative users (or maybe later content moderators) so let's leave it as *Administration:General* for now. By default, in Serene template, only the *admin* user has this permission

Next, Sergen will ask you which files to generate, leave default **RSU** option (e.g. Row, Service and User Interface) and press ENTER last time.

> If you don't need UI for some entity, just type **RS**. 
>
> If you just want an entity class, and not a repository / service access, type only **R**.

Now you can quit command prompt, and return back to Visual Studio (or Notepad :)

## After Generating Code

> If Visual Studio asks if you want to reload changes, click Reload All.

*REBUILD the Solution* and then press *F5* to launch application.

Use *admin* as username, and *serenity* as password to login.

When you are greeted with Dashboard page, you will notice that there is a new section, *MovieDB* on the bottom of left navigation. 

Click to expand it and click Movie to open our first generated page.

![Movies First Generation](img/mdb_movie_initial.png)

Now try adding a new movie, than try updating and deleting it.

Sergen generated code for our table, and it just works without writing a single line of code.

> This doesn't mean i don't like writing code. In contrast, i love it. Actually i'm not a fan of most designers and code generators. The code they produce is usually unmanagable mess. 

> Sergen just helped us here for initial setup which is required for layered architecture and platform standards. We would have to create about 10 files for entity, repository, page, endpoint, grid, form etc. Also we needed to do some setup in a few other places.

> Even if we did copy paste and replace code from some other page, it would be error prone and take about 5-10 mins.

> The code files Sergen generates has minimum code with the absolute basics. This is thanks to the base classes in Serenity that handles the most logic. Once we generate code for some table, we'll probably never use Sergen again (for this table), and modify this generated code to our needs. We'll see how.

