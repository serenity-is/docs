# EditLinkAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the property this attribute placed on should have an edit link

```csharp
[AttributeUsage(AttributeTargets.All)]
public sealed class EditLinkAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [EditLinkAttribute](EditLinkAttribute/EditLinkAttribute.md)() | Creates a new EditLink attribute |
| [EditLinkAttribute](EditLinkAttribute/EditLinkAttribute.md)(…) | Creates a new EditLink attribute with enable/disable option |
| [CssClass](EditLinkAttribute/CssClass.md) { get; set; } | Gets/sets optional css class to add to edit links |
| [IdField](EditLinkAttribute/IdField.md) { get; set; } | Gets/sets from which property this edit link should get its ID value to edit |
| [ItemType](EditLinkAttribute/ItemType.md) { get; set; } | Optional item type that this edit link should open. It should match the dialog namespace / class name. |
| [Value](EditLinkAttribute/Value.md) { get; } | Gets/sets edit link enable state |

## See Also

* **Source:** *[EditLinkAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/EditLinkAttribute.cs)*