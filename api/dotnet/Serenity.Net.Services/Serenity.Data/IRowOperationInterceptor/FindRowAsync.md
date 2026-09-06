# IRowOperationInterceptor.FindRowAsync method

Intercepts the async EntityConnectionExtensions ById/TryById/First/TryFirst/Single/TrySingle methods. The default implementation forwards to [`FindRow`](./FindRow.md).

```csharp
public Task<OptionalValue<IRow>> FindRowAsync(Type rowType, OptionalValue<object> id, 
    ICriteria where, Action<SqlQuery> editQuery, bool byIdOrSingle, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| rowType | Type of the row. |
| id | The identifier if one of the ById methods is used. |
| where | The where criteria for the First/TryFirst/Single/TrySingle methods. |
| editQuery | Callback to edit the query. |
| byIdOrSingle | True if one of the ById/TryById/Single/TrySingle methods is used. |
| cancellationToken | Cancellation token |

## Return Value

Entity with the given ID, or null if not found.

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [IRow](../IRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)