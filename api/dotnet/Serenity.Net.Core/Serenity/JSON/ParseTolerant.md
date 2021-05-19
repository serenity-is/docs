# JSON.ParseTolerant method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deserializes a JSON string to an object, using more tolerant settings

```csharp
public static object ParseTolerant(string input, Type targetType, bool includeNulls = false)
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

# JSON.ParseTolerant&lt;T&gt; method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Deserializes a JSON string to an object, using more tolerant settings.

```csharp
public static T ParseTolerant<T>(string input, bool includeNulls = false)
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