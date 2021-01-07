# MasterDetailRelationAttribute.ForceCascadeDelete property
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Forces deletion of linking row records even if master record uses soft delete. If false (default) this doesn't delete linking records, as master record might be undeleted.

```csharp
public bool ForceCascadeDelete { get; set; }
```

## See Also

* class [MasterDetailRelationAttribute](../MasterDetailRelationAttribute.md)