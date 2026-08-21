# IUserClaimCreator.CreatePrincipal method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a principal for the specified user.

```csharp
public ClaimsPrincipal CreatePrincipal(string username, string authType)
```

| parameter | description |
| --- | --- |
| username | The username of the user to create the principal for. |
| authType | The authentication type to assign to the created identity. |

## Return Value

The created ClaimsPrincipal.

## See Also

* interface [IUserClaimCreator](../IUserClaimCreator.md)