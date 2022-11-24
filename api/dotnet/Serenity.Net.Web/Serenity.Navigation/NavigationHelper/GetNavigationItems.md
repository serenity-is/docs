# NavigationHelper.GetNavigationItems method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets navigation items

```csharp
public static List<NavigationItem> GetNavigationItems(IPermissionService permissions, 
    ITypeSource typeSource, IServiceProvider serviceProvider, 
    Func<string, string> resolveUrl = null, Func<NavigationItemAttribute, bool> filter = null)
```

| parameter | description |
| --- | --- |
| permissions | Permission service |
| typeSource | Type source |
| serviceProvider | Service provider |
| resolveUrl | Resolve URL callback |
| filter | Filter function |

## See Also

* class [NavigationItem](../NavigationItem.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [NavigationItemAttribute](../NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)