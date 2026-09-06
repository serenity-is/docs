# IChangeNotifier interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for an object that can be externally notified that its content has changed. The object itself does not need to detect changes; external code calls [`NotifyChanged`](./IChangeNotifier/NotifyChanged.md) and consumers subscribe to the change token to invalidate their caches.

```csharp
public interface IChangeNotifier
```

## Members

| name | description |
| --- | --- |
| [NotifyChanged](IChangeNotifier/NotifyChanged.md)() | Notifies subscribers that the object's content has changed. |

## See Also

* **Source:** *[IChangeNotifier.cs](https://github.com/serenity-is/Serenity/blob/3d49a4525ab0022015db75294315ec4aa3d0283d/src/core/ComponentModel/Extensibility/IChangeNotifier.cs)*