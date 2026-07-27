# DefaultHandlerRegistry class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implentation for the [`IDefaultHandlerFactory`](IDefaultHandlerFactory.md)

```csharp
public class DefaultHandlerRegistry : IDefaultHandlerRegistry
```

| parameter | description |
| --- | --- |
| typeSource | Type source containing possible handler classes. |

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerRegistry](DefaultHandlerRegistry/DefaultHandlerRegistry.md)(…) | Default implentation for the [`IDefaultHandlerFactory`](IDefaultHandlerFactory.md) |
| virtual [GetTypes](DefaultHandlerRegistry/GetTypes.md)() |  |
| [GetTypes](DefaultHandlerRegistry/GetTypes.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | typeSource is null |

## Remarks

Creates an instance of the class

## See Also

* interface [IDefaultHandlerRegistry](IDefaultHandlerRegistry.md)
* **Source:** *[DefaultHandlerRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Handler/DefaultHandlerRegistry.cs)*