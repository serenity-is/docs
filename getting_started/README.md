# Getting Started

The best and fastest way to get your hands dirty on Serenity is _SERENE_, which is a starter application template.

> Premium customers can also use _StartSharp_ template which they can download from https://serenity-is members area.

You have three options to install _SERENE_ template:

> Please check prerequisites below before trying to install Serene.

* [Installing SERENE from Visual Studio Marketplace (Windows)](installing_serene_from_visual_studio_gallery.md)

* [Installing SERENE directly from Visual Studio (Windows)](installing_serene_directly_from_visual_studio.md)

* [Installing SERENE for Asp.Net Core with SERIN (Linux, OSX, Windows)](instaling-serene-aspnet-core-version-with-serin.md)

## Prerequisites

### Visual Studio Version

The application requires _Visual Studio 2019+_ with most recent updates installed. .NET CORE 5 SDK is also only supported in Visual Studio 2019+. 

An alternative option is to use command line to create projects and use Visual Studio Code if you don't have access to Visual Studio 2019+.

Please install .NET Core 5 SDK from:

https://dotnet.microsoft.com/download

### Visual Studio TypeScript Extension

As of writing, the recommended version of TypeScript is 4.0+ 

The project comes with a reference to a recent version of Microsoft.TypeScript.MsBuild package and it is supposed to be used by Visual Studio 2019+ automatically.

You may also check https://www.typescriptlang.org/download for information on updating your TypeScript.

### NodeJS / NPM

NodeJS / NPM is used for following:

- TypeScript typings (.d.ts) for libraries like jQuery, Bootstrap etc. 
- Less compilation (lessjs)
- Code generation through Sergen by parsing TypeScript sources

NodeJS and NPM LTS (Long Term Support) versions are required and you may download from [https://nodejs.org/en/](https://nodejs.org/en/)

The application will check their versions on project creation and ask for confirmation to download and install them. Anyway, please check your versions manually by opening a command prompt:

```cmd
> npm -v
5.4.2
```

```cmd
> node -v
8.7.0
```

If you get an error, they might not be installed or not in path. Also confirm that versions listed are higher than ones shown above.

### Visual Studio and External Web Tool Paths

Even if you have correct Node / NPM installed, Visual Studio might still be trying to use its own integrated, and older version of NodeJS.

Click _Tools_ => _Options_, and then under _Projects and Solutions_ => _External Web Tools_ add _C:\Program Files\nodejs_ to the top of the list by clicking plus folder icon, typing _C:\Program Files\nodejs_ and using _Up Arrow_ to move it to the start:

![VS External Tools Path](img/vs-external-tools-path.png)