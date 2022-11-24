# NavigationHelper.ConvertToNavigationItems method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Converts a list of [`NavigationItemAttribute`](../NavigationItemAttribute.md) objects to a list of [`NavigationItem`](../NavigationItem.md) classes.

```csharp
public static List<NavigationItem> ConvertToNavigationItems(IPermissionService permissions, 
    ILookup<string, NavigationItemAttribute> attrByCategory, Func<string, string> resolveUrl)
```

| parameter | description |
| --- | --- |
| permissions | Permission service |
| attrByCategory | A lookup to find attributes by their category |
| resolveUrl | Resolve url callback |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is null |

## See Also

* class [NavigationItem](../NavigationItem.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* class [NavigationItemAttribute](../NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)