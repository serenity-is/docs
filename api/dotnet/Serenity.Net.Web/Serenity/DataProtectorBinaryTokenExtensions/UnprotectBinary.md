# DataProtectorBinaryTokenExtensions.UnprotectBinary method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Decrypts the given token in base64 URL encoded format and return a binary reader with the decrypted data

```csharp
public static BinaryReader UnprotectBinary(this IDataProtector protector, string token)
```

| parameter | description |
| --- | --- |
| protector | Data protector |
| token | Encrypted token in base 64 URL encoded format |

## See Also

* class [DataProtectorBinaryTokenExtensions](../DataProtectorBinaryTokenExtensions.md)