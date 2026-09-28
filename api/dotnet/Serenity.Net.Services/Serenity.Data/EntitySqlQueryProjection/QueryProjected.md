# EntitySqlQueryProjection.QueryProjected&lt;TRow,TResult&gt; method (1 of 6)

Executes the query and materializes each result row into the specified flat projection. The query must not already have SELECT columns. Each selector parameter must match one unambiguous row-fields source in the query, or sources can be supplied explicitly.

```csharp
public static IEnumerable<TResult> QueryProjected<TRow, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow, TResult>> projection, bool buffered = true, 
    IReadOnlyDictionary<string, object?>? parameters = null)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The row type of the projected source. |
| TResult | The flat projection result type. |
| query | The query to execute. |
| connection | The connection. |
| projection | A flat projection built from direct row field accesses. |
| buffered | Whether to buffer all results before returning. |
| parameters | Values that override the source query's parameters for this execution. |

## Return Value

The projected results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjected&lt;TRow,TResult&gt; method (2 of 6)

Executes a projection using the specified row-fields source aliases.

```csharp
public static IEnumerable<TResult> QueryProjected<TRow, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, bool buffered = true, 
    IReadOnlyDictionary<string, object?>? parameters = null)
    where TRow : class, IRow
```

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjected&lt;TRow1,TRow2,TResult&gt; method (3 of 6)

Executes the query and materializes each result row into the specified flat projection. When *buffered* is false, the data reader remains open until enumeration completes or the enumerator is disposed.

```csharp
public static IEnumerable<TResult> QueryProjected<TRow1, TRow2, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow1, TRow2, TResult>> projection, 
    bool buffered = true, IReadOnlyDictionary<string, object?>? parameters = null)
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
| buffered | Whether to buffer all results before returning. |
| parameters | Values that override the source query's parameters for this execution. |

## Return Value

The projected results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjected&lt;TRow1,TRow2,TResult&gt; method (4 of 6)

Executes a projection using the specified row-fields source aliases.

```csharp
public static IEnumerable<TResult> QueryProjected<TRow1, TRow2, TResult>(this SqlQuery query, 
    IDbConnection connection, Expression<Func<TRow1, TRow2, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, bool buffered = true, 
    IReadOnlyDictionary<string, object?>? parameters = null)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
```

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjected&lt;TRow1,TRow2,TRow3,TResult&gt; method (5 of 6)

Executes the query and materializes each result row into the specified flat projection. When *buffered* is false, the data reader remains open until enumeration completes or the enumerator is disposed.

```csharp
public static IEnumerable<TResult> QueryProjected<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, bool buffered = true, 
    IReadOnlyDictionary<string, object?>? parameters = null)
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
| buffered | Whether to buffer all results before returning. |
| parameters | Values that override the source query's parameters for this execution. |

## Return Value

The projected results.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.QueryProjected&lt;TRow1,TRow2,TRow3,TResult&gt; method (6 of 6)

Executes a projection using the specified row-fields source aliases.

```csharp
public static IEnumerable<TResult> QueryProjected<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, IDbConnection connection, 
    Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources, bool buffered = true, 
    IReadOnlyDictionary<string, object?>? parameters = null)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
    where TRow3 : class, IRow
```

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)