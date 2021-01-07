# SqlDelete class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Class to generate queries of form `DELETE FROM tablename WHERE [conditions]`.

```csharp
public sealed class SqlDelete : QueryWithParams, IFilterableQuery
```

## Public Members

| name | description |
| --- | --- |
| [SqlDelete](SqlDelete/SqlDelete.md)(…) | Creates a new SqlDelete query. |
| override [ToString](SqlDelete/ToString.md)() | Gets string representation of the query. |
| [Where](SqlDelete/Where.md)(…) | Adds a new condition to the WHERE part of the query with an "AND" between. (2 methods) |
| static [Format](SqlDelete/Format.md)(…) | Formats a DELETE query. |

## See Also

* class [QueryWithParams](QueryWithParams.md)
* interface [IFilterableQuery](IFilterableQuery.md)
* **Source:** *[SqlDelete.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/FluentSql/SqlDelete.cs)*