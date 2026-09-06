# EntitySqlQueryExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extensions for [`SqlQuery`](./SqlQuery.md).

```csharp
public static class EntitySqlQueryExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [From](EntitySqlQueryExtensions/From.md)(…) | Adds a table to the FROM statement with "T0" alias and sets it as the target for future field selections. |
| static [GroupBy](EntitySqlQueryExtensions/GroupBy.md)(…) | Adds a field's expression to the group by list. (2 methods) |
| static [Into](EntitySqlQueryExtensions/Into.md)(…) | Adds the specified entity to the INTO list of the query, and sets it as the current INTO row. |
| static [OrderBy](EntitySqlQueryExtensions/OrderBy.md)(…) | Adds a field's expression to the order by list. (2 methods) |
| static [Select](EntitySqlQueryExtensions/Select.md)(…) | Adds a field's expression to the SELECT statement with its own column name. If a join alias is referenced in the field expression, and the join is defined in the field's entity class, it is automatically included in the query. The field is marked as a target at the current index for future loading from a data reader. (5 methods) |
| static [SelectAs](EntitySqlQueryExtensions/SelectAs.md)(…) | Adds a field or an expression to the SELECT statement with a column name of a field's name. The field is marked as a target at the current index for future loading from a data reader. |

## See Also

* **Source:** *[EntitySqlQueryExtensions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Entity/Extensions/EntitySqlQueryExtensions.cs)*