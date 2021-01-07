# DisplayOrderHelper.ReorderValues method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public static bool ReorderValues(IDbConnection connection, IDisplayOrderRow row, 
    ICriteria filter = null, object recordID = null, int newDisplayOrder = 1, 
    bool descendingKeyOrder = false, bool hasUniqueConstraint = false)
```

## See Also

* interface [IDisplayOrderRow](../Serenity.Net.Entity/../IDisplayOrderRow.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)

---

# DisplayOrderHelper.ReorderValues method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public static bool ReorderValues(IDbConnection connection, string tableName, Field keyField, 
    Field orderField, ICriteria filter = null, object recordID = null, int newDisplayOrder = 1, 
    bool descendingKeyOrder = false, bool hasUniqueConstraint = false)
```

## See Also

* class [Field](../Serenity.Net.Entity/../Field.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)