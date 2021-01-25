# EntityConnectionExtensions.TryById&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Tries to finds an entity by its ID value. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static TRow TryById<TRow>(this IDbConnection connection, object id)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |

## Return Value

Entity with given ID, or null if not found

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Multiple records with the ID found |

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.TryById&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Tries to find an entity by its ID value. This method does not select any fields by default and allows you to edit the query to select fields you want.

```csharp
public static TRow TryById<TRow>(this IDbConnection connection, object id, 
    Action<SqlQuery> editQuery)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |
| editQuery | Callback to edit the query. |

## Return Value

Entity with given ID, or null if not found

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Multiple records with the ID found |

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)