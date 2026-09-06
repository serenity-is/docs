# DefaultBehaviorFactory class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default [`IBehaviorFactory`](./IBehaviorFactory.md) implementation.

```csharp
public class DefaultBehaviorFactory : IBehaviorFactory
```

| parameter | description |
| --- | --- |
| provider | Service provider which will be used to resolve the services that behavior classes might require |

## Public Members

| name | description |
| --- | --- |
| [DefaultBehaviorFactory](DefaultBehaviorFactory/DefaultBehaviorFactory.md)(…) | Default [`IBehaviorFactory`](./IBehaviorFactory.md) implementation. |
| [CreateInstance](DefaultBehaviorFactory/CreateInstance.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *provider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IBehaviorFactory](./IBehaviorFactory.md)
* **Source:** *[DefaultBehaviorFactory.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Behavior/DefaultBehaviorFactory.cs)*