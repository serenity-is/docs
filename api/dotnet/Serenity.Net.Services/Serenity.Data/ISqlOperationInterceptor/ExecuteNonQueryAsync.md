# ISqlOperationInterceptor.ExecuteNonQueryAsync method

Intercepts the async [`SqlHelper`](../SqlHelper.md)`Execute` methods (SqlDelete/SqlUpdate/SqlInsert). The default implementation forwards to [`ExecuteNonQuery`](./ExecuteNonQuery.md).

```csharp
public Task<OptionalValue<long?>> ExecuteNonQueryAsync(string commandText, 
    IDictionary<string, object> parameters, ExpectedRows expectedRows, IQueryWithParams query, 
    bool getNewId, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| parameters | The parameters. |
| expectedRows | The expected rows. |
| query | The query. |
| getNewId | True if `InsertAndGetIDAsync` is called. |
| cancellationToken | Cancellation token |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* enum [ExpectedRows](../ExpectedRows.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)