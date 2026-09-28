# IFilterableQuery.GetWhereClause method

Gets the WHERE conditions as SQL text, without the WHERE keyword.

```csharp
public string GetWhereClause()
```

## Return Value

The WHERE conditions joined with AND, or an empty string.

## Remarks

Criteria parameters are added when [`Where`](./Where.md) is called. Reading this clause repeatedly does not add duplicate parameters. Query-specific table references are normalized where needed.

## See Also

* interface [IFilterableQuery](../IFilterableQuery.md)