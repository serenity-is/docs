# FormWidthAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the CSS class for the field on forms only. Useful for Bootstrap grid, e.g. col-md-4 etc.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FormWidthAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FormWidthAttribute](FormWidthAttribute/FormWidthAttribute.md)() | Creates a FormWidth attribute with no initial column classes. Make sure to set properties to make it useful. |
| [FormWidthAttribute](FormWidthAttribute/FormWidthAttribute.md)(…) | Creates a FormWidth attribute with given custom css class, like col-md-6 col-sm-4 etc. |
| [JustThis](FormWidthAttribute/JustThis.md) { get; set; } | Applies this form width (e.g. bootstrap grid size) to just the current field and doesn't cancel a prior form width attribute with an UntilNext attribute. Don't set UntilNext = true if you set JustThis = true, as they are exclusive. |
| [Large](FormWidthAttribute/Large.md) { get; set; } | Gets or sets the number of columns (1..12) in large devices (width &gt;= 1200px, large desktops). |
| [Medium](FormWidthAttribute/Medium.md) { get; set; } | Gets or sets the number of columns (1..12) in medium devices (width &gt;= 992px, medium desktops). |
| [Small](FormWidthAttribute/Small.md) { get; set; } | Gets or sets the number of columns (1..12) in small devices (width &gt;= 768px, tablets). |
| [UntilNext](FormWidthAttribute/UntilNext.md) { get; set; } | Applies this form width (e.g. bootstrap grid size) to all following fields until another FormWidth attribute. |
| [Value](FormWidthAttribute/Value.md) { get; protected set; } | Gets the CSS class that will be applied to the field. |
| [XSmall](FormWidthAttribute/XSmall.md) { get; set; } | Gets or sets the number of columns (1..12) in extra small devices (width &lt; 768px, mobile phones). |

## See Also

* **Source:** *[FormWidthAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/Layout/FormWidthAttribute.cs)*