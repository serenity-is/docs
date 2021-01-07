# RowFieldsBase class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

```csharp
public class RowFieldsBase : Collection<Field>, IAlias, IHaveJoins
```

## Public Members

| name | description |
| --- | --- |
| [AliasName](RowFieldsBase/AliasName.md) { get; } |  |
| [ConnectionKey](RowFieldsBase/ConnectionKey.md) { get; } |  |
| [Database](RowFieldsBase/Database.md) { get; } |  |
| [Dialect](RowFieldsBase/Dialect.md) { get; } |  |
| [FieldPrefix](RowFieldsBase/FieldPrefix.md) { get; set; } |  |
| [GenerationKey](RowFieldsBase/GenerationKey.md) { get; set; } |  |
| [IdField](RowFieldsBase/IdField.md) { get; } |  |
| [Joins](RowFieldsBase/Joins.md) { get; } |  |
| [LocalTextPrefix](RowFieldsBase/LocalTextPrefix.md) { get; set; } |  |
| [ModuleIdentifier](RowFieldsBase/ModuleIdentifier.md) { get; } |  |
| [NameField](RowFieldsBase/NameField.md) { get; } |  |
| [PrimaryKeys](RowFieldsBase/PrimaryKeys.md) { get; } |  |
| [RowIdentifier](RowFieldsBase/RowIdentifier.md) { get; } |  |
| [Schema](RowFieldsBase/Schema.md) { get; } |  |
| [SortOrders](RowFieldsBase/SortOrders.md) { get; } |  |
| [TableName](RowFieldsBase/TableName.md) { get; } |  |
| [TableOnly](RowFieldsBase/TableOnly.md) { get; } |  |
| [FindField](RowFieldsBase/FindField.md)(…) |  |
| [FindFieldByPropertyName](RowFieldsBase/FindFieldByPropertyName.md)(…) |  |
| [GetFieldsByAttribute](RowFieldsBase/GetFieldsByAttribute.md)(…) |  |
| [GetFieldsByAttribute&lt;TAttr&gt;](RowFieldsBase/GetFieldsByAttribute.md)() |  |
| [Initialize](RowFieldsBase/Initialize.md)(…) |  |
| [LockAlias](RowFieldsBase/LockAlias.md)() |  |
| [ReplaceAliasWith](RowFieldsBase/ReplaceAliasWith.md)(…) |  |
| static [ParseDatabaseAndSchema](RowFieldsBase/ParseDatabaseAndSchema.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [RowFieldsBase](RowFieldsBase/RowFieldsBase.md)(…) |  |
| virtual [AfterInitialize](RowFieldsBase/AfterInitialize.md)() |  |
| override [InsertItem](RowFieldsBase/InsertItem.md)(…) |  |
| override [RemoveItem](RowFieldsBase/RemoveItem.md)(…) |  |
| override [SetItem](RowFieldsBase/SetItem.md)(…) |  |

## See Also

* class [Field](Field.md)
* interface [IAlias](../Serenity.Net.Data/IAlias.md)
* interface [IHaveJoins](../Serenity.Net.Data/IHaveJoins.md)
* **Source:** *[RowFieldsBase.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/RowFieldsBase.cs)*