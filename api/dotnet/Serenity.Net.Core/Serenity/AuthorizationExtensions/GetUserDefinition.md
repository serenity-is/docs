# AuthorizationExtensions.GetUserDefinition method (1 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the user definition for the currently authenticated user.

```csharp
public static IUserDefinition GetUserDefinition(this IUserProvider userProvider)
```

| parameter | description |
| --- | --- |
| userProvider | The user provider that supplies the current principal. |

## Return Value

The user definition, or `null` if no user is authenticated or the user is not found.

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserProvider](../../Serenity.Abstractions/IUserProvider.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition method (2 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the user definition for the specified principal.

```csharp
public static IUserDefinition GetUserDefinition(this ClaimsPrincipal identity, 
    IUserRetrieveService userRetriever)
```

| parameter | description |
| --- | --- |
| identity | The principal whose identity name is used for lookup. |
| userRetriever | The service used to retrieve the user definition. |

## Return Value

The user definition, or `null` if the principal is not authenticated or the user is not found.

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition method (3 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the user definition for the specified principal.

```csharp
public static IUserDefinition GetUserDefinition(this IUserRetrieveService userRetriever, 
    ClaimsPrincipal identity)
```

| parameter | description |
| --- | --- |
| userRetriever | The service used to retrieve the user definition. |
| identity | The principal whose identity name is used for lookup. |

## Return Value

The user definition, or `null` if the principal is not authenticated or the user is not found.

## See Also

* interface [IUserDefinition](../IUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)

---

# AuthorizationExtensions.GetUserDefinition&lt;TUserDefinition&gt; method (4 of 4)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the typed user definition for the specified principal.

```csharp
public static TUserDefinition GetUserDefinition<TUserDefinition>(this ClaimsPrincipal identity, 
    IUserRetrieveService userRetriever)
    where TUserDefinition : class, IUserDefinition
```

| parameter | description |
| --- | --- |
| TUserDefinition | The concrete user definition type. |
| identity | The principal whose identity name is used for lookup. |
| userRetriever | The service used to retrieve the user definition. |

## Return Value

The typed user definition, or `null` if the principal is not authenticated or the user is not found.

## See Also

* class [TUserDefinition](../Serenity.Net.Core/../AuthorizationExtensions.TUserDefinition.md)
* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* interface [IUserDefinition](../IUserDefinition.md)
* class [AuthorizationExtensions](../AuthorizationExtensions.md)