# IPasswordStrengthValidator.Validate method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Validates password strength

```csharp
public void Validate(string password)
```

| parameter | description |
| --- | --- |
| password |  |

## Exceptions

| exception | condition |
| --- | --- |
| [ValidationError](../../Serenity.Services/ValidationError.md) | Throws validation error if password does not match the expected password strength rules |

## See Also

* interface [IPasswordStrengthValidator](../IPasswordStrengthValidator.md)