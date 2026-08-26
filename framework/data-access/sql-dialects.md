# SQL Dialects

Serenity is database-agnostic. The dialect abstraction
([`ISqlDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ISqlDialect.md))
describes the SQL syntax and behavior of a particular database server type (and
version), so that `SqlQuery`, the criteria system, and the SQL builders can
generate queries that are correct for the target database.

## `ISqlDialect`

[`ISqlDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ISqlDialect.md)
is a large interface, but you rarely need to implement it yourself. Each built-in
dialect exposes a shared `Instance`, which is what you pass around. The members
control how Serenity generates SQL:

| Group | Members |
| --- | --- |
| Identifier quoting | `OpenQuote`, `CloseQuote`, `QuoteIdentifier`, `QuoteColumnAlias`, `QuoteUnicodeString` |
| Paging | `CanUseSkipKeyword`, `CanUseOffsetFetch`, `CanUseRowNumber`, `UseRowNum`, `SkipKeyword`, `TakeKeyword`, `UseTakeAtEnd`, `OffsetFormat`, `OffsetFetchFormat` |
| Identity / insert | `UseScopeIdentity`, `UseReturningIdentity`, `UseReturningIntoVar`, `ScopeIdentityExpression` |
| String concat | `CanUseConcat`, `ConcatOperator` |
| Date / time formats | `DateFormat`, `DateTimeFormat`, `TimeFormat` |
| Other behavior | `IsLikeCaseSensitive`, `NeedsBoolWorkaround`, `NeedsExecuteBlockStatement`, `MultipleResultsets`, `UseDateTime2`, `UnionKeyword`, `ServerType`, `AutoQuotedIdentifiers`, `IsReservedKeyword` |

Several members have sensible default values (via default interface members). For
example `CanUseConcat` defaults to `true` and `AutoQuotedIdentifiers` defaults to
`null`, which means [`SqlSettings.AutoQuotedIdentifiers`](#sqlsettings) is used.

## `ServerType`

[`ServerType`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ServerType.md)
is an enum of the server families Serenity knows about:

`Firebird`, `MySql`, `Oracle`, `Postgres`, `Sqlite`, `SqlServer`

Dialects return one of these from their `ServerType` property.

## Built-in Dialects

Serenity ships a dialect for each supported server, exposed as a static
`Instance`:

| Dialect | Server |
| --- | --- |
| [`FirebirdDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/FirebirdDialect.md) | Firebird |
| [`MySqlDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/MySqlDialect.md) | MySQL |
| [`PostgresDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/PostgresDialect.md) | PostgreSQL |
| [`SqliteDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqliteDialect.md) | SQLite |
| [`SqlServer2000Dialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlServer2000Dialect.md) | SQL Server 2000 |
| [`SqlServer2005Dialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlServer2005Dialect.md) | SQL Server 2005 |
| [`SqlServer2008Dialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlServer2008Dialect.md) | SQL Server 2008 |
| [`SqlServer2012Dialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlServer2012Dialect.md) | SQL Server 2012+ |
| [`OracleDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/OracleDialect.md) | Oracle |
| [`Oracle12cDialect`](../api/dotnet/Serenity.Net.Services/Serenity.Data/Oracle12cDialect.md) | Oracle 12c |

> SQL Server dialects inherit from one another, so `SqlServer2012Dialect` is a
> `SqlServer2008Dialect`, which is a `SqlServer2005Dialect`, etc.

## Resolving a Dialect

[`ISqlDialectMapper`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ISqlDialectMapper.md)
maps a provider name or a dialect type name to an `ISqlDialect` instance:

```csharp
public interface ISqlDialectMapper
{
    ISqlDialect TryGet(string dialectOrProviderName);
}
```

The default implementation,
[`DefaultSqlDialectMapper`](../api/dotnet/Serenity.Net.Services/Serenity.Data/DefaultSqlDialectMapper.md),
maps well-known ADO.NET provider names:

| Provider name | Dialect |
| --- | --- |
| `System.Data.SqlClient`, `Microsoft.Data.SqlClient` | `SqlServer2012Dialect` |
| `FirebirdSql.Data.FirebirdClient` | `FirebirdDialect` |
| `Npgsql` | `PostgresDialect` |
| `MySql.Data.MySqlClient`, `MySqlConnector` | `MySqlDialect` |
| `System.Data.SQLite`, `Microsoft.Data.SQLite` | `SqliteDialect` |
| `System.Data.OracleClient`, `Oracle.ManagedDataAccess.Client` | `OracleDialect` |

If a provider name isn't found, it also tries to resolve a dialect type by its
name (e.g. `SqlServer2005` or a full type name), which is how a connection's
`Dialect` setting is resolved. See
[Connections and Transactions](sql-connections.md) for how a connection picks the
dialect.

## `SqlSettings`

[`SqlSettings`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlSettings.md)
holds global SQL configuration:

- `DefaultDialect` — the dialect used when one isn't otherwise determined. It
  defaults to `SqlServer2012Dialect`. Set it once at application start:
  ```csharp
  SqlSettings.DefaultDialect = SqliteDialect.Instance;
  ```

  > Not all queries fall back to this. A connection's dialect is derived from its
  > `providerName` (or an explicit `Dialect` setting in `appsettings.json`), so a
  > global default only applies where no more specific dialect was resolved.

- `AutoQuotedIdentifiers` — whether to automatically quote identifiers. Defaults
  to `true`. Used by the dialect and by `SqlSyntax` when quoting is needed.

- `DefaultCommandTimeout` — an optional default command timeout.

- `SetLocalDialect(dialect)` — sets a dialect for the current thread/async
  context only. This is useful for background tasks and unit tests, where you
  want to override the dialect locally without affecting the application-wide
  default:

  ```csharp
  SqlSettings.SetLocalDialect(SqliteDialect.Instance);
  ```

## Custom Dialects

If you need a server that isn't covered, implement `ISqlDialect` (or derive from
a built-in dialect and override the members that differ) and register it. A
custom dialect can also implement
[`ISqlExpressionTranslator`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ISqlExpressionTranslator.md)
to customize the SQL generated for dynamic expression attributes (such as
`ConcatExpressionAttribute`):

```csharp
public interface ISqlExpressionTranslator
{
    // Return null if you don't handle the given expression type.
    string Translate(object expression);
}
```

When a dialect implements this interface, Serenity asks it to translate each
expression; returning `null` means the default behavior is used.

## See Also

- [Connections and Transactions](sql-connections.md) — how a connection picks its dialect
- [Fluent SQL](fluent-sql.md) — how dialects affect generated `SELECT` / paging SQL
- [SQL Data Manipulation](sql-data-manipulation.md) — dialect-specific upsert statements
- [SQL Query Utilities](sql-query-utilities.md) — translating SQL for a target dialect
