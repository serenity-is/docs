# Schema Provider (Sergen)

The schema provider is the abstraction Sergen uses to read database metadata —
tables, columns, primary keys, identity columns, and foreign keys — so it can
generate rows, forms, grids, pages, and services from an existing database. It
is an internal piece of the code generator, but understanding it helps when you
want to know how Sergen discovers tables and columns, or when you need to
support a database that Serenity does not ship a provider for.

## When Sergen reads the schema

When you run `dotnet sergen generate`, the first thing Sergen does is open the
selected connection and ask the schema provider for the list of tables:

```csharp
using (var connection = sqlConnections.NewByKey(connectionKey))
{
    schemaProvider = SchemaHelper.GetSchemaProvider(connection.GetDialect().ServerType);
    allTableEntries = schemaProvider.GetTableNames(connection).ToList();
}
```

The "Available Tables" list you see in the interactive wizard comes from
`GetTableNames`. Once you pick a table, the same provider supplies the column
metadata used to build the row, form, grid, page, and service code.

## `ISchemaProvider`

[`ISchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/ISchemaProvider.md)
is the interface every provider implements. It has six members:

| Member | Returns | Purpose |
| --- | --- | --- |
| `DefaultSchema` | `string` | The default schema for the server (e.g. `dbo` for SQL Server) |
| `GetTableNames(connection)` | `IEnumerable<TableName>` | All tables and views in the database |
| `GetFieldInfos(connection, schema, table)` | `IEnumerable<FieldInfo>` | Column metadata for a table |
| `GetPrimaryKeyFields(connection, schema, table)` | `IEnumerable<string>` | Primary key column names |
| `GetIdentityFields(connection, schema, table)` | `IEnumerable<string>` | Identity / auto-increment column names |
| `GetForeignKeys(connection, schema, table)` | `IEnumerable<ForeignKeyInfo>` | Foreign keys referencing other tables |

## Metadata types

The provider returns three small metadata types.

### `TableName`

[`TableName`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/TableName.md)
describes a table or view:

- `Schema` — schema name
- `Table` — table name
- `IsView` — whether it is a view
- `Tablename` — convenience `Schema.Table` (or just `Table` when there is no schema)

### `FieldInfo`

[`FieldInfo`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/FieldInfo.md)
describes a single column:

- `FieldName`, `DataType`, `Size`, `Scale`
- `IsPrimaryKey`, `IsIdentity`, `IsNullable`
- `PKSchema`, `PKTable`, `PKColumn` — when the column is a foreign key, the referenced table and column

### `ForeignKeyInfo`

[`ForeignKeyInfo`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/ForeignKeyInfo.md)
describes a foreign key:

- `FKName`, `FKColumn` — the constraint and column on the current table
- `PKSchema`, `PKTable`, `PKColumn` — the referenced table and column

## Built-in providers

Serenity ships a provider for each supported server, in the
`Serenity.Data.Schema` namespace:

| Provider | Server | Default schema |
| --- | --- | --- |
| [`SqlServerSchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/SqlServerSchemaProvider.md) | SQL Server | `dbo` |
| [`MySqlSchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/MySqlSchemaProvider.md) | MySQL | — |
| [`PostgresSchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/PostgresSchemaProvider.md) | PostgreSQL | `public` |
| [`SqliteSchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/SqliteSchemaProvider.md) | SQLite | — |
| [`OracleSchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/OracleSchemaProvider.md) | Oracle | — |
| [`FirebirdSchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/FirebirdSchemaProvider.md) | Firebird | — |

Each provider runs database-specific metadata queries. For example,
`SqlServerSchemaProvider.GetFieldInfos` reads `INFORMATION_SCHEMA.COLUMNS` and
normalizes the SQL type (e.g. `timestamp` → `rowversion`) and nullability:

```sql
SELECT
    COLUMN_NAME [FieldName],
    CASE WHEN DATA_TYPE = 'timestamp' THEN 'rowversion' ELSE DATA_TYPE END [DataType],
    CASE WHEN IS_NULLABLE = 'NO' THEN 0 ELSE 1 END [IsNullable],
    COALESCE(CHARACTER_MAXIMUM_LENGTH,
        CASE WHEN DATA_TYPE in ('decimal', 'money', 'numeric')
            THEN NUMERIC_PRECISION ELSE 0 END) [Size],
    NUMERIC_SCALE [Scale]
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = @sma AND TABLE_NAME = @tbl
ORDER BY ORDINAL_POSITION
```

## How Sergen picks a provider

Sergen does not ask you which provider to use. It derives it from the
connection's dialect: `SchemaHelper.GetSchemaProvider` receives the dialect's
`ServerType` and looks up a type named
`Serenity.Data.Schema.<ServerType>SchemaProvider`:

```csharp
public static ISchemaProvider GetSchemaProvider(string serverType)
{
    var providerType = Type.GetType("Serenity.Data.Schema." + serverType + "SchemaProvider, Serenity.Net.Services") ??
        Type.GetType("Serenity.Data.Schema." + serverType + "SchemaProvider, SerenityData");
    if (providerType == null || !typeof(ISchemaProvider).GetTypeInfo().IsAssignableFrom(providerType))
        throw new ArgumentOutOfRangeException(nameof(serverType), serverType, "Unknown server type");

    return (ISchemaProvider)Activator.CreateInstance(providerType);
}
```

So the provider is chosen by the connection's dialect `ServerType` (see
[SQL Dialects](../framework/data-access/sql-dialects.md)). If you set the
dialect for a connection in `appsettings.json`, Sergen uses the matching
provider.

## From metadata to generated code

The provider is wrapped by `EntityDataSchema` (behind the `IEntityDataSchema`
interface) and consumed by `EntityModelFactory` when it builds the row model:

- `GetFieldInfos` produces the row's fields, with `[Size]`, `[Scale]`,
  `[NotNull]`, etc. derived from the column metadata.
- `GetPrimaryKeyFields` / `GetIdentityFields` determine the `[PrimaryKey]`,
  `[Identity]` / `[AutoIncrement]` attributes and the row's `IdField`.
- `GetForeignKeys` finds columns that reference other tables. For each
  single-column foreign key, Sergen pulls the referenced table's fields in as
  view fields (with `[ForeignKey]`, `[LeftJoin]`, etc.), which is why generated
  rows include fields from related tables.

Two `sergen.json` options control how this foreign-key expansion behaves:

- `RemoveForeignFields` — a list of field names to drop from foreign joins
  (e.g. logging fields like `InsertUserId`, `UpdateDate`).
- `BaseRowClasses` — if a table has all the fields listed for a base row class
  (e.g. `LoggingRow`), Sergen derives the row from that class and does not
  regenerate those fields.

## Custom providers

`ISchemaProvider` is a public interface, so you can implement your own provider
if you need to generate code from a database Serenity does not ship a provider
for. Because `SchemaHelper.GetSchemaProvider` resolves providers by the
`<ServerType>SchemaProvider` naming convention, a custom provider must be named
`Serenity.Data.Schema.<ServerType>SchemaProvider` and be discoverable by that
reflection lookup.

## See Also

- [Code Generator (Sergen)](code_generator_sergen.md)
- [Sergen Commands](sergen_commands.md)
- [SQL Dialects](../framework/data-access/sql-dialects.md)
- [SQL Connections](../framework/data-access/sql-connections.md)
- API reference: [`ISchemaProvider`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/ISchemaProvider.md),
  [`FieldInfo`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/FieldInfo.md),
  [`ForeignKeyInfo`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/ForeignKeyInfo.md),
  [`TableName`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Schema/TableName.md)