# RowFieldsProvider class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Contains extension methods and settings for row fields providers

```csharp
public static class RowFieldsProvider
```

## Public Members

| name | description |
| --- | --- |
| static [Current](RowFieldsProvider/Current.md) { get; } | Gets current row fields provider. Returns async local provider if available, otherwise the default provider. |
| static [Resolve&lt;TFields&gt;](RowFieldsProvider/Resolve.md)() | Resolves a fields class using current row fields provider |
| static [Resolve&lt;TFields&gt;](RowFieldsProvider/Resolve.md)(…) | Resolves an aliased fields class using current row fields provider |
| static [SetDefault](RowFieldsProvider/SetDefault.md)(…) | Sets default row fields provider. This instance is required as rows might have to be created in contexts where dependency injection is not possible, like deserialization. If using a DI container, set this at startup to the same singleton service you register with DI. |
| static [SetDefaultFrom](RowFieldsProvider/SetDefaultFrom.md)(…) | Sets default row fields provider by resolving it from the service provider. |
| static [SetLocal](RowFieldsProvider/SetLocal.md)(…) | Sets local row fields provider for current thread and async context. Useful for background tasks, async methods, and testing to set provider locally and for auto spawned threads. |
| static [SetLocalFrom](RowFieldsProvider/SetLocalFrom.md)(…) | Sets local row fields provider by resolving it from the service provider. |

## See Also

* **Source:** *[RowFieldsProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/RowFieldsProvider.cs)*