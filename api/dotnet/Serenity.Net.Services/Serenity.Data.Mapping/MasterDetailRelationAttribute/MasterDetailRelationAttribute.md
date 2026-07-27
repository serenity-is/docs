# MasterDetailRelationAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Defines a master detail relation (1-N) between this row and another

```csharp
public MasterDetailRelationAttribute(string foreignKey)
```

| parameter | description |
| --- | --- |
| foreignKey | The property name of the FK field in the detail table which matches the PK (id) of the master table. For example, if the two tables are 'Order(Id, Date, ...)' and 'OrderDetail(DetailId, OrderId, Qty, ...)' it should be 'OrderId'. |

## Remarks

Initializes a new instance of the [`MasterDetailRelationAttribute`](../MasterDetailRelationAttribute.md) class.

## See Also

* class [MasterDetailRelationAttribute](../MasterDetailRelationAttribute.md)