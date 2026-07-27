# BaseRequestHandler constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

An abstract class that can be used as base for request handlers that accept a [`IRequestContext`](../IRequestContext.md) instance.

```csharp
protected BaseRequestHandler(IRequestContext context)
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
* class [BaseRequestHandler](../BaseRequestHandler.md)