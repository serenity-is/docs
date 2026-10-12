# DefaultBehaviorFactory class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default [`IBehaviorFactory`](./IBehaviorFactory.md) implementation.

```csharp
public class DefaultBehaviorFactory : IBehaviorFactory
```

| parameter | description |
| --- | --- |
| serviceProviderAccessor | Accessor for the service provider which will be used to resolve the services that behavior classes might require |

## Public Members

| name | description |
| --- | --- |
| [DefaultBehaviorFactory](DefaultBehaviorFactory/DefaultBehaviorFactory.md)(…) | Default [`IBehaviorFactory`](./IBehaviorFactory.md) implementation. |
| [CreateInstance](DefaultBehaviorFactory/CreateInstance.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProviderAccessor* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IBehaviorFactory](./IBehaviorFactory.md)
* **Source:** *[DefaultBehaviorFactory.cs](https://github.com/serenity-is/Serenity/blob/95342587aebf71b494e0c09221452e4fd9429d1b/src/services/RequestHandlers/Behavior/DefaultBehaviorFactory.cs)*