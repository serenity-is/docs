# MigrationUtils.CreateTableWithId32 method

Please prefer IdentityKey(this) on the fluent column builder

```csharp
public static void CreateTableWithId32(this MigrationBase migration, string table, string idField, 
    Action<ICreateTableColumnOptionOrWithColumnSyntax> addColumns, string schema = null, 
    bool checkExists = false, bool primaryKey = true)
```

## See Also

* class [MigrationUtils](../MigrationUtils.md)