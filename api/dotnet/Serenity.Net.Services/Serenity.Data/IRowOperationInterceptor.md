# IRowOperationInterceptor interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface that allows you to intercept SQL operations on entities. Note that this does not intercept all SQL operations, only the ones that are done through EntityConnectionExtensions. This interface should be implemented by the mock connection class used in tests.

```csharp
public interface IRowOperationInterceptor
```

## Members

| name | description |
| --- | --- |
| [FindRow](IRowOperationInterceptor/FindRow.md)(…) | Intercepts EntityConnectionExtensions's ById/TryById/First/TryFirst/Single/TrySingle methods. |
| [FindRowAsync](IRowOperationInterceptor/FindRowAsync.md)(…) | Intercepts the async EntityConnectionExtensions ById/TryById/First/TryFirst/Single/TrySingle methods. The default implementation forwards to [`FindRow`](IRowOperationInterceptor/FindRow.md). |
| [ListRows](IRowOperationInterceptor/ListRows.md)(…) | Intercepts EntityConnectionExtensions.List and Count methods. |
| [ListRowsAsync](IRowOperationInterceptor/ListRowsAsync.md)(…) | Intercepts the async EntityConnectionExtensions List and Count methods. The default implementation forwards to [`ListRows`](IRowOperationInterceptor/ListRows.md). |
| [ManipulateRow](IRowOperationInterceptor/ManipulateRow.md)(…) | Intercepts EntityConnectionExtensions.DeleteById method. |
| [ManipulateRowAsync](IRowOperationInterceptor/ManipulateRowAsync.md)(…) | Intercepts the async EntityConnectionExtensions DeleteById/Insert/Update methods. The default implementation forwards to [`ManipulateRow`](IRowOperationInterceptor/ManipulateRow.md). |

## See Also

* **Source:** *[IRowOperationInterceptor.cs](https://github.com/serenity-is/Serenity/blob/73168d59056410d43d88aeecc9e4fe750d71793a/src/services/Entity/Extensions/IRowOperationInterceptor.cs)*