# ReportRegistry constructor

Default report registry implementation

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
| ArgumentNullException | *typeSource*, *permissions* or *localizer* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [ReportRegistry](../ReportRegistry.md)