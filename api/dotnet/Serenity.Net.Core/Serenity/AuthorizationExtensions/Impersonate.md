# AuthorizationExtensions.Impersonate method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Impersonates the user with the specified username.

```csharp
public static void Impersonate(this IUserProvider userProvider, string username, 
    string authType = "Impersonation")
```

| parameter | description |
| --- | --- |
| userProvider | The user provider that performs the impersonation. |
| username | The username of the user to impersonate. |
| authType | The authentication type to assign to the new principal. Defaults to `Impersonation`. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | No user exists with the specified username. |
| InvalidOperationException | The underlying accessor does not support impersonation. |

## See Also

* interface [IUserProvider](../../Serenity.Abstractions/IUserProvider.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)