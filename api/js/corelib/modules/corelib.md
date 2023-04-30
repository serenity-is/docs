[@serenity-is](../README.md) / [Modules](../modules.md) / corelib

# Module: corelib

This is the main entry point for `@serenity-is/corelib` package.

The types from this module are available by importing from "@serenity-is/corelib":

```ts
import { EntityGrid } from "serenity-is/corelib"

export class MyGrid extends EntityGrid<MyRow, any> {
}
```
  
> When using classic namespaces instead of the ESM modules, the types and functions in this module are directly available from the global `Serenity` namespace.
> e.g. `Serenity.EntityGrid`

## Table of contents

### References

- [ColumnSelection](corelib.md#columnselection)
- [Criteria](corelib.md#criteria)
- [DeleteRequest](corelib.md#deleterequest)
- [DeleteResponse](corelib.md#deleteresponse)
- [Formatter](corelib.md#formatter)
- [ISlickFormatter](corelib.md#islickformatter)
- [ListRequest](corelib.md#listrequest)
- [ListResponse](corelib.md#listresponse)
- [PropertyItem](corelib.md#propertyitem)
- [PropertyItemsData](corelib.md#propertyitemsdata)
- [RetrieveColumnSelection](corelib.md#retrievecolumnselection)
- [RetrieveLocalizationRequest](corelib.md#retrievelocalizationrequest)
- [RetrieveLocalizationResponse](corelib.md#retrievelocalizationresponse)
- [RetrieveRequest](corelib.md#retrieverequest)
- [RetrieveResponse](corelib.md#retrieveresponse)
- [SaveRequest](corelib.md#saverequest)
- [SaveRequestWithAttachment](corelib.md#saverequestwithattachment)
- [SaveResponse](corelib.md#saveresponse)
- [SaveWithLocalizationRequest](corelib.md#savewithlocalizationrequest)
- [ServiceError](corelib.md#serviceerror)
- [ServiceOptions](corelib.md#serviceoptions)
- [ServiceRequest](corelib.md#servicerequest)
- [ServiceResponse](corelib.md#serviceresponse)
- [SummaryType](corelib.md#summarytype)
- [UndeleteRequest](corelib.md#undeleterequest)
- [UndeleteResponse](corelib.md#undeleteresponse)

### Namespaces

- [Decorators](corelib.Decorators.md)
- [DialogExtensions](corelib.DialogExtensions.md)
- [DialogTypeRegistry](corelib.DialogTypeRegistry.md)
- [EditorTypeRegistry](corelib.EditorTypeRegistry.md)
- [EditorUtils](corelib.EditorUtils.md)
- [EnumTypeRegistry](corelib.EnumTypeRegistry.md)
- [FilterOperators](corelib.FilterOperators.md)
- [FilteringTypeRegistry](corelib.FilteringTypeRegistry.md)
- [FormatterTypeRegistry](corelib.FormatterTypeRegistry.md)
- [GridSelectAllButtonHelper](corelib.GridSelectAllButtonHelper.md)
- [GridUtils](corelib.GridUtils.md)
- [LazyLoadHelper](corelib.LazyLoadHelper.md)
- [PropertyItemSlickConverter](corelib.PropertyItemSlickConverter.md)
- [ReflectionOptionsSetter](corelib.ReflectionOptionsSetter.md)
- [ReflectionUtils](corelib.ReflectionUtils.md)
- [Reporting](corelib.Reporting.md)
- [SlickFormatting](corelib.SlickFormatting.md)
- [SlickHelper](corelib.SlickHelper.md)
- [SlickTreeHelper](corelib.SlickTreeHelper.md)
- [SubDialogHelper](corelib.SubDialogHelper.md)
- [TabsExtensions](corelib.TabsExtensions.md)
- [UploadHelper](corelib.UploadHelper.md)
- [VX](corelib.VX.md)
- [ValidationHelper](corelib.ValidationHelper.md)
- [WX](corelib.WX.md)

### Enumerations

- [CaptureOperationType](../enums/corelib.CaptureOperationType.md)
- [PropertyGridMode](../enums/corelib.PropertyGridMode.md)

### Classes

- [BaseEditorFiltering](../classes/corelib.BaseEditorFiltering.md)
- [BaseFiltering](../classes/corelib.BaseFiltering.md)
- [BooleanEditor](../classes/corelib.BooleanEditor.md)
- [BooleanFiltering](../classes/corelib.BooleanFiltering.md)
- [BooleanFormatter](../classes/corelib.BooleanFormatter.md)
- [CascadedWidgetLink](../classes/corelib.CascadedWidgetLink.md)
- [CategoryAttribute](../classes/corelib.CategoryAttribute.md)
- [CheckLookupEditor](../classes/corelib.CheckLookupEditor.md)
- [CheckTreeEditor](../classes/corelib.CheckTreeEditor.md)
- [CheckboxFormatter](../classes/corelib.CheckboxFormatter.md)
- [ColumnPickerDialog](../classes/corelib.ColumnPickerDialog.md)
- [ColumnsKeyAttribute](../classes/corelib.ColumnsKeyAttribute.md)
- [CssClassAttribute](../classes/corelib.CssClassAttribute.md)
- [DataGrid](../classes/corelib.DataGrid.md)
- [DateEditor](../classes/corelib.DateEditor.md)
- [DateFiltering](../classes/corelib.DateFiltering.md)
- [DateFormatter](../classes/corelib.DateFormatter.md)
- [DateTimeEditor](../classes/corelib.DateTimeEditor.md)
- [DateTimeFiltering](../classes/corelib.DateTimeFiltering.md)
- [DateTimeFormatter](../classes/corelib.DateTimeFormatter.md)
- [DateYearEditor](../classes/corelib.DateYearEditor.md)
- [DecimalEditor](../classes/corelib.DecimalEditor.md)
- [DecimalFiltering](../classes/corelib.DecimalFiltering.md)
- [DefaultValueAttribute](../classes/corelib.DefaultValueAttribute.md)
- [DialogTypeAttribute](../classes/corelib.DialogTypeAttribute.md)
- [DisplayNameAttribute](../classes/corelib.DisplayNameAttribute.md)
- [EditorFiltering](../classes/corelib.EditorFiltering.md)
- [EditorOptionAttribute](../classes/corelib.EditorOptionAttribute.md)
- [EditorTypeAttribute](../classes/corelib.EditorTypeAttribute.md)
- [EditorTypeAttributeBase](../classes/corelib.EditorTypeAttributeBase.md)
- [ElementAttribute](../classes/corelib.ElementAttribute.md)
- [EmailAddressEditor](../classes/corelib.EmailAddressEditor.md)
- [EmailEditor](../classes/corelib.EmailEditor.md)
- [EntityDialog](../classes/corelib.EntityDialog.md)
- [EntityGrid](../classes/corelib.EntityGrid.md)
- [EntityTypeAttribute](../classes/corelib.EntityTypeAttribute.md)
- [EnumEditor](../classes/corelib.EnumEditor.md)
- [EnumFiltering](../classes/corelib.EnumFiltering.md)
- [EnumFormatter](../classes/corelib.EnumFormatter.md)
- [EnumKeyAttribute](../classes/corelib.EnumKeyAttribute.md)
- [FileDownloadFormatter](../classes/corelib.FileDownloadFormatter.md)
- [FileUploadEditor](../classes/corelib.FileUploadEditor.md)
- [FilterDialog](../classes/corelib.FilterDialog.md)
- [FilterDisplayBar](../classes/corelib.FilterDisplayBar.md)
- [FilterPanel](../classes/corelib.FilterPanel.md)
- [FilterStore](../classes/corelib.FilterStore.md)
- [FilterWidgetBase](../classes/corelib.FilterWidgetBase.md)
- [FilterableAttribute](../classes/corelib.FilterableAttribute.md)
- [Flexify](../classes/corelib.Flexify.md)
- [FlexifyAttribute](../classes/corelib.FlexifyAttribute.md)
- [FormKeyAttribute](../classes/corelib.FormKeyAttribute.md)
- [GeneratedCodeAttribute](../classes/corelib.GeneratedCodeAttribute.md)
- [GoogleMap](../classes/corelib.GoogleMap.md)
- [GridRadioSelectionMixin](../classes/corelib.GridRadioSelectionMixin.md)
- [GridRowSelectionMixin](../classes/corelib.GridRowSelectionMixin.md)
- [HiddenAttribute](../classes/corelib.HiddenAttribute.md)
- [HintAttribute](../classes/corelib.HintAttribute.md)
- [HtmlContentEditor](../classes/corelib.HtmlContentEditor.md)
- [HtmlNoteContentEditor](../classes/corelib.HtmlNoteContentEditor.md)
- [HtmlReportContentEditor](../classes/corelib.HtmlReportContentEditor.md)
- [IAsyncInit](../classes/corelib.IAsyncInit.md)
- [IBooleanValue](../classes/corelib.IBooleanValue.md)
- [IDialog](../classes/corelib.IDialog.md)
- [IDoubleValue](../classes/corelib.IDoubleValue.md)
- [IEditDialog](../classes/corelib.IEditDialog.md)
- [IFiltering](../classes/corelib.IFiltering.md)
- [IGetEditValue](../classes/corelib.IGetEditValue.md)
- [IInitializeColumn](../classes/corelib.IInitializeColumn.md)
- [IQuickFiltering](../classes/corelib.IQuickFiltering.md)
- [IReadOnly](../classes/corelib.IReadOnly.md)
- [ISetEditValue](../classes/corelib.ISetEditValue.md)
- [IStringValue](../classes/corelib.IStringValue.md)
- [IValidateRequired](../classes/corelib.IValidateRequired.md)
- [IdPropertyAttribute](../classes/corelib.IdPropertyAttribute.md)
- [ImageUploadEditor](../classes/corelib.ImageUploadEditor.md)
- [InsertableAttribute](../classes/corelib.InsertableAttribute.md)
- [IntegerEditor](../classes/corelib.IntegerEditor.md)
- [IntegerFiltering](../classes/corelib.IntegerFiltering.md)
- [IsActivePropertyAttribute](../classes/corelib.IsActivePropertyAttribute.md)
- [ItemNameAttribute](../classes/corelib.ItemNameAttribute.md)
- [LocalTextPrefixAttribute](../classes/corelib.LocalTextPrefixAttribute.md)
- [LookupEditor](../classes/corelib.LookupEditor.md)
- [LookupEditorBase](../classes/corelib.LookupEditorBase.md)
- [LookupFiltering](../classes/corelib.LookupFiltering.md)
- [MaskedEditor](../classes/corelib.MaskedEditor.md)
- [MaxLengthAttribute](../classes/corelib.MaxLengthAttribute.md)
- [MaximizableAttribute](../classes/corelib.MaximizableAttribute.md)
- [MinuteFormatter](../classes/corelib.MinuteFormatter.md)
- [MultipleFileUploadEditor](../classes/corelib.MultipleFileUploadEditor.md)
- [MultipleImageUploadEditor](../classes/corelib.MultipleImageUploadEditor.md)
- [NamePropertyAttribute](../classes/corelib.NamePropertyAttribute.md)
- [NumberFormatter](../classes/corelib.NumberFormatter.md)
- [OneWayAttribute](../classes/corelib.OneWayAttribute.md)
- [OptionAttribute](../classes/corelib.OptionAttribute.md)
- [OptionsTypeAttribute](../classes/corelib.OptionsTypeAttribute.md)
- [PanelAttribute](../classes/corelib.PanelAttribute.md)
- [PasswordEditor](../classes/corelib.PasswordEditor.md)
- [PlaceholderAttribute](../classes/corelib.PlaceholderAttribute.md)
- [PopupMenuButton](../classes/corelib.PopupMenuButton.md)
- [PopupToolButton](../classes/corelib.PopupToolButton.md)
- [PrefixedContext](../classes/corelib.PrefixedContext.md)
- [PropertyDialog](../classes/corelib.PropertyDialog.md)
- [PropertyGrid](../classes/corelib.PropertyGrid.md)
- [PropertyPanel](../classes/corelib.PropertyPanel.md)
- [QuickFilterBar](../classes/corelib.QuickFilterBar.md)
- [QuickSearchInput](../classes/corelib.QuickSearchInput.md)
- [RadioButtonEditor](../classes/corelib.RadioButtonEditor.md)
- [ReadOnlyAttribute](../classes/corelib.ReadOnlyAttribute.md)
- [Recaptcha](../classes/corelib.Recaptcha.md)
- [RequiredAttribute](../classes/corelib.RequiredAttribute.md)
- [ResizableAttribute](../classes/corelib.ResizableAttribute.md)
- [ResponsiveAttribute](../classes/corelib.ResponsiveAttribute.md)
- [ScriptContext](../classes/corelib.ScriptContext.md)
- [Select2AjaxEditor](../classes/corelib.Select2AjaxEditor.md)
- [Select2Editor](../classes/corelib.Select2Editor.md)
- [SelectEditor](../classes/corelib.SelectEditor.md)
- [ServiceAttribute](../classes/corelib.ServiceAttribute.md)
- [ServiceLookupEditor](../classes/corelib.ServiceLookupEditor.md)
- [ServiceLookupEditorBase](../classes/corelib.ServiceLookupEditorBase.md)
- [ServiceLookupFiltering](../classes/corelib.ServiceLookupFiltering.md)
- [SlickPager](../classes/corelib.SlickPager.md)
- [StringEditor](../classes/corelib.StringEditor.md)
- [StringFiltering](../classes/corelib.StringFiltering.md)
- [TemplatedDialog](../classes/corelib.TemplatedDialog.md)
- [TemplatedPanel](../classes/corelib.TemplatedPanel.md)
- [TemplatedWidget](../classes/corelib.TemplatedWidget.md)
- [TextAreaEditor](../classes/corelib.TextAreaEditor.md)
- [TimeEditor](../classes/corelib.TimeEditor.md)
- [Toolbar](../classes/corelib.Toolbar.md)
- [TreeGridMixin](../classes/corelib.TreeGridMixin.md)
- [URLEditor](../classes/corelib.URLEditor.md)
- [UpdatableAttribute](../classes/corelib.UpdatableAttribute.md)
- [UrlFormatter](../classes/corelib.UrlFormatter.md)
- [Widget](../classes/corelib.Widget.md)

### Interfaces

- [CKEditorConfig](../interfaces/corelib.CKEditorConfig.md)
- [CheckLookupEditorOptions](../interfaces/corelib.CheckLookupEditorOptions.md)
- [CheckTreeItem](../interfaces/corelib.CheckTreeItem.md)
- [CreateWidgetParams](../interfaces/corelib.CreateWidgetParams.md)
- [CriteriaWithText](../interfaces/corelib.CriteriaWithText.md)
- [DataChangeInfo](../interfaces/corelib.DataChangeInfo.md)
- [DateTimeEditorOptions](../interfaces/corelib.DateTimeEditorOptions.md)
- [DateYearEditorOptions](../interfaces/corelib.DateYearEditorOptions.md)
- [DecimalEditorOptions](../interfaces/corelib.DecimalEditorOptions.md)
- [EmailEditorOptions](../interfaces/corelib.EmailEditorOptions.md)
- [EnumEditorOptions](../interfaces/corelib.EnumEditorOptions.md)
- [FileUploadConstraints](../interfaces/corelib.FileUploadConstraints.md)
- [FileUploadEditorOptions](../interfaces/corelib.FileUploadEditorOptions.md)
- [FilterLine](../interfaces/corelib.FilterLine.md)
- [FilterOperator](../interfaces/corelib.FilterOperator.md)
- [FlexifyOptions](../interfaces/corelib.FlexifyOptions.md)
- [GoogleMapOptions](../interfaces/corelib.GoogleMapOptions.md)
- [GridPersistanceFlags](../interfaces/corelib.GridPersistanceFlags.md)
- [GridRadioSelectionMixinOptions](../interfaces/corelib.GridRadioSelectionMixinOptions.md)
- [GridRowSelectionMixinOptions](../interfaces/corelib.GridRowSelectionMixinOptions.md)
- [HtmlContentEditorOptions](../interfaces/corelib.HtmlContentEditorOptions.md)
- [IDataGrid](../interfaces/corelib.IDataGrid.md)
- [IRowDefinition](../interfaces/corelib.IRowDefinition.md)
- [ImageUploadEditorOptions](../interfaces/corelib.ImageUploadEditorOptions.md)
- [IntegerEditorOptions](../interfaces/corelib.IntegerEditorOptions.md)
- [LookupEditorOptions](../interfaces/corelib.LookupEditorOptions.md)
- [MaskedEditorOptions](../interfaces/corelib.MaskedEditorOptions.md)
- [ModalOptions](../interfaces/corelib.ModalOptions.md)
- [PersistedGridColumn](../interfaces/corelib.PersistedGridColumn.md)
- [PersistedGridSettings](../interfaces/corelib.PersistedGridSettings.md)
- [PopupMenuButtonOptions](../interfaces/corelib.PopupMenuButtonOptions.md)
- [PopupToolButtonOptions](../interfaces/corelib.PopupToolButtonOptions.md)
- [PropertyGridOptions](../interfaces/corelib.PropertyGridOptions.md)
- [QuickFilter](../interfaces/corelib.QuickFilter.md)
- [QuickFilterArgs](../interfaces/corelib.QuickFilterArgs.md)
- [QuickFilterBarOptions](../interfaces/corelib.QuickFilterBarOptions.md)
- [QuickSearchField](../interfaces/corelib.QuickSearchField.md)
- [QuickSearchInputOptions](../interfaces/corelib.QuickSearchInputOptions.md)
- [RadioButtonEditorOptions](../interfaces/corelib.RadioButtonEditorOptions.md)
- [RecaptchaOptions](../interfaces/corelib.RecaptchaOptions.md)
- [Select2CommonOptions](../interfaces/corelib.Select2CommonOptions.md)
- [Select2EditorOptions](../interfaces/corelib.Select2EditorOptions.md)
- [Select2FilterOptions](../interfaces/corelib.Select2FilterOptions.md)
- [Select2InplaceAddOptions](../interfaces/corelib.Select2InplaceAddOptions.md)
- [Select2SearchPromise](../interfaces/corelib.Select2SearchPromise.md)
- [Select2SearchQuery](../interfaces/corelib.Select2SearchQuery.md)
- [Select2SearchResult](../interfaces/corelib.Select2SearchResult.md)
- [SelectEditorOptions](../interfaces/corelib.SelectEditorOptions.md)
- [ServiceLookupEditorOptions](../interfaces/corelib.ServiceLookupEditorOptions.md)
- [SettingStorage](../interfaces/corelib.SettingStorage.md)
- [TextAreaEditorOptions](../interfaces/corelib.TextAreaEditorOptions.md)
- [TimeEditorOptions](../interfaces/corelib.TimeEditorOptions.md)
- [ToolButton](../interfaces/corelib.ToolButton.md)
- [ToolbarOptions](../interfaces/corelib.ToolbarOptions.md)
- [TreeGridMixinOptions](../interfaces/corelib.TreeGridMixinOptions.md)
- [UploadInputOptions](../interfaces/corelib.UploadInputOptions.md)
- [UploadResponse](../interfaces/corelib.UploadResponse.md)
- [UploadedFile](../interfaces/corelib.UploadedFile.md)
- [WidgetClass](../interfaces/corelib.WidgetClass.md)
- [WidgetComponentProps](../interfaces/corelib.WidgetComponentProps.md)
- [WidgetDialogClass](../interfaces/corelib.WidgetDialogClass.md)

### Type Aliases

- [AnyWidgetClass](corelib.md#anywidgetclass)
- [Constructor](corelib.md#constructor)

### Variables

- [datePickerIconSvg](corelib.md#datepickericonsvg)

### Functions

- [jsxDomWidget](corelib.md#jsxdomwidget)
- [reactPatch](corelib.md#reactpatch)
- [useIdPrefix](corelib.md#useidprefix)

## References

### ColumnSelection

Re-exports [ColumnSelection](../enums/corelib_q.ColumnSelection.md)

___

### Criteria

Re-exports [Criteria](corelib_q.md#criteria)

___

### DeleteRequest

Re-exports [DeleteRequest](../interfaces/corelib_q.DeleteRequest.md)

___

### DeleteResponse

Re-exports [DeleteResponse](../interfaces/corelib_q.DeleteResponse.md)

___

### Formatter

Re-exports [Formatter](../interfaces/corelib_slick.Formatter.md)

___

### ISlickFormatter

Re-exports [ISlickFormatter](../classes/corelib_q.ISlickFormatter.md)

___

### ListRequest

Re-exports [ListRequest](../interfaces/corelib_q.ListRequest.md)

___

### ListResponse

Re-exports [ListResponse](../interfaces/corelib_q.ListResponse.md)

___

### PropertyItem

Re-exports [PropertyItem](../interfaces/corelib_q.PropertyItem.md)

___

### PropertyItemsData

Re-exports [PropertyItemsData](../interfaces/corelib_q.PropertyItemsData.md)

___

### RetrieveColumnSelection

Re-exports [RetrieveColumnSelection](../enums/corelib_q.RetrieveColumnSelection.md)

___

### RetrieveLocalizationRequest

Re-exports [RetrieveLocalizationRequest](../interfaces/corelib_q.RetrieveLocalizationRequest.md)

___

### RetrieveLocalizationResponse

Re-exports [RetrieveLocalizationResponse](../interfaces/corelib_q.RetrieveLocalizationResponse.md)

___

### RetrieveRequest

Re-exports [RetrieveRequest](../interfaces/corelib_q.RetrieveRequest.md)

___

### RetrieveResponse

Re-exports [RetrieveResponse](../interfaces/corelib_q.RetrieveResponse.md)

___

### SaveRequest

Re-exports [SaveRequest](../interfaces/corelib_q.SaveRequest.md)

___

### SaveRequestWithAttachment

Re-exports [SaveRequestWithAttachment](../interfaces/corelib_q.SaveRequestWithAttachment.md)

___

### SaveResponse

Re-exports [SaveResponse](../interfaces/corelib_q.SaveResponse.md)

___

### SaveWithLocalizationRequest

Re-exports [SaveWithLocalizationRequest](../interfaces/corelib_q.SaveWithLocalizationRequest.md)

___

### ServiceError

Re-exports [ServiceError](../interfaces/corelib_q.ServiceError.md)

___

### ServiceOptions

Re-exports [ServiceOptions](../interfaces/corelib_q.ServiceOptions.md)

___

### ServiceRequest

Re-exports [ServiceRequest](../interfaces/corelib_q.ServiceRequest.md)

___

### ServiceResponse

Re-exports [ServiceResponse](../interfaces/corelib_q.ServiceResponse.md)

___

### SummaryType

Re-exports [SummaryType](../enums/corelib_q.SummaryType.md)

___

### UndeleteRequest

Re-exports [UndeleteRequest](../interfaces/corelib_q.UndeleteRequest.md)

___

### UndeleteResponse

Re-exports [UndeleteResponse](../interfaces/corelib_q.UndeleteResponse.md)

## Type Aliases

### AnyWidgetClass

Ƭ **AnyWidgetClass**<`TOptions`\>: [`WidgetClass`](../interfaces/corelib.WidgetClass.md)<`TOptions`\> \| [`WidgetDialogClass`](../interfaces/corelib.WidgetDialogClass.md)<`TOptions`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | `object` |

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### Constructor

Ƭ **Constructor**<`T`\>: (...`args`: `any`[]) => `T`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Type declaration

• (`...args`)

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

#### Defined in

[src/index.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/index.ts#L107)

## Variables

### datePickerIconSvg

• **datePickerIconSvg**: `string` = `'<svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 0 17 17"><g></g><path d="M14 2v-1h-3v1h-5v-1h-3v1h-3v15h17v-15h-3zM12 2h1v2h-1v-2zM4 2h1v2h-1v-2zM16 16h-15v-8.921h15v8.921zM1 6.079v-3.079h2v2h3v-2h5v2h3v-2h2v3.079h-15z" fill="currentColor"></path></svg>'`

#### Defined in

[src/ui/editors/dateeditor.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L6)

## Functions

### jsxDomWidget

▸ **jsxDomWidget**<`TWidget`, `TOptions`\>(`type`): `JsxDomWidget`<`TOptions` & { `ref?`: (`r`: `TWidget`) => `void`  }\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](../classes/corelib.Widget.md)<`TOptions`, `TWidget`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (`element`: `JQuery`, `options?`: `TOptions`) => `TWidget` |

#### Returns

`JsxDomWidget`<`TOptions` & { `ref?`: (`r`: `TWidget`) => `void`  }\>

#### Defined in

[src/ui/widgets/jsx.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/jsx.ts#L74)

___

### reactPatch

▸ **reactPatch**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L19)

___

### useIdPrefix

▸ **useIdPrefix**(`prefix`): `IdPrefixType`

#### Parameters

| Name | Type |
| :------ | :------ |
| `prefix` | `string` |

#### Returns

`IdPrefixType`

#### Defined in

[src/ui/widgets/templatedwidget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L138)
