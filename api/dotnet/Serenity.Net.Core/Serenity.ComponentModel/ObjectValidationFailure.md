# ObjectValidationFailure class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Why an object is not valid, see [`ValidateObject`](./ValidationRules/ValidateObject.md): the first property whose value is not.

```csharp
public class ObjectValidationFailure
```

| parameter | description |
| --- | --- |
| propertyName | The name of the property. |
| message | The message of the rule the value is not valid by, or null for a required value that is missing. |

## Public Members

| name | description |
| --- | --- |
| [ObjectValidationFailure](ObjectValidationFailure/ObjectValidationFailure.md)(…) | Why an object is not valid, see [`ValidateObject`](./ValidationRules/ValidateObject.md): the first property whose value is not. |
| [IsRequired](ObjectValidationFailure/IsRequired.md) { get; } | Gets whether a required value is missing. |
| [Message](ObjectValidationFailure/Message.md) { get; } | Gets the message of the rule the value is not valid by, or null when a required value is missing, which is told the way the required fields are, e.g. with the title of the field. |
| [PropertyName](ObjectValidationFailure/PropertyName.md) { get; } | Gets the name of the property. |

## See Also

* **Source:** *[ObjectValidationFailure.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ObjectValidationFailure.cs)*