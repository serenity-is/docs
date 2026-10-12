# DefaultBehaviorFactory constructor

Default [`IBehaviorFactory`](../IBehaviorFactory.md) implementation.

```csharp
public DefaultBehaviorFactory(IServiceProviderAccessor serviceProviderAccessor)
```

| parameter | description |
| --- | --- |
| serviceProviderAccessor | Accessor for the service provider which will be used to resolve the services that behavior classes might require |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProviderAccessor* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IServiceProviderAccessor](../../../Serenity.Net.Core/Serenity/IServiceProviderAccessor.md)
* class [DefaultBehaviorFactory](../DefaultBehaviorFactory.md)