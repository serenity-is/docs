# DefaultBehaviorProvider constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Default implementation for [`IBehaviorProvider`](../IBehaviorProvider.md).

```csharp
public DefaultBehaviorProvider(IImplicitBehaviorRegistry implicitBehaviors, 
    IBehaviorFactory behaviorFactory)
```

| parameter | description |
| --- | --- |
| implicitBehaviors | Registry for implicit behaviors. |
| behaviorFactory | Behavior factory |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *implicitBehaviors* or *behaviorFactory* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IImplicitBehaviorRegistry](../IImplicitBehaviorRegistry.md)
* interface [IBehaviorFactory](../IBehaviorFactory.md)
* class [DefaultBehaviorProvider](../DefaultBehaviorProvider.md)