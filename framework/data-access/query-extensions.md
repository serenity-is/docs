# Query Extensions

The fluent SQL builders expose extension methods that add convenience on top of their query interfaces. The core query extensions come from three static classes:

- [`FilterableQueryExtensions`](#filterablequeryextensions) — adds typed `WHERE` filters
- [`QueryWithParamsExtensions`](#querywithparamsextensions) — adds and sets parameters
- [`SetFieldByStatementExtensions`](#setfieldbystatementextensions) — assigns values in `INSERT`/`UPDATE`

These core extensions target an interface rather than a concrete builder, so the methods apply to any builder that implements that interface — for example `SqlQuery` (filtering and parameters), and `SqlInsert`/`SqlUpdate` (setting values and parameters). The entity query extensions described below add row-aware sources and subqueries.

## `FilterableQueryExtensions`

[`FilterableQueryExtensions`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/FilterableQueryExtensions.md) adds methods to anything implementing [`IFilterableQuery`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/IFilterableQuery.md). The interface itself defines `Where(ICriteria?)`; `Where(string)` is an extension method.

| Method | What it does |
| --- | --- |
| `Where(ICriteria? criteria)` (interface method) | Adds an `AND` condition built from a [`Criteria`](criteria.md) object. Empty criteria are skipped. |
| `Where(string filter)` (extension method) | Adds one raw criteria expression. Call it repeatedly to add more `AND` conditions. |
| `WhereEqual(field, value)` (extension method) | Adds an equality filter (`field = @param`) and adds the value as a parameter. |

`Where(ICriteria)` lets you build filters from `Criteria` expressions instead of raw SQL strings. Values in criteria expressions are parameterized:

```csharp
var fld = PersonRow.Fields;

var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname)
    .Where(fld.Age > 18 & fld.Country == "US");
```

This produces `WHERE Age > @p1 AND Country = @p2` rather than concatenating the values into the SQL. See [Criteria Objects](criteria.md) for how the `&`/`==` operators build the criteria.

`Where(string)` wraps the supplied string as a criteria expression; it does not parameterize values interpolated into that string. Use it only for trusted SQL fragments, and bind values separately with query parameters as shown below.

`WhereEqual` is a shortcut for the common single-field equality case:

```csharp
var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname)
    .WhereEqual(fld.PersonId, 5);
```

It is equivalent to `.Where(fld.PersonId == 5)`, and the value is always added as a parameter.

`IFilterableQuery` also exposes `GetWhereCriteria()` and `GetWhereClause()`. The former returns a read-only list of criteria passed to `Where`; the latter returns the combined conditions joined with `AND`, without the `WHERE` keyword. Its parameters are added when `Where` is called, so reading the clause repeatedly does not add duplicate parameters.

## `QueryWithParamsExtensions`

[`QueryWithParamsExtensions`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/QueryWithParamsExtensions.md) adds methods to anything implementing [`IQueryWithParams`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/IQueryWithParams.md), which exposes `AddParam(name, value)`, `SetParam(name, value)`, and `AutoParam()`.

| Method | What it does |
| --- | --- |
| `AddParam(object value)` | Creates an auto-named parameter (e.g. `@p0`), adds the value, and returns the [`Parameter`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/Parameter.md) so you can reference its `Name`. |
| `SetParam(Parameter param, object value)` | Sets the value of an auto-named `Parameter`. |

`AddParam` is the underlying mechanism used by `WhereEqual` and `Set`. You can also use it directly when you need to add a value as a parameter and reference it by name:

```csharp
var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname);

var param = query.AddParam("US");
query.Where("Country = " + param.Name);
```

This produces `WHERE Country = @p0` with `@p0` bound to `"US"`. This is still safe (the value is parameterized); only the field/table names should never come from user input.

`SetParam` sets the value of an auto-named `Parameter`, which is handy when you create the parameter name once and reuse it (for example in a loop or a query that reuses the same value):

```csharp
var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname);

var param = query.AutoParam();   // e.g. @p0
query.SetParam(param, "US");
query.Where("Country = " + param.Name);
```

## `SetFieldByStatementExtensions`

[`SetFieldByStatementExtensions`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/SetFieldByStatementExtensions.md) adds `Set` to anything implementing [`ISetFieldByStatement`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/ISetFieldByStatement.md) (i.e. `SqlInsert`/`SqlUpdate`). It assigns a field to a parameterized value in one call:

```csharp
new SqlUpdate(fld.TableName)
    .Set(fld.FirstName, "John")
    .Set(fld.LastName, "Doe")
    .WhereEqual(fld.PersonId, 5);
```

`Set(field, value)` adds the value as a parameter and calls `SetTo` with that parameter name. See [SQL Data Manipulation](sql-data-manipulation.md) for `Set`, `SetTo`, and `SetNull` in full.

## Row-Aware Sources and Subqueries

[`EntitySqlQueryExtensions`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntitySqlQueryExtensions.md) adds helpers for using row fields as query sources:

- `From(row, out fields)` adds the row as a source, sets it as the query's `INTO` target, and returns the fields instance with the alias actually used by the query. An overload accepts an explicit alias.
- `SubQueryFrom(fields, out aliased)` creates a child `SqlQuery` and adds the fields as its source without setting an `INTO` target. If the fields use the default `T0` alias, an available alias is assigned and returned through `aliased`.
- `WithSelf(out reference)` assigns the query itself to `reference` and returns the same query, making the parent available from within a fluent chain.

For example, use `WithSelf` when a filter needs a subquery built from the outer query:

```csharp
var query = new SqlQuery()
    .From(new RolePermissionRow(), out var permission)
    .WithSelf(out var outer)
    .Select(permission.PermissionKey)
    .Where(permission.RoleId.In(
        outer.SubQueryFrom(UserRoleRow.Fields, out var userRole)
            .Select(userRole.RoleId)
            .Where(userRole.UserId == userId)));
```

Use the fields returned by `out` for expressions and criteria so they carry the alias assigned to that source. `From(row, ...)` sets the single `INTO` target; for additional row sources, add aliased fields with `From(fields).Into(row)`. See [Entity SQL Projections](entity-projections.md) for projecting results from one or more source rows.

## See Also

- [Fluent SQL](fluent-sql.md) — building `SELECT` queries with `SqlQuery`
- [SQL Data Manipulation](sql-data-manipulation.md) — `SqlInsert`, `SqlUpdate`, `SqlDelete`, `Set`/`SetTo`/`SetNull`
- [Criteria Objects](criteria.md) — building typed `WHERE` conditions
- [SQL Helpers & Settings](sql-helpers.md) — the `Sql` expression helper, `SqlSyntax`, `SqlSettings`
- [Entity SQL Projections](entity-projections.md) — selecting flat results from row sources
