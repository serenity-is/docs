# EditorOptionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets an editor option for target property editor. Avoid using this where possible as option keys and values are not checked.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public class EditorOptionAttribute : Attribute
```

| parameter | description |
| --- | --- |
| key | The key. |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [EditorOptionAttribute](EditorOptionAttribute/EditorOptionAttribute.md)(…) | Sets an editor option for target property editor. Avoid using this where possible as option keys and values are not checked. |
| [Key](EditorOptionAttribute/Key.md) { get; } | Gets the key. |
| [Value](EditorOptionAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`EditorOptionAttribute`](EditorOptionAttribute.md) class.

## See Also

* **Source:** *[EditorOptionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/Editing/EditorOptionAttribute.cs)*