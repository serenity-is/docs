# NavigationLinkAttribute class
**namespace:** *[Serenity.Navigation](../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

A navigation item with a link.

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class NavigationLinkAttribute : NavigationItemAttribute
```

## Public Members

| name | description |
| --- | --- |
| [NavigationLinkAttribute](NavigationLinkAttribute/NavigationLinkAttribute.md)(…) | Initializes a new instance of the [`NavigationLinkAttribute`](NavigationLinkAttribute.md) class. (4 constructors) |
| static [GetFeaturesFromController](NavigationLinkAttribute/GetFeaturesFromController.md)(…) | Tries to extract features from a controller action. |
| static [GetPermissionFromController](NavigationLinkAttribute/GetPermissionFromController.md)(…) | Tries to extract the permission from a controller action. |
| static [GetUrlFromController](NavigationLinkAttribute/GetUrlFromController.md)(…) | Tries to extract the URL from a controller action. |

## See Also

* class [NavigationItemAttribute](../Serenity.Net.Core/NavigationItemAttribute.md)
* **Source:** *[NavigationLinkAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Navigation/NavigationLinkAttribute.cs)*