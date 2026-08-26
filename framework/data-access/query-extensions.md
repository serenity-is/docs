# Query Extensions

The fluent SQL builders expose a small set of extension methods that add convenience on top of the query interfaces. They come from three static classes:

- [`FilterableQueryExtensions`](#filterablequeryextensions) — adds typed `WHERE` filters
- [`QueryWithParamsExtensions`](#querywithparamsextensions) — adds and sets parameters
- [`SetFieldByStatementExtensions`](#setfieldbystatementextensions) — assigns values in `INSERT`/`UPDATE`

Each extension targets an interface rather than a concrete builder, so the methods apply to any builder that implements that interface — for example `SqlQuery` (filtering and parameters), and `SqlInsert`/`SqlUpdate` (setting values and parameters).

## `FilterableQueryExtensions`

[`FilterableQueryExtensions`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/FilterableQueryExtensions.md) adds methods to anything implementing [`IFilterableQuery`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/IFilterableQuery.md) (which already has a `Where(string)` method).

| Method | What it does |
| --- | --- |
| `Where(ICriteria filter)` | Adds an `AND` condition built from a [`Criteria`](criteria.md) object. Empty criteria are skipped. |
| `WhereEqual(field, value)` | Adds an equality filter (`field = @param`) and adds the value as a parameter. |

`Where(ICriteria)` is what lets you build filters from `Criteria` expressions instead of raw SQL strings. This is the safe, parameterized way to filter a query:

```csharp
var fld = PersonRow.Fields;

var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname)
    .Where(fld.Age > 18 & fld.Country == "US");
```

This produces `WHERE Age > @p1 AND Country = @p2` rather than concatenating the values into the SQL. See [Criteria Objects](criteria.md) for how the `&`/`==` operators build the criteria.

`WhereEqual` is a shortcut for the common single-field equality case:

```csharp
var query = new SqlQuery()
    .From(fld)
    .Select(fld.Firstname)
    .WhereEqual(fld.PersonId, 5);
```

It is equivalent to `.Where(fld.PersonId == 5)`, and the value is always added as a parameter.

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

## See Also

- [Fluent SQL](fluent-sql.md) — building `SELECT` queries with `SqlQuery`
- [SQL Data Manipulation](sql-data-manipulation.md) — `SqlInsert`, `SqlUpdate`, `SqlDelete`, `Set`/`SetTo`/`SetNull`
- [Criteria Objects](criteria.md) — building typed `WHERE` conditions
- [SQL Helpers & Settings](sql-helpers.md) — the `Sql` expression helper, `SqlSyntax`, `SqlSettings`
