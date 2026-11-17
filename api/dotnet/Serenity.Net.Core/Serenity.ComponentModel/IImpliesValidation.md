# IImpliesValidation interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An attribute, e.g. of an editor, that implies validation rules for the property it is on, like an email editor that implies [`ValidateEmailAttribute`](./ValidateEmailAttribute.md). They are checked on the server and by the forms as if they were on the property, see [`GetRules`](./ValidationRules/GetRules.md).

```csharp
public interface IImpliesValidation
```

## Members

| name | description |
| --- | --- |
| [GetImpliedValidation](IImpliesValidation/GetImpliedValidation.md)() | Gets the rules the attribute implies. |

## See Also

* **Source:** *[IImpliesValidation.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/IImpliesValidation.cs)*