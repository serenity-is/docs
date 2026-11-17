# RequestHandlerExtensions class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains extension methods to create request / response types for a request handler instance

```csharp
public static class RequestHandlerExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [CreateRequest](RequestHandlerExtensions/CreateRequest.md)(…) | Creates a request object for the list handler instance (5 methods) |
| static [CreateRequest&lt;TRow&gt;](RequestHandlerExtensions/CreateRequest.md)(…) | Creates a request object for the save handler instance |
| static [GetRequestType](RequestHandlerExtensions/GetRequestType.md)(…) | Gets the request type for the handler instance. For a sync / async list handler wrapper returned by the handler factory, it is the request type of the wrapped handler, which may be a subclass of [`ListRequest`](./ListRequest.md) the wrapped handler casts the request to. |
| static [GetResponseType](RequestHandlerExtensions/GetResponseType.md)(…) | Gets the response type for the handler instance |
| static [GetTimeZoneInfo](RequestHandlerExtensions/GetTimeZoneInfo.md)(…) | Finds the time zone of a list request, see [`TimeZone`](./ListRequest/TimeZone.md). |
| static [IsPagingLimitsSuppressed&lt;TRequest&gt;](RequestHandlerExtensions/IsPagingLimitsSuppressed.md)(…) | Gets whether paging limits ([`DefaultPageSize`](./RequestHandlerSettings/DefaultPageSize.md) / [`MaxPageSize`](./RequestHandlerSettings/MaxPageSize.md)) are suppressed for the list request, e.g. set via [`SuppressPagingLimits`](./RequestHandlerExtensions/SuppressPagingLimits.md). |
| static [SuppressPagingLimits&lt;TRequest&gt;](RequestHandlerExtensions/SuppressPagingLimits.md)(…) | Sets whether paging limits ([`DefaultPageSize`](./RequestHandlerSettings/DefaultPageSize.md) / [`MaxPageSize`](./RequestHandlerSettings/MaxPageSize.md)) should be ignored for the list request. Server side code that needs all rows (e.g. exports, reports, background jobs, nested relation loads) should call this; otherwise enabling the limits may silently truncate the results. Has no effect on JSON bound client requests. |

## See Also

* **Source:** *[RequestHandlerExtensions.cs](https://github.com/serenity-is/Serenity/blob/fe192008ef3eb7ca797fe26e985938f11d067e66/src/services/RequestHandlers/Handler/RequestHandlerExtensions.cs)*