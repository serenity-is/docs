# NavigationGroupAttribute class
**namespace:** *[Serenity.Navigation](../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Defines a navigation group, which are usually the icons on the sidebar band

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class NavigationGroupAttribute : NavigationItemAttribute
```

## Public Members

| name | description |
| --- | --- |
| [NavigationGroupAttribute](NavigationGroupAttribute/NavigationGroupAttribute.md)(…) | Creates a new instance of the attribute (2 constructors) |
| [Default](NavigationGroupAttribute/Default.md) { get; set; } | This group automatically includes siblings that does not match any other groups |
| [Include](NavigationGroupAttribute/Include.md) { get; set; } | This is a list used to move items that are not normally under this item based on path (to create groups). For example, if this item is named A, and want to move all menus under B/.. or C/.. to A, the list should be ["B/", "C/"]. To move B and C themselves under A, list should be ["B", "C"]. |

## See Also

* class [NavigationItemAttribute](NavigationItemAttribute.md)
* **Source:** *[NavigationGroupAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Navigation/NavigationGroupAttribute.cs)*