# NavigationItemAttribute.GetUrlFromController method

Tries to extract the URL from a controller action.

```csharp
public static string? GetUrlFromController(Type controller, string action, 
    bool throwIfAbsent = true)
```

| parameter | description |
| --- | --- |
| controller | The controller. |
| action | The action name. |
| throwIfAbsent | Whether to throw if the action is not found. |

## Return Value

The resolved URL, or `null` if the action is not found and *throwIfAbsent* is `false`.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Controller or action is `null`. |
| ArgumentOutOfRangeException | The action name is invalid. |
| InvalidOperationException | The route attribute is not found. |

## See Also

* class [NavigationItemAttribute](../NavigationItemAttribute.md)