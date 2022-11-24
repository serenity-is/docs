# EndpointExtensions.InTransaction&lt;TResponse&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Executes a callback by passing a unit of work object and converts any exception raised inside to a service response.

```csharp
public static Result<TResponse> InTransaction<TResponse>(this Controller controller, 
    string connectionKey, Func<IUnitOfWork, TResponse> handler)
    where TResponse : ServiceResponse, new()
```

| parameter | description |
| --- | --- |
| TResponse | Response type |
| controller | Controller |
| connectionKey | Connection key |
| handler | Handler callback |

## See Also

* class [Result&lt;TResponse&gt;](../Result-1.md)
* class [TResponse](../Serenity.Net.Web/../EndpointExtensions.TResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [ServiceResponse](../Serenity.Net.Services/../ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)