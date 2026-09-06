# ITextLocalizer.TryGet method

Gets the translation for a key based on the context language and pending approval state, or `null` if not available.

```csharp
public string? TryGet(string key)
```

| parameter | description |
| --- | --- |
| key | The local text key. |

## Return Value

The translated text, or `null` if no translation is found in the context language.

## See Also

* interface [ITextLocalizer](../ITextLocalizer.md)