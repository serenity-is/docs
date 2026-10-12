# EntitySqlQueryProjection.ListProjectedAsync&lt;TRow,TResult&gt; method (1 of 6)

Asynchronously executes the query and buffers the flat projection results.

```csharp
public static Task<List<TResult>> ListProjectedAsync<TRow, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow, TResult>> projection, 
    IReadOnlyDictionary<string, object?>? parameters = null, bool takeOwnership = false, 
    CancellationToken cancellationToken = default)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The row type of the projected source. |
| TResult | The flat projection result type. |
| query | The query to execute. |
| connection | The connection. |
| projection | A flat projection built from direct row field accesses. |
| parameters | Values that override the source query's parameters for this execution. |
| takeOwnership | Whether to prepare the source query in place instead of cloning it. The source must not be frozen. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the projected list.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.ListProjectedAsync&lt;TRow,TResult&gt; method (2 of 6)

Executes and buffers a projection asynchronously using the specified row-fields source aliases.

```csharp
public static Task<List<TResult>> ListProjectedAsync<TRow, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, IReadOnlyDictionary<string, object?>? parameters = null, 
    bool takeOwnership = false, CancellationToken cancellationToken = default)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| query | The query to execute. |
| connection | The database connection. |
| projection | A flat projection built from row field accesses or SQL expressions. |
| sources | The row-fields sources for the projection parameters. |
| parameters | The query parameters. |
| takeOwnership | Whether to prepare the source query in place. If false, a clone is prepared; a frozen source cannot be taken over. |
| cancellationToken | The cancellation token. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.ListProjectedAsync&lt;TRow1,TRow2,TResult&gt; method (3 of 6)

Asynchronously executes the query and buffers the flat projection results.

```csharp
public static Task<List<TResult>> ListProjectedAsync<TRow1, TRow2, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow1, TRow2, TResult>> projection, 
    IReadOnlyDictionary<string, object?>? parameters = null, bool takeOwnership = false, 
    CancellationToken cancellationToken = default)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
```

| parameter | description |
| --- | --- |
| TRow1 | The row type of the first projected source. |
| TRow2 | The row type of the second projected source. |
| TResult | The flat projection result type. |
| query | The query to execute. |
| connection | The connection. |
| projection | A flat projection built from direct row field accesses. |
| parameters | Values that override the source query's parameters for this execution. |
| takeOwnership | Whether to prepare the source query in place instead of cloning it. The source must not be frozen. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the projected list.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.ListProjectedAsync&lt;TRow1,TRow2,TResult&gt; method (4 of 6)

Executes and buffers a projection asynchronously using the specified row-fields source aliases.

```csharp
public static Task<List<TResult>> ListProjectedAsync<TRow1, TRow2, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow1, TRow2, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, IReadOnlyDictionary<string, object?>? parameters = null, 
    bool takeOwnership = false, CancellationToken cancellationToken = default)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
```

| parameter | description |
| --- | --- |
| query | The query to execute. |
| connection | The database connection. |
| projection | A flat projection built from row field accesses or SQL expressions. |
| sources | The row-fields sources for the projection parameters. |
| parameters | The query parameters. |
| takeOwnership | Whether to prepare the source query in place. If false, a clone is prepared; a frozen source cannot be taken over. |
| cancellationToken | The cancellation token. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.ListProjectedAsync&lt;TRow1,TRow2,TRow3,TResult&gt; method (5 of 6)

Asynchronously executes the query and buffers the flat projection results.

```csharp
public static Task<List<TResult>> ListProjectedAsync<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, 
    IReadOnlyDictionary<string, object?>? parameters = null, bool takeOwnership = false, 
    CancellationToken cancellationToken = default)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
    where TRow3 : class, IRow
```

| parameter | description |
| --- | --- |
| TRow1 | The row type of the first projected source. |
| TRow2 | The row type of the second projected source. |
| TRow3 | The row type of the third projected source. |
| TResult | The flat projection result type. |
| query | The query to execute. |
| connection | The connection. |
| projection | A flat projection built from direct row field accesses. |
| parameters | Values that override the source query's parameters for this execution. |
| takeOwnership | Whether to prepare the source query in place instead of cloning it. The source must not be frozen. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the projected list.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.ListProjectedAsync&lt;TRow1,TRow2,TRow3,TResult&gt; method (6 of 6)

Executes and buffers a projection asynchronously using the specified row-fields source aliases.

```csharp
public static Task<List<TResult>> ListProjectedAsync<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, IReadOnlyDictionary<string, object?>? parameters = null, 
    bool takeOwnership = false, CancellationToken cancellationToken = default)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
    where TRow3 : class, IRow
```

| parameter | description |
| --- | --- |
| query | The query to execute. |
| connection | The database connection. |
| projection | A flat projection built from row field accesses or SQL expressions. |
| sources | The row-fields sources for the projection parameters. |
| parameters | The query parameters. |
| takeOwnership | Whether to prepare the source query in place. If false, a clone is prepared; a frozen source cannot be taken over. |
| cancellationToken | The cancellation token. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)