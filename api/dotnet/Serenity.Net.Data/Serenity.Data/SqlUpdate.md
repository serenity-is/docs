# SqlUpdate class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Generates queries of the form `UPDATE tablename SET field1 = value1, field2 = value2 ... fieldN = valueN WHERE [filter]`.

```csharp
public class SqlUpdate : QueryWithParams, IFilterableQuery, ISetFieldByStatement
```

## Public Members

| name | description |
| --- | --- |
| [SqlUpdate](SqlUpdate/SqlUpdate.md)(…) | Creates a new SqlUpdate query. |
| [Clone](SqlUpdate/Clone.md)() | Clones this SqlUpdate query. |
| [Dec](SqlUpdate/Dec.md)(…) | Decreases a fields value. (2 methods) |
| [Dialect](SqlUpdate/Dialect.md)(…) | Sets the dialect (SQL server type / version) for query. |
| [Inc](SqlUpdate/Inc.md)(…) | Increases a fields value. (2 methods) |
| [SetNull](SqlUpdate/SetNull.md)(…) | Sets field value to NULL. |
| [SetTo](SqlUpdate/SetTo.md)(…) | Sets field value to the expression. (2 methods) |
| override [ToString](SqlUpdate/ToString.md)() | Gets string representation of SqlUpdate query. |
| [Where](SqlUpdate/Where.md)(…) | Adds a condition to WHERE clause of the query. (2 methods) |
| static [Format](SqlUpdate/Format.md)(…) | Formats an SQL UPDATE statement. |
| static [RemoveT0Reference](SqlUpdate/RemoveT0Reference.md)(…) | Removes the t0 reference from an SQL field reference. |

## Remarks

To determine updated field values, Set(field, value) should be called several times.Where expressions determines the record(s) to update.

## See Also

* class [QueryWithParams](QueryWithParams.md)
* interface [IFilterableQuery](IFilterableQuery.md)
* interface [ISetFieldByStatement](ISetFieldByStatement.md)
* **Source:** *[SqlUpdate.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/FluentSql/SqlUpdate.cs)*