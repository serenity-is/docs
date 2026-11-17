# MigrationUtils.GetDialect method

Gets the SQL dialect for the database the migration is running against. It can be used to quote identifiers and strings in the statements passed to `Execute.Sql`.

```csharp
public static ISqlDialect GetDialect(this MigrationBase migration)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |

## Return Value

The SQL dialect.

## Exceptions

| exception | condition |
| --- | --- |
| NotSupportedException | There is no dialect for the database type. |

## See Also

* interface [ISqlDialect](../../../Serenity.Net.Services/Serenity.Data/ISqlDialect.md)
* class [MigrationUtils](../MigrationUtils.md)