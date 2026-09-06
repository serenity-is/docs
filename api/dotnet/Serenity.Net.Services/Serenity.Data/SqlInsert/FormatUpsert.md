# SqlInsert.FormatUpsert method

Formats an UPSERT query, i.e. a query that updates the row matching the key fields or inserts a new row if no such row exists.

```csharp
public static string FormatUpsert(string tableName, 
    IEnumerable<FieldExpressionPair> fieldExpressions, IEnumerable<string> keyFields, 
    ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| tableName | Table name (required). |
| fieldExpressions | Field names and their value expressions. |
| keyFields | List of key field names (e.g. primary key columns) that should be used to determine whether an existing row is updated or a new row is inserted. Key fields must exist among the fields in *fieldExpressions*. |
| dialect | Target dialect |

## Return Value

Formatted UPSERT query.

## See Also

* struct [FieldExpressionPair](../FieldExpressionPair.md)
* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlInsert](../SqlInsert.md)