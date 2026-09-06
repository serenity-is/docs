# SafeCriteriaValidator.VisitCriteria method

Visits the criteria, returning a potentially reworked version.

```csharp
protected override BaseCriteria VisitCriteria(Criteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |

## Return Value

The visited criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | InvalidCriteriaField |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [Criteria](../Criteria.md)
* class [SafeCriteriaValidator](../SafeCriteriaValidator.md)