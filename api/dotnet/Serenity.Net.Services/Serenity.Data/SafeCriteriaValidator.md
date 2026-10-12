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
| override [VisitFunctionCall](SafeCriteriaValidator/VisitFunctionCall.md)(…) | Visits an allowed function call criteria. |
| override [VisitParam](SafeCriteriaValidator/VisitParam.md)(…) | Visits the parameter criteria. A parameter criteria is just a parameter name. |
| override [VisitValue](SafeCriteriaValidator/VisitValue.md)(…) | Visits the value criteria. |

## Remarks

This validator is intended for criteria supplied by clients, such as criteria deserialized from a `ListRequest`. A criteria instance does not indicate whether it came from JSON or was constructed by application code, so the same restrictions apply in either case. This is not a validator for every criteria expression the framework can generate: aliases (e.g. `T0.Name`), quoted identifiers, and free-form expressions such as `1=1` are intentionally rejected, even when they are otherwise valid framework criteria.

## See Also

* class [BaseCriteriaVisitor](./BaseCriteriaVisitor.md)
* **Source:** *[SafeCriteriaValidator.cs](https://github.com/serenity-is/Serenity/blob/3c72e3a995e5b7f20c5dd207ea34da4e838509d6/src/services/Data/Criteria/SafeCriteriaValidator.cs)*