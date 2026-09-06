# DisplayOrderHelper.GetNextValueAsync method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously gets the next display order value for a table or a group of records.

```csharp
public static Task<int> GetNextValueAsync(IDbConnection connection, IDisplayOrderRow row, 
    ICriteria filter = null, CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| row | Row with a display order field (required). |
| filter | Filter for records (can be null). |
| cancellationToken | Cancellation token |

## Return Value

A task whose result is one more of maximum display order values of records in the group. If none, 1.

## See Also

* interface [IDisplayOrderRow](../IDisplayOrderRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)

---

# DisplayOrderHelper.GetNextValueAsync method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously gets the next display order value for a table or a group of records.

```csharp
public static Task<int> GetNextValueAsync(IDbConnection connection, string tableName, 
    Field orderField, ICriteria filter, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| tableName | Table name (required). |
| orderField | Display order field meta (required). |
| filter | Filter for records (can be null). |
| cancellationToken | Cancellation token |

## Return Value

A task whose result is one more of maximum display order values of records in the group. If none, 1.

## See Also

* class [Field](../Field.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)