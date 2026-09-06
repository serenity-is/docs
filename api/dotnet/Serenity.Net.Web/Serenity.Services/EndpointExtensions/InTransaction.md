# EndpointExtensions.InTransaction&lt;TResponse&gt; method

Executes a callback by passing a unit of work object and converts any exception raised inside to a service response.

```csharp
public static Result<TResponse> InTransaction<TResponse>(this ControllerBase controller, 
    string connectionKey, Func<IUnitOfWork, TResponse> handler)
    where TResponse : ServiceResponse, new()
```

| parameter | description |
| --- | --- |
| TResponse | The response type. |
| controller | The controller. |
| connectionKey | The connection key. |
| handler | The handler callback. |

## Return Value

The action result.

## See Also

* class [Result&lt;TResponse&gt;](../Result-1.md)
* interface [IUnitOfWork](../../../Serenity.Net.Services/Serenity.Data/IUnitOfWork.md)
* class [ServiceResponse](../../../Serenity.Net.Services/Serenity.Services/ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)