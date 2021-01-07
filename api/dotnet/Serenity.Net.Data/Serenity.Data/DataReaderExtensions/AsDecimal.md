# DataReaderExtensions.AsDecimal method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads value at field index. Returns DbNull as Null.Decimal.

```csharp
public static decimal? AsDecimal(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or Null.Decimal if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)