# ISaveBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marker interface for save behaviors that can be used as a mixin within a SaveRequestHandler lifecycle.

```csharp
public interface ISaveBehavior
```

## Remarks

All save behaviors should implement either [`ISaveBehaviorSync`](ISaveBehaviorSync.md) or [`ISaveBehaviorAsync`](ISaveBehaviorAsync.md), not this interface directly.

## See Also

* **Source:** *[ISaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/ISaveBehavior.cs)*