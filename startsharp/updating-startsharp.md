# Updating StartSharp

This document outlines steps required to update an existing StartSharp project to the latest Serenity / Serenity.Pro version.

> ### Warning
>
> It is possible to upgrade your existing StartSharp based project, by updating its Serenity NuGet packages using guides here.
>
> But, some of our users ask us how to update their *existing project* to *latest StartSharp template*. The short answer to this question is *you can't*. 
>
>Your existing project which is created using StartSharp template is a modifiable copy. Thus, it can not be seamlessly updated to latest StartSharp version as that would mean losing your changes. 
>
>Of course, it doesn't mean you can't update your existing project to use latest StartSharp features, but it requires some manual and tedious work.
>
>If you would like to avoid any such work and have newest features / samples in StartSharp template easily, you would need to create a new project based on latest StartSharp template.
>
>To manually update your existing StartSharp based application by transferring code from a new StartSharp project, it is useful to create the new project with the same name as your existing one. This will make it easier to copy / merge changes between them.
>
>Even though we try to list steps you need to perform under Upgrade Guides and Breaking Changes, it may not always work as expected. In that case, please create a new StartSharp project and try to transfer your existing custom code into the new project.

## Step 1 - Backup Existing Project

To be safe in case of an error during update process, first backup your project. You might ZIP your entire solution directory, or if you are using some source control system like Git, you may commit pending changes if any. 

> This step is optional, you may skip it at your own risk.

## Step 2 - Update Prerequisites

Applying latest Visual Studio patches, updating latest TypeScript / Node / NPM versions is usually a good idea.

We list the minimum requirements in this document:

https://github.com/volkanceylan/Serenity/blob/master/INSTALL.md

> Versions listed there might be lower than latest TypeScript / Node versions but more recent versions would probably work.

## Step 2 - Update Serenity NuGet Packages

### Applying Changes in Upgrade Guides

> While updating Serenity packages, there may be cases where you would need do some changes to your existing project based on your prior Serenity version. See Upgrade Guides and Breaking Changes section for more information.

Updating NuGet packages in a StartSharp project has some differences for ASP.NET MVC / ASP.NET Core.

### Serenity Update on ASP.NET MVC

Using package manager console, update following packages:

```
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
Update-Package Serenity.Web.Tooling
```

Build and make sure that there are no errors / warnings.

### Serenity Update on ASP.NET Core

Using package manager console, update following package:

```
Update-Package Serenity.Web
```

Edit *YourProject.Web.csproj* by right clicking on project name in VS, and choosing edit.

Find these lines:

```
<PackageReference Include="Serenity.Web" Version="x.y.z" />
<PackageReference Include="Serenity.Web.AspNetCore" Version="..." />
<DotNetCliToolReference Include="Serenity.CodeGenerator" Version="..." />
```

Take a note of *Serenity.Web* package version (x.y.z), and change versions of
Serenity.Web.AspNetCore and Serenity.CodeGenerator to the same value.

## Step 3 - Update Serenity.Pro NuGet Package(s)

Next step is updating *Serenity.Pro.Scripts* package, which contains scripts for premium StartSharp features.

As this package is premium only, it is not available from public NuGet repository and its update process works differently than other packages.

We distribute a **pro-packages.zip** file in StartSharp GitHub repository Releases tab. Grab the latest one from there:

> It's next to StartSharp.Template.vsix file.

[https://github.com/volkanceylan/StartSharp/releases](https://github.com/volkanceylan/StartSharp/releases)

> You may also extract it from the VSIX file, just download latest *StartSharp.Template.vsix*, rename it to *StartSharp.Template.vsix.zip* using file explorer, double click to open, copy the *pro-packages.zip* from *Assets* folder inside VSIX, and paste it to your solution folder.

Extract contents of *pro-packages.zip* file into the *pro-packages* folder in your solution directory (where YourProject.sln file and *packages* folder exists), e.g:

```
C:\..\YourSolutionDirectory\pro-packages\
```

> If you don't have a *pro-packages* folder inside your solution directory please see upgrade guide for [StartSharp v3.6.0.2](#startsharp-v3602)

Now you should have a *serenity.pro.scripts* folder inside *pro-packages* and a version folder like *3.7.6* inside that. Please make sure the version matches the one in *pro-packages.zip* file.

```
C:\..\YourSolutionDirectory\pro-packages\serenity.pro.scripts\3.7.6\
```

> The version of the *Serenity.Pro.Scripts* package doesn't always match *Serenity* or *StartSharp* version, as it has a different release cycle.

Using package manager console, update following package:

```
Update-Package Serenity.Pro.Scripts
```

## Step 4 - Restoring Static Content in .NET Core Version

If you are using ASP.NET Core version, open a command prompt in project directory (where YourProject.Web.csproj is) and type these commands:

```cmd
dotnet restore
dotnet sergen restore
```

*dotnet sergen restore* is critical as in .NET Core, NuGet can't install any static content, e.g. scripts, css, image etc into a .NET Core project. We worked around this by writing our own restore command. If you don't run this command, you'll have older versions of Serenity scripts.

## Step 5 - Transferring Samples / Features

So far we've updated NuGet packages. Some features are already contained in NuGet packages so you don't have to do anything other than looking at related sample source code and applying similar code lines to your project.

But if you need a new sample or feature that is contained directly in StartSharp, it might need a bit extra work.

You would need to copy / paste a sample page / module and related files from a new StartSharp project to your existing project.

In some cases, samples require some extra *CSS* too. In that case, transfer changes in *site.premium.less*, *site.theme.less*, *site.advancedsamples.less* etc. files to the same file in your project.

A sample might also require additional scripts as well. Check *Scripts* folder, and *ScriptBundles.json* to see if a sample has extra entries there. Add missing entries to your project and copy relevant files.

Upgrade Guides and Breaking Changes might sometimes contain useful information on what you should do to enable a new feature / sample.

## Step 6 - Rebuild and Check for Errors

Build and make sure that there are no errors / warnings.

## Upgrade Guides and Breaking Changes

We try to keep Serenity / StartSharp backward compatible as much as possible. 

In rare cases where we can't avoid breaking changes, we list them here so that you can safely upgrade your existing project. 

You should apply changes listed here *for versions greater than* your existing one in order from *lowest to highest*.

For example, if your existing Serenity / StartSharp version is 3.5.0 and updating to 3.9.0, then you should apply upgrade guide for 3.6.0, 3.7.5, 3.8.4 etc. if any in increasing order.

## Serenity 3.6.0

Serenity 3.6.0 comes with React integration but it is currently activated in StartSharp only. Once you update to Serenity 3.6.0, you may get some errors about React, as Serenity.CoreLib scripts has references to it.

```txt
Cannot find type definition file for 'react'.
Cannot find name 'React'.
...
```

> Serenity itself doesn't require React, it is just a TypeScript warning, so, you don't actually need to include React scripts in your site, just need typings.

To resolve such errors, you'll need to include typing for React in your package.json:

```json
  "dependencies": {
    //...
    "@types/react": "^16.1.0",
  }
```

After that save the file and make sure there is a **react** folder at *YourProject.Web\node_modules\@types*. If not, you might have some configuration error with NodeJS integration in Visual Studio.^

If you are still seeing warnings in Visual Studio errors tab about React, you might need to restart Visual Studio.

## StartSharp v3.6.0.2

Starting with StartSharp 3.6.0.2, we have a new *Serenity.Pro.Scripts* NuGet package which contains some features which is only available for StartSharp customers.

As this package is premium only, it is not available from public NuGet repository and its update process works differently than other packages.

We distribute a **pro-packages.zip** file in StartSharp GitHub repository Releases tab. Grab the latest one from there:

> It's next to StartSharp.Template.vsix file.

[https://github.com/volkanceylan/StartSharp/releases](https://github.com/volkanceylan/StartSharp/releases)

> You may also extract it from the VSIX file, just download latest *StartSharp.Template.vsix*, rename it to *StartSharp.Template.vsix.zip* using file explorer, double click to open, copy the *pro-packages.zip* from *Assets* folder inside VSIX, and paste it to your solution folder.

Create a *pro-packages* folder inside your solution directory (where YourProject.sln file and *packages* folder exists).

Extract contents of *pro-packages.zip* file into the *pro-packages* folder, e.g:

```
C:\..\YourSolutionDirectory\pro-packages\
```

Now you should have a *serenity.pro.scripts* folder inside *pro-packages* and a version folder like *3.7.6* inside that:

```
C:\..\YourSolutionDirectory\pro-packages\serenity.pro.scripts\3.7.6\
```

Next, create a *NuGet.config* file in your solution directory with contents below:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <packageSources>
        <add key="SerenityPro" value="pro-packages" />
    </packageSources>
</configuration>
```

Restart Visual Studio if it is running, so that it can see this new *NuGet.config* file and use *pro-packages* folder as a package source.

Using package manager console, install *Serenity.Pro.Scripts* package:

```
Install-Package Serenity.Pro.Scripts
```

Edit your *ScriptBundles.json* file (under *wwwroot/Scripts/site* or *Scripts/site* based on ASP.NET Core/MVC)

Find the line with *Serenity.CoreLib.js* and replace it with below lines:

```
    "~/Scripts/react.{REACT}.js",
    "~/Scripts/react-dom.{REACT}.js",
    "~/Scripts/serenity/Serenity.CoreLib.js",
    "~/Scripts/serenity/Serenity.Pro.UI.js",
    "~/Scripts/serenity/Serenity.Pro.App.js"
```

Edit your *web.config* file and insert *Replacements* part to ScriptBundling setting that is shown below:

```xml
<add key="ScriptBundling" value="{ 
    Enabled: false,
    Minimize: true, 
    UseMinJS: true, 
    NoMinimize: ['~/Scripts/ckeditor/ckeditor.js'], 
    Replacements: { REACT: 'development' } 
}" />
```

> Insert "`, Replacements: { REACT: 'development' }`" before last "`}`"

This makes sure that react.development.js is used during development. You may change it to `production` in your live environment.

As some script features and widgets like CardViewMixin, FavoriteViewsMixin etc. are moved into Serenity.Pro.Scripts for easier update, you'll need to remove them from your project.

Delete the following files from your project:

```
Modules/Common/GridMixins/CardViewMixin.ts
Modules/Common/GridMixins/FavoriteViewsMixin.ts
Modules/Common/Premium/SingleLineTextFormatter.ts
Modules/Common/Premium/WizardDialog.ts
```

Remove this line from `Modules/AdvancedSamples/Forms/OrderWizard/OrderWizard.ts`:

```xml
/// <reference path="../../../Common/Premium/WizardDialog.ts" />
```

Also, as your project doesn't have *EmailClient* sample, you'll need to exclude its typings file. Edit tsconfig.json and add a *exclude* setting under *include*:

```json
  "include": [
    "./Imports/",
    "./Modules/",
    "./Scripts/typings/"
  ],
  "exclude": [
    "./Scripts/serenity/Serenity.Pro.EmailClient.d.ts"
  ]
```

If you are using .NET Core version, you should write `"./wwwroot/Scripts/serenity/Serenity.Pro.EmailClient.d.ts"` instead.

> If you need *EmailClient* functionality, create a new StartSharp project and merge changes to your existing project.

You might also need to change *Build Action* of *Serenity.Pro.EmailClient.d.ts* file to *None* using *Visual Studio Properties* window as TypeScript language service in Visual Studio sometimes fails to use *tsconfig.json* properly.

Changing build action of *tsconfig.json* to *Content* is also recommended.

As we have switched from VueJS to React for card view templates, you'll need to modify *Modules/Northwind/Customer/CustomerGrid.ts* file and replace lines starting with *new Serenity.CardViewMixin* with:

```ts
            var editItem = this.editItem.bind(this);

            new Serenity.CardViewMixin({
                grid: this,
                renderItem: (item, index) => React.createElement(CustomerCard, {
                    item: item,
                    editItem: editItem
                })
            });
```

Edit *tsconfig.json* file again and add setting for *JSX* under *compilerOptions*:

```json
    //...
    "target": "es5",
    "jsx": "react",
    "typeRoots": [
    //...
```

Edit *YourProject.Web.csproj* file and add this line before **TypeScriptCompileBlocked**:

```
<TypeScriptJSXEmit>React</TypeScriptJSXEmit>
<TypeScriptCompileBlocked>True</TypeScriptCompileBlocked>
```

Also create a file named *CustomerCard.tsx* next to *CustomerGrid.ts*:

```tsx
// replace *StartSharp* with your project name
namespace StartSharp.Northwind {

    var randomImages = [
        "avatar.png",
        "avatar04.png",
        "avatar2.png",
        "avatar3.png",
        "avatar5.png"
    ];

    function getRandomImage(item: CustomerRow) {
        return Q.resolveUrl("~/Content/adminlte/img/" +
            randomImages[Math.floor(Math.random() * randomImages.length)]);
    }

    export interface CustomerCardProps {
        item: CustomerRow;
        editItem: (item: CustomerRow) => void;
    }

    export class CustomerCard extends React.Component<CustomerCardProps> {
        render(): React.ReactNode {
            var item = this.props.item;
            return (
                <table>
                    <tbody>
                        <tr>
                            <td rowSpan={4} className="img">
                                <img src={getRandomImage(item)} />
                            </td>
                        </tr>
                        <tr>
                            <td className="name">
                                <a href="javascript:;" onClick={e => this.props.editItem(item)}>
                                    {item.CustomerID} - {item.CompanyName}
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td className="contact">{item.ContactName}, {item.ContactTitle}</td>
                        </tr>
                        <tr>
                            <td className="country">{item.City}, {item.Country}</td>
                        </tr>
                    </tbody>
                </table>
            );
        }
    }
}
```

Restart Visual Studio, rebuild and run your project to ensure that there are no script errors.

### StartSharp v3.8.3.2

In this version an idle timeout sample is added. To enable it for your site, add these lines to your ScriptInitialization.ts:

```ts
    $(() => {
        // let demo page use its own settings for idle timeout
        if (window.location.pathname.indexOf('Samples/IdleTimeout') > 0)
            return;

        var meta = $('meta[name=username]');
        if ((meta.length && meta.attr('content')) ||
            (!meta.length && Q.Authorization.isLoggedIn)) {

            new Serenity.IdleTimeout({
                activityTimeout: 15 * 60,
                warningDuration: 2 * 60
            });
        }
    });
```

> Make sure you update Serenity and Serenity.Pro.Scripts packages first, and don't forget to run `dotnet sergen restore` if using .NET Core.

### StartSharp v3.8.6.0

This version comes with some modern flat design improvements for grids, forms and toolbars. To apply these changes into your project, after updating Serenity and Serenity.Pro.Scripts packages (and don't forget to run `dotnet sergen restore` if using .NET Core), edit your ScriptInitialization.ts add add this line inside namespace braces:

```ts
Serenity.setupUIOverrides();
```

Also please take changes from site.premium.less, minimum between these two lines:

```css
// --- Start of UI Overrides ---

... copy paste everything between

// --- End of UI Overrides ---
```

You may get these lines by creating a new StartSharp project, or using the following link:

https://github.com/volkanceylan/StartSharp/blob/master/StartSharp/StartSharp.Web/Content/site/site.premium.less

There are some minor changes in skins.azure.less file so it is a good idea to update that too:

https://github.com/volkanceylan/StartSharp/blob/master/StartSharp/StartSharp.Web/Content/skins/azure.less

