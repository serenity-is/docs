# DefaultBehaviorFactory constructor

Default [`IBehaviorFactory`](../IBehaviorFactory.md) implementation.

```csharp
public DefaultBehaviorFactory(IServiceProvider provider)
```

| parameter | description |
| --- | --- |
| provider | Service provider which will be used to resolve the services that behavior classes might require |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *provider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [DefaultBehaviorFactory](../DefaultBehaviorFactory.md)