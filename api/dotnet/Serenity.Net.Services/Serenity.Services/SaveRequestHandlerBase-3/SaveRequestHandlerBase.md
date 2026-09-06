# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt; constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Abstract base class for save request handlers that share state and mode neutral helper methods between synchronous and asynchronous save request handlers.

```csharp
protected SaveRequestHandlerBase(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)