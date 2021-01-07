# ServiceLookupEditorBaseAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for service lookup based editor types

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class ServiceLookupEditorBaseAttribute : CustomEditorAttribute
```

## Public Members

| name | description |
| --- | --- |
| [AutoComplete](ServiceLookupEditorBaseAttribute/AutoComplete.md) { get; set; } | Allows dynamically creating new options from text input by the user in the search box. This option should only be used for free text inputs, not ID / Text pairs. When this option is enabled InplaceAdd cannot be used. Newly created option will have same ID / Text which is user entered text. |
| [CascadeField](ServiceLookupEditorBaseAttribute/CascadeField.md) { get; set; } | Cascade filtering field (items will be filtered on this key, e.g. CountryID) |
| [CascadeFrom](ServiceLookupEditorBaseAttribute/CascadeFrom.md) { get; set; } | ID (can be relative) of the editor that this editor will cascade from, e.g. Country |
| [CascadeValue](ServiceLookupEditorBaseAttribute/CascadeValue.md) { get; set; } | Cascade filtering value, usually set by CascadeFrom editor, e.g. the integer value of CountryID If null or empty, and CascadeField is set, all items are filtered |
| [ColumnSelection](ServiceLookupEditorBaseAttribute/ColumnSelection.md) { get; set; } | Column selection, defaults to KeyOnly |
| [Delimited](ServiceLookupEditorBaseAttribute/Delimited.md) { get; set; } | Use comma separated string instead of an array to serialize values. |
| [DialogType](ServiceLookupEditorBaseAttribute/DialogType.md) { get; set; } | This property is meaningfull when InplaceAdd is true. By default, dialog type name is determined by service, e.g. if service is "Northwind/CustomerCity/List", a dialog class named "Northwind.CustomerCityDialog" is used. If dialog type is different than the service, set this to classname, e.g. "MyModule.MyDialog" |
| [ExcludeColumns](ServiceLookupEditorBaseAttribute/ExcludeColumns.md) { get; set; } | Exclude columns list |
| [FilterField](ServiceLookupEditorBaseAttribute/FilterField.md) { get; set; } | Optional filtering field (items will be filtered on this key, e.g. GroupID) |
| [FilterValue](ServiceLookupEditorBaseAttribute/FilterValue.md) { get; set; } | Optional filtering value, e.g. the integer value of GroupID. If null or empty string no filtering occurs. |
| [IdField](ServiceLookupEditorBaseAttribute/IdField.md) { get; set; } | Name of the id field |
| [IncludeColumns](ServiceLookupEditorBaseAttribute/IncludeColumns.md) { get; set; } | Include columns list, defaults to id, text, and [LookupInclude] columns. |
| [IncludeDeleted](ServiceLookupEditorBaseAttribute/IncludeDeleted.md) { get; set; } | Include deleted, defaults to false |
| [InplaceAdd](ServiceLookupEditorBaseAttribute/InplaceAdd.md) { get; set; } | Enable inplace add / edit functionality |
| [InplaceAddPermission](ServiceLookupEditorBaseAttribute/InplaceAddPermission.md) { get; set; } | Permission required to use inplace add / edit |
| [ItemType](ServiceLookupEditorBaseAttribute/ItemType.md) { get; set; } | Gets/sets row type related with this service lookup editor |
| [MinimumResultsForSearch](ServiceLookupEditorBaseAttribute/MinimumResultsForSearch.md) { get; set; } | The minimum number of results that must be initially (after opening the dropdown for the first time) populated in order to keep the search field. This is useful for cases where local data is used with just a few results, in which case the search box is not very useful and wastes screen space. The option can be set to a negative value to permanently hide the search field. |
| [Multiple](ServiceLookupEditorBaseAttribute/Multiple.md) { get; set; } | Allow multiple selection. Make sure your field is a List. You may also set CommaSeparated to use a string field. |
| [OpenDialogAsPanel](ServiceLookupEditorBaseAttribute/OpenDialogAsPanel.md) { get; set; } | Open dialogs as panel (default value is null, which uses panel attribute on dialog class) |
| [PageSize](ServiceLookupEditorBaseAttribute/PageSize.md) { get; set; } | Page size used while loading records, default 100 |
| [Service](ServiceLookupEditorBaseAttribute/Service.md) { get; set; } | List service url, e.g. Northwind/Customer/List. It can be an absolute or relative URL to ~/Services |
| [Sort](ServiceLookupEditorBaseAttribute/Sort.md) { get; set; } | Sort order for records, defaults to text field |
| [TextField](ServiceLookupEditorBaseAttribute/TextField.md) { get; set; } | Name of the text field |

## Protected Members

| name | description |
| --- | --- |
| [ServiceLookupEditorBaseAttribute](ServiceLookupEditorBaseAttribute/ServiceLookupEditorBaseAttribute.md)(…) | Initializes a new instance of the [`ServiceLookupEditorBaseAttribute`](ServiceLookupEditorBaseAttribute.md) class. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* **Source:** *[ServiceLookupEditorBaseAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/ServiceLookupEditorBaseAttribute.cs)*