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
* **Source:** *[IUndeleteRequestProcessor.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/Undelete/IUndeleteRequestProcessor.cs)*