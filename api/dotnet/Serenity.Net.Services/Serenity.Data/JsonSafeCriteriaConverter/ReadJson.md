# JsonSafeCriteriaConverter.ReadJson method

Reads the JSON representation of the object.

```csharp
public override object ReadJson(JsonReader reader, Type objectType, object existingValue, 
    JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The JsonReader to read from. |
| objectType | The type of the object. |
| existingValue | The existing value of the object being read. |
| serializer | The calling serializer. |

## Return Value

The object value.

## See Also

* class [JsonSafeCriteriaConverter](../JsonSafeCriteriaConverter.md)