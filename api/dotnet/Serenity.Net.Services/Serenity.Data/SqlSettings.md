# SqlSettings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Global SQL settings.

```csharp
public static class SqlSettings
```

## Public Members

| name | description |
| --- | --- |
| static [AutoQuotedIdentifiers](SqlSettings/AutoQuotedIdentifiers.md) { get; set; } | Gets or sets a value indicating whether to automatically quote identifiers. This is used as a fallback if the dialect and [`DefaultDialect`](./SqlSettings/DefaultDialect.md) do not provide a value. Default is true. |
| static [DefaultCommandTimeout](SqlSettings/DefaultCommandTimeout.md) { get; set; } | Gets or sets the default command timeout. Returns the local timeout if any is set through [`SetLocalCommandTimeout`](./SqlSettings/SetLocalCommandTimeout.md), otherwise the default timeout. The local timeout should be used for unit tests. |
| static [DefaultComparer](SqlSettings/DefaultComparer.md) { get; set; } | Gets or sets the default comparer used to compare string field values (e.g. for change detection or dirty tracking) when a field, row or connection does not specify one. Returns the local comparer if any is set through [`SetLocalComparer`](./SqlSettings/SetLocalComparer.md), otherwise the default comparer. Defaults to CurrentCulture. This should only be set on application start. The local comparer should be used for unit tests. |
| static [DefaultDialect](SqlSettings/DefaultDialect.md) { get; set; } | Gets or sets the default dialect. Returns the local dialect if any is set through [`SetLocalDialect`](./SqlSettings/SetLocalDialect.md), otherwise the default dialect. This should only be set on application start. The local dialect should be used for unit tests. |
| static [SetLocalCommandTimeout](SqlSettings/SetLocalCommandTimeout.md)(…) | Sets the local command timeout for the current thread and async context. Useful for background tasks, async methods, and testing to set the timeout locally and for auto spawned threads. |
| static [SetLocalComparer](SqlSettings/SetLocalComparer.md)(…) | Sets the local comparer for the current thread and async context. Useful for background tasks, async methods, and testing to set the comparer locally and for auto spawned threads. |
| static [SetLocalDialect](SqlSettings/SetLocalDialect.md)(…) | Sets the local dialect for the current thread and async context. Useful for background tasks, async methods, and testing to set the dialect locally and for auto spawned threads. |

## See Also

* **Source:** *[SqlSettings.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Data/SqlHelpers/SqlSettings.cs)*