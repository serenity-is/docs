# MigrationUtils.GetConcurrencyVersionTriggerSql method

Generates the SQL statements that create the concurrency version trigger for the given database type.

```csharp
public static string GetConcurrencyVersionTriggerSql(string serverType, string table, 
    string column, bool isLong, string idField, string? schema = null)
```

| parameter | description |
| --- | --- |
| serverType | Database server type, e.g. "SqlServer", "Postgres", "MySql", "Oracle", "Firebird" or "Sqlite". |
| table | Table name. |
| column | Concurrency version column name. |
| isLong | True for a 64-bit (long) column, false for a 32-bit (int) column. |
| idField | Id (primary key) column name, required for SQL Server. |
| schema | Optional schema name. |

## Return Value

The trigger creation SQL.

## See Also

* class [MigrationUtils](../MigrationUtils.md)