# RegexWithDefault.Combine method

Gets the regular expression matching what the default or the configured pattern matches.

```csharp
public static string? Combine(bool useDefault, string defaultPattern, string? pattern)
```

| parameter | description |
| --- | --- |
| useDefault | Whether the default pattern is used. |
| defaultPattern | The default pattern. |
| pattern | The configured pattern, if any. |

## Return Value

The combined pattern, or null when nothing is to be matched.

## See Also

* class [RegexWithDefault](../RegexWithDefault.md)