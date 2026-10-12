# DefaultRequestContext class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for a [`IRequestContext`](./IRequestContext.md).

```csharp
public class DefaultRequestContext : IHasHandlerSettings, IRequestContext
```

| parameter | description |
| --- | --- |
| behaviors | Behavior provider |
| cache | Two level cache |
| localizer | Text localizer |
| permissions | Permissions |
| userAccessor | User access |
| handlerSettings | Request handler settings |

## Public Members

| name | description |
| --- | --- |
| [DefaultRequestContext](DefaultRequestContext/DefaultRequestContext.md)(…) | Default implementation for a [`IRequestContext`](./IRequestContext.md). |
| [Behaviors](DefaultRequestContext/Behaviors.md) { get; } |  |
| [Cache](DefaultRequestContext/Cache.md) { get; } |  |
| [HandlerSettings](DefaultRequestContext/HandlerSettings.md) { get; } |  |
| [Localizer](DefaultRequestContext/Localizer.md) { get; } |  |
| [Permissions](DefaultRequestContext/Permissions.md) { get; } |  |
| [User](DefaultRequestContext/User.md) { get; } |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Any of the arguments is `null`. |

## Remarks

This implementation is registered as a singleton by default, so it assumes its dependencies (e.g. IUserAccessor, IPermissionService, ITextLocalizer) are also registered as singletons. The default IUserAccessor implementation in web applications reads the current user from the ambient HTTP context, so a singleton is safe in that case.

If you need scoped implementations of any of these dependencies, register your own [`IRequestContext`](./IRequestContext.md) implementation and resolve them on demand from ServiceProvider (which returns the current request's scoped provider in web applications, and the root provider otherwise) instead of capturing them in the constructor.

## See Also

* interface [IHasHandlerSettings](./IHasHandlerSettings.md)
* interface [IRequestContext](./IRequestContext.md)
* **Source:** *[DefaultRequestContext.cs](https://github.com/serenity-is/Serenity/blob/df6fb676c90d207452f30ac96d17cc9ba967a264/src/services/RequestHandlers/Repository/DefaultRequestContext.cs)*