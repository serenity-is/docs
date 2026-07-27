# JSON.PopulateObject&lt;T&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to populate an existing object similar to JsonConvert's PopulateObject

```csharp
public static void PopulateObject<T>(T target, string jsonSource, JsonSerializerOptions options)
    where T : class
```

| parameter | description |
| --- | --- |
| T | Type of the object |
| target | Target object |
| jsonSource | JSON string |
| options | Serializer options |

## See Also

* class [T](../Serenity.Net.Core/../JSON.T.md)
* class [JSON](../JSON.md)