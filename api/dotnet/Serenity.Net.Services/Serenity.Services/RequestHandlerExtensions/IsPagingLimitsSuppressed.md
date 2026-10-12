# RequestHandlerExtensions.IsPagingLimitsSuppressed&lt;TRequest&gt; method

Gets whether paging limits ([`DefaultPageSize`](../RequestHandlerSettings/DefaultPageSize.md) / [`MaxPageSize`](../RequestHandlerSettings/MaxPageSize.md)) are suppressed for the list request, e.g. set via [`SuppressPagingLimits`](./SuppressPagingLimits.md).

```csharp
public static bool IsPagingLimitsSuppressed<TRequest>(this TRequest request)
    where TRequest : ListRequest
```

| parameter | description |
| --- | --- |
| TRequest | List request type. |
| request | The list request. |

## Return Value

True if paging limits should be ignored.

## See Also

* class [ListRequest](../ListRequest.md)
* class [RequestHandlerExtensions](../RequestHandlerExtensions.md)