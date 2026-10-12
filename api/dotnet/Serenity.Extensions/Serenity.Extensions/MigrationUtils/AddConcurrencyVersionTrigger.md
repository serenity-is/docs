# MigrationUtils.AddConcurrencyVersionTrigger method (1 of 2)

Adds a database trigger that increments this column on every update, providing optimistic concurrency support for rows implementing `Serenity.Data.IConcurrencyVersionRow`.

```csharp
public static IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax AddConcurrencyVersionTrigger(
    this IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax syntax, MigrationBase migration, 
    string idField, string? schema = null)
```

| parameter | description |
| --- | --- |
| syntax | Column option syntax (after AsInt32/AsInt64). |
| migration | The migration reference. |
| idField | Name of the id (primary key) column, required for the trigger. |
| schema | Optional schema name. Defaults to the table's schema. |

## Remarks

See the [`AddConcurrencyVersionTrigger`](./AddConcurrencyVersionTrigger.md) overload for details. This overload is for `Alter.Table(...).AddColumn(...)`.

## See Also

* class [MigrationUtils](../MigrationUtils.md)

---

# MigrationUtils.AddConcurrencyVersionTrigger method (2 of 2)

Adds a database trigger that increments this column on every update, providing optimistic concurrency support for rows implementing `Serenity.Data.IConcurrencyVersionRow`.

```csharp
public static ICreateTableColumnOptionOrWithColumnSyntax AddConcurrencyVersionTrigger(
    this ICreateTableColumnOptionOrWithColumnSyntax syntax, MigrationBase migration, 
    string idField, string? schema = null)
```

| parameter | description |
| --- | --- |
| syntax | Column option syntax (after AsInt32/AsInt64). |
| migration | The migration reference. |
| idField | Name of the id (primary key) column, required for the trigger. |
| schema | Optional schema name. Defaults to the table's schema. |

## Remarks

Call on the column builder after `AsInt32()` / `AsInt64()`, e.g. `.WithColumn("RowVersion").AsInt32().AddConcurrencyVersionTrigger(this, idField: "ID")`. The column name, table name and column type (int32/int64) are read from the builder, so only the id (primary key) column is passed explicitly.

If you only target SQL Server, prefer a native `rowversion` column (mapped as a byte[] field) which the server maintains automatically, instead of this trigger based numeric column. This trigger approach is recommended when you need to support multiple database types with the same numeric version column.

## See Also

* class [MigrationUtils](../MigrationUtils.md)