# PropertyProcessorOptions class
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Property item generation options for BasicPropertyProcessor

```csharp
public class PropertyProcessorOptions
```

## Public Members

| name | description |
| --- | --- |
| [PropertyProcessorOptions](PropertyProcessorOptions/PropertyProcessorOptions.md)() | The default constructor. |
| [DefaultSummaryType](PropertyProcessorOptions/DefaultSummaryType.md) { get; set; } | Gets or sets a the default summary type for numeric fields if no SummaryTypeAttribute is present. This only applies if the property is of a numeric type and is not a primary key, identity, foreign key, unbound or has a LeftJoin attribute. Default is SummaryType.Sum. |
| const [SectionKey](PropertyProcessorOptions/SectionKey.md) | Default section key |

## See Also

* **Source:** *[PropertyProcessorOptions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/PropertyGrid/BasicPropertyProcessor/PropertyProcessorOptions.cs)*