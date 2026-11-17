# FormValidationAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Makes the save handlers also validate by a form what they save, i.e. what the form checks in the browser that the row doesn't: its own [`RequiredAttribute`](./RequiredAttribute.md)s, [`RequiredWhenAttribute`](./RequiredWhenAttribute.md)s and validation rules, like [`ValidateRangeAttribute`](./ValidateRangeAttribute.md), skipping the fields the form hides or makes read only, as the browser does. It can be on a save handler, or on a row for the handlers that have none, and a handler can choose a form by its own logic instead, e.g. by overriding its `GetValidationForm`, when an entity has more than one.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public class FormValidationAttribute : Attribute
```

| parameter | description |
| --- | --- |
| formType | The type of the form, e.g. `typeof(CustomerForm)`. |

## Public Members

| name | description |
| --- | --- |
| [FormValidationAttribute](FormValidationAttribute/FormValidationAttribute.md)(…) | Makes the save handlers also validate by a form what they save, i.e. what the form checks in the browser that the row doesn't: its own [`RequiredAttribute`](./RequiredAttribute.md)s, [`RequiredWhenAttribute`](./RequiredWhenAttribute.md)s and validation rules, like [`ValidateRangeAttribute`](./ValidateRangeAttribute.md), skipping the fields the form hides or makes read only, as the browser does. It can be on a save handler, or on a row for the handlers that have none, and a handler can choose a form by its own logic instead, e.g. by overriding its `GetValidationForm`, when an entity has more than one. |
| [FormType](FormValidationAttribute/FormType.md) { get; } | Gets the type of the form. |

## See Also

* **Source:** *[FormValidationAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/FormValidationAttribute.cs)*