# BaseRepository constructor

A base class that can be used for repositories that accept a [`IRequestContext`](../IRequestContext.md) instance. This repository pattern is not recommended. Prefer defining an individual request handler per service operation (e.g. save, list, retrieve, delete), such as [`BaseRequestHandler`](../BaseRequestHandler.md).

```csharp
public BaseRepository(IRequestContext context)
```

| parameter | description |
| --- | --- |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [BaseRepository](../BaseRepository.md)