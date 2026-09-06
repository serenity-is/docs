# PasswordStrengthValidator class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Validates passwords against the configured password strength rules.

```csharp
public class PasswordStrengthValidator : IPasswordStrengthValidator
```

## Public Members

| name | description |
| --- | --- |
| [PasswordStrengthValidator](PasswordStrengthValidator/PasswordStrengthValidator.md)(…) | Validates passwords against the configured password strength rules. |
| virtual [Validate](PasswordStrengthValidator/Validate.md)(…) | Validates the specified password against the configured strength rules, throwing a ValidationError if it does not meet the requirements. |

## See Also

* interface [IPasswordStrengthValidator](../../Serenity.Net.Core/Serenity.Abstractions/IPasswordStrengthValidator.md)
* **Source:** *[PasswordStrengthValidator.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/Membership/PasswordStrength/PasswordStrengthValidator.cs)*