# Updating Serenity Packages (ASP.NET MVC Version)

When i started writing this tutorial, Serenity was at version 2.1.8.

When you read this you are probably using a later version, so you might not have to update serenity yet.

But, i want to show how you can update Serenity NuGet packages, in case another version comes out in the future.

I prefer to work with NuGet from *Package Manager Console* instead of using NuGet GUI interface as it performs much faster.

Click *View -> Other Windows -> Package Manager Console*.

Type:

> Update-Package Serenity.Web
> Update-Package Serenity.Scripts
> Update-Package Serenity.Web.Assets

This will also update following NuGet packages in *MovieTutorial.Web* because of dependencies:

```txt
Serenity.Core
Serenity.Data
Serenity.Data.Entity
Serenity.Services
```

To update Serenity.CodeGenerator (e.g. *dotnet sergen* tool), open a console window in project directory and type:

> dotnet tool update sergen

> During updates, if NuGet asks to override changes in some script files, you can safely say yes unless you did manual modifications to Serenity script files (which i suggest you avoid).

To update Serenity.CodeGenerator (e.g. *dotnet sergen* tool) and script files that comes with Serenity, open a console window in project directory and type:

> dotnet tool update sergen\
> dotnet restore\
> dotnet sergen restore

# Updating Serenity Packages (alternative approach by editing CSPROJ file)

Theorically, you should be able to update Serenity by using NuGet package manager console, but it might not work, probably due to some conditionals in CSPROJ file confusing NuGet.
 
Right click your project file, click *Edit MySerene.csproj*:

```xml
<PackageReference Include="Serenity.Web" Version="3.0.5" />
<PackageReference Include="Serenity.Web.Assets" Version="3.0.5" />
<PackageReference Include="Serenity.Scripts" Version="3.0.5" />
```

Find three lines that include *Serenity.Web*, *Serenity.Web.Assets* and *Serenity.Scripts* like shown above and change their versions to latest *Serenity* version.

Open a command prompt in your project directory and type these two lines:

```cmd
dotnet tool update sergen
dotnet restore
dotnet sergen restore
```

### Building Project

Now rebuild your solution and it should build successfully.

> From time to time, breaking changes might happen in Serenity, but they are kept to minimum, and you might have to do a few manual changes in your application code. 

> Such changes are documented with a [BREAKING CHANGE] tag in change log at:\
> https://github.com/serenity-is/Serenity/blob/master/CHANGELOG.md

> If you still have a problem after upgrade, feel free to ask in discussions at:\
> https://github.com/serenity-is/Serenity/discussions


### What Is Updated

Updating Serenity NuGet packages, takes Serenity assemblies up to the latest version.

It might also update some other third-party packages like ASP.NET Core, FluentMigrator, Select2.js, SlickGrid etc.

> Please don't update Select2.js to a version after 3.5.1 yet as it has some compability problems.

Serenity.Scripts and Serenity.Web.Assets packages also comes with some static script and css resources like the following:

```
Content/serenity/serenity.css
Scripts/serenity/Serenity.CoreLib.js
```

> These files are updated using `dotnet sergen restore`. NuGet itself does not support static files in NuGet packages to be installed / updated on application itself.

So, these and a few more are also updated in MovieApplication.Web.


### What Is Not Updated (OR Can't Be Updated Automatically)

Updating Serenity packages, updates Serenity assemblies and most static scripts, but not all *Serene* template content is updated.

We are trying to keep updating your application as simple as possible, but Serene is just a project template, not a static package. Your application is a customizable copy of Serene.

You might have done modifications to application source, so updating a Serene application created with an older version of Serene template, might not be as easy as it sounds.

Sometimes you might have to create a new Serene application with up-to-date Serene template version, and compare it to your application, and merge features you need. This is a manual process.

Usually, updating Serenity packages is enough. Updating Serene itself is not required unless you need some recent features from latest Serene version.

> We have some plans to make parts of Serene template also a NuGet package, but it is still not trivial how to update your application without overriding your changes, e.g. to shared code like Navigation items. And what if you removed Northwind code, but our update reinstalls it? Open to discussion...