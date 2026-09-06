# EntityConnectionExtensions.ListAsync&lt;TRow&gt; method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously lists all records. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static Task<List<TRow>> ListAsync<TRow>(this IDbConnection connection, 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is all records.

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.ListAsync&lt;TRow&gt; method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously lists the records, allowing the caller to specify criteria and set of fields to select through an editQuery callback.

```csharp
public static Task<List<TRow>> ListAsync<TRow>(this IDbConnection connection, 
    Action<SqlQuery> editQuery, CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The edit query callback. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the list of records matching the edited query.

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.ListAsync&lt;TRow&gt; method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously lists the records matching specified where criteria. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static Task<List<TRow>> ListAsync<TRow>(this IDbConnection connection, ICriteria where, 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the records matching the specified criteria.

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)