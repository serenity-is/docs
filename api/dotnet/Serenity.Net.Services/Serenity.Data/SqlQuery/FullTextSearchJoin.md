# SqlQuery.FullTextSearchJoin method

Creates the required join for full text search in MSSQL.

```csharp
public SqlQuery FullTextSearchJoin(string searchTable, string searchFields, string searchQuery, 
    string searchTableAlias, string searchTableKey, string containsAlias)
```

| parameter | description |
| --- | --- |
| searchTable | Table name containing the fields to be searched (required). |
| searchFields | Fields to be searched (required). |
| searchQuery | Searched word or phrase (required). Words must be separated by comma. |
| searchTableAlias | Alias assigned to the table to be searched in the FROM part of the query (required, e.g. T0). |
| searchTableKey | Key (ID) field of the table to be searched (required). |
| containsAlias | Alias to be assigned to the joined contains table (required, e.g. CT). |

## Return Value

The SqlSelect object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Any of the parameters is null or empty. |

## Remarks

This join uses SQL Server's `CONTAINSTABLE` syntax and is SQL Server specific. It is emitted as-is for all dialects, similar to table hints; use it only with SQL Server. Table and field arguments are SQL fragments and are not automatically quoted or validated.

## See Also

* class [SqlQuery](../SqlQuery.md)