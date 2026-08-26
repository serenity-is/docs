# SQL Helpers and Settings

Serenity provides a set of static helper classes that complement the fluent query builders. Some generate SQL expressions you can drop into a `SqlQuery`, others deal with identifiers and quoting, and the rest help you configure, translate, execute, and log SQL.

This page covers:

- [`Sql`](#the-sql-helper) — helpers that build SQL expressions (`SUM`, `COUNT`, `CASE`, `COALESCE`, …)
- [`SqlSyntax`](#sqlsyntax) — identifier, quoting and alias helpers
- [`SqlSettings`](#sqlsettings) — global defaults (dialect, quoting, command timeout)
- [`SqlConversions`](#sqlconversions) — turning .NET values into SQL literals, and translating SQL for a dialect
- [`SqlHelper`](#sqlhelper) — creating commands, adding parameters, executing and logging
- [`ExpectedRows`](#expectedrows) — guarding `UPDATE`/`DELETE` against affecting too many rows
- [Running queries with Dapper](#running-queries-with-dapper) — the Serenity-aware Dapper extension methods
- [`ISqlOperationInterceptor`](#isqloperationinterceptor) — intercepting SQL operations (mostly for tests)

## The `Sql` helper

The static [`Sql`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/Sql.md) class builds SQL expressions. Each method returns the expression as a string, and the `IField` overloads use the field's `Expression`, so they work with row fields.

| Method | Returns |
| --- | --- |
| `Sql.Count()` | `COUNT(*)` |
| `Sql.Count(field)` | `COUNT(<field>)` |
| `Sql.Sum(field)` | `SUM(<field>)` |
| `Sql.Min(field)` / `Sql.Max(field)` / `Sql.Avg(field)` | `MIN/MAX/AVG(<field>)` |
| `Sql.Coalesce(a, b, c)` | `COALESCE(a, b, c)` |
| `Sql.Convert(type, field)` | `CONVERT(<type>, <field>)` |
| `Sql.SubString(expr, start, length)` | `SUBSTRING(<expr>, <start>, <length>)` |

For example, inside a `SqlQuery`:

```csharp
var fld = PersonRow.Fields;

var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname)
    .Select(Sql.Count())
    .Select(Sql.Sum(fld.Age))
    .Select(query.Coalesce(fld.Nickname, fld.Firstname, "N/A"), "DisplayName");
```

The `Coalesce` overload that takes the query adds non-expression values as parameters rather than concatenating them. Note it is called on the query instance (`query.Coalesce(...)`), not on the static `Sql` class.

### Building a `CASE` expression

For a `CASE` statement you use the query-based overload, which lets you chain `WHEN`/`THEN` pairs. `Then` and `Else` values that aren't expressions are added as parameters:

```csharp
var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname)
    .Select(
        query.Case(cb => cb
            .When(fld.Age > 18).Then("Adult")
            .Else("Minor")),
        "AgeGroup");
```

This produces something like `CASE WHEN Age > @p1 THEN @p2 ELSE @p3 END AS AgeGroup`.

## `SqlSyntax`

The static [`SqlSyntax`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlSyntax.md) class contains helpers for working with identifiers, quoting, and the auto-generated table aliases.

| Helper | Purpose |
| --- | --- |
| `int.TableAlias()` | Returns a table alias like `T0`, `T1` |
| `int.TableAliasDot()` | Returns an alias with a dot, like `T0.` |
| `int.IndexParam()` | Returns a parameter name like `@p0`, `@p1` |
| `IsValidIdentifier(s)` | True if `s` is a valid, unquoted SQL identifier |
| `IsValidQuotedIdentifier(s)` | True if `s` is a valid quoted identifier |
| `IsQuoted(s)` | True if `s` is bracketed (`[…]`), `"…"`, or `` `…` `` |
| `IsReservedKeywordForAny(s)` | True if `s` is a reserved keyword in any known dialect |
| `AutoBracket(s, dialect)` | Brackets `s` according to the dialect and the auto-quote setting |
| `AutoBracketValid(s, dialect)` | Like `AutoBracket`, but only brackets valid identifiers |
| `Unquote(s)` | Removes the surrounding brackets/quotes |

```csharp
0.TableAlias()        // "T0"
1.TableAliasDot()     // "T1."
3.IndexParam()        // "@p3"

SqlSyntax.IsValidIdentifier("PersonId")              // true
SqlSyntax.IsQuoted("[PersonId]")                     // true
SqlSyntax.AutoBracket("PersonId", SqlServer2012Dialect.Instance)
```

`AutoBracket` is what the query builders use internally when quoting is enabled; it respects the dialect's `AutoQuotedIdentifiers` and the fallback `SqlSettings.AutoQuotedIdentifiers` setting.

## `SqlSettings`

[`SqlSettings`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlSettings.md) holds process-wide (and per-async-context) defaults:

| Setting | Meaning |
| --- | --- |
| `DefaultDialect` | The dialect used when a connection doesn't specify one. Setting it is optional; the dialect is normally derived from the connection's `ProviderName`, with this as a fallback. |
| `SetLocalDialect(dialect)` | Sets the dialect for the current async context / thread. Useful in background tasks and unit tests. |
| `AutoQuotedIdentifiers` | Fallback for whether identifiers are quoted automatically. Defaults to `true`. |
| `DefaultCommandTimeout` | The default command timeout (seconds). |

```csharp
SqlSettings.DefaultDialect = SqliteDialect.Instance;

// limit the change to the current async context / thread
SqlSettings.SetLocalDialect(SqlServer2012Dialect.Instance);
```

See [SQL Dialects](sql-dialects.md) for the dialect system in full.

## `SqlConversions`

The static [`SqlConversions`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlConversions.md) class converts .NET values into SQL literals and translates SQL for a target dialect.

### `ToSql` value conversions

The `ToSql`/`ToSqlDate`/`ToSqlTime` extension methods convert nullable and non-nullable values to a SQL literal, returning `NULL` for a null value:

```csharp
123.ToSql();                                     // "123"
true.ToSql();                                    // "1"
new DateTime(2026, 1, 1).ToSqlDate();            // "'2026-01-01'"
"O'Reilly".ToSql();                              // quoted with the dialect's quote char
```

String and datetime conversions take an optional `ISqlDialect`; when omitted they use `SqlSettings.DefaultDialect`.

### `Translate`

`Translate(commandText, dialect)` (or `Translate(commandText, connection)`) converts command text for the target dialect by rewriting bracketed identifiers (`[]`) and the parameter prefix (`@`). This is what the query builders and the Dapper extensions use under the hood. It is the modern replacement for the obsolete `SqlHelper.FixCommandText`. See [SQL Query Utilities](sql-query-utilities.md).

## `SqlHelper`

The static [`SqlHelper`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlHelper.md) class provides lower-level helpers for building and running `IDbCommand` objects, and for logging.

- `NewCommand(connection, commandText)` — creates a command, translating the text for the connection's dialect.
- `NewCommand(connection, commandText, param)` — as above, plus parameters.
- `AddParamWithValue(command, name, value, dialect)` — adds a parameter, fixing its type (`bool`, enum, stream) and applying the dialect's parameter prefix.
- `FixParamType(value)` — converts a value to a type suitable as a SQL parameter (e.g. enums to their integral type, streams to `byte[]`).
- `ExecuteNonQuery(connection, commandText, param, logger)` — executes and returns the affected row count.
- `ExecuteAndGetID(insert, connection, logger)` — executes an `SqlInsert` and returns the generated identity.
- `LogCommand(method, command, logger)` — logs the SQL at debug level.

```csharp
using var command = SqlHelper.NewCommand(connection,
    "UPDATE Person SET Age = @Age WHERE PersonId = @Id");

command.AddParamWithValue("@Age", 30, connection.GetDialect());
command.AddParamWithValue("@Id", personId, connection.GetDialect());
```

`SqlHelper`'s execution methods also check for the connection-pool exception (`10054`) and retry by clearing the pools. When the connection implements `ISqlOperationInterceptor`, the interceptor is called first.

Use the query-level extensions (`query.ExecuteReader`, `SqlHelper.ExecuteScalar`, `EntitySqlHelper`) instead when you have a `SqlQuery` — see [Fluent SQL](fluent-sql.md).

## `ExpectedRows`

[`ExpectedRows`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/ExpectedRows.md) is an enum used by `SqlUpdate`/`SqlDelete` to guard against affecting more rows than intended. `SqlDelete`/`SqlUpdate` default to `ExpectedRows.One`. See [SQL Data Manipulation](sql-data-manipulation.md) for the values and examples.

## Running queries with Dapper

Serenity ships extension methods in the [`SqlMapper`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlMapper.md) class that mirror Dapper's `SqlMapper.Execute`/`SqlMapper.Query` methods but do two extra things: they translate the SQL for the connection's dialect (brackets and parameter prefix) and call `EnsureOpen()` before executing.

```csharp
using var connection = sqlConnections.NewFor<PersonRow>();

var people = connection.Query<dynamic>(
    "SELECT Firstname, Surname FROM Person WHERE Age > @Age",
    new { Age = 18 }).ToList();
```

There are also Serenity-specific overloads that accept an `ISqlQuery` (e.g. a `SqlQuery`) directly. Note these extensions don't go through `ISqlOperationInterceptor`.

## `ISqlOperationInterceptor`

[`ISqlOperationInterceptor`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/ISqlOperationInterceptor.md) lets a connection interceptor the basic SQL operations performed through `SqlHelper` (execute, execute reader, execute scalar), mostly for testing. It is implemented by a mock connection — for example to assert on the generated SQL or to return canned results.

```csharp
public class FakeConnectionInterceptor : ISqlOperationInterceptor
{
    public OptionalValue<long?> ExecuteNonQuery(string commandText,
        IDictionary<string, object> parameters, ExpectedRows expectedRows,
        IQueryWithParams query, bool getNewId)
    {
        // Return default to let the operation run normally.
        // Return a meaningful value (HasValue = true) to short-circuit it.
        return default;
    }

    public OptionalValue<IDataReader> ExecuteReader(string commandText,
        IDictionary<string, object> parameters, SqlQuery query) => default;

    public OptionalValue<object> ExecuteScalar(string commandText,
        IDictionary<string, object> parameters, SqlQuery query) => default;
}
```

It does not intercept Dapper operations.

## See Also

- [Fluent SQL](fluent-sql.md) — building `SELECT` queries with `SqlQuery`
- [SQL Data Manipulation](sql-data-manipulation.md) — `SqlInsert`, `SqlUpdate`, `SqlDelete`, `ExpectedRows`
- [SQL Query Utilities](sql-query-utilities.md) — rewriting SQL expressions, `SqlConversions.Translate`
- [SQL Dialects](sql-dialects.md) — the dialect abstraction and `SqlSettings`
- [SQL Connections](sql-connections.md) — creating and wrapping connections
- [Criteria Objects](criteria.md) — building typed filter conditions
