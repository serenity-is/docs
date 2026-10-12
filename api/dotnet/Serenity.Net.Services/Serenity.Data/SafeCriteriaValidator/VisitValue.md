# SafeCriteriaValidator.VisitValue method

Visits the value criteria.

```csharp
protected override BaseCriteria VisitValue(ValueCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |

## Return Value

The visited value criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | UnsupportedCriteriaType - Criteria values can't contain nested criteria! |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [ValueCriteria](../ValueCriteria.md)
* class [SafeCriteriaValidator](../SafeCriteriaValidator.md)