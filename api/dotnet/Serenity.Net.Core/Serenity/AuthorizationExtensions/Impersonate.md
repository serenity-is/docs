# AuthorizationExtensions.Impersonate method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Impersonates a user by its username. Note that this throws an exception if the user is not found, or the underlying user accessor is not an impersonator.

```csharp
public static void Impersonate(this IUserProvider userProvider, string username, 
    string authType = "Impersonation")
```

| parameter | description |
| --- | --- |
| userProvider | User provider |
| username | Username |
| authType | Authentication type to use while creating the ClaimsPrincipal. Default is "Impersonation". |

## See Also

* interface [IUserProvider](../../Serenity.Abstractions/IUserProvider.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)