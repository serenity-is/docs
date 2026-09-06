# TextLocalizerExtensions.Get method

Gets the translation for a key.

```csharp
public static string Get(this ITextLocalizer localTexts, string key)
```

| parameter | description |
| --- | --- |
| localTexts | The text localizer. |
| key | The key. |

## Return Value

The translated text, or the key itself if no translation is found.

## See Also

* interface [ITextLocalizer](../ITextLocalizer.md)
* class [TextLocalizerExtensions](../TextLocalizerExtensions.md)