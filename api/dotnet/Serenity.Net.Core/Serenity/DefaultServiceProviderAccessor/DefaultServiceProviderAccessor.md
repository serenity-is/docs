# DefaultServiceProviderAccessor constructor

Default [`IServiceProviderAccessor`](../IServiceProviderAccessor.md) that always returns the same service provider.

```csharp
public DefaultServiceProviderAccessor(IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider to return. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProvider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [DefaultServiceProviderAccessor](../DefaultServiceProviderAccessor.md)