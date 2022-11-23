# IDeleteRequestProcessor interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for delete request handlers with a Process method.

```csharp
public interface IDeleteRequestProcessor : IDeleteRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Process](IDeleteRequestProcessor/Process.md)(…) | Processes the [`DeleteRequest`](DeleteRequest.md) and returns a [`DeleteResponse`](DeleteResponse.md) |

## See Also

* interface [IDeleteRequestHandler](IDeleteRequestHandler.md)
* **Source:** *[IDeleteRequestProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/IDeleteRequestProcessor.cs)*