# SqlInsert class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

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
| [IdentityColumn](SqlInsert/IdentityColumn.md)() | Gets the identity column. |
| [IdentityColumn](SqlInsert/IdentityColumn.md)(…) | Sets the identity column. |
| [SetNull](SqlInsert/SetNull.md)(…) | Assigns NULL as the field value. |
| [SetTo](SqlInsert/SetTo.md)(…) | Sets field value. (2 methods) |
| override [ToString](SqlInsert/ToString.md)() | Gets string representation of the query. |
| static [Format](SqlInsert/Format.md)(…) | Formats an INSERT query. |

## See Also

* class [QueryWithParams](QueryWithParams.md)
* interface [ISetFieldByStatement](ISetFieldByStatement.md)
* **Source:** *[SqlInsert.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/FluentSql/SqlInsert.cs)*