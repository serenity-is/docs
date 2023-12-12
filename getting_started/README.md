# Getting Started

The best and fastest way to get your hands dirty on Serenity is `Serene`, which is a starter application template.

> Premium customers can also use `StartSharp` template which they can download from https://serenity-is members area.

You have a few options to install the Serene template:

> Please check prerequisites below before trying to install Serene.

* [Installing SERENE from VS Marketplace (Windows)](installing_serene_from_visual_studio_gallery.md)

* [Installing Serene with DotNet New](installing_serene_with_dotnet_new.md)

## Prerequisites

### Visual Studio, .NET, and TypeScript Versions

The application requires _Visual Studio 2022+_ with the most recent updates installed. 

.NET 8 SDK is also only supported in Visual Studio 2022 17.8+. 

An alternative option is to use the command line to create projects and work in Visual Studio Code if you don't have access to Visual Studio 2022+.

Please install .NET SDK from:

https://dotnet.microsoft.com/download

As of writing, the recommended version of TypeScript is 4.8+ 

The project comes with a reference to a recent version of Microsoft.TypeScript.MSBuild package and it should be used by Visual Studio automatically.

You may also check https://www.typescriptlang.org/download for information on updating your TypeScript.

### NodeJS / NPM

Node, and its package manager NPM is used for the following:

- TypeScript typings (.d.ts) for libraries like jQuery and Bootstrap. 
- Installing and executing external tools like ESBuild

NodeJS and NPM LTS (Long Term Support) versions are required and you may download them from [https://nodejs.org/en/](https://nodejs.org/en/)

The application will check their versions on project creation and ask for confirmation to download and install them. Anyway, please check your versions manually by opening a command prompt:

```cmd
> npm -v
8.19.2
```

```cmd
> node -v
18.12.1
```

If you get an error, they might not be installed or not in the path. Also, confirm that the versions listed are higher than the ones shown above.

### Visual Studio and External Web Tool Paths

Even if you have the correct Node / NPM installed, Visual Studio might still be trying to use the integrated, and older version of NodeJS.

Click `Tools` => `Options`, and then under `Projects and Solutions` => `External Web Tools` add `C:\Program Files\nodejs` to the top of the list by clicking plus folder icon and using the `Up Arrow`:

![VS External Tools Path](img/vs-external-tools-path.png)
