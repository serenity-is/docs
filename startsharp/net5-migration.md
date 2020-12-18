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

* Type `([\t ]*)(private|public)[\t ]+class[\t ]+My(Save|Retrieve|List|Delete|Undelete)Handler[\t ]*\:[\t ]*(\3)RequestHandler(\<[A-Za-z\.\, \t]+\>)[\t ]*\{?[\t ]*(\r?\n)[\t\r\s]*\{` in `Find` input

* Type <pre>`$1$2 class My$3Handler : $3RequestHandler$5$6$1{$6$1    public My$3Handler(IRequestContext context)$6$1$1 : base(context)$6$1    {$6$1    }$6`</pre> in `Replace` input

* Click `Replace All`

Now will repeat it for empty handlers:

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Look in` is Current project, `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

* Type `([\t ]*)(private|public)[\t ]+class[\t ]+My(Save|Retrieve|List|Delete|Undelete)Handler[\t ]*\:[\t ]*(\3)RequestHandler(\<[A-Za-z\.\, \t]+\>)[\t ]*\{?[\t ]*\}[\t ]*(\r?\n)([\t\r\s]*\n)?` in `Find` input

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

* Type `new[\t ]*My(Save|Retrieve|List|Delete|Undelete)Handler[\t ]*\([\t ]*\)`

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

## Fixing TranslationRepository and TranslationEndpoint

Get them from latest StartSharp / Serene repo or do following changes:

* Modify TranslationEndpoint like below:

```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Serenity.Abstractions;
using Serenity.Services;
using System;
using MyRepository = StartSharp.Administration.Repositories.TranslationRepository;

namespace StartSharp.Administration.Endpoints
{
    [Route("Services/Administration/Translation/[action]")]
    [ServiceAuthorize(PermissionKeys.Translation)]
    public class TranslationController : ServiceEndpoint
    {
        protected IWebHostEnvironment HostEnvironment { get; }
        protected ILocalTextRegistry LocalTextRegistry { get; }
        protected ITypeSource TypeSource { get; }

        public TranslationController(IWebHostEnvironment hostEnvironment,
            ILocalTextRegistry localTextRegistry, ITypeSource typeSource)
        {
            HostEnvironment = hostEnvironment ?? throw new ArgumentNullException(nameof(hostEnvironment));
            LocalTextRegistry = localTextRegistry ?? throw new ArgumentNullException(nameof(localTextRegistry));
            TypeSource = typeSource ?? throw new ArgumentNullException(nameof(typeSource));
        }

        private MyRepository NewRepository()
        {
            return new MyRepository(Context, HostEnvironment, LocalTextRegistry, TypeSource);
        }

        public ListResponse<TranslationItem> List(TranslationListRequest request)
        {
            return NewRepository().List(request);
        }

        [HttpPost]
        public SaveResponse Update(TranslationUpdateRequest request)
        {
            return NewRepository().Update(request, HttpContext.RequestServices);
        }
    }
}
```

* Modify TranslationRepository constructor and GetUserTextsFilePath:

```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
//...
protected IWebHostEnvironment HostEnvironment { get; }
protected ILocalTextRegistry LocalTextRegistry { get; }
protected ITypeSource TypeSource { get; }

public TranslationRepository(IRequestContext context, IWebHostEnvironment hostEnvironment, 
    ILocalTextRegistry localTextRegistry, ITypeSource typeSource)
        : base(context)
{
    HostEnvironment = hostEnvironment;
    LocalTextRegistry = localTextRegistry;
    TypeSource = typeSource;
}

public static string GetUserTextsFilePath(IWebHostEnvironment hostEnvironment, string languageID)
{
    return Path.Combine(hostEnvironment.ContentRootPath, "App_Data", "texts", 
        "user.texts." + (languageID.TrimToNull() ?? "invariant") + ".json");
}
```

* Replace `GetUserTextsFilePath\(targetLanguageID\)` with `GetUserTextsFilePath(HostEnvironment, targetLanguageID)`
* Replace `JsonConfigHelper\.LoadConfig\<Dictionary\<string, JToken\>\>\(textsFilePath\)` with `JSON.Parse<Dictionary<string, JToken>>(File.ReadAllText(textsFilePath))`
* Remove `var registry = Dependency.Resolve<ILocalTextRegistry>();`
* Replace `GetAllAvailableLocalTextKeys` like following:

```csharp
public HashSet<string> GetAllAvailableLocalTextKeys()
{
    var result = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    foreach (NavigationItemAttribute attr in TypeSource.GetAssemblyAttributes<NavigationItemAttribute>())
        result.Add("Navigation." + (attr.Category.IsEmptyOrNull() ? "" : attr.Category + "/") + attr.Title);

    foreach (var type in TypeSource.GetTypesWithAttribute(typeof(FormScriptAttribute)))
    {
        var attr = type.GetAttribute<FormScriptAttribute>();
        foreach (var member in type.GetMembers(BindingFlags.Instance | BindingFlags.Public))
        {
            var category = member.GetCustomAttribute<CategoryAttribute>();
            if (category != null && !category.Category.IsEmptyOrNull())
                result.Add("Forms." + attr.Key + ".Categories." + category.Category);
        }
    }

    var repository = LocalTextRegistry as LocalTextRegistry;
    if (repository != null)
        result.AddRange(repository.GetAllTextKeys(false));

    return result;
}
```

* Replace `Dependency\.Resolve\<ILocalTextRegistry\>\(\) as LocalTextRegistry` with `LocalTextRegistry as LocalTextRegistry`
* Replace `\(localTextRegistry as IRemoveAll\)\?\.RemoveAll\(\)` with `(LocalTextRegistry as IRemoveAll)?.RemoveAll()`
* Replace `DynamicScriptManager\.Reset\(\)` with `services.GetService<IDynamicScriptManager>()?.Reset()`


## Handling AccountPage, UserPasswordValidator and Related Code

Find the following line:

```cs
services.AddSingleton<IAuthenticationService, Administration.AuthenticationService>();
```

and replace with

```cs
services.AddSingleton<Administration.IUserPasswordValidator, Administration.UserPasswordValidator>();
```


Find and delete in the following file:

* Modules/Administration/User/Authentication/AuthenticationService.cs

Add new 3 files:

* Modules/Administration/User/Authentication/UserPasswordValidator.cs

```csharp
namespace StartSharp.Administration
{
    public interface IUserPasswordValidator
    {
        PasswordValidationResult Validate(ref string username, string password);
    }
}
```

* Modules/Administration/User/Authentication/PasswordValidationResult.cs

```csharp
namespace StartSharp.Administration
{
    public enum PasswordValidationResult
    {
        EmptyUsername,
        EmptyPassword,
        InactiveUser,
        UnknownSource,
        Throttle,
        DirectoryError,
        Invalid,
        Valid
    }
}
```

* Modules/Administration/User/Authentication/UserPasswordValidator.cs

```csharp
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using StartSharp.Administration.Entities;
using StartSharp.Administration.Repositories;
using System;

namespace StartSharp.Administration
{
    public class UserPasswordValidator : IUserPasswordValidator
    {
        public UserPasswordValidator(ITwoLevelCache cache, ISqlConnections sqlConnections, 
            IUserRetrieveService userRetriever, 
            ILogger<UserPasswordValidator> log = null, 
            IDirectoryService directoryService = null)
        {
            Cache = cache ?? throw new ArgumentNullException(nameof(cache));
            SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
            UserRetriever = userRetriever ?? throw new ArgumentNullException(nameof(userRetriever));
            DirectoryService = directoryService;
            Log = log;
        }

        protected ITwoLevelCache Cache { get; }
        public ISqlConnections SqlConnections { get; }
        protected IUserRetrieveService UserRetriever { get; }
        protected IDirectoryService DirectoryService { get; }
        protected ILogger<UserPasswordValidator> Log { get; }

        public PasswordValidationResult Validate(ref string username, string password)
        {
            if (username.IsTrimmedEmpty())
                return PasswordValidationResult.EmptyUsername;

            if (password.IsEmptyOrNull())
                return PasswordValidationResult.EmptyPassword;

            username = username.TrimToEmpty();

            if (UserRetriever.ByUsername(username) is UserDefinition user)
                return ValidateExistingUser(ref username, password, user);

            return ValidateFirstTimeUser(ref username, password);
        }

        private PasswordValidationResult ValidateExistingUser(ref string username, string password, UserDefinition user)
        {
            username = user.Username;

            if (user.IsActive != 1)
            {
                Log?.LogError("Inactive user login attempt: {0}", username);
                return PasswordValidationResult.InactiveUser;
            }

            // prevent more than 50 invalid login attempts in 30 minutes
            var throttler = new Throttler(Cache.Memory, "ValidateUser:" + username.ToLowerInvariant(), TimeSpan.FromMinutes(30), 50);
            if (!throttler.Check())
                return PasswordValidationResult.Throttle;

            Func<bool> validatePassword = () => UserRepository.CalculateHash(password, user.PasswordSalt)
                .Equals(user.PasswordHash, StringComparison.OrdinalIgnoreCase);

            if (user.Source == "site" || user.Source == "sign" || DirectoryService == null)
            {
                if (validatePassword())
                {
                    throttler.Reset();
                    return PasswordValidationResult.Valid;
                }

                return PasswordValidationResult.Invalid;
            }

            if (user.Source != "ldap")
                return PasswordValidationResult.UnknownSource;

            if (!string.IsNullOrEmpty(user.PasswordHash) &&
                user.LastDirectoryUpdate != null &&
                user.LastDirectoryUpdate.Value.AddHours(1) >= DateTime.Now)
            {
                if (validatePassword())
                {
                    throttler.Reset();
                    return PasswordValidationResult.Valid;
                }

                return PasswordValidationResult.Invalid;
            }

            DirectoryEntry entry;
            try
            {
                entry = DirectoryService.Validate(username, password);
                if (entry == null)
                    return PasswordValidationResult.Invalid;

                throttler.Reset();
            }
            catch (Exception ex)
            {
                Log?.LogError(ex, "Error on directory access");

                // couldn't access directory. allow user to login with cached password
                if (!user.PasswordHash.IsTrimmedEmpty())
                {
                    if (validatePassword())
                    {
                        throttler.Reset();
                        return PasswordValidationResult.Valid;
                    }

                    return PasswordValidationResult.Invalid;
                }

                throw;
            }

            try
            {
                string salt = user.PasswordSalt.TrimToNull();
                var hash = UserRepository.GenerateHash(password, ref salt);
                var displayName = entry.FirstName + " " + entry.LastName;
                var email = entry.Email.TrimToNull() ?? user.Email ?? (username + "@yourdefaultdomain.com");

                using (var connection = SqlConnections.NewFor<UserRow>())
                using (var uow = new UnitOfWork(connection))
                {
                    var fld = UserRow.Fields;
                    new SqlUpdate(fld.TableName)
                        .Set(fld.DisplayName, displayName)
                        .Set(fld.PasswordHash, hash)
                        .Set(fld.PasswordSalt, salt)
                        .Set(fld.Email, email)
                        .Set(fld.LastDirectoryUpdate, DateTime.Now)
                        .WhereEqual(fld.UserId, user.UserId)
                        .Execute(connection, ExpectedRows.One);

                    uow.Commit();

                    UserRetrieveService.RemoveCachedUser(Cache, user.UserId, username);
                }

                return PasswordValidationResult.Valid;
            }
            catch (Exception ex)
            {
                Log?.LogError(ex, "Error while updating directory user");
                return PasswordValidationResult.Valid;
            }
        }

        private PasswordValidationResult ValidateFirstTimeUser(ref string username, string password)
        {
            var throttler = new Throttler(Cache.Memory, "ValidateUser:" + username.ToLowerInvariant(), TimeSpan.FromMinutes(30), 50);
            if (!throttler.Check())
                return PasswordValidationResult.Throttle;

            if (DirectoryService == null)
                return PasswordValidationResult.Invalid;

            DirectoryEntry entry;
            try
            {
                entry = DirectoryService.Validate(username, password);
                if (entry == null)
                    return PasswordValidationResult.Invalid;

                throttler.Reset();
            }
            catch (Exception ex)
            {
                Log?.LogError(ex, "Error on directory first time authentication");
                return PasswordValidationResult.DirectoryError;
            }

            try
            {
                string salt = null;
                var hash = UserRepository.GenerateHash(password, ref salt);
                var displayName = entry.FirstName + " " + entry.LastName;
                var email = entry.Email.TrimToNull() ?? (username + "@yourdefaultdomain.com");
                username = entry.Username.TrimToNull() ?? username;

                using (var connection = SqlConnections.NewFor<UserRow>())
                using (var uow = new UnitOfWork(connection))
                {
                    var userId = (int)connection.InsertAndGetID(new UserRow
                    {
                        Username = username,
                        Source = "ldap",
                        DisplayName = displayName,
                        Email = email,
                        PasswordHash = hash,
                        PasswordSalt = salt,
                        IsActive = 1,
                        InsertDate = DateTime.Now,
                        InsertUserId = 1,
                        LastDirectoryUpdate = DateTime.Now
                    });

                    uow.Commit();

                    UserRetrieveService.RemoveCachedUser(Cache, userId, username);
                }

                return PasswordValidationResult.Valid;
            }
            catch (Exception ex)
            {
                Log?.LogError(ex, "Error while importing directory user");
                return PasswordValidationResult.DirectoryError;
            }
        }
    }
}
```

* Apply the following file changes in StartSharp:

* https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Administration/User/Authentication/UserRetrieveService.cs

* https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Membership/Account/AccountPage.cs

* https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Membership/Account/ChangePassword/AccountPage.ChangePassword.cs

* https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Membership/Account/ForgotPassword/AccountPage.ForgotPassword.cs

* https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Membership/Account/ResetPassword/AccountPage.ResetPassword.cs

* https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Membership/Account/SignUp/AccountPage.SignUp.cs

* or following file changes in Serene:

* https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Administration/User/Authentication/UserRetrieveService.cs

* https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Membership/Account/AccountPage.cs

* https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Membership/Account/ChangePassword/AccountPage.ChangePassword.cs

* https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Membership/Account/ForgotPassword/AccountPage.ForgotPassword.cs

* https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Membership/Account/ResetPassword/AccountPage.ResetPassword.cs

* https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Membership/Account/SignUp/AccountPage.SignUp.cs

## Sergen Tool Update

Open command line in your project directory and run following:

```ps
dotnet tool update sergen
```

## Fix SmtpSettings

.NET options does not like converting nulls to default values when the target is not nullable so fix the SmtpSettings in appsettings.json file (port and usessl, and pickuppath parts) like following (or apply your valid settings):

```json
"SmtpSettings": {
    "Host": null,
    "Port": null,
    "UseSsl": null,
    "From": null
    "Port": 25,
    "UseSsl": false,
    "From": null,
    "PickupPath": "App_Data/Mail"
  }
  ```
  
## Handling DataMigrations.cs

We are going to use FluentMigrator's latest version and making DataMigrations dependency injectable.

* Add following usings:

```cs
using FluentMigrator.Runner;
using FluentMigrator.Runner.Conventions;
using FluentMigrator.Runner.Processors;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;
```

* Remove `using System.Data.SqlClient;`

* Replace `public static class DataMigrations` with `public class DataMigrations : IDataMigrations`
* Replace `SqlConnections\.GetConnectionString\(databaseKey\)\;` with
```cs
SqlConnections.TryGetConnectionString(databaseKey);
if (cs == null)
    throw new ArgumentOutOfRangeException(nameof(databaseKey));
```

* Replace `Serenity\.Dependency\.Resolve\<IWebHostEnvironment\>\(\)\.ContentRootPath` with `HostEnvironment.ContentRootPath`
* Replace `cs\.ProviderFactory\.CreateConnectionStringBuilder\(\)\;` with `DbProviderFactories.GetFactory(cs.ProviderName).CreateConnectionStringBuilder();`
* Replace `, cs.ProviderName)` with `, cs.ProviderName, cs.Dialect)`
* Replace `var hostingEnvironment \= Serenity\.Dependency\.TryResolve\<IWebHostEnvironment\>\(\)\;` with `var hostingEnvironment = HostEnvironment;`
* Remove `var connection = cs.ConnectionString;` line
* Remove `bool isSqlServer = serverType.StartsWith(""SqlServer"", StringComparison.OrdinalIgnoreCase);` line
* Find the line starting with `using (var sw = new StringWriter` and modify remaining lines like below:

```cs
var conventionSet = new DefaultConventionSet(defaultSchemaName: null,
                Path.GetDirectoryName(typeof(DataMigrations).Assembly.Location));

var serviceProvider = new ServiceCollection()
    .AddLogging(lb => lb.AddFluentMigratorConsole())
    .AddFluentMigratorCore()
    .AddSingleton<IConventionSet>(conventionSet)
    .Configure<TypeFilterOptions>(options =>
    {
        options.Namespace = "!!!YourProjectNamespace!!!.Migrations." + databaseKey + "DB";
    })
    .Configure<ProcessorOptions>(options =>
    {
        options.Timeout = TimeSpan.FromSeconds(90);
    })
    .ConfigureRunner(builder =>
    {
        if (databaseType == OracleDialect.Instance.ServerType)
            builder.AddOracleManaged();
        else if (databaseType == SqliteDialect.Instance.ServerType)
            builder.AddSQLite();
        else if (databaseType == FirebirdDialect.Instance.ServerType)
            builder.AddFirebird();
        else if (databaseType == MySqlDialect.Instance.ServerType)
            builder.AddMySql5();
        else if (databaseType == PostgresDialect.Instance.ServerType)
            builder.AddPostgres();
        else
            builder.AddSqlServer();

        builder.WithGlobalConnectionString(cs.ConnectionString);
        builder.WithMigrationsIn(typeof(DataMigrations).Assembly);
    })
    .BuildServiceProvider();

var culture = CultureInfo.CurrentCulture;
try
{
    if (isFirebird)
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

    using var scope = serviceProvider.CreateScope();
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}
catch (Exception ex)
{
    throw new InvalidOperationException("Error executing migration!", ex);
}
finally
{
    if (isFirebird)
        Thread.CurrentThread.CurrentCulture = culture;
}
```

* Edit Your .CSPROJ file and replace following line:

```xml
<PackageReference Include="Serenity.FluentMigrator.Runner" Version="1.6.904" />
```

with

```xml
<PackageReference Include="FluentMigrator.Runner" Version="3.2.9" />
```

* Edit Startup.cs and following lines in ConfigureServices:

```cs
services.AddSingleton<IDataMigrations, DataMigrations>();
services.AddSingleton<IReportRegistry, ReportRegistry>();
```

* Replace following lines:

```cs
services.AddConfig(Configuration);
services.AddCaching();
services.AddAnnotationTypes();
services.AddTextRegistry();
services.AddFileLogging();
services.AddSingleton<IAuthenticationService, Administration.AuthenticationService>();
```

with

```cs
services.AddServiceHandlers();
services.AddDynamicScripts();
services.AddCssBundling();
services.AddScriptBundling();
services.AddUploadStorage();
services.AddSingleton<Administration.IUserPasswordValidator, Administration.UserPasswordValidator>();
```

* Edit Startup.cs and replace following line

```cs
DataMigrations.Initialize();
```

with 

```cs
app.ApplicationServices.GetRequiredService<IDataMigrations>().Initialize();
```

add these usings to start:

```cs
using Microsoft.Data.SqlClient;
using Serenity.Reporting;
using System.Data.Common;
```

remove this usings:

```cs
using System.Data.SqlClient;
using Serenity.Web.Middleware;
```

and add following to RegisterDataProviders:

```cs
DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", SqlClientFactory.Instance);
```

## Fix SqlErrorStore

* Add `using System.Data.Common;`

* Remove these lines:

```cs
private readonly string connectionString;
private readonly bool isSqlServer;
```

* Modify constructor like this:

```cs
public SqlErrorStore(ErrorStoreSettings settings, string providerName)
    : base(settings)
{
    if (settings == null)
        throw new ArgumentNullException(nameof(settings));

    displayCount = Math.Min(displayCount, MaximumDisplayCount);
    this.providerName = providerName ?? throw new ArgumentNullException(nameof(providerName));
}
```

* Replace `if (isSqlServer)` with `if (providerName.IndexOf("SqlClient") >= 0)`

* Modify GetConnection:

```csharp
private IDbConnection GetConnection()
{
    var connection = DbProviderFactories.GetFactory(providerName).CreateConnection();
    connection.ConnectionString = Settings.ConnectionString;
    return connection;
}
```

## Fixing Startup.ExceptionLog

Modify Log method like this:

```cs
public void Log(Exception exception, string category = null)
{
    exception.Log(httpContextAccessor.HttpContext, category);
}
```

## Removing Web Based Sergen UI

Sergen will soon have its own web based UI, and the sample in the StartSharp/Serene is obsolete.

* Edit `AdministrationNavigation.cs` and remove this line:

`[assembly: NavigationLink(9000, "Administration/Sergen", typeof(Administration.SergenController), icon: "fa-magic")]`

* Delete `Modules/Administration/Sergen` folder and files under it.

## Replacing isPublicDemo References

This is only used for Serenity Demo at http://serenity.is, you may delete any line that looks like following:

```cs
UserRepository.isPublicDemo
```

or replace it with

```cs
UserRepository.IsPublicDemo
```

## Fixing DataAuditLog

If you have StartSharp data audit log feature, delete `DataAuditLogHandler.cs` and get latest versions of following files from StartSharp repository:

* [DataAuditLogBehavior.cs](https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Administration/DataAuditLog/DataAuditLogBehavior.cs)
* [DataAuditLogPage.cs](https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Administration/DataAuditLog/DataAuditLogPage.cs)

## Fixing Row Lookup Scripts

If you have external lookup scripts defined like this:

```cs
public LanguageLookup()
```

You need to add a sqlConnections argument to the constructor (or add the constructor if none exists).

```cs
public LanguageLookup(ISqlConnections sqlConnections)
    : base(sqlConnections)
```

## Replacing RoleRepository.RoleById by RoleRepository.GetRoleById

Modify static RoleById property like this:

```cs
public static Dictionary<int, MyRow> GetRoleById(ITwoLevelCache cache, ISqlConnections sqlConnections)
{
    if (cache is null)
        throw new ArgumentNullException(nameof(cache));

    return cache.GetLocalStoreOnly("RoleById", TimeSpan.Zero, 
        fld.GenerationKey, () =>
        {
            if (sqlConnections is null)
                throw new ArgumentNullException(nameof(sqlConnections));

            using var connection = sqlConnections.NewFor<MyRow>();
            return connection.List<MyRow>().ToDictionary(x => x.RoleId.Value);
        });
}
```

## Modify TranslationEndpoint.cs

Modify this file like below:

```cs
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Serenity.Abstractions;
using Serenity.Services;
using System;
using MyRepository = StartSharp.Administration.Repositories.TranslationRepository;

namespace StartSharp.Administration.Endpoints
{
    [Route("Services/Administration/Translation/[action]")]
    [ServiceAuthorize(PermissionKeys.Translation)]
    public class TranslationController : ServiceEndpoint
    {
        protected IWebHostEnvironment HostEnvironment { get; }
        protected ILocalTextRegistry LocalTextRegistry { get; }
        protected ITypeSource TypeSource { get; }

        public TranslationController(IWebHostEnvironment hostEnvironment,
            ILocalTextRegistry localTextRegistry, ITypeSource typeSource)
        {
            HostEnvironment = hostEnvironment ?? throw new ArgumentNullException(nameof(hostEnvironment));
            LocalTextRegistry = localTextRegistry ?? throw new ArgumentNullException(nameof(localTextRegistry));
            TypeSource = typeSource ?? throw new ArgumentNullException(nameof(typeSource));
        }

        private MyRepository NewRepository()
        {
            return new MyRepository(Context, HostEnvironment, LocalTextRegistry, TypeSource);
        }

        public ListResponse<TranslationItem> List(TranslationListRequest request)
        {
            return NewRepository().List(request);
        }

        [HttpPost]
        public SaveResponse Update(TranslationUpdateRequest request)
        {
            return NewRepository().Update(request, HttpContext.RequestServices);
        }
    }
}
```

## Fix TranslationRepository.cs

* Add `using Microsoft.Extensions.DependencyInjection;`
* Remove `using System.Web.Hosting;`
* Modify constructor and GetUserTextsFilePath as below:

```csharp
protected IWebHostEnvironment HostEnvironment { get; }
protected ILocalTextRegistry LocalTextRegistry { get; }
protected ITypeSource TypeSource { get; }

public TranslationRepository(IRequestContext context, IWebHostEnvironment hostEnvironment, 
    ILocalTextRegistry localTextRegistry, ITypeSource typeSource)
        : base(context)
{
    HostEnvironment = hostEnvironment;
    LocalTextRegistry = localTextRegistry;
    TypeSource = typeSource;
}

public static string GetUserTextsFilePath(IWebHostEnvironment hostEnvironment, string languageID)
{
    return Path.Combine(hostEnvironment.ContentRootPath, "App_Data", "texts", 
        "user.texts." + (languageID.TrimToNull() ?? "invariant") + ".json");
}
```

* Replace `GetUserTextsFilePath\(targetLanguageID\)\;` with `GetUserTextsFilePath(HostEnvironment, targetLanguageID);`
* Replace `GetUserTextsFilePath\(request.TargetLanguageID\)\;` with `GetUserTextsFilePath(HostEnvironment, request.TargetLanguageID);`
* Replace `var json \= JsonConfigHelper\.LoadConfig\<Dictionary\<string\, JToken\>\>\(textsFilePath\)\;` with `var json = JSON.Parse<Dictionary<string, JToken>>(File.ReadAllText(textsFilePath));`
* Remove `var registry = Dependency.Resolve<ILocalTextRegistry>();` line
* Replace `registry\.TryGet\((source|target)LanguageID\, key\)` with `LocalTextRegistry.TryGet($1LanguageID, key, false)`
* Modify GetAllAvailableLocalTexts like this:

```csharp
public HashSet<string> GetAllAvailableLocalTextKeys()
{
    var result = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    foreach (NavigationItemAttribute attr in TypeSource.GetAssemblyAttributes<NavigationItemAttribute>())
        result.Add("Navigation." + (attr.Category.IsEmptyOrNull() ? "" : attr.Category + "/") + attr.Title);

    foreach (var type in TypeSource.GetTypesWithAttribute(typeof(FormScriptAttribute)))
    {
        var attr = type.GetAttribute<FormScriptAttribute>();
        foreach (var member in type.GetMembers(BindingFlags.Instance | BindingFlags.Public))
        {
            var category = member.GetCustomAttribute<CategoryAttribute>();
            if (category != null && !category.Category.IsEmptyOrNull())
                result.Add("Forms." + attr.Key + ".Categories." + category.Category);
        }
    }

    var repository = LocalTextRegistry as LocalTextRegistry;
    if (repository != null)
        result.AddRange(repository.GetAllTextKeys(false));

    return result;
}
```

* Add `(LocalTextRegistry as IRemoveAll)?.RemoveAll();` before `Startup.InitializeLocalTexts(services);``
* Replace `DynamicScriptManager\.Reset\(\)\;` with `services.GetService<IDynamicScriptManager>()?.Reset();`

## Modify UserRetrieve.cs

Apply the following file changes in StartSharp:

* [UserRetrieveService.cs](https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Administration/DataAuditLog/DataAuditLogPage.cs)


* or following file changes in Serene:
* [UserRetrieveService.cs](https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Administration/User/Authentication/UserRetrieveService.cs)


## Modify UserEndpoint.cs

Find this line:

```csharp
if (request != null && Serenity.Permissions.HasPermission("ImpersonateAs"))
```
and change with this line:
```csharp
if (request != null && Permissions.HasPermission("ImpersonateAs"))
```

## Modify UserRepository.cs

Apply the following file changes in StartSharp:

* [UserRepository.cs](https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Administration/User/UserRepository.cs)

 or following file changes in Serene:
* [UserRepository.cs](https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Administration/User/UserRepository.cs)

## Modify UserPermissionEndpoint.cs

Apply the following file changes:

* Add `using Serenity.Abstractions;`

Find this method:

```csharp
public ListResponse<string> ListPermissionKeys()
{
    return new MyRepository(Context).ListPermissionKeys(includeRoles: false);
}
```

and change with: 

```csharp
public ListResponse<string> ListPermissionKeys(
    [FromServices] ISqlConnections sqlConnections,
    [FromServices] ITypeSource typeSource)
{
    return new MyRepository(Context).ListPermissionKeys(sqlConnections, typeSource, includeRoles: false);
}
```

Find this method:

```csharp
public Dictionary<string, HashSet<string>> ListImplicitPermissions()
{
    return new MyRepository(Context).ImplicitPermissions;
}
```

and change with: 

```csharp
public IDictionary<string, HashSet<string>> ListImplicitPermissions(
    [FromServices] ITypeSource typeSource)
{
    return MyRepository.GetImplicitPermissions(Cache.Memory, typeSource);
}
```

## Modify UserPermissionRepository.cs

Apply the following file changes in StartSharp:

* [UserPermissionRepository.cs](https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Administration/UserPermission/UserPermissionRepository.cs)

 or following file changes in Serene:
* [UserPermissionRepository.cs](https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Administration/UserPermission/UserPermissionRepository.cs)


## Modify AdvanceSamplesPage.cs

Apply the following file changes:

* Add `using Serenity.Data;`
* Add `using System;`

Find the controller `AdvancedSamplesController`
and change inside of like in the following:

```csharp
public AdvancedSamplesController(ISqlConnections sqlConnections)
{
    SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
}

protected ISqlConnections SqlConnections { get; }
```
at the end your `AdvancedSamplesController` will be like:
```csharp
[PageAuthorize, Route("AdvancedSamples/[action]")]
public partial class AdvancedSamplesController : Controller
{
    public AdvancedSamplesController(ISqlConnections sqlConnections)
    {
        SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
    }

    protected ISqlConnections SqlConnections { get; }
}
```

## Modify ServerSide.cshtml

Apply the following file changes:

* Add `@inject Serenity.ITextLocalizer Localizer` <br/>under `@model IEnumerable<StartSharp.Northwind.Entities.CustomerRow>`

* Change `Title` with `GetTitle(Localizer)` in `<th>` lines like in the following:
```html
<th>@fld.CustomerID.GetTitle(Localizer)</th>
...
```` 

## Modify DataExplorerEndpoint.cs

Apply the following file changes:

Add the following code lines above `ListResponse` method

```csharp
protected ISqlConnections SqlConnections { get; }

public DataExplorerController(ISqlConnections sqlConnections)
{
    SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
}
````

Find the following line and 
```cs
throw new ArgumentOutOfRangeException("serverType", (object)serverType, "Unknown server type");
```
with 
```cs
throw new ArgumentOutOfRangeException(nameof(serverType), serverType, "Unknown server type");
```

Find the following line and 
```cs
private string[] NumericTypes = new string[] { "Int32", "Int64", "Int16", "Decimal", "Double", "Single" };
```
with 
```cs
private readonly string[] NumericTypes = new string[] { "Int32", "Int64", "Int16", "Decimal", "Double", "Single" };
```

Find the following line and 
```cs
private static Dictionary<string, string> SqlTypeToFieldTypeMap =
```
with 
```cs
private static readonly Dictionary<string, string> SqlTypeToFieldTypeMap =
```

## Fix MeetingIndex.cshtml

* Add `@inject Serenity.Web.IContentHashCache ContentHashCache` after `@inject Serenity.ITextLocalizer Localizer`

* Replace `@ContentHashCache.ResolvePath("~/Scripts/ckeditor/")` with `@ContentHashCache.ResolvePath(Context.Request.PathBase, "~/Scripts/ckeditor/")`

## Fix AccountLogin.AdminLTE.cshtml

* Add `@inject IDataMigrations DataMigrations` after `@inject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.Login.FormTitle;` with `Texts.Forms.Membership.Login.FormTitle.ToString(Localizer);`

* Replace `@Texts.Forms.Membership.Login.RememberMe` with `@Texts.Forms.Membership.Login.RememberMe.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.SignInButton` with `@Texts.Forms.Membership.Login.SignInButton.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.SignUp.ActivationCompleteMessage` with `@Texts.Forms.Membership.SignUp.ActivationCompleteMessage.ToString(Localizer)`

* Replace `@Texts.Navigation.SiteTitle` with `@Texts.Navigation.SiteTitle.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.FormTitle` with `@Texts.Forms.Membership.Login.FormTitle.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.OR` with `@Texts.Forms.Membership.Login.OR.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.FacebookButton` with `@Texts.Forms.Membership.Login.FacebookButton.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.GoogleButton` with `@Texts.Forms.Membership.Login.GoogleButton.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.ForgotPassword` with `@Texts.Forms.Membership.Login.ForgotPassword.ToString(Localizer)`

* Replace `@Texts.Forms.Membership.Login.SignUpButton` with `@Texts.Forms.Membership.Login.SignUpButton.ToString(Localizer)`

## Fix AccountLogin.cshtml

* Add `@inject IDataMigrations DataMigrations` after `@inject Serenity.ITextLocalizer Localizer`

* Replace `@Texts.Forms.Membership.SignUp.ActivationCompleteMessage` with `@Texts.Forms.Membership.SignUp.ActivationCompleteMessage.ToString(Localizer)`

## Modify AccountPage.cs

Apply the following file changes in StartSharp:
* [AccountPage.cs](https://github.com/volkanceylan/StartSharp/blob/net5/StartSharp/StartSharp.Core/Modules/Membership/Account/AccountPage.cs)

or following file changes in Serene:

* [AccountPage.cs](https://github.com/serenity-is/Serene/blob/master/Serene/Serene.Core/Modules/Membership/Account/AccountPage.cs)

## Modify BasicSamplesPage.Grids.cs

* Add `using Serenity.Data;`
* Find `DragDropInTreeGrid()` method and its inside like in the following:
```csharp
public ActionResult DragDropInTreeGrid([FromServices] ISqlConnections sqlConnections)
{
    Repositories.DragDropSampleRepository.PopulateInitialItems(sqlConnections);
    return View(Views.DragDropInTreeGrid.Index);
}
```

## Modify DragDropSampleRepository.cs

* Add `using System;`
* Find `PopulateInitialItems()` method and add the parameter inside `ISqlConnections sqlConnections`
```cs
public static void PopulateInitialItems(ISqlConnections sqlConnections){ ... }
```
* Find this line: 
```cs
using (var connection = SqlConnections.NewFor<MyRow>())
```
and change `SqlConnections` with `sqlConnections` (pay attention to uppercase and lowercase letters)

* Add these code lines above the `using (var connection = sqlConnections.NewFor<MyRow>())`
```csharp
if (sqlConnections is null)
    throw new ArgumentNullException(nameof(sqlConnections));
```

at the end your method will be like: 
```csharp
public static void PopulateInitialItems(ISqlConnections sqlConnections)
{
    if (sqlConnections is null)
        throw new ArgumentNullException(nameof(sqlConnections));

    using (var connection = sqlConnections.NewFor<MyRow>())
    {
        ....
```
## Fix AccountChangePassword.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.ChangePassword.FormTitle` with `Texts.Forms.Membership.ChangePassword.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ChangePassword.SubmitButton` with `Texts.Forms.Membership.ChangePassword.SubmitButton.ToString(Localizer)`

## Fix AccountPage.ChangePassword.cs

* Replace `public Result<ServiceResponse> ChangePassword(ChangePasswordRequest request)` with `public Result<ServiceResponse> ChangePassword(ChangePasswordRequest request, [FromServices] IUserPasswordValidator passwordValidator)`

* Replace `Texts.Forms.Membership.ChangePassword.SubmitButton` with `Texts.Forms.Membership.ChangePassword.SubmitButton.ToString(Localizer)`

* Add the following code lines inside the ` ChangePassword(ChangePasswordRequest request, [FromServices] IUserPasswordValidator passwordValidator)` method

```csharp
if (passwordValidator is null)
    throw new ArgumentNullException(nameof(passwordValidator));
````

* Replace `Authorization.Username` with `User.Identity?.Name`

Find the following line and
```cs
if (!Dependency.Resolve<IAuthenticationService>().Validate(ref username, request.OldPassword))
    throw new ValidationError("CurrentPasswordMismatch", Texts.Validation.CurrentPasswordMismatch);
```
replace with 
```cs
if (passwordValidator.Validate(ref username, request.OldPassword) != PasswordValidationResult.Valid)
    throw new ValidationError("CurrentPasswordMismatch", Texts.Validation.CurrentPasswordMismatch.ToString(Localizer));
```

* Replace `UserRepository.ValidatePassword(username, request.NewPassword, false)` with `UserRepository.ValidatePassword(request.NewPassword, Localizer)`

* Replace `Authorization.UserId` with `User.GetIdentifier()`

## Fix AccountForgotPassword.AdminLTE.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.ForgotPassword.SubmitButton` with `Texts.Forms.Membership.ForgotPassword.SubmitButton.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ForgotPassword.FormInfo` with `Texts.Forms.Membership.ForgotPassword.FormInfo.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ForgotPassword.FormTitle` with `Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ForgotPassword.BackToLogin` with `Texts.Forms.Membership.ForgotPassword.BackToLogin.ToString(Localizer)`

## Fix AccountForgotPassword.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.ForgotPassword.FormTitle` with `Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ForgotPassword.FormInfo` with `Texts.Forms.Membership.ForgotPassword.FormInfo.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ForgotPassword.SubmitButton` with `Texts.Forms.Membership.ForgotPassword.SubmitButton.ToString(Localizer)`


## Fix AccountPage.ForgotPassword.cs

* Add `using Microsoft.Extensions.Options;` and `using StartSharp.Common;`

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(public\s*Result<ServiceResponse>\s*ForgotPassword\s*\(\s*ForgotPasswordRequest\s*([A-Za-z0-9_]*))\)(\r\n\s*)` in `Find` input

* Type `$1,$3[FromServices] IEmailSender emailSender,$3[FromServices] IOptions<EnvironmentSettings> options = null)$3` in `Replace` input

* Click `Replace All`

* Type `(.*Texts.Validation.CantFindUserWithEmail)(\s*)` in `Find` input

* Type `$1.ToString(Localizer)$2` in `Replace` input

* Click `Replace All`

* Type `Config.Get<EnvironmentSettings>\s*\(\).SiteExternalUrl` in `Find` input

* Type `options?.Value.SiteExternalUrl` in `Replace` input

* Click `Replace All`

* Type `(.*Texts.Forms.Membership.ResetPassword.EmailSubject).ToString\(\)(\s*)` in `Find` input

* Type `$1.ToString(Localizer)$2` in `Replace` input

* Click `Replace All`

* Type `(.*)Common.EmailHelper.Send\(([a-zA-Z0-9_]*)\s*,\s*([a-zA-Z0-9_]*)\s*,\s*(user.Email)\s*\)\s*;(\r\n\s*)` in `Find` input

* Type `$1if (emailSender is null)\n$1\tthrow new ArgumentNullException(nameof(emailSender));$5emailSender.Send(subject: $2, body: $3, mailTo: $4);$5` in `Replace` input

* Click `Replace All`


## Fix ProductExcelImportEndpoint.cs

* Remove `using System.IO;`
* Find `ExcelImport()` method and add 3rd parameter `[FromServices] IUploadStorage uploadStorage`. Your method should be like:
```cs
public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
    [FromServices] IUploadStorage uploadStorage)
{
    ...
```
* Find exceptions contains `"filename"` parameters
```cs
ArgumentNullException("filename");
ArgumentOutOfRangeException("filename");
```
and change with `nameof(request.FileName)` like in the following:
```cs
ArgumentNullException(nameof(request.FileName));
ArgumentOutOfRangeException(nameof(request.FileName));
```
* Find this line:
```cs
using (var fs = new FileStream(UploadHelper.DbFilePath(request.FileName), FileMode.Open, FileAccess.Read))
```
and change with:
```cs
using (var fs = uploadStorage.OpenFile(request.FileName))
```
* (optional) You can change `ProductRow` with `MyRow` except using line `using MyRow = StartSharp.Northwind.Entities.ProductRow;`

## Fix AccountPage.ResetPassword.cs

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(.*public\s*ActionResult\s*ResetPassword\s*\(\s*string\s*[a-zA-Z0-9_]*\s*)(\))` in `Find` input

* Type `$1, [FromServices] ISqlConnections sqlConnections$2` in `Replace` input

* Click `Replace All`

* Type `(.*Texts.Validation.InvalidResetToken)(\s*)` in `Find` input

* Type `$1.ToString(Localizer)$2` in `Replace` input

* Click `Replace All`

* Type `((.*)using\s*\(\s*var\s*([a-zA-Z0-9]*)\s*=\s*)SqlConnections(.NewFor<UserRow>\(\)\))` in `Find` input

* Type `$2if (sqlConnections is null)\n$2\tthrow new ArgumentNullException(nameof(sqlConnections));\n\n$1sqlConnections$4` in `Replace` input

* Click `Replace All`

* Type `(.*public\s*Result<ServiceResponse>\s*ResetPassword\s*\(\s*ResetPasswordRequest\s*[a-zA-Z0-9_]*\s*)(\))` in `Find` input

* Type `$1, [FromServices] ISqlConnections sqlConnections$2` in `Replace` input

* Click `Replace All`

* Type `(UserRepository.ValidatePassword\s*\()\s*[a-zA-Z0-9_.]*\s*,\s*(request.NewPassword)\s*,\s*false(.*)` in `Find` input

* Type `$1$2, Localizer$3` in `Replace` input

* Click `Replace All`

## Fix AccountResetPassword.AdminLTE.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.ResetPassword.FormTitle` with `Texts.Forms.Membership.ResetPassword.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ResetPassword.SubmitButton` with `Texts.Forms.Membership.ResetPassword.SubmitButton.ToString(Localizer)`

* Replace `@Texts.Navigation.SiteTitle` with `@Texts.Navigation.SiteTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ResetPassword.BackToLogin` with `Texts.Forms.Membership.ResetPassword.BackToLogin.ToString(Localizer)`

## Fix AccountResetPassword.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.ResetPassword.FormTitle` with `Texts.Forms.Membership.ResetPassword.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.ResetPassword.SubmitButton` with `Texts.Forms.Membership.ResetPassword.SubmitButton.ToString(Localizer)`

## Modify CustomerGrossSalesEndpoint.cs

* Add `using Serenity.PropertyGrid;`

* Find `DynamicDataReport()` method and add 3rd parameter `HttpContext.RequestServices`. Your method should be like:
```cs
var report = new DynamicDataReport(data, request.IncludeColumns, 
    typeof(Columns.CustomerGrossSalesColumns), HttpContext.RequestServices);
```
* Find this line 
```cs
var bytes = new ReportRepository(Context).Render(report);
```
and change with 
```cs 
var bytes = ReportRepository.Render(report);
```

## Modify BackgroundJobManager.cs

* Find this line 
```cs
isDisabled = !Config.Get<Settings>().Enabled;
```
and change with 
```cs 
isDisabled = !options.Value.Enabled;
this.logger = logger;
```

## Modify DailyBackgroundJob.cs

* Find `Initialize()` method and copy and paste in the following lines above that method
```cs
    protected ILogger Log { get; }
    protected IExceptionLogger ExceptionLog { get; }

    protected DailyBackgroundJob(ILogger log, IExceptionLogger exceptionLog)
    {
        Log = log;
        ExceptionLog = exceptionLog;
    }
```

* Open `Replace` dialog in Visual Studio `Ctrl+H` (be sure that `Current Document` is selected)

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(using\s*Serenity;)` in `Find` input

* Type `$1\nusing Microsoft.Extensions.Logging;\nusing Serenity.Abstractions;` in `Replace` input

* Click `Replace All`

* Type `((.*)(private\s*.*retryCount;)())` in `Find` input

* Type `$1\n\n$2protected ILogger Log { get; }\n$2protected IExceptionLogger ExceptionLog { get; }\n\n$2protected DailyBackgroundJob(ILogger log, IExceptionLogger exceptionLog)\n$2{\n$2\tLog = log;\n$2\tExceptionLog = exceptionLog;\n$2}` in `Replace` input

* Click `Replace All`

* Type `(.*)this.(GetType.*)` in `Find` input

* Type `$1$2` in `Replace` input

* Click `Replace All`

* Type `((.*)(Log)(.*.*\(\))(\);))` in `Find` input

* Type `$2$3?.LogInformation(job$5` in `Replace` input

* Click `Replace All`

* Type `((.*)(.Log\()(\);))` in `Find` input

* Type `$2$3ExceptionLog$4` in `Replace` input

* Click `Replace All`
## Fix AccountPage.SignUp.cs

* Add `using StartSharp.Common;`

* Add `using Microsoft.Extensions.Options;`

* Remove `using MailKit.Net.Smtp;`

* Remove `using using MimeKit;`

* Remove `using MailKit.Security;`

* Remove `usinusing System.Web.Hosting;`

* Replace `throw new ArgumentNullException(""email"");` with `throw new ArgumentNullException(nameof(request.Email));`

* Replace `throw new ArgumentNullException(""password"");` with `throw new ArgumentNullException(nameof(request.Password));`

* Replace `throw new ArgumentNullException(""displayName"");` with `throw new ArgumentNullException(nameof(request.DisplayName));`

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(public\s*Result<ServiceResponse>\s*SignUp\s*\(\s*SignUpRequest\s*([A-Za-z0-9_]*))\)(\r\n\s*)` in `Find` input

* Type `$1,$3\t[FromServices] IEmailSender emailSender,$3\t[FromServices] IOptions<EnvironmentSettings> options = null)$3` in `Replace` input

* Click `Replace All`

* Type `(.*Texts.Validation.EmailInUse)(\s*)` in `Find` input

* Type `$1.ToString(Localizer)$2` in `Replace` input

* Click `Replace All`

* Type `Config.Get<EnvironmentSettings>\s*\(\).SiteExternalUrl` in `Find` input

* Type `options?.Value.SiteExternalUrl` in `Replace` input

* Click `Replace All`

* Type `(.*)Common.EmailHelper.Send\(([a-zA-Z0-9_]*)\s*,\s*([a-zA-Z0-9_]*)\s*,\s*([a-zA-Z0-9_]*)\s*\)\s*;(\r\n\s*)` in `Find` input

* Type `$1if (emailSender is null)\n$1\tthrow new ArgumentNullException(nameof(emailSender));$5emailSender.Send(subject: $2, body: $3, mailTo: $4);$5` in `Replace` input

* Click `Replace All`

* Type `(.*UserRetrieveService.RemoveCachedUser\s*\()\s*([a-zA-Z0-9_]*)\s*,\s*([a-zA-Z0-9_]*)(\s*\);)` in `Find` input

* Type `$1Cache, $2, $3$4` in `Replace` input

* Click `Replace All`

* Type `(.*Texts.Validation.InvalidActivateToken)(\s*)` in `Find` input

* Type `$1.ToString(Localizer)$2` in `Replace` input

* Click `Replace All`

## Fix AccountSignUp.AdminLTE.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.SignUp.FormTitle` with `Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.SignUp.SubmitButton` with `Texts.Forms.Membership.SignUp.SubmitButton.ToString(Localizer)`

* Replace `Texts.Forms.Membership.SignUp.AcceptTerms` with `Texts.Forms.Membership.SignUp.AcceptTerms.ToString(Localizer)`

* Replace `Texts.Navigation.SiteTitle` with `Texts.Navigation.SiteTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.SignUp.FormInfo` with `Texts.Forms.Membership.SignUp.FormInfo.ToString(Localizer)`

* Replace `Texts.Forms.Membership.SignUp.BackToLogin` with `Texts.Forms.Membership.SignUp.BackToLogin.ToString(Localizer)`

## Fix AccountSignUp.cshtml

* Add `@injeinject Serenity.ITextLocalizer Localizer`

* Replace `Texts.Forms.Membership.SignUp.FormTitle` with `Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer)`

* Replace `Texts.Forms.Membership.SignUp.FormInfo` with `Texts.Forms.Membership.SignUp.FormInfo.ToString(Localizer)`

* Replace `Texts.Forms.Membership.SignUp.SubmitButton` with `Texts.Forms.Membership.SignUp.SubmitButton.ToString(Localizer)`

## Modify CategoryRepository.cs

* Find the following method and remove 

```csharp
protected override void AfterSave()
{
    base.AfterSave();

    if (Request.Localizations != null)
        foreach (var pair in Request.Localizations)
        {
            pair.Value.CategoryID = Row.CategoryID.Value;
            new LocalizationRowHandler<MyRow>().Update<Entities.CategoryLangRow>(this.UnitOfWork, pair.Value, Convert.ToInt32(pair.Key));
        }
}
```

* Add following method to inside the `private class MySaveHandler..` code block

```csharp
public MySaveHandler(IRequestContext context)
    : base(context)
{
}
```

## Fix CategoryRow.cs

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(\[DisplayName\(""Category Name""\).*NameProperty)]` in `Find` input

* Type `$1, Localizable(true)]` in `Replace` input

* Click `Replace All`

* Type `(\[DisplayName\(""Description""\).*QuickSearch)]` in `Find` input

* Type `$1, Localizable(true)]` in `Replace` input

* Click `Replace All`

## Fix CustomerEndpoint.cs

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `((.*)var\s*[a-zA-Z0-9_]*\s*=\s*new\s*DynamicDataReport\s*\(([a-zA-Z0-9_]*)\s*,\s*([a-zA-Z0-9_.]*)\s*,\s*typeof\(([a-zA-Z0-9_.]*)\s*\))\);` in `Find` input

* Type `$1,\n$2\tHttpContext.RequestServices);` in `Replace` input

* Click `Replace All`

* Type `(.*var\s*[a-zA-Z0-9_]*\s*=\s*)new\s*(ReportRepository)\(Context\)(.Render\(\s*([a-zA-Z0-9_]*)\);)` in `Find` input

* Type `$1$2$3` in `Replace` input

* Click `Replace All`

## Fix CustomerIndex.cshtml

* Add `@inject IContentHashCache ContentHashCache`

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(.*@ContentHashCache.ResolvePath\(\s*)(\"".*)` in `Find` input

* Type `$1Context.Request.PathBase, $2` in `Replace` input

* Click `Replace All`

## Fix CustomerLookup.cs

* Add `using Serenity.Data;`

## Fix CustomerRepository.cs

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(.*SqlExceptionHelper.HandleDeleteForeignKeyException\(\s*[a-zA-Z0-9_]*\s*)(\);)` in `Find` input

* Type `$1, Localizer$2` in `Replace` input

* Click `Replace All`

## Fix CustomerRow.cs

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(.*\[\s*)(LookupEditor\(\s*typeof\(\s*EmployeeRow\s*\)\s*,\s*Multiple\s*=\s*true\s*\)\s*,\s*NotMapped\])` in `Find` input

* Type `$1DisplayName(""Representatives""), $2` in `Replace` input

* Click `Replace All`

## Fix EmployeeListDecorator.cs

* Add `using Serenity.Abstractions;`

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(.*public\s*class\s*EmployeeListDecorator\s*:\s*BaseCellDecorator\r\n\s*{(\r\n\s*))` in `Find` input

* Type `$1public EmployeeListDecorator(ITwoLevelCache cache, ISqlConnections sqlConnections)$2{$2\tCache = cache ?? throw new ArgumentNullException(nameof(cache));$2\tSqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));$2}\n$2public ITwoLevelCache Cache { get; }$2public ISqlConnections SqlConnections { get; }\n$2` in `Replace` input

* Click `Replace All`

## Fix NotesBehavior.cs

* Open `Replace` dialog in Visual Studio `Ctrl+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(.*public\s*class\s*NotesBehavior\s*:\s*.*\r\n\s*{(\r\n\s*))` in `Find` input

* Type `$1public IRequestContext Context { get; }$2public ISqlConnections SqlConnections { get; }\n$2public NotesBehavior(IRequestContext context, ISqlConnections sqlConnections)$2{$2\tContext = context ?? throw new ArgumentNullException(nameof(context));$2\tSqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));$2}\n$2` in `Replace` input

* Click `Replace All`

* Type `(.*idField)\[\s*(handler.Row)\s*\]\s+` in `Find` input

* Type `$1.AsObject($2)` in `Replace` input

* Click `Replace All`

* Type `(.*)(rowIdField)\[\s*([a-zA-Z0-9_]*)\s*\].Value` in `Find` input

* Type `$1Convert.ToInt64($2.AsObject($3))` in `Replace` input

* Click `Replace All`

* Type `(.*)(rowIdField)\[\s*([a-zA-Z0-9_]*)\s*\];` in `Find` input

* Type `$1$2.AsObject($3);` in `Replace` input

* Click `Replace All`

* Type `(.*)(idField)\[\s*([a-zA-Z0-9_.]*)\s*\].Value(.*)` in `Find` input

* Type `$1Convert.ToInt64($2.AsObject($3))$4` in `Replace` input

* Click `Replace All`

* Type `(.*)(id).Value` in `Find` input

* Type `$1Convert.ToInt64($2)` in `Replace` input

* Click `Replace All`