# ForeignKeyAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Specifies that this property is a foreign key to another field in a primary key table. There is no need for foreign key to exist in database actually. It is not checked. This is mostly used for joins.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ForeignKeyAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ForeignKeyAttribute](ForeignKeyAttribute/ForeignKeyAttribute.md)(…) | Specifies that this property is a foreign key to another field in a primary key table. (2 constructors) |
| [Field](ForeignKeyAttribute/Field.md) { get; } | Gets the field. |
| [RowType](ForeignKeyAttribute/RowType.md) { get; set; } | Gets or sets the type of the row. |
| [Table](ForeignKeyAttribute/Table.md) { get; } | Gets the table. |

## See Also

* **Source:** *[ForeignKeyAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/ForeignKeyAttribute.cs)*