# EntityFieldExtensions.IsSensitiveFieldBasedOnInterfaces method

Returns true if the field is a sensitive field based on the row implementing interfaces like [`IPasswordRow`](../IPasswordRow.md) (e.g. its password hash / salt), regardless of its name. This complements the name based detection in [`RowFieldsBase`](../RowFieldsBase.md). The caller is responsible for checking any explicit attributes (e.g. [`MinSelectLevelAttribute`](../../Serenity.Data.Mapping/MinSelectLevelAttribute.md)) that may opt the field out of the default protection.

```csharp
public static bool IsSensitiveFieldBasedOnInterfaces(Field field, IRow? row)
```

| parameter | description |
| --- | --- |
| field | The field. |
| row | The row instance, used to detect the sensitive interface fields. |

## Return Value

True if the field is a sensitive field based on the row interfaces.

## See Also

* class [Field](../Field.md)
* interface [IRow](../IRow.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)