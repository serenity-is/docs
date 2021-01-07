# IFilterableQuery interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Interface for query classes (e.g. SqlSelect, SqlUpdate) having a where method to filter records

```csharp
public interface IFilterableQuery : IQueryWithParams
```

## Members

| name | description |
| --- | --- |
| [Where](IFilterableQuery/Where.md)(…) | Filters a query by a filter string. |

## See Also

* interface [IQueryWithParams](IQueryWithParams.md)
* **Source:** *[IFilterableQuery.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/QueryModel/IFilterableQuery.cs)*