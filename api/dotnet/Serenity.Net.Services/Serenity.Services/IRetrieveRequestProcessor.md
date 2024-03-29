# IRetrieveRequestProcessor interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for retrieve request handlers with a Process method.

```csharp
public interface IRetrieveRequestProcessor : IRetrieveRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Process](IRetrieveRequestProcessor/Process.md)(…) | Processes the [`RetrieveRequest`](RetrieveRequest.md) and returns a [`RetrieveResponse`](RetrieveResponse-1.md) |

## See Also

* interface [IRetrieveRequestHandler](IRetrieveRequestHandler.md)
* **Source:** *[IRetrieveRequestProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/IRetrieveRequestProcessor.cs)*