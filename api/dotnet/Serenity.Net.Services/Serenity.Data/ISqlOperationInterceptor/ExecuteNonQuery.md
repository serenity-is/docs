# ISqlOperationInterceptor.ExecuteNonQuery method

Intercepts the [`SqlHelper`](../SqlHelper.md)`Execute` method (SqlDelete/SqlUpdate/SqlInsert).

```csharp
public OptionalValue<long?> ExecuteNonQuery(string commandText, 
    IDictionary<string, object> parameters, ExpectedRows expectedRows, IQueryWithParams query, 
    bool getNewId)
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| parameters | The parameters. |
| expectedRows | The expected rows. |
| query | The query. |
| getNewId | True if `InsertAndGetID` is called. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* enum [ExpectedRows](../ExpectedRows.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* interface [ISqlOperationInterceptor](../ISqlOperationInterceptor.md)