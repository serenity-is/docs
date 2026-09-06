# EndpointExtensions.ConvertToResponse&lt;TResponse&gt; method (1 of 2)

Converts the exception object to a service response.

```csharp
public static TResponse ConvertToResponse<TResponse>(this Exception exception, 
    HttpContext httpContext)
    where TResponse : ServiceResponse, new()
```

| parameter | description |
| --- | --- |
| TResponse | The response object type. |
| exception | The exception. |
| httpContext | The HTTP context. |

## Return Value

The converted service response.

## See Also

* class [ServiceResponse](../../../Serenity.Net.Services/Serenity.Services/ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)

---

# EndpointExtensions.ConvertToResponse&lt;TResponse&gt; method (2 of 2)

Converts the exception to a service response.

```csharp
public static TResponse ConvertToResponse<TResponse>(this Exception exception, ILogger logger, 
    ITextLocalizer localizer, bool showDetails)
    where TResponse : ServiceResponse, new()
```

| parameter | description |
| --- | --- |
| TResponse | The response object type. |
| exception | The exception. |
| logger | The exception logger. |
| localizer | The text localizer. |
| showDetails | `true` to show details. |

## Return Value

The converted service response.

## See Also

* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [ServiceResponse](../../../Serenity.Net.Services/Serenity.Services/ServiceResponse.md)
* class [EndpointExtensions](../EndpointExtensions.md)