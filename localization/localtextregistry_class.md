# LocalTextRegistry 类

[**命名空间**: *Serenity.Localization*, **程序集**: *Serenity.Core*]

此类是 ILocalTextRegistry 接口可嵌入的默认实现。

```cs
public class LocalTextRegistry : ILocalTextRegistry
{
    public void Add(string languageID, string key, string text);
    public string TryGet(string languageID, string key);
    public void SetLanguageFallback(string languageID, string languageFallbackID);

    public void AddPending(string languageID, string key, string text);
    public string TryGet(string languageID, string textKey, bool isApprovalMode);

    public Dictionary<string, string> GetAllAvailableTextsInLanguage(
        string languageID, bool pending);
}
```

Add 和 TryGet 实现了 ILocalTextRegistry 接口的相应方法。

## LocalTextRegistry.SetLanguageFallback 方法

为语言回退（language fallback）设置指定的语言。

```cs
var registry = (LocalTextRegistry)(Dependency.Resolve<ILocalTextRegistry>());
registry.SetLanguageFallback('en-UK', 'en-US');
// from now on if a translation is not found in "en-UK" language,
// it will be looked up in "en-US" language first, followed by "en".
```

> 可以在有关章节中找到有关语言回退的详细信息。


## 注册 LocalTextRegistry 作为提供者

通常在应用程序启动方法中做此操作：

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();
registrar.RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());
```

> 如果没有已注册的提供者，*CommonInitialization.Run* 或 *CommonInitialization.InitializeLocalTexts* 方法将注册一个 LocalTextRegistry 实例作为 ILocalTextRegistry 提供者。
