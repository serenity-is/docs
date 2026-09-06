# BaseCriteriaVisitor.Visit method

Visits the specified criteria.

```csharp
protected virtual BaseCriteria Visit(BaseCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |

## Return Value

The visited criteria, which may be a reworked version.

## Exceptions

| exception | condition |
| --- | --- |
| Exception | Criteria type is unknown. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [BaseCriteriaVisitor](../BaseCriteriaVisitor.md)