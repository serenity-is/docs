# AuthorizationExtensions.IsLoggedIn method (1 of 2)

Determines whether the specified principal is authenticated.

```csharp
public static bool IsLoggedIn(this ClaimsPrincipal? user)
```

| parameter | description |
| --- | --- |
| user | The principal to check. |

## Return Value

`true` if the principal is authenticated; otherwise `false`.

## See Also

* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.IsLoggedIn method (2 of 2)

Determines whether the user accessed via *userAccessor* is authenticated.

```csharp
public static bool IsLoggedIn(this IUserAccessor? userAccessor)
```

| parameter | description |
| --- | --- |
| userAccessor | The accessor that provides the current user principal. |

## Return Value

`true` if a user is authenticated; otherwise `false`.

## See Also

* interface [IUserAccessor](../../Serenity.Abstractions/IUserAccessor.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)