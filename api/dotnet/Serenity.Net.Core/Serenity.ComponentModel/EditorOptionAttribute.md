# EditorOptionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets an editor option for target property editor. Avoid using this where possible as option keys and values are not checked.

```csharp
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public class EditorOptionAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [EditorOptionAttribute](EditorOptionAttribute/EditorOptionAttribute.md)(…) | Initializes a new instance of the [`EditorOptionAttribute`](EditorOptionAttribute.md) class. |
| [Key](EditorOptionAttribute/Key.md) { get; } | Gets the key. |
| [Value](EditorOptionAttribute/Value.md) { get; } | Gets the value. |

## See Also

* **Source:** *[EditorOptionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/Editing/EditorOptionAttribute.cs)*