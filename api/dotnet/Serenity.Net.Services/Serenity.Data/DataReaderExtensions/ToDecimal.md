# DataReaderExtensions.ToDecimal method

Reads and converts the value at the field index to Decimal. Returns `null` if the value is DBNull.

```csharp
public static decimal? ToDecimal(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader (required). |
| index | The field index. |

## Return Value

The field value, or `null` if the value is DBNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)