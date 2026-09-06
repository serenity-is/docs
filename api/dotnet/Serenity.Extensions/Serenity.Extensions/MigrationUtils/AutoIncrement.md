# MigrationUtils.AutoIncrement method

Declares column as auto increment (e.g. Identity()) if the database is something other than Oracle, defines an Oracle sequence otherwise. It also calls NotNullable() as it is not possible for auto increment / sequence columns to be nullable. This assumes the column will NOT be set as PrimaryKey(), just as an auto incrementing value. As MySql does not support AUTO_INCREMENT without primary key or an index, this first creates the column as a regular one, then creates an index and modifies it to be an AUTO_INCREMENT.

```csharp
public static ICreateTableColumnOptionOrWithColumnSyntax AutoIncrement(
    this ICreateTableColumnOptionOrWithColumnSyntax syntax, MigrationBase migration)
```

| parameter | description |
| --- | --- |
| syntax | The WithColumn syntax builder |
| migration | The migration reference to determine the database type |

## See Also

* class [MigrationUtils](../MigrationUtils.md)