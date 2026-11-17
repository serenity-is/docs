# ObjectValidationOptions class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

How an object is validated by [`ValidateObject`](./ValidationRules/ValidateObject.md).

```csharp
public class ObjectValidationOptions
```

## Public Members

| name | description |
| --- | --- |
| [ObjectValidationOptions](ObjectValidationOptions/ObjectValidationOptions.md)() | The default constructor. |
| [CheckRequiredAttribute](ObjectValidationOptions/CheckRequiredAttribute.md) { get; set; } | Gets or sets whether the [`RequiredAttribute`](./RequiredAttribute.md)s of the properties are checked, which is the default, while their [`RequiredWhenAttribute`](./RequiredWhenAttribute.md)s always are. They are not for a row, as a required field of a row is one that is not null in the database, which is checked otherwise, and its attribute only makes a field required in the forms. |
| [CheckRules](ObjectValidationOptions/CheckRules.md) { get; set; } | Gets or sets whether the validation rules of the properties are checked, which is the default. They are not when they are checked otherwise, e.g. the ones of a row by its save handler. |
| [GetValue](ObjectValidationOptions/GetValue.md) { get; set; } | Gets or sets how the value of a property is read, e.g. from the fields of a row, by its name. The values are read from the properties of the object when it is not set, and a property the object doesn't have is not checked. |
| [IncludeProperty](ObjectValidationOptions/IncludeProperty.md) { get; set; } | Gets or sets which properties are checked, e.g. only the ones an update has, by their names. All are checked when it is not set. The ones that are not checked are still read for the conditions of the others. |
| [IsInsert](ObjectValidationOptions/IsInsert.md) { get; set; } | Gets or sets whether the object is being inserted, for the fields hidden on insert or update, which are not checked, or null when neither applies. |
| [RulesType](ObjectValidationOptions/RulesType.md) { get; set; } | Gets or sets the type whose properties declare what is checked, e.g. a form, which is the type of the object when it is not set. The properties of the object are found by the names of the ones of this type. |
| [Services](ObjectValidationOptions/Services.md) { get; set; } | Gets or sets the services of the context the rules are checked in, e.g. a localizer, see [`GetLocalizer`](../Serenity/ValidationContextExtensions/GetLocalizer.md). |
| [TextKeyPrefix](ObjectValidationOptions/TextKeyPrefix.md) { get; set; } | Gets or sets the local text key prefix of the properties, which the implied text keys of the messages of their rules start with, e.g. `Forms.Northwind.Customer.`, by default the one of the form or columns of the [`RulesType`](./ObjectValidationOptions/RulesType.md), if it is one. |

## See Also

* **Source:** *[ObjectValidationOptions.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ObjectValidationOptions.cs)*