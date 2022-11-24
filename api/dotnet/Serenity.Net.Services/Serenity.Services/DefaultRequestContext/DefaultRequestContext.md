# DefaultRequestContext constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates an instance of the class

```csharp
public DefaultRequestContext(IBehaviorProvider behaviors, ITwoLevelCache cache, 
    ITextLocalizer localizer, IPermissionService permissions, IUserAccessor userAccessor)
```

| parameter | description |
| --- | --- |
| behaviors | Behavior provider |
| cache | Two level cache |
| localizer | Text localizer |
| permissions | Permissions |
| userAccessor | User access |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Any of the arguments is null |

## See Also

* interface [IBehaviorProvider](../IBehaviorProvider.md)
* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [IUserAccessor](../Serenity.Net.Core/../../Serenity.Abstractions/IUserAccessor.md)
* class [DefaultRequestContext](../DefaultRequestContext.md)