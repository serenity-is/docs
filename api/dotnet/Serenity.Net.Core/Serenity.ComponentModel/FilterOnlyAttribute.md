# FilterOnlyAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this field should not be shown, and could not be made visible in column selection dialog, but only used for advanced filtering.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FilterOnlyAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default) indicates this field is filter only. |

## Public Members

| name | description |
| --- | --- |
| [FilterOnlyAttribute](FilterOnlyAttribute/FilterOnlyAttribute.md)(…) | Indicates that this field should not be shown, and could not be made visible in column selection dialog, but only used for advanced filtering. |
| [Value](FilterOnlyAttribute/Value.md) { get; } | Gets a value indicating whether this [`FilterOnlyAttribute`](FilterOnlyAttribute.md) is enabled. |

## Remarks

Initializes a new instance of the [`FilterOnlyAttribute`](FilterOnlyAttribute.md) class.

## See Also

* **Source:** *[FilterOnlyAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Filtering/FilterOnlyAttribute.cs)*