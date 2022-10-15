# RowFieldsBase class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base class for row fields collection

```csharp
public class RowFieldsBase : Collection<Field>, IAlias, IHaveJoins
```

## Public Members

| name | description |
| --- | --- |
| [AliasName](RowFieldsBase/AliasName.md) { get; } | Gets the name of the alias. |
| [ConnectionKey](RowFieldsBase/ConnectionKey.md) { get; } | Gets the connection key. |
| [Database](RowFieldsBase/Database.md) { get; } | Gets the database. |
| [Dialect](RowFieldsBase/Dialect.md) { get; } | Gets the dialect. |
| [FieldPrefix](RowFieldsBase/FieldPrefix.md) { get; set; } | Gets or sets the field prefix. |
| [GenerationKey](RowFieldsBase/GenerationKey.md) { get; set; } | Gets or sets the generation key. |
| [IdField](RowFieldsBase/IdField.md) { get; } | Gets the identifier field. |
| [Joins](RowFieldsBase/Joins.md) { get; } | List of all joins in entity |
| [LocalTextPrefix](RowFieldsBase/LocalTextPrefix.md) { get; set; } | Gets or sets the local text prefix. |
| [ModuleIdentifier](RowFieldsBase/ModuleIdentifier.md) { get; } | Gets the module identifier. |
| [NameField](RowFieldsBase/NameField.md) { get; } | Gets the name field. |
| [PrimaryKeys](RowFieldsBase/PrimaryKeys.md) { get; } | Gets the primary keys. |
| [RowIdentifier](RowFieldsBase/RowIdentifier.md) { get; } | Gets the row identifier. |
| [Schema](RowFieldsBase/Schema.md) { get; } | Gets the schema. |
| [SortOrders](RowFieldsBase/SortOrders.md) { get; } | Gets the sort orders. |
| [TableName](RowFieldsBase/TableName.md) { get; } | Gets the name of the table. |
| [TableOnly](RowFieldsBase/TableOnly.md) { get; } | Gets the table only. |
| [FindField](RowFieldsBase/FindField.md)(…) | Finds the field. |
| [FindFieldByPropertyName](RowFieldsBase/FindFieldByPropertyName.md)(…) | Finds the name of the field by property. |
| [GetFieldsByAttribute](RowFieldsBase/GetFieldsByAttribute.md)(…) | Gets the fields by attribute. |
| [GetFieldsByAttribute&lt;TAttr&gt;](RowFieldsBase/GetFieldsByAttribute.md)() | Gets the fields by attribute. |
| [Initialize](RowFieldsBase/Initialize.md)(…) | Initializes the specified annotations. |
| [LockAlias](RowFieldsBase/LockAlias.md)() | Locks the alias. |
| [ReplaceAliasWith](RowFieldsBase/ReplaceAliasWith.md)(…) | Replaces the alias with. |
| static [ParseDatabaseAndSchema](RowFieldsBase/ParseDatabaseAndSchema.md)(…) | Parses the database and schema. |

## Protected Members

| name | description |
| --- | --- |
| [RowFieldsBase](RowFieldsBase/RowFieldsBase.md)(…) | Initializes a new instance of the [`RowFieldsBase`](RowFieldsBase.md) class. |
| virtual [AfterInitialize](RowFieldsBase/AfterInitialize.md)() | Afters the initialize. |
| virtual [CreateGeneratedFields](RowFieldsBase/CreateGeneratedFields.md)() | Should be only used by row source generator to create field objects it generated |
| override [InsertItem](RowFieldsBase/InsertItem.md)(…) | Inserts an element into the Collection at the specified index. |
| override [RemoveItem](RowFieldsBase/RemoveItem.md)(…) | Removes the element at the specified index of the Collection. |
| override [SetItem](RowFieldsBase/SetItem.md)(…) | Replaces the element at the specified index. |

## See Also

* class [Field](Field.md)
* interface [IAlias](../Serenity.Net.Data/IAlias.md)
* interface [IHaveJoins](../Serenity.Net.Data/IHaveJoins.md)
* **Source:** *[RowFieldsBase.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/RowFieldsBase.cs)*