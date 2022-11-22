# DisplayOrderHelper.ReorderValues method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets a records display order to to requested value, and also renumbers other records in the group as required.

```csharp
public static bool ReorderValues(IDbConnection connection, IDisplayOrderRow row, 
    ICriteria filter = null, object recordID = null, int newDisplayOrder = 1, 
    bool descendingKeyOrder = false, bool hasUniqueConstraint = false)
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| row | Row with a display order and ID field (should implement IDbIdRow interface). |
| filter | Filter that will determine the record group (can be null). |
| recordID | ID value of the record. |
| newDisplayOrder | New display order of the record. |
| descendingKeyOrder | Will records with same display order values be sorted in ascending or descending ID order? For example, if records with ID's 1, 2, 3 has display order value of "0", their actual display orders are 1, 2 and 3. If this parameter is set to true (descending), their display orders will become 3, 2, 1. This parameter controls if records that are added recently and has no display order value assigned (or 0) be shown at start or at the end. |

## Return Value

If any of the display order values is changed true.

## See Also

* interface [IDisplayOrderRow](../Serenity.Net.Entity/../IDisplayOrderRow.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)

---

# DisplayOrderHelper.ReorderValues method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets a records display order to to requested value, and also renumbers other records in the group as required.

```csharp
public static bool ReorderValues(IDbConnection connection, string tableName, Field keyField, 
    Field orderField, ICriteria filter = null, object recordID = null, int newDisplayOrder = 1, 
    bool descendingKeyOrder = false, bool hasUniqueConstraint = false)
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
| descendingKeyOrder | Will records with same display order values be sorted in ascending or descending ID order? For example, if records with ID's 1, 2, 3 has display order value of "0", their actual display orders are 1, 2 and 3. If this parameter is set to true (descending), their display orders will become 3, 2, 1. This parameter controls if records that are added recently and has no display order value assigned (or 0) be shown at start or at the end. |

## Return Value

If any of the display order values is changed true.

## See Also

* class [Field](../Serenity.Net.Entity/../Field.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)