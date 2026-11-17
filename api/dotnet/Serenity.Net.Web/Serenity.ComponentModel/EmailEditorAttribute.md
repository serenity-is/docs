# EmailEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Email editor type with two inputs. Prefer EmailAddressEditorAttribute which uses a single input.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EmailEditorAttribute : CustomEditorAttribute, IImpliesValidation
```

## Public Members

| name | description |
| --- | --- |
| [EmailEditorAttribute](EmailEditorAttribute/EmailEditorAttribute.md)() | Initializes a new instance of the [`EmailEditorAttribute`](./EmailEditorAttribute.md) class. |
| [Domain](EmailEditorAttribute/Domain.md) { get; set; } | Gets or sets the domain. |
| [ReadOnlyDomain](EmailEditorAttribute/ReadOnlyDomain.md) { get; set; } | Gets or sets a value indicating whether the domain should be read-only. |
| [GetImpliedValidation](EmailEditorAttribute/GetImpliedValidation.md)() | Gets the rule an email editor implies, so the value is checked as an email address on the server, and by the forms, see ValidateEmailAttribute. |
| static readonly [EmailPattern](EmailEditorAttribute/EmailPattern.md) | The default email validation pattern, which is the one of ValidateEmailAttribute. |
| const [Key](EmailEditorAttribute/Key.md) | The editor type key. |

## See Also

* class [CustomEditorAttribute](../../Serenity.Net.Core/Serenity.ComponentModel/CustomEditorAttribute.md)
* interface [IImpliesValidation](../../Serenity.Net.Core/Serenity.ComponentModel/IImpliesValidation.md)
* **Source:** *[EmailEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/web/DynamicScript/PropertyEditor/EmailEditorAttribute.cs)*