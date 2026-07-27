# ISqlDialect.AutoQuotedIdentifiers property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets a value indicating whether to automatically quote identifiers. Default is null, e.g. SqlSettings.AutoQuotedIdentifiers is used, which itself is false by default, but usually set to true in applications.

```csharp
public bool? AutoQuotedIdentifiers { get; }
```

## See Also

* interface [ISqlDialect](../ISqlDialect.md)