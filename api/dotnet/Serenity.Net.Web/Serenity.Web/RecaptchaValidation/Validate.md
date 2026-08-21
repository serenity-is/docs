# RecaptchaValidation.Validate method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Validates a recaptcha token against the Google site verify endpoint.

```csharp
public static void Validate(string secretKey, string token, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| secretKey | The secret key. |
| token | The recaptcha token to validate. |
| localizer | The text localizer. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | The token is empty or the verification fails. |

## Remarks

Inspired from https://github.com/tanveery/recaptcha-net/blob/master/src/Recaptcha.Web/RecaptchaVerificationHelper.cs

## See Also

* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [RecaptchaValidation](../RecaptchaValidation.md)