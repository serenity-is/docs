# BaseRepository class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An base class that can be used for repositories (obsolete, [`BaseRequestHandler`](BaseRequestHandler.md)) that accept a [`IRequestContext`](IRequestContext.md) instance.

```csharp
public class BaseRepository
```

| parameter | description |
| --- | --- |
| context | Request context |

## Public Members

| name | description |
| --- | --- |
| [BaseRepository](BaseRepository/BaseRepository.md)(…) | An base class that can be used for repositories (obsolete, [`BaseRequestHandler`](BaseRequestHandler.md)) that accept a [`IRequestContext`](IRequestContext.md) instance. |

## Protected Members

| name | description |
| --- | --- |
| [Cache](BaseRepository/Cache.md) { get; } | Gets cache from the request context |
| [Context](BaseRepository/Context.md) { get; } | Gets the request context |
| [Localizer](BaseRepository/Localizer.md) { get; } | Gets text localizer from the request context |
| [Permissions](BaseRepository/Permissions.md) { get; } | Gets permission service from the request context |
| [User](BaseRepository/User.md) { get; } | Gets the user from the request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Context is null |

## Remarks

Creates an instance of the class.

## See Also

* **Source:** *[BaseRepository.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Repository/BaseRepository.cs)*