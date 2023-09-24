# NavigationLinkAttribute.GetUrlFromController method
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Tries to extract URL from a controller action

```csharp
public static string GetUrlFromController(Type controller, string action)
```

| parameter | description |
| --- | --- |
| controller | Controller |
| action | Action name |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controll or action is null |
| ArgumentOutOfRangeException | Action name is invalid |
| InvalidOperationException | Route attribute is not found |

## See Also

* class [NavigationLinkAttribute](../NavigationLinkAttribute.md)