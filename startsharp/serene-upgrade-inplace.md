# Upgrading an Existing Serene Project to StartSharp Features

This document outlines steps required to upgrade an existing Serene based project to StartSharp.

Upgrade is performed inplace, e.g. your existing project is modified during the process.

> Another option involves migration by creating a new StartSharp project and copying your existing modules in Serene project into the new StartSharp project. 
> If you prefer that see [Serene Upgrade by Migration](serene-upgrade-migrate.md) topic for that alternative.

## Step 1 - Backup Existing Project

To be safe in case of an error during upgrade process, first backup your project. You might ZIP your entire solution directory, or if you are using some source control system like Git, you may commit pending changes if any.

## Step 2 - Update Serenity NuGet Packages

If your Serene based project is not at latest version of Serenity, update them first using Package Manager Console:

```
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
Update-Package Serenity.Web.Tooling
```

## Step 3 - Download StartSharp and Install

Download latest StartSharp.vsix from GitHub StartSharp repository (https://github.com/volkanceylan/StartSharp) or Serenity members dashboard (http://serenity.is/Dashboard) and install.

## Step 4 - Create a new StartSharp Project with the Same Name

If your existing project is named MyProject, create a new StartSharp project with the same name, e.g. MyProject. This is important for namespaces to match during copy/paste process.


## Step 5 - Merge package.json

StartSharp and Serene might have different dependencies. As of writing, StartSharp package.json (at your project root) has React dependency while Serene doesn't as React feature is currently StartSharp only. 

Compare them and add missing pieces to your existing project package.json file:

```json
{
  //...
  "dependencies": {
    //...
    "@types/react": "^16.3.13"
  }
}
```

## Step 6 - Install Missing NuGet Packages

As StartSharp has some extra features, it might be using some NuGet packages that is not used in Serene.

Some of them are required for samples only (e.g. MimeKit/MailKit for IMAP Client Sample, PagedList.Mvc for Bootstrap form sample).

We'll install all missing ones (except Serenity.Pro.Scripts which we'll cover in next step) but you may wait see if you're going to need them first, and install them later if required.

```
Install-Package MailKit
```

This also installs MimeKit and BouncyCaste because of dependencies.

```
Install-Package PagedList.Mvc
```

This also installs PagedList

```
Install-Package TinyMapper
```

Your packages.config files in both projects (or .csproj files) should look similar after these installs. If not, there might be some packages added after this document is written, so you may try installing them as well.

## Step 7 - Installing Serenity.Pro.Scripts

StartSharp comes with some premium NuGet packages that are not available in Serene. 

> As of writing we only have Serenity.Pro.Scripts but more to follow.

Serenity.Pro.Scripts (and other future Pro packages) are not available in public NuGet package source as they are premium only.

We need to install them locally.

Go to your StartSharp solution folder, you'll see that there is a `NuGet.config` file there. Copy that to your Serene solution folder. This file configures the `pro-packages` local folder as a NuGet package source.

Also copy `pro-packages` folder from the same location to your Serene based solution folder.

Close Visual Studio that has Serene based project, restart it and open the same Serene based project.

Open package manager console and install Serenity.Pro.Scripts:

```
Install-Package Serenity.Pro.Scripts
```

## Step 8 - Update ScriptBundles.json

Compare file `Scripts\site\ScriptBundles.json` with your version and add missing includes.

As of writing, add these scripts:

Include React scripts before `Serenity.CoreLib.js`:

```json
    "~/Scripts/react.{REACT}.js",
    "~/Scripts/react-dom.{REACT}.js",
    "~/Scripts/Serenity.CoreLib.js"
```

Include Pro scripts after `Serenity.CoreLib.js`:

```json
    "~/Scripts/serenity/Serenity.CoreLib.js",
    "~/Scripts/serenity/Serenity.Pro.UI.js",
    "~/Scripts/serenity/Serenity.Pro.App.js"
```

React is required for card view feature, and some samples like IMAP email client.

`Serenity.Pro.UI.js` includes React integration for Serenity and adds some React specific components.

`Serenity.Pro.App.js` includes script code for StartSharp features like Card View, Favorite Views, Wizard.

## Step 9 - Configure React Environment

React has two versions, one for development and one for production. We should configure which one to use in web.config ScriptBundling settings:

```xml
<configuration>
  <appSettings>
    <add key="ScriptBundling" value="{ 
        Enabled: false, Minimize: true, UseMinJS: true, 
        NoMinimize: ['~/Scripts/ckeditor/ckeditor.js'], 
        Replacements: { REACT: 'development' } }" />
```

You should add the section with `Replacements:` to your ScriptBundling settings in web.config file.

`{REACT}` text in your ScriptBundles.json is replaced with value you write here (`development`).

> Once you publish, replace `development` with `production` in your live web.config.


## Step 10 - Update tsconfig.json

Apply extra lines in StartSharp `tsconfig.json` to the one in your existing project:

We list below the missing / mismatched lines you might have:

```json
{
  "compilerOptions": {
    //...
    "jsx": "react",
    //...
    "skipLibCheck": true,
    "skipDefaultLibCheck": true,
    //...
  },
  "include": [
    "./Scripts/typings/serenity/Serenity.CoreLib.d.ts",
    "./Scripts/typings/jspdf/jspdf.autotable.d.ts",
    "./Scripts/serenity/Serenity.Pro.UI.d.ts",
    "./Scripts/serenity/Serenity.Pro.App.d.ts",
    "./Imports/**/*",
    "./Modules/**/*"
  ]
}

```

> Don't include `./Scripts/serenity/Serenity.Pro.EmailClient.d.ts` yet as we will transfer that module later.

## Step 11 - Enable Favorite Views Mixin

We're going to enable this feature in Northwind Customers, but you might apply it to any screen with a few changes.

Add two methods below to `CustomerGrid.ts`:

```ts
        protected createToolbarExtensions() {
            super.createToolbarExtensions();

            new Serenity.FavoriteViewsMixin({
                grid: this
            });
        }

        protected getPersistanceStorage(): Serenity.SettingStorage {
            return new Common.UserPreferenceStorage();
        }
```

Copy text related to FavoriteViewsMixin from `Modules\Texts.cs`:

```cs
        public static class Site {
        
            //...
        
            public static class FavoriteViewsMixin
            {
                public static LocalText FavoriteViews = "Favorite Views";
                public static LocalText SaveButton = "Save";
                public static LocalText SaveView = "Save view";
                public static LocalText EmptyNameError = "Please write a view name!";
                public static LocalText DeleteButtonHint = "delete view";
                public static LocalText SaveSuccessMessage = "Current view is saved with name \"{0}\".";
                public static LocalText DeleteSuccessMessage = "View with name \"{0}\" is deleted.";
                public static LocalText LoadedViewMessage = "Loaded view: {0}";
            }
        }
```

Create a new file `Content\site\site.gridviews.less` and copy its content from StartSharp project.

Include `site.gridviews.less` in site.less:

```less
//...
@import "site.administration.less";
@import "site.gridviews.less";
//...
```

Rebuild the project so that site.css gets changes.

You should now run the project and see if favorite views feature is working on Customer page.

## Step 12 - Enable Card View Mixin

Create a new file named `Modules\Northwind\CustomerCard.tsx` and copy its contents from StartSharp project.

> As of writing, due to an error at project creation, the namespace in this file is `StartSharp.Northwind`, rename it to `MyProject.Northwind`.

Edit `createToolbarExtensions` method in `CustomerGrid.ts` and add these lines:

```ts
        protected createToolbarExtensions() {
            super.createToolbarExtensions();

            //...

            var editItem = this.editItem.bind(this);

            new Serenity.CardViewMixin({
                grid: this,
                renderItem: (item, index) => React.createElement(CustomerCard, {
                    item: item,
                    editItem: editItem
                })
            });
        }
```

Add method below to `CustomerGrid.ts` so that fields used in card view is always loaded from server, even when they are hidden:

```ts
        protected getIncludeColumns(include) {
            super.getIncludeColumns(include);

            // these columns are used by card view, so even if they
            // are hidden in grid view, we should make sure they
            // are loaded from server
            include[CustomerRow.Fields.CustomerID] = true;
            include[CustomerRow.Fields.CompanyName] = true;
            include[CustomerRow.Fields.ContactName] = true;
            include[CustomerRow.Fields.ContactTitle] = true;
            include[CustomerRow.Fields.Country] = true;
            include[CustomerRow.Fields.City] = true;
        }
```

## Step 13 - Transferring Extra Helpers

There might be some files in StartSharp that is not available in Serene. One sample is `SingleLineTextFormatterAttribute.cs` under `Modules\Common\Helpers` folder.

Copy that file using Windows File Explorer and paste it to same folder using Visual Studio into existing project.

Do the same for following files (and any extra ones you see there):

```
Modules\Common\Helpers\PromptDialog.ts
Modules\Common\Helpers\RequireHttpsWithConfig.cs
Modules\Common\Helpers\ServiceEditorBase.cs
```

## Step 14 - Transferring Migrations

As of writing, there are four extra migrations related to samples and additional features in StartSharp.

This step is optional, and if you are not going to use Organization, Meeting samples, Mail Queue or Two Factor Authorization features you don't need to include related migrations.

### Organization / Meeting Modules:

```
Migrations/DefaultDB/DefaultDB_20161126_200000_Organization.cs
Migrations/DefaultDB/DefaultDB_20161126_210000_Meeting.cs

```

### Mail Queue

```
Migrations/DefaultDB/DefaultDB_20170211_152700_Mailing.cs
```

### Two Factor Authorization Sample

```
Migrations/DefaultDB/DefaultDB_20170304_085200_TwoFactorAuth.cs
```

## Step 15 - Transferring Organization / Meeting Modules

This step is also optional and is to demonstrate how you could transfer a module from StartSharp to Serene (or vice versa)

Open `Modules\` folder in File Explorer. Copy `Meeting` and `Organization` folders and paste them into your existing project `Modules\` folder using Visual Studio. Make sure you copy files from Windows File Explorer and paste in Visual Studio to existing project.


Open `Imports\ServerTypings\` folder in File Explorer. Copy files starting with `Meeting.` and `Organization.` and paste them to same folder in existing project using Visual Studio.

Open `Imports\ClientTypes\` folder in File Explorer. Copy files starting with `Meeting.` and `Organization.` and paste them to same folder in existing project using Visual Studio.

Open `Content\site` folder, copy `site.meeting.less` and `site.organization.less` files, paste them into same folder in your existing project using Visual Studio.

Include less files in `site.less`:

```less
@import "site.meeting.less";
@import "site.organization.less";
```

Rebuild for changes to take effect.

Run project and test that modules are shown in navigation and works properly.

## Step 16 - Transform T4

After transferring modules, features and samples into your project, you should transform T4 to be sure that it won't introduce any problems.

You may get an error in CodeGenerationHelpers.ttinclude file during transform due to a change in Mono.Cecil.

In that case, replace `externalType.Interfaces.Add(intf.FullName);` in that file with `externalType.Interfaces.Add(intf.InterfaceType.FullName);` and try transform again.

After transformation, your project should build successfully.