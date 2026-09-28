# RowFieldsBase.GetFieldTypeToCreate method

Gets the type of the field to create when a Field member is null. This can be overridden to provide custom field types for specific properties, especially when the field's type is Field, which is abstract and cannot be instantiated directly. By default, it returns the field's declared type.

```csharp
protected virtual Type? GetFieldTypeToCreate(FieldInfo fieldInfo, IPropertyInfo? property)
```

| parameter | description |
| --- | --- |
| fieldInfo | The field information. |
| property | The property information. |

## Return Value

The type of the field to create. Return a subclass of Field, or this field will be skipped.

## See Also

* interface [IPropertyInfo](../../../Serenity.Net.Core/Serenity.Reflection/IPropertyInfo.md)
* class [RowFieldsBase](../RowFieldsBase.md)