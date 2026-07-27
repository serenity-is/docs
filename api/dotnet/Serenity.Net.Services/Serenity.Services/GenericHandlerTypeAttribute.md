# GenericHandlerTypeAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Assigns the generic handler type (e.g. [`SaveRequestHandler`](SaveRequestHandler-1.md) for a handler interface (like [`ISaveRequestHandler`](ISaveRequestHandler.md))

```csharp
[AttributeUsage(AttributeTargets.Interface)]
public class GenericHandlerTypeAttribute : Attribute
```

| parameter | description |
| --- | --- |
| type | The handler type |

## Public Members

| name | description |
| --- | --- |
| [GenericHandlerTypeAttribute](GenericHandlerTypeAttribute/GenericHandlerTypeAttribute.md)(…) | Assigns the generic handler type (e.g. [`SaveRequestHandler`](SaveRequestHandler-1.md) for a handler interface (like [`ISaveRequestHandler`](ISaveRequestHandler.md)) |
| [Value](GenericHandlerTypeAttribute/Value.md) { get; } | The generic handler type. |

## Remarks

Creates an instance of the attribute

## See Also

* **Source:** *[GenericHandlerTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Handler/GenericHandlerTypeAttribute.cs)*