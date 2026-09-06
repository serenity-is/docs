# DefaultUserClaimCreator.CreatePrincipal method

Creates a principal for the specified user.

```csharp
public virtual ClaimsPrincipal CreatePrincipal(string username, string authType)
```

| parameter | description |
| --- | --- |
| username | The username of the user to create the principal for. |
| authType | The authentication type to assign to the created identity. |

## Return Value

The created ClaimsPrincipal.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *username* or *authType* is `null`. |
| ArgumentOutOfRangeException | No user exists with the specified *username*. |

## See Also

* class [DefaultUserClaimCreator](../DefaultUserClaimCreator.md)