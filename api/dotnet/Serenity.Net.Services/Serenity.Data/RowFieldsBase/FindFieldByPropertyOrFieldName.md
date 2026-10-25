# RowFieldsBase.FindFieldByPropertyOrFieldName method

Finds a field by its C# property name, falling back to its column or field name.

```csharp
public Field? FindFieldByPropertyOrFieldName(string? name)
```

| parameter | description |
| --- | --- |
| name | The C# property name or the column or field name. |

## Return Value

The matching field, or `null` if no field matches.

## Remarks

A property-name match takes precedence. If no property matches, this lookup accepts a column or field name even when the matching field has a corresponding C# property. Use [`FindFieldByPublicName`](./FindFieldByPublicName.md) to restrict that fallback to fields without a corresponding property.

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)