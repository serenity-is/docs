# FilterableAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates if the field this attribute is placed on is filterable.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FilterableAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default) field is filterable. |

## Public Members

| name | description |
| --- | --- |
| [FilterableAttribute](FilterableAttribute/FilterableAttribute.md)(…) | Indicates if the field this attribute is placed on is filterable. |
| [Value](FilterableAttribute/Value.md) { get; } | Gets a value indicating whether this [`FilterableAttribute`](./FilterableAttribute.md) is enabled. |

## Remarks

Initializes a new instance of the [`FilterableAttribute`](./FilterableAttribute.md) class.

## See Also

* **Source:** *[FilterableAttribute.cs](https://github.com/serenity-is/Serenity/blob/d25d8234d5d47750c7fc36779de766d0541b2868/src/core/ComponentModel/Columns/Filtering/FilterableAttribute.cs)*