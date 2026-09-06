# BinarySerialization.Deserialize&lt;TValue&gt; method

A helper method to deserialize objects with BinaryReader. Creates a memory stream and a BinaryReader on it, and invokes the callback specified.

```csharp
public static TValue Deserialize<TValue>(byte[] input, Func<BinaryReader, TValue> deserialize)
```

| parameter | description |
| --- | --- |
| input | Input array. |
| deserialize | Deserialization delegate. |

## See Also

* class [BinarySerialization](../BinarySerialization.md)