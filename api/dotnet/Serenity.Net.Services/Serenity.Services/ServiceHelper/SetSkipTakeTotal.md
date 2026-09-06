# ServiceHelper.SetSkipTakeTotal&lt;T&gt; method

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