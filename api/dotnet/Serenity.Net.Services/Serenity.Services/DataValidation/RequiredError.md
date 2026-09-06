# DataValidation.RequiredError method (1 of 2)

Returns a required validation error

```csharp
public static ValidationError RequiredError(Field field, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| field | Field |
| localizer | Text localizer |

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.RequiredError method (2 of 2)

Returns a required validation error.

```csharp
public static ValidationError RequiredError(string name, ITextLocalizer localizer, 
    string title = null)
```

| parameter | description |
| --- | --- |
| name | Field name |
| localizer | Text localizer |
| title | Field title |

## Return Value

The required validation error.

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)