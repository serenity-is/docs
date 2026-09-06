# DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt; constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Abstract base class for delete request handlers that share state and mode neutral helper methods between synchronous and asynchronous delete request handlers.

```csharp
protected DeleteRequestHandlerBase(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TDeleteRequest | Delete request type |
| TDeleteResponse | Delete response type |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandlerBase-3.md)