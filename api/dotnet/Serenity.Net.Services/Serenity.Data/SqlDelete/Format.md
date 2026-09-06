# SqlDelete.Format method

Formats a DELETE query.

```csharp
public static string Format(string tableName, string where, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| tableName | Table name. |
| where | Where part of the query. |
| dialect | Target dialect |

## Return Value

Formatted query.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | tableName is null or empty. |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlDelete](../SqlDelete.md)