# GenericHandlerTypeAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Assigns the generic handler type (e.g. [`SaveRequestHandler`](SaveRequestHandler-1.md) for a handler interface (like [`ISaveRequestHandler`](ISaveRequestHandler.md))

```csharp
[AttributeUsage(AttributeTargets.Interface)]
public class GenericHandlerTypeAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [GenericHandlerTypeAttribute](GenericHandlerTypeAttribute/GenericHandlerTypeAttribute.md)(…) | Creates an instance of the attribute |
| [Value](GenericHandlerTypeAttribute/Value.md) { get; } | The generic handler type. |

## See Also

* **Source:** *[GenericHandlerTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Handler/GenericHandlerTypeAttribute.cs)*