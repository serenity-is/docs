# JsonSafeInt64Converter.ReadJson method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

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

* class [JsonSafeInt64Converter](../JsonSafeInt64Converter.md)