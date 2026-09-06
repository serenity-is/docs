# JsonRowConverter.ReadJson method

Reads the JSON representation of the object.

```csharp
public override object ReadJson(JsonReader reader, Type objectType, object existingValue, 
    JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The JsonReader to read from. |
| objectType | Type of the object. |
| existingValue | The existing value of object being read. |
| serializer | The calling serializer. |

## Return Value

The object value.

## See Also

* class [JsonRowConverter](../JsonRowConverter.md)