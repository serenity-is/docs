# ServiceQueryHelper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains static helper methods for service handler queries.

```csharp
public static class ServiceQueryHelper
```

## Public Members

| name | description |
| --- | --- |
| static [ApplyContainsText](ServiceQueryHelper/ApplyContainsText.md)(…) | Applies contains text criteria to the query |
| static [ApplySkipTakeAndCount](ServiceQueryHelper/ApplySkipTakeAndCount.md)(…) | Applies skip, take and exclude total count parameters to the query |
| static [ApplySort](ServiceQueryHelper/ApplySort.md)(…) | Applies the sort order to the query (3 methods) |
| static [GetContainsTextFilter](ServiceQueryHelper/GetContainsTextFilter.md)(…) | Creates a contains text criteria |
| static [GetNotDeletedCriteria](ServiceQueryHelper/GetNotDeletedCriteria.md)(…) | Gets not deleted criteria for a row type, e.g. for rows that support soft delete. |
| static [UseSoftDelete](ServiceQueryHelper/UseSoftDelete.md)(…) | Returns if row uses soft delete |

## See Also

* **Source:** *[ServiceQueryHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Helpers/ServiceQueryHelper.cs)*