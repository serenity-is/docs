# DefaultFilenameFormatSanitizer.SanitizePlaceholder method
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Default implementation for sanitizing values of replacement placeholders in a file name format string like &#x7C;X&#x7C;/&#x7C;Y&#x7C;. Trims the value, and if it is empty, returns "_". Characters like '/', '&amp;', and diacritics etc. are replaced by calling StringHelper.SanitizeFileName, then replacing backslashes with underscore, and double dots and trailing dots with underscore.

```csharp
public virtual string SanitizePlaceholder(string _, string value)
```

| parameter | description |
| --- | --- |
| _ | Key for placeholder, ignored by this implementation. |
| value | Value to be sanitized. |

## See Also

* class [DefaultFilenameFormatSanitizer](../DefaultFilenameFormatSanitizer.md)