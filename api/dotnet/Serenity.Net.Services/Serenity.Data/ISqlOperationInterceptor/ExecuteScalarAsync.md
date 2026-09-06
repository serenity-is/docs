# ISqlOperationInterceptor.ExecuteScalarAsync method

Intercepts the async [`SqlHelper`](../SqlHelper.md)`ExecuteScalar` methods. The default implementation forwards to [`ExecuteScalar`](./ExecuteScalar.md).

```csharp
public Task<OptionalValue<object>> ExecuteScalarAsync(string commandText, 
    IDictionary<string, object> parameters, SqlQuery query, 
    CancellationToken cancellationToken = default)
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