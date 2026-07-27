# IRowOperationInterceptor.FindRow method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Intercepts EntityConnectionExtensions's ById/TryById/First/TryFirst/Single/TrySingle methods.

```csharp
public OptionalValue<IRow> FindRow(Type rowType, OptionalValue<object> id, ICriteria where, 
    Action<SqlQuery> editQuery, bool byIdOrSingle)
```

| parameter | description |
| --- | --- |
| rowType | Type of the row |
| id | The identifier if one of ById methods are used. |
| where | The where criteria for First/TryFirst/Single/TrySingle methods. |
| editQuery | Callback to edit the query. |
| byIdOrSingle | True if one of ById/TryById/Single/TrySingle methods is used |

## Return Value

Entity with given ID, or null if not found

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [IRow](../IRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)