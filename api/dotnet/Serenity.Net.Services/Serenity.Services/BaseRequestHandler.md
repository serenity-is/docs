# BaseRequestHandler class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An abstract class that can be used as base for request handlers that accept a [`IRequestContext`](IRequestContext.md) instance.

```csharp
public abstract class BaseRequestHandler : IRequestHandler
```

| parameter | description |
| --- | --- |
| context | Request context |

## Protected Members

| name | description |
| --- | --- |
| [BaseRequestHandler](BaseRequestHandler/BaseRequestHandler.md)(…) | An abstract class that can be used as base for request handlers that accept a [`IRequestContext`](IRequestContext.md) instance. |
| [Cache](BaseRequestHandler/Cache.md) { get; } | Gets cache from the request context |
| [Context](BaseRequestHandler/Context.md) { get; } | Gets the request context |
| [Localizer](BaseRequestHandler/Localizer.md) { get; } | Gets text localizer from the request context |
| [Permissions](BaseRequestHandler/Permissions.md) { get; } | Gets permission service from the request context |
| [User](BaseRequestHandler/User.md) { get; } | Gets the user from the request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Context is null |

## Remarks

Creates an instance of the class.

## See Also

* interface [IRequestHandler](../Serenity.Net.Core/IRequestHandler.md)
* **Source:** *[BaseRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Handler/BaseRequestHandler.cs)*