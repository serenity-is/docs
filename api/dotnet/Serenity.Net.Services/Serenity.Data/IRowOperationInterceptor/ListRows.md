# IRowOperationInterceptor.ListRows method

Intercepts EntityConnectionExtensions.List and Count methods.

```csharp
public OptionalValue<IList> ListRows(Type rowType, ICriteria where, Action<SqlQuery> editQuery, 
    bool countOnly)
```

| parameter | description |
| --- | --- |
| rowType | Type of the row. |
| where | The where criteria. |
| editQuery | The edit query callback. |
| countOnly | True if intercepting the Count method. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)