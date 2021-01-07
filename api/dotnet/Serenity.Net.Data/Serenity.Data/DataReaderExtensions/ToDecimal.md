# DataReaderExtensions.ToDecimal method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads and converts value at field index to Decimal. Returns DbNull as Null.Decimal.

```csharp
public static decimal? ToDecimal(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or Null.Decimal if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)