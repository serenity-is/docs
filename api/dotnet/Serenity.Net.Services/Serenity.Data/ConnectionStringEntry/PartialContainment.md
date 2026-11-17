# ConnectionStringEntry.PartialContainment property

Gets or sets a value indicating whether a SQL Server database for this connection is created as a partially contained database, if it is created by the application. Table and column names of such a database are compared by a fixed case insensitive collation, whatever [`Collation`](./Collation.md) is.

```csharp
public bool PartialContainment { get; set; }
```

## Remarks

The "contained database authentication" setting of the server must already be enabled, and such a database can't use replication, change data capture or change tracking.

## See Also

* class [ConnectionStringEntry](../ConnectionStringEntry.md)