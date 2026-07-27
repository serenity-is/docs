# PinColumnAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Pins column to the start (left for LTR, right for RTL) or end (right for LTR, left for RTL) side of the grid. Note that pinning a column requires FrozenLayout or EnhancedLayout. Only EnhancedLayout supports pinning to end side.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class PinColumnAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [PinColumnAttribute](PinColumnAttribute/PinColumnAttribute.md)(…) | Creates a new PinColumnAttribute for specified side: "start" (or "left") or "end" (or "right"). (2 constructors) |
| [Value](PinColumnAttribute/Value.md) { get; } | The pin value: "start" (left), "end" (right) or null (not pinned). |

## See Also

* **Source:** *[PinColumnAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Pinning/PinColumnAttribute.cs)*