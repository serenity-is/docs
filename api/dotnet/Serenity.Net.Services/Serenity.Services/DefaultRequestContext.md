# DefaultRequestContext class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for a [`IRequestContext`](IRequestContext.md)

```csharp
public class DefaultRequestContext : IRequestContext
```

| parameter | description |
| --- | --- |
| behaviors | Behavior provider |
| cache | Two level cache |
| localizer | Text localizer |
| permissions | Permissions |
| userAccessor | User access |

## Public Members

| name | description |
| --- | --- |
| [DefaultRequestContext](DefaultRequestContext/DefaultRequestContext.md)(…) | Default implementation for a [`IRequestContext`](IRequestContext.md) |
| [Behaviors](DefaultRequestContext/Behaviors.md) { get; } |  |
| [Cache](DefaultRequestContext/Cache.md) { get; } |  |
| [Localizer](DefaultRequestContext/Localizer.md) { get; } |  |
| [Permissions](DefaultRequestContext/Permissions.md) { get; } |  |
| [User](DefaultRequestContext/User.md) { get; } |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Any of the arguments is null |

## Remarks

Creates an instance of the class

## See Also

* interface [IRequestContext](IRequestContext.md)
* **Source:** *[DefaultRequestContext.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Repository/DefaultRequestContext.cs)*