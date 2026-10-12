# Sql.Coalesce method (1 of 2)

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
| ArgumentNullException | statements is null or empty. |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Coalesce method (2 of 2)

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
| InvalidOperationException | A value is a query with auto parameters outside *query*'s parameter storage. |

## Remarks

Embedded queries are rendered as text only: their parameters are not merged. Pass queries sharing this query's parameter storage (e.g. via SubQuery()), instead of standalone queries. Independent queries without parameters are safe to embed.

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [Sql](../Sql.md)