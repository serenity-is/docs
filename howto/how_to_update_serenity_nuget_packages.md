# How To: Update Serenity NuGet Packages

Serene template contains references to following Serenity NuGet packages:

```
Serenity.Core
Serenity.Data
Serenity.Data.Entity
Serenity.Services
Serenity.Web
Serenity.Web.Assets
Serenity.Scripts
```

and also a global tool:

`dotnet sergen`

To update Serenity packages to latest version, open package manager console (click View -> Other Windows -> Package Manager Console).

And type following:

```ps
Update-Package Serenity.Web
Update-Package Serenity.Web.Assets
Update-Package Serenity.Scripts
```
Updating these packages will also update others (because of dependencies).

Open a command line in project directory and type these:

```ps
dotnet tool update sergen
dotnet restore
dotnet sergen restore
```

> The last line is critical as `dotnet sergen restore` is the command that updates script/css files in your project to latest version. NuGet itself can't update static files in .NET Core projects.
