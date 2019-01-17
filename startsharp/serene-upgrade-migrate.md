# Migrating an Existing Serene Project to StartSharp

This document outlines steps required to migrate an existing Serene based project to StartSharp.

Upgrade is NOT performed inplace, you will create a new StartSharp project and copy your modules into that, so your existing project will not be modified.

> If you prefer to upgrade inplace, see [Serene Inplace Upgrade](serene-upgrade-inplace.md) topic.


## Step 1 - Backup Existing Project

To be safe in case of an error during upgrade process, first backup your project. You might ZIP your entire solution directory, or if you are using some source control system like Git, you may commit pending changes if any.

## Step 2 - Update Serenity NuGet Packages

If your Serene based project is not at latest version of Serenity, update them first using Package Manager Console:

```
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
Update-Package Serenity.Web.Tooling
```

Build and make sure that there are no errors / warnings.

## Step 3 - Download StartSharp and Install

Download latest StartSharp.vsix from GitHub StartSharp repository (https://github.com/volkanceylan/StartSharp) or Serenity members dashboard (http://serenity.is/Dashboard) and install.

## Step 4 - Create a new StartSharp Project with the Same Name

If your existing project is named MyProject, create a new StartSharp project with the same name, e.g. MyProject. This is important for namespaces to match during copy/paste process.

## Step 5 - Install Missing NuGet Packages

If you are using any extra NuGet packages in your existing project, install them to your newly created StartSharp project.

```
Install-Package SomeExtraPackage
```

## Step 6 - Update ScriptBundles.json

Compare file `Scripts\site\ScriptBundles.json` with your version and add missing includes to newly created one, e.g. ones that you might have added manually in your existing project that doesn't come in StartSharp.

## Step 7 - Transferring Migrations

Copy migration files you might have added under `Migrations` folder in your existing project directory using Windows File Explorer and paste them using Visual Studio to the same location in new project.

## Step 8 - Transferring Modules

Open `Modules\` folder in File Explorer. Copy `YourModule` folder and paste it into your existing project `Modules\` folder using Visual Studio. Make sure you copy files from Windows File Explorer and paste in Visual Studio to existing project.

Open `Imports\ServerTypings\` folder in File Explorer. Copy files starting with `YourModule.` and paste it to same folder in existing project using Visual Studio.

Open `Imports\ClientTypes\` folder in File Explorer. Copy files starting with `YourModule.` and paste it to same folder in existing project using Visual Studio.

Open `Imports\MVC\MVC.cs` file in existing project. Copy code under `YourModule` class to the same location in new project.

Open `Content\site` folder, copy `site.yourmodule.less` file, and paste it into same folder in new project using Visual Studio.

Include less file in `site.less`:

```less
@import "site.yourmodule.less";
```

Rebuild for changes to take effect.

> Sometimes Visual Studio TypeScript language service might get confused during copy/paste and show invalid errors. Restarting Visual Studio usually solves the issue.

Run project and test that modules are shown in navigation and works properly.

## Step 9 - Transform T4

After transferring modules, features and samples into your project, you should transform T4 to be sure that it won't introduce any problems.