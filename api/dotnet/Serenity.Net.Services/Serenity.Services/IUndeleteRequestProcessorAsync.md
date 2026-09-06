# IUndeleteRequestProcessorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for undelete request handlers with an async Process method.

```csharp
public interface IUndeleteRequestProcessorAsync : IUndeleteRequestHandler
```

## Members

| name | description |
| --- | --- |
| [ProcessAsync](IUndeleteRequestProcessorAsync/ProcessAsync.md)(…) | Processes the [`UndeleteRequest`](UndeleteRequest.md) asynchronously and returns a [`UndeleteResponse`](UndeleteResponse.md) |

## See Also

* interface [IUndeleteRequestHandler](IUndeleteRequestHandler.md)
* **Source:** *[IUndeleteRequestProcessorAsync.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/IUndeleteRequestProcessorAsync.cs)*