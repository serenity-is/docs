# EndpointExtensions class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains some extensions for service endpoints

```csharp
public static class EndpointExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ConvertToResponse&lt;TResponse&gt;](EndpointExtensions/ConvertToResponse.md)(…) | Converts the exception object to a service response (2 methods) |
| static [ExecuteMethod&lt;TResponse&gt;](EndpointExtensions/ExecuteMethod.md)(…) | Executes an action method and converts any exception to a service response |
| static [InTransaction&lt;TResponse&gt;](EndpointExtensions/InTransaction.md)(…) | Executes a callback by passing a unit of work object and converts any exception raised inside to a service response. |
| static [UseConnection&lt;TResponse&gt;](EndpointExtensions/UseConnection.md)(…) | Executes a callback by passing a connection object and converts any exception raised inside to a service response. |

## See Also

* **Source:** *[EndpointExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/EndpointExtensions.cs)*