# EntitySqlQueryExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Extensions for SqlQuery.

```csharp
public static class EntitySqlQueryExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [From](EntitySqlQueryExtensions/From.md)(…) | Adds a table to the FROM statement with "T0" alias and sets it as target for future field selections. |
| static [GroupBy](EntitySqlQueryExtensions/GroupBy.md)(…) | Adds fields expressions to group by list (2 methods) |
| static [Into](EntitySqlQueryExtensions/Into.md)(…) | Add the specified entity to INTO list of the query, and sets it as current INTO row. |
| static [OrderBy](EntitySqlQueryExtensions/OrderBy.md)(…) | Adds fields expression to order by list (2 methods) |
| static [Select](EntitySqlQueryExtensions/Select.md)(…) | Adds a field's expression to the SELECT statement with its own column name. If a join alias is referenced in the field expression, and the join is defined in field's entity class, it is automatically included in the query. The field is marked as a target at current index for future loading from a data reader. (5 methods) |
| static [SelectAs](EntitySqlQueryExtensions/SelectAs.md)(…) | Adds a field or an expression to the SELECT statement with a column name of a field's name. The field is marked as a target at current index for future loading from a data reader. |

## See Also

* **Source:** *[EntitySqlQueryExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Extensions/EntitySqlQueryExtensions.cs)*