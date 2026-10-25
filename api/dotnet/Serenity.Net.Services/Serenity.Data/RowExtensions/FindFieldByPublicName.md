# RowExtensions.FindFieldByPublicName method

Finds a field by its public name: its C# property name, or its field name when it has no corresponding property.

```csharp
public static Field? FindFieldByPublicName(this IRow row, string? name)
```

| parameter | description |
| --- | --- |
| row | The row. |
| name | A C# property name, or the field name of a field without a corresponding property. |

## Return Value

The matching field, or `null` if no eligible field matches.

## Remarks

Property-name matches take precedence. A column or field name is accepted only if the matching field has no corresponding C# property name. Use [`FindFieldByPropertyOrFieldName`](./FindFieldByPropertyOrFieldName.md) to also allow column or field names for property-backed fields.

## See Also

* class [Field](../Field.md)
* interface [IRow](../IRow.md)
* class [RowExtensions](../RowExtensions.md)