# EndpointExtensions.ExecuteMethod&lt;TResponse&gt; method

Executes an action method and converts any exception to a service response.

```csharp
public static Result<TResponse> ExecuteMethod<TResponse>(this ControllerBase controller, 
    Func<TResponse> handler)
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
* class [ServiceResponse](../../../Serenity.Net.Services/Serenity.Services/ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)