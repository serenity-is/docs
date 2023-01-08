# IFilenameFormatSanitizer interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for sanitizing values of replacement placeholders in a file name format string like &#x7C;X&#x7C;/&#x7C;Y&#x7C;. Sanitizer is called for each of the placeholders and for the result. Can be implemented by custom subclasses of upload editor attributes or registered in DI.

```csharp
public interface IFilenameFormatSanitizer
```

## Members

| name | description |
| --- | --- |
| [SanitizePlaceholder](IFilenameFormatSanitizer/SanitizePlaceholder.md)(…) | Sanitizes the placeholder value |
| [SanitizeResult](IFilenameFormatSanitizer/SanitizeResult.md)(…) | Sanitizes the formatting result, usually by replacing double slashes resulting from an empty replacement value with /_/ to keep expected directory structure. |

## See Also