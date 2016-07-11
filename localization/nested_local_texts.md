# 嵌入本地化文本

Serenity 允许你定义包含 LocalText 对象的静态嵌套类来定义翻译，如：

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

此定义允许使用智能感知来引用本地化文本，而不必记住字符串键。

这些嵌入式的翻译通常用于定义固定语言（最终回退）的默认翻译。

这是该 *Texts* 类定义的翻译表：

Key                             |LanguageID|Text (Translation)
--------------------------------|----------|-------------------------------
Site.Dashboard.WelcomeMessage   |          |Welcome to Serenity BasicApp...
Validation.DeleteForeignKeyError|          |Can't delete record...
Validation.SavePrimaryKeyError  |          |Can't save record...

本地化文本键由静态嵌套类之间使用点连接类名组成。尽管使用 *Texts* 命名以保持一致性是好主意，但是最顶层静态类（Texts）的名称将被忽略。

除非另有说明，这些文本的 LanguageID 都被认为是固定语言（空字符串）。

## NestedLocalTexts 特性

嵌套本地化文本注册类的最顶层类（如 *Texts*）必须有该属性。

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

它包含两个可选属性：*LanguageID* 和 *Prefix*。

*LanguageID* 允许你定义翻译的目标语言。

> 如果没有指定该属性，将使用固定语言。

> 在固定语言中注册默认文本是一个好注意，即使注册的文本不是英文。因为它是所有语言的最终回退语言。

如果我们这样使用：

```cs
[NestedLocalTexts(LanguageID = "en-US")]
public static partial class Texts
{
    // ..
}
```

在翻译表的 LanguageID 列将是 "en-US"：

Key                             |LanguageID|Text (Translation)
--------------------------------|----------|-------------------------------
Site.Dashboard.WelcomeMessage   |en-US     |Welcome to Serenity BasicApp...
Validation.DeleteForeignKeyError|en-US     |Can't delete record...

Prefix 属性值被用来作为本地化文本键（local text keys）前缀：

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


## NestedLocalTextRegistration 类 

[**命名空间**: *Serenity.Localization*, **程序集**: *Serenity.Core*]

要注册嵌套本地化文本定义，需要在应用程序启用时调用 *NestedLocalTextRegistration.Initialize()* 方法： 

```cs
void Application_Start()
{
    NestedLocalTextRegistration.Initialize();
}
```

> 默认调用 CommonInitialization.Run 和 CommonInitialization.InitializeLocalTexts 方法。

一旦运行应用程序，所有自动生成键的翻译都添加到当前的 ILocalTextRegistry 提供者，并且在静态嵌套类中的 LocalText 实例被替换为包含生成键（通过反射设置）的实际 LocalText 实例。


