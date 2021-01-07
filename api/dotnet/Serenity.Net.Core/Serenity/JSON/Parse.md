# JSON.Parse method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deserializes a JSON string to an object

```csharp
public static object Parse(string input, Type targetType, bool includeNulls = false)
```

| parameter | description |
| --- | --- |
| targetType | Type to deserialize |
| input | JSON string |
| includeNulls | If true, if a value is null and target property is not nullable, raises error. |

## Return Value

Deserialized object

## See Also

* class [JSON](../JSON.md)

---

# JSON.Parse&lt;T&gt; method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deserializes a JSON string to an object

```csharp
public static T Parse<T>(string input, bool includeNulls = false)
```

| parameter | description |
| --- | --- |
| T | Type to deserialize |
| input | JSON string |
| includeNulls | If true, if a value is null and target property is not nullable, raises error. |

## Return Value

Deserialized object

## See Also

* class [T](../Serenity.Net.Core/../JSON.T.md)
* class [JSON](../JSON.md)