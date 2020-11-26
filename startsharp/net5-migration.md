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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `class ([A-Za-z]*)Row\s*:\s*IRow` in `Find` input

* Type `class $1Row : Row<$1Row.RowFields>` in `Replace` input

* Click `Replace All`

* Save all open files if any

## Removing Static RowFields Instance from Rows

We used to have a static RowFields instance named `Fields` in row classes which is no longer required as the base generic row class already have a correctly typed static `Fields` property with the same name.

> This new design will open way to having different sets of fields for multi tenant row customization scenarios in the future.

* Open `Replace in Fields` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is checked.

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `(\[[^\{\}]*)(\][\r\n\s]*public [A-Za-z0-9]+\?? )([A-Za-z]+)(\s*\r?\n+[\s\S\n]+)(\r?\n\s*StringField\s*INameRow.NameField[\s\r\n]*(\{[\r\n\s]*get[r\n\s]*\{[\r\n\s]*return|=>\s*) Fields.)(\3)([\s]*;([\r\n\s]*\}[\r\n\s]*\}|))\r?\n?\r?\n?` in `Find` input

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `` in `Find` input

* Type `$1, NameProperty$2$3$4` in `Replace` input

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `([\t ]*)Check.NotNull\(([A-Za-z0-9\.]+),\s*([^\n\r]*)\);([\r]?\n)` in `Find` input

* Type `$1if ($2 is null)$4$1    throw new ArgumentNullException($3);$4` in `Replace` input

* Click `Replace All`

## Replacing Check.NotNullOrEmpty Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `([\t ]*)Check.NotNullOrEmpty\(([A-Za-z0-9\.]+),\s*([^\n\r]*)\);([\r]?\n)` in `Find` input

* Type `$1if (string.IsNullOrEmpty($2))$4$1    throw new ArgumentNullException($3);$4` in `Replace` input

* Click `Replace All`

## Replacing Check.NotNullOrWhiteSpace Calls

* Open `Replace in Files` dialog in Visual Studio `Ctrl+Shift+H`

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `([\t ]*)Check.NotNullOrWhiteSpace\(([A-Za-z0-9\.]+),\s*([^\n\r]*)\);([\r]?\n)` in `Find` input

* Type `$1if (string.IsNullOrWhiteSpace($2))$4$1    throw new ArgumentNullException($3);$4` in `Replace` input

* Click `Replace All`

* Save all open files if any

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

* Make sure `Match case` is Checked, `Match whole word` is NOT checked and `Use regular expressions` is Checked.

* Type `[\t ]*\[[\t ]*(SettingScope\(.*\)\,|)[\t ]*SettingKey\("(.*)"\)\][\t ]*\r?\n[\s\r\n]*public class[\t ]*([A-Za-z0-9]*)[\t ]*(\r?\n)[\r\n]*([\t ]*)\{` in `Find` input

* Type `$5// services.Configure<$3>(Configuration.GetSection($3.SectionKey));$4$5public class $3$4$5{$4$5    public const string SectionKey = "AppSettings:$2";$4` in `Replace` input

* Click `Replace All`

Now your setting class will turn into this:

```csharp
// services.Configure<InstalledModuleSettings>(Configuration.GetSection(MyCustomSettings.SectionKey));
public class MyCustomSettings
{
    public const string SectionKey = "AppSettings:MyCustomKey";
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

Repeat this for all settings classes you have.

> Serenity used to keep its own settings under `AppSettings:` thats why we used that prefix in `SectionKey` so that your existing config in `appsettings.json` will be properly matched. This prefix is no longer required. If you choose to move your custom settings up a level in `appsettings.json` just remove `AppSettings:` prefix in `SectionKey` (after moving the setting to the root).

## Replacing `Config.Get<TSettings>` Calls

As noted in previous section, `Config` class is removed and we'll be using .NET options pattern instead.

Unfortunately this is not something we can do simply with Search/Replace.

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


