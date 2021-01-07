# EndpointExtensions.ExecuteMethod&lt;TResponse&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

```csharp
public static Result<TResponse> ExecuteMethod<TResponse>(this Controller controller, 
    Func<TResponse> handler)
    where TResponse : ServiceResponse, new()
```

## See Also

* class [Result&lt;TResponse&gt;](../Result-1.md)
* class [TResponse](../Serenity.Net.Web/../EndpointExtensions.TResponse.md)
* class [ServiceResponse](../Serenity.Net.Services/../ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)