# BaseCriteriaVisitor class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

A visitor implementation for BaseCriteria object trees.

```csharp
public abstract class BaseCriteriaVisitor
```

## Protected Members

| name | description |
| --- | --- |
| [BaseCriteriaVisitor](BaseCriteriaVisitor/BaseCriteriaVisitor.md)() | Initializes a new instance of the [`BaseCriteriaVisitor`](BaseCriteriaVisitor.md) class. |
| virtual [Visit](BaseCriteriaVisitor/Visit.md)(…) | Visits the specified criteria. |
| virtual [VisitBinary](BaseCriteriaVisitor/VisitBinary.md)(…) | Visits the binary criteria. Binary criteria is one with two operands and an operator between. |
| virtual [VisitCriteria](BaseCriteriaVisitor/VisitCriteria.md)(…) | Visits the criteria returning potentially reworked version. |
| virtual [VisitParam](BaseCriteriaVisitor/VisitParam.md)(…) | Visits the parameter criteria. Parameter criteria is just a parameter name. |
| virtual [VisitUnary](BaseCriteriaVisitor/VisitUnary.md)(…) | Visits the unary criteria. Unary criteria is one with one operand and one operator. |
| virtual [VisitValue](BaseCriteriaVisitor/VisitValue.md)(…) | Visits the value criteria. Value criteria is just a constant value. |

## See Also

* **Source:** *[BaseCriteriaVisitor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Criteria/BaseCriteriaVisitor.cs)*