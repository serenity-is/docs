# BinarySerialization.Deserialize&lt;TValue&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

A helper method to deserialize objects with BinaryWriter. Creates a memory stream and a BinaryReader on it, and invokes the callback specified.

```csharp
public static TValue Deserialize<TValue>(byte[] input, Func<BinaryReader, TValue> deserialize)
```

| parameter | description |
| --- | --- |
| input | Input array |
| deserialize | Deserialization delegate |

## See Also

* class [TValue](../Serenity.Net.Core/../BinarySerialization.TValue.md)
* class [BinarySerialization](../BinarySerialization.md)