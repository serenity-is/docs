# BinarySerialization.Serialize method

A helper method to serialize objects with BinaryWriter. Creates a memory stream and a BinaryWriter on it, and invokes the callback specified.

```csharp
public static byte[] Serialize(Action<BinaryWriter> serialize)
```

| parameter | description |
| --- | --- |
| serialize | Serialization delegate |

## See Also

* class [BinarySerialization](../BinarySerialization.md)