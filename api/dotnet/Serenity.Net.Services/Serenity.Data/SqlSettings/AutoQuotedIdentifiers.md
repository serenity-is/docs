# SqlSettings.AutoQuotedIdentifiers property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets or sets a value indicating whether to automatically quote identifiers. This is used as a fallback if the dialect and SqlSettings.DefaultDialect does not provide a value. Default is true.

```csharp
public static bool AutoQuotedIdentifiers { get; set; }
```

## Property Value

`true` if should automatically quote identifiers; otherwise, `false`.

## See Also

* class [SqlSettings](../SqlSettings.md)