# NavigationItem class
**namespace:** *[Serenity.Navigation](../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A node in a navigation tree model.

```csharp
public class NavigationItem
```

## Public Members

| name | description |
| --- | --- |
| [NavigationItem](NavigationItem/NavigationItem.md)() | The default constructor. |
| [Children](NavigationItem/Children.md) { get; } | List of children |
| [FullPath](NavigationItem/FullPath.md) { get; set; } | Full path of the item |
| [IconClass](NavigationItem/IconClass.md) { get; set; } | Icon class |
| [IsSection](NavigationItem/IsSection.md) { get; set; } | True if this is a navigation section |
| [ItemClass](NavigationItem/ItemClass.md) { get; set; } | Item class |
| [Order](NavigationItem/Order.md) { get; set; } | Effective order among siblings. Unlike the declared `Order` on [`NavigationItemAttribute`](./NavigationItemAttribute.md) (which may be assigned from an Int32 in an assembly attribute), this is a Decimal so that duplicate declared orders can be resolved to unique values (see `NavigationHelper.HealOrders`), and so consumers (e.g. a CMS inserting dynamic pages into the menu) can compute a midpoint between two siblings. |
| [Parent](NavigationItem/Parent.md) { get; set; } | Parent navigation item |
| [Target](NavigationItem/Target.md) { get; set; } | Target window to open the link, e.g. "_blank" |
| [Title](NavigationItem/Title.md) { get; set; } | Title |
| [Url](NavigationItem/Url.md) { get; set; } | URL |

## See Also

* **Source:** *[NavigationItem.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Navigation/NavigationItem.cs)*