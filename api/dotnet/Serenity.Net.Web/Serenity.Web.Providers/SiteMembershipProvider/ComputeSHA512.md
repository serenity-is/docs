# SiteMembershipProvider.ComputeSHA512 method

Computes the SHA512 hash of the given string.

```csharp
public static string ComputeSHA512(string s)
```

| parameter | description |
| --- | --- |
| s | The string to hash. |

## Return Value

The base64 encoded SHA512 hash with padding stripped.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *s* is null or empty. |

## See Also

* class [SiteMembershipProvider](../SiteMembershipProvider.md)