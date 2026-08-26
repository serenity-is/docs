# SQL Data Manipulation (Insert, Update, Delete)

Serenity's fluent SQL builders aren't limited to `SELECT` queries. Alongside
[SqlQuery](fluent-sql.md), which builds `SELECT` statements, Serenity ships three
small builders for the data-manipulation (DML) statements:

| Builder | Generates |
| --- | --- |
| [`SqlInsert`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlInsert.md) | `INSERT INTO ...` |
| [`SqlUpdate`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlUpdate.md) | `UPDATE ... SET ... WHERE ...` |
| [`SqlDelete`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlDelete.md) | `DELETE FROM ... WHERE ...` |

All three derive from [`QueryWithParams`](../api/dotnet/Serenity.Net.Services/Serenity.Data/QueryWithParams.md),
so the values you pass are turned into auto-named parameters rather than being
concatenated into the SQL string. This keeps your queries safe from SQL injection
and gives them the same parameter handling as `SqlQuery`.

These builders are **low level**. They perform no validation, no permission
check, and do not call any service behaviors or request handlers. When you work
with entities inside a request handler you will normally use the
[request handlers](../services/README.md) or the CRUD helpers in
[Entity CRUD & Query Helpers](../services/entity-crud.md). Reach for the builders
below when you need to run a bare `INSERT` / `UPDATE` / `DELETE` directly on a
connection — for example in a migration, a background job, or when you are
authoring a custom store.

## IMPORTANT WARNING!

Never pass a user-provided string to one of these builders' methods. It is VERY
DANGEROUS as it would open your code to SQL-injection attacks! This includes
using a user-provided string in a string concatenation operation and passing it.

The `user-provided string` here includes anything entered on a client-side form,
in addition to any parameters that are sent to one of your API/actions/services
via JSON, XML, query-string, form, request-body, etc.

https://en.wikipedia.org/wiki/SQL_injection

## Setting Field Values

All three builders let you assign a value to a column. There are three related
ways to do this:

| Method | What it does |
| --- | --- |
| `Set(field, value)` | Sets the field to a parameterized value. The value is added to the parameter dictionary and referenced by an auto-named parameter (e.g. `@p1`). |
| `SetTo(field, expression)` | Sets the field to a raw SQL expression (e.g. `Now()`, a subquery, or a column reference). **Do not pass user input here.** |
| `SetNull(field)` | Sets the field to `NULL`. |

`Set` is an extension method on anything implementing `ISetFieldByStatement`, and
uses `AddParam` under the hood, so it is a safe way to write a value from a
variable:

```csharp
new SqlInsert("People")
    .Set("FirstName", "John")
    .Set("LastName", "Doe")
    .Set("Age", 30)
    .SetNull("Photo");
```

The `Set` overloads also accept an `IField`, so you can use a row's field
objects directly:

```csharp
var fld = PersonRow.Fields;

new SqlInsert(fld.TableName)
    .Set(fld.FirstName, "John")
    .Set(fld.LastName, "Doe")
    .Set(fld.Age, 30);
```

## SqlInsert

[`SqlInsert`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlInsert.md)
generates `INSERT INTO table (col1, col2, ...) VALUES (v1, v2, ...)`.

```csharp
var insert = new SqlInsert("People")
    .Set("FirstName", "John")
    .Set("LastName", "Doe");

// INSERT INTO People (FirstName, LastName) VALUES (@p1, @p2)
```

It is constructed with a table name (or a row's `TableName`). Each `Set()` /
`SetTo()` / `SetNull()` adds a column/value pair, and the order of calls becomes
the order of the columns.

### Running an Insert

Use [`SqlHelper.Execute`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlHelper.md)
to execute the insert:

```csharp
new SqlInsert(fld.TableName)
    .Set(fld.UserId, userId)
    .Set(fld.PreferenceType, request.PreferenceType)
    .Set(fld.Name, request.Name)
    .Set(fld.Value, request.Value)
    .Execute(connection);
```

### Returning the Generated Identity

If the table has an auto-increment (identity) primary key, tell the builder which
column it is and call `ExecuteAndGetID` to retrieve the generated value:

```csharp
var insert = new SqlInsert("People")
    .IdentityColumn("PersonId")
    .Set("FirstName", "John");

long? id = insert.ExecuteAndGetID(connection);
```

`ExecuteAndGetID` only works for auto-incremented integer columns. For GUID
primary keys, generate the value yourself and use a regular `Execute`.

### Set the Dialect

When you run a builder you can rely on the connection's dialect, but in some
scenarios (for example building the query before you have a connection) you may
want to pin it:

```csharp
var insert = new SqlInsert(tableName)
    .Dialect(connection.GetDialect())
    .Set(colId, key)
    .Set(colValue, value);
```

### Upsert (Insert or Update)

`SqlInsert` can also generate a dialect-specific upsert. This is an atomic
"insert, or update if the key already exists" statement. Use
`ExecuteUpsert(connection, keyFields, expectedRows)` and supply the key fields
used to match an existing row:

```csharp
new SqlInsert(cacheTable)
    .Dialect(connection.GetDialect())
    .Set(colId, GetCacheKey(key))
    .Set(colValue, value)
    .SetNull(colSlidingExpirationInSeconds)
    .ExecuteUpsert(connection, [colId], ExpectedRows.Ignore);
```

The generated statement depends on the dialect:

| Dialect | Generated statement |
| --- | --- |
| SQL Server | `INSERT ... SELECT ... WHERE NOT EXISTS (...)` with an `UPDATE` fallback |
| SQLite / Postgres | `INSERT ... ON CONFLICT (...) DO UPDATE` / `DO NOTHING` |
| MySQL | `INSERT ... ON DUPLICATE KEY UPDATE` |
| Oracle | `MERGE INTO ...` |
| Firebird | `UPDATE OR INSERT INTO ... MATCHING (...)` |

If the dialect doesn't support an atomic upsert, `ExecuteUpsert` falls back to a
non-atomic update-then-insert. You can also get the raw statement without running
it via `ToUpsertString(keyFields)`.

## SqlUpdate

[`SqlUpdate`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlUpdate.md)
generates `UPDATE table SET col = val, ... WHERE ...`.

```csharp
new SqlUpdate("People")
    .Set("FirstName", "Jane")
    .Inc("Age", 1)                       // Age = Age + 1
    .Where(new Criteria("PersonId") == 5)
    .Execute(connection, ExpectedRows.One);
```

In addition to `Set` / `SetTo` / `SetNull`, `SqlUpdate` offers two arithmetic
shortcuts:

| Method | Effect |
| --- | --- |
| `Inc(field, amount)` | `field = field + amount` (adds `+`, or `-` for a negative amount). |
| `Dec(field, amount)` | `field = field - amount` (equivalent to `Inc(field, -amount)`). |

### Filtering with Where

`.Where()` adds a condition to the `WHERE` clause. Successive calls are joined
with `AND`. You can pass a raw string or a criteria object:

```csharp
var criteria = fld.UserId == userId &
    fld.PreferenceType == request.PreferenceType;

new SqlUpdate(fld.TableName)
    .Set(fld.Value, request.Value)
    .Where(criteria)
    .Execute(connection, ExpectedRows.ZeroOrOne);
```

Because `SqlUpdate` implements `IFilterableQuery`, the
[`WhereEqual`](../api/dotnet/Serenity.Net.Services/Serenity.Data/FilterableQueryExtensions.md)
helper is also available for a safe, parameterized equality filter:

```csharp
new SqlUpdate(fld.TableName)
    .Set(fld.DisplayName, displayName)
    .Set(fld.PasswordHash, hash)
    .WhereEqual(fld.UserId, user.UserId)
    .Execute(connection, ExpectedRows.One);
```

## SqlDelete

[`SqlDelete`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlDelete.md)
generates `DELETE FROM table WHERE ...`.

```csharp
new SqlDelete("People")
    .Where(new Criteria("PersonId") == 5)
    .Execute(connection, ExpectedRows.One);
```

Like `SqlUpdate`, `.Where()` accepts a string or a criteria object, and `.Where(params string[])` accepts multiple conditions joined with `AND`:

```csharp
new SqlDelete(Fld.TableName)
    .Where(
        new Criteria(Fld.UserId) == userID &
        new Criteria(Fld.RoleId) == k)
    .Execute(connection);
```

> `SqlDelete` / `SqlUpdate` default to `ExpectedRows.One`. This is a deliberate
> safety net: if you forget a `WHERE`, the call throws rather than updating or
> deleting every row. See [ExpectedRows](#expectedrows).

## ExpectedRows

[`ExpectedRows`](../api/dotnet/Serenity.Net.Services/Serenity.Data/ExpectedRows.md)
controls how the number of affected rows is validated after an `UPDATE` or
`DELETE`:

| Value | Meaning |
| --- | --- |
| `ExpectedRows.One` | Exactly one row must be affected, otherwise an `InvalidOperationException` is thrown. This is the default. |
| `ExpectedRows.ZeroOrOne` | Zero or one row may be affected; more than one throws. |
| `ExpectedRows.Ignore` | The affected row count is ignored. |

This makes a missing `WHERE` clause a loud error instead of silently truncating a
table.

## Executing the Query

The builders are executed through the
[`SqlHelper`](../api/dotnet/Serenity.Net.Services/Serenity.Data/SqlHelper.md)
extension methods, which take care of opening the connection, building the
command, adding parameters, logging, and honoring any
`ISqlOperationInterceptor`:

| Builder | Execution methods |
| --- | --- |
| `SqlInsert` | `Execute(connection)`, `ExecuteAndGetID(connection)`, `ExecuteUpsert(connection, keyFields, expectedRows)` |
| `SqlUpdate` | `Execute(connection, expectedRows)` |
| `SqlDelete` | `Execute(connection, expectedRows)` |

Each returns the number of affected rows (or the generated id for
`ExecuteAndGetID`).

## See Also

- [Fluent SQL](fluent-sql.md) — building `SELECT` queries with `SqlQuery`
- [Query Extensions](query-extensions.md) — `Set`, `WhereEqual`, `AddParam` helpers
- [Criteria Objects](criteria.md) — building typed filter conditions
- [Entity CRUD & Query Helpers](../services/entity-crud.md) — higher-level row CRUD helpers
- [SQL Connections](sql-connections.md) — how connections are created and managed
