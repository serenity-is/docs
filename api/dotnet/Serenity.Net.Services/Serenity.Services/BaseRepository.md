# BaseRepository class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An base class that can be used for repositories (obsolete, [`BaseRequestHandler`](BaseRequestHandler.md)) that accept a [`IRequestContext`](IRequestContext.md) instance.

```csharp
public class BaseRepository
```

## Public Members

| name | description |
| --- | --- |
| [BaseRepository](BaseRepository/BaseRepository.md)(…) | Creates an instance of the class. |

## Protected Members

| name | description |
| --- | --- |
| [Cache](BaseRepository/Cache.md) { get; } | Gets cache from the request context |
| [Context](BaseRepository/Context.md) { get; } | Gets the request context |
| [Localizer](BaseRepository/Localizer.md) { get; } | Gets text localizer from the request context |
| [Permissions](BaseRepository/Permissions.md) { get; } | Gets permission service from the request context |
| [User](BaseRepository/User.md) { get; } | Gets the user from the request context |

## See Also

* **Source:** *[BaseRepository.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Repository/BaseRepository.cs)*