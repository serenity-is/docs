# IFilterableQuery interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for query classes (e.g. SqlSelect, SqlUpdate) having a where method to filter records.

```csharp
public interface IFilterableQuery : IQueryWithParams
```

## Members

| name | description |
| --- | --- |
| [Where](IFilterableQuery/Where.md)(…) | Filters a query by a filter string. |

## See Also

* interface [IQueryWithParams](IQueryWithParams.md)
* **Source:** *[IFilterableQuery.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/QueryModel/IFilterableQuery.cs)*