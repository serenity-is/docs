# CriteriaFieldExpressionReplacer constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Converts field names in a criteria to their corresponding SQL field expressions.

```csharp
public CriteriaFieldExpressionReplacer(IRow row, IPermissionService permissions, 
    bool lookupAccessMode = false, ISqlDialect dialect = null, 
    Func<IField, BaseCriteria> toCriteria = null)
```

| parameter | description |
| --- | --- |
| row | The row instance |
| permissions | Permission service |
| lookupAccessMode | Use lookup access mode. In the lookup access mode only the lookup fields can be used in the filter. Default is false. |
| dialect | Optional dialect |
| toCriteria | Optional field to criteria converter |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row or permissions is null |

## Remarks

Creates an instance of the class

## See Also

* interface [IRow](../IRow.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [ISqlDialect](../ISqlDialect.md)
* interface [IField](../IField.md)
* class [BaseCriteria](../BaseCriteria.md)
* class [CriteriaFieldExpressionReplacer](../CriteriaFieldExpressionReplacer.md)