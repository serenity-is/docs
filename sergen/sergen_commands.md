# Serenity Code Generator

Serenity has code  generator what generates row, form, grid, page, services, client typings and server typings. It's already installed in Serene and StartSharp templates. 

[Sergen on Nuget.org](https://www.nuget.org/packages/sergen/)

## Installation:
---
```sh 
$ dotnet tool install sergen
```

## Usage
---

Ensure your console working directory is in your web project.

```sh
$ cd /projects/Serene/Serene.Core/
$ dotnet sergen
Serenity Code Generator 5.0.7.0

Usage: sergen [command]

Commands:
    g[enerate]        Launches table code generator
    r[estore]         Restores content, e.g. scripts, fonts and css from .nupkg

    c[lienttypes]     Imports editor, formatter types from TypeScript to CS
    m[vc]             Generates intellisense helpers for view locations
    s[ervertypings]   Imports row, form, service types from CS to TypeScript
    t[ransform]       Runs clienttypes, mvc and servertypings commands at once
```

### Restoring contents for serenity
---

Serenity distribute contents from nuget packages, but it's needs restore operation for effect your project. For example, lets say Serenity.Scripts has new content and bug fixes in typescript code, when you update `Serenity.Scripts` nuget package on your project, you still seeing the previous contents. After sergen restore operation your contents are updated and you can access latest content.  

```sh
$ dotnet sergen restore
  Determining projects to restore...
  Restored /projects/Serene/Serene.Core/Serene.Core.csproj (in 39.92 sec).
Processing: Mapster
Processing: StackExchange.Exceptional.AspNetCore
Processing: Serenity.FluentMigrator.Runner
Processing: Serenity.Scripts
Processing: Serenity.Web
Processing: Serenity.Web.Assets
Restoring: wwwroot/fonts/glyphicons-halflings-regular.svg
Processing: StackExchange.Exceptional.Shared
Processing: Serenity.Core
Processing: Serenity.Data
Processing: Serenity.Data.Entity
Processing: Serenity.Services
Processing: jQuery
Processing: jQuery.UI.Combined
Processing: jQuery.Validation
Processing: bootstrap
Restoring: wwwroot/fonts/glyphicons-halflings-regular.svg
Processing: toastr
Processing: Select2.js
```

### Generating ClientTypes
---

Client Types are attributes what used in server side as definition, like editors, formatters etc. For example, when you create a custom editor, it's must registered as editor with `@Serenity.Decorators.registerEditor()` . Then `sergen` is collects that "editors" from your `.ts` files. It's creates attribute `.cs` files. This attributes are used on properties in `SampleForm.cs` or `SampleRow.cs` files mostly.

```sh
$ dotnet sergen clienttypes
Transforming ClientTypes at: /projects/Serene/Serene.Core/Imports/ClientTypes
```

### Generating ServerTypings
---

Server Types are codes what generated on client side. It's will include grid columns, forms, rows, services, enums, permissions, request objects and response objects etc. For example, when you create a `enum` at c# and then add `ScriptInclude` attribute on it, `sergen` generates this `enum` for `typescript`.

```sh
$ dotnet sergen servertypings
Transforming ServerTypings at: /projects/Serene/Serene.Core/Imports/ServerTypings
```

### Generates intellisense helpers for view locations
---

Sergen can create helpers for "view file" paths. Serenity uses `*.cshtml` files under module directory. So when you want to use it from controller, you need to write full path instead of mvc convension. This helpers are for make easy to access your cshtml path with intellisense. 

```sh
$ dotnet sergen mvc
Transforming MVC at: /projects/Serene/Serene.Core/Imports/MVC
```

### Transform
---

Transform is shortcut for run all typings commands at once.

```sh
$ dotnet sergen transform
Transforming MVC at: /projects/Serene/Serene.Core/Imports/MVC
Transforming ClientTypes at: /projects/Serene/Serene.Core/Imports/ClientTypes
Transforming ServerTypings at: /projects/Serene/Serene.Core/Imports/ServerTypings
```

### Generate
---
This command is generate code from selected database table. Follow requests. 

```sh
$ dotnet sergen generate
=== Table Code Generation ===

Available Connections:
Default
Northwind

Enter a Connection: ('!' to abort)
Northwind

Available Tables:
...
dbo.Categories
dbo.Customers
dbo.Orders
dbo.Products
dbo.Region
dbo.Shippers
dbo.Suppliers
dbo.Territories
dbo.VersionInfo

Enter a Table: ('!' to abort)
dbo.Region

Enter a Module name for table: ('!' to abort)
Northwind

Enter a class Identifier for table: ('!' to abort)
RegionSample

Enter a Permission Key for table: ('!' to abort)
Northwind:RegionSampleRole

Choose What to Generate (R:Row, S:Repo+Svc, U=UI, C=Custom)
RSUC
```

Generated files are listed below:

```
/projects/Serene/Serene.Core/Modules/Northwind/NorthwindNavigation.cs
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleColumns.cs
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleDialog.ts
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleEndpoint.cs
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleForm.cs
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleGrid.ts
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleIndex.cshtml
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSamplePage.cs
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleRepository.cs
/projects/Serene/Serene.Core/Modules/Northwind/RegionSample/RegionSampleRow.cs
```