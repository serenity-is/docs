# DataValidation.RequiredError method (1 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns a required validation error

```csharp
public static ValidationError RequiredError(Field field, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| field | Field |
| localizer | Text localizer |

## See Also

* class [ValidationError](../Serenity.Net.Core/../ValidationError.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.RequiredError method (2 of 2)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns a required validation error

```csharp
public static ValidationError RequiredError(string name, ITextLocalizer localizer, 
    string title = null)
```

| parameter | description |
| --- | --- |
| name | Field name |
| localizer | Text localizer |
| title | Field title |

## See Also

* class [ValidationError](../Serenity.Net.Core/../ValidationError.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)