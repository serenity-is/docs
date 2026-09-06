# StringHelper.IsTrimmedEmpty method

This function is just an extension method version of string.IsNullOrWhitespace and is effectively obsolete.

```csharp
public static bool IsTrimmedEmpty(this string? str)
```

| parameter | description |
| --- | --- |
| str | String. |

## Return Value

If *str* is `null`, empty or whitespace, `true`

## See Also

* class [StringHelper](../StringHelper.md)