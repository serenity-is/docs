# TabularDataReport.FromPropertyItem method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a [`ReportColumn`](../ReportColumn.md) from a PropertyItem

```csharp
public static ReportColumn FromPropertyItem(PropertyItem item, Field field, PropertyInfo property, 
    IServiceProvider provider, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| item | Property item |
| field | Optional field object |
| property | PropertyInfo if any |
| provider | Service provider |
| localizer | Text localizer |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | item or localizer is null |

## See Also

* class [ReportColumn](../ReportColumn.md)
* class [PropertyItem](../Serenity.Net.Core/../../Serenity.ComponentModel/PropertyItem.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [TabularDataReport](../TabularDataReport.md)