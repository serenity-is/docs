# IDynamicScript interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script abstraction

```csharp
public interface IDynamicScript
```

## Members

| name | description |
| --- | --- |
| [Expiration](IDynamicScript/Expiration.md) { get; } | Cache expiration timespan |
| [GroupKey](IDynamicScript/GroupKey.md) { get; } | Group key for cached items |
| [CheckRights](IDynamicScript/CheckRights.md)(…) | Checks script permissions |
| [GetScript](IDynamicScript/GetScript.md)() | Gets the script content |

## See Also

* **Source:** *[IDynamicScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScript/IDynamicScript.cs)*