# Sql.Case method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a CASE() expression.

```csharp
public static string Case(this IQueryWithParams query, Action<CaseBuilder> builder)
```

| parameter | description |
| --- | --- |
| query | The query. |
| builder | The action which will receive CASE statement builder. |

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [CaseBuilder](../Sql.CaseBuilder.md)
* class [Sql](../Sql.md)

---

# Sql.Case method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Builds a CASE statement.

```csharp
public static string Case(string condition, string[] whenThenPairs, string elseStatement)
```

| parameter | description |
| --- | --- |
| condition | Optional condition. For example for statement "CASE Field1 WHEN 1 THEN 2 END", condition would be "Field1" |
| whenThenPairs | Pairs of WHEN/THEN statements like ["A = 1", "'Result1'", "A = 2", "'Result2'"] for a case statement like CASE WHEN A = 1 THEN 'Result1' WHEN A = 2 THEN 'Result2' END. |
| elseStatement | Optional ELSE statement |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | whenThenPairs is empty or contains odd number of elements |

## See Also

* class [Sql](../Sql.md)