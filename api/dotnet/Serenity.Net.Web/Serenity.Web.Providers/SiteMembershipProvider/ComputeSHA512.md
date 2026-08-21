# SiteMembershipProvider.ComputeSHA512 method
**namespace:** *[Serenity.Web.Providers](../../README.md#serenity.web.providers-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

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