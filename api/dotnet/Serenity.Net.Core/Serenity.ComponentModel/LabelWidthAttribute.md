# LabelWidthAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Determines label with of target property, and optionally the properties following it until another of this attribute is used.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class LabelWidthAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [LabelWidthAttribute](LabelWidthAttribute/LabelWidthAttribute.md)(…) | Initializes a new instance of the [`LabelWidthAttribute`](LabelWidthAttribute.md) class. (2 constructors) |
| [JustThis](LabelWidthAttribute/JustThis.md) { get; set; } | Gets or sets a value indicating whether this attribute shouldn't break effectiveness of another LabelWidth attribute with UntilNext flag. For example, if you set all fields to 100px by adding a [LabelWidth("100px", UntilNext = true)] attribute to the first property of a form, but just want to change one property in the middle to 200px, and if you add [LabelWidth("200px")] to that property, 100px would not apply to following ones. But if you did [LabelWidth("200px", JustThis = true)], 100px will still apply to following ones. |
| [UntilNext](LabelWidthAttribute/UntilNext.md) { get; set; } | Gets or sets a value indicating whether this attribute should apply to following properties until next occurence of this attribute without JustThis flag. |
| [Value](LabelWidthAttribute/Value.md) { get; } | Gets the value. |

## See Also

* **Source:** *[LabelWidthAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/Layout/LabelWidthAttribute.cs)*