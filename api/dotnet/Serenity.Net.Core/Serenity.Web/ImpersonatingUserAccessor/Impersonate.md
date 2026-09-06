# ImpersonatingUserAccessor.Impersonate method

Pushes the specified principal onto the impersonation stack.

```csharp
public void Impersonate(ClaimsPrincipal user)
```

| parameter | description |
| --- | --- |
| user | The principal to impersonate. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *user* is `null`. |

## See Also

* class [ImpersonatingUserAccessor](../ImpersonatingUserAccessor.md)