# GenericHandlerTypeAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Assigns the generic handler type (e.g. [`SaveRequestHandler`](./SaveRequestHandler-1.md) for a handler interface (like [`ISaveRequestHandler`](./ISaveRequestHandler.md)).

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
| [GenericHandlerTypeAttribute](GenericHandlerTypeAttribute/GenericHandlerTypeAttribute.md)(…) | Assigns the generic handler type (e.g. [`SaveRequestHandler`](./SaveRequestHandler-1.md) for a handler interface (like [`ISaveRequestHandler`](./ISaveRequestHandler.md)). |
| [Value](GenericHandlerTypeAttribute/Value.md) { get; } | Gets the generic handler type. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* **Source:** *[GenericHandlerTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Handler/GenericHandlerTypeAttribute.cs)*