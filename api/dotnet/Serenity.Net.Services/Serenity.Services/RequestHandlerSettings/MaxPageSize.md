# RequestHandlerSettings.MaxPageSize property

Gets or sets the maximum page size (take) allowed for List requests. When greater than zero, a requested page size larger than this is clamped to this value, and an unspecified page size is also limited to this value. The response returns the applied take. Zero means no limit.

```csharp
public int MaxPageSize { get; set; }
```

## Remarks

WARNING: This has the same risks as [`DefaultPageSize`](./DefaultPageSize.md) (truncation of server side enumerations and grids without a pager, and an added total count whenever the take becomes non-zero, even when [`ExcludeTotalCountByDefault`](./ExcludeTotalCountByDefault.md) is enabled). Server side callers that need all rows must call [`SuppressPagingLimits`](../RequestHandlerExtensions/SuppressPagingLimits.md). Do not enable this without auditing existing List usages, and avoid low values. Negative values are ignored (treated as zero, i.e. no limit).

## See Also

* class [RequestHandlerSettings](../RequestHandlerSettings.md)