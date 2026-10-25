# RowExtensions.FindFieldByPropertyName method

Finds a field by its C# property name.

```csharp
public static Field? FindFieldByPropertyName(this IRow row, string? name)
```

| parameter | description |
| --- | --- |
| row | The row. |
| name | The C# property name. |

## Return Value

The matching field, or `null` if no field has that property.

## Remarks

This lookup does not fall back to a column or field name. Use [`FindFieldByPropertyOrFieldName`](./FindFieldByPropertyOrFieldName.md) to try the property name first and then fall back to any column or field name, or [`FindFieldByPublicName`](./FindFieldByPublicName.md) to restrict that fallback to fields without a corresponding property.

## See Also

* class [Field](../Field.md)
* interface [IRow](../IRow.md)
* class [RowExtensions](../RowExtensions.md)