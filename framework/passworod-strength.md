# Password Strength

Serenity's built-in password strength validator is a feature designed to validate passwords entered by users based on custom-defined security standards. This feature plays a significant role in safeguarding your application by ensuring that all user passwords adhere to strong security criteria, thus minimizing the risk of unauthorized access.

These settings can be controlled via the `appsettings.json` file within the `Membership` section, ensuring that the management of these rules is both convenient and accessible.

The `MembershipSettings` class defines several properties with default values to establish a basic level of password strength. By modifying the values in `appsettings.json`, developers can customize these properties to align with organizational security standards or to respond to evolving threats.

Here's an example of how password rules can be configured within `appsettings.json`:

```json
"Membership": {
    "MinPasswordLength": 8,
    "RequireDigit": true,
    "RequireLowercase": true,
    "RequireNonAlphanumeric": true,
    "RequireUppercase": true,
    "SaltSize": 5
}
```

Each of the attributes within `Membership` section controls a different aspect of the password policy:

- `MinPasswordLength` sets the minimum character count for passwords. Default value is 8.
- `RequireDigit` requires at least one numeral within the password. Default value is `true`.
- `RequireLowercase` and `RequireUppercase` requires the inclusion of case-sensitive letters. Default values are `true`.
- `RequireNonAlphanumeric` requires the inclusion of special characters, such as punctuation marks. Spaces are not considered special characters. Default value is `true`.
- `SaltSize` determines the size of the cryptographic salt used in password hashing, providing additional security against hash-specific attacks. Default value is 5.

Adjusting these settings in the `appsettings.json` is straightforward. Developers can change the default values depending on the level of password security that the application requires.

## Password Strength Validation on server side

The `IPasswordStrengthValidator` represents a contract for a password strength validation service. Here's the definition with comments explaining its purpose and usage:

```cs
/// <summary>
/// Abstraction to validate the password strength
/// </summary>
public interface IPasswordStrengthValidator
{

    /// <summary>
    /// Validates password strength
    /// </summary>
    /// <param name="password"></param>
    /// <exception cref="ValidationError">Throws validation error if password 
    /// does not match the expected password strength rules</exception>
    void Validate(string password);
}
```

The `Validate` method checks the provided password against a set of strength criteria. If the password fails to meet these criteria, the implementation should throw a `ValidationError` which aspects of the strength requirements have not been satisfied. This interface abstraction allows for different implementations of password validation logic that can be swapped out or updated independently from the rest of the application, adhering to the principles of modularity and separation of concerns.

The `PasswordStrengthValidator` class in `Serenity.Extensions` implements the `IPasswordStrengthValidator` interface and provides the default password strength validation logic. It uses the `MembershipSettings` class to get the password strength rules and throws a `ValidationError` if the password does not meet the criteria.

To integrate the `IPasswordStrengthValidator` with a Serenity based application, registeration is required with the dependency injection container. This involves adding a line to the `ConfigureServices` method within your `Startup.cs` file to wire up the interface with a concrete implementation, which will provide the password validation logic.

Here is how you would add the necessary line to your Startup.cs file:

```cs
public void ConfigureServices(IServiceCollection services)
{
    // ...
    services.AddSingleton<IPasswordStrengthValidator, PasswordStrengthValidator>();
    // ...
}
```

This approach allows you to easily swap out the default implementation with a custom implementation, if necessary.

## Password Strength Validation on script side

The `PasswordStrengthValidation.ts` file in `Serenity.Extensions` contains the client side password strength validation logic. It has 2 exported functions: `getPasswordStrengthRules` that returns the password strength rules and `addPasswordStrengthValidation` that adds the password strength validation to the specified password editor.

The `addPasswordStrengthValidation` function takes 2 parameters:

- `editor` is the password editor to add the validation to.
- `uniqueName` is the unique name of the form that the editor is in. 

Here is an example usage:

```ts
import { addPasswordStrengthValidation } from "@serenity-is/extensions";

class ChangePasswordPanel<P = {}> extends PropertyPanel<ChangePasswordRequest, P> {

    protected getFormKey() { return ChangePasswordForm.formKey; }

    private form = new ChangePasswordForm(this.idPrefix);

    constructor(props: WidgetProps<P>) {
        super(props);

        addPasswordStrengthValidation(this.form.NewPassword, this.uniqueName);
        
        // ... other code
    }
}
```

## `PasswordStrengthRules` data script

Like the `UserDefinition` in `C#` and `UserData` in script side, the `PasswordStrengthRules` data script is used to transfer the password strength rules from the server to the client side. It is a simple data script with a single `PasswordStrengthRules` class that contains the password strength rules as properties.

Here is the definition of the `PasswordStrengthRules` object:

```ts
export interface PasswordStrengthRules {
    MinPasswordLength?: number;
    RequireDigit?: boolean;
    RequireLowercase?: boolean;
    RequireNonAlphanumeric?: boolean;
    RequireUppercase?: boolean;
}
```

To access the password strength rules from the client side, the function with name `getRemoteDataAsync` can be used like `await getRemoteDataAsync<PasswordStrengthRules>("PasswordStrengthRules")`. This function returns a promise that resolves to the password strength rules. The data script key is `PasswordStrengthRules` and it is defined on top of the `PasswordStrengthRulesDataScript` class in `Serenity.Extensions`.

When required, similar data script approach can be used to transfer custom password strength rules from server side to script side.

## Overriding the password screens and password strength rules

To override the password screens, you need to customize the password forms and panels. Serenity have `AccountPasswordActionsPageBase` which is the base class for the password actions pages. You need to override the `ModuleFolder` to point to your custom folder which contains `ChangePasswordPage.ts` and `SetPasswordPage.ts`. Don't forget when you override the `ModuleFolder` you need to copy or create own version of the `ForgotPasswordPage.ts` and `ResetPasswordPage.ts` files too.

After that, you can use similar approach like `PasswordStrengthRules` data script to transfer the password strength rules from server side to script side. You can use `PasswordStrengthRulesDataScript.cs` class as a sample for your custom data script class. You also need to update `UserDialog.ts` to use your custom password validations.
