# FilteringIdFieldAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the ID field to filter on a field. For example, if this attribute is placed on the EmployeeName field, EmployeeId can be the filtering field, so that values are filtered on the ID rather than the text value.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FilteringIdFieldAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [FilteringIdFieldAttribute](FilteringIdFieldAttribute/FilteringIdFieldAttribute.md)(…) | Specifies the ID field to filter on a field. For example, if this attribute is placed on the EmployeeName field, EmployeeId can be the filtering field, so that values are filtered on the ID rather than the text value. |
| [Value](FilteringIdFieldAttribute/Value.md) { get; } | Gets the filtering ID value. |

## Remarks

Initializes a new instance of the [`FilteringIdFieldAttribute`](FilteringIdFieldAttribute.md) class.

## See Also

* **Source:** *[FilteringIdFieldAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Filtering/FilteringIdFieldAttribute.cs)*