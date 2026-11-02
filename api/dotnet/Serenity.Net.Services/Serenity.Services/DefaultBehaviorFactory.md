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
* **Source:** *[DefaultBehaviorFactory.cs](https://github.com/serenity-is/Serenity/blob/090f59bd1ba489cacd572f4dfffdb4a12f4c29d9/src/services/RequestHandlers/Behavior/DefaultBehaviorFactory.cs)*