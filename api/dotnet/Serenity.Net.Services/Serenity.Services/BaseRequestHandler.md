# BaseRequestHandler class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An abstract class that can be used as base for request handlers that accept a [`IRequestContext`](IRequestContext.md) instance.

```csharp
public abstract class BaseRequestHandler : IRequestHandler
```

## Public Members

| name | description |
| --- | --- |
| [BaseRequestHandler](BaseRequestHandler/BaseRequestHandler.md)(…) | Creates an instance of the class. |

## Protected Members

| name | description |
| --- | --- |
| [Cache](BaseRequestHandler/Cache.md) { get; } | Gets cache from the request context |
| [Context](BaseRequestHandler/Context.md) { get; } | Gets the request context |
| [Localizer](BaseRequestHandler/Localizer.md) { get; } | Gets text localizer from the request context |
| [Permissions](BaseRequestHandler/Permissions.md) { get; } | Gets permission service from the request context |
| [User](BaseRequestHandler/User.md) { get; } | Gets the user from the request context |

## See Also

* interface [IRequestHandler](IRequestHandler.md)
* **Source:** *[BaseRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Handler/BaseRequestHandler.cs)*