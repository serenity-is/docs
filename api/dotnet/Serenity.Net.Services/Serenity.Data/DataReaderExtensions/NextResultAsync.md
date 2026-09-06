# DataReaderExtensions.NextResultAsync method

Asynchronously advances the data reader to the next result set, using the native CancellationToken) when available, and falling back to a synchronous NextResult for readers that do not support async operations.

```csharp
public static Task<bool> NextResultAsync(this IDataReader reader, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| reader | The data reader. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result is true if there are more result sets.

## See Also

* class [DataReaderExtensions](../DataReaderExtensions.md)