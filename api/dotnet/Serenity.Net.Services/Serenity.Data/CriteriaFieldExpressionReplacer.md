# CriteriaFieldExpressionReplacer class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Converts field names in a criteria to their corresponding SQL field expressions.

```csharp
public class CriteriaFieldExpressionReplacer : SafeCriteriaValidator
```

## Public Members

| name | description |
| --- | --- |
| [CriteriaFieldExpressionReplacer](CriteriaFieldExpressionReplacer/CriteriaFieldExpressionReplacer.md)(…) | Creates an instance of the class |
| [Process](CriteriaFieldExpressionReplacer/Process.md)(…) | Visits the criteria for conversion and returns a processed criteria containing replaced field expressions. |

## Protected Members

| name | description |
| --- | --- |
| [Row](CriteriaFieldExpressionReplacer/Row.md) { get; } | The row instance |
| virtual [CanFilterField](CriteriaFieldExpressionReplacer/CanFilterField.md)(…) | Virtual method to check if a Field can be filtered. |
| virtual [FindField](CriteriaFieldExpressionReplacer/FindField.md)(…) | Finds a field by its property name or field name |
| override [VisitBinary](CriteriaFieldExpressionReplacer/VisitBinary.md)(…) |  |
| override [VisitCriteria](CriteriaFieldExpressionReplacer/VisitCriteria.md)(…) |  |

## See Also

* class [SafeCriteriaValidator](../Serenity.Net.Data/SafeCriteriaValidator.md)
* **Source:** *[CriteriaFieldExpressionReplacer.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Helpers/CriteriaFieldExpressionReplacer.cs)*