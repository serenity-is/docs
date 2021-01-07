# DataReaderExtensions.ToInt32 method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads and converts value at field index to Int32. Returns DbNull as Null.Int32.

```csharp
public static int? ToInt32(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or Null.Int32 if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)