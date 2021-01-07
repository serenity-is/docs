# DataReaderExtensions.AsInt32 method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads value at field index. Returns DbNull as Null.Int32.

```csharp
public static int? AsInt32(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or Null.Int32 if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)