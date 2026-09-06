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
* **Source:** *[IDeleteRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/IDeleteRequestProcessorAsync.cs)*