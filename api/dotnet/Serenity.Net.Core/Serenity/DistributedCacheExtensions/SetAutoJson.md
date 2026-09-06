# DistributedCacheExtensions.SetAutoJson&lt;TValue&gt; method (1 of 2)

Sets a value in the cache as byte[], string, or using JSON serialization depending on type of TValue

```csharp
public static void SetAutoJson<TValue>(this IDistributedCache cache, string key, TValue? value)
    where TValue : class
```

| parameter | description |
| --- | --- |
| cache | Cache |
| key | Key |
| value | Value |

## See Also

* class [DistributedCacheExtensions](../DistributedCacheExtensions.md)

---

# DistributedCacheExtensions.SetAutoJson&lt;TValue&gt; method (2 of 2)

Sets a value in the cache as byte[], string, or using JSON serialization depending on type of TValue

```csharp
public static void SetAutoJson<TValue>(this IDistributedCache cache, string key, TValue? value, 
    TimeSpan expiration)
    where TValue : class
```

| parameter | description |
| --- | --- |
| cache | Cache |
| key | Key |
| value | Value |
| expiration | Expiration |

## See Also

* class [DistributedCacheExtensions](../DistributedCacheExtensions.md)