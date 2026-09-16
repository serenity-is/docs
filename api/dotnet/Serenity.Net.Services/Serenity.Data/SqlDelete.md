# SqlDelete class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Class to generate queries of form `DELETE FROM tablename WHERE [conditions]`.

```csharp
public sealed class SqlDelete : QueryWithParams, IFilterableQuery
```

| parameter | description |
| --- | --- |
| tableName | Table to delete records from (required). |

## Public Members

| name | description |
| --- | --- |
| [SqlDelete](SqlDelete/SqlDelete.md)(…) | Class to generate queries of form `DELETE FROM tablename WHERE [conditions]`. |
| override [ToString](SqlDelete/ToString.md)() | Gets string representation of the query. |
| [Where](SqlDelete/Where.md)(…) | Adds a new condition to the WHERE part of the query with an "AND" between. (2 methods) |
| static [Format](SqlDelete/Format.md)(…) | Formats a DELETE query. |

## Remarks

Creates a new SqlDelete query.

## See Also

* class [QueryWithParams](./QueryWithParams.md)
* interface [IFilterableQuery](./IFilterableQuery.md)
* **Source:** *[SqlDelete.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/services/Data/FluentSql/SqlDelete.cs)*