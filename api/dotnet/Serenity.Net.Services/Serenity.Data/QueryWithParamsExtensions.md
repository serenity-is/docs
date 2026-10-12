# QueryWithParamsExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extension methods for classes implementing [`IQueryWithParams`](./IQueryWithParams.md).

```csharp
public static class QueryWithParamsExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddParam&lt;TQuery&gt;](QueryWithParamsExtensions/AddParam.md)(…) | Adds the parameter. |
| static [Freeze&lt;TQuery&gt;](QueryWithParamsExtensions/Freeze.md)(…) | Freezes the query and its parameters, and prepares its SQL text for reuse. |
| static [FreezeParams&lt;TQuery&gt;](QueryWithParamsExtensions/FreezeParams.md)(…) | Freezes the query's parameters so they can no longer be added or changed. |
| static [SetParam&lt;TQuery&gt;](QueryWithParamsExtensions/SetParam.md)(…) | Sets the parameter. |

## See Also

* **Source:** *[QueryWithParamsExtensions.cs](https://github.com/serenity-is/Serenity/blob/028603594e120da335eefb6e5088403e8fb06a32/src/services/Data/QueryExtensions/QueryWithParamsExtensions.cs)*