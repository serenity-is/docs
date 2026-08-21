# NavigationHelper class
**namespace:** *[Serenity.Navigation](../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains helper methods for navigation models and items.

```csharp
public class NavigationHelper
```

## Public Members

| name | description |
| --- | --- |
| [NavigationHelper](NavigationHelper/NavigationHelper.md)() | The default constructor. |
| static [ByCategory](NavigationHelper/ByCategory.md)(…) | Creates a lookup of navigation item attributes by their category. |
| static [ConvertToNavigationItems](NavigationHelper/ConvertToNavigationItems.md)(…) | Converts a list of NavigationItemAttribute objects to a list of NavigationItem classes. |
| static [GetNavigationItems](NavigationHelper/GetNavigationItems.md)(…) | Gets navigation items. |
| static [HealOrders](NavigationHelper/HealOrders.md)(…) | Resolves duplicate order values among a set of siblings into unique decimal values, e.g. so that statically declared navigation items (whose Int32 order may collide, as it is only guaranteed unique by developer convention, not enforced) get distinct sort keys that a consumer (e.g. a CMS module) can also use to compute a midpoint when inserting new items between them. This only changes orders for items that actually collide with another sibling; non-colliding orders (other than *sentinel*, see below) are returned unchanged, and within a group of colliding siblings, the first one (in the order it was given) also keeps its original value, minimizing the number of altered orders. Any order equal to *sentinel* (the code generator's default, meaning "not explicitly set") is never left as-is: it is always resolved to *parentOrder* (or the largest real sibling order, if there is one) plus a multiple of *step*, so a forgotten order ends up near its siblings instead of near MaxValue. |

## See Also

* **Source:** *[NavigationHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Navigation/NavigationHelper.cs)*