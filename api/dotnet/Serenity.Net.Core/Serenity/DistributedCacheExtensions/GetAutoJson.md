# DistributedCacheExtensions.GetAutoJson&lt;TValue&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sets a value from the cache as byte[], string, or using JSON deserialization depending on type

```csharp
public static TValue GetAutoJson<TValue>(this IDistributedCache cache, string key)
    where TValue : class
```

| parameter | description |
| --- | --- |
| cache | Cache |
| key | Key |

## See Also

* class [TValue](../Serenity.Net.Core/../DistributedCacheExtensions.TValue.md)
* class [DistributedCacheExtensions](../DistributedCacheExtensions.md)