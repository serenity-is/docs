# DefaultRequestContext constructor

Default implementation for a [`IRequestContext`](../IRequestContext.md).

```csharp
public DefaultRequestContext(IBehaviorProvider behaviors, ITwoLevelCache cache, 
    ITextLocalizer localizer, IPermissionService permissions, IUserAccessor userAccessor, 
    IOptions<RequestHandlerSettings>? handlerSettings = null)
```

| parameter | description |
| --- | --- |
| behaviors | Behavior provider |
| cache | Two level cache |
| localizer | Text localizer |
| permissions | Permissions |
| userAccessor | User access |
| handlerSettings | Request handler settings |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Any of the arguments is `null`. |

## Remarks

This implementation is registered as a singleton by default, so it assumes its dependencies (e.g. IUserAccessor, IPermissionService, ITextLocalizer) are also registered as singletons. The default IUserAccessor implementation in web applications reads the current user from the ambient HTTP context, so a singleton is safe in that case.

If you need scoped implementations of any of these dependencies, register your own [`IRequestContext`](../IRequestContext.md) implementation and resolve them on demand from ServiceProvider (which returns the current request's scoped provider in web applications, and the root provider otherwise) instead of capturing them in the constructor.

## See Also

* interface [IBehaviorProvider](../IBehaviorProvider.md)
* interface [ITwoLevelCache](../../../Serenity.Net.Core/Serenity.Abstractions/ITwoLevelCache.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [IUserAccessor](../../../Serenity.Net.Core/Serenity.Abstractions/IUserAccessor.md)
* class [RequestHandlerSettings](../RequestHandlerSettings.md)
* class [DefaultRequestContext](../DefaultRequestContext.md)