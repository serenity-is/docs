# DataProtectorBinaryTokenExtensions.ProtectBinary method

Encrypts a token populated by the given callback and returns the encrypted token in base64 URL encoded format.

```csharp
public static string ProtectBinary(this IDataProtector protector, Action<BinaryWriter> callback)
```

| parameter | description |
| --- | --- |
| protector | The data protector. |
| callback | The callback used to populate the writer. |

## Return Value

The protected token in base64 URL encoded format.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *callback* is `null`. |

## See Also

* class [DataProtectorBinaryTokenExtensions](../DataProtectorBinaryTokenExtensions.md)