# DefaultReportFactory constructor
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Default implementation for IReportFactory

```csharp
public DefaultReportFactory(IReportRegistry reportRegistry, IServiceProvider serviceProvider, 
    IHttpContextAccessor httpContextAccessor = null)
```

| parameter | description |
| --- | --- |
| reportRegistry | Report registry |
| serviceProvider | Service provider |
| httpContextAccessor | Http context accessor |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## Remarks

Creates an instance of the class

## See Also

* interface [IReportRegistry](../Serenity.Net.Services/../IReportRegistry.md)
* class [DefaultReportFactory](../DefaultReportFactory.md)