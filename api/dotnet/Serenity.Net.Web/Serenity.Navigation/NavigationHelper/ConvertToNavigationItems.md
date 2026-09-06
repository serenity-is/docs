# NavigationHelper.ConvertToNavigationItems method

Converts a list of NavigationItemAttribute objects to a list of NavigationItem classes.

```csharp
public static List<NavigationItem> ConvertToNavigationItems(IPermissionService permissions, 
    ILookup<string, NavigationItemAttribute> attrByCategory, Func<string, string> resolveUrl)
```

| parameter | description |
| --- | --- |
| permissions | The permission service. |
| attrByCategory | A lookup to find attributes by their category. |
| resolveUrl | The resolve URL callback. |

## Return Value

The list of navigation items.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## See Also

* class [NavigationItem](../../../Serenity.Net.Core/Serenity.Navigation/NavigationItem.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* class [NavigationItemAttribute](../../../Serenity.Net.Core/Serenity.Navigation/NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)