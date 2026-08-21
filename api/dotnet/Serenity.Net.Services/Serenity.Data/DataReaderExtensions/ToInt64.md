# DataReaderExtensions.ToInt64 method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Reads and converts the value at the field index to Int64. Returns `null` if the value is DBNull.

```csharp
public static long? ToInt64(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader (required). |
| index | The field index. |

## Return Value

The field value, or `null` if the value is DBNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)