# IHasHandlerSettings interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Optional capability for an [`IRequestContext`](./IRequestContext.md) implementation to provide [`RequestHandlerSettings`](./RequestHandlerSettings.md). When the context does not implement this interface, [`Default`](./RequestHandlerSettings/Default.md) is used.

```csharp
public interface IHasHandlerSettings
```

## Members

| name | description |
| --- | --- |
| [HandlerSettings](IHasHandlerSettings/HandlerSettings.md) { get; } | Gets the request handler settings. |

## See Also

* **Source:** *[IHasHandlerSettings.cs](https://github.com/serenity-is/Serenity/blob/28b68737bc8f157a094a9d003f9d247685b04b60/src/services/RequestHandlers/Handler/IHasHandlerSettings.cs)*