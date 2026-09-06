# ServiceLookupEditorBaseAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for service lookup based editor types.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class ServiceLookupEditorBaseAttribute : CustomEditorAttribute
```

| parameter | description |
| --- | --- |
| editorType | Type of the editor. |

## Public Members

| name | description |
| --- | --- |
| [AutoComplete](ServiceLookupEditorBaseAttribute/AutoComplete.md) { get; set; } | Allows dynamically creating new options from text input by the user in the search box. This option should only be used for free text inputs, not ID / Text pairs. When this option is enabled, InplaceAdd cannot be used. A newly created option will have the same ID / Text as the user-entered text. |
| [CascadeField](ServiceLookupEditorBaseAttribute/CascadeField.md) { get; set; } | Cascade filtering field (items will be filtered on this key, e.g. CountryID) |
| [CascadeFrom](ServiceLookupEditorBaseAttribute/CascadeFrom.md) { get; set; } | ID (can be relative) of the editor that this editor will cascade from, e.g. Country. |
| [CascadeValue](ServiceLookupEditorBaseAttribute/CascadeValue.md) { get; set; } | Cascade filtering value, usually set by the CascadeFrom editor, e.g. the integer value of CountryID. If null or empty, and CascadeField is set, all items are filtered. |
| [ColumnSelection](ServiceLookupEditorBaseAttribute/ColumnSelection.md) { get; set; } | Column selection, defaults to KeyOnly. |
| [Delimited](ServiceLookupEditorBaseAttribute/Delimited.md) { get; set; } | Use comma separated string instead of an array to serialize values. |
| [DialogType](ServiceLookupEditorBaseAttribute/DialogType.md) { get; set; } | This property is meaningful when InplaceAdd is true. By default, the dialog type name is determined by the service, e.g. if the service is "Northwind/CustomerCity/List", a dialog class named "Northwind.CustomerCityDialog" is used. If the dialog type is different than the service, set this to the class name, e.g. "MyModule.MyDialog". |
| [ExcludeColumns](ServiceLookupEditorBaseAttribute/ExcludeColumns.md) { get; set; } | Exclude columns list. |
| [FilterField](ServiceLookupEditorBaseAttribute/FilterField.md) { get; set; } | Optional filtering field (items will be filtered on this key, e.g. GroupID) |
| [FilterValue](ServiceLookupEditorBaseAttribute/FilterValue.md) { get; set; } | Optional filtering value, e.g. the integer value of GroupID. If null or empty string no filtering occurs. |
| [IdField](ServiceLookupEditorBaseAttribute/IdField.md) { get; set; } | Name of the ID field. |
| [IncludeColumns](ServiceLookupEditorBaseAttribute/IncludeColumns.md) { get; set; } | Include columns list, defaults to ID, text, and [LookupInclude] columns. |
| [IncludeDeleted](ServiceLookupEditorBaseAttribute/IncludeDeleted.md) { get; set; } | Include deleted, defaults to false. |
| [InplaceAdd](ServiceLookupEditorBaseAttribute/InplaceAdd.md) { get; set; } | Enables inplace add / edit functionality. |
| [InplaceAddPermission](ServiceLookupEditorBaseAttribute/InplaceAddPermission.md) { get; set; } | Permission required to use inplace add / edit. |
| [ItemType](ServiceLookupEditorBaseAttribute/ItemType.md) { get; set; } | Gets or sets the row type related to this service lookup editor. |
| [MinimumResultsForSearch](ServiceLookupEditorBaseAttribute/MinimumResultsForSearch.md) { get; set; } | The minimum number of results that must be initially (after opening the dropdown for the first time) populated in order to keep the search field. This is useful for cases where local data is used with just a few results, in which case the search box is not very useful and wastes screen space. The option can be set to a negative value to permanently hide the search field. |
| [Multiple](ServiceLookupEditorBaseAttribute/Multiple.md) { get; set; } | Allow multiple selection. Make sure your field is a List. You may also set CommaSeparated to use a string field. |
| [OpenDialogAsPanel](ServiceLookupEditorBaseAttribute/OpenDialogAsPanel.md) { get; set; } | Opens dialogs as a panel (default value is null, which uses the panel attribute on the dialog class). |
| [PageSize](ServiceLookupEditorBaseAttribute/PageSize.md) { get; set; } | Page size used while loading records, default 100. |
| [Service](ServiceLookupEditorBaseAttribute/Service.md) { get; set; } | List service URL, e.g. Northwind/Customer/List. It can be an absolute or relative URL to ~/Services. |
| [Sort](ServiceLookupEditorBaseAttribute/Sort.md) { get; set; } | Sort order for records, defaults to the text field. |
| [TextField](ServiceLookupEditorBaseAttribute/TextField.md) { get; set; } | Name of the text field. |

## Protected Members

| name | description |
| --- | --- |
| [ServiceLookupEditorBaseAttribute](ServiceLookupEditorBaseAttribute/ServiceLookupEditorBaseAttribute.md)(…) | Base class for service lookup based editor types. |

## Remarks

Initializes a new instance of the [`ServiceLookupEditorBaseAttribute`](./ServiceLookupEditorBaseAttribute.md) class.

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* **Source:** *[ServiceLookupEditorBaseAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/EditorTypes/ServiceLookupEditorBaseAttribute.cs)*