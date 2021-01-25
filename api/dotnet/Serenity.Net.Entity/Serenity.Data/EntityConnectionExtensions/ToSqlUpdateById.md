# EntityConnectionExtensions.ToSqlUpdateById method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Converts the entity to an SqlUpdate object by ID setting only the assigned fields.

```csharp
public static SqlUpdate ToSqlUpdateById(this IIdRow row)
```

| parameter | description |
| --- | --- |
| row | The row with field values to set in new record (must be in TrackAssignments mode). |

## Return Value

SqlUpdate object

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row is null |

## See Also

* class [SqlUpdate](../Serenity.Net.Data/../SqlUpdate.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)