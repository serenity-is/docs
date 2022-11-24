# ServiceQueryHelper.ApplySkipTakeAndCount method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies skip, take and exclude total count parameters to the query

```csharp
public static SqlQuery ApplySkipTakeAndCount(this SqlQuery query, int skip, int take, 
    bool excludeTotalCount)
```

| parameter | description |
| --- | --- |
| query | Query |
| skip | Skip parameter |
| take | Take parameter |
| excludeTotalCount | ExcludeTotalCount flag |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)