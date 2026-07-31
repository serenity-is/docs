# Installing Serene with `dotnet new`

This section is for users who don't use, or can't use, Visual Studio (for example, on Linux or macOS).

Serene (and StartSharp) supports Linux and macOS in addition to Windows.

> We recommend Visual Studio Code on all platforms, but it's also possible to work with a basic text editor like Notepad or Vim.

## Installing the .NET SDK

Go to the address below and follow the instructions for your specific platform:

https://dotnet.microsoft.com/en-us/download

> Serenity typically depends on the latest stable version of the .NET SDK (10.0 as of this writing). If you get an error about the .NET SDK when creating a project, check the error message and install the appropriate version, as this document might not be updated yet.

## Installing Node.js

Because `TypeScript` and `esbuild` run on Node.js, you need to install Node.js/npm from:

https://nodejs.org/en/download/

or via your favorite package manager:

https://nodejs.org/en/download/package-manager/

### Installing the Template Package

`Serene.Templates` is a NuGet package that contains the `Serene` template. Install it from the command line with `dotnet new`:

```cmd
dotnet new install Serene.Templates
```

> If you're a premium customer and want to create a `StartSharp` project instead, make sure you have the premium package source configured, then run:
> ```cmd
> dotnet new install Serenity.Pro.Templates
> ```

The command above installs the latest version of `Serene.Templates` (or `Serenity.Pro.Templates`), or updates it to the latest version if it's already installed.

> To install an older version, specify it like this: `dotnet new install Serene.Templates:6.4.4`

See the `dotnet new` documentation for more information:

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new

## Creating a New Project Using the Template

Create an empty folder, for instance `MyProject`, and change into it:

```bash
~/> mkdir MyProject
~/> cd MyProject
```

To create a new project named after the current folder, type:

```bash
~/MyProject> dotnet new serene
```

> To specify a different name, pass the `-n` argument:
> ```bash
> ~/MyProject> dotnet new serene -n MyAnotherProject
> ```
> In that case, the project will be created in a subdirectory named `MyAnotherProject`. You should `cd` into that folder after creating it.

> Use `dotnet new startsharp` to create a StartSharp-based project.

Change to the `MyProject.Web` folder, run `npm install` to install the packages, then `dotnet build` and `dotnet run` to try the project:

```bash
~/MyProject/MyProject.Web> npm i
~/MyProject/MyProject.Web> dotnet build
~/MyProject/MyProject.Web> dotnet run

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
```

> Note that `dotnet new` won't create a solution file. If you open this project in Visual Studio, we recommend naming the solution `MyProject` and saving the solution file in the root folder as `MyProject/MyProject.sln`, rather than `MyProject.Web/MyProject.Web.sln`.

Now open a browser and navigate to `http://localhost:5000`.

> The actual port may vary. You'll see it in the console after running *dotnet run*.

## Excluding Modules / Features When Creating a Project

The `dotnet new` command for `serene` and `startsharp` supports arguments that let you specify which modules to enable or disable.

Type `dotnet new serene --help` or `dotnet new startsharp --help` to see the arguments and their possible values.

For example, to exclude demo modules such as `Northwind` and `Basic Samples`, type:

```
~/MyProject> dotnet new serene -E
```

To exclude the demo modules and include only `DataAuditLog` and `OpenIddict` instead of all the pro modules in StartSharp:

```
~/MyProject> dotnet new startsharp -E -P DataAuditLog -P OpenIddict
```