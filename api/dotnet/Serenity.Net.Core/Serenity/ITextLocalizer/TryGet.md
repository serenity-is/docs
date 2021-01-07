# ITextLocalizer.TryGet method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets translation for a key based on the context language / pending approval state, or null if not available

```csharp
public string TryGet(string key)
```

| parameter | description |
| --- | --- |
| key | Local text key |

## Return Value

Translated text or null if no translation found in the context language

## See Also

* interface [ITextLocalizer](../ITextLocalizer.md)