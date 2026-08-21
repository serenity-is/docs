# Sql.Coalesce method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a COALESCE() expression.

```csharp
public static string Coalesce(params string[] statements)
```

| parameter | description |
| --- | --- |
| statements | The statements. |

## Return Value

The COALESCE() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fields is null or empty. |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Coalesce method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a COALESCE() expression while adding values to the specified query as parameters.

```csharp
public static string Coalesce(this IQueryWithParams query, params object[] values)
```

| parameter | description |
| --- | --- |
| query | The query. |
| values | The values. |

## Return Value

The COALESCE() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | values is null or empty. |

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [Sql](../Sql.md)