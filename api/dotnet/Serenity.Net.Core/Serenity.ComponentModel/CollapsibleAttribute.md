# CollapsibleAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Used to specify a target is collapsible. Commonly used with form categories to make them collapsible.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class CollapsibleAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [CollapsibleAttribute](CollapsibleAttribute/CollapsibleAttribute.md)(…) | Initializes a new instance of the [`CollapsibleAttribute`](CollapsibleAttribute.md) class. |
| [Collapsed](CollapsibleAttribute/Collapsed.md) { get; set; } | Gets or sets a value indicating whether the target is initially collapsed. Default is false. |
| [Value](CollapsibleAttribute/Value.md) { get; } | Gets a value indicating whether this [`CollapsibleAttribute`](CollapsibleAttribute.md) is value. |

## See Also

* **Source:** *[CollapsibleAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/CollapsibleAttribute.cs)*