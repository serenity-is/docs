# SqlInsert class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Class to generate queries of the form `INSERT INTO tablename (field1, field2..fieldN) VALUES (value1, value2..valueN)`

```csharp
public class SqlInsert : QueryWithParams, ISetFieldByStatement
```

## Public Members

| name | description |
| --- | --- |
| [SqlInsert](SqlInsert/SqlInsert.md)(…) | Creates a new SqlInsert query. |
| [Clone](SqlInsert/Clone.md)() | Clones the query. |
| [Dialect](SqlInsert/Dialect.md)(…) | Sets the dialect (SQL server type / version) for query. |
| [GetFieldExpressions](SqlInsert/GetFieldExpressions.md)() | Returns field and value expression pairs. |
| [IdentityColumn](SqlInsert/IdentityColumn.md)() | Gets the identity column. |
| [IdentityColumn](SqlInsert/IdentityColumn.md)(…) | Sets the identity column. |
| [SetNull](SqlInsert/SetNull.md)(…) | Assigns NULL as the field value. |
| [SetTo](SqlInsert/SetTo.md)(…) | Sets field value. (2 methods) |
| [TableName](SqlInsert/TableName.md)() | Gets the table name. |
| override [ToString](SqlInsert/ToString.md)() | Gets string representation of the query. |
| [ToUpsertString](SqlInsert/ToUpsertString.md)(…) | Formats an UPSERT query, i.e. a query that updates the row matching the key fields or inserts a new row if no such row exists. |
| static [Format](SqlInsert/Format.md)(…) | Formats an INSERT query. |
| static [FormatUpsert](SqlInsert/FormatUpsert.md)(…) | Formats an UPSERT query, i.e. a query that updates the row matching the key fields or inserts a new row if no such row exists. |

## See Also

* class [QueryWithParams](QueryWithParams.md)
* interface [ISetFieldByStatement](ISetFieldByStatement.md)
* **Source:** *[SqlInsert.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/FluentSql/SqlInsert.cs)*