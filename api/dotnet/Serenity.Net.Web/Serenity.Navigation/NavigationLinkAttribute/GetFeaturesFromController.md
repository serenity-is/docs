# NavigationLinkAttribute.GetFeaturesFromController method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Tries to extract features from a controller action

```csharp
public static string[] GetFeaturesFromController(Type controller, string action, 
    out bool requireAny)
```

| parameter | description |
| --- | --- |
| controller | Controller |
| action | Action |
| requireAny | If any of features are required |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controller or action is null |
| ArgumentOutOfRangeException | Action name is invalid |

## See Also

* class [NavigationLinkAttribute](../NavigationLinkAttribute.md)