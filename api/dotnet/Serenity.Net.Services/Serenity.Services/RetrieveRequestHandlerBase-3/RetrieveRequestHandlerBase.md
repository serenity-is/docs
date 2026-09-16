# RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; constructor

Abstract base class for retrieve request handlers that share state and mode neutral helper methods between synchronous and asynchronous retrieve request handlers.

```csharp
protected RetrieveRequestHandlerBase(IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TRetrieveRequest | Retrieve request type |
| TRetrieveResponse | Retrieve response type |
| context | Request context |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRequestContext](../IRequestContext.md)
* class [RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandlerBase-3.md)