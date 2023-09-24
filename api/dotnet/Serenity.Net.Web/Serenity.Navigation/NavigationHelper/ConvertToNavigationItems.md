# NavigationHelper.ConvertToNavigationItems method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Converts a list of NavigationItemAttribute objects to a list of NavigationItem classes.

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

* class [NavigationItem](../Serenity.Net.Core/../NavigationItem.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* class [NavigationItemAttribute](../Serenity.Net.Core/../NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)