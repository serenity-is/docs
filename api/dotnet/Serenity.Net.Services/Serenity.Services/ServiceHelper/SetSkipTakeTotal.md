# ServiceHelper.SetSkipTakeTotal&lt;T&gt; method (1 of 2)

Sets the Skip, Take and Total parameters in the response

```csharp
public static void SetSkipTakeTotal<T>(this ListResponse<T> response, SqlQuery query)
```

| parameter | description |
| --- | --- |
| T | Type of the response entities |
| response | Response object |
| query | Query to get params from |

## See Also

* class [ListResponse&lt;T&gt;](../ListResponse-1.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ServiceHelper](../ServiceHelper.md)

---

# ServiceHelper.SetSkipTakeTotal&lt;T&gt; method (2 of 2)

Sets paging metadata using the state returned by [`ApplyPagingParams`](../ServiceQueryHelper/ApplyPagingParams.md).

```csharp
public static void SetSkipTakeTotal<T>(this ListResponse<T> response, SqlQuery query, 
    ListRequestPagingState pagingState, int? distinctFieldCount = null, int? rowsRead = null)
```

| parameter | description |
| --- | --- |
| T | Type of the response entities |
| response | Response object |
| query | Query after execution |
| pagingState | Paging strategy selected before query execution |
| distinctFieldCount | Number of fields in each flattened distinct value tuple, or null for entities. |
| rowsRead | Number of rows returned by the query before post-processing (e.g. `ProcessEntity` dropping rows). When provided, the [`More`](../ListResponse-1/More.md) sentinel check uses it, so a dropped row does not hide the existence of further results. |

## See Also

* class [ListResponse&lt;T&gt;](../ListResponse-1.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestPagingState](../ListRequestPagingState.md)
* class [ServiceHelper](../ServiceHelper.md)