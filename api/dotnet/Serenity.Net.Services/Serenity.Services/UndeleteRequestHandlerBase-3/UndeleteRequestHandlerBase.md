# UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; constructor

Abstract base class for undelete request handlers that share state and mode neutral helper methods between synchronous and asynchronous undelete request handlers.

```csharp
protected UndeleteRequestHandlerBase(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TUndeleteRequest | Undelete request type |
| TUndeleteResponse | Undelete response type |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandlerBase-3.md)