# BaseUniqueConstraintSaveBehavior.BuildUniqueConstraintQuery method

Builds the query used to check the unique constraint. Override this method to customize the pre-check, for example to add row-level scoping (tenant/owner filters) so that the check matches the actual database unique constraint, or to skip the pre-check entirely.

```csharp
protected virtual SqlQuery BuildUniqueConstraintQuery(ISaveRequestHandler handler, 
    IEnumerable<Field> fields, BaseCriteria? groupCriteria)
```

| parameter | description |
| --- | --- |
| handler | Save request handler. |
| fields | Fields that make up the unique constraint. |
| groupCriteria | Optional additional criteria to scope the check. |

## Return Value

The query to run.

## Remarks

Equality is evaluated by the database, which is the single source of truth for comparison semantics, so case sensitivity follows the actual column collation and the pre-check matches the real unique index. The configured field, dialect or [`DefaultComparer`](../../Serenity.Data/SqlSettings/DefaultComparer.md) comparer only approximates that for in-memory change detection and does not affect this query.

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* class [Field](../../Serenity.Data/Field.md)
* class [BaseCriteria](../../Serenity.Data/BaseCriteria.md)
* class [BaseUniqueConstraintSaveBehavior](../BaseUniqueConstraintSaveBehavior.md)