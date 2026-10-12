# RequestHandlerExtensions.SuppressPagingLimits&lt;TRequest&gt; method

Sets whether paging limits ([`DefaultPageSize`](../RequestHandlerSettings/DefaultPageSize.md) / [`MaxPageSize`](../RequestHandlerSettings/MaxPageSize.md)) should be ignored for the list request. Server side code that needs all rows (e.g. exports, reports, background jobs, nested relation loads) should call this; otherwise enabling the limits may silently truncate the results. Has no effect on JSON bound client requests.

```csharp
public static TRequest SuppressPagingLimits<TRequest>(this TRequest request, bool suppress = true)
    where TRequest : ListRequest
```

| parameter | description |
| --- | --- |
| TRequest | List request type. |
| request | The list request. |
| suppress | True to ignore paging limits, false to apply them. |

## Return Value

The same request, for chaining.

## See Also

* class [ListRequest](../ListRequest.md)
* class [RequestHandlerExtensions](../RequestHandlerExtensions.md)