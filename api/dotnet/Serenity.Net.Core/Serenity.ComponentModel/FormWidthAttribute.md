# FormWidthAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets CSS class for field on forms only. Useful for Bootstrap grid, e.g. col-md-4 etc.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FormWidthAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FormWidthAttribute](FormWidthAttribute/FormWidthAttribute.md)() | Creates a FormWidth attribute with no initial column classes. Make sure to set properties to make it useful. |
| [FormWidthAttribute](FormWidthAttribute/FormWidthAttribute.md)(…) | Creates a FormWidth attribute with given custom css class, like col-md-6 col-sm-4 etc. |
| [JustThis](FormWidthAttribute/JustThis.md) { get; set; } | Applies this form width (e.g. bootstrap grid size) to just current field and doesn't cancel prior form width attribute with a UntilNext attribute. Don't set UntilNext = true if you set JustThis = true, as they are exclusive |
| [Large](FormWidthAttribute/Large.md) { get; set; } | Gets / sets cols (1..12) in large devices (width &gt;= 1200px, large desktops) |
| [Medium](FormWidthAttribute/Medium.md) { get; set; } | Gets / sets cols (1..12) in medium devices (width &gt;= 992px, medium desktops) |
| [Small](FormWidthAttribute/Small.md) { get; set; } | Gets / sets cols (1..12) in small devices (width &gt;= 768px, tablets) |
| [UntilNext](FormWidthAttribute/UntilNext.md) { get; set; } | Applies this form width (e.g. bootstrap grid size) to all following fields until next another FormWidth attribute |
| [Value](FormWidthAttribute/Value.md) { get; protected set; } | Gets the css class that will be applied to field |
| [XSmall](FormWidthAttribute/XSmall.md) { get; set; } | Gets / sets cols (1..12) in extra small devices (width &lt; 768px, mobile phones) |

## See Also

* **Source:** *[FormWidthAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/Layout/FormWidthAttribute.cs)*