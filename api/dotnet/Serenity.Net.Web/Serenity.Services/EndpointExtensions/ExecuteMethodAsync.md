# EndpointExtensions.ExecuteMethodAsync&lt;TResponse&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Executes an action method asynchronously and converts any exception to a service response.

```csharp
public static Task<Result<TResponse>> ExecuteMethodAsync<TResponse>(this ControllerBase controller, 
    Func<Task<TResponse>> handler)
    where TResponse : ServiceResponse, new()
```

| parameter | description |
| --- | --- |
| TResponse | The response type. |
| controller | The controller. |
| handler | The handler callback. |

## Return Value

The action result.

## See Also

* class [Result&lt;TResponse&gt;](../Result-1.md)
* class [TResponse](../Serenity.Net.Web/../EndpointExtensions.TResponse.md)
* class [ServiceResponse](../Serenity.Net.Services/../ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)