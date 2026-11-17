# ITranslationKeyProvider.GetKeys method

Gets the keys with the texts they are meant to be translated from, which are what is shown for the key when it has no text in the registry.

```csharp
public IEnumerable<KeyValuePair<string, string?>> GetKeys()
```

## Return Value

The keys with their source texts, which can be null when there is none.

## See Also

* interface [ITranslationKeyProvider](../ITranslationKeyProvider.md)