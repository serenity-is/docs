# DataValidation.ValidateObjectAsync method

Validates an object, like [`ValidateObject`](./ValidateObject.md), awaiting the rules that can be checked asynchronously.

```csharp
public static Task ValidateObjectAsync(object instance, ObjectValidationOptions? options = null, 
    ITextLocalizer? localizer = null, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| instance | The object. |
| options | How it is validated, e.g. by the rules of a form. |
| localizer | Text localizer of the message of a required value. |
| cancellationToken | The cancellation token. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | A property of the object is not valid. |

## See Also

* class [ObjectValidationOptions](../../../Serenity.Net.Core/Serenity.ComponentModel/ObjectValidationOptions.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)