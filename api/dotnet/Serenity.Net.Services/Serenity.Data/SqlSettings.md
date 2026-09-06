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
| static [DefaultCommandTimeout](SqlSettings/DefaultCommandTimeout.md) { get; set; } | Gets or sets the default command timeout. |
| static [DefaultDialect](SqlSettings/DefaultDialect.md) { get; set; } | Gets or sets the default dialect. Returns the local dialect if any is set through [`SetLocalDialect`](./SqlSettings/SetLocalDialect.md), otherwise the default dialect. This should only be set on application start. The local dialect should be used for unit tests. |
| static [SetLocalDialect](SqlSettings/SetLocalDialect.md)(…) | Sets the local dialect for the current thread and async context. Useful for background tasks, async methods, and testing to set the dialect locally and for auto spawned threads. |

## See Also

* **Source:** *[SqlSettings.cs](https://github.com/serenity-is/Serenity/blob/fa8ddd78cf707d00a1aca68d898e31e73d5971b9/src/services/Data/SqlHelpers/SqlSettings.cs)*