# FilteringIdFieldAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies ID field to filter on a field. For example, if this attribute is placed on EmployeeName field, EmployeeId can be the filtering field, so that values are filtered on ID not text value.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FilteringIdFieldAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FilteringIdFieldAttribute](FilteringIdFieldAttribute/FilteringIdFieldAttribute.md)(…) | Initializes a new instance of the [`FilteringIdFieldAttribute`](FilteringIdFieldAttribute.md) class. |
| [Value](FilteringIdFieldAttribute/Value.md) { get; } | Gets the filtering ID value. |

## See Also

* **Source:** *[FilteringIdFieldAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Filtering/FilteringIdFieldAttribute.cs)*