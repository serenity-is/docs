# EntityFieldExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

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
| static [IsTableField](EntityFieldExtensions/IsTableField.md)(…) | Checks to see if field is an actual table field, e.g. not a foreign or calculated field. This is determined by field flags and having expression. |
| static [OfJoin&lt;TField&gt;](EntityFieldExtensions/OfJoin.md)(…) | Returns a new field an expression with specified join alias. Avoid using. |

## See Also

* **Source:** *[EntityFieldExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Extensions/EntityFieldExtensions.cs)*