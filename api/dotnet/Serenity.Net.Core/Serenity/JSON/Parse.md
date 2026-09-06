# JSON.Parse method (1 of 2)

Deserializes a JSON string to an object

```csharp
public static object? Parse(string input, Type targetType, JsonSerializerOptions? options = null)
```

| parameter | description |
| --- | --- |
| targetType | Type to deserialize |
| options | Serializer options. Defaults to StrictWriteNulls. |
| input | JSON string |

## Return Value

Deserialized object

## See Also

* class [JSON](../JSON.md)

---

# JSON.Parse&lt;T&gt; method (2 of 2)

Deserializes a JSON string to an object

```csharp
public static T? Parse<T>(string input, JsonSerializerOptions? options = null)
```

| parameter | description |
| --- | --- |
| T | Type to deserialize |
| input | JSON string |
| options | Serializer options. Defaults to StrictWriteNulls. |

## Return Value

Deserialized object

## See Also

* class [JSON](../JSON.md)