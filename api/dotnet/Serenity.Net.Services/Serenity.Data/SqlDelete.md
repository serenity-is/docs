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
| [Where](SqlDelete/Where.md)(…) | Adds a criteria to the WHERE part of the query with an "AND" between. |
| static [Format](SqlDelete/Format.md)(…) | Formats a DELETE query. |

## Remarks

Creates a new SqlDelete query.

## See Also

* class [QueryWithParams](./QueryWithParams.md)
* interface [IFilterableQuery](./IFilterableQuery.md)
* **Source:** *[SqlDelete.cs](https://github.com/serenity-is/Serenity/blob/de0a044eefe64e0284eb9b4ee9ae4d70a32f1359/src/services/Data/FluentSql/SqlDelete.cs)*