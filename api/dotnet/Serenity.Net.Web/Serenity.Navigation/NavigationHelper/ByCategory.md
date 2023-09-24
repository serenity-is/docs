# NavigationHelper.ByCategory method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a lookup of navigation item attributes by their category

```csharp
public static ILookup<string, NavigationItemAttribute> ByCategory(
    IEnumerable<NavigationItemAttribute> list)
```

| parameter | description |
| --- | --- |
| list | List with navigation item attributes |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | List is null |

## See Also

* class [NavigationItemAttribute](../Serenity.Net.Core/../NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)