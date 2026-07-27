# AuthorizationExtensions.GetUserDefinition method (1 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets user definition for current user

```csharp
public static IUserDefinition GetUserDefinition(this IUserProvider userProvider)
```

| parameter | description |
| --- | --- |
| userProvider | User provider |

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserProvider](../../Serenity.Abstractions/IUserProvider.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition method (2 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets user definition for given user identity

```csharp
public static IUserDefinition GetUserDefinition(this ClaimsPrincipal identity, 
    IUserRetrieveService userRetriever)
```

| parameter | description |
| --- | --- |
| identity |  |
| userRetriever | User retrieve service |

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition method (3 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets user definition for given user identity

```csharp
public static IUserDefinition GetUserDefinition(this IUserRetrieveService userRetriever, 
    ClaimsPrincipal identity)
```

| parameter | description |
| --- | --- |
| userRetriever | User retrieve service |
| identity |  |

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition&lt;TUserDefinition&gt; method (4 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets user definition for given user identity

```csharp
public static TUserDefinition GetUserDefinition<TUserDefinition>(this ClaimsPrincipal identity, 
    IUserRetrieveService userRetriever)
    where TUserDefinition : class, IUserDefinition
```

| parameter | description |
| --- | --- |
| identity |  |
| userRetriever | User retrieve service |

## See Also

* class [TUserDefinition](../Serenity.Net.Core/../AuthorizationExtensions.TUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IUserDefinition](../IUserDefinition.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)