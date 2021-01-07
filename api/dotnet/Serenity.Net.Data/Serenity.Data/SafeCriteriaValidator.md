# SafeCriteriaValidator class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Validates a criteria for allowed field names, operators and SQL injection safety

```csharp
public class SafeCriteriaValidator : BaseCriteriaVisitor
```

## Public Members

| name | description |
| --- | --- |
| [SafeCriteriaValidator](SafeCriteriaValidator/SafeCriteriaValidator.md)() | The default constructor. |
| [Validate](SafeCriteriaValidator/Validate.md)(…) | Validates the specified criteria. |

## Protected Members

| name | description |
| --- | --- |
| override [VisitCriteria](SafeCriteriaValidator/VisitCriteria.md)(…) | Visits the criteria returning potentially reworked version. |
| override [VisitParam](SafeCriteriaValidator/VisitParam.md)(…) | Visits the parameter criteria. Parameter criteria is just a parameter name. |

## See Also

* class [BaseCriteriaVisitor](BaseCriteriaVisitor.md)
* **Source:** *[SafeCriteriaValidator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Criteria/SafeCriteriaValidator.cs)*