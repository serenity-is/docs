# DataValidation.ValidateDateRange method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates date range is valid, e.g. start date is before end date etc.

```csharp
public static void ValidateDateRange(IRow row, DateTimeField start, DateTimeField finish, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| start | Start date |
| finish | End date |
| localizer | Text localizer |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [DateTimeField](../Serenity.Net.Entity/../../Serenity.Data/DateTimeField.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)