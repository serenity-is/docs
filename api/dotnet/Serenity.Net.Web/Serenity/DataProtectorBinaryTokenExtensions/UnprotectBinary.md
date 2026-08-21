# DataProtectorBinaryTokenExtensions.UnprotectBinary method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Decrypts the given token in base64 URL encoded format and returns a binary reader over the decrypted data.

```csharp
public static BinaryReader UnprotectBinary(this IDataProtector protector, string token)
```

| parameter | description |
| --- | --- |
| protector | The data protector. |
| token | The encrypted token in base64 URL encoded format. |

## Return Value

A BinaryReader over the decrypted data.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *token* is `null`. |

## See Also

* class [DataProtectorBinaryTokenExtensions](../DataProtectorBinaryTokenExtensions.md)