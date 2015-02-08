# ILocalTextRegistry Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

LocalText class accesses translations for local text keys through the provider for this interface.

```cs
public interface ILocalTextRegistry
{
    string TryGet(string languageID, string key);
    void Add(string languageID, string key, string text);
}
```

## ILocalTextRegistry.TryGet Method

Gets translation for the specified key in requested language.

Current language is determined by *CultureInfo.CurrentUICulture*.

It is *providers responsibility* to check language fallbacks for the key, if a translation is not found in requested language.

This method returns null if no translation is found in the language hierarchy (from requested language down to invariant language).

## ILocalTextRegistry.Add Method

Adds a translation to the local text table which is internally hold by the local text registry.

The local text table is an in-memory table (dictionary) like:

Key                   |LanguageID|Text (Translation)
----------------------|----------|-------------------
Dialogs.YesButton     |en        |Yes
Dialogs.YesButton     |tr        |Evet
Dialogs.NoButton      |en        |No
Dialogs.NoButton      |tr        |Hayır


> This method doesn't throw an exception if same key/language ID pair is added twice. It simply overrides existing translation.


