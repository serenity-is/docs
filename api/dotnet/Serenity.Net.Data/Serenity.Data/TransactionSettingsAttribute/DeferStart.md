# TransactionSettingsAttribute.DeferStart property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets / sets if the transaction start should be deferred if possible (generally until the connection property of unit of work object is read). This might have undesired side effects so use with care.

```csharp
public bool DeferStart { get; set; }
```

## See Also

* class [TransactionSettingsAttribute](../TransactionSettingsAttribute.md)