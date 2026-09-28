# ISqlOperationInterceptor.ExecuteNonQuery method

Intercepts the [`SqlHelper`](../SqlHelper.md)`Execute` method (SqlDelete/SqlUpdate/SqlInsert).

```csharp
public OptionalValue<long?> ExecuteNonQuery(InterceptExecuteNonQueryArgs args)
```

| parameter | description |
| --- | --- |
| args | The operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptExecuteNonQueryArgs](../InterceptExecuteNonQueryArgs.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)