# IListRequestProcessorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for list request handlers with an async Process method.

```csharp
public interface IListRequestProcessorAsync : IListRequestHandler
```

## Members

| name | description |
| --- | --- |
| [ProcessAsync](IListRequestProcessorAsync/ProcessAsync.md)(…) | Processes the [`ListRequest`](./ListRequest.md) asynchronously and returns a [`IListResponse`](./IListResponse.md) |

## See Also

* interface [IListRequestHandler](./IListRequestHandler.md)
* **Source:** *[IListRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/a8d7b8ad81c84c4caad371e2eeca49085cf8de96/src/services/RequestHandlers/List/IListRequestProcessorAsync.cs)*