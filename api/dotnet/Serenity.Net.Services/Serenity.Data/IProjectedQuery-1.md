# IProjectedQuery&lt;TResult&gt; interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A reusable projected query that can be executed with per-call parameter overrides.

```csharp
public interface IProjectedQuery<TResult>
```

| parameter | description |
| --- | --- |
| TResult | The flat projection result type. |

## Members

| name | description |
| --- | --- |
| [List](IProjectedQuery-1/List.md)(…) | Executes the projection and buffers its results. |
| [ListAsync](IProjectedQuery-1/ListAsync.md)(…) | Asynchronously executes the projection and buffers its results. |
| [Query](IProjectedQuery-1/Query.md)(…) | Executes the projection and returns its results. Results are buffered by default. |
| [QueryAsync](IProjectedQuery-1/QueryAsync.md)(…) | Asynchronously streams the projected results. |

## See Also

* **Source:** *[IProjectedQuery.cs](https://github.com/serenity-is/Serenity/blob/2a803ec2ea06e7ccde726327384096507a8532d0/src/services/Entity/Extensions/IProjectedQuery.cs)*