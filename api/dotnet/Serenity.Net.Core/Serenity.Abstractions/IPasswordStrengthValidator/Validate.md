# IPasswordStrengthValidator.Validate method

Validates the strength of the specified password.

```csharp
public void Validate(string password)
```

| parameter | description |
| --- | --- |
| password | The plain-text password to validate. |

## Exceptions

| exception | condition |
| --- | --- |
| [ValidationError](../../Serenity.Services/ValidationError.md) | Thrown when the password does not satisfy the strength rules. |

## See Also

* interface [IPasswordStrengthValidator](../IPasswordStrengthValidator.md)