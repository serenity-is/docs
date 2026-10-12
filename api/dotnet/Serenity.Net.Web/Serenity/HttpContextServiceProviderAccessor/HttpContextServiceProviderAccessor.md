# HttpContextServiceProviderAccessor constructor

An IServiceProviderAccessor that uses the current HTTP request's scoped service provider when available, falling back to the root provider otherwise.

```csharp
public HttpContextServiceProviderAccessor(IServiceProvider serviceProvider, 
    IHttpContextAccessor? httpContextAccessor = null)
```

| parameter | description |
| --- | --- |
| serviceProvider | Root service provider used when there is no active HTTP request. |
| httpContextAccessor | HTTP context accessor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProvider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [HttpContextServiceProviderAccessor](../HttpContextServiceProviderAccessor.md)