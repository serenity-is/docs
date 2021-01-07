# LabelWidthAttribute.JustThis property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets or sets a value indicating whether this attribute shouldn't break effectiveness of another LabelWidth attribute with UntilNext flag. For example, if you set all fields to 100px by adding a [LabelWidth("100px", UntilNext = true)] attribute to the first property of a form, but just want to change one property in the middle to 200px, and if you add [LabelWidth("200px")] to that property, 100px would not apply to following ones. But if you did [LabelWidth("200px", JustThis = true)], 100px will still apply to following ones.

```csharp
public bool JustThis { get; set; }
```

## Property Value

`true` if it should break effectiveness of a prior LabelWidth attribute with UntilNext flag, otherwise, `false`.

## See Also

* class [LabelWidthAttribute](../LabelWidthAttribute.md)