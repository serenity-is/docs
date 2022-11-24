# DataValidation.ValidateRequired method (1 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates that the field does not contain a null value or an empty string.

```csharp
public static void ValidateRequired(this IRow row, Field field, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| field | Field |
| localizer | Text localizer |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.ValidateRequired method (2 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates the fields does not contain null or empty string values. This does not validate unassigned fields that does not have a default value.

```csharp
public static void ValidateRequired(this IRow row, IEnumerable<Field> fields, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| fields | List of fields |
| localizer |  |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)