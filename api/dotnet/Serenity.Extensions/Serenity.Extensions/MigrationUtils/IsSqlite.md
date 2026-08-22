# MigrationUtils.IsSqlite method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Determines whether the migration is running against a Sqlite database.

```csharp
public static bool IsSqlite(this MigrationBase migration)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |

## Return Value

`true` if the database is Sqlite; otherwise, `false`.

## See Also

* class [MigrationUtils](../MigrationUtils.md)