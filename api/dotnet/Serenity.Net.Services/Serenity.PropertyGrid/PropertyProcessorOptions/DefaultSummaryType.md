# PropertyProcessorOptions.DefaultSummaryType property
**namespace:** *[Serenity.PropertyGrid](../../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets or sets a the default summary type for numeric fields if no SummaryTypeAttribute is present. This only applies if the property is of a numeric type and is not a primary key, identity, foreign key, unbound or has a LeftJoin attribute. Default is SummaryType.Sum.

```csharp
public SummaryType? DefaultSummaryType { get; set; }
```

## See Also

* enum [SummaryType](../Serenity.Net.Core/../../Serenity/SummaryType.md)
* class [PropertyProcessorOptions](../PropertyProcessorOptions.md)