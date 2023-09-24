# NavigationLinkAttribute.GetPermissionFromController method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Tries to extract permission from a controller action

```csharp
public static string GetPermissionFromController(Type controller, string action)
```

| parameter | description |
| --- | --- |
| controller | Controller |
| action | Action |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controller or action is null |
| ArgumentOutOfRangeException | Action name is invalid |

## See Also

* class [NavigationLinkAttribute](../NavigationLinkAttribute.md)