# SqlDelete class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Class to generate queries of form `DELETE FROM tablename WHERE [conditions]`.

```csharp
public class SqlDelete : QueryWithParams, IFilterableQuery
```

| parameter | description |
| --- | --- |
| tableName | Table to delete records from (required). |

## Public Members

| name | description |
| --- | --- |
| [SqlDelete](SqlDelete/SqlDelete.md)(…) | Class to generate queries of form `DELETE FROM tablename WHERE [conditions]`. |
| [Clone](SqlDelete/Clone.md)() | Clones this SqlDelete query. |
| override [ToString](SqlDelete/ToString.md)() | Gets string representation of the query. |
| [Where](SqlDelete/Where.md)(…) | Adds a criteria to the WHERE part of the query with an "AND" between. |
| static [Format](SqlDelete/Format.md)(…) | Formats a DELETE query. |

## Remarks

Creates a new SqlDelete query.

## See Also

* class [QueryWithParams](./QueryWithParams.md)
* interface [IFilterableQuery](./IFilterableQuery.md)
* **Source:** *[SqlDelete.cs](https://github.com/serenity-is/Serenity/blob/abc2c8d4a2aa2be4c3652541931f850f86324a47/src/services/Data/FluentSql/SqlDelete.cs)*