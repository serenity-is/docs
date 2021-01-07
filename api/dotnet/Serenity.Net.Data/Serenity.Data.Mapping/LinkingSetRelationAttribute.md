# LinkingSetRelationAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Specifies a linking set relation (1-N relation of ID values, like a check list.)

```csharp
[AttributeUsage(AttributeTargets.Property)]
public sealed class LinkingSetRelationAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [LinkingSetRelationAttribute](LinkingSetRelationAttribute/LinkingSetRelationAttribute.md)(…) | Declares a linking set relation |
| [FilterField](LinkingSetRelationAttribute/FilterField.md) { get; set; } | Gets or sets the filter field. |
| [FilterValue](LinkingSetRelationAttribute/FilterValue.md) { get; set; } | Gets or sets the filter value. |
| [ForceCascadeDelete](LinkingSetRelationAttribute/ForceCascadeDelete.md) { get; set; } | Forces deletion of linking row records even if master record uses soft delete. If false (default) this doesn't delete linking records, as master record might be undeleted. |
| [HandleEqualityFilter](LinkingSetRelationAttribute/HandleEqualityFilter.md) { get; set; } | Gets or sets a value indicating whether to handle equality filter. |
| [ItemKey](LinkingSetRelationAttribute/ItemKey.md) { get; } | Gets the item key, e.g. name of the field in linking set table that contains ID's of selected items. |
| [PreserveOrder](LinkingSetRelationAttribute/PreserveOrder.md) { get; set; } | Gets or sets a value indicating whether to preserve existing order of records on save. |
| [RowType](LinkingSetRelationAttribute/RowType.md) { get; } | Gets the type of the row. |
| [ThisKey](LinkingSetRelationAttribute/ThisKey.md) { get; } | Gets the this key, e.g. name of field in linking set table that this tables ID field corresponds to. |

## See Also

* **Source:** *[LinkingSetRelationAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/LinkingSetRelationAttribute.cs)*