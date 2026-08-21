# IUserPasswordValidator.Validate method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Validates the specified username and password.

```csharp
public PasswordValidationResult Validate(ref string username, string password)
```

| parameter | description |
| --- | --- |
| username | The username to validate. The implementation may normalize the value in place. |
| password | The plain-text password to validate. |

## Return Value

Valid when the credentials are valid; otherwise a value indicating the reason for failure.

## See Also

* enum [PasswordValidationResult](../../Serenity.ComponentModel/PasswordValidationResult.md)
* interface [IUserPasswordValidator](../IUserPasswordValidator.md)