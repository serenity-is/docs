# DefaultReportFactory class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of IReportFactory.

```csharp
public class DefaultReportFactory : IReportFactory
```

| parameter | description |
| --- | --- |
| reportRegistry | The report registry. |
| serviceProvider | The service provider. |
| httpContextAccessor | The HTTP context accessor. |

## Public Members

| name | description |
| --- | --- |
| [DefaultReportFactory](DefaultReportFactory/DefaultReportFactory.md)(…) | Default implementation of IReportFactory. |
| [Create](DefaultReportFactory/Create.md)(…) |  |
| [SetParams](DefaultReportFactory/SetParams.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *reportRegistry* or *serviceProvider* is `null`. |

## Remarks

Initializes a new instance of the [`DefaultReportFactory`](./DefaultReportFactory.md) class.

## See Also

* interface [IReportFactory](../../Serenity.Net.Services/Serenity.Reporting/IReportFactory.md)
* **Source:** *[DefaultReportFactory.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Reporting/DefaultReportFactory.cs)*