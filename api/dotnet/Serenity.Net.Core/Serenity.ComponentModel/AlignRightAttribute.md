# AlignRightAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Right aligns text horizontally (usually in a grid column)

```csharp
[AttributeUsage(AttributeTargets.All)]
public class AlignRightAttribute : AlignmentAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AlignRightAttribute](AlignRightAttribute/AlignRightAttribute.md)() | Creates a new AlignRight attribute |

## Remarks

Used for text alignment in grids by adding `align-center` CSS class to corresponding SlickGrid column. Note that it has no effect on editors or forms.

## See Also

* class [AlignmentAttribute](AlignmentAttribute.md)
* **Source:** *[AlignRightAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Alignment/AlignRightAttribute.cs)*