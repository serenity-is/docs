# ISqlOperationInterceptor.ExecuteReaderAsync method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Intercepts the async [`SqlHelper`](../SqlHelper.md)`ExecuteReader` methods. The default implementation forwards to [`ExecuteReader`](ExecuteReader.md).

```csharp
public Task<OptionalValue<IDataReader>> ExecuteReaderAsync(string commandText, 
    IDictionary<string, object> parameters, SqlQuery query, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| parameters | The parameters. |
| query | The query. |
| cancellationToken | Cancellation token |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* class [SqlQuery](../SqlQuery.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)