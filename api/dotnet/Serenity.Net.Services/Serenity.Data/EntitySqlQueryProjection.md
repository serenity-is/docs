# EntitySqlQueryProjection class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extensions for SQL query projections.

```csharp
public static class EntitySqlQueryProjection
```

## Public Members

| name | description |
| --- | --- |
| static [AsReusableProjected&lt;TRow,TResult&gt;](EntitySqlQueryProjection/AsReusableProjected.md)(…) | Prepares a reusable flat projection. The source query must be a root query without existing SELECT columns. (2 methods) |
| static [AsReusableProjected&lt;TRow1,TRow2,TResult&gt;](EntitySqlQueryProjection/AsReusableProjected.md)(…) | Prepares a reusable flat projection. The source query must be a root query without existing SELECT columns. (2 methods) |
| static [AsReusableProjected&lt;TRow1,TRow2,TRow3,TResult&gt;](EntitySqlQueryProjection/AsReusableProjected.md)(…) | Prepares a reusable flat projection. The source query must be a root query without existing SELECT columns. (2 methods) |
| static [ListProjected&lt;TRow,TResult&gt;](EntitySqlQueryProjection/ListProjected.md)(…) | Executes the query and materializes each result row into the specified flat projection. (2 methods) |
| static [ListProjected&lt;TRow1,TRow2,TResult&gt;](EntitySqlQueryProjection/ListProjected.md)(…) | Executes the query and materializes each result row into the specified flat projection. (2 methods) |
| static [ListProjected&lt;TRow1,TRow2,TRow3,TResult&gt;](EntitySqlQueryProjection/ListProjected.md)(…) | Executes the query and materializes each result row into the specified flat projection. (2 methods) |
| static [ListProjectedAsync&lt;TRow,TResult&gt;](EntitySqlQueryProjection/ListProjectedAsync.md)(…) | Asynchronously executes the query and buffers the flat projection results. (2 methods) |
| static [ListProjectedAsync&lt;TRow1,TRow2,TResult&gt;](EntitySqlQueryProjection/ListProjectedAsync.md)(…) | Asynchronously executes the query and buffers the flat projection results. (2 methods) |
| static [ListProjectedAsync&lt;TRow1,TRow2,TRow3,TResult&gt;](EntitySqlQueryProjection/ListProjectedAsync.md)(…) | Asynchronously executes the query and buffers the flat projection results. (2 methods) |
| static [QueryProjected&lt;TRow,TResult&gt;](EntitySqlQueryProjection/QueryProjected.md)(…) | Executes the query and materializes each result row into the specified flat projection. The query must not already have SELECT columns. Each selector parameter must match one unambiguous row-fields source in the query, or sources can be supplied explicitly. (2 methods) |
| static [QueryProjected&lt;TRow1,TRow2,TResult&gt;](EntitySqlQueryProjection/QueryProjected.md)(…) | Executes the query and materializes each result row into the specified flat projection. When *buffered* is false, the data reader remains open until enumeration completes or the enumerator is disposed. (2 methods) |
| static [QueryProjected&lt;TRow1,TRow2,TRow3,TResult&gt;](EntitySqlQueryProjection/QueryProjected.md)(…) | Executes the query and materializes each result row into the specified flat projection. When *buffered* is false, the data reader remains open until enumeration completes or the enumerator is disposed. (2 methods) |
| static [QueryProjectedAsync&lt;TRow,TResult&gt;](EntitySqlQueryProjection/QueryProjectedAsync.md)(…) | Asynchronously streams the flat projection results. The data reader remains open until enumeration completes, is cancelled, or the async enumerator is disposed. (2 methods) |
| static [QueryProjectedAsync&lt;TRow1,TRow2,TResult&gt;](EntitySqlQueryProjection/QueryProjectedAsync.md)(…) | Asynchronously streams the flat projection results. The data reader remains open until enumeration completes, is cancelled, or the async enumerator is disposed. (2 methods) |
| static [QueryProjectedAsync&lt;TRow1,TRow2,TRow3,TResult&gt;](EntitySqlQueryProjection/QueryProjectedAsync.md)(…) | Asynchronously streams the flat projection results. The data reader remains open until enumeration completes, is cancelled, or the async enumerator is disposed. (2 methods) |

## Remarks

Projection selectors currently support flat anonymous types, constructor projections, and object initializers whose values are direct row field accesses. Sources are inferred from query row fields when each selector parameter has one unique match, or can be supplied explicitly. Unbuffered results keep the data reader open until enumeration completes or the enumerator is disposed.

## See Also

* **Source:** *[EntitySqlQueryProjection.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Entity/Extensions/EntitySqlQueryProjection.cs)*