# ISaveHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for async save request handlers with custom request / response types.

```csharp
public interface ISaveHandlerAsync<TRow, TSaveRequest, TSaveResponse> : 
    ICreateHandlerAsync<TRow, TSaveRequest, TSaveResponse>, 
    IUpdateHandlerAsync<TRow, TSaveRequest, TSaveResponse>
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |

## See Also

* interface [ICreateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](ICreateHandlerAsync-3.md)
* class [TRow](../Serenity.Net.Services/ISaveHandlerAsync-3.TRow.md)
* class [TSaveRequest](../Serenity.Net.Services/ISaveHandlerAsync-3.TSaveRequest.md)
* class [TSaveResponse](../Serenity.Net.Services/ISaveHandlerAsync-3.TSaveResponse.md)
* interface [IUpdateHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](IUpdateHandlerAsync-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* **Source:** *[ISaveHandlerAsync.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/ISaveHandlerAsync.cs)*