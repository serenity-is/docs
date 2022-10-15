# CheckLookupEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "CheckLookup" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class CheckLookupEditorAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [CheckLookupEditorAttribute](CheckLookupEditorAttribute/CheckLookupEditorAttribute.md)(…) | Initializes a new instance of the [`CheckLookupEditorAttribute`](CheckLookupEditorAttribute.md) class. (2 constructors) |
| [CascadeField](CheckLookupEditorAttribute/CascadeField.md) { get; set; } | Cascade filtering field (items will be filtered on this key, e.g. CountryID) Make sure you have [LookupInclude] attribute on this field of lookup row, otherwise you'll have empty results as this field won't be available client side. |
| [CascadeFrom](CheckLookupEditorAttribute/CascadeFrom.md) { get; set; } | ID (can be relative) of the editor that this editor will cascade from, e.g. Country |
| [CascadeValue](CheckLookupEditorAttribute/CascadeValue.md) { get; set; } | Cascade filtering value, usually set by CascadeFrom editor, e.g. the integer value of CountryID If null or empty, and CascadeField is set, all items are filtered |
| [CheckedOnTop](CheckLookupEditorAttribute/CheckedOnTop.md) { get; set; } | Move selected items to top on load |
| [Delimited](CheckLookupEditorAttribute/Delimited.md) { get; set; } | Use comma separated string instead of an array to serialize values. |
| [FilterField](CheckLookupEditorAttribute/FilterField.md) { get; set; } | Optional filtering field (items will be filtered on this key, e.g. GroupID) Make sure you have [LookupInclude] attribute on this field of lookup row, otherwise you'll have empty results as this field won't be available client side. |
| [FilterValue](CheckLookupEditorAttribute/FilterValue.md) { get; set; } | Optional filtering value, e.g. the integer value of GroupID. If null or empty string no filtering occurs. |
| [HideSearch](CheckLookupEditorAttribute/HideSearch.md) { get; set; } | Hide quick search input |
| [LookupKey](CheckLookupEditorAttribute/LookupKey.md) { get; set; } | Lookup key, e.g. Northwind.CustomerCity |
| [ShowSelectAll](CheckLookupEditorAttribute/ShowSelectAll.md) { get; set; } | Show select all button |
| const [Key](CheckLookupEditorAttribute/Key.md) | Editor type key |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[CheckLookupEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/CheckLookupEditorAttribute.cs)*