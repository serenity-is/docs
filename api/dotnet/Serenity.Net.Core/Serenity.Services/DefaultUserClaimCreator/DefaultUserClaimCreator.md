# DefaultUserClaimCreator constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Default implementation of [`IUserClaimCreator`](../../Serenity.Abstractions/IUserClaimCreator.md) that builds a ClaimsPrincipal from a user definition retrieved via [`IUserRetrieveService`](../../Serenity.Abstractions/IUserRetrieveService.md).

```csharp
public DefaultUserClaimCreator(IUserRetrieveService userRetriever)
```

| parameter | description |
| --- | --- |
| userRetriever | The service used to retrieve user definitions by username. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *userRetriever* is `null`. |

## Remarks

Creates a new instance of the [`DefaultUserClaimCreator`](../DefaultUserClaimCreator.md) class.

## See Also

* interface [IUserRetrieveService](../../Serenity.Abstractions/IUserRetrieveService.md)
* class [DefaultUserClaimCreator](../DefaultUserClaimCreator.md)