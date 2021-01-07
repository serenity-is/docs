# StringHelper.TrimToNull method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Removes whitespace characters in the left or right of the String string, and if resulting string is empty or null, returns null.

```csharp
public static string TrimToNull(this string str)
```

| parameter | description |
| --- | --- |
| str | String to be trimmed. |

## Return Value

Trimmed string, result is null if empty.

## Remarks

Generally, when a user entered string is going to be saved to database, if user entered an empty string, `null` or a string of whitespaces, it is stored as `null`, otherwise it is expected to remove whitespace at start and end only.Warning: "\n" (line end), "\t" (tab) and some other are also considered as whitespace). To see a list see Trim function.This is an extension method, so it can be called directly as `str.TrimToNull()`.

## See Also

* class [StringHelper](../StringHelper.md)