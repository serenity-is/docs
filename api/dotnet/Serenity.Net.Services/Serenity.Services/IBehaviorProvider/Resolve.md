# IBehaviorProvider.Resolve method

Resolves a list of behavior instances targeted for a handler, row and behavior type.

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