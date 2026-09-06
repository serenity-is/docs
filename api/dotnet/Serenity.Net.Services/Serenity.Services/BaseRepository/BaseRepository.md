# BaseRepository constructor

A base class that can be used for repositories (obsolete, [`BaseRequestHandler`](../BaseRequestHandler.md)) that accept a [`IRequestContext`](../IRequestContext.md) instance.

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