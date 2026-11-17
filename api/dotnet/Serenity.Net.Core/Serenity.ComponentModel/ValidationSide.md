# ValidationSide enumeration
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Where a validation rule is checked, see [`Side`](./IClientValidationRule/Side.md).

```csharp
public enum ValidationSide
```

## Values

| name | value | description |
| --- | --- | --- |
| Both | `0` | By the forms and on the server, which is the default. |
| Client | `1` | Only by the forms, e.g. a hint for the user that the server doesn't need to enforce. |
| Server | `2` | Only on the server, e.g. a rule that needs the database. |

## See Also

* **Source:** *[ValidationSide.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidationSide.cs)*