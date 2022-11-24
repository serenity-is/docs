# DataValidation.ValidateRequiredIfModified method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates that field values does not contain a null or empty string if the field is assigned

```csharp
public static void ValidateRequiredIfModified(this IRow row, IEnumerable<Field> fields, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| fields | List of fields |
| localizer | Text localizer |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)