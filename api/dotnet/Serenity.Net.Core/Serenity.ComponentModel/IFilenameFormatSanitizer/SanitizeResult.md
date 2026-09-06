# IFilenameFormatSanitizer.SanitizeResult method

Sanitizes the formatting result, usually by replacing double slashes resulting from an empty replacement value with /_/ to keep expected directory structure.

```csharp
public string SanitizeResult(string result)
```

| parameter | description |
| --- | --- |
| result | The formatted file name result to sanitize. |

## See Also

* interface [IFilenameFormatSanitizer](../IFilenameFormatSanitizer.md)