# MigrationUtils.IsPostgres method

Determines whether the migration is running against a Postgres database.

```csharp
public static bool IsPostgres(this MigrationBase migration)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |

## Return Value

`true` if the database is Postgres; otherwise, `false`.

## See Also

* class [MigrationUtils](../MigrationUtils.md)