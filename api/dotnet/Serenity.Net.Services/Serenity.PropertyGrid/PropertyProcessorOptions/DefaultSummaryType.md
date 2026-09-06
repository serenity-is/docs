# PropertyProcessorOptions.DefaultSummaryType property

Gets or sets the default summary type for numeric fields if no SummaryTypeAttribute is present. This only applies if the property is of a numeric type and is not a primary key, identity, foreign key, unbound or has a [`LeftJoinAttribute`](../../Serenity.Data.Mapping/LeftJoinAttribute.md). Default is Sum.

```csharp
public SummaryType? DefaultSummaryType { get; set; }
```

## See Also

* enum [SummaryType](../../../Serenity.Net.Core/Serenity/SummaryType.md)
* class [PropertyProcessorOptions](../PropertyProcessorOptions.md)