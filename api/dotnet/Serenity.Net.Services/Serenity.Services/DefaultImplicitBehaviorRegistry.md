# DefaultImplicitBehaviorRegistry class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for the [`IImplicitBehaviorRegistry`](./IImplicitBehaviorRegistry.md)

```csharp
public class DefaultImplicitBehaviorRegistry : IDisposable, IImplicitBehaviorRegistry
```

## Public Members

| name | description |
| --- | --- |
| [DefaultImplicitBehaviorRegistry](DefaultImplicitBehaviorRegistry/DefaultImplicitBehaviorRegistry.md)(…) | Initializes a new instance of the class. |
| [Dispose](DefaultImplicitBehaviorRegistry/Dispose.md)() |  |
| [GetTypes](DefaultImplicitBehaviorRegistry/GetTypes.md)() |  |

## Remarks

Scans the ITypeSource lazily on first use and caches the concrete [`IImplicitBehavior`](./IImplicitBehavior.md) types. When the type source also implements IChangeTokenProvider, the cache is reset whenever its change token fires, e.g. when dynamic assemblies or feature toggles change, and rebuilt on next use. A failed scan is not cached, so a later call retries it.

## See Also

* interface [IImplicitBehaviorRegistry](./IImplicitBehaviorRegistry.md)
* **Source:** *[DefaultImplicitBehaviorRegistry.cs](https://github.com/serenity-is/Serenity/blob/95342587aebf71b494e0c09221452e4fd9429d1b/src/services/RequestHandlers/Behavior/DefaultImplicitBehaviorRegistry.cs)*