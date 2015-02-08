# LocalTextRegistry Class

[**namespace**: *Serenity.Localization*, **assembly**: *Serenity.Core*]

This class is the embedded, default implementation of ILocalTextRegistry interface.

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

Add and TryGet implements corresponding methods in ILocalTextRegistry interface.

## LocalTextRegistry.SetLanguageFallback Method

Sets language fallback for specified language.

```cs
var registry = (LocalTextRegistry)(Dependency.Resolve<ILocalTextRegistry>());
registry.SetLanguageFallback('en-UK', 'en-US');
// from now on if a translation is not found in "en-UK" language,
// it will be looked up in "en-US" language first, followed by "en".
```

> More information about language fallbacks can be found in relevant section.


## Registering LocalTextRegistry as Provider

This is usually done in your application start method:

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();
registrar.RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());
```

> *CommonInitialization.Run* or *CommonInitialization.InitializeLocalTexts* methods also register a LocalTextRegistry instance as the ILocalTextRegistry provider, if none is already registered.
