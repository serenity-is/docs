# StringHelper.IsNullOrEmpty method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns true if String is `null` or empty (zero length)

```csharp
public static bool IsNullOrEmpty(this string str)
```

| parameter | description |
| --- | --- |
| str | String. |

## Return Value

If *str* is `null` or empty, `true`

## Remarks

This function might be useful if an empty string is assumed to be `null`.This is an extension method, so it can be called directly as `str.IsNullOrEmpty()`.

## See Also

* class [StringHelper](../StringHelper.md)