# NavigationLinkAttribute.GetFeaturesFromController method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Tries to extract features from a controller action.

```csharp
public static string[] GetFeaturesFromController(Type controller, string action, 
    out bool requireAny)
```

| parameter | description |
| --- | --- |
| controller | The controller. |
| action | The action. |
| requireAny | Whether any of the features are required. |

## Return Value

The list of required features, or `null` if none is found.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controller or action is `null`. |
| ArgumentOutOfRangeException | The action name is invalid. |

## See Also

* class [NavigationLinkAttribute](../NavigationLinkAttribute.md)