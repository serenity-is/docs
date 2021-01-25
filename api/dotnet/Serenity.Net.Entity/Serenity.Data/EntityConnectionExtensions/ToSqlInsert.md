# EntityConnectionExtensions.ToSqlInsert method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Converts the entity to an SqlInsert object by setting only the assigned fields.

```csharp
public static SqlInsert ToSqlInsert(this IRow row)
```

| parameter | description |
| --- | --- |
| row | The row with field values to set in new record (must be in TrackAssignments mode). |

## Return Value

SqlInsert object

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row is null |

## See Also

* class [SqlInsert](../Serenity.Net.Data/../SqlInsert.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)