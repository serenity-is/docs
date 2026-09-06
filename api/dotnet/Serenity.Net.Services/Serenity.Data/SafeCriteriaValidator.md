# SafeCriteriaValidator class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

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
| override [VisitCriteria](SafeCriteriaValidator/VisitCriteria.md)(…) | Visits the criteria, returning a potentially reworked version. |
| override [VisitParam](SafeCriteriaValidator/VisitParam.md)(…) | Visits the parameter criteria. A parameter criteria is just a parameter name. |

## See Also

* class [BaseCriteriaVisitor](./BaseCriteriaVisitor.md)
* **Source:** *[SafeCriteriaValidator.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Criteria/SafeCriteriaValidator.cs)*