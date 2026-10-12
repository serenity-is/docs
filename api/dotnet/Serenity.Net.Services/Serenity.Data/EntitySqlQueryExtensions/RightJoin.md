# EntitySqlQueryExtensions.RightJoin&lt;TFields&gt; method

Adds a RIGHT JOIN using fields aliased for this query and builds its ON criteria from those fields.

```csharp
public static SqlQuery RightJoin<TFields>(this SqlQuery query, TFields fields, 
    Func<TFields, ICriteria> onCriteria, out TFields aliased)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query. |
| fields | The fields whose table is joined. |
| onCriteria | Creates the ON criteria from the fields with their query alias. |
| aliased | Receives the fields instance with the alias used by the join. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)