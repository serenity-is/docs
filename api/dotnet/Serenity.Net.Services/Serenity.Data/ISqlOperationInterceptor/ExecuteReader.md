# ISqlOperationInterceptor.ExecuteReader method

Intercepts the [`SqlHelper`](../SqlHelper.md)`ExecuteReader` method.

```csharp
public OptionalValue<IDataReader> ExecuteReader(InterceptExecuteReaderArgs args)
```

| parameter | description |
| --- | --- |
| args | The operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptExecuteReaderArgs](../InterceptExecuteReaderArgs.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)