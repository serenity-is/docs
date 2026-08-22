# BinarySerialization class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper functions for serialization and deserialization of data items (e.g. cached items).

```csharp
public static class BinarySerialization
```

## Public Members

| name | description |
| --- | --- |
| static [Deserialize&lt;TValue&gt;](BinarySerialization/Deserialize.md)(…) | A helper method to deserialize objects with BinaryReader. Creates a memory stream and a BinaryReader on it, and invokes the callback specified. |
| static [Serialize](BinarySerialization/Serialize.md)(…) | A helper method to serialize objects with BinaryWriter. Creates a memory stream and a BinaryWriter on it, and invokes the callback specified. |

## See Also

* **Source:** *[BinarySerialization.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Helpers/BinarySerialization.cs)*