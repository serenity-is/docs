# EmailEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EmailEditorAttribute : CustomEditorAttribute, ICustomValidator
```

## Public Members

| name | description |
| --- | --- |
| [EmailEditorAttribute](EmailEditorAttribute/EmailEditorAttribute.md)() | The default constructor. |
| [Domain](EmailEditorAttribute/Domain.md) { get; set; } |  |
| [ReadOnlyDomain](EmailEditorAttribute/ReadOnlyDomain.md) { get; set; } |  |
| [Validate](EmailEditorAttribute/Validate.md)(…) |  |
| static readonly [EmailPattern](EmailEditorAttribute/EmailPattern.md) |  |
| const [Key](EmailEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](../Serenity.Net.Core/CustomEditorAttribute.md)
* interface [ICustomValidator](../Serenity.Net.Data/../Serenity/ICustomValidator.md)
* **Source:** *[EmailEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/PropertyEditor/EmailEditorAttribute.cs)*