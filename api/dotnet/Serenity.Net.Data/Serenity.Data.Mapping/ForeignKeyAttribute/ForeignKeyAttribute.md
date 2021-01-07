# ForeignKeyAttribute constructor (1 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Specifies that this property is a foreign key to another field in a primary key table.

```csharp
public ForeignKeyAttribute(string table, string field)
```

| parameter | description |
| --- | --- |
| table | Primary key table |
| field | Matching column in primary key table |

## See Also

* class [ForeignKeyAttribute](../ForeignKeyAttribute.md)

---

# ForeignKeyAttribute constructor (2 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Specifies that this property is a foreign key to another field in a primary key table.

```csharp
public ForeignKeyAttribute(Type rowType, string field = null)
```

| parameter | description |
| --- | --- |
| rowType | Entity for primary key table. Row must have a [TableName] attribute. |
| field | If field parameter is not specified, the row type must have a field with [Identity] attribute or single property with [PrimaryKey] attribute. (implementing IIdRow won't help) |

## See Also

* class [ForeignKeyAttribute](../ForeignKeyAttribute.md)