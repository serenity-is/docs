# How To: Update Serenity NuGet Packages

Serene template contains references to following Serenity NuGet packages:

```
Serenity.Core
Serenity.Data
Serenity.Data.Entity
Serenity.Services
Serenity.Web
Serenity.Web.Assets
Serenity.Web.Tooling
Serenity.CodeGenerator
```

To update Serenity packages to latest version, open package manager console (click View -> Other Windows -> Package Manager Console).

And type following:

```ps
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
Update-Package Serenity.Web.Tooling
```

Updating these two packages will also update others (because of dependencies).