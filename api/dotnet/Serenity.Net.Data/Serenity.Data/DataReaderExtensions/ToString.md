# DataReaderExtensions.ToString method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Reads and converts value at field index to String. Returns DbNull as null.

```csharp
public static string ToString(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | Reader (required). |
| index | Index. |

## Return Value

Field value or null if value is DbNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)