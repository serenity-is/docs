# CriteriaFieldExpressionReplacer constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates an instance of the class

```csharp
public CriteriaFieldExpressionReplacer(IRow row, IPermissionService permissions, 
    bool lookupAccessMode = false)
```

| parameter | description |
| --- | --- |
| row | The row instance |
| permissions | Permission service |
| lookupAccessMode | Use lookup access mode. In the lookup access mode only the lookup fields can be used in the filter. Default is false. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row or permissions is null |

## See Also

* interface [IRow](../Serenity.Net.Entity/../IRow.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* class [CriteriaFieldExpressionReplacer](../CriteriaFieldExpressionReplacer.md)