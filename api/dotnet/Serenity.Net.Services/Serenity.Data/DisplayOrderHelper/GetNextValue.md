# DisplayOrderHelper.GetNextValue method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the next display order value for a table or a group of records.

```csharp
public static int GetNextValue(IDbConnection connection, IDisplayOrderRow row, 
    ICriteria filter = null)
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| row | Row with a display order field (required). |
| filter | Filter for records (can be null). |

## Return Value

One more of maximum display order values of records in the group. If none, 1.

## See Also

* interface [IDisplayOrderRow](../Serenity.Net.Entity/../IDisplayOrderRow.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)

---

# DisplayOrderHelper.GetNextValue method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the next display order value for a table or a group of records.

```csharp
public static int GetNextValue(IDbConnection connection, string tableName, Field orderField, 
    ICriteria filter)
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| tableName | Table name (required). |
| orderField | Display order field meta (required). |
| filter | Filter for records (can be null). |

## Return Value

One more of maximum display order values of records in the group. If none, 1.

## See Also

* class [Field](../Serenity.Net.Entity/../Field.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)