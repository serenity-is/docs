# EntitySqlQueryProjection.QueryProjectedAsync&lt;TRow,TResult&gt; method (1 of 6)

Asynchronously streams the flat projection results. The data reader remains open until enumeration completes, is cancelled, or the async enumerator is disposed.

```csharp
public static IAsyncEnumerable<TResult> QueryProjectedAsync<TRow, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow, TResult>> projection, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
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
| cancellationToken | The cancellation token. |

## Return Value

An asynchronous stream of projected results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjectedAsync&lt;TRow,TResult&gt; method (2 of 6)

Streams a projection asynchronously using the specified row-fields source aliases.

```csharp
public static IAsyncEnumerable<TResult> QueryProjectedAsync<TRow, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
    where TRow : class, IRow
```

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjectedAsync&lt;TRow1,TRow2,TResult&gt; method (3 of 6)

Asynchronously streams the flat projection results. The data reader remains open until enumeration completes, is cancelled, or the async enumerator is disposed.

```csharp
public static IAsyncEnumerable<TResult> QueryProjectedAsync<TRow1, TRow2, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TResult>> projection, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
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
| cancellationToken | The cancellation token. |

## Return Value

An asynchronous stream of projected results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjectedAsync&lt;TRow1,TRow2,TResult&gt; method (4 of 6)

Streams a projection asynchronously using the specified row-fields source aliases.

```csharp
public static IAsyncEnumerable<TResult> QueryProjectedAsync<TRow1, TRow2, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TResult>> projection, IReadOnlyList<RowFieldsBase> sources, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
```

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjectedAsync&lt;TRow1,TRow2,TRow3,TResult&gt; method (5 of 6)

Asynchronously streams the flat projection results. The data reader remains open until enumeration completes, is cancelled, or the async enumerator is disposed.

```csharp
public static IAsyncEnumerable<TResult> QueryProjectedAsync<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
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
| cancellationToken | The cancellation token. |

## Return Value

An asynchronous stream of projected results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjectedAsync&lt;TRow1,TRow2,TRow3,TResult&gt; method (6 of 6)

Streams a projection asynchronously using the specified row-fields source aliases.

```csharp
public static IAsyncEnumerable<TResult> QueryProjectedAsync<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
    where TRow3 : class, IRow
```

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)