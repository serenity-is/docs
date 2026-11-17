# DataValidation.ValidateObject method

Validates an object, e.g. the options of a service that is not a row, see ObjectValidationOptions).

```csharp
public static void ValidateObject(object instance, ObjectValidationOptions? options = null, 
    ITextLocalizer? localizer = null)
```

| parameter | description |
| --- | --- |
| instance | The object. |
| options | How it is validated, e.g. by the rules of a form. |
| localizer | Text localizer of the message of a required value. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | A property of the object is not valid. |

## See Also

* class [ObjectValidationOptions](../../../Serenity.Net.Core/Serenity.ComponentModel/ObjectValidationOptions.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)