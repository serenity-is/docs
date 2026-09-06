# ISqlOperationInterceptor.ExecuteScalar method

Intercepts the [`SqlHelper`](../SqlHelper.md)`ExecuteScalar` method.

```csharp
public OptionalValue<object> ExecuteScalar(string commandText, 
    IDictionary<string, object> parameters, SqlQuery query)
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| parameters | The parameters. |
| query | The query. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* class [SqlQuery](../SqlQuery.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)