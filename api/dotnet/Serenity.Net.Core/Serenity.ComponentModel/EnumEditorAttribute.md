# EnumEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "Enum" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EnumEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [EnumEditorAttribute](EnumEditorAttribute/EnumEditorAttribute.md)() | Initializes a new instance of the [`EnumEditorAttribute`](./EnumEditorAttribute.md) class. |
| [EnumEditorAttribute](EnumEditorAttribute/EnumEditorAttribute.md)(…) | Initializes a new instance of the [`EnumEditorAttribute`](./EnumEditorAttribute.md) class for a numeric enum or a [`StringEnum`](../Serenity/StringEnum.md) type, which is needed for a property that is not typed with it, e.g. a string property that holds the values of a [`StringEnum`](../Serenity/StringEnum.md). (2 constructors) |
| [AllowClear](EnumEditorAttribute/AllowClear.md) { get; set; } | Gets or sets a value indicating whether to allow clearing. |
| [Delimited](EnumEditorAttribute/Delimited.md) { get; set; } | Use comma separated string instead of an array to serialize values. |
| [EnumKey](EnumEditorAttribute/EnumKey.md) { get; set; } | Gets or sets the key of the enum or string enumeration, which is determined from the type of the property when it is typed with one. |
| [Flags](EnumEditorAttribute/Flags.md) { get; set; } | Indicates whether the enum should be treated as a flags enum, allowing multiple selections. |
| [MinimumResultsForSearch](EnumEditorAttribute/MinimumResultsForSearch.md) { get; set; } | The minimum number of results that must be initially (after opening the dropdown for the first time) populated in order to keep the search field. This is useful for cases where local data is used with just a few results, in which case the search box is not very useful and wastes screen space. The option can be set to a negative value to permanently hide the search field. |
| [Multiple](EnumEditorAttribute/Multiple.md) { get; set; } | Allow multiple selection. Make sure your field is a List. You may also set CommaSeparated to use a string field. |
| const [Key](EnumEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[EnumEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/8f6e80f63cd4a595485dd70d71cd10519d241f14/src/core/ComponentModel/PropertyGrid/EditorTypes/EnumEditorAttribute.cs)*