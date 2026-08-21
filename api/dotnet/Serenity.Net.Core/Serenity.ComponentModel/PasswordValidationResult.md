# PasswordValidationResult enumeration
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Represents the result of a password validation attempt.

```csharp
public enum PasswordValidationResult
```

## Values

| name | value | description |
| --- | --- | --- |
| EmptyUsername | `0` | The username was empty. |
| EmptyPassword | `1` | The password was empty. |
| InactiveUser | `2` | The user account is not active. |
| UnknownSource | `3` | The user source could not be found. |
| Throttle | `4` | The request was throttled due to too many attempts. |
| DirectoryError | `5` | A directory service error occurred. |
| Invalid | `6` | The credentials are invalid. |
| Valid | `7` | The credentials are valid. |

## See Also

* **Source:** *[PasswordValidationResult.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/PasswordValidationResult.cs)*