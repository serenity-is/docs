# MigrationUtils.IdentityKey method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Declares column as Identity() if the database is something other than Oracle, defines an Oracle sequence otherwise. It sets the column as PrimaryKey() and also calls NotNullable() as it is not possible for identity / sequence columns to be nullable.

```csharp
public static ICreateTableColumnOptionOrWithColumnSyntax IdentityKey(
    this ICreateTableColumnOptionOrWithColumnSyntax syntax, MigrationBase migration)
```

| parameter | description |
| --- | --- |
| syntax | The WithColumn syntax builder |
| migration | The migration reference to determine the database type |

## See Also

* class [MigrationUtils](../MigrationUtils.md)