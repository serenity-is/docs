# Entity SQL Projections

The entity projection extensions execute a `SqlQuery` and materialize its selected values into a flat result type. They are useful when a query needs only a few fields or combines values from multiple rows, rather than loading complete rows.

The selector describes the result and generates the `SELECT` columns and their aliases, so do not add `SELECT` columns to the query first. Selector parameters bind to typed row-fields aliases from the query's `FROM` sources and joins; projections do not require `INTO` rows. Binding is inferred when there is exactly one compatible assignment for the selector parameters. If row types or aliases make that assignment ambiguous, pass an ordered `IReadOnlyList<RowFieldsBase>` as the `sources` argument. The list order must match the selector parameter order.

## Projecting One Row

Start with a typed row source, then pass a selector to `ListProjected`:

```csharp
using var connection = sqlConnections.NewFor<CustomerRow>();

var minimumId = 10;
var query = new SqlQuery()
    .From(new CustomerRow(), out var customerFields)
    .Where(customerFields.ID > minimumId);

var customers = query.ListProjected(connection,
    (CustomerRow customer) => new
    {
        customer.ID,
        customer.Name
    });
```

The selector can create an anonymous type, call a result constructor, or use an object initializer. Its result must be flat: nested result objects are not materialized. Map nested shapes from the returned values after the query completes.

`QueryProjected` returns an `IEnumerable<TResult>` and buffers by default. Pass `buffered: false` to stream rows; in that case, the database reader remains open until enumeration finishes or its enumerator is disposed. `ListProjected` always returns a materialized `List<TResult>`.

Selectors can read a mapped foreign-row path when its row-valued property uses [`ForeignRow`](../../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/ForeignRowAttribute.md), for example `customer.Manager!.Name`. The corresponding foreign-key join is included as needed.

## Projecting Multiple Rows

Each selector parameter must resolve to one unique typed source. For different row types, the query can infer the mapping from its `FROM` and typed `JOIN` aliases. When multiple aliases have the same row type, specify the aliases in selector parameter order:

```csharp
var order = new OrderRow();

var query = new SqlQuery()
    .From(order, out var orderFields)
    .From(CustomerRow.Fields, out var customerFields);

var summaries = query.ListProjected(connection,
    (OrderRow orderRow, CustomerRow customerRow) => new
    {
        OrderId = orderRow.ID,
        CustomerName = customerRow.Name
    }, sources: [orderFields, customerFields]);
```

`From(fields, out aliased)` returns the fields instance with the alias actually assigned by the query. Here it chooses an available alias because the order row already uses `T0`, so no explicit `.As("T1")` is needed. The aliased fields passed to typed joins are also available as projection sources. See [Joins & Aliases](joins-aliases.md#using-joins-in-queries) for callback-based typed joins and foreign-key `JoinVia` helpers. Add the joins or criteria appropriate to the relationship between sources. Typed selectors and explicit source lists are available for one, two, or three row parameters.

## SQL Expressions

Use row properties for normal field selections. To put a trusted SQL expression in a projection, mark it with `Sql.Expr<T>`:

```csharp
var total = query.ListProjected(connection,
    (OrderRow orderRow) => new
    {
        orderRow.ID,
        AmountWithTax = Sql.Expr<decimal?>("T0.[Amount] * 1.2")
    });
```

`Sql.Expr<T>` is interpreted only inside a projection selector. Its string is inserted as SQL, not bound as a parameter. If the expression needs a user-provided value, use a parameter placeholder such as `@TaxRate` in the expression and bind that parameter through the query or the projection call's `parameters` argument. Do not interpolate or concatenate the value into the SQL string.

## Reusing a Projection

`AsReusableProjected` prepares the projection once and returns an [`IProjectedQuery<TResult>`](../../api/dotnet/Serenity.Net.Services/Serenity.Data/IProjectedQuery-1.md), which can execute it repeatedly:

```csharp
var customerIdParam = new ParamCriteria("@CustomerId");
var reusable = new SqlQuery()
    .From(CustomerRow.Fields, out var fld)
    .Where(fld.ID == customerIdParam)
    .AsReusableProjected((CustomerRow customer) => new { customer.ID, customer.Name });

var first = reusable.List(connection,
    new Dictionary<string, object?> { [customerIdParam.Name] = 1 });
var second = reusable.List(connection,
    new Dictionary<string, object?> { [customerIdParam.Name] = 2 });
```

The source query must be a root query with no existing `SELECT` columns. Supply parameter values for each execution; per-call values override matching query parameters for that execution without changing the query's stored parameter values.

The reusable projection supports `Query` and `List`, plus `QueryAsync` and `ListAsync`. `Query` buffers by default; set `buffered: false` to stream. The async query method returns an `IAsyncEnumerable<TResult>`, while the async list method buffers into a list. The direct projection extensions also provide `ListProjectedAsync` and `QueryProjectedAsync`.

## See Also

- [Fluent SQL](fluent-sql.md) — constructing and executing `SqlQuery` instances
- [Query Extensions](query-extensions.md) — row-aware `From`, subquery, and query-reference helpers
- [Joins & Aliases](joins-aliases.md) — aliases used by row sources and joins
- [Mapping](mapping.md) — row, field, and foreign-row mapping
- [EntitySqlQueryProjection API](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntitySqlQueryProjection.md)