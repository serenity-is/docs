# DataReaderExtensions.AsBytes method

Reads the value at the field index as a byte array. Returns `null` if the value is DBNull. When the provider does not return a byte array (or SqlBinary) directly, the value is read using the `GetBytes` method, honoring the number of bytes actually returned by each call so that partial reads are not lost.

```csharp
public static byte[]? AsBytes(this IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader (required). |
| index | The field index. |

## Return Value

The field value as a byte array, or `null` if the value is DBNull.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)