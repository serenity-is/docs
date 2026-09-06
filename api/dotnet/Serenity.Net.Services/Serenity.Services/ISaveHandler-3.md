# ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt; interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for save request handlers with custom request / response types.

```csharp
public interface ISaveHandler<TRow, TSaveRequest, TSaveResponse> : 
    ICreateHandler<TRow, TSaveRequest, TSaveResponse>, 
    IUpdateHandler<TRow, TSaveRequest, TSaveResponse>
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

* interface [ICreateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](./ICreateHandler-3.md)
* interface [IUpdateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](./IUpdateHandler-3.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](./SaveRequest-1.md)
* class [SaveResponse](./SaveResponse.md)
* **Source:** *[ISaveHandler.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/Save/ISaveHandler.cs)*