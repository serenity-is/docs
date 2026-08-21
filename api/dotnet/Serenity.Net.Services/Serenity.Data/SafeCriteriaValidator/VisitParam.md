# SafeCriteriaValidator.VisitParam method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Visits the parameter criteria. A parameter criteria is just a parameter name.

```csharp
protected override BaseCriteria VisitParam(ParamCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The parameter criteria. |

## Return Value

The visited parameter criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | UnsupportedCriteriaType - Param type criterias is not supported! |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [ParamCriteria](../ParamCriteria.md)
* class [SafeCriteriaValidator](../SafeCriteriaValidator.md)