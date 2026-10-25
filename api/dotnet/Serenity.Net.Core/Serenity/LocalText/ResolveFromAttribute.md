# LocalText.ResolveFromAttribute method

Resolves the local text key and invariant text for an attribute value.

```csharp
public static ResolveLocalTextResult ResolveFromAttribute(Attribute attribute, string? text, 
    string? defaultKey)
```

| parameter | description |
| --- | --- |
| attribute | The attribute that defines the text. |
| text | The attribute's invariant text. |
| defaultKey | The fallback key, or `null` or empty when no fallback key is available. |

## Return Value

The resolved local text key, invariant text, and fallback behavior.

## See Also

* record [ResolveLocalTextResult](../../Serenity.Localization/ResolveLocalTextResult.md)
* class [LocalText](../LocalText.md)