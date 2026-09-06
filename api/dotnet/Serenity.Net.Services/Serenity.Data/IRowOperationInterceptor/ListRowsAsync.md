# IRowOperationInterceptor.ListRowsAsync method

Intercepts the async EntityConnectionExtensions List and Count methods. The default implementation forwards to [`ListRows`](./ListRows.md).

```csharp
public Task<OptionalValue<IList>> ListRowsAsync(Type rowType, ICriteria where, 
    Action<SqlQuery> editQuery, bool countOnly, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| rowType | Type of the row. |
| where | The where criteria. |
| editQuery | The edit query callback. |
| countOnly | True if intercepting the Count method. |
| cancellationToken | Cancellation token |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)