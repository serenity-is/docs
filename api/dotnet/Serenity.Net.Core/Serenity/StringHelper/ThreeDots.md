# StringHelper.ThreeDots method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

If the string's length is over a specified limit, trims its right and adds three points ("...").

```csharp
public static string ThreeDots(this string str, int maxLength)
```

| parameter | description |
| --- | --- |
| str | String. |
| maxLength | Maximum length for the resulting string. If given as 0, or *str* is shorter than this value, string returns as is. Otherwise *str* it is trimmed to be under this limit in length including "the three dots". |

## Return Value

*str* itself, or trimmed and three dotted string

## Remarks

This is an extension method, so it can be called directly as `str.ThreeDots()`.

## See Also

* class [StringHelper](../StringHelper.md)