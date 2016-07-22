# 枚举文本

可以用 Description 特性显示指定枚举值的文本。

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

此枚举和它的 Description 特性定义以下的本地化文本键和翻译：

Key                              |LanguageID|Text (Translation)
---------------------------------|----------|-------------------------------
Enums.MyApplication.Sample.Value1|          |First Value
Enums.MyApplication.Sample.Value2|          |Second Value

> 默认情况下，所有的文本都作为固定语言 ID 的翻译。

可以使用这些键访问枚举值的翻译描述，或者使用枚举类型（需引用 Serenity 命名空间） 定义的扩展方法 GetText()。

```cs
using Serenity;
//...
Console.WriteLine(MyApplication.Sample.Value1.GetText());
```

```
> First Value
```

## EnumKey 特性

枚举翻译使用枚举类型的全名作为生成本地文本键的前缀。该前缀也以被 EnumKeyAttribute 重载：

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

现在定义的键和翻译是：

Key                   |LanguageID|Text (Translation)
----------------------|----------|-------------------------------
Enums.Something.Value1|          |First Value
Enums.Something.Value2|          |Second Value


## EnumLocalTextRegistration 类

[**命名空间**: *Serenity.Localization*, **程序集**: *Serenity.Core*]

若要枚举注册的本地化文本定义，你需要在应用程序启动时调用 *EnumLocalTextRegistration.Initialize()* 方法：

```cs
void Application_Start()
{
    EnumLocalTextRegistration.Initialize(ExtensibilityHelper.SelfAssemblies);
}
```

它获取程序集列表以检索枚举类型。你可以手工传递程序集列表或使用 *ExtensibilityHelper.SelfAssemblies* （包含 Serenity 程序集的所有引用）。

> 默认情况下， CommonInitialization.Run 和 CommonInitialization.InitializeLocalTexts 方法会调用它。


