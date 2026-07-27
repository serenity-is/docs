# LocalizationRowAttribute.LocalizeListByDefault property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

If set to true returns translated values by default for the list handler (available in Pro.Extensions package) when ListRequest.Localize is not set, e.g. it is null. Note that if this is enabled, Request.Localize parameter must be specified as empty string to get original values.

```csharp
public bool LocalizeListByDefault { get; set; }
```

## See Also

* class [LocalizationRowAttribute](../LocalizationRowAttribute.md)