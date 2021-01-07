# SafeCriteriaValidator.VisitParam method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Visits the parameter criteria. Parameter criteria is just a parameter name.

```csharp
protected override BaseCriteria VisitParam(ParamCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The parameter criteria. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | UnsupportedCriteriaType - Param type criterias is not supported! |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [ParamCriteria](../ParamCriteria.md)
* class [SafeCriteriaValidator](../SafeCriteriaValidator.md)