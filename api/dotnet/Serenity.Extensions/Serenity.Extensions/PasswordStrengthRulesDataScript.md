# PasswordStrengthRulesDataScript class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

This declares a dynamic script with key 'PasswordStrengthRules' that will be available from client side.

```csharp
public class PasswordStrengthRulesDataScript : DataScript<PasswordStrengthRules>
```

## Public Members

| name | description |
| --- | --- |
| [PasswordStrengthRulesDataScript](PasswordStrengthRulesDataScript/PasswordStrengthRulesDataScript.md)(…) | This declares a dynamic script with key 'PasswordStrengthRules' that will be available from client side. |

## Protected Members

| name | description |
| --- | --- |
| override [GetData](PasswordStrengthRulesDataScript/GetData.md)() | Gets the password strength rules from the configured membership settings. |

## See Also

* class [DataScript&lt;TData&gt;](../../Serenity.Net.Services/Serenity.Web/DataScript-1.md)
* class [PasswordStrengthRules](./PasswordStrengthRules.md)
* **Source:** *[PasswordStrengthRulesDataScript.cs](https://github.com/serenity-is/Serenity/blob/996e620854dd44715465a4898d52f11f4fdf110b/common-features/src/extensions/Modules/Membership/PasswordStrength/PasswordStrengthRulesDataScript.cs)*