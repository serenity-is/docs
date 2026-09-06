# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt; constructor

Abstract base class for list request handlers that share state and mode neutral helper methods between synchronous and asynchronous list request handlers.

```csharp
protected ListRequestHandlerBase(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TListRequest | List request type |
| TListResponse | List response type |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)