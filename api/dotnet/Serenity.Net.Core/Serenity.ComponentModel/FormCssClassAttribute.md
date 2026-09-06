# FormCssClassAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the CSS class for the field on forms only.

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
| [FormCssClassAttribute](FormCssClassAttribute/FormCssClassAttribute.md)(…) | Sets the CSS class for the field on forms only. |
| [UntilNext](FormCssClassAttribute/UntilNext.md) { get; set; } | Applies this form CSS class to all following fields until another FormCssClass attribute. |
| [Value](FormCssClassAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`FormCssClassAttribute`](./FormCssClassAttribute.md) class.

## See Also

* **Source:** *[FormCssClassAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/Layout/FormCssClassAttribute.cs)*