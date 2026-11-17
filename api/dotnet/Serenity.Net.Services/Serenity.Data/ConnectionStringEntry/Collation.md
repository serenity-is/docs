# ConnectionStringEntry.Collation property

Gets or sets the default collation to use if the database for this connection is created by the application, in the format of the database engine, e.g. "Turkish_100_CI_AS" for SQL Server. It has no effect on a database that already exists. Defaults to null, meaning the database is created with the default collation of the server.

```csharp
public string? Collation { get; set; }
```

## Remarks

It can also be one of the [`SqlCollationMapper`](../SqlCollationMapper.md) keywords, to map [`Comparer`](./Comparer.md) to a collation of the database engine. "automap" throws and "tryautomap" uses no collation if there is no match. Their "automaptolerant" and "tryautomaptolerant" versions also accept a collation that only differs in case or accent sensitivity.

## See Also

* class [ConnectionStringEntry](../ConnectionStringEntry.md)