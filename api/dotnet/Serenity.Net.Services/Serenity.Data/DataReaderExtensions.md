# DataReaderExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extension methods for IDataReader objects.

```csharp
public static class DataReaderExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AsDateTime](DataReaderExtensions/AsDateTime.md)(…) | Reads the value at the field index. Returns `null` if the value is DBNull. |
| static [AsDecimal](DataReaderExtensions/AsDecimal.md)(…) | Reads the value at the field index. Returns `null` if the value is DBNull. |
| static [AsDouble](DataReaderExtensions/AsDouble.md)(…) | Reads the value at the field index. Returns `null` if the value is DBNull. |
| static [AsInt32](DataReaderExtensions/AsInt32.md)(…) | Reads the value at the field index. Returns `null` if the value is DBNull. |
| static [AsInt64](DataReaderExtensions/AsInt64.md)(…) | Reads the value at the field index. Returns `null` if the value is DBNull. |
| static [AsString](DataReaderExtensions/AsString.md)(…) | Reads the value at the field index. Returns `null` if the value is DBNull. |
| static [NextResultAsync](DataReaderExtensions/NextResultAsync.md)(…) | Asynchronously advances the data reader to the next result set, using the native CancellationToken) when available, and falling back to a synchronous NextResult for readers that do not support async operations. |
| static [ReadAsync](DataReaderExtensions/ReadAsync.md)(…) | Asynchronously advances the data reader to the next record, using the native CancellationToken) when available, and falling back to a synchronous Read for readers that do not support async operations. |
| static [ToDateTime](DataReaderExtensions/ToDateTime.md)(…) | Reads and converts the value at the field index to DateTime. Returns `null` if the value is DBNull. |
| static [ToDecimal](DataReaderExtensions/ToDecimal.md)(…) | Reads and converts the value at the field index to Decimal. Returns `null` if the value is DBNull. |
| static [ToDouble](DataReaderExtensions/ToDouble.md)(…) | Reads and converts the value at the field index to Double. Returns `null` if the value is DBNull. |
| static [ToInt32](DataReaderExtensions/ToInt32.md)(…) | Reads and converts the value at the field index to Int32. Returns `null` if the value is DBNull. |
| static [ToInt64](DataReaderExtensions/ToInt64.md)(…) | Reads and converts the value at the field index to Int64. Returns `null` if the value is DBNull. |
| static [ToString](DataReaderExtensions/ToString.md)(…) | Reads and converts the value at the field index to String. Returns `null` if the value is DBNull. |

## See Also

* **Source:** *[DataReaderExtensions.cs](https://github.com/serenity-is/Serenity/blob/41745e6f6cee341e0662ee7a59c54637f6b1e8de/src/services/Data/Connections/DataReaderExtensions.cs)*