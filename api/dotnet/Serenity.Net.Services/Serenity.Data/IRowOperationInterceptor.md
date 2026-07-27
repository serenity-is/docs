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
| [ListRows](IRowOperationInterceptor/ListRows.md)(…) | Intercepts EntityConnectionExtensions.List and Count methods. |
| [ManipulateRow](IRowOperationInterceptor/ManipulateRow.md)(…) | Intercepts EntityConnectionExtensions.DeleteById method. |

## See Also

* **Source:** *[IRowOperationInterceptor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Extensions/IRowOperationInterceptor.cs)*