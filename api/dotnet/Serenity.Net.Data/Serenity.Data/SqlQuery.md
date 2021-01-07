# SqlQuery class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

SQL query string builder

```csharp
public class SqlQuery : QueryWithParams, IFilterableQuery, IGetExpressionByName, ISqlQuery, 
    ISqlQueryExtensible
```

## Public Members

| name | description |
| --- | --- |
| [SqlQuery](SqlQuery/SqlQuery.md)() | Creates a new SqlQuery instance. |
| [CountRecords](SqlQuery/CountRecords.md) { get; set; } | Gets/sets the flag to get the total record count when paging is used by SKIP/TAKE. A secondary query without SKIP/TAKE is generated to get total record count, when this property is true. |
| [Text](SqlQuery/Text.md) { get; } | Gets current query text. |
| [Clone](SqlQuery/Clone.md)() | Creates a clone of the query. |
| [Dialect](SqlQuery/Dialect.md)(…) | Sets the dialect (SQL server type / version) for query. |
| [Distinct](SqlQuery/Distinct.md)(…) | Sets DISTINCT flag. |
| [EnsureJoin](SqlQuery/EnsureJoin.md)(…) | Ensures the join. |
| [EnsureJoinsInExpression](SqlQuery/EnsureJoinsInExpression.md)(…) | Ensures the joins in expression. For this to work, into row must provide a list of joins and their expressions. |
| [ForJson](SqlQuery/ForJson.md)(…) | Adds a FOR JSON statement to the query. |
| [ForXml](SqlQuery/ForXml.md)(…) | Adds a FOR XML statement to the query. |
| [From](SqlQuery/From.md)(…) | Adds a table to the FROM statement. When it is called more than once, puts a comma between table names (cross join) (4 methods) |
| [FullTextSearchJoin](SqlQuery/FullTextSearchJoin.md)(…) | MSSQL'de full text araması için gerekli join'i oluşturur. |
| [GroupBy](SqlQuery/GroupBy.md)(…) | Adds a field name or an SQL expression to the GROUP BY clause. (2 methods) |
| [Having](SqlQuery/Having.md)(…) | Adds an SQL expression to the GROUP BY clause. |
| [InnerJoin](SqlQuery/InnerJoin.md)(…) | Adds an inner join to the query. |
| [Join](SqlQuery/Join.md)(…) | Joins the specified join. |
| [LeftJoin](SqlQuery/LeftJoin.md)(…) | Adds a LEFT JOIN to the query. (2 methods) |
| [OrderBy](SqlQuery/OrderBy.md)(…) | Adds a field name or an SQL expression to the ORDER BY clause. (2 methods) |
| [OrderByFirst](SqlQuery/OrderByFirst.md)(…) | Inserts a field name or an SQL expression to the start of ORDER BY clause. |
| [RightJoin](SqlQuery/RightJoin.md)(…) | Adds a right join to the query. (2 methods) |
| [Select](SqlQuery/Select.md)(…) | Adds a field name or an SQL expression to the SELECT statement. (6 methods) |
| [SelectMany](SqlQuery/SelectMany.md)(…) | Adds field names or SQL expressions to the SELECT statement. |
| [Skip](SqlQuery/Skip.md)() | Gets current SKIP value. |
| [Skip](SqlQuery/Skip.md)(…) | Sets SKIP value. Used for paging. |
| [SubQuery](SqlQuery/SubQuery.md)() | Creates a new query that shares parameter dictionary with this query. |
| [Take](SqlQuery/Take.md)() | Gets TAKE/TOP value. |
| [Take](SqlQuery/Take.md)(…) | Sets TAKE/TOP value. Used for paging. |
| override [ToString](SqlQuery/ToString.md)() | Formats SQL Query as string. If paging is used and skip requested, multiple queries might be created one after each other. |
| [Union](SqlQuery/Union.md)(…) | Adds a union to query with the specified union type. |
| [Where](SqlQuery/Where.md)(…) | Adds an expression to WHERE clause. If query already has a WHERE clause, inserts AND between existing one and new one. (2 methods) |
| class [Column](SqlQuery.Column.md) | Holds information about a column in SELECT clause. |

## See Also

* class [QueryWithParams](QueryWithParams.md)
* interface [IFilterableQuery](IFilterableQuery.md)
* interface [IGetExpressionByName](IGetExpressionByName.md)
* interface [ISqlQuery](ISqlQuery.md)
* interface [ISqlQueryExtensible](ISqlQueryExtensible.md)
* **Source:** *[SqlQuery.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/FluentSql/SqlQuery.cs)*