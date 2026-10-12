# DefaultHandlerRegistry class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for the [`IDefaultHandlerRegistry`](./IDefaultHandlerRegistry.md).

```csharp
public class DefaultHandlerRegistry : IDefaultHandlerRegistry, IDisposable
```

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerRegistry](DefaultHandlerRegistry/DefaultHandlerRegistry.md)(…) | Initializes a new instance of the class. |
| [Dispose](DefaultHandlerRegistry/Dispose.md)() |  |
| virtual [GetTypes](DefaultHandlerRegistry/GetTypes.md)() |  |
| [GetTypes](DefaultHandlerRegistry/GetTypes.md)(…) |  |

## Remarks

Scans the ITypeSource lazily on first use and caches the concrete IRequestHandler types. When the type source also implements IChangeTokenProvider, the cache is reset whenever its change token fires, e.g. when dynamic assemblies or feature toggles change, and rebuilt on next use. A failed scan is not cached, so a later call retries it.

## See Also

* interface [IDefaultHandlerRegistry](./IDefaultHandlerRegistry.md)
* **Source:** *[DefaultHandlerRegistry.cs](https://github.com/serenity-is/Serenity/blob/95342587aebf71b494e0c09221452e4fd9429d1b/src/services/RequestHandlers/Handler/DefaultHandlerRegistry.cs)*