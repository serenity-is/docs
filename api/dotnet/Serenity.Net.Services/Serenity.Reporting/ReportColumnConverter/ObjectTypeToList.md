# ReportColumnConverter.ObjectTypeToList method

Extracts list of report columns from a type, which is usually a Columns type.

```csharp
public static List<ReportColumn> ObjectTypeToList(Type objectType, 
    IServiceProvider serviceProvider, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| objectType | The columns type |
| serviceProvider | Service provider |
| localizer | Text localizer |

## See Also

* class [ReportColumn](../ReportColumn.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [ReportColumnConverter](../ReportColumnConverter.md)