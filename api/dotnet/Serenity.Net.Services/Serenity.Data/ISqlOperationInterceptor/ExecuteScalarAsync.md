# ISqlOperationInterceptor.ExecuteScalarAsync method

Intercepts the async [`SqlHelper`](../SqlHelper.md)`ExecuteScalar` methods. The default implementation forwards to [`ExecuteScalar`](./ExecuteScalar.md).

```csharp
public Task<OptionalValue<object>> ExecuteScalarAsync(InterceptExecuteScalarArgs args)
```

| parameter | description |
| --- | --- |
| args | The operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptExecuteScalarArgs](../InterceptExecuteScalarArgs.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)