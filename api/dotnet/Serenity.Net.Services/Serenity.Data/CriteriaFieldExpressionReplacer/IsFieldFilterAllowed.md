# CriteriaFieldExpressionReplacer.IsFieldFilterAllowed method

Returns whether filtering a field is allowed by its flags and permissions.

```csharp
public static bool IsFieldFilterAllowed(Field field, IPermissionService permissions, 
    bool lookupAccessMode = false, IRow? row = null)
```

| parameter | description |
| --- | --- |
| field | The field to check. |
| permissions | The permission service. |
| lookupAccessMode | Whether lookup access mode is enabled. |
| row | Optional row instance, used to detect IPasswordRow sensitive fields. |

## Return Value

True if filtering the field is allowed.

## See Also

* class [Field](../Field.md)
* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [IRow](../IRow.md)
* class [CriteriaFieldExpressionReplacer](../CriteriaFieldExpressionReplacer.md)