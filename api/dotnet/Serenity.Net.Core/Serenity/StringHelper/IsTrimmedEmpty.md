# StringHelper.IsTrimmedEmpty method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Checks if a string String is `null`, empty or just contains whitespace characters.

```csharp
public static bool IsTrimmedEmpty(this string str)
```

| parameter | description |
| --- | --- |
| str | String. |

## Return Value

If string is null, empty or contains only white space, `true`

## Remarks

Warning: "\n" (line end), "\t" (tab) and some other are also considered as whitespace). To see a list see Trim function.This is an extension method, so it can be called directly as `str.IsTrimmedEmpty()`.

## See Also

* class [StringHelper](../StringHelper.md)