# CompanionHandlerTypeAttribute constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Specifies the companion (other mode) handler interface for a request processor interface, e.g. [`ISaveRequestProcessorAsync`](../ISaveRequestProcessorAsync.md) as companion of [`ISaveRequestProcessor`](../ISaveRequestProcessor.md), together with a wrapper type that adapts a custom handler of the companion interface to this interface.

```csharp
public CompanionHandlerTypeAttribute(Type companionType, Type wrapperType)
```

## Remarks

This attribute is used by [`DefaultHandlerFactory`](../DefaultHandlerFactory.md) to discover custom request handlers of the other (sync / async) mode, when no custom handler exists for the requested mode. For example when an async behavior requests [`ISaveRequestProcessor`](../ISaveRequestProcessor.md) for a row, but only an async custom handler implementing [`ISaveRequestProcessorAsync`](../ISaveRequestProcessorAsync.md) is available, the factory returns the async custom handler wrapped in the specified wrapper type so that custom handler logic is not silently skipped.

## See Also

* class [CompanionHandlerTypeAttribute](../CompanionHandlerTypeAttribute.md)