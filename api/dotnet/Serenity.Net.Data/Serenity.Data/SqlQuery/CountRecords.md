# SqlQuery.CountRecords property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets/sets the flag to get the total record count when paging is used by SKIP/TAKE. A secondary query without SKIP/TAKE is generated to get total record count, when this property is true.

```csharp
public bool CountRecords { get; set; }
```

## See Also

* class [SqlQuery](../SqlQuery.md)