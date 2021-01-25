# EndpointExtensions.ConvertToResponse&lt;TResponse&gt; method (1 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

```csharp
public static TResponse ConvertToResponse<TResponse>(this Exception exception, 
    HttpContext httpContext)
    where TResponse : ServiceResponse, new()
```

## See Also

* class [TResponse](../Serenity.Net.Web/../EndpointExtensions.TResponse.md)
* class [ServiceResponse](../Serenity.Net.Services/../ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)

---

# EndpointExtensions.ConvertToResponse&lt;TResponse&gt; method (2 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

```csharp
public static TResponse ConvertToResponse<TResponse>(this Exception exception, 
    IExceptionLogger logger, ITextLocalizer localizer, bool showDetails)
    where TResponse : ServiceResponse, new()
```

## See Also

* class [TResponse](../Serenity.Net.Web/../EndpointExtensions.TResponse.md)
* interface [IExceptionLogger](../Serenity.Net.Core/../../Serenity.Abstractions/IExceptionLogger.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ServiceResponse](../Serenity.Net.Services/../ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)