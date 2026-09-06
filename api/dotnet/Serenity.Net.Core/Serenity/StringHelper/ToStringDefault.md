# StringHelper.ToStringDefault&lt;T&gt; method (1 of 2)

Formats a nullable object

```csharp
public static string ToStringDefault<T>(this T source, string? format = null, 
    IFormatProvider? provider = null, string? empty = null)
    where T : class, IFormattable
```

| parameter | description |
| --- | --- |
| source | The value to format. |
| format | The format string If `null` use the default format defined for the type of the IFormattable implementation. |
| provider | The format provider If `null` the default provider is used |
| empty | The string to show when the source is `null`. If `null` an empty string is returned |

## Return Value

The formatted string or the default value if the source is `null`

## See Also

* class [StringHelper](../StringHelper.md)

---

# StringHelper.ToStringDefault&lt;T&gt; method (2 of 2)

Formats a nullable struct

```csharp
public static string ToStringDefault<T>(this T? source, string? format = null, 
    IFormatProvider? provider = null, string? empty = null)
    where T : struct, IFormattable
```

| parameter | description |
| --- | --- |
| source | The value to format. |
| format | The format string If `null` use the default format defined for the type of the IFormattable implementation. |
| provider | The format provider If `null` the default provider is used |
| empty | The string to show when the source is `null`. If `null` an empty string is returned |

## Return Value

The formatted string or the default value if the source is `null`

## See Also

* class [StringHelper](../StringHelper.md)