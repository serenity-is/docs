# SqlSettings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Global SQL settings

```csharp
public static class SqlSettings
```

## Public Members

| name | description |
| --- | --- |
| static [AutoQuotedIdentifiers](SqlSettings/AutoQuotedIdentifiers.md) { get; set; } | Gets or sets a value indicating whether to automatically quote identifiers. This is used as a fallback if the dialect and SqlSettings.DefaultDialect does not provide a value. Default is true. |
| static [DefaultCommandTimeout](SqlSettings/DefaultCommandTimeout.md) { get; set; } | Gets or sets the default command timeout. |
| static [DefaultDialect](SqlSettings/DefaultDialect.md) { get; set; } | The default dialect, returns the local dialect if any set through SetLocal, the default dialect otherwise. This should be only set on application start. Local dialect should be used for unit tests. |
| static [SetLocalDialect](SqlSettings/SetLocalDialect.md)(…) | Sets local dialect for current thread and async context. Useful for background tasks, async methods, and testing to set dialect locally and for auto spawned threads. |

## See Also

* **Source:** *[SqlSettings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/SqlHelpers/SqlSettings.cs)*