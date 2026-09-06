# DisplayOrderHelper.ReorderValuesAsync method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets a records display order to to requested value, and also renumbers other records in the group as required.

```csharp
public static Task<bool> ReorderValuesAsync(IDbConnection connection, IDisplayOrderRow row, 
    ICriteria filter = null, object recordID = null, int newDisplayOrder = 1, 
    bool descendingKeyOrder = false, bool hasUniqueConstraint = false, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| row | Row with a display order and ID field (should implement IDbIdRow interface). |
| filter | Filter that will determine the record group (can be null). |
| recordID | ID value of the record. |
| newDisplayOrder | New display order of the record. |
| descendingKeyOrder | Will records with same display order values be sorted in ascending or descending ID order? |
| hasUniqueConstraint | True if the display order field has a unique index |
| cancellationToken | Cancellation token |

## Return Value

A task whose result is true if any of the display order values is changed.

## See Also

* interface [IDisplayOrderRow](../IDisplayOrderRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)

---

# DisplayOrderHelper.ReorderValuesAsync method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously sets a records display order to to requested value, and also renumbers other records in the group as required.

```csharp
public static Task<bool> ReorderValuesAsync(IDbConnection connection, string tableName, 
    Field keyField, Field orderField, ICriteria filter = null, object recordID = null, 
    int newDisplayOrder = 1, bool descendingKeyOrder = false, bool hasUniqueConstraint = false, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| tableName | Table name (required). |
| keyField | ID field meta that will be used to locate the record (required). |
| orderField | Display order field meta. |
| filter | Filter that will determine the record group (can be null). |
| recordID | ID value of the record. |
| newDisplayOrder | New display order of the record. |
| descendingKeyOrder | Will records with same display order values be sorted in ascending or descending ID order? |
| hasUniqueConstraint | True if the entity has a unique constraint on display order column. |
| cancellationToken | Cancellation token |

## Return Value

A task whose result is true if any of the display order values is changed.

## See Also

* class [Field](../Field.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)