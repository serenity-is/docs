# DataValidation.InvalidIdError method (1 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns an invalid ID error

```csharp
public static ValidationError InvalidIdError(Field field, long value, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| field | Field |
| value | Value |
| localizer | Text localizer |

## See Also

* class [ValidationError](../Serenity.Net.Core/../ValidationError.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.InvalidIdError method (2 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns a Invalid ID error

```csharp
public static ValidationError InvalidIdError(IRow row, Field field, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| field | Field |
| localizer | Text localizer |

## See Also

* class [ValidationError](../Serenity.Net.Core/../ValidationError.md)
* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)