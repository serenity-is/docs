# IntegerEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Integer" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class IntegerEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [IntegerEditorAttribute](IntegerEditorAttribute/IntegerEditorAttribute.md)() | Initializes a new instance of the [`IntegerEditorAttribute`](./IntegerEditorAttribute.md) class. |
| [AllowNegatives](IntegerEditorAttribute/AllowNegatives.md) { get; set; } | Gets or sets a value indicating whether the editor should allow negatives. |
| [MaxValue](IntegerEditorAttribute/MaxValue.md) { get; set; } | Gets or sets the maximum value. |
| [MinValue](IntegerEditorAttribute/MinValue.md) { get; set; } | Gets or sets the minimum value. |
| static [AllowNegativesByDefault](IntegerEditorAttribute/AllowNegativesByDefault.md) { get; set; } | Gets or sets a value indicating whether editors should allow negatives by default. This is a global setting that controls the default of the AllowNegatives property in this attribute. Returns the local value if any is set through [`SetLocalAllowNegativesByDefault`](./IntegerEditorAttribute/SetLocalAllowNegativesByDefault.md), otherwise the default value. The local value should be used for unit tests. |
| const [Key](IntegerEditorAttribute/Key.md) | Editor type key |
| static [SetLocalAllowNegativesByDefault](IntegerEditorAttribute/SetLocalAllowNegativesByDefault.md)(…) | Sets the local value for [`AllowNegativesByDefault`](./IntegerEditorAttribute/AllowNegativesByDefault.md) for the current thread and async context. Useful for background tasks, async methods, and testing to set the value locally without affecting other threads or tests. |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[IntegerEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/2c895c355fe09b3459b5091b6d2e792ced719b68/src/core/ComponentModel/PropertyGrid/EditorTypes/IntegerEditorAttribute.cs)*