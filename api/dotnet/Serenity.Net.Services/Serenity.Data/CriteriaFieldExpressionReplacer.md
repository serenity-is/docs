# CriteriaFieldExpressionReplacer class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Converts field names in a criteria to their corresponding SQL field expressions.

```csharp
public class CriteriaFieldExpressionReplacer : SafeCriteriaValidator
```

| parameter | description |
| --- | --- |
| row | The row instance |
| permissions | Permission service |
| lookupAccessMode | Use lookup access mode. In the lookup access mode only the lookup fields can be used in the filter. Default is false. |
| dialect | Optional dialect |
| toCriteria | Optional field to criteria converter |

## Public Members

| name | description |
| --- | --- |
| [CriteriaFieldExpressionReplacer](CriteriaFieldExpressionReplacer/CriteriaFieldExpressionReplacer.md)(…) | Converts field names in a criteria to their corresponding SQL field expressions. |
| [Process](CriteriaFieldExpressionReplacer/Process.md)(…) | Visits the criteria for conversion and returns a processed criteria containing replaced field expressions. |

## Protected Members

| name | description |
| --- | --- |
| [Dialect](CriteriaFieldExpressionReplacer/Dialect.md) { get; } | Gets the dialect passed in or the default dialect. |
| [Row](CriteriaFieldExpressionReplacer/Row.md) { get; } | Gets the row instance. |
| virtual [CanFilterField](CriteriaFieldExpressionReplacer/CanFilterField.md)(…) | Virtual method to check if a Field can be filtered. |
| virtual [FindField](CriteriaFieldExpressionReplacer/FindField.md)(…) | Finds a field by its property name or field name |
| virtual [ToCriteria](CriteriaFieldExpressionReplacer/ToCriteria.md)(…) | Converts field to criteria |
| override [VisitBinary](CriteriaFieldExpressionReplacer/VisitBinary.md)(…) |  |
| override [VisitCriteria](CriteriaFieldExpressionReplacer/VisitCriteria.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *row* or *permissions* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [SafeCriteriaValidator](SafeCriteriaValidator.md)
* **Source:** *[CriteriaFieldExpressionReplacer.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Helpers/CriteriaFieldExpressionReplacer.cs)*