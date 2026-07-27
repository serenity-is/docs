# ISqlOperationInterceptor.ExecuteReader method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Intercepts SqlHelper.ExecuteReader method.

```csharp
public OptionalValue<IDataReader> ExecuteReader(string commandText, 
    IDictionary<string, object> parameters, SqlQuery query)
```

| parameter | description |
| --- | --- |
| commandText | Command text |
| parameters | The parameters. |
| query | The query |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* class [SqlQuery](../SqlQuery.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)