# ReportRegistry constructor
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates an instance of the class.

```csharp
public ReportRegistry(ITypeSource typeSource, IPermissionService permissions, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| typeSource | The type source to search report types in |
| permissions | Permission service |
| localizer | Text localizer |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ReportRegistry](../ReportRegistry.md)