# DefaultReportFactory constructor
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Default implementation of IReportFactory.

```csharp
public DefaultReportFactory(IReportRegistry reportRegistry, IServiceProvider serviceProvider, 
    IHttpContextAccessor httpContextAccessor = null)
```

| parameter | description |
| --- | --- |
| reportRegistry | The report registry. |
| serviceProvider | The service provider. |
| httpContextAccessor | The HTTP context accessor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *reportRegistry* or *serviceProvider* is `null`. |

## Remarks

Initializes a new instance of the [`DefaultReportFactory`](../DefaultReportFactory.md) class.

## See Also

* interface [IReportRegistry](../Serenity.Net.Services/../IReportRegistry.md)
* class [DefaultReportFactory](../DefaultReportFactory.md)