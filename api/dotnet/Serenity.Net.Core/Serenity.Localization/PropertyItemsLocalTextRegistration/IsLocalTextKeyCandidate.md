# PropertyItemsLocalTextRegistration.IsLocalTextKeyCandidate method

Returns `true` if the text value can be a local text key that could be passed to the client side.

```csharp
public static bool IsLocalTextKeyCandidate(string? text, bool uiKeyOnly = true)
```

| parameter | description |
| --- | --- |
| text | The key or text. |
| uiKeyOnly | If set to `true`, only considers keys with UI-related prefixes. |

## Return Value

`true` if the text looks like a local text key; otherwise, `false`.

## See Also

* class [PropertyItemsLocalTextRegistration](../PropertyItemsLocalTextRegistration.md)