# CompanionHandlerTypeAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies the companion (other mode) handler interface for a request processor interface, e.g. [`ISaveRequestProcessorAsync`](./ISaveRequestProcessorAsync.md) as companion of [`ISaveRequestProcessor`](./ISaveRequestProcessor.md), together with a wrapper type that adapts a custom handler of the companion interface to this interface.

```csharp
[AttributeUsage(AttributeTargets.Interface)]
public class CompanionHandlerTypeAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [CompanionHandlerTypeAttribute](CompanionHandlerTypeAttribute/CompanionHandlerTypeAttribute.md)(…) | Specifies the companion (other mode) handler interface for a request processor interface, e.g. [`ISaveRequestProcessorAsync`](./ISaveRequestProcessorAsync.md) as companion of [`ISaveRequestProcessor`](./ISaveRequestProcessor.md), together with a wrapper type that adapts a custom handler of the companion interface to this interface. |
| [CompanionType](CompanionHandlerTypeAttribute/CompanionType.md) { get; } | Gets the companion (other mode) handler interface type. |
| [WrapperType](CompanionHandlerTypeAttribute/WrapperType.md) { get; } | Gets the open generic wrapper type that adapts a handler implementing [`CompanionType`](./CompanionHandlerTypeAttribute/CompanionType.md) to the interface this attribute is applied to. |

## Remarks

This attribute is used by [`DefaultHandlerFactory`](./DefaultHandlerFactory.md) to discover custom request handlers of the other (sync / async) mode, when no custom handler exists for the requested mode. For example when an async behavior requests [`ISaveRequestProcessor`](./ISaveRequestProcessor.md) for a row, but only an async custom handler implementing [`ISaveRequestProcessorAsync`](./ISaveRequestProcessorAsync.md) is available, the factory returns the async custom handler wrapped in the specified wrapper type so that custom handler logic is not silently skipped.

## See Also

* **Source:** *[CompanionHandlerTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Handler/CompanionHandlerTypeAttribute.cs)*