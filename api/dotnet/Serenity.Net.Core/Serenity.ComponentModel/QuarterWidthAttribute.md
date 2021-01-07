# QuarterWidthAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Marks form field with "col-lg-3 col-sm-6" css class, which makes it allocate half of form row on device widths &gt;= 768 (e.g. ipad), and quarter on device widths &gt;= 1200px (desktop)

```csharp
[AttributeUsage(AttributeTargets.All)]
public class QuarterWidthAttribute : FormWidthAttribute
```

## Public Members

| name | description |
| --- | --- |
| [QuarterWidthAttribute](QuarterWidthAttribute/QuarterWidthAttribute.md)() | Initializes a new instance of the [`QuarterWidthAttribute`](QuarterWidthAttribute.md) class. |

## See Also

* class [FormWidthAttribute](FormWidthAttribute.md)
* **Source:** *[QuarterWidthAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/Layout/QuarterWidthAttribute.cs)*