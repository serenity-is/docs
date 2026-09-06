# IWrappedBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for behaviors that wrap another behavior to adapt it between synchronous and asynchronous variants. Exposes the inner behavior so framework code can check whether it implements additional interfaces (e.g. [`ISaveExceptionBehavior`](ISaveExceptionBehavior.md)).

```csharp
public interface IWrappedBehavior
```

## Members

| name | description |
| --- | --- |
| [WrappedBehavior](IWrappedBehavior/WrappedBehavior.md) { get; } | Gets the wrapped (inner) behavior. |

## See Also

* **Source:** *[IWrappedBehavior.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Behavior/IWrappedBehavior.cs)*