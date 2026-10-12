# MigrationUtils.DropConcurrencyVersionTrigger method

Drops the concurrency version trigger created by [`AddConcurrencyVersionTrigger`](./AddConcurrencyVersionTrigger.md).

```csharp
public static void DropConcurrencyVersionTrigger(this MigrationBase migration, string table, 
    string column, string? schema = null)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |
| table | Table name. |
| column | Concurrency version column name. |
| schema | Optional schema name. |

## See Also

* class [MigrationUtils](../MigrationUtils.md)