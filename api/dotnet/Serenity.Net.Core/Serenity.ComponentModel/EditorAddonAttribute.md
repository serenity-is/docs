# EditorAddonAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds an editor addon to the target property.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class EditorAddonAttribute : Attribute
```

| parameter | description |
| --- | --- |
| type | The type. |

## Public Members

| name | description |
| --- | --- |
| [EditorAddonAttribute](EditorAddonAttribute/EditorAddonAttribute.md)(…) | Adds an editor addon to the target property. |
| [AddonKey](EditorAddonAttribute/AddonKey.md) { get; set; } | Gets or sets the addon key which is set as data-addonkey attribute. |
| [AddonType](EditorAddonAttribute/AddonType.md) { get; } | Gets the type of the editor. |
| virtual [IsLocalizableOption](EditorAddonAttribute/IsLocalizableOption.md)(…) | Gets if the specified option key is localizable. |
| virtual [SetParams](EditorAddonAttribute/SetParams.md)(…) | Sets the parameters for each pair in the editorParams dictionary. |

## Protected Members

| name | description |
| --- | --- |
| [GetOption&lt;TType&gt;](EditorAddonAttribute/GetOption.md)(…) | Gets the editor option. |
| [SetOption](EditorAddonAttribute/SetOption.md)(…) | Sets the editor option. |

## Remarks

Initializes a new instance of the [`EditorAddonAttribute`](EditorAddonAttribute.md) class.

## See Also

* **Source:** *[EditorAddonAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/EditorAddons/EditorAddonAttribute.cs)*