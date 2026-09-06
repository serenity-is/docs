# ServiceQueryHelper.ApplySkipTakeAndCount method

Applies skip, take and exclude total count parameters to the query.

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

## Return Value

The query.

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)