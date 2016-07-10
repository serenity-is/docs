# 嵌入本地化文本 Nested Local Texts

Serenity allows you to define nested static classes containing LocalText objects to define translations like below:

```cs
[NestedLocalTexts]
public static partial class Texts
{
    public static class Site
    {
        public static class Dashboard
        {
            public static LocalText WelcomeMessage =
                "Welcome to Serenity BasicApplication home page. " +
                "Use the navigation on left to browse other pages...";
        }
    }

    public static class Validation
    {
        public static LocalText DeleteForeignKeyError =
            "Can't delete record. '{0}' table has records that depends on this one!";

        public static LocalText SavePrimaryKeyError =
            "Can't save record. There is another record with the same {1} value!";
    }
}
```

This definitions allow you to reference localized texts with intellisense support, without having to memorize string keys.

These embedded translation definitions are commonly used to define default translations in invariant language (ultimate fallbacks).

Here is a table of translations that are defined with this *Texts* class:

Key                             |LanguageID|Text (Translation)
--------------------------------|----------|-------------------------------
Site.Dashboard.WelcomeMessage   |          |Welcome to Serenity BasicApp...
Validation.DeleteForeignKeyError|          |Can't delete record...
Validation.SavePrimaryKeyError  |          |Can't save record...

Local text keys are generated from nested static class names with a dot inserted between. Topmost static class (Texts) name is ignored though it is a good idea to name it something like *Texts* for consistency.

Unless otherwise stated, language ID for these texts are considered to be the invariant language (empty string).

## NestedLocalTexts Attribute

Topmost class (e.g. *Texts*) for nested local text registration classes must have this attribute.

```cs
[AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
public sealed class NestedLocalTextsAttribute : Attribute
{
    public NestedLocalTextsAttribute()
    {
    }

    public string LanguageID { get; set; }
    public string Prefix { get; set; }
}
```

It has two optional attributes, *LanguageID* and *Prefix*.

*LanguageID* allows you to define what language translations are in.

> If not specified, translations are considered to be in the invariant language.

> It is a good idea to register default texts in invariant language, even if texts are not in English, as invariant language is the eventual language fallback for all languages.

If we used it like:

```cs
[NestedLocalTexts(LanguageID = "en-US")]
public static partial class Texts
{
    // ..
}
```

LanguageID column in translations table would be "en-US":

Key                             |LanguageID|Text (Translation)
--------------------------------|----------|-------------------------------
Site.Dashboard.WelcomeMessage   |en-US     |Welcome to Serenity BasicApp...
Validation.DeleteForeignKeyError|en-US     |Can't delete record...

Prefix attribute value is used as a prefix for local text keys:

```cs
[NestedLocalTexts(LanguageID = "en-US", Prefix = "APrefix.")]
public static partial class Texts
{
    // ..
}
```

Key                                        |LanguageID|Text (Translation)
-------------------------------------------|----------|-------------------------------
APrefix.Site.Dashboard.WelcomeMessage      |en-US     |Welcome to Serenity BasicApp...
APrefix.Validation.DeleteForeignKeyError   |en-US     |Can't delete record...


## NestedLocalTextRegistration Class

[**namespace**: *Serenity.Localization*, **assembly**: *Serenity.Core*]

For nested local text definitions to be registered, you need to call *NestedLocalTextRegistration.Initialize()* method in your application start:

```cs
void Application_Start()
{
    NestedLocalTextRegistration.Initialize();
}
```

> CommonInitialization.Run and CommonInitialization.InitializeLocalTexts methods call it by default.

Once it is run, all translations with auto generated keys are added to current ILocalTextRegistry provider and LocalText instances in nested static classes are replaced with actual LocalText instances containing generated keys (they are set through reflection).


