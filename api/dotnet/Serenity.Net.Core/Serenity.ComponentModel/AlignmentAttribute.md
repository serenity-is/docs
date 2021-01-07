# AlignmentAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls horizontal alignment of text (usually in grid columns).

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class AlignmentAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [Value](AlignmentAttribute/Value.md) { get; } | Gets/sets value of the alignment attribute |

## Protected Members

| name | description |
| --- | --- |
| [AlignmentAttribute](AlignmentAttribute/AlignmentAttribute.md)(…) | Creates a new AlignmentAttribute |

## Remarks

This is an abstract base class. You need to use AlignCenter or AlignRight attributes.

## See Also

* **Source:** *[AlignmentAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Alignment/AlignmentAttribute.cs)*