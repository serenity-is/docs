# DataProtectorBinaryTokenExtensions.ProtectBinary method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Encrypts a token populated by the given callback and returns the encrypted token in base64 URL encoded format

```csharp
public static string ProtectBinary(this IDataProtector protector, Action<BinaryWriter> callback)
```

| parameter | description |
| --- | --- |
| protector | Data protector |
| callback | Callback to populate the writer |

## See Also

* class [DataProtectorBinaryTokenExtensions](../DataProtectorBinaryTokenExtensions.md)