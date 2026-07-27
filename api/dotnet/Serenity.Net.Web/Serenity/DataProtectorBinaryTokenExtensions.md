# DataProtectorBinaryTokenExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Extension methods for data protector to support tokens created via BinaryWriter

```csharp
public static class DataProtectorBinaryTokenExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ProtectBinary](DataProtectorBinaryTokenExtensions/ProtectBinary.md)(…) | Encrypts a token populated by the given callback and returns the encrypted token in base64 URL encoded format |
| static [UnprotectBinary](DataProtectorBinaryTokenExtensions/UnprotectBinary.md)(…) | Decrypts the given token in base64 URL encoded format and return a binary reader with the decrypted data |

## See Also

* **Source:** *[DataProtectorBinaryTokenExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Security/DataProtectorBinaryTokenExtensions.cs)*