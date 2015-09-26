# How To: Update Serenity NuGet Packages

Serene template contains references to following Serenity NuGet packages:

```
Serenity.Core
Serenity.Data
Serenity.Data.Entity
Serenity.Services
Serenity.Web
Serenity.CodeGenerator

Serenity.Script
```

If your solution name is MyProject, Serenity.Script package is referenced in MyProject.Script while others are used in MyProject.Web.

To update Serenity packages to latest version, open package manager console (click View -> Other Windows -> Package Manager Console).

And type following:

```ps
Update-Package Serenity.Web

Update-Package Serenity.CodeGenerator

Update-Package Serenity.Script
```