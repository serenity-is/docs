# DataReaderExtensions.ReadAsync method

Asynchronously advances the data reader to the next record, using the native CancellationToken) when available, and falling back to a synchronous Read for readers that do not support async operations.

```csharp
public static Task<bool> ReadAsync(this IDataReader reader, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| reader | The data reader. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result is true if there is another row to read.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)