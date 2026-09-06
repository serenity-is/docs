# NavigationHelper.GetNavigationItems method

Gets navigation items.

```csharp
public static List<NavigationItem> GetNavigationItems(IPermissionService permissions, 
    ITypeSource typeSource, IServiceProvider serviceProvider, 
    Func<string, string> resolveUrl = null, Func<NavigationItemAttribute, bool> filter = null)
```

| parameter | description |
| --- | --- |
| permissions | The permission service. |
| typeSource | The type source. |
| serviceProvider | The service provider. |
| resolveUrl | The resolve URL callback. |
| filter | The filter function. |

## Return Value

The list of navigation items.

## See Also

* class [NavigationItem](../../../Serenity.Net.Core/Serenity.Navigation/NavigationItem.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [NavigationItemAttribute](../../../Serenity.Net.Core/Serenity.Navigation/NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)