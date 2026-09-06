# EntityConnectionExtensions.ToSqlUpdateById method

Converts the entity to an SqlUpdate object by ID setting only the assigned fields.

```csharp
public static SqlUpdate ToSqlUpdateById(this IIdRow row)
```

| parameter | description |
| --- | --- |
| row | The row with field values to set in new record (must be in TrackAssignments mode). |

## Return Value

SqlUpdate object.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row is null. |

## See Also

* class [SqlUpdate](../SqlUpdate.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)