# ServiceQueryHelper.ApplyPagingLimits method

Applies the configured paging limits ([`DefaultPageSize`](../RequestHandlerSettings/DefaultPageSize.md) and [`MaxPageSize`](../RequestHandlerSettings/MaxPageSize.md)) to [`Take`](../ListRequestPagingParams/Take.md), changing it in place. A zero take is replaced by the default page size, then clamped to the maximum page size when set.

```csharp
public static ListRequestPagingParams ApplyPagingLimits(this ListRequestPagingParams paging, 
    RequestHandlerSettings settings, bool suppressed = false)
```

| parameter | description |
| --- | --- |
| paging | Paging parameters (required). |
| settings | Handler settings that provide the limits (required). |
| suppressed | True to bypass the configured limits. |

## Return Value

The same paging parameters, for chaining.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *paging* or *settings* is null. |

## See Also

* class [ListRequestPagingParams](../ListRequestPagingParams.md)
* class [RequestHandlerSettings](../RequestHandlerSettings.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)