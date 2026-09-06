# IChangeTokenProvider interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for an object that can provide a change token that fires when its content changes. The object itself does not need to detect changes; external code may trigger the token and consumers subscribe to it to invalidate their caches.

```csharp
public interface IChangeTokenProvider
```

## Members

| name | description |
| --- | --- |
| [GetChangeToken](IChangeTokenProvider/GetChangeToken.md)() | Gets a change token that fires when the object's content changes. |

## See Also

* **Source:** *[IChangeTokenProvider.cs](https://github.com/serenity-is/Serenity/blob/3d49a4525ab0022015db75294315ec4aa3d0283d/src/core/ComponentModel/Extensibility/IChangeTokenProvider.cs)*