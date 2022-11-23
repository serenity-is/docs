# IRequestContext interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A service request context abstraction containing services that are mostly used by all service handler types. This is a type similar to the HttpContext but is specialized for service handlers.

```csharp
public interface IRequestContext
```

## Members

| name | description |
| --- | --- |
| [Behaviors](IRequestContext/Behaviors.md) { get; } | Gets the behavior provider |
| [Cache](IRequestContext/Cache.md) { get; } | Get the two level cache |
| [Localizer](IRequestContext/Localizer.md) { get; } | Gets the text localizer |
| [Permissions](IRequestContext/Permissions.md) { get; } | Gets the permission service |
| [User](IRequestContext/User.md) { get; } | Gets current user |

## See Also

* **Source:** *[IRequestContext.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Repository/IRequestContext.cs)*