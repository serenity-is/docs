# EntityConnectionExtensions.ByIdAsync&lt;TRow&gt; method (1 of 2)

Asynchronously finds an entity by its ID value. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static Task<TRow> ByIdAsync<TRow>(this IDbConnection connection, object id, 
    CancellationToken cancellationToken = default)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the entity with the given ID.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | Record with the specified ID is not found. |
| InvalidOperationException | Multiple records with the ID found. |

## See Also

* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.ByIdAsync&lt;TRow&gt; method (2 of 2)

Asynchronously finds an entity by its ID value. This method does not select any fields by default and allows you to edit the query to select fields you want.

```csharp
public static Task<TRow> ByIdAsync<TRow>(this IDbConnection connection, object id, 
    Action<SqlQuery> editQuery, CancellationToken cancellationToken = default)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |
| editQuery | Callback to edit the query. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the entity with the given ID.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | Record with the specified ID is not found. |
| InvalidOperationException | Multiple records with the ID found. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)