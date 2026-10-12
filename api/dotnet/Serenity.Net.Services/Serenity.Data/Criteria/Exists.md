# Criteria.Exists method (1 of 3)

Creates a new EXISTS criteria from another criteria expression.

```csharp
public static BaseCriteria Exists(BaseCriteria expression)
```

| parameter | description |
| --- | --- |
| expression | The expression. |

## Return Value

A new EXISTS criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [Criteria](../Criteria.md)

---

# Criteria.Exists method (2 of 3)

Creates a new EXISTS criteria.

```csharp
public static BaseCriteria Exists(ISqlQuery query)
```

| parameter | description |
| --- | --- |
| query | The expression. Must share the same root query that the resulting criteria will be used in (usually built via that query's SubQuery() method); an unrelated query's parameters are not available to the outer query, so embedding it may produce completely invalid results. |

## Return Value

A new EXISTS criteria.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | query is an independent query with auto parameters. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* interface [ISqlQuery](../ISqlQuery.md)
* class [Criteria](../Criteria.md)

---

# Criteria.Exists method (3 of 3)

Creates a new EXISTS criteria.

```csharp
public static BaseCriteria Exists(string expression)
```

| parameter | description |
| --- | --- |
| expression | The expression. |

## Return Value

A new EXISTS criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [Criteria](../Criteria.md)