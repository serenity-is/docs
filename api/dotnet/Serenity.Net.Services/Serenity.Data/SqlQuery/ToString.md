# SqlQuery.ToString method (1 of 2)

Formats SQL Query as string. If paging is used and skip requested, multiple queries might be created one after each other.

```csharp
public override string ToString()
```

## Return Value

Formatted SELECT statement.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.ToString method (2 of 2)

Formats SQL Query as string. If paging is used and skip requested, multiple queries might be created one after each other.

```csharp
public static string ToString(ISqlQuery query, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| query | The query to format. |
| dialect | The target dialect. |

## Return Value

Formatted SELECT statement.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query is null. |

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlQuery](../SqlQuery.md)