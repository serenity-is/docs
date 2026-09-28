# IFilterableQuery interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for query classes (e.g. SqlSelect, SqlUpdate) having a where method to filter records.

```csharp
public interface IFilterableQuery : IQueryWithParams
```

## Members

| name | description |
| --- | --- |
| [GetWhereClause](IFilterableQuery/GetWhereClause.md)() | Gets the WHERE conditions as SQL text, without the WHERE keyword. |
| [GetWhereCriteria](IFilterableQuery/GetWhereCriteria.md)() | Gets the criteria passed to the query's WHERE method. |
| [Where](IFilterableQuery/Where.md)(…) | Filters a query by a criteria. |

## See Also

* interface [IQueryWithParams](./IQueryWithParams.md)
* **Source:** *[IFilterableQuery.cs](https://github.com/serenity-is/Serenity/blob/de0a044eefe64e0284eb9b4ee9ae4d70a32f1359/src/services/Data/QueryModel/IFilterableQuery.cs)*