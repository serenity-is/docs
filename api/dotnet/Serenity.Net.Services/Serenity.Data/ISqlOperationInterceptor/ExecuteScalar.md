# ISqlOperationInterceptor.ExecuteScalar method

Intercepts the [`SqlHelper`](../SqlHelper.md)`ExecuteScalar` method.

```csharp
public OptionalValue<object> ExecuteScalar(InterceptExecuteScalarArgs args)
```

| parameter | description |
| --- | --- |
| args | The operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptExecuteScalarArgs](../InterceptExecuteScalarArgs.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)