# EntityConnectionExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Contains extension methods to perform entity CRUD operations directly on connections. Please note that all these methods operate on a low level, and none of them call service behaviors or performs service validations.

```csharp
public static class EntityConnectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ById&lt;TRow&gt;](EntityConnectionExtensions/ById.md)(…) | Finds an entity by its ID value. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields. (2 methods) |
| static [Count&lt;TRow&gt;](EntityConnectionExtensions/Count.md)(…) | Gets count of all records. (2 methods) |
| static [DeleteById&lt;TRow&gt;](EntityConnectionExtensions/DeleteById.md)(…) | Deletes the entity by its identifier. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers. |
| static [Exists&lt;TRow&gt;](EntityConnectionExtensions/Exists.md)(…) | Checks if record matching specified criteria exists. |
| static [ExistsById&lt;TRow&gt;](EntityConnectionExtensions/ExistsById.md)(…) | Checks if the record with specified ID exists. |
| static [First&lt;TRow&gt;](EntityConnectionExtensions/First.md)(…) | Finds first entity matching a where criteria. (2 methods) |
| static [Insert&lt;TRow&gt;](EntityConnectionExtensions/Insert.md)(…) | Inserts the specified entity. Note that this operates at a low level, it does not perform any validation or permission check, and does not call service behaviors / handlers. |
| static [InsertAndGetID&lt;TRow&gt;](EntityConnectionExtensions/InsertAndGetID.md)(…) | Inserts the specified entity and returns the ID of record inserted. Only works for identity columns of integer type. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers. |
| static [List&lt;TRow&gt;](EntityConnectionExtensions/List.md)(…) | Lists all records. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields. (3 methods) |
| static [Single&lt;TRow&gt;](EntityConnectionExtensions/Single.md)(…) | Finds a single entity matching the specified criteria. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields. (2 methods) |
| static [ToSqlInsert](EntityConnectionExtensions/ToSqlInsert.md)(…) | Converts the entity to an SqlInsert object by setting only the assigned fields. |
| static [ToSqlUpdateById](EntityConnectionExtensions/ToSqlUpdateById.md)(…) | Converts the entity to an SqlUpdate object by ID setting only the assigned fields. |
| static [TryById&lt;TRow&gt;](EntityConnectionExtensions/TryById.md)(…) | Tries to finds an entity by its ID value. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields. (2 methods) |
| static [TryFirst&lt;TRow&gt;](EntityConnectionExtensions/TryFirst.md)(…) | Tries to find first entity matching a where criteria. (2 methods) |
| static [TrySingle&lt;TRow&gt;](EntityConnectionExtensions/TrySingle.md)(…) | Tries to find a single entity matching the specified criteria. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields. (2 methods) |
| static [UpdateById&lt;TRow&gt;](EntityConnectionExtensions/UpdateById.md)(…) | Updates the entity by its identifier. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers. |

## See Also

* **Source:** *[EntityConnectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Extensions/EntityConnectionExtensions.cs)*