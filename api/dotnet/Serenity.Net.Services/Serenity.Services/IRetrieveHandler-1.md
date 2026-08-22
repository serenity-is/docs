# IRetrieveHandler&lt;TRow&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for retrieve request handlers.

```csharp
public interface IRetrieveHandler<TRow> : 
    IRetrieveHandler<TRow, RetrieveRequest, RetrieveResponse<TRow>>
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## See Also

* interface [IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](IRetrieveHandler-3.md)
* class [TRow](../Serenity.Net.Services/IRetrieveHandler-1.TRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* interface [IRow](../Serenity.Data/IRow.md)
* **Source:** *[IRetrieveHandlerT.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Retrieve/IRetrieveHandlerT.cs)*