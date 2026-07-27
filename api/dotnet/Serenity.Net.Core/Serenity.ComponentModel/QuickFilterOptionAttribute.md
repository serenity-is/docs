# QuickFilterOptionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Add an option to the quick filtering.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public class QuickFilterOptionAttribute : Attribute
```

| parameter | description |
| --- | --- |
| key | The key. |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [QuickFilterOptionAttribute](QuickFilterOptionAttribute/QuickFilterOptionAttribute.md)(…) | Add an option to the quick filtering. |
| [Key](QuickFilterOptionAttribute/Key.md) { get; } | Gets the key of the quick filter option. |
| [Value](QuickFilterOptionAttribute/Value.md) { get; } | Gets the value of the quick filter option. |

## Remarks

Initializes a new instance of the [`QuickFilterOptionAttribute`](QuickFilterOptionAttribute.md) class.

## See Also

* **Source:** *[QuickFilterOptionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Filtering/QuickFilterOptionAttribute.cs)*