# SafeCriteriaValidator.VisitFunctionCall method

Visits an allowed function call criteria.

```csharp
protected override BaseCriteria VisitFunctionCall(FunctionCallCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |

## Return Value

The visited function call criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | Only UPPER with one field or string argument is supported. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [FunctionCallCriteria](../FunctionCallCriteria.md)
* class [SafeCriteriaValidator](../SafeCriteriaValidator.md)