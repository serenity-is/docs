# NavigationItemAttribute class
**namespace:** *[Serenity.Navigation](../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public abstract class NavigationItemAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [Category](NavigationItemAttribute/Category.md) { get; set; } | This is full path of its parent, e.g. A/B for A/B/C |
| [FullPath](NavigationItemAttribute/FullPath.md) { get; set; } | The full path to navigation item like A/B/C This is used to generate local text key for this item like Navigation.A/B/C |
| [IconClass](NavigationItemAttribute/IconClass.md) { get; set; } | Icon class |
| [ItemClass](NavigationItemAttribute/ItemClass.md) { get; set; } | Extra css class to apply to its navigation element e.g. LI |
| [Order](NavigationItemAttribute/Order.md) { get; set; } | Gets / sets the order (only) among its siblings. |
| [Permission](NavigationItemAttribute/Permission.md) { get; set; } | Permission required to view this navigation item |
| [Target](NavigationItemAttribute/Target.md) { get; set; } | Window target to open this link, e.g. _blank etc. |
| [Title](NavigationItemAttribute/Title.md) { get; set; } | Title of the navigation item. It is the part after last slash, e.g. C for A/B/C |
| [Url](NavigationItemAttribute/Url.md) { get; set; } | Url of this navigation item, should be null for menu |
| static [GetPermissionFromController](NavigationItemAttribute/GetPermissionFromController.md)(…) |  |
| static [GetUrlFromController](NavigationItemAttribute/GetUrlFromController.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [NavigationItemAttribute](NavigationItemAttribute/NavigationItemAttribute.md)(…) |  (2 constructors) |

## See Also

* **Source:** *[NavigationItemAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Navigation/NavigationItemAttribute.cs)*