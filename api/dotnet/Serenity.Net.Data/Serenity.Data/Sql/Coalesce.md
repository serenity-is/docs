# Sql.Coalesce method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a COALESCE() expression.

```csharp
public static string Coalesce(params string[] statements)
```

| parameter | description |
| --- | --- |
| statements | The statements. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fields is null or empty |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Coalesce method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a COALESCE() expression while adding values to specified query as params.

```csharp
public static string Coalesce(this IQueryWithParams query, params object[] values)
```

| parameter | description |
| --- | --- |
| query | The query. |
| values | The values. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | values is null or empty |

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [Sql](../Sql.md)