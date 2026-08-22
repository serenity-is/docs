# EditLinkAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the property this attribute is placed on should have an edit link.

```csharp
[AttributeUsage(AttributeTargets.All)]
public sealed class EditLinkAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [EditLinkAttribute](EditLinkAttribute/EditLinkAttribute.md)() | Creates a new EditLinkAttribute. |
| [EditLinkAttribute](EditLinkAttribute/EditLinkAttribute.md)(…) | Creates a new EditLinkAttribute with enable/disable option. |
| [CssClass](EditLinkAttribute/CssClass.md) { get; set; } | Gets or sets the optional CSS class to add to edit links. |
| [IdField](EditLinkAttribute/IdField.md) { get; set; } | Gets or sets the property from which this edit link should get its ID value to edit. |
| [ItemType](EditLinkAttribute/ItemType.md) { get; set; } | Optional item type that this edit link should open. It should match the dialog namespace / class name. |
| [Value](EditLinkAttribute/Value.md) { get; } | Gets or sets the edit link enable state. |

## See Also

* **Source:** *[EditLinkAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Columns/EditLinkAttribute.cs)*