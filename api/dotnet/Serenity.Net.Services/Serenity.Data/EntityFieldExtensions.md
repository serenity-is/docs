# EntityFieldExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains static extension methods for Field objects.

```csharp
public static class EntityFieldExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AutoTrim](EntityFieldExtensions/AutoTrim.md)(…) | Automatically performs trim on field value based on the field flags TrimToEmpty and Trim. |
| static [EnumerateTableFields](EntityFieldExtensions/EnumerateTableFields.md)(…) | Gets a dictionary of table fields (e.g. not a foreign or calculated field) in a row. |
| static [GetAttribute&lt;TAttribute&gt;](EntityFieldExtensions/GetAttribute.md)(…) | Gets the attribute. |
| static [GetAttributes&lt;TAttribute&gt;](EntityFieldExtensions/GetAttributes.md)(…) | Gets the attributes. |
| static [GetTableFields](EntityFieldExtensions/GetTableFields.md)(…) | Gets a dictionary of table fields (e.g. not a foreign or calculated field) in a row. |
| static [IsSensitiveFieldBasedOnInterfaces](EntityFieldExtensions/IsSensitiveFieldBasedOnInterfaces.md)(…) | Returns true if the field is a sensitive field based on the row implementing interfaces like [`IPasswordRow`](./IPasswordRow.md) (e.g. its password hash / salt), regardless of its name. This complements the name based detection in [`RowFieldsBase`](./RowFieldsBase.md). The caller is responsible for checking any explicit attributes (e.g. [`MinSelectLevelAttribute`](../Serenity.Data.Mapping/MinSelectLevelAttribute.md)) that may opt the field out of the default protection. |
| static [IsTableField](EntityFieldExtensions/IsTableField.md)(…) | Checks to see if field is an actual table field, e.g. not a foreign or calculated field. This is determined by field flags and having expression. |
| static [OfJoin&lt;TField&gt;](EntityFieldExtensions/OfJoin.md)(…) | Returns a new field with an expression using the specified join alias. Avoid using. |

## See Also

* **Source:** *[EntityFieldExtensions.cs](https://github.com/serenity-is/Serenity/blob/d25d8234d5d47750c7fc36779de766d0541b2868/src/services/Entity/Extensions/EntityFieldExtensions.cs)*