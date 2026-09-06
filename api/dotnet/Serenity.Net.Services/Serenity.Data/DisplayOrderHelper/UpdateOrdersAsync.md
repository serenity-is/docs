# DisplayOrderHelper.UpdateOrdersAsync method

Asynchronously updates display order values in a table

```csharp
public static Task<bool> UpdateOrdersAsync(IDbConnection connection, 
    List<OrderRecord> orderRecords, string tableName, Field keyField, Field orderField, 
    bool hasUniqueConstraint = false, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| orderRecords | List of records with new orders |
| tableName | Tablename |
| keyField | Key field |
| orderField | Order field |
| hasUniqueConstraint | True if order field has a unique constraint |
| cancellationToken | Cancellation token |

## Return Value

A task whose result is true if any display order values were updated

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection, tableName, keyField or orderField is null |

## See Also

* class [OrderRecord](../DisplayOrderHelper.OrderRecord.md)
* class [Field](../Field.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)