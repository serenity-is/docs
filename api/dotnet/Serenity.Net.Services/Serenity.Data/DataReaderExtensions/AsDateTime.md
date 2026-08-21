# DataReaderExtensions.AsDateTime method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Reads the value at the field index. Returns `null` if the value is DBNull.

```csharp
public static DateTime? AsDateTime(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader (required). |
| index | The field index. |

## Return Value

The field value, or `null` if the value is DBNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)