# PasswordValidationResult enumeration
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Password validation result

```csharp
public enum PasswordValidationResult
```

## Values

| name | value | description |
| --- | --- | --- |
| EmptyUsername | `0` | Username is empty |
| EmptyPassword | `1` | Password is empty |
| InactiveUser | `2` | User is not active |
| UnknownSource | `3` | User source is not found |
| Throttle | `4` | To many retries |
| DirectoryError | `5` | Directory error |
| Invalid | `6` | Invalid |
| Valid | `7` | Valid |

## See Also

* **Source:** *[PasswordValidationResult.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/PasswordValidationResult.cs)*