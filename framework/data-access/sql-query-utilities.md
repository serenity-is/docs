# SQL Query Utilities

Serenity ships a few small static helper classes that analyze or rewrite raw SQL
expression strings. They are **low level** — you will rarely call them directly
from application code — but they are useful to know about when you port raw SQL
into a Serenity query, write a migration, or debug the SQL Serenity generates.

## `BracketLocator`

[`BracketLocator`](../api/dotnet/Serenity.Net.Services/Serenity.Data/BracketLocator.md)
finds and replaces the `[Identifier]` brackets used by SQL Server in an SQL
expression, so the expression can be targeted at a different dialect:

- `ReplaceBrackets(expression, dialect)` — replaces `[Identifier]` with the
  dialect's quoting (e.g. backticks for MySQL, double quotes for Postgres).
- `ReplaceBracketContents(expression, validChar1, replace)` — lets you provide a
  callback that rewrites the contents of each bracketed identifier.

This is commonly used in migrations, where the generated SQL uses SQL Server
brackets but may run on another provider:

```csharp
Execute.Sql(BracketLocator.ReplaceBrackets(
    new SqlUpdate("[Users]").Set("[IsActive]", 0).ToString(),
    connection.GetDialect()));
```

It also powers [`SqlConversions.Translate`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlConversions.md),
which is the modern replacement for the obsolete `SqlHelper.FixCommandText`.

## `JoinAliasLocator`

[`JoinAliasLocator`](../api/dotnet/Serenity.Net.Services/Serenity.Data/JoinAliasLocator.md)
finds the aliases referenced in an SQL expression:

- `Locate(expression)` — returns a `HashSet<string>` of the aliases found (the
  part before the dot in `alias.Field`), or `null` if there are none.
- `LocateOptimized(expression, out singleAlias)` — same, but returns the first
  alias in an `out` parameter for the common single-alias case.
- `EnumerateAliases(expression, action)` — invokes a callback for each alias.
- `ReplaceAliases(expression, replace)` — rewrites aliases via a callback.

`SqlQuery` and the `Join` classes use this internally to track which aliases a
join or expression references, so that dependent joins can be added
automatically (`EnsureJoinsInExpression`). You generally don't call it directly.

## `T0ReferenceRemover`

[`T0ReferenceRemover`](../api/dotnet/Serenity.Net.Services/Serenity.Data/T0ReferenceRemover.md)
removes the `t0.` prefix from an SQL expression:

- `RemoveT0Aliases(expression)` — strips leading `t0.` / `T0.` references, e.g.
  `T0.UserId` becomes `UserId`.

`SqlUpdate` and `SqlDelete` use this when you pass a `Where` expression, because
`UPDATE` and `DELETE` statements don't use the `T0` prefix the way `SELECT`
queries do. `SqlUpdate.RemoveT0Reference` is the helper that wraps it.

## `ParamPrefixReplacer`

[`ParamPrefixReplacer`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ParamPrefixReplacer.md)
replaces the `@` parameter prefix in an SQL expression:

- `Replace(expression, paramPrefix)` — turns `@p1` into `:p1` (for Oracle) or the
  target dialect's prefix.

This is used alongside `BracketLocator` when translating SQL for a specific
dialect; `SqlConversions.Translate` combines both.

## See Also

- [Joins & Aliases](joins-aliases.md) — the alias and join types
- [Fluent SQL](fluent-sql.md) — building `SELECT` queries with `SqlQuery`
- [SQL Data Manipulation](sql-data-manipulation.md) — where `T0ReferenceRemover` is used by `UPDATE` / `DELETE`
- [SQL Connections](sql-connections.md) — dialects and connection strings
