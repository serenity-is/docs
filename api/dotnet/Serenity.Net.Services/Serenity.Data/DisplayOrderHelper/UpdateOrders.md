# DisplayOrderHelper.UpdateOrders method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Updates display order values in a table

```csharp
public static bool UpdateOrders(IDbConnection connection, List<OrderRecord> orderRecords, 
    string tableName, Field keyField, Field orderField, bool hasUniqueConstraint = false)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| orderRecords | List of records with new orders |
| tableName | Tablename |
| keyField | Key field |
| orderField | Order field |
| hasUniqueConstraint | True if order field has a unique constraint |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection, tableName, keyField or orderField is null |

## See Also

* class [OrderRecord](../DisplayOrderHelper.OrderRecord.md)
* class [Field](../Serenity.Net.Entity/../Field.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)