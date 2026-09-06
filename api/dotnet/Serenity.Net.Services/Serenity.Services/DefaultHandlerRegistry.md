# DefaultHandlerRegistry class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for the [`IDefaultHandlerRegistry`](./IDefaultHandlerRegistry.md).

```csharp
public class DefaultHandlerRegistry : IDefaultHandlerRegistry
```

| parameter | description |
| --- | --- |
| typeSource | Type source containing possible handler classes. |

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerRegistry](DefaultHandlerRegistry/DefaultHandlerRegistry.md)(…) | Default implementation for the [`IDefaultHandlerRegistry`](./IDefaultHandlerRegistry.md). |
| virtual [GetTypes](DefaultHandlerRegistry/GetTypes.md)() |  |
| [GetTypes](DefaultHandlerRegistry/GetTypes.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *typeSource* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IDefaultHandlerRegistry](./IDefaultHandlerRegistry.md)
* **Source:** *[DefaultHandlerRegistry.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Handler/DefaultHandlerRegistry.cs)*