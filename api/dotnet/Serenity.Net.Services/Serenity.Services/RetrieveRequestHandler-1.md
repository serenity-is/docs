# RetrieveRequestHandler&lt;TRow&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for retrieve request handlers that use [`RetrieveRequest`](./RetrieveRequest.md) as the request type, and [`RetrieveResponse`](./RetrieveResponse-1.md) as the response type.

```csharp
public class RetrieveRequestHandler<TRow> : 
    RetrieveRequestHandler<TRow, RetrieveRequest, RetrieveResponse<TRow>>, IRetrieveHandler<TRow>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The entity type |
| context | The request context |

## Public Members

| name | description |
| --- | --- |
| [RetrieveRequestHandler](RetrieveRequestHandler-1/RetrieveRequestHandler.md)(…) | Base generic class for retrieve request handlers that use [`RetrieveRequest`](./RetrieveRequest.md) as the request type, and [`RetrieveResponse`](./RetrieveResponse-1.md) as the response type. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](./RetrieveRequestHandler-3.md)
* class [RetrieveRequest](./RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](./RetrieveResponse-1.md)
* interface [IRetrieveHandler&lt;TRow&gt;](./IRetrieveHandler-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[RetrieveRequestHandlerT.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Retrieve/RetrieveRequestHandlerT.cs)*