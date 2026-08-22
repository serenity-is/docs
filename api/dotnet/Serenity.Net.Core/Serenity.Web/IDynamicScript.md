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

* **Source:** *[IDynamicScript.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/DynamicScript/IDynamicScript.cs)*