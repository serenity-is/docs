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

When a row is added with `From(row, out fields)`, use the returned fields instance in query expressions. It has the alias assigned to that source:

```csharp
var query = new SqlQuery()
    .From(new CustomerRow(), out var customer)
    .Select(customer.Name);
```

To use more than one row as a query source, add later field collections with an alias and associate each with its `INTO` row using `Into(row)`. See [Query Extensions](query-extensions.md#row-aware-sources-and-subqueries) for the source helpers and [Entity SQL Projections](entity-projections.md) for typed selectors over multiple rows.

Subqueries created by `SubQueryFrom(fields, out aliased)` participate in the query's alias allocation. When the supplied fields use `T0`, the helper assigns an available alias to the child query's source; use the returned `aliased` fields rather than the original collection inside that subquery.

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

For joins between typed row fields, use the entity query extensions. Their
`InnerJoin`, `LeftJoin`, and `RightJoin` overloads take the fields to join, a
callback that builds the `ON` criteria from those fields after alias allocation,
and an `out` parameter that receives the aliased fields. Use that returned
fields object in later criteria and selections:

```csharp
var query = new SqlQuery()
    .From(CustomerRow.Fields, out var customer)
    .InnerJoin(OrderRow.Fields,
        order => order.CustomerID == customer.CustomerID,
        out var order)
    .Select(customer.CompanyName)
    .Select(order.OrderID, "OrderID");
```

The query chooses an available alias for the joined fields. The callback is
invoked with that alias already applied, so the `ON` expression refers to the
actual query aliases. The `out` fields are required; the no-`out` convenience
overloads are not provided. The same pattern is available for inner and right
joins.

When the source field already describes a foreign key, use `LeftJoinVia`,
`RightJoinVia`, or `InnerJoinVia` to build the `ON` criteria from its metadata:

```csharp
var query = new SqlQuery()
    .From(OrderRow.Fields, out var order)
    .LeftJoinVia(CustomerRow.Fields, order.CustomerID, out var customer)
    .Select(order.OrderID)
    .Select(customer.CompanyName, "CompanyName");
```

Pass the referenced row's fields first, followed by the source foreign-key
field. This lets the compiler infer `TFields`; the supplied fields are used to
infer and validate the target type. A custom alias on those fields is preserved;
when they use the default `T0` alias, the method assigns an available query alias.
The `out` parameter returns the fields with the alias used by the join. These methods use the field's
`ForeignJoinAlias` when available; otherwise they use its
`ForeignKey` metadata (including the referenced row type, foreign table, and
foreign field). When a `ForeignJoinAlias` is used, its `ON` criteria is retained
and its join alias is rewritten to the allocated query alias.

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
