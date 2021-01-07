# DataReaderExtensions.ToDouble method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads and converts value at field index to Double. Returns DbNull as Null.Double.

```csharp
public static double? ToDouble(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or Null.Double if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)