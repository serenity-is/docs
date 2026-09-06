# IRetrieveRequestProcessorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for retrieve request handlers with an async Process method.

```csharp
public interface IRetrieveRequestProcessorAsync : IRetrieveRequestHandler
```

## Members

| name | description |
| --- | --- |
| [ProcessAsync](IRetrieveRequestProcessorAsync/ProcessAsync.md)(…) | Processes the [`RetrieveRequest`](./RetrieveRequest.md) asynchronously and returns a [`IRetrieveResponse`](./IRetrieveResponse.md) |

## See Also

* interface [IRetrieveRequestHandler](./IRetrieveRequestHandler.md)
* **Source:** *[IRetrieveRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/IRetrieveRequestProcessorAsync.cs)*