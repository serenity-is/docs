# IBehaviorProvider.Resolve method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Resolves a list of behavior instances targeted for a handler, row and behaivor type.

```csharp
public IEnumerable Resolve(Type handlerType, Type rowType, Type behaviorType)
```

| parameter | description |
| --- | --- |
| handlerType | The handler type requesting list of behaviors |
| rowType | Target row type |
| behaviorType | Type of the behaviors |

## See Also

* interface [IBehaviorProvider](../IBehaviorProvider.md)