# LocalText.ToString method

Returns the translation for the current context.

```csharp
public string ToString(ITextLocalizer? localizer)
```

| parameter | description |
| --- | --- |
| localizer | The text localizer used to resolve the translation. |

## Return Value

The translated text, or the key itself if no translation is found.

## See Also

* interface [ITextLocalizer](../ITextLocalizer.md)
* class [LocalText](../LocalText.md)