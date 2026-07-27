# ISqlOperationInterceptor.ExecuteNonQuery method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Intercepts SqlHelper.Execute(SqlDelete/SqlUpdate/SqlInsert) method. Command textParametersThe query.Expected rowsTrue if InsertAndGetID is called

```csharp
public OptionalValue<long?> ExecuteNonQuery(string commandText, 
    IDictionary<string, object> parameters, ExpectedRows expectedRows, IQueryWithParams query, 
    bool getNewId)
```

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* enum [ExpectedRows](../ExpectedRows.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)