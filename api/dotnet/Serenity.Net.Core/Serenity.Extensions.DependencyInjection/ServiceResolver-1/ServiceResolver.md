# ServiceResolver&lt;TService&gt; constructor

A generic version of IServiceProvider which resolves a service on demand.

```csharp
public ServiceResolver(IServiceProviderAccessor serviceProviderAccessor)
```

| parameter | description |
| --- | --- |
| TService | The type of the service to resolve. |
| serviceProviderAccessor | Accessor for the service provider to resolve the service on demand. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Throws when the service provider accessor is null. |

## Remarks

Initializes a new instance.

## See Also

* interface [IServiceProviderAccessor](../../Serenity/IServiceProviderAccessor.md)
* class [ServiceResolver&lt;TService&gt;](../ServiceResolver-1.md)