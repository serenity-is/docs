# LookupEditorBaseAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for lookup based editor types

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class LookupEditorBaseAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [Async](LookupEditorBaseAttribute/Async.md) { get; set; } | Load lookup in async mode, default false |
| [AutoComplete](LookupEditorBaseAttribute/AutoComplete.md) { get; set; } | Allows dynamically creating new options from text input by the user in the search box. This option should only be used for free text inputs, not ID / Text pairs. When this option is enabled InplaceAdd cannot be used. Newly created option will have same ID / Text which is user entered text. |
| [CascadeField](LookupEditorBaseAttribute/CascadeField.md) { get; set; } | Cascade filtering field (items will be filtered on this key, e.g. CountryID) Make sure you have [LookupInclude] attribute on this field of lookup row, otherwise you'll have empty results as this field won't be available client side. |
| [CascadeFrom](LookupEditorBaseAttribute/CascadeFrom.md) { get; set; } | ID (can be relative) of the editor that this editor will cascade from, e.g. Country |
| [CascadeValue](LookupEditorBaseAttribute/CascadeValue.md) { get; set; } | Cascade filtering value, usually set by CascadeFrom editor, e.g. the integer value of CountryID If null or empty, and CascadeField is set, all items are filtered |
| [Delimited](LookupEditorBaseAttribute/Delimited.md) { get; set; } | Use comma separated string instead of an array to serialize values. |
| [DialogType](LookupEditorBaseAttribute/DialogType.md) { get; set; } | This property is meaningful when InplaceAdd is true. By default, dialog type name is determined by LookupKey, e.g. if lookup key is "Northwind.CustomerCity", a dialog class named "Northwind.CustomerCityDialog" is used. If dialog type is different than lookup key, set this to classname, e.g. "MyModule.MyDialog" |
| [FilterField](LookupEditorBaseAttribute/FilterField.md) { get; set; } | Optional filtering field (items will be filtered on this key, e.g. GroupID) Make sure you have [LookupInclude] attribute on this field of lookup row, otherwise you'll have empty results as this field won't be available client side. |
| [FilterValue](LookupEditorBaseAttribute/FilterValue.md) { get; set; } | Optional filtering value, e.g. the integer value of GroupID. If null or empty string no filtering occurs. |
| [InplaceAdd](LookupEditorBaseAttribute/InplaceAdd.md) { get; set; } | Enable inplace add / edit functionality |
| [InplaceAddPermission](LookupEditorBaseAttribute/InplaceAddPermission.md) { get; set; } | Permission required to use inplace add / edit |
| [LookupKey](LookupEditorBaseAttribute/LookupKey.md) { get; set; } | Lookup key, e.g. Northwind.CustomerCity |
| [MinimumResultsForSearch](LookupEditorBaseAttribute/MinimumResultsForSearch.md) { get; set; } | The minimum number of results that must be initially (after opening the dropdown for the first time) populated in order to keep the search field. This is useful for cases where local data is used with just a few results, in which case the search box is not very useful and wastes screen space. The option can be set to a negative value to permanently hide the search field. |
| [Multiple](LookupEditorBaseAttribute/Multiple.md) { get; set; } | Allow multiple selection. Make sure your field is a List. You may also set CommaSeparated to use a string field. |
| [OpenDialogAsPanel](LookupEditorBaseAttribute/OpenDialogAsPanel.md) { get; set; } | Open dialogs as panel (default value is null, which uses panel attribute on dialog class) |

## Protected Members

| name | description |
| --- | --- |
| [LookupEditorBaseAttribute](LookupEditorBaseAttribute/LookupEditorBaseAttribute.md)(…) | Initializes a new instance of the [`LookupEditorBaseAttribute`](LookupEditorBaseAttribute.md) class. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[LookupEditorBaseAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/LookupEditorBaseAttribute.cs)*