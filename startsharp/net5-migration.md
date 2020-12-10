# Upgrading to Serenity.NET 5

This document outlines steps required to upgrade an existing Serenity .NET Core 3.1 based project to Serenity.NET 5.0 

## Editing Project File

Edit `YourProject.csproj` and change target framework:

From:

```xml
<TargetFramework>netcoreapp3.1</TargetFramework>`
```

To:

```xml
<TargetFramework>net5.0</TargetFramework>
```

> If you are using GIT it is recommended to stage your changes on every step to be able to undo your changes if you make a mistake during following steps as we'll do many bulk operations.

## Changing References to Row with IRow interface

Serenity base Row class is replaced with a generic row class which implements new IRow interface so any references in your project to old Row class should be replaced with IRow.

It might be hard to replace all such references manually, so we'll use a trick to make Visual Studio do it for us automatically.

Create an empty .CS file in your project like `RowTrick.cs`:

```cs
namespace Serenity.Data
{
    public class Row 
    {
    }
}
```

Now put your editing cursor. onto `Row` word and press Ctrl+R+R or Ctrl+F2 (based on your editor shortcuts) or right click `Row` and click `Rename...` and type `IRow` then press `Enter` to apply changes.

Now you may delete `RowTrick.cs` file.

## Changing base class of rows to `Row<TRowFields>`

As noted in previous section, base `Row` class is replaced with a generic row class `Row<TRowFields>` which provides a direct reference to a rows fields type.

So if you used to had:

```cs
public class MyRow : Row
{
    public class RowFields
    {
    }
}
```

You will need to replace it with:

```cs
public class MyRow : Row<MyRow.RowFields>
{
    public class RowFields
    {
    }
}
```

Again this might take too much time for a manual process, so let's use a Regex replace:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `class\s*([A-Za-z]*)Row\s*:\s*I?Row(\s*[^<]{1})` in `Find` input

* Type `class $1Row : Row<$1Row.RowFields>$2` in `Replace` input

* Click `Replace All`

* Save all open files if any

## Removing Static RowFields Instance from Rows

We used to have a static RowFields instance named `Fields` in row classes which is no longer required as the base generic row class already have a correctly typed static `Fields` property with the same name.

> This new design will open way to having different sets of fields for multi tenant row customization scenarios in the future.

* Open `Replace in Fields` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `[\r]?[\n]?[ \t]*public\s+static\s+readonly\s+RowFields\s+Fields\s*=\s*new\s+RowFields\(\)\.Init\(\);\r?\n` in `Find` input

* Clear `Replace` input value (empty string)

* Click `Replace All`

## Adding Row Constructors to Accept a RowFields Instance

Row constructors used to pass the static RowFields instance to base Row constructor like this:

```csharp
public CustomerRow()
    : base(Fields)
{
}
```

As there is no longer a static Fields instance, we'll keep the default constructor removing the base call and also add a new constructor that accepts a RowFields instance.

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([ \t]*public[ \t]* )([A-Za-z]*)Row\(\)([\s\r\n]*:[\s]*base\()Fields\)(\s*\{\s*\})([\r]?[\n]?)` in `Find` input

* Type `$1$2Row()$4$5$5$1$2Row(RowFields fields)$3fields)$4$5` in `Replace` input

* Click `Replace All`

* Save all open files if any


## Replacing IIdRow.IdField with [IdProperty] Attribute

In your rows you might you have `IIdRow` interface implemented like below:

```csharp
// we will delete this
IIdField IIdRow.IdField
{
    get { return Fields.CustomerId; }
}
```

This interface is still there, but it does not have `IdField` property now.

We replaced it with `[IdProperty]` attribute as old explicit style made determining that field using reflection (without creating a row instance first) difficult.

You need to find all such rows by searching for `IIdRow.IdField`. Then take a note of `IdField`, delete the block and put a `[IdProperty]` attribute on corresponding property if required (read following paragraph).

> Unfortunately we could not find a way to do it with search replace like prior steps, so you have to manually do it

Please note that if you only have one property with [Identity] attribute in your row class and it matches the ID property you don't need to put [IdProperty] explicitly. Same applies to [PrimaryKey] as long as it is just one.

> Tip: Fields with `[Identity]` attribute implicitly has the `PrimaryKey` flag as it is a combination of AutoIncrement and PrimaryKey. If you have an auto increment field that is not a primary key, it should be marked with `[AutoIncrement]` not `[Identity]`.

The order for precedence to determine the ID property is [IdProperty] => Single [Identity] => Single [PrimaryKey].

So if your ID property can't be determined by [Identity] or [PrimaryKey] attributes, or if you prefer to be explicit, add [IdProperty] like this:

```csharp
[..., IdProperty] 
public Guid? CustomerId
{
    get { return Fields.CustomerId[this]; }
    set { Fields.CustomerId[this] = value; }
}
```

If you prefer to do it with search / replace again, here is the way (warning might be slow due to complexity of the regex):

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `(\[[^\{\}]*)(\][\r\n\s]*public [A-Za-z0-9]+\?? )([A-Za-z]+)(\s*\r?\n+[\s\S\n]+)(\r?\n\s*IIdField\s*IIdRow.IdField[\s\r\n]*(\{[\r\n\s]*get[r\n\s]*\{[\r\n\s]*return|=>\s*) Fields.)(\3)([\s]*;([\r\n\s]*\}[\r\n\s]*\}|))\r?\n?\r?\n?` in `Find` input

* Type `$1, IdProperty$2$3$4` in `Replace` input

* Click `Replace All`

* Save all open files if any

## Replacing INameRow.NameField with [NameProperty] Attribute

Just like IIdRow, you may also you have `INameRow` interface implemented like below:

```csharp
// we will delete this
StringField INameRow.NameField
{
    get { return Fields.CustomerName; }
}
```

Again, this interface is still there, but it does not have `NameField` property now.

We replaced it with `[NameProperty]` attribute as old explicit style made determining that field without creating a row instance first difficult, and it had to be a string field before.

You need to find all such rows by searching for `INameRow.NameField`. Then take a note of `NameField`, delete the block, and put a `[NameProperty]` attribute on corresponding property. 

For the example above, CustomerName property will be like this:

```csharp
[..., NameProperty] 
public String CustomerName
{
    get { return Fields.CustomerName[this]; }
    set { Fields.CustomerName[this] = value; }
}
```

If you prefer to do it with search / replace again, here is the way (warning might be slow due to complexity of the regex):

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `(\[[^\{\}]*)(\][\r\n\s]*public [A-Za-z0-9]+\?? )([A-Za-z]+)(\s*\r?\n+[\s\S\n]+)(\r?\n\s*StringField\s*INameRow.NameField[\s\r\n]*(\{[\r\n\s]*get[r\n\s]*\{[\r\n\s]*return|=>\s*) Fields.)(\3)([\s]*;([\r\n\s]*\}[\r\n\s]*\}|))\r?\n?` in `Find` input

* Type `$1, NameProperty$2$3$4` in `Replace` input

* Click `Replace All`

* Save all open files if any

## Replacing `IIdField` References with `Field`

The IIdField interface is removed, and interfaces like IInsertLogRow and IUpdateLogRow uses `Field` instead of `IIdField`.

So if you had these (for example in LoggingRow.cs):

```csharp
IIdField IInsertLogRow.InsertUserIdField
{
    get { return loggingFields.InsertUserId; }
}

IIdField IUpdateLogRow.UpdateUserIdField
{
    get { return loggingFields.UpdateUserId; }
}
```

Need to replace them with these:

```csharp
Field IInsertLogRow.InsertUserIdField
{
    get { return loggingFields.InsertUserId; }
}

Field IUpdateLogRow.UpdateUserIdField
{
    get { return loggingFields.UpdateUserId; }
}
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `(\s?)IIdField(\s+)` in `Find` input

* Type `$1Field$2` in `Replace` input

* Click `Replace All`

* Save all open files if any


## Using `fields` instead of `Fields` in Row Properties

The new static `Fields` instance in base Row class is resolved from a `RowFieldsProvider` for current thread context everytime it is accessed.

We used to have such properties in Row.cs:

```csharp
public int? CountryID
{
    get { return Fields.CountryID[this]; }
    set { Fields.CountryID[this] = value; }
}
```

We need to replace `Fields` with `fields` as they might be different in rare cases (multi-tenant scenarios). Also it is much slower to access `Fields` than `fields`.

We'll replace them like below (also using new property syntax):

```csharp
public int? CountryID
{
    get => fields.CountryID[this];
    set => fields.CountryID[this] = value;
}
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `(^[\t ]*)(get|set)[ \t]*(\=\>|\{)[\t ]*(return|)[\t ]*F(ields\.[^\^;}]*)\;[\t ]*\}?[\t ]*\r?$` in `Find` input

* Type `$1$2 => f$5;` in `Replace` input

* Click `Replace All`

* Save all open files if any

## Replacing Check.NotNull Calls

We used to have a helper class to check for nulls and empty strings etc. but Visual Studio analyzer still raised warnings even if you check for null using those helpers.

So, we decided to remove that class completely.

If you had a check like below:

```csharp
Check.NotNull(request.Something, nameof(request.Something));
```

Replace it with:

```csharp
if (request.Something == null)
    throw new ArgumentNullException(nameof(request.Something));
```

Here is the search replace method that can do it:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)Check.NotNull\(([A-Za-z0-9\.]+),\s*([^\n\r]*)\);([\r]?\n)` in `Find` input

* Type <pre>`$1if ($2 is null)$4$1    throw new ArgumentNullException($3);$4`</pre> in `Replace` input

* Click `Replace All`

## Replacing Check.NotNullOrEmpty Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)Check.NotNullOrEmpty\(([A-Za-z0-9\.]+),\s*([^\n\r]*)\);([\r]?\n)` in `Find` input

* Type <pre>`$1if (string.IsNullOrEmpty($2))$4$1    throw new ArgumentNullException($3);$4`</pre> in `Replace` input

* Click `Replace All`

## Replacing Check.NotNullOrWhiteSpace Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)Check.NotNullOrWhiteSpace\(([A-Za-z0-9\.]+),\s*([^\n\r]*)\);([\r]?\n)` in `Find` input

* Type <pre>`$1if (string.IsNullOrWhiteSpace($2))$4$1    throw new ArgumentNullException($3);$4`</pre> in `Replace` input

* Click `Replace All`

* Save all open files if any

## Replacing request.CheckNotNull Calls

If you had a check like below:

```csharp
request.CheckNotNull();
```

Replace it with:

```csharp
if (request is null)
    throw new ArgumentNullException(nameof(request));
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)request.CheckNotNull\(\);([\r]?\n)` in `Find` input

* Type <pre>`$1if (request is null)$2$1    throw new ArgumentNullException(nameof(request));$2`</pre> in `Replace` input

* Click `Replace All`

* Save all open files if any

## Add System Namespace to Files with Errors

You might get `The type or namespace name 'ArgumentNullException'...` after doing prior changes, so please add `using System;` to any file that you get that error in, for example `SergenEndpoint.cs` and `UserPreferenceRepository.cs`

## Moving BackgroundJobManager.Settings Class Outside

If you have a project created from a recent StartSharp template, you may have a `BackgroundJobManager.cs` file like below:

```cs
        //...
            isDisabled = !Config.Get<Settings>().Enabled;
        //...

        public static void Register(IBackgroundJob task)
        {
            Process();
        }

        [SettingScope("Application"), SettingKey("BackgroundJobs")]
        public class Settings
        {
            public bool Enabled { get; set; }
        }
    }
}
```

The Settings class is a nested one, and we need to move it outside the BackgroundJobManager class, and rename it to `BackgroundJobSettings`:

```cs
        //...
            isDisabled = !Config.Get<BackgroundJobSettings>().Enabled;
        //...

        public static void Register(IBackgroundJob task)
        {
            Process();
        }
    }

    [SettingScope("Application"), SettingKey("BackgroundJobs")]
    public class BackgroundJobSettings
    {
        public bool Enabled { get; set; }
    }
}
```

## Replacing `SettingScope` and `SettingKey`

Serenity applications used to have settings like following which are read through a special `Config` class when required:

```csharp
[SettingScope("Application"), SettingKey("MyCustomKey")]
public class MyCustomSettings
{
}
```

We removed the `Config` class and will be using .NET Core configuration / options instead.


> See following documents on how it works:
> https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-5.0
> https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-5.0

Previous class will be replaced with following:

```csharp
[SettingScope("Application"), SettingKey("MyCustomKey")]
public class MyCustomSettings
{
    public const string ConfigurationPath = "AppSettings:MyCustomKey";
}
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `[\t ]*\[[\t ]*(SettingScope\(.*\)\,|)[\t ]*SettingKey\("(.*)"\)\][\t ]*\r?\n[\s\r\n]*public class[\t ]*([A-Za-z0-9]*)[\t ]*(\r?\n)[\r\n]*([\t ]*)\{` in `Find` input

* Type `$5// services.Configure<$3>(Configuration.GetSection($3.SectionKey));$4$5public class $3$4$5{$4$5    public const string SectionKey = "$2";$4` in `Replace` input

* Click `Replace All`

Now your setting class will turn into this:

```csharp
// services.Configure<InstalledModuleSettings>(Configuration.GetSection(MyCustomSettings.SectionKey));
public class MyCustomSettings
{
    public const string SectionKey = "MyCustomKey";
}
```

Please copy the commented like (except //) and paste it inside `Startup.cs` -> `ConfigureServices` method:

```cs
public void ConfigureServices(IServiceCollection services)
{
    //...
    services.Configure<MyCustomSettings>(Configuration.GetSection(MyCustomSettings.SectionKey));
    //...
}
```

You may need to add the namespace for MyCustomSettings to usings in Startup.cs.

After that delete the commented line above MyCustomSettings. 

And finally open `appsettings.json` file and move the setting inside `AppSettings` subsection to root:

```json
{
    "AppSettings": {
        // ...before lines
        "MyCustomKey": {

        }
        // ...after lines
    }
}
```

should be replaced with:

```json
{
    "AppSettings": {
        // ...before lines
        // ...after lines
    },
    "MyCustomKey": {

    }
}
```

> Serenity used to keep its own settings under `AppSettings:` for historical reasons. This prefix is no longer used.

Repeat steps above for all settings classes you have.

## Migrating EnvironmentSettings

As EnvironmentSettings class under `Modules/Membership/Account/EnvironmentSettings.cs` does not have `SettingKey` attribute, modify the class like below and repeat changes in `appsettings.json` and `Startup.cs` for it.

```cs
public class EnvironmentSettings
{
    public const string SectionKey = "EnvironmentSettings";

    public string SiteExternalUrl { get; set; }
}
```

## Configuring Serenity Options

Just like we configured your custom settings with .NET options system in the last section, we also need to configure Serenity options.

Open `Startup.cs` file and add following under `ConfigureServices` method:

```cs
using Serenity.Data;
using Serenity.Web;

public void ConfigureServices(IServiceCollection services)
{
    //...
    services.Configure<ConnectionStringOptions>(Configuration.GetSection(ConnectionStringOptions.SectionKey));
    services.Configure<CssBundlingOptions>(Configuration.GetSection(CssBundlingOptions.SectionKey));
    services.Configure<LocalTextPackages>(Configuration.GetSection(LocalTextPackages.SectionKey));
    services.Configure<ScriptBundlingOptions>(Configuration.GetSection(ScriptBundlingOptions.SectionKey));
    services.Configure<UploadSettings>(Configuration.GetSection(UploadSettings.SectionKey));    
    //...
}
```

Edit `appsettings.json` and move following out from `AppSettings`:

```json
{
    "AppSettings": {
        // ...before lines
        "CssBundling": {
        },
        "ScriptBundling": {
        },
        "UploadSettings": {
        },
        "LocalTextPackages": {
        }
        // ...after lines
    }
}
```

should be replaced with:

```json
{
    "AppSettings": {
        // ...before lines
        // ...after lines
    },
    "CssBundling": {
    },
    "ScriptBundling": {
    },
    "UploadSettings": {
    },
    "LocalTextPackages": {
    }
}
```

You may delete `AppSettings` key if nothing left under it after doing this.

## Migrating LocalTextPackages Setting

LocalTextPackages determines the list of text bundles that are allowed to be sent to the browser. They used to be a list of prefixes:

```json
"LocalTextPackages": {
    "Site": [
        "Controls.",
        "Db.",
        "Dialogs.",
        "Enums.",
        "Forms.",
        "Permission.",
        "Site.",
        "Validation."
    ],
    "Login": [
        "Forms.Membership.Login.",
        "Db.Administration.User.",
        "Validation.Required",
        "Dialogs."
    ]
}
```

In the new version, packages are defined as a simple regular expression instead of an array of prefixes, so the previous setting in `appsettings.json` should be replaced with following:

```json
"LocalTextPackages": {
    "Site": "^(Controls|Db|Dialogs|Enums|Forms|Permission|Site|Validation)\\.",
    "Login": "^(Forms\\.Membership\\.Login|Db\\.Administration\\.User|Validation\\.Required|Dialogs)\\."
}
```
> Simply put a `^(` followed by previous prefixes separated by `|` then `)\\.`, while `.` inside the prefixes should be replaced with `\\.`. If you haven't modified anything there, then just use our sample.

## Migrating CssBundles.json and ScriptBundles.json to Options System

We used to have `wwwroot/Scripts/site/ScriptBundles.json` and `wwwroot/Content/site/CssBundles.json` files. These bundles are still there but needs to be migrated to .NET options. Their contents should be moved to relevant sections inside a `appsettings.bundles.json` file.

So if you have `CssBundles.json` file like this:

```json
{
  "Libs": [
    "~/Content/font-open-sans.css",
  // ...
  ],
  "Site": [
    "~/Content/site/site.css"
  // ...
  ]
}
```

and a `ScriptBundles.json` file like this:

```json
{
    "Libs": [
    "~/Scripts/pace.js",
    // ...
    ],
    "Site": [
    "~/Scripts/adminlte/app.js",
    // ...
    ]
}
```

Create a `appsettings.bundles.json` file next to `appsettings.json` file and copy existing content under `ScriptBundles.json` and `CssBundles.json` like this:

```json
{
  "CssBundling": {
    "Bundles": { // this part is from CssBundles.json
      "Libs": [
        "~/Content/font-open-sans.css",
        // ...
      ],
      "Site": [
        "~/Content/site/site.css"
        // ...
      ]
    }
  },
  "ScriptBundling": {
    "Bundles": { // this part is from ScriptBundles.json
      "Libs": [
        "~/Scripts/pace.js",
        // ...
      ],
      "Site": [
        "~/Scripts/adminlte/app.js",
        // ...
      ]
    }
  }
}
```

Next we need to set this file as a JSON config source. Open `Program.cs` and add following line before `appsettings.machine.json`:

```cs
config.AddJsonFile("appsettings.bundles.json");
config.AddJsonFile("appsettings.machine.json", optional: true);
```

You may delete `CssBundles.json` and `ScriptBundles.json` afterwards.

## Replacing `Config.Get<TSettings>` Calls

As noted in previous sections, `Config` class is removed and we'll be using .NET options pattern instead.

Unfortunately this is not something we can do simply with Search/Replace.

> We'll list some samples below for your custom cases, and will show steps for DataExplorer, BackgroundJobManager in the following sections

If you were reading configuration in a Controller:

```csharp
public class MyController : Controller
{
    public ActionResult SomeAction(...)
    {
        var config = Config.Get<MyCustomSettings>();
    }
}
```

You may replace it like this:

```csharp
using Microsoft.Extensions.Options;

public class MyController : Controller
{
    public ActionResult SomeAction([FromServices] IOptions<MyCustomSettings> myCustomSettings...)
    {
        var config = myCustomSettings.Value;
    }
}
```

Or if you prefer constructor injection:

```csharp
using Microsoft.Extensions.Options;

public class MyController : Controller
{
    MyCustomSettings myCustomSettings;

    public MyController(IOptions<MyCustomSettings> myCustomSettings)
    {
        this.myCustomSettings = myCustomSettings.Value;
    }

    public ActionResult SomeAction(...)
    {
        var config = myCustomSettings;
    }
}
```

If you are accessing the setting from a repository method you need to inject the configuration to the service endpoint (controller) using one of the methods shown above, and pass the setting to the constructor / method of your repository:

```csharp
public class MyController : ServiceEndpoint
{
    public ServiceResponse SomeServiceCall(MyRequest serviceRequest, 
        [FromServices] IOptions<MyCustomSettings> myCustomSettings)
    {
        return new MyRepository().SomeServiceCall(serviceRequest, myCustomSettings)
    }
}

public class MyRepository
{
    public ServiceResponse SomeServiceCall(MyRequest serviceRequest, 
        IOptions<MyCustomSettings> myCustomSettings)
    {
        // use myCustomSettings here
    }
}
```

If you are accessing the setting from a view, and it is not possible to pass it from controller (layout page?), inject it like:

```html
@model MyModel
@using Microsoft.Extensions.Options
@inject IOptions<MyCustomSettings> myCustomSettings
<div>
    @if (myCustomSettings?.Value.SomeFlag == true) 
    {

    }
  ...
</div>
```

## Fixing `Config.Get` in DataExplorerEndpoint.cs

If you have DataExplorer sample in your StartSharp based project, do following steps in
`DataExplorerEndpoint.cs`:

> You may also get latest DataExplorerEndpoint.cs from StartSharp repository.

> All replaces is given as regex as before, but should be applied only to the specified file.

* Add `using Microsoft.Extensions.Options` after `using Microsoft.AspNetCore.Mvc;`
* Replace `Request request\)` with `Request request, [FromServices] IOptions<DataExplorerConfig> options`
* Replace `Config\.Get<DataExplorerConfig>\(\)` with `options.Value`
* Replace `ListConnections\(new ListRequest\(\)\)` with `ListConnections(new ListRequest(), options)`
* Replace `ConnectionKey \}\)` with `ConnectionKey }, options)`

## Fixing `Config.Get` in BackgroundJobManager.cs

If you have `BackgroundJobManager` in your project, do following in `BackgroundJobManager.cs`:

> You may also get latest BackgroundJobManager.cs from StartSharp repository.

* Add `using Microsoft.Extensions.Options;` and `using Serenity.Abstractions;`
* Replace `static ` with empty string.
* Replace `public class BackgroundJobManager` with `public class BackgroundJobManager : IBackgroundJobManager`
* Add `private IExceptionLogger logger;` after `private bool isDisabled;`
* Replace `BackgroundJobManager\(\)` with `public BackgroundJobManager(IOptions<BackgroundJobSettings> options, IExceptionLogger logger = null)`
* Replace `Config.Get\<BackgroundJobSettings\>\(\)\.Enabled;` with `options.Value.Enabled;` and add `this.logger = logger;` line after that.
* Replace `ex.Log\(\)` with `ex.Log(logger)`

Add a `IBackgroundJobManager.cs` file with following content next to `BackgroundJobManager.cs`, replacing the namespace with yours:

```cs
namespace YourNamespace.Common.Services
{
    public interface IBackgroundJobManager
    {
        void Initialize();
        void Register(IBackgroundJob task);
        void Reset();
    }
}
```

Edit `Startup.cs` and do following steps:

* Add `services.AddSingleton<IBackgroundJobManager, BackgroundJobManager>();` after `services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();` line.

* Add `var backgroundJobManager = app.ApplicationServices.GetRequiredService<IBackgroundJobManager>();` before the first `BackgroundManager.Register(...)` line.

* Replace `BackgroundJobManager\.` with `backgroundJobManager.`


## Replacing EmailHelper with a IEmailSender Interface

We used to have an EmailHelper static class which makes testing difficult, so it will be replaced with an abstraction.

Delete `Modules/Common/EmailHelper.cs` file and create a `Modules/Common/EmailSender` folder with following files in it (replace namespace with your project namespace):

> Warning! If you made any modifications to EmailHelper.cs, you need to apply your changes to new style manually

* IEmailSender.cs:

```cs
using MimeKit;

namespace YourProject.Common
{
    public interface IEmailSender
    {
        void Send(MimeMessage message, bool skipQueue = false);
    }
}
```

* SmtpSettings.cs:

```cs
namespace YourProject.Common
{
    public class SmtpSettings
    {
        public const string SectionKey = "SmtpSettings";

        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
        public string From { get; set; }
        public string PickupPath { get; set; }
    }
}
```

* EmailSender.cs:

```cs
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using MimeKit;
using Serenity.Data;
using YourProject.Common.Entities;
using YourProject.Common.Services;
using System;
using System.IO;

namespace YourProject.Common
{
    public class EmailSender : IEmailSender
    {
        private IWebHostEnvironment host;
        private SmtpSettings smtp;
        // these three lines below are only for StartSharp with mail queue
        private MailingServiceSettings mailing; 
        private ISqlConnections connections;
        private IUserAccessor userAccessor;

        public EmailSender(IWebHostEnvironment host, IOptions<SmtpSettings> smtp,
            // below line is only for StartSharp with mail queue
            IOptions<MailingServiceSettings> mailing, ISqlConnections connections, IUserAccessor userAccessor) 
        {
            this.host = (host ?? throw new ArgumentNullException(nameof(host)));
            this.smtp = (smtp ?? throw new ArgumentNullException(nameof(smtp))).Value;
            // three lines below only for StartSharp with mail queue
            this.mailing = (mailing ?? throw new ArgumentNullException(nameof(mailing))).Value;
            this.connections = connections ?? throw new ArgumentNullException(nameof(connections));
            this.userAccessor = userAccessor ?? throw new ArgumentNullException(nameof(userAccessor));
        }

        public void Send(MimeMessage message, bool skipQueue)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            if (message.From.Count == 0 && !string.IsNullOrEmpty(smtp.From))
                message.From.Add(MailboxAddress.Parse(smtp.From));

            // this first if block is only for StartSharp with mail queue
            if (!skipQueue && mailing.AutoUse)
            {
                using (var connection = connections.NewFor<MailRow>())
                    new MailingService().Enqueue(connection, message, userAccessor);
            }
            else if (!string.IsNullOrEmpty(smtp.Host))
            {
                using var client = new SmtpClient();
                client.Connect(smtp.Host, smtp.Port, smtp.UseSsl);
                client.Send(message);
                client.Disconnect(true);
            }
            else
            {
                var pickupPath = string.IsNullOrEmpty(smtp.PickupPath) ?
                    Path.Combine(host.ContentRootPath, "App_Data", "Mail") : 
                    Path.Combine(host.ContentRootPath, smtp.PickupPath);
                if (!Directory.Exists(pickupPath))
                    Directory.CreateDirectory(pickupPath);
                message.WriteTo(Path.Combine(pickupPath, DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") + ".eml"));
            }
        }
    }
}
```

* EmailSenderExtensions.cs:

```cs
using MimeKit;
using System;

namespace YourProject.Common
{
    public static class EmailSenderExtensions
    {
        public static void Send(this IEmailSender emailSender, string subject, string body, string mailTo)
        {
            var message = new MimeMessage();
            if (mailTo == null)
                throw new ArgumentNullException(nameof(mailTo));
            message.To.Add(MailboxAddress.Parse(mailTo));
            message.Subject = subject;
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = body
            };
            message.Body = bodyBuilder.ToMessageBody();
            emailSender.Send(message);
        }
    }
}
```

* Register IEmailSender as Singleton Service in Startup.cs:

```cs
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
services.AddSingleton<Common.IEmailSender, Common.EmailSender>();
```

## Fixing MailingService

If you have StartSharp mail queue feature, do following changes:

* Add `using Serenity.Abstractions;`
* Add a `IUserAccessor` parameter to `Enqueue` method:

```cs
public void Enqueue(IDbConnection connection, MimeMessage message, IUserAccessor userAccessor, Guid? uid = null)
{
    //...
    mail.InsertUserId = userAccessor?.User.GetIdentifier() == null ? (int?)null : 
        Convert.ToInt32(userAccessor?.User.GetIdentifier());
    //...
}
```

* Add two parameters to `SendById` method:

```cs
public bool SendById(IDbConnection connection, long mailId, IEmailSender emailSender, int retryLimit)
```

* Change the try catch block inside `SendById` method like this:

```cs
    try
    {
        var message = BuildMessage(mail);
        emailSender.Send(message);
    }
    catch (Exception ex)
    {
        errorMessage = ex.Message;
        status = retryCount < retryLimit ? MailStatus.InQueue : MailStatus.Failed;
    }
```

## Fixing MailingBackgroundJob

If you have StartSharp mailing background job, do following changes in `MailingBackgroundJob.cs`:

* Add `using Serenity.Abstractions;` and `using Microsoft.Extensions.Options;`
* Add following fields and constructor:

```cs
public class MailingBackgroundJob : PeriodicBackgroundJob
{
    private readonly ISqlConnections connections;
    private readonly IEmailSender emailSender;
    private readonly MailingServiceSettings config;
    private readonly IExceptionLogger logger;

    public MailingBackgroundJob(ISqlConnections connections, IEmailSender emailSender, 
        IOptions<MailingServiceSettings> options, IExceptionLogger logger = null)
    {
        this.connections = connections ?? throw new ArgumentNullException(nameof(connections));
        this.emailSender = emailSender ?? throw new ArgumentNullException(nameof(emailSender));
        config = (options ?? throw new ArgumentNullException(nameof(options))).Value;
        this.logger = logger;
    }
```

* Remove two `var config = Config.Get<MailingServiceSettings>();` lines
* Replace `SqlConnections.NewFor` with `connections.NewFor`
* Replace `ex.Log()` with `ex.Log(logger)`
* Replace `new MailingService().SendById(connection, mail.MailId.Value);` with `new MailingService().SendById(connection, mail.MailId.Value, emailSender, config.RetryLimit);`

Edit `Startup.cs`:

* Replace `new MailingBackgroundJob()` with `ActivatorUtilities.CreateInstance<MailingBackgroundJob>(app.ApplicationServices)`

## Removing `Serenity.Configuration` Namespace

No such namespace exists anymore, so we need to delete any references to it:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `using Serenity\.Configuration\;[\t ]*\r?\n` in `Find` input

* Clear value in `Replace` input

* Click `Replace All`

## Replace `Serenity.Extensibility` Namespace with `Serenity.ComponentModel`

`NestedPermissions` and `NestedLocalTexts` in `Serenity.Extensibility` namespace are moved to `Serenity.ComponentModel` namespace.

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `using Serenity\.Extensibility\;(\t ]*\r?\n)` in `Find` input

* Type `using Serenity.ComponentModel$1` in `Replace` input

* Click `Replace All`

There might be double usings for Serenity.ComponentModel after this in some files like `Startup.cs`, please remove one.


## Using `BaseRepository` and `IRequestContext` in Repositories

We have a new `IRequestContext` class declared like below which you can inject into your repositories, handlers, controllers and other kinds of classes.

```csharp
public interface IRequestContext
{
    IBehaviorProvider Behaviors { get; }
    ITwoLevelCache Cache { get; }
    ITextLocalizer Localizer { get; }
    IPermissionService Permissions { get; }
    ClaimsPrincipal User { get; }
}
```

This interface simply contains references to minimum set of services that repositories, request handlers and endpoints might need in a Serenity application:
- *Behaviors*: Provides access to service behaviors, mostly used by request handlers
- *Cache*: ITwoLevelCache instance which also provides access to MemoryCache and DistributedCache services
- *Localizer*: Text localizer (required for LocalText to string conversion)
- *Permissions*: Access to permission service
- *User*: Provides access to current user (HttpContext.User in web contexts)

> We could inject these services into your repositories / handlers separately but this design allows us to add new services to this interface in the future if required without breaking your code. As .NET dependency injection only supports Constructor Injection by default, if we had to add these as separate constructor injection arguments, you would have to change all your derived constructors if we decide to add a new required interface to our base constructors.

We also created a base repository class that accepts a IRequestContext parameter and provides access to these services as properties of itself.

```csharp
public class BaseRepository
{
    public BaseRepository(IRequestContext context)
    {
        Context = context ?? throw new ArgumentNullException(nameof(context));
    }

    protected IRequestContext Context { get; }
    protected ITextLocalizer Localizer => Context.Localizer;
    protected IPermissionService Permissions => Context.Permissions;
    protected ClaimsPrincipal User => Context.User;
}
```

We are now going to set this as base class for all your existing repositories:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)public[\t ]+class[\t ]+([A-Za-z0-9_]*)Repository[\t ]*(\r?\n|)[\t ]*\{` in `Find` input

* Type `$1public class $2Repository : BaseRepository$3$1{$3$1$1public $2Repository(IRequestContext context)$3$1$1$1 : base(context)$3$1$1{$3$1$1}$3` in `Replace` input

* Click `Replace All`

## Handling UserRepository

If your UserRepository is a partial class it will not be handled by previous regex, so need to manually add the constructor:

> Partial repositories might have multiple files and including them in previous regex would create multiple constructors, which would be invalid.

Open `UserRepository.cs` and modify it like below:

```csharp
public partial class UserRepository : BaseRepository
{
    public UserRepository(IRequestContext context)
        : base(context)
    {
    } 

    // ...
}
```

## Adding a constructor that accepts `IRequestContext` to Request Handlers

Just like we added a constructor that accepts IRequestContext for repositories, we need to do it for RequestHandlers.

You should have classes like below in your repositories:

```csharp
private class MySaveHandler : SaveRequestHandler<MyRow> 
{ 

}
```

They now need a constructor with IRequestContext parameter as all base request handlers have one.

```csharp
private class MySaveHandler : SaveRequestHandler<MyRow> 
{ 
    public MySaveHandler(IRequestContext context)
        : base(context)
    {
    }
}
```

First do it for handlers that are not empty:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)(private|public)[\t ]+class[\t ]+My(Save|Retrieve|List|Delete)Handler[\t ]*\:[\t ]*(\3)RequestHandler(\<[A-Za-z\.\, \t]+\>)[\t ]*\{?[\t ]*(\r?\n)[\t\r\s]*\{` in `Find` input

* Type <pre>`$1$2 class My$3Handler : $3RequestHandler$5$6$1{$6$1    public My$3Handler(IRequestContext context)$6$1$1 : base(context)$6$1    {$6$1    }$6`</pre> in `Replace` input

* Click `Replace All`

Now will repeat it for empty handlers:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)(private|public)[\t ]+class[\t ]+My(Save|Retrieve|List|Delete)Handler[\t ]*\:[\t ]*(\3)RequestHandler(\<[A-Za-z\.\, \t]+\>)[\t ]*\{?[\t ]*\}[\t ]*(\r?\n)([\t\r\s]*\n)?` in `Find` input

* Type <pre>`$1$2 class My$3Handler : $3RequestHandler$5$6$1{$6$1    public My$3Handler(IRequestContext context)$6$1$1 : base(context)$6$1    {$6$1    }$6$1}$6$6`</pre> in `Replace` input

* Click `Replace All`

## Pass `Context` to Handler Constructors

As all handlers now requires a `context` parameter, need to pass it to them, so all calls like this:

```csharp
new MySaveHandler().Process(uow, request, SaveRequestType.Create);
```

will be replaced with:

```csharp
new MySaveHandler(Context).Process(uow, request, SaveRequestType.Create);
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `new[\t ]*My(Save|Retrieve|List|Delete)Handler[\t ]*\([\t ]*\)`

* Type <pre>`new My$1Handler(Context)`</pre> in `Replace` input

* Click `Replace All`

## Passing `Context` to Repository Constructors

As all repositories now requires a `context` parameter, need to pass it to them, so all calls like this:

```csharp
new MyRepository().Create(uow, request);
```

will be replaced with:

```csharp
new MyRepository(Context).Create(uow, request);
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `new[\t ]*([A-Za-z0-9_]*)Repository[\t ]*\([\t ]*\)`

* Type <pre>`new $1Repository(Context)`</pre> in `Replace` input

* Click `Replace All`

## Getting `IRequestContext` Instance in Ordinary Pages

Service endpoints deriving from `ServiceEndpoint` base class (XyzEndpoint.cs) automatically has a reference to `Context` so the previous change we made for repository constructors will work with them, but ordinary controllers don't have that property.

So you'll need to use constructor injection / [FromServices] attribute like we did for options if you are creating a repository in any of Page.cs files:

```csharp
public ActionResult MyAction([FromServices] IRequestContext context)
{
    // ...
    var result = new MyRepository(context).Something();
    // ...
}
```

## Fixing LoggingRow and Derived Rows

If you are using `LoggingRow` sample:

```csharp
public abstract class LoggingRow : Row<LoggingRow.RowFields>, ILoggingRow
{
    protected LoggingRow(RowFieldsBase fields)
        : base(fields)
    {
```

Modify it like below:

```csharp
public abstract class LoggingRow<TFields> : Row<TFields>, ILoggingRow
        where TFields : LoggingRowFields
{
    protected LoggingRow(TFields fields) : base(fields) { }
    protected LoggingRow() : base() { }

    [NotNull, Insertable(false), Updatable(false)]
    public Int32? InsertUserId 
    { 
        get => fields.InsertUserId[this]; 
        set => fields.InsertUserId[this] = value; 
    }

    [NotNull, Insertable(false), Updatable(false)]
    public DateTime? InsertDate
    { 
        get => fields.InsertDate[this]; 
        set => fields.InsertDate[this] = value; 
    }

    [Insertable(false), Updatable(false)]
    public Int32? UpdateUserId 
    { 
        get => fields.UpdateUserId[this]; 
        set => fields.UpdateUserId[this] = value; 
    }

    [Insertable(false), Updatable(false)]
    public DateTime? UpdateDate 
    { 
        get => fields.UpdateDate[this]; 
        set => fields.UpdateDate[this] = value; 
    }

    Field IInsertLogRow.InsertUserIdField => fields.InsertUserId;
    Field IUpdateLogRow.UpdateUserIdField => fields.UpdateUserId;
    DateTimeField IInsertLogRow.InsertDateField => fields.InsertDate;
    DateTimeField IUpdateLogRow.UpdateDateField => fields.UpdateDate;
}

public class LoggingRowFields : RowFieldsBase
{
    public Int32Field InsertUserId;
    public DateTimeField InsertDate;
    public Int32Field UpdateUserId;
    public DateTimeField UpdateDate;

    public LoggingRowFields(string tableName = null, string fieldPrefix = null)
        : base(tableName, fieldPrefix)
    {
    }
}
```

And if you have a row that derives from `LoggingRow`:

```csharp
public class SomeRow : LoggingRow, IIdRow
{
    public class SomeFields : LoggingRow.LoggingRowFields 
    {
    }
}
```

It should become:

```csharp
public class SomeRow : LoggingRow<SomeRow.RowFields>, IIdRow
{
    public class RowFields : LoggingRowFields 
    {
    }
}
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `class\s*([A-Za-z0-9_]*)Row\s*:\s*([A-Za-z0-9_.]*)LoggingRow\s*[^<]`

* Type <pre>`class $1Row : $2LoggingRow<$1Row.RowFields>,`</pre> in `Replace` input

* Click `Replace All`

* Type `class\s*RowFields\s*:\s*([a-zA-Z0-9_.]*)LoggingRow\.LoggingRowFields` in `Find` input

* Type <pre>`class RowFields : $1LoggingRowFields`</pre> in `Replace` input

* Click `Replace All`

## Replacing IAuthorizationService with IUserAccessor

`IAuthorizationService` interface which was used to access current user is removed and needs to be replaced with `IUserAccessor` interface which does a similar work but more compatible with ASP.NET Core authentication system.

```csharp
services.AddSingleton<IAuthorizationService, AuthorizationService>();
```

AuthorizationService class in under Initialization folder should be removed and you can use `Serenity.Web.HttpContextUserAccessor` instead:

```csharp
services.AddSingleton<IAuthorizationService, Serenity.Web.HttpContextUserAccessor>();
```

If you also need impersonation support, you should use following class instead:

```csharp
using Microsoft.AspNetCore.Http;
using Serenity.Abstractions;
using Serenity.Web;
using System.Security.Claims;

public class UserAccessor : IUserAccessor, IImpersonator
{
    private ImpersonatingUserAccessor impersonator;

    public UserAccessor(IHttpContextAccessor httpContextAccessor)
    {
        impersonator = new ImpersonatingUserAccessor(new HttpContextUserAccessor(httpContextAccessor), 
            new HttpContextItemsAccessor(httpContextAccessor));
    }

    public ClaimsPrincipal User => impersonator.User;

    public void Impersonate(ClaimsPrincipal user)
    {
        impersonator.Impersonate(user);
    }

    public void UndoImpersonate()
    {
        impersonator.UndoImpersonate();
    }
}

// Startup.cs
services.AddSingleton<IAuthorizationService, UserAccessor>();
```

## Remove References to Dependency

We use .NET dependency injection and there is no longer a `Dependency` class, so remove this line in `Startup.cs`:

```csharp
Dependency.SetResolver(new DependencyResolver(app.ApplicationServices));
```

And remove `DependencyResolver` class under `Initialization` folder.

Also if you use `Dependency.Resolve` anywhere, replace those calls with constructor injection, or [FromServices] attribute.

## Replacing SelfAssemblies with ITypeSource

Serenity apps used to hold a `ExtensibilityHelper.SelfAssemblies` array, which was used to find types used by Serenity like forms, lookup scripts etc. but it is now removed and will be replaced with an `ITypeSource` abstraction.

So given the code below in Startup.cs:

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
    ILoggerFactory loggerFactory, IAntiforgery antiforgery)
{
    Serenity.Extensibility.ExtensibilityHelper.SelfAssemblies = 
        new System.Reflection.Assembly[]
    {
        typeof(LocalTextRegistry).Assembly,
        typeof(SqlConnections).Assembly,
        typeof(Row).Assembly,
        typeof(SaveRequestHandler<>).Assembly,
        typeof(WebSecurityHelper).Assembly,
        typeof(Startup).Assembly
    };
    //...
}
```

It should be moved to start of ConfigureServices method and replaced with a ITypeSource service registration.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<ITypeSource>(new DefaultTypeSource(new[] 
    {
        typeof(LocalTextRegistry).Assembly,
        typeof(ISqlConnections).Assembly,
        typeof(IRow).Assembly,
        typeof(SaveRequestHandler<>).Assembly,
        typeof(IDynamicScriptManager).Assembly,
        typeof(Startup).Assembly
    }));
```

## Fixing Local Text Initialization

Text registration block in Startup.cs:

```csharp
public static void InitializeLocalTexts(ILocalTextRegistry textRegistry,       
    IWebHostEnvironment env)
{
    textRegistry.AddNestedTexts();
    textRegistry.AddNestedPermissions();
    textRegistry.AddEnumTexts();
    textRegistry.AddRowTexts();
    textRegistry.AddJsonTexts(Path.Combine(env.WebRootPath, 
        "Scripts/serenity/texts".Replace('/', Path.DirectorySeparatorChar)));
    textRegistry.AddJsonTexts(Path.Combine(env.WebRootPath, 
        "Scripts/site/texts".Replace('/', Path.DirectorySeparatorChar)));
    textRegistry.AddJsonTexts(Path.Combine(env.ContentRootPath, 
        "App_Data/texts".Replace('/', Path.DirectorySeparatorChar)));
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
    ILoggerFactory loggerFactory, IAntiforgery antiforgery)
{
    var textRegistry = app.ApplicationServices.GetRequiredService<ILocalTextRegistry>();
    InitializeLocalTexts(textRegistry, env);
    //...
```

should be replaced with this:

```csharp
public static void InitializeLocalTexts(IServiceProvider services)
{
    var env = services.GetRequiredService<IWebHostEnvironment>();

    services.AddAllTexts(new[]
    {
        Path.Combine(env.WebRootPath, "Scripts", "serenity", "texts"),
        Path.Combine(env.WebRootPath, "Scripts", "site", "texts"),
        Path.Combine(env.ContentRootPath, "App_Data", "texts")
    });
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
    ILoggerFactory loggerFactory, IAntiforgery antiforgery)
{
    InitializeLocalTexts(app.ApplicationServices);
    // ...
```

And if you have this line in `TranslationRepository.cs`:

```cs
public SaveResponse Update(TranslationUpdateRequest request)
{
    // ...
    Startup.InitializeLocalTexts(localTextRegistry, 
        Dependency.Resolve<IWebHostEnvironment>());
```

Replace it with:

```cs
public SaveResponse Update(TranslationUpdateRequest request, IServiceProvider services)
{
    // ...
    Startup.InitializeLocalTexts(services);
```

And in `TranslationEndpoint.cs`:

```cs
[HttpPost]
public SaveResponse Update(TranslationUpdateRequest request)
{
    return new MyRepository(Context).Update(request, HttpContext.RequestServices);
}
```

## Replacing Old IRequestContext Registration

If you have this line in Startup.cs:

```csharp
services.AddSingleton<IRequestContext, Serenity.Web.RequestContext>();
```

Replace it with:

```csharp
services.AddSingleton<IHttpContextItemsAccessor, HttpContextItemsAccessor>();
```

If you don't have that line but used a UserAccessor with impersonation support you still need to add it before registering the user accessor:

```csharp
services.AddSingleton<IHttpContextItemsAccessor, HttpContextItemsAccessor>();
services.AddSingleton<IUserAccessor, Administration.UserAccessor>();
```

## Fixing BatchGenerationUpdater Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `BatchGenerationUpdater\.OnCommit\((uow|this\.UnitOfWork|UnitOfWork),\s*(.*).GenerationKey\)`

* Type `Cache.InvalidateOnCommit($1, $2)` in `Replace` input

* Click `Replace All`

## Replacing Authorization.HasPermission Calls

Static Authorization class is removed and calls like below:

```csharp
Authorization.HasPermission("SomePermission")
```

with:

```csharp
Permissions.HasPermission("SomePermission")
```

where Permissions is a reference to `IPermissionService`. 

Handlers, repositories and service endpoints already has this property, but if you need it somewhere else (e.g. ordinary Controller), you need to use constructor injection / [FromServices] attribute.

```csharp
public ActionResult MyAction(...
    [FromServices] IPermissionService permissions) 
{
    permissions.HasPermission("SomePermission");
}
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `Authorization\.HasPermission\(([A-Za-z\."]*)\)` in `Find` input

* Type `Permissions.HasPermission($1)` in `Replace` input

* Click `Replace All`

## Replacing Authorization.ValidatePermission Calls

Static Authorization class is removed and calls like below:

```csharp
Authorization.ValidatePermission("SomePermission")
```

with:

```csharp
Permissions.ValidatePermission("SomePermission")
```

where Permissions is a reference to `IPermissionService` while Localizer is a reference to `ITextLocalizer`. 

Handlers, repositories and service endpoints already has these properties, but if you need it somewhere else (e.g. ordinary Controller), you need to use constructor injection / [FromServices] attribute like this:

```csharp
public ActionResult MyAction(...
    [FromServices] IPermissionService permissions, [FromServices] ITextLocalizer localizer) 
{
    permissions.ValidatePermission("SomePermission", localizer);
}
```

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `Authorization\.ValidatePermission\(([^\r\n]+)\);` in `Find` input

* Type `Permissions.ValidatePermission($1, Localizer);` in `Replace` input

* Click `Replace All`

* Type `Serenity\.Permissions` in `Find` input

* Type `Permissions.ValidatePermission($1, Localizer);` in `Replace` input

* Click `Replace All`

## Replacing TwoLevelCache.ExpireGroupItems Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `TwoLevelCache\.ExpireGroupItems` in `Find` input

* Type `Cache.ExpireGroupItems` in `Replace` input

* Click `Replace All`

## Replacing TwoLevelCache.Get and TwoLevelCache.GetLocalStoreOnly Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `TwoLevelCache\.Get` in `Find` input

* Type `Cache.Get` in `Replace` input

* Click `Replace All`

## Replacing TwoLevelCache.Remove Calls

* Type `TwoLevelCache\.Remove` in `Find` input

* Type `Cache.Remove` in `Replace` input

* Click `Replace All`

## Remove DetailListSaveHandler

There was a `DetailListSaveHandler` class that was used before MasterDetailRelation behavior was written, so you should delete `Modules/Common/Helpers/DetailListSaveHandler.cs`

## Replacing IdField Indexers and NotesBehavior.cs

As ID fields can now be any field, and there is no IIdField interface anymore, you should replace idField[row] calls with idField.AsObject.

Such an access is available in NotesBehavior (note that Notes behavior still expects integer ID fields).

Edit `Modules/Northwind/Note/NotesBehavior.cs`:

* Add following constructor and properties to `NotesBehavior`:

```csharp
public IRequestContext Context { get; }
public ISqlConnections SqlConnections { get; }

public NotesBehavior(IRequestContext context, ISqlConnections sqlConnections)
{
    Context = context ?? 
        throw new ArgumentNullException(nameof(context));
    SqlConnections = sqlConnections ?? 
        throw new ArgumentNullException(nameof(sqlConnections));
}
```

* Replace `idField\[handler\.Row\](\s)` with `idField.AsObject(handler.Row)$1`

* Replace `([A-Za-z]*dField)\[([A-Za-z\.]*)]\.Value` with `Convert.ToInt64($1.AsObject($2))`

* Replace `rowIdField\[item\]` with `rowIdField.AsObject(item)`

* Replace `id\.Value` with `Convert.ToInt64(id)`


## Fixing UserPermissionService

Take latest version of PermissionService.cs from StartSharp / Serene repository, or do following changes:

* Add following constructor and properties:

```csharp
protected ITwoLevelCache Cache { get; }
protected ISqlConnections SqlConnections { get; }
public ITypeSource TypeSource { get; }
protected IUserAccessor UserAccessor { get; }

public PermissionService(ITwoLevelCache cache, ISqlConnections sqlConnections, 
    ITypeSource typeSource, IUserAccessor userAccessor)
{
    Cache = cache ?? throw new ArgumentNullException(nameof(cache));
    SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
    TypeSource = typeSource ?? throw new ArgumentNullException(nameof(typeSource));
    UserAccessor = userAccessor ?? throw new ArgumentNullException(nameof(userAccessor));
}
```

* Change start of HasPermission method like this:

```csharp
public bool HasPermission(string permission)
{
    if (Authorization.Username == "admin")
    if (permission == null)
        return false;

    if (permission == "*")
        return true;

    var user = (UserDefinition)Authorization.UserDefinition;
    if (user == null)
    var isLoggedIn = UserAccessor.IsLoggedIn();

    if (permission == "?")
        return isLoggedIn;

    if (!isLoggedIn)
        return false;

    var username = UserAccessor.User?.Identity?.Name;
    if (username == "admin")
        return true;

    var userId = Convert.ToInt32(UserAccessor.User.GetIdentifier());
    //...
    // only admin has Impersonation...
```

* Replace `user\.UserId` with `userId`

* If have implicit permissions feature (StartSharp) replace `new Repositories\.UserPermissionRepository\(\)\.ImplicitPermissions` with `UserPermissionRepository.GetImplicitPermissions(Cache.Memory, TypeSource);` and change the code for ImplicitPermissions property in `UserPermissionRepository`:

```cs
public static Dictionary<string, HashSet<string>> GetImplicitPermissions(
    IMemoryCache memoryCache, ITypeSource typeSource)
{
    // ...


}
```

* Replace `LocalCache\.Get` with `memoryCache.Get` in GetImplicitPermissions
* Replace the code block that enumerates ExtensibilityHelper.SelfAssemblies like

```csharp
foreach (var type in typeSource.GetTypesWithAttribute(
                    typeof(NestedPermissionKeysAttribute)))
{
    addFrom(type);
}
```

> You may also get latest code from StartSharp

## Handling LocalText to String Conversion

We were able to simply pass a LocalText object to any method that requires a string, and it was automatically translated:

```cs
String.Format(Texts.Validation.MinRequiredPasswordLength, 5)
```

Unfortunately that is no longer possible as translation requires a localization context:

```cs
String.Format(Texts.Validation.MinRequiredPasswordLength.ToString(Localizer), 5);
```

Localizer is an ITextLocalizer object which is available in repositories, and service endpoints but should be injected in other contexts.

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `Texts\.([A-Za-z_.]*)([\s,;\<\r\n)])` in `Find` input

* Type `Texts.$1.ToString(Localizer)$2` in `Replace` input

* Make sure `File Types` is `*.cshtml; *.cs`

* Click `Replace All`

* Type `Texts\.([A-Za-z_.]*)\.ToString\(\)` in `Find` input

* Type `Texts.$1.ToString(Localizer)` in `Replace` input

* Click `Replace All`

## Handling LocalText.Get Calls

All calls like following:

```cs
LocalText.Get("SomeKey") 
LocalText.TryGet("SomeKey")
```

should be replaced with

```
Localizer.Get("SomeKey")
Localizer.TryGet("SomeKey")
```

* Type `(Serenity\.)?LocalText\.(Get|TryGet)\((["A-Za-z_\.]+)\)` in `Find` input

* Type `Localizer.$2($3)` in `Replace` input

* Make sure `File Types` is `*.cshtml; *.cs`

* Click `Replace All`

## Injecting Localizer to CSHTML Files

Find all .CSHTML files which needs `Localizer` service to get injected with searching following regex in *.cshtml files:

`.*(?Localizer\.(Try|Get))`

Add this line after `@model` directive if exists, or as the first line:

```cs
@model XYZ
@inject Serenity.ITextLocalizer Localizer
```

## Inject Localizer to AccountPage

Add this property and constructor to `AccountController.cs` as Localizer is required in many files:

```csharp
protected ITextLocalizer Localizer { get; }

public AccountController(ITextLocalizer localizer)
{
    Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
}
```