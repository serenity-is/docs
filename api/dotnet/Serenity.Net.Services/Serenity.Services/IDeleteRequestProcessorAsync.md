# IDeleteRequestProcessorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for delete request handlers with an async Process method.

```csharp
public interface IDeleteRequestProcessorAsync : IDeleteRequestHandler
```

## Members

| name | description |
| --- | --- |
| [ProcessAsync](IDeleteRequestProcessorAsync/ProcessAsync.md)(…) | Processes the [`DeleteRequest`](./DeleteRequest.md) asynchronously and returns a [`DeleteResponse`](./DeleteResponse.md) |

## See Also

* interface [IDeleteRequestHandler](./IDeleteRequestHandler.md)
* **Source:** *[IDeleteRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/a8d7b8ad81c84c4caad371e2eeca49085cf8de96/src/services/RequestHandlers/Delete/IDeleteRequestProcessorAsync.cs)*