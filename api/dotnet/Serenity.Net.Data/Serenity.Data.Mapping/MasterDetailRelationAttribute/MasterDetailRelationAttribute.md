# MasterDetailRelationAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`MasterDetailRelationAttribute`](../MasterDetailRelationAttribute.md) class.

```csharp
public MasterDetailRelationAttribute(string foreignKey)
```

| parameter | description |
| --- | --- |
| foreignKey | The property name of the FK field in the detail table which matches the PK (id) of the master table. For example, if the two tables are 'Order(Id, Date, ...)' and 'OrderDetail(DetailId, OrderId, Qty, ...)' it should be 'OrderId'. |

## See Also

* class [MasterDetailRelationAttribute](../MasterDetailRelationAttribute.md)