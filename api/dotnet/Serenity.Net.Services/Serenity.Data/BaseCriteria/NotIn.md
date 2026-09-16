# BaseCriteria.NotIn method (1 of 3)

Creates a new binary NOT IN criteria containing this criteria as the left operand.

```csharp
public BaseCriteria NotIn(BaseCriteria statement)
```

| parameter | description |
| --- | --- |
| statement | The statement. |

## Return Value

A new binary NOT IN criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | statement is null or empty |

## Remarks

The statement criteria is used as is, without adding parentheses around it. Use the [`NotIn`](./NotIn.md) overload for subqueries, which wraps the query in parentheses, or include them in the criteria expression.

## See Also

* class [BaseCriteria](../BaseCriteria.md)

---

# BaseCriteria.NotIn method (2 of 3)

Creates a new binary NOT IN criteria containing this criteria as the left operand.

```csharp
public BaseCriteria NotIn(ISqlQuery statement)
```

| parameter | description |
| --- | --- |
| statement | The statement query. |

## Return Value

A new binary NOT IN criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | statement is null |

## Remarks

Subqueries created via [`SubQuery`](../SqlQuery/SubQuery.md) already enclose themselves in parenthesis while rendering, so the statement is only wrapped in parenthesis when the query would render without them.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [BaseCriteria](../BaseCriteria.md)

---

# BaseCriteria.NotIn&lt;T&gt; method (3 of 3)

Creates a new binary NOT IN criteria containing this criteria as the left operand.

```csharp
public BaseCriteria NotIn<T>(params T[] values)
```

| parameter | description |
| --- | --- |
| T | The type of values. |
| values | The values. |

## Return Value

A new binary NOT IN criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | values is null or zero length array |

## See Also

* class [BaseCriteria](../BaseCriteria.md)