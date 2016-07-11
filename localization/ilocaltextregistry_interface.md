# ILocalTextRegistry 接口 

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

LocalText 类通过该接口的提供者访问本地化文本键的翻译。

```cs
public interface ILocalTextRegistry
{
    string TryGet(string languageID, string key);
    void Add(string languageID, string key, string text);
}
```

## ILocalTextRegistry.TryGet 方法 

获得目标语言指定键的翻译。

由 *CultureInfo.CurrentUICulture* 决定当前语言。

如果没有在请求语言中找到翻译，*提供者的职责* 是检查键的语言回退。

如果在语言层级（从请求语言往固定语言搜索）没有找到翻译，该方法返回 null。

## ILocalTextRegistry.Add 方法 

向内部由本地化文本注册保存的本地化文本表中添加翻译。

本地化文本表是内存表（字典），如：

Key                   |LanguageID|Text (Translation)
----------------------|----------|-------------------
Dialogs.YesButton     |en        |Yes
Dialogs.YesButton     |tr        |Evet
Dialogs.NoButton      |en        |No
Dialogs.NoButton      |tr        |Hayır


> 如果 Key/LanguageID 对被重复添加，该方法不会抛出异常。它会覆盖已存在的翻译。


