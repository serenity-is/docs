# DataReaderExtensions.ToInt64 method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads and converts value at field index to Int64. Returns DbNull as Null.Int64.

```csharp
public static long? ToInt64(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or Null.Int64 if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)