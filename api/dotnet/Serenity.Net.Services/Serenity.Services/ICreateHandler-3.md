# ICreateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for create request handlers with custom request / response types.

```csharp
public interface ICreateHandler<TRow, TSaveRequest, TSaveResponse> : 
    IRequestHandler<TRow, TSaveRequest, TSaveResponse>
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |

## Members

| name | description |
| --- | --- |
| [Create](ICreateHandler-3/Create.md)(…) | Processes a Create request |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/ICreateHandler-3.TRow.md)
* class [TSaveRequest](../Serenity.Net.Services/ICreateHandler-3.TSaveRequest.md)
* class [TSaveResponse](../Serenity.Net.Services/ICreateHandler-3.TSaveResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* **Source:** *[ICreateHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/ICreateHandler.cs)*