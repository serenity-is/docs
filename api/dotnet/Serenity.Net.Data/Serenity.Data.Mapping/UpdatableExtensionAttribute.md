# UpdatableExtensionAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Marks the JOIN as an updatable extension.

```csharp
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class UpdatableExtensionAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [UpdatableExtensionAttribute](UpdatableExtensionAttribute/UpdatableExtensionAttribute.md)(…) | Initializes a new instance of the [`UpdatableExtensionAttribute`](UpdatableExtensionAttribute.md) class. |
| [Alias](UpdatableExtensionAttribute/Alias.md) { get; } | The join alias in this row that brings in extension table fields as view fields |
| [CascadeDelete](UpdatableExtensionAttribute/CascadeDelete.md) { get; set; } | Delete extension record if this record is deleted |
| [FilterField](UpdatableExtensionAttribute/FilterField.md) { get; set; } | Name of a field in extension table that will be filtered in extension table in addition to key. For example, if you have a CustomerAddresses table, and your join condition is T0.CustomerID = ca.CustomerID and ca.AddressType = 'Billing', your FilterField is AddressType and your FilterValue is 'Billing' |
| [FilterValue](UpdatableExtensionAttribute/FilterValue.md) { get; set; } | Constant value of a field in extension table that will be filtered in extension table in addition to key. For example, if you have a CustomerAddresses table, and your join condition is T0.CustomerID = ca.CustomerID and ca.AddressType = 'Billing', your FilterField is AddressType and your FilterValue is 'Billing' |
| [OtherKey](UpdatableExtensionAttribute/OtherKey.md) { get; set; } | Name of the key field in extension table. If not specified, ID field of extension table is assumed, unless there is a field with matching name to ThisKey in extension table. |
| [PresenceField](UpdatableExtensionAttribute/PresenceField.md) { get; set; } | This extension should only be inserted if this field is equal to PresenceValue For example, you might have a PersonType column in PersonRow and student record should only be created (if not already) if PersonType = "Student". |
| [PresenceValue](UpdatableExtensionAttribute/PresenceValue.md) { get; set; } | This extension should only be inserted if PresenceField value is equal to this one. For example, you might have a PersonType column in PersonRow and student record should only be created (if not already) if PersonType = "Student". |
| [RowType](UpdatableExtensionAttribute/RowType.md) { get; } | Gets the type of the row. |
| [ThisKey](UpdatableExtensionAttribute/ThisKey.md) { get; set; } | Name of the key field in this table. If not specified, ID field of this table will be used. |

## See Also

* **Source:** *[UpdatableExtensionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/UpdatableExtensionAttribute.cs)*