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

Create an empty folder, for instance `Projects`, and change into it:

```bash
~/> mkdir Projects
~/> cd Projects
```

Specify a name for the project with the `-n` argument, for example:

```bash
~/Projects> dotnet new serene -n HelloSerenity
```

This creates the project in a subdirectory named after the project name, e.g. `Projects/HelloSerenity/HelloSerenity.Web/HelloSerenity.Web.csproj`.

> Use `dotnet new startsharp -n HelloSerenity` to create a StartSharp-based project.

Change to the project's `.Web` folder, run `npm install` to install the packages, then `dotnet build` and `dotnet run` to try the project:

```bash
~/Projects/HelloSerenity/HelloSerenity.Web> npm i
~/Projects/HelloSerenity/HelloSerenity.Web> dotnet build
~/Projects/HelloSerenity/HelloSerenity.Web> dotnet run

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
```

> If you run `dotnet new serene` without a name, `dotnet new` names the project after the current folder, e.g. from `~/Projects` it creates `~/Projects/Projects.Web/Projects.Web.csproj`. This can result in an unintended name (for example, a lowercase one), so it's usually better to pass an explicit name with `-n`.

> Note that `dotnet new` won't create a solution file. If you open this project in Visual Studio, we recommend naming the solution `HelloSerenity` and saving the solution file in the root folder as `HelloSerenity/HelloSerenity.sln`, rather than `HelloSerenity.Web/HelloSerenity.Web.sln`.

Now open a browser and navigate to `http://localhost:5000`.

> The actual port may vary. You'll see it in the console after running *dotnet run*.

## Excluding Modules / Features When Creating a Project

The `dotnet new` command for `serene` and `startsharp` supports arguments that let you specify which modules to enable or disable.

Type `dotnet new serene --help` or `dotnet new startsharp --help` to see the arguments and their possible values.

For example, to exclude demo modules such as `Northwind` and `Basic Samples`, type:

```
~/Projects> dotnet new serene -n HelloSerenity -D false
```

> `-D` (or `--DemoModules`) is `true` by default, so pass `false` to exclude the demo modules.

The `startsharp` template accepts similar boolean options, all of which default to `true`, e.g. `-dm/--demo-modules`, `-dx/--data-explorer`, `-ec/--email-client`, `-mt/--meeting`, `-os/--openid-server`, `-oc/--openid-client`, `-T/--TwoFactorAuthenticator`, and `-wl/--worklog`.

For example, to exclude the demo modules and other pro modules in StartSharp, keeping only the OpenId server and Data Explorer:

```
~/Projects> dotnet new startsharp -n HelloSerenity -dm false -ec false -mt false -T false -wl false
```