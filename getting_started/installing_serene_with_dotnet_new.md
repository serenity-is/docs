# Installing Serene with the `dotnet new`

This section is for users who doesn't or can't use Visual Studio (in Linux / OSX). 

Serene (and StartSharp) Asp.Net Core version supports Linux and Mac OSX in addition to Windows.

> We recommend Visual Studio Code for all platforms, but it is also possible to work with a basic text editor like Notepad / VIM. There are also other nice options e.g. Atom.

## Install .NET SDK 

Please go to the address below and follow the instructions for your specific platform:

https://dotnet.microsoft.com/en-us/download

> Serenity usually depends on latest stable version of .NET SDK (6.0 as of writing), if you get an error on project creation about .NET SDK, please check the error message, and install appropriate version of .NET SDK as this document might be updated yet.

## Install NodeJS

As `TypeScript` and `esbuild` run on NodeJS you need to install Node/NPM from:

https://nodejs.org/en/download/

or using your favorite package manager:

https://nodejs.org/en/download/package-manager/

### Install the Template Package

> Note: As of Serene 6.4.4, the old `serin` tool is obsolete and may not work properly  to create new Serene projects as we are now using `dotnet new` templating.

`Serene.Templates` is a NuGet package that contains our `Serene` template. Install it with `dotnet new` via command line:

```cmd
dotnet new install Serene.Templates
```

If you don't have the .NET 7 SDK, you may have to type `dotnet new --install Serene.Templates` instead.

> If you are a premium customer and want to create a `StartSharp` project instead, make sure you have the premium package source configured and run:
> ```cmd
>dotnet new install Serenity.Pro.Templates
> ```

The command above should install latest version of Serene.Templates (or Serenity.Pro.Templates), or update it to latest version if it is already installed.

> If you want to install an older version, specify it like: `dotnet new install Serene.Templates:6.4.4`

See `dotnet new` documentation for more information:

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new

## Creating a New Project Using the Template

Create an empty folder, for instance, `MyProject` and cd into that folder:

```bash
~/> mkdir MyProject
~/> cd MyProject
```

To create a new project with the name of the current folder name type:

```bash
~/MyProject> dotnet new serene
```

> If you wanted to specify a different name pass `-n` argument:
> ```bash
> ~/MyProject> dotnet new serene -n MyAnotherProject
> ```
> Note that in that case the project will be created in a sub-directory named `MyAnotherProject`. You should `cd` into that folder after creating.

> Use `dotnet new startsharp` to create a StartSharp based project

Change directory to `MyProject.Web` folder, run `npm install` to install packages, followed by `dotnet build` and `dotnet run` to try the project:

```bash
~/MyProject/MyProject.Web> npm i
~/MyProject/MyProject.Web> dotnet build
~/MyProject/MyProject.Web> dotnet run

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
```

> Note that dotnet new won't create a solution file. If you open this project in Visual Studio we recommend naming the solution `MyProject` and saving the solution file in the root folder as `MyProject/MyProject.sln`, not `MyProject.Web/MyProject.Web.sln`.

Now open a browser and navigate to `http://localhost:5000`.

> Actual port may vary. You'll see it on console after executing *dotnet run*.

## Excluding Modules / Features During Project Creation

`dotnet new` command for `serene` and `startsharp` supports arguments that lets you specify which modules to enable/disable.

Type `dotnet new serene --help` or `dotnet new startsharp --help` to see the arguments and their possible values.

For example, to exclude demo modules like `Northwind`, `Basic Samples`, etc. you can type:

```
~/MyProject> dotnet new serene -E
```

To exclude demo modules and to only include `DataAuditLog` and `OpenIddict` instead of the all pro modules in StartSharp:

```
~/MyProject> dotnet new startsharp -E -P DataAuditLog -P OpenIddict
```