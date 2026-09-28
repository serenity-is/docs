# ISqlOperationInterceptor.ExecuteReaderAsync method

Intercepts the async [`SqlHelper`](../SqlHelper.md)`ExecuteReader` methods. The default implementation forwards to [`ExecuteReader`](./ExecuteReader.md).

```csharp
public Task<OptionalValue<IDataReader>> ExecuteReaderAsync(InterceptExecuteReaderArgs args)
```

| parameter | description |
| --- | --- |
| args | The operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptExecuteReaderArgs](../InterceptExecuteReaderArgs.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)