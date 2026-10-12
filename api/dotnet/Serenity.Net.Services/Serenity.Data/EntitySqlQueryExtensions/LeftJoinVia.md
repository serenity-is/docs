# EntitySqlQueryExtensions.LeftJoinVia&lt;TFields&gt; method

Adds a LEFT JOIN to the row referenced by the foreign key field.

```csharp
public static SqlQuery LeftJoinVia<TFields>(this SqlQuery query, TFields fields, 
    Field foreignKeyField, out TFields aliased)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The referenced row fields type. |
| query | The query. |
| fields | The referenced row fields, used to infer and validate the target type. |
| foreignKeyField | The foreign key field. |
| aliased | Receives the referenced fields with the alias used by this query. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)