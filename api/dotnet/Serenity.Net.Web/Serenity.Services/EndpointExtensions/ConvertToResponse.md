# EndpointExtensions.ConvertToResponse&lt;TResponse&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

```csharp
public static TResponse ConvertToResponse<TResponse>(this Exception exception, HttpContext context)
    where TResponse : ServiceResponse, new()
```

## See Also

* class [TResponse](../Serenity.Net.Web/../EndpointExtensions.TResponse.md)
* class [ServiceResponse](../Serenity.Net.Services/../ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)