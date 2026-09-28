# EntitySqlQueryExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extensions for [`SqlQuery`](./SqlQuery.md) related to entities.

```csharp
public static class EntitySqlQueryExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [From](EntitySqlQueryExtensions/From.md)(…) | Adds row fields as a FROM source and applies their dialect when the query dialect is not overridden. (2 methods) |
| static [From&lt;TFields&gt;](EntitySqlQueryExtensions/From.md)(…) | Adds fields as a FROM source, adjusting the default T0 alias when it is already used. This overload does not set an INTO target. (5 methods) |
| static [GroupBy](EntitySqlQueryExtensions/GroupBy.md)(…) | Adds a field's expression to the group by list. (2 methods) |
| static [Into](EntitySqlQueryExtensions/Into.md)(…) | Adds the specified entity to the INTO list of the query, and sets it as the current INTO row. |
| static [IntoForeignRow&lt;TFields&gt;](EntitySqlQueryExtensions/IntoForeignRow.md)(…) | Selects fields from an already joined foreign row into a row-valued property. |
| static [OrderBy](EntitySqlQueryExtensions/OrderBy.md)(…) | Adds a field's expression to the order by list. (2 methods) |
| static [Select](EntitySqlQueryExtensions/Select.md)(…) | Adds a field's expression to the SELECT statement with its own column name. If a join alias is referenced in the field expression, and the join is defined in the field's entity class, it is automatically included in the query. The field is marked as a target at the current index for future loading from a data reader. (5 methods) |
| static [SelectAs](EntitySqlQueryExtensions/SelectAs.md)(…) | Adds a field or an expression to the SELECT statement with a column name of a field's name. The field is marked as a target at the current index for future loading from a data reader. |
| static [SubQueryFrom&lt;TFields&gt;](EntitySqlQueryExtensions/SubQueryFrom.md)(…) | Creates a subquery and adds the specified fields as its FROM source without setting an INTO target. If the fields use the default T0 alias, an available alias is allocated from the query tree. |
| static [WithSelf&lt;TQuery&gt;](EntitySqlQueryExtensions/WithSelf.md)(…) | Returns the query and assigns the same instance to a reference for use within a fluent chain. |

## See Also

* **Source:** *[EntitySqlQueryExtensions.cs](https://github.com/serenity-is/Serenity/blob/a33f821b7a5431477e50f129ce63ce324c984018/src/services/Entity/Extensions/EntitySqlQueryExtensions.cs)*