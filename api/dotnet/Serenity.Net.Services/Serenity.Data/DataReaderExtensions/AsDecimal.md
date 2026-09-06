# DataReaderExtensions.AsDecimal method

Reads the value at the field index. Returns `null` if the value is DBNull.

```csharp
public static decimal? AsDecimal(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader (required). |
| index | The field index. |

## Return Value

The field value, or `null` if the value is DBNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)