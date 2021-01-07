# AuthorizationExtensions.GetUserDefinition method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets user definition for given user identity

```csharp
public static IUserDefinition GetUserDefinition(this ClaimsPrincipal identity, 
    IUserRetrieveService userRetrieveService)
```

| parameter | description |
| --- | --- |
| identity |  |
| userRetrieveService | User retrieve service |

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition&lt;TUserDefinition&gt; method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets user definition for given user identity

```csharp
public static TUserDefinition GetUserDefinition<TUserDefinition>(this ClaimsPrincipal identity, 
    IUserRetrieveService userRetrieveService)
    where TUserDefinition : class, IUserDefinition
```

| parameter | description |
| --- | --- |
| identity |  |
| userRetrieveService | User retrieve service |

## See Also

* class [TUserDefinition](../Serenity.Net.Core/../AuthorizationExtensions.TUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IUserDefinition](../IUserDefinition.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)