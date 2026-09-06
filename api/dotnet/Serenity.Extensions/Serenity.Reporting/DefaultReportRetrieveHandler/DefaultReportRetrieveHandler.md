# DefaultReportRetrieveHandler constructor

Default implementation for report retrieve handler

```csharp
public DefaultReportRetrieveHandler(IPropertyItemProvider propertyItemProvider, 
    IReportRegistry reportRegistry, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| propertyItemProvider | Property item provider |
| reportRegistry | Report registry |
| serviceProvider | Service provider |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IPropertyItemProvider](../../../Serenity.Net.Services/Serenity.PropertyGrid/IPropertyItemProvider.md)
* interface [IReportRegistry](../../../Serenity.Net.Services/Serenity.Reporting/IReportRegistry.md)
* class [DefaultReportRetrieveHandler](../DefaultReportRetrieveHandler.md)