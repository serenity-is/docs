# RowFieldsBase.FindFieldByPropertyName method

Finds a field by its C# property name.

```csharp
public Field? FindFieldByPropertyName(string? propertyName)
```

| parameter | description |
| --- | --- |
| propertyName | The C# property name. |

## Return Value

The matching field, or `null` if no field has that property.

## Remarks

This lookup does not fall back to a column or field name. Use [`FindField`](./FindField.md) to search by column or field name, or [`FindFieldByPropertyOrFieldName`](./FindFieldByPropertyOrFieldName.md) to try the property name first and then fall back to any column or field name. Use [`FindFieldByPublicName`](./FindFieldByPublicName.md) if that fallback should only match fields without a corresponding property.

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)