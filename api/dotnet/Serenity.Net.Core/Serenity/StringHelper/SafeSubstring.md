# StringHelper.SafeSubstring method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

A substring function that doesn't raise out of bound errors or null reference exception.

```csharp
public static string SafeSubstring(this string value, int startIndex, int maxLength)
```

| parameter | description |
| --- | --- |
| value | The value. |
| startIndex | The start index. |
| maxLength | The maximum length. |

## Return Value

Substring or empty string.

## See Also

* class [StringHelper](../StringHelper.md)