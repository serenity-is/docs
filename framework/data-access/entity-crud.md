# Entity CRUD & Query Helpers

Serenity provides low-level extension methods to perform entity CRUD and query operations directly on a connection. These are useful when you need to work with rows outside of a service handler (e.g. in a migration, a background job, or a custom handler).

> **Important:** These methods operate at a low level. They do **not** run service behaviors or perform service-level validation (permissions, required fields, etc.). For full service behavior, use the request handlers instead.

## Reading Entities

[EntityConnectionExtensions](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntityConnectionExtensions.md) provides methods to read entities directly from a connection:

```cs
using var connection = sqlConnections.NewFor<MyRow>();

var row = connection.ById<MyRow>(someId);          // throws if not found
var row2 = connection.TryById<MyRow>(someId);      // returns null if not found
var first = connection.First<MyRow>(criteria);     // first matching record
var single = connection.Single<MyRow>(criteria);   // exactly one record
```

- `ById` / `TryById` — find by ID (selects table fields only by default; overloads accept an `editQuery` callback to select more).
- `First` / `TryFirst` / `Single` / `TrySingle` — find by a criteria.
- `List<TRow>` — list all matching records.
- `Count` — count matching records.

These use the row's `IIdRow`/`INameRow` contracts and the fluent SQL query builder under the hood.

## Writing Entities

The same class provides insert/update/delete helpers:

```cs
using var connection = sqlConnections.NewFor<MyRow>();

var row = new MyRow { Name = "Test" };
var newId = connection.InsertAndGetID(row);        // insert, return new identity

row.Name = "Updated";
connection.UpdateById(row);                        // update by ID

connection.DeleteById<MyRow>(newId);               // delete by ID
```

- `Insert` / `InsertAndGetID` — insert a row (returns the new ID for identity columns).
- `Update` / `UpdateById` — update a row (by ID or by criteria).
- `Delete` / `DeleteById` — delete a row.

These operate on the row's **assigned fields** (assignment tracking), so only the fields you set are included in the SQL.

## Query Building Helpers

### `EntityQueryExtensions`

[EntityQueryExtensions](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntityQueryExtensions.md) provides fluent helpers for building queries from a row:

- `WhereEqual(row)` — adds all assigned field values to the WHERE clause with equality.
- `Set(row)` — sets all assigned field values (for `SqlUpdate`/`SqlInsert`).
- `SelectTableFields(row)` — selects the row's actual table fields.

These require the row to be in `TrackAssignments` mode.

### `EntitySqlHelper`

[EntitySqlHelper](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntitySqlHelper.md) provides helpers to execute a query and load results into a row:

- `GetFirst(query, connection)` — loads the first row into the query's loader row.
- `GetSingle(query, connection)` — loads the single row (throws if more than one).
- `ForEach(query, connection, callback)` — executes the callback for each row.

### `EntitySqlQueryExtensions`

[EntitySqlQueryExtensions](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntitySqlQueryExtensions.md) provides additional query-building extensions for entities.

## Field Helpers

[EntityFieldExtensions](../../api/dotnet/Serenity.Net.Services/Serenity.Data/EntityFieldExtensions.md) provides helpers for working with fields:

- `IsTableField(field)` — whether the field is an actual table column (not foreign/calculated/not-mapped).
- `EnumerateTableFields(row)` / `GetTableFields(row)` — the row's actual table fields.

## Row Helpers

[RowExtensions](../../api/dotnet/Serenity.Net.Services/Serenity.Data/RowExtensions.md) provides row-level helpers:

- `Clone()` — clones a row.
- `ApplyDefaultValues()` — applies field default values.
- `FindField()` / `FindFieldByPropertyName()` — find a field by name.

## Aliased Fields

[AliasedFields](../../api/dotnet/Serenity.Net.Services/Serenity.Data/AliasedFields.md) lets you create an aliased copy of a row's fields for queries:

```cs
var f = MyRow.Fields.As("x");
// f.Name now refers to x.Name instead of T0.Name
```

This is useful when a query joins the same table more than once.

## `OptionalValue<T>`

[OptionalValue&lt;T&gt;](../../api/dotnet/Serenity.Net.Services/Serenity/OptionalValue-1.md) is a small struct that wraps a value with a `HasValue` flag. It's used by interceptors to indicate whether a result is meaningful or whether the operation should continue normally.

## `IRowOperationInterceptor`

[IRowOperationInterceptor](../../api/dotnet/Serenity.Net.Services/Serenity.Data/IRowOperationInterceptor.md) lets you intercept the entity CRUD operations performed through `EntityConnectionExtensions` (find, list, count, insert/update/delete). It's primarily implemented by mock connections in tests to avoid hitting a real database.

## See Also

- [Entities (Rows)](entities.md)
- [Fluent SQL](fluent-sql.md)
- [Criteria Objects](criteria.md)
- [SQL Connections](sql-connections.md)
- [Save Request Handler](../../services/save_request_handler.md)