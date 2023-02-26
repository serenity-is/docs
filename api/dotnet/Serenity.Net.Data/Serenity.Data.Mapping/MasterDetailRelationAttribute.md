# MasterDetailRelationAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Defines a master detail relation (1-N) between this row and another

```csharp
[AttributeUsage(AttributeTargets.Property)]
public sealed class MasterDetailRelationAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [MasterDetailRelationAttribute](MasterDetailRelationAttribute/MasterDetailRelationAttribute.md)(…) | Initializes a new instance of the [`MasterDetailRelationAttribute`](MasterDetailRelationAttribute.md) class. |
| [CheckChangesOnUpdate](MasterDetailRelationAttribute/CheckChangesOnUpdate.md) { get; set; } | Gets or sets a value indicating whether to check changes on update. Disable this if you are getting comparison errors. |
| [ColumnSelection](MasterDetailRelationAttribute/ColumnSelection.md) { get; set; } | Gets or sets the column selection. |
| [ColumnsType](MasterDetailRelationAttribute/ColumnsType.md) { get; set; } | Gets or sets the columns type with properties to include in column selection |
| [FilterField](MasterDetailRelationAttribute/FilterField.md) { get; set; } | Gets or sets the filter field. |
| [FilterValue](MasterDetailRelationAttribute/FilterValue.md) { get; set; } | Gets or sets the filter value. |
| [ForceCascadeDelete](MasterDetailRelationAttribute/ForceCascadeDelete.md) { get; set; } | Forces deletion of linking row records even if master record uses soft delete. If false (default) this doesn't delete linking records, as master record might be undeleted. |
| [ForeignKey](MasterDetailRelationAttribute/ForeignKey.md) { get; } | Gets the foreign key. |
| [IncludeColumnNames](MasterDetailRelationAttribute/IncludeColumnNames.md) { get; set; } | Gets or sets the list of include column names as array. |
| [IncludeColumns](MasterDetailRelationAttribute/IncludeColumns.md) { get; set; } | Gets or sets the comma separated list of include columns. Obsolete, please prefer IncludeColumnNames or ColumnsType |
| [MasterKeyField](MasterDetailRelationAttribute/MasterKeyField.md) { get; set; } | Optional: override the default behaviour and use a different master id (PK) field (i.e. from a unique constraint) |

## See Also

* **Source:** *[MasterDetailRelationAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/MasterDetailRelationAttribute.cs)*