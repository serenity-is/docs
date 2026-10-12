# CriteriaFieldExpressionReplacer constructor

Converts field names in a criteria to their corresponding SQL field expressions.

```csharp
public CriteriaFieldExpressionReplacer(IRow row, IPermissionService permissions, 
    bool lookupAccessMode = false, ISqlDialect? dialect = null, 
    Func<IField, BaseCriteria>? toCriteria = null, Func<Field, bool>? allowFilterField = null)
```

| parameter | description |
| --- | --- |
| row | The row instance |
| permissions | Permission service |
| lookupAccessMode | Use lookup access mode. In the lookup access mode only the lookup fields can be used in the filter. Default is false. |
| dialect | Optional dialect |
| toCriteria | Optional field to criteria converter |
| allowFilterField | Optional field filter validator. If provided, it will be used to determine if a field can be filtered instead of the default logic using see permissions argument. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *row* or *permissions* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IRow](../IRow.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [ISqlDialect](../ISqlDialect.md)
* interface [IField](../IField.md)
* class [BaseCriteria](../BaseCriteria.md)
* class [Field](../Field.md)
* class [CriteriaFieldExpressionReplacer](../CriteriaFieldExpressionReplacer.md)