# MembershipPageBase&lt;TUserRow&gt;.CalculateHash method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Calculates the SHA-512 hash of the password combined with the salt.

```csharp
protected virtual string CalculateHash(string password, string salt)
```

| parameter | description |
| --- | --- |
| password | The password. |
| salt | The salt. |

## Return Value

The computed hash.

## See Also

* class [MembershipPageBase&lt;TUserRow&gt;](../MembershipPageBase-1.md)