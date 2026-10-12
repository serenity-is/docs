# ListRequestPagingParams.ExcludeTotalCount property

Gets or sets the requested [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md) value. `true` excludes the total count, `false` requests it, and `null` (the default, unspecified) leaves the decision to [`IncludeMore`](./IncludeMore.md) and [`ExcludeTotalCountByDefault`](./ExcludeTotalCountByDefault.md).

```csharp
public bool? ExcludeTotalCount { get; set; }
```

## See Also

* class [ListRequestPagingParams](../ListRequestPagingParams.md)