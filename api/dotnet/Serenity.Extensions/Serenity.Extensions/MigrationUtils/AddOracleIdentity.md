# MigrationUtils.AddOracleIdentity method

Adds an Oracle sequence and trigger to generate identity values for the specified column.

```csharp
public static void AddOracleIdentity(this MigrationBase migration, string table, string id)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |
| table | The table name. |
| id | The identity column name. |

## See Also

* class [MigrationUtils](../MigrationUtils.md)