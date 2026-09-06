# CollectionExtensions.Get&lt;TKey,TValue&gt; method (1 of 2)

Gets the specified key or returns default value of TValue if not found.

```csharp
public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
```

| parameter | description |
| --- | --- |
| TKey | The type of the key. |
| TValue | The type of the value. |
| dict | The dictionary. |
| key | The key. |

## Return Value

Value for specified key, or default value if not found.

## See Also

* class [CollectionExtensions](../CollectionExtensions.md)

---

# CollectionExtensions.Get&lt;TKey,TValue&gt; method (2 of 2)

Gets the specified key or returns defaultValue if not found.

```csharp
public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, 
    TValue defaultValue)
```

| parameter | description |
| --- | --- |
| TKey | The type of the key. |
| TValue | The type of the value. |
| dict | The dictionary. |
| key | The key. |
| defaultValue | The default value. |

## Return Value

Value for specified key, or default value if not found.

## See Also

* class [CollectionExtensions](../CollectionExtensions.md)