# EmailEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Email editor type with two inputs. Prefer EmailAddressEditorAttribute which uses a single input.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EmailEditorAttribute : CustomEditorAttribute, ICustomValidator
```

## Public Members

| name | description |
| --- | --- |
| [EmailEditorAttribute](EmailEditorAttribute/EmailEditorAttribute.md)() | Initializes a new instance of the [`EmailEditorAttribute`](EmailEditorAttribute.md) class. |
| [Domain](EmailEditorAttribute/Domain.md) { get; set; } | Gets or sets the domain. |
| [ReadOnlyDomain](EmailEditorAttribute/ReadOnlyDomain.md) { get; set; } | Gets or sets a value indicating whether the domain should be read-only. |
| [Validate](EmailEditorAttribute/Validate.md)(…) | Validates the email address. |
| static readonly [EmailPattern](EmailEditorAttribute/EmailPattern.md) | The default email validation pattern. |
| const [Key](EmailEditorAttribute/Key.md) | The editor type key. |

## See Also

* class [CustomEditorAttribute](../Serenity.Net.Core/CustomEditorAttribute.md)
* interface [ICustomValidator](../Serenity.Net.Services/../Serenity/ICustomValidator.md)
* **Source:** *[EmailEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/PropertyEditor/EmailEditorAttribute.cs)*