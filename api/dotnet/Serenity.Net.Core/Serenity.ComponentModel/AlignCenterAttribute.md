# AlignCenterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Centers text horizontally (usually in a grid column).

```csharp
[AttributeUsage(AttributeTargets.All)]
public class AlignCenterAttribute : AlignmentAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AlignCenterAttribute](AlignCenterAttribute/AlignCenterAttribute.md)() | Creates a new AlignCenterAttribute |

## Remarks

Used for text alignment in grids by adding `align-center` CSS class to corresponding SlickGrid column. Note that it has no effect on editors or forms.

## See Also

* class [AlignmentAttribute](AlignmentAttribute.md)
* **Source:** *[AlignCenterAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Alignment/AlignCenterAttribute.cs)*