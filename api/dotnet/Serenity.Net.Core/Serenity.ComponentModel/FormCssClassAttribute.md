# FormCssClassAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets CSS class for field on forms only.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FormCssClassAttribute : Attribute
```

| parameter | description |
| --- | --- |
| cssClass | The CSS class. |

## Public Members

| name | description |
| --- | --- |
| [FormCssClassAttribute](FormCssClassAttribute/FormCssClassAttribute.md)(…) | Sets CSS class for field on forms only. |
| [UntilNext](FormCssClassAttribute/UntilNext.md) { get; set; } | Applies this form css class to all following fields until next another FormCssClass attribute |
| [Value](FormCssClassAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`FormCssClassAttribute`](FormCssClassAttribute.md) class.

## See Also

* **Source:** *[FormCssClassAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/Layout/FormCssClassAttribute.cs)*