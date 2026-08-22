# AlignRightAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Right aligns text horizontally (usually in a grid column).

```csharp
[AttributeUsage(AttributeTargets.All)]
public class AlignRightAttribute : AlignmentAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AlignRightAttribute](AlignRightAttribute/AlignRightAttribute.md)() | Creates a new AlignRightAttribute. |

## Remarks

Used for text alignment in grids by adding `align-right` CSS class to corresponding SleekGrid column. Note that it has no effect on editors or forms.

## See Also

* class [AlignmentAttribute](AlignmentAttribute.md)
* **Source:** *[AlignRightAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Columns/Alignment/AlignRightAttribute.cs)*