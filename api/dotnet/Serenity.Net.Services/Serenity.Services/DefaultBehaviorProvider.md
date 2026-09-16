# DefaultBehaviorProvider class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for [`IBehaviorProvider`](./IBehaviorProvider.md).

```csharp
public class DefaultBehaviorProvider : IBehaviorProvider
```

| parameter | description |
| --- | --- |
| implicitBehaviors | Registry for implicit behaviors. |
| behaviorFactory | Behavior factory |

## Public Members

| name | description |
| --- | --- |
| [DefaultBehaviorProvider](DefaultBehaviorProvider/DefaultBehaviorProvider.md)(…) | Default implementation for [`IBehaviorProvider`](./IBehaviorProvider.md). |
| [Resolve](DefaultBehaviorProvider/Resolve.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *implicitBehaviors* or *behaviorFactory* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IBehaviorProvider](./IBehaviorProvider.md)
* **Source:** *[DefaultBehaviorProvider.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/services/RequestHandlers/Behavior/DefaultBehaviorProvider.cs)*