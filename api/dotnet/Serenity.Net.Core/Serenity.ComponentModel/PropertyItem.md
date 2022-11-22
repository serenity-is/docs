# PropertyItem class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Corresponds to a property item (e.g. a field in property grid with a label and editor, or a column specification in a grid)

```csharp
public class PropertyItem
```

## Public Members

| name | description |
| --- | --- |
| [PropertyItem](PropertyItem/PropertyItem.md)() | Initializes a new instance of the [`PropertyItem`](PropertyItem.md) class. |
| [Alignment](PropertyItem/Alignment.md) { get; set; } | Gets or sets the alignment of the column. Only applies to column, not editors. |
| [AllowHide](PropertyItem/AllowHide.md) { get; set; } | Gets or sets the allow hide flag for columns. |
| [Category](PropertyItem/Category.md) { get; set; } | Gets or sets the category of the property in form. Only meaningful for forms. |
| [Collapsed](PropertyItem/Collapsed.md) { get; set; } | Gets or sets the initial collapsed status of the category this property is in. |
| [Collapsible](PropertyItem/Collapsible.md) { get; set; } | Gets or sets the collapsible flag for the category this property is in. Should only be set for the first field in the category. |
| [CssClass](PropertyItem/CssClass.md) { get; set; } | Gets or sets the CSS class that should be applied to the grid column, e.g. data cells for this property. Only used in grids. |
| [DefaultValue](PropertyItem/DefaultValue.md) { get; set; } | Gets or sets the default value of the property in new record forms. |
| [DisplayFormat](PropertyItem/DisplayFormat.md) { get; set; } | Gets or sets the display format to be passed to the formatter of a column. Note that display format has no effect on editors. |
| [EditLink](PropertyItem/EditLink.md) { get; set; } | Gets or sets the edit link flag. Determines if column should have a edit link to open related dialog. |
| [EditLinkCssClass](PropertyItem/EditLinkCssClass.md) { get; set; } | Gets or sets the edit link CSS class. |
| [EditLinkIdField](PropertyItem/EditLinkIdField.md) { get; set; } | Gets or sets the edit link identifier (e.g. ID) field. If edit link is in CompanyName field, EditLinkId field might be CompanyId. |
| [EditLinkItemType](PropertyItem/EditLinkItemType.md) { get; set; } | Gets or sets the type of the edit link item type if it is different than the item type of the grid. |
| [EditorParams](PropertyItem/EditorParams.md) { get; set; } | Gets or sets the editor parameters that should be passed to the editor while it is being created. |
| [EditorType](PropertyItem/EditorType.md) { get; set; } | Gets or sets the type of the editor used in form. |
| [ExtensionData](PropertyItem/ExtensionData.md) { get; set; } | Gets or sets the extension data, used for JSON.NET serialization / deserialization of dynamic properties. |
| [FilteringIdField](PropertyItem/FilteringIdField.md) { get; set; } | Gets or sets the filtering identifier field. If the column is CompanyName, its FilteringIdField might be CompanyId. |
| [FilteringParams](PropertyItem/FilteringParams.md) { get; set; } | Gets or sets the filtering parameters. |
| [FilteringType](PropertyItem/FilteringType.md) { get; set; } | Gets or sets the type of the filtering for the column. |
| [FilterOnly](PropertyItem/FilterOnly.md) { get; set; } | Gets or sets the filter only flag, e.g. this property should not be used for forms/grids, it is here only to set filtering options. |
| [FormatterParams](PropertyItem/FormatterParams.md) { get; set; } | Gets or sets the formatter parameters for columns. |
| [FormatterType](PropertyItem/FormatterType.md) { get; set; } | Gets or sets the type of the formatter for columns. |
| [FormCssClass](PropertyItem/FormCssClass.md) { get; set; } | Gets or sets the form CSS class for the property. This class is applied to containing "div.field" not the editor. Only used in forms. |
| [GroupOrder](PropertyItem/GroupOrder.md) { get; set; } | Gets or sets the grouping order of a column, e.g. in which position this column is grouped by default in the grid. Only applies to grids, not forms. |
| [HeaderCssClass](PropertyItem/HeaderCssClass.md) { get; set; } | Gets or sets the header CSS class for the grid column. Only used in grids. |
| [HideOnInsert](PropertyItem/HideOnInsert.md) { get; set; } | Gets or sets the hide on insert flag which controls visibility of the property in new record forms. |
| [HideOnUpdate](PropertyItem/HideOnUpdate.md) { get; set; } | Gets or sets the hide on update flag which controls visibility of the property in edit record forms. |
| [Hint](PropertyItem/Hint.md) { get; set; } | Gets or sets the hint. This is only used for forms and it is shown when the label is hovered. |
| [Insertable](PropertyItem/Insertable.md) { get; set; } | Gets or sets the insertable flag of the property. If this is false, the property won't be serialized back in new record forms. Does not apply to grids. |
| [InsertPermission](PropertyItem/InsertPermission.md) { get; set; } | Gets or sets the insert permission. If user doesn't have this permission, field won't be serialized back in new record forms and it will be readonly. |
| [LabelWidth](PropertyItem/LabelWidth.md) { get; set; } | Gets or sets the width of the label in forms. |
| [Localizable](PropertyItem/Localizable.md) { get; set; } | Gets or sets the localizable flag of the property. Only fields with this flag are shown in localization tab of entity dialog. |
| [MaxLength](PropertyItem/MaxLength.md) { get; set; } | Gets or sets the maximum length of the editor in a form. |
| [MaxWidth](PropertyItem/MaxWidth.md) { get; set; } | Gets or sets the maximum width of a column. |
| [MinWidth](PropertyItem/MinWidth.md) { get; set; } | Gets or sets the minimum width of a column. |
| [Name](PropertyItem/Name.md) { get; set; } | Gets or sets the property name. |
| [NotFilterable](PropertyItem/NotFilterable.md) { get; set; } | Gets or sets the not filterable that disables filtering by the property in advanced filter dialog. |
| [OneWay](PropertyItem/OneWay.md) { get; set; } | Gets or sets the one way flag, which when true field won't be serialized back to entity on save. |
| [Placeholder](PropertyItem/Placeholder.md) { get; set; } | Gets or sets the placeholder for the editor when it has an empty value. Only useful for forms. |
| [QuickFilter](PropertyItem/QuickFilter.md) { get; set; } | Gets or sets the quick filter flag. Only used for columns. |
| [QuickFilterCssClass](PropertyItem/QuickFilterCssClass.md) { get; set; } | Gets or sets the quick filter CSS class. |
| [QuickFilterParams](PropertyItem/QuickFilterParams.md) { get; set; } | Gets or sets the quick filter parameters. |
| [QuickFilterSeparator](PropertyItem/QuickFilterSeparator.md) { get; set; } | Gets or sets the quick filter separator flag. |
| [ReadOnly](PropertyItem/ReadOnly.md) { get; set; } | Gets or sets the read only flag of the property in forms. |
| [ReadPermission](PropertyItem/ReadPermission.md) { get; set; } | Gets or sets the read permission. If user doesn't have this permission, they won't see it in grid / form. |
| [Required](PropertyItem/Required.md) { get; set; } | Gets or sets the required flag of the property in forms. |
| [Resizable](PropertyItem/Resizable.md) { get; set; } | Gets or sets the resizable flag of a column. |
| [Sortable](PropertyItem/Sortable.md) { get; set; } | Gets or sets the sortable flag of a column. |
| [SortOrder](PropertyItem/SortOrder.md) { get; set; } | Gets or sets the sort order of a column, e.g. in which position this column is sorted by default in the grid. Only applies to grids, not forms. |
| [SummaryType](PropertyItem/SummaryType.md) { get; set; } | Gets or sets the type of the summary. Only applies to grids. |
| [Tab](PropertyItem/Tab.md) { get; set; } | Gets or sets the tab for the property. Used only in forms. |
| [Title](PropertyItem/Title.md) { get; set; } | Gets or sets the title, e.g. label of a form field, or caption of a grid column. |
| [Updatable](PropertyItem/Updatable.md) { get; set; } | Gets or sets the updatable flag of the property. If it is false, property won't be serialized back in edit forms and it will be readonly. |
| [UpdatePermission](PropertyItem/UpdatePermission.md) { get; set; } | Gets or sets the update permission. If user doesn't have this permission, field won't be serialized back in edit record forms and it will be readonly. |
| [Visible](PropertyItem/Visible.md) { get; set; } | Gets or sets the visible flag. Only used for columns. |
| [Width](PropertyItem/Width.md) { get; set; } | Gets or sets the width of the column. Does not apply to forms. |
| [WidthSet](PropertyItem/WidthSet.md) { get; set; } | Gets or sets the width explicitly set flag. If property has a [Width] attribute this property is true. If property column width is automatically calculated by Serenity based on field metadata, it is false. |
| [ShouldSerializeEditorParams](PropertyItem/ShouldSerializeEditorParams.md)() | Should the EditorParams property be serialized by JSON.NET, used to reduce JSON size. |
| [ShouldSerializeEditorType](PropertyItem/ShouldSerializeEditorType.md)() | Should the EditorType property be serialized by JSON.NET, used to reduce JSON size. |
| [ShouldSerializeFilteringParams](PropertyItem/ShouldSerializeFilteringParams.md)() | Should the FilteringParams property be serialized by JSON.NET, used to reduce JSON size. |
| [ShouldSerializeFilteringType](PropertyItem/ShouldSerializeFilteringType.md)() | Should the FilteringType property be serialized by JSON.NET, used to reduce JSON size. |
| [ShouldSerializeFormatterParams](PropertyItem/ShouldSerializeFormatterParams.md)() | Should the FormatterParams property be serialized by JSON.NET, used to reduce JSON size. |
| [ShouldSerializeQuickFilterParams](PropertyItem/ShouldSerializeQuickFilterParams.md)() | Should the QuickFilterParams property be serialized by JSON.NET, used to reduce JSON size. |

## See Also

* **Source:** *[PropertyItem.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/PropertyItem.cs)*