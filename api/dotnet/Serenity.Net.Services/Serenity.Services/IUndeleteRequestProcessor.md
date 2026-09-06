# IUndeleteRequestProcessor interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for undelete request handlers with a Process method.

```csharp
public interface IUndeleteRequestProcessor : IUndeleteRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Process](IUndeleteRequestProcessor/Process.md)(…) | Processes the [`UndeleteRequest`](UndeleteRequest.md) and returns a [`UndeleteResponse`](UndeleteResponse.md) |

## See Also

* interface [IUndeleteRequestHandler](IUndeleteRequestHandler.md)
* **Source:** *[IUndeleteRequestProcessor.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/IUndeleteRequestProcessor.cs)*