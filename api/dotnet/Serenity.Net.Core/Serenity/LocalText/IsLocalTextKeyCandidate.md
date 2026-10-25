# LocalText.IsLocalTextKeyCandidate method

Determines whether the specified text is a candidate for a local text key, optionally restricting to UI key prefixes.

```csharp
public static bool IsLocalTextKeyCandidate(string? text, bool uiKeyOnly = true)
```

| parameter | description |
| --- | --- |
| text | The text to evaluate as a potential local text key. |
| uiKeyOnly | If set to `true`, only considers keys with UI-related prefixes. |

## Return Value

`true` if the text is a candidate for a local text key; otherwise, `false`.

## See Also

* class [LocalText](../LocalText.md)