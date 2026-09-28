# ISqlOperationInterceptor.ExecuteNonQueryAsync method

Intercepts the async [`SqlHelper`](../SqlHelper.md)`Execute` methods (SqlDelete/SqlUpdate/SqlInsert). The default implementation forwards to [`ExecuteNonQuery`](./ExecuteNonQuery.md).

```csharp
public Task<OptionalValue<long?>> ExecuteNonQueryAsync(InterceptExecuteNonQueryArgs args)
```

| parameter | description |
| --- | --- |
| args | The operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptExecuteNonQueryArgs](../InterceptExecuteNonQueryArgs.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)