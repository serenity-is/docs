# FindRowArgs constructor

Arguments for intercepting entity find operations.

```csharp
public FindRowArgs(Type RowType, OptionalValue<object?> Id, SqlQuery Query, bool ByIdOrSingle)
```

| parameter | description |
| --- | --- |
| RowType | The type of the row. |
| Id | The identifier, if the operation is by ID. |
| Query | The fully configured query. |
| ByIdOrSingle | True when a single row is expected. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* class [SqlQuery](../SqlQuery.md)
* record [FindRowArgs](../FindRowArgs.md)