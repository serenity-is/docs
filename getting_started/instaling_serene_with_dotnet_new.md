# Installing Serene Asp.Net Core Version with `dotnet new`

This section is for users who doesn't or can't use Visual Studio (in Linux / OSX). 

Serene Asp.Net Core version supports Linux and Mac OSX in addition to Windows.

> We recommend Visual Studio Code for all platforms, but it is also possible to work with a basic text editor like Notepad / VIM. There are also other nice options e.g. Atom.

## Install .NET SDK 

Please go to the address below and follow the instructions for your specific platform:

https://dotnet.microsoft.com/en-us/download

> Serenity usually depends on latest stable version of .NET SDK (6.0 as of writing), if you get an error on project creation about .NET SDK, please check the error message, and install appropriate version of .NET SDK as this document might be updated yet.

## Install NodeJS

As `TypeScript` and `esbuild` runs on NodeJS you need to install Node/NPM from:

https://nodejs.org/en/download/

or using your favorite package manager:

https://nodejs.org/en/download/package-manager/

### Install `Serene.Templates` NuGet Package

> Note: As of Serene 6.4.4, old `serin` tool is obsolete and can't be used to create new Serene projects as we are now using `dotnet new` templating.

`Serene.Templates` is a NuGet package that contains our `Serene` template. Install it with `dotnet new` via command line:

```cmd
dotnet new install Serene.Templates
```

The command above should install latest version of Serene.Templates, or update it to latest version if it is already installed.

> If you want to install another version, specify it like: `dotnet new install Serene.Templates:6.4.4`

See `dotnet new` documentation for more information:

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new

Create an empty folder, for instance, `MySerene` and cd into that folder:

```bash
~/> mkdir MySerene
~/> cd MySerene
```

To create a new project with the name current folder name type:

```bash
~/MySerene> dotnet new serene
```

> If you wanted to specify a different name pass `-n` argument:
> ```bash
> ~/MySerene> dotnet new serene -n MyAnotherProject
> ```
> Note that in that case the project will be created in a sub-directory named `MyAnotherProject`. You should `cd` into that folder after creating.

Run `npm install` to install packages, followed by `dotnet build` and `dotnet run` to try the project:

```bash
~/MySerene> npm i
~/MySerene> dotnet build
~/MySerene> dotnet run

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
```

Now open a browser and navigate to `http://localhost:5000`.

> Actual port may vary. You'll see it on console after executing *dotnet run*.
