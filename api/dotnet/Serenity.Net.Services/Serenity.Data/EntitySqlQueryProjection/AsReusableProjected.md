# EntitySqlQueryProjection.AsReusableProjected&lt;TRow,TResult&gt; method (1 of 6)

Prepares a reusable flat projection. The source query must be a root query without existing SELECT columns.

```csharp
public static IProjectedQuery<TResult> AsReusableProjected<TRow, TResult>(this SqlQuery query, 
    Expression<Func<TRow, TResult>> projection)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The row type of the projected source. |
| TResult | The flat projection result type. |
| query | The query to prepare. |
| projection | A flat projection built from row field accesses or SQL expressions. |

## Return Value

A reusable projection that can be executed with different parameter values.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.AsReusableProjected&lt;TRow,TResult&gt; method (2 of 6)

Prepares a reusable projection using the specified row-fields source aliases.

```csharp
public static IProjectedQuery<TResult> AsReusableProjected<TRow, TResult>(this SqlQuery query, 
    Expression<Func<TRow, TResult>> projection, IReadOnlyList<RowFieldsBase> sources)
    where TRow : class, IRow
```

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)
* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.AsReusableProjected&lt;TRow1,TRow2,TResult&gt; method (3 of 6)

Prepares a reusable flat projection. The source query must be a root query without existing SELECT columns.

```csharp
public static IProjectedQuery<TResult> AsReusableProjected<TRow1, TRow2, TResult>(
    this SqlQuery query, Expression<Func<TRow1, TRow2, TResult>> projection)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
```

| parameter | description |
| --- | --- |
| TRow1 | The row type of the first projected source. |
| TRow2 | The row type of the second projected source. |
| TResult | The flat projection result type. |
| query | The query to prepare. |
| projection | A flat projection built from row field accesses or SQL expressions. |

## Return Value

A reusable projection that can be executed with different parameter values.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.AsReusableProjected&lt;TRow1,TRow2,TResult&gt; method (4 of 6)

Prepares a reusable projection using the specified row-fields source aliases.

```csharp
public static IProjectedQuery<TResult> AsReusableProjected<TRow1, TRow2, TResult>(
    this SqlQuery query, Expression<Func<TRow1, TRow2, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
```

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)
* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.AsReusableProjected&lt;TRow1,TRow2,TRow3,TResult&gt; method (5 of 6)

Prepares a reusable flat projection. The source query must be a root query without existing SELECT columns.

```csharp
public static IProjectedQuery<TResult> AsReusableProjected<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, Expression<Func<TRow1, TRow2, TRow3, TResult>> projection)
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
| query | The query to prepare. |
| projection | A flat projection built from row field accesses or SQL expressions. |

## Return Value

A reusable projection that can be executed with different parameter values.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)

---

# EntitySqlQueryProjection.AsReusableProjected&lt;TRow1,TRow2,TRow3,TResult&gt; method (6 of 6)

Prepares a reusable projection using the specified row-fields source aliases.

```csharp
public static IProjectedQuery<TResult> AsReusableProjected<TRow1, TRow2, TRow3, TResult>(
    this SqlQuery query, Expression<Func<TRow1, TRow2, TRow3, TResult>> projection, 
    IReadOnlyList<RowFieldsBase> sources)
    where TRow1 : class, IRow
    where TRow2 : class, IRow
    where TRow3 : class, IRow
```

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)
* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* interface [IRow](../IRow.md)
* class [EntitySqlQueryProjection](../EntitySqlQueryProjection.md)