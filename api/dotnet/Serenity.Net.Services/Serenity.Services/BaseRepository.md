# BaseRepository class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A base class that can be used for repositories (obsolete, [`BaseRequestHandler`](BaseRequestHandler.md)) that accept a [`IRequestContext`](IRequestContext.md) instance.

```csharp
public class BaseRepository
```

| parameter | description |
| --- | --- |
| context | Request context |

## Public Members

| name | description |
| --- | --- |
| [BaseRepository](BaseRepository/BaseRepository.md)(…) | A base class that can be used for repositories (obsolete, [`BaseRequestHandler`](BaseRequestHandler.md)) that accept a [`IRequestContext`](IRequestContext.md) instance. |

## Protected Members

| name | description |
| --- | --- |
| [Cache](BaseRepository/Cache.md) { get; } | Gets the cache from the request context. |
| [Context](BaseRepository/Context.md) { get; } | Gets the request context. |
| [Localizer](BaseRepository/Localizer.md) { get; } | Gets the text localizer from the request context. |
| [Permissions](BaseRepository/Permissions.md) { get; } | Gets the permission service from the request context. |
| [User](BaseRepository/User.md) { get; } | Gets the user from the request context. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* **Source:** *[BaseRepository.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Repository/BaseRepository.cs)*