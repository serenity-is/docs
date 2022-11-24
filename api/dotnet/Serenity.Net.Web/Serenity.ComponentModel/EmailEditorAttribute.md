# EmailEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Email editor type with two inputs. Please prefer EmailAddressEditorAttribute which uses a single input.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EmailEditorAttribute : CustomEditorAttribute, ICustomValidator
```

## Public Members

| name | description |
| --- | --- |
| [EmailEditorAttribute](EmailEditorAttribute/EmailEditorAttribute.md)() | Creates a new instance of the email editor |
| [Domain](EmailEditorAttribute/Domain.md) { get; set; } | Domain |
| [ReadOnlyDomain](EmailEditorAttribute/ReadOnlyDomain.md) { get; set; } | True if the domain should be readonly |
| [Validate](EmailEditorAttribute/Validate.md)(…) | Validates the email address |
| static readonly [EmailPattern](EmailEditorAttribute/EmailPattern.md) | Default email validation pattern |
| const [Key](EmailEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](../Serenity.Net.Core/CustomEditorAttribute.md)
* interface [ICustomValidator](../Serenity.Net.Data/../Serenity/ICustomValidator.md)
* **Source:** *[EmailEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/PropertyEditor/EmailEditorAttribute.cs)*