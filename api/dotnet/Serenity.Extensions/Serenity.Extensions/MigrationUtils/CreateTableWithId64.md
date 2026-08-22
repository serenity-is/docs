# MigrationUtils.CreateTableWithId64 method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Please prefer IdentityKey(this) on the fluent column builder

```csharp
public static void CreateTableWithId64(this MigrationBase migration, string table, string idField, 
    Action<ICreateTableColumnOptionOrWithColumnSyntax> addColumns, string schema = null, 
    bool checkExists = false, bool primaryKey = true)
```

## See Also

* class [MigrationUtils](../MigrationUtils.md)