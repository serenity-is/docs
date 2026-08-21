# NavigationLinkAttribute.GetUrlFromController method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Tries to extract the URL from a controller action.

```csharp
public static string GetUrlFromController(Type controller, string action)
```

| parameter | description |
| --- | --- |
| controller | The controller. |
| action | The action name. |

## Return Value

The resolved URL.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controller or action is `null`. |
| ArgumentOutOfRangeException | The action name is invalid. |
| InvalidOperationException | The route attribute is not found. |

## See Also

* class [NavigationLinkAttribute](../NavigationLinkAttribute.md)