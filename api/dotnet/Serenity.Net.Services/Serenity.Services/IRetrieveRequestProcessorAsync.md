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
* **Source:** *[IRetrieveRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/a8d7b8ad81c84c4caad371e2eeca49085cf8de96/src/services/RequestHandlers/Retrieve/IRetrieveRequestProcessorAsync.cs)*