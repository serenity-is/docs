# BaseRepository constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

An base class that can be used for repositories (obsolete, [`BaseRequestHandler`](../BaseRequestHandler.md)) that accept a [`IRequestContext`](../IRequestContext.md) instance.

```csharp
public BaseRepository(IRequestContext context)
```

| parameter | description |
| --- | --- |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Context is null |

## Remarks

Creates an instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [BaseRepository](../BaseRepository.md)