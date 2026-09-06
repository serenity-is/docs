# SqlInsert.ToUpsertString method

Formats an UPSERT query, i.e. a query that updates the row matching the key fields or inserts a new row if no such row exists.

```csharp
public string ToUpsertString(IEnumerable<string> keyFields)
```

| parameter | description |
| --- | --- |
| keyFields | List of key field names (e.g. primary key columns) that should be used to determine whether an existing row is updated or a new row is inserted. Key fields must exist among the fields set on this query. |

## Return Value

Formatted UPSERT query.

## See Also

* class [SqlInsert](../SqlInsert.md)