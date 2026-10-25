# RowFieldsBase.FindField method

Finds a field by its column or field name.

```csharp
public Field? FindField(string? fieldName)
```

| parameter | description |
| --- | --- |
| fieldName | The column or field name. |

## Return Value

The matching field, or `null` if no field has that name.

## Remarks

This lookup does not search by C# property name. Use [`FindFieldByPropertyName`](./FindFieldByPropertyName.md) for a property-name lookup, or [`FindFieldByPropertyOrFieldName`](./FindFieldByPropertyOrFieldName.md) when the name may be a property name or any column or field name.

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)