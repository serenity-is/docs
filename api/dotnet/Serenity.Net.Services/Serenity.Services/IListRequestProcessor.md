# IListRequestProcessor interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for list request handlers with a Process method.

```csharp
public interface IListRequestProcessor : IListRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Process](IListRequestProcessor/Process.md)(…) | Processes the [`ListRequest`](ListRequest.md) and returns a [`ListResponse`](ListResponse-1.md) |

## See Also

* interface [IListRequestHandler](IListRequestHandler.md)
* **Source:** *[IListRequestProcessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/IListRequestProcessor.cs)*