# DefaultFilenameFormatSanitizer class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default implementation for [`IFilenameFormatSanitizer`](./IFilenameFormatSanitizer.md).

```csharp
public class DefaultFilenameFormatSanitizer : IFilenameFormatSanitizer
```

## Public Members

| name | description |
| --- | --- |
| [DefaultFilenameFormatSanitizer](DefaultFilenameFormatSanitizer/DefaultFilenameFormatSanitizer.md)() | The default constructor. |
| virtual [SanitizePlaceholder](DefaultFilenameFormatSanitizer/SanitizePlaceholder.md)(…) | Default implementation for sanitizing values of replacement placeholders in a file name format string like &#x7C;X&#x7C;/&#x7C;Y&#x7C;. Trims the value, and if it is empty, returns "_". Characters like '/', '&amp;', and diacritics etc. are replaced by calling StringHelper.SanitizeFileName, then replacing backslashes with underscore, and double dots and trailing dots with underscore. |
| virtual [SanitizeResult](DefaultFilenameFormatSanitizer/SanitizeResult.md)(…) | Sanitizing an upload filename formatting result by replacing backslashes with forward slashes, and replacing double slashes with "/_/". |
| static readonly [Instance](DefaultFilenameFormatSanitizer/Instance.md) | An instance of this class. |

## See Also

* interface [IFilenameFormatSanitizer](./IFilenameFormatSanitizer.md)
* **Source:** *[DefaultFilenameFormatSanitizer.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Upload/DefaultFilenameFormatSanitizer.cs)*