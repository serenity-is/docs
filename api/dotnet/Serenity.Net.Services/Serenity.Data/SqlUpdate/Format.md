# SqlUpdate.Format method

Formats an SQL UPDATE statement.

```csharp
public static string Format(string tableName, string where, 
    IEnumerable<FieldExpressionPair> fieldExpressions, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| tableName | Table name (required). |
| fieldExpressions | Field names and their value expressions. |
| where | WHERE clause (can be null). |
| dialect | Target dialect |

## Return Value

Formatted UPDATE query.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | tableName or fieldExpressions is null. |

## See Also

* struct [FieldExpressionPair](../FieldExpressionPair.md)
* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlUpdate](../SqlUpdate.md)