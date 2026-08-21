# ISqlOperationInterceptor.ExecuteScalar method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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