# Enumeration Texts

Display text for enumeration values can be specified with Description attribute.

```
namespace MyApplication
{
    public enum Sample
    {
        [Description("First Value")]
        Value1 = 1,
        [Description("Second Value")]
        Value2 = 2
    }
}
```

This enumeration and its Description attributes defines following local text keys and translations:

Key                              |LanguageID|Text (Translation)
---------------------------------|----------|-------------------------------
Enums.MyApplication.Sample.Value1|          |First Value
Enums.MyApplication.Sample.Value2|          |Second Value

> All texts are defined for invariant language ID by default.

You can use these keys to access translated descriptions for enumeration values, or use extension method GetText() defined for enumeration types (import namespace Serenity to make this extension method available).

```cs
using Serenity;
//...
Console.WriteLine(MyApplication.Sample.Value1.GetText());
```

```
> First Value
```

## EnumKey Attribute

Enumeration translations use full name of enumeration type as prefix to generate local text keys. This prefix can be overriden with EnumKeyAttribute:

```
namespace MyApplication
{
    [EnumKey("Something")]
    public enum Sample
    {
        [Description("First Value")]
        Value1 = 1,
        [Description("Second Value")]
        Value2 = 2
    }
}
```

Now defined keys and translations are:

Key                   |LanguageID|Text (Translation)
----------------------|----------|-------------------------------
Enums.Something.Value1|          |First Value
Enums.Something.Value2|          |Second Value


## EnumLocalTextRegistration Class

[**namespace**: *Serenity.Localization*, **assembly**: *Serenity.Core*]

For enumeration local text definitions to be registered, you need to call *EnumLocalTextRegistration.Initialize()* method in your application start:

```cs
void Application_Start()
{
    EnumLocalTextRegistration.Initialize(ExtensibilityHelper.SelfAssemblies);
}
```

It gets list of assemblies to search for enumeration types. You can pass list of assemblies manually or use *ExtensibilityHelper.SelfAssemblies* which contains all assemblies that reference a Serenity assembly.

> CommonInitialization.Run and CommonInitialization.InitializeLocalTexts methods call it by default.


