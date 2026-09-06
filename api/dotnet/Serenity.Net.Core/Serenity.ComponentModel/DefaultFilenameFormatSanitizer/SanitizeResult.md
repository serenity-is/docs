# DefaultFilenameFormatSanitizer.SanitizeResult method

Sanitizing an upload filename formatting result by replacing backslashes with forward slashes, and replacing double slashes with "/_/".

```csharp
public virtual string SanitizeResult(string result)
```

| parameter | description |
| --- | --- |
| result | The formatted file name result to sanitize. |

## Return Value

The sanitized file name result.

## See Also

* class [DefaultFilenameFormatSanitizer](../DefaultFilenameFormatSanitizer.md)