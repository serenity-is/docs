# DataValidation.ObjectValidationError method

Gets the error of a property of an object that is not valid: a required error for a missing value, with the title of the property, else the message of the rule it is not valid by.

```csharp
public static ValidationError ObjectValidationError(ObjectValidationFailure failure, 
    ITextLocalizer? localizer, string? name = null, string? title = null)
```

| parameter | description |
| --- | --- |
| failure | The failure. |
| localizer | Text localizer of the message of a required value. |
| name | The name the error is for, by default the name of the property, e.g. the name of the field of a row. |
| title | The title of the property, by default its name. |

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* class [ObjectValidationFailure](../../../Serenity.Net.Core/Serenity.ComponentModel/ObjectValidationFailure.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)