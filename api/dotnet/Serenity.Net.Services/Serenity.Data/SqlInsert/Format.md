# SqlInsert.Format method

Formats an INSERT query.

```csharp
public static string Format(string tableName, IEnumerable<FieldExpressionPair> fieldExpressions, 
    ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| tableName | Table name (required). |
| fieldExpressions | Field names and their value expressions. |
| dialect | Target dialect |

## Return Value

Formatted query.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | tableName or fieldExpressions is null. |

## See Also

* struct [FieldExpressionPair](../FieldExpressionPair.md)
* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlInsert](../SqlInsert.md)