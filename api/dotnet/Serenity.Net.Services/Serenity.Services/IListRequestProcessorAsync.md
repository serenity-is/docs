# IListRequestProcessorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for list request handlers with an async Process method.

```csharp
public interface IListRequestProcessorAsync : IListRequestHandler
```

## Members

| name | description |
| --- | --- |
| [ProcessAsync](IListRequestProcessorAsync/ProcessAsync.md)(…) | Processes the [`ListRequest`](ListRequest.md) asynchronously and returns a [`IListResponse`](IListResponse.md) |

## See Also

* interface [IListRequestHandler](IListRequestHandler.md)
* **Source:** *[IListRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/IListRequestProcessorAsync.cs)*