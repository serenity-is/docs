# NavigationLinkAttribute.GetPermissionFromController method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Tries to extract the permission from a controller action.

```csharp
public static string GetPermissionFromController(Type controller, string action)
```

| parameter | description |
| --- | --- |
| controller | The controller. |
| action | The action. |

## Return Value

The permission key, or `null` if none is found.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controller or action is `null`. |
| ArgumentOutOfRangeException | The action name is invalid. |

## See Also

* class [NavigationLinkAttribute](../NavigationLinkAttribute.md)