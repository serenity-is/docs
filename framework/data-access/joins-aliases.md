# Joins & Aliases

SQL queries refer to tables through short aliases (e.g. `FROM Person p`). Serenity
models this with the [`Alias`](../api/dotnet/Serenity.Net.Services/Serenity.Data/Alias.md)
type, and the `INNER` / `LEFT` / `RIGHT` / `CROSS APPLY` / `OUTER APPLY` clauses
with the [`Join`](../api/dotnet/Serenity.Net.Services/Serenity.Data/Join.md)
family of classes. Together they let you build prefixed field expressions and
describe joins in a type-safe way.

## Alias

[`Alias`](../api/dotnet/Serenity.Net.Services/Serenity.Data/Alias.md) implements
[`IAlias`](../api/dotnet/Serenity.Net.Services/Serenity.Data/IAlias.md), which
exposes `Name` (the short name), `NameDot` (`name.`), and `Table` (the table
name). There are several ways to create one:

```csharp
new Alias("Person", "p")   // table "Person", short name "p"
new Alias("p")             // short name only, no table
new Alias(0)               // numeric alias -> "t0"
Alias.T0                   // alias whose short name is "t0"
```

The `Alias` class also defines static aliases `T0` … `T9`. `T0` is the
conventional alias for the main (primary) table of a query.

Use an alias to build a prefixed field reference:

```csharp
var p = new Alias("Person", "p");

p["Firstname"]               // indexer          -> "p.Firstname"
p + "Firstname"              // `+` operator     -> "p.Firstname"
p + PersonRow.Fields.Firstname  // `+` with a field -> "p.Firstname"
p._("Firstname")             // criteria (legacy) -> Criteria("p.Firstname")
```

`p[IField]` and `p + IField` are also available, so you can use a row's field
objects instead of strings.

## The `T0` Alias

`T0` is the default alias for the row's own table. When you call
`new SqlQuery().From(row)`, Serenity uses the row's fields collection as an
alias, so fields are referenced as `T0.<Field>`. Joined tables use their declared
aliases. The `T0` alias is described in more detail in
[Row Fields](row-fields.md).

## `AliasExtensions`

[`AliasExtensions`](../api/dotnet/Serenity.Net.Services/Serenity.Data/AliasExtensions.md)
provides a single helper:

- `alias.WithNoLock()` — returns a new alias that appends `WITH(NOLOCK)` to the
  alias name. This is useful for allowing dirty reads on the joined table:

```csharp
new SqlQuery()
    .From(new Alias("Person", "p").WithNoLock())
    .Select("p.Firstname");
```

## Join Classes

The [`Join`](../api/dotnet/Serenity.Net.Services/Serenity.Data/Join.md) base
class is an `Alias` that also carries the `ON` criteria, the join's dictionary,
and the set of aliases it references. The concrete classes add the SQL keyword:

| Class | SQL keyword |
| --- | --- |
| [`InnerJoin`](../api/dotnet/Serenity.Net.Services/Serenity.Data/InnerJoin.md) | `INNER JOIN` |
| [`LeftJoin`](../api/dotnet/Serenity.Net.Services/Serenity.Data/LeftJoin.md) | `LEFT JOIN` |
| [`RightJoin`](../api/dotnet/Serenity.Net.Services/Serenity.Data/RightJoin.md) | `RIGHT JOIN` |
| [`CrossApply`](../api/dotnet/Serenity.Net.Services/Serenity.Data/CrossApply.md) | `CROSS APPLY` |
| [`OuterApply`](../api/dotnet/Serenity.Net.Services/Serenity.Data/OuterApply.md) | `OUTER APPLY` |

Each join is constructed with a table (or subquery) name, an alias, and an `ON`
criteria:

```csharp
var join = new LeftJoin("City", "c",
    new Criteria("p.CityId") == new Criteria("c.ID"));
```

For `CrossApply` / `OuterApply`, the first argument is a subquery and there is no
`ON` criteria:

```csharp
new OuterApply(
    "SELECT COUNT(*) FROM Orders o WHERE o.PersonId = p.PersonId",
    "oc");
```

The `Join` classes implement
[`ISqlJoin`](../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/ISqlJoin.md),
the interface used by the mapping attributes (`LeftJoinAttribute`,
`InnerJoinAttribute`, `OuterApplyAttribute`) and by behavior/UI code to read
join metadata (`Alias`, `ToTable`, `OnCriteria`, `PropertyPrefix`, `RowType`).

## Using Joins in Queries

`SqlQuery` provides the `LeftJoin` / `RightJoin` / `InnerJoin` methods (see
[Fluent SQL](fluent-sql.md)):

```csharp
var p = new Alias("Person", "p");
var c = new Alias("City", "c");

var query = new SqlQuery()
    .From(p)
    .LeftJoin(c, new Criteria(p["CityId"]) == new Criteria(c["ID"]))
    .Select(p["Firstname"])
    .Select(c["Name"], "CityName");
```

You can also construct a join yourself and pass it to `SqlQuery.Join(Join)`.
This is useful for `CROSS APPLY` / `OUTER APPLY`, which don't have dedicated
`SqlQuery` methods, or when you want to keep a join object around to reuse:

```csharp
var p = new Alias("Person", "p");

new SqlQuery()
    .From(p)
    .Join(new OuterApply(
        "SELECT COUNT(*) AS OrderCount FROM Orders o WHERE o.PersonId = p.PersonId",
        "oc"))
    .Select(p["Firstname"])
    .Select("oc.OrderCount");
```

> When a join's `Alias` itself references further joins, `SqlQuery` pulls in the
> required joins automatically via `EnsureJoinsInExpression`.

## CROSS / OUTER APPLY

`CROSS APPLY` evaluates a subquery or table-valued function once for each row of
the outer query, so the inner query can reference the outer alias. `OUTER APPLY`
is the left-join equivalent — it preserves outer rows that have no match:

```sql
SELECT p.Firstname, oc.OrderCount
FROM Person p
OUTER APPLY (
    SELECT COUNT(*) AS OrderCount
    FROM Orders o
    WHERE o.PersonId = p.PersonId
) oc
```

Because `CROSS` / `OUTER` `APPLY` can reference the outer query, they behave
differently from a regular join whose `ON` clause can only reference already-joined
tables.

## See Also

- [Fluent SQL](fluent-sql.md) — building `SELECT` queries with `SqlQuery`
- [Row Fields](row-fields.md) — the `T0` alias and row field collections
- [Mapping](mapping.md) — declarative join attributes (`LeftJoin`, `InnerJoin`, `OuterApply`)
- [SQL Query Utilities](sql-query-utilities.md) — internal helpers for rewriting SQL expressions
