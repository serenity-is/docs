# DefaultUserClaimCreator class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default implementation of [`IUserClaimCreator`](../Serenity.Abstractions/IUserClaimCreator.md) that builds a ClaimsPrincipal from a user definition retrieved via [`IUserRetrieveService`](../Serenity.Abstractions/IUserRetrieveService.md).

```csharp
public class DefaultUserClaimCreator : IUserClaimCreator
```

| parameter | description |
| --- | --- |
| userRetriever | The service used to retrieve user definitions by username. |

## Public Members

| name | description |
| --- | --- |
| [DefaultUserClaimCreator](DefaultUserClaimCreator/DefaultUserClaimCreator.md)(…) | Default implementation of [`IUserClaimCreator`](../Serenity.Abstractions/IUserClaimCreator.md) that builds a ClaimsPrincipal from a user definition retrieved via [`IUserRetrieveService`](../Serenity.Abstractions/IUserRetrieveService.md). |
| virtual [CreatePrincipal](DefaultUserClaimCreator/CreatePrincipal.md)(…) | Creates a principal for the specified user. |

## Protected Members

| name | description |
| --- | --- |
| virtual [AddClaims](DefaultUserClaimCreator/AddClaims.md)(…) | Adds claims to the specified identity for the given user definition. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *userRetriever* is `null`. |

## Remarks

Creates a new instance of the [`DefaultUserClaimCreator`](DefaultUserClaimCreator.md) class.

## See Also

* interface [IUserClaimCreator](../Serenity.Abstractions/IUserClaimCreator.md)
* **Source:** *[DefaultUserClaimCreator.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/DefaultUserClaimCreator.cs)*