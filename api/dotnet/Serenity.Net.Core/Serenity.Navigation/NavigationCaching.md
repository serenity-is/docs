# NavigationCaching class
**namespace:** *[Serenity.Navigation](../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

The cache group keys related to the navigation items, so that code changing what a navigation item source returns can expire them without having to know how a navigation model factory caches its items.

```csharp
public static class NavigationCaching
```

## Public Members

| name | description |
| --- | --- |
| const [ItemsGroupKey](NavigationCaching/ItemsGroupKey.md) | The cache group key that navigation model factories should use for the navigation items, in addition to any other groups they depend on, like the permissions of the users. |

## See Also

* **Source:** *[NavigationCaching.cs](https://github.com/serenity-is/Serenity/blob/56991f31ee4d57ba97b6838d28dbc96c25d113f7/src/core/ComponentModel/Navigation/NavigationCaching.cs)*