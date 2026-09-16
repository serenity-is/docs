# IDynamicScript interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Dynamic script abstraction

```csharp
public interface IDynamicScript
```

## Members

| name | description |
| --- | --- |
| [Expiration](IDynamicScript/Expiration.md) { get; } | Cache expiration timespan |
| [GroupKey](IDynamicScript/GroupKey.md) { get; } | Group key for cached items |
| [CheckRights](IDynamicScript/CheckRights.md)(…) | Checks whether the current user has the permissions required to access this script, throwing an exception if access is not allowed. |
| [GetScript](IDynamicScript/GetScript.md)() | Gets the script content |

## See Also

* **Source:** *[IDynamicScript.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/core/DynamicScript/IDynamicScript.cs)*