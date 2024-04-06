@serenity-is/corelib

# @serenity-is/corelib

## Serenity Core Library

This is the package containing core TypeScript classes and functions used in Serenity applications. 

It should be installed by default in your projects created from `Serene` or `StartSharp` template:

```json
{
  "dependencies": {
    // ...
    "@serenity-is/corelib": "latest"
  }
}
```

The version number for this package should be equal or as close as possible to Serenity NuGet package versions in your project file.

> When using classic namespaces instead of the ESM modules, the types and functions in this module are directly available from the global `Serenity` and `Q` namespaces.
> e.g. `Serenity.EntityGrid`

## Table of contents

### Namespaces

- [AggregateFormatting](modules/AggregateFormatting.md)
- [Aggregators](modules/Aggregators.md)
- [Authorization](modules/Authorization.md)
- [Decorators](modules/Decorators.md)
- [DialogExtensions](modules/DialogExtensions.md)
- [DialogTexts](modules/DialogTexts.md)
- [DialogTypeRegistry](modules/DialogTypeRegistry.md)
- [EditorTypeRegistry](modules/EditorTypeRegistry.md)
- [EditorUtils](modules/EditorUtils.md)
- [Enum](modules/Enum.md)
- [EnumTypeRegistry](modules/EnumTypeRegistry.md)
- [ErrorHandling](modules/ErrorHandling.md)
- [FilterOperators](modules/FilterOperators.md)
- [FilteringTypeRegistry](modules/FilteringTypeRegistry.md)
- [FormatterTypeRegistry](modules/FormatterTypeRegistry.md)
- [GridSelectAllButtonHelper](modules/GridSelectAllButtonHelper.md)
- [GridUtils](modules/GridUtils.md)
- [LT](modules/LT.md)
- [LayoutTimer](modules/LayoutTimer.md)
- [LazyLoadHelper](modules/LazyLoadHelper.md)
- [PropertyItemSlickConverter](modules/PropertyItemSlickConverter.md)
- [ReflectionOptionsSetter](modules/ReflectionOptionsSetter.md)
- [ReflectionUtils](modules/ReflectionUtils.md)
- [Router](modules/Router.md)
- [ScriptData](modules/ScriptData.md)
- [SlickFormatting](modules/SlickFormatting.md)
- [SlickHelper](modules/SlickHelper.md)
- [SlickTreeHelper](modules/SlickTreeHelper.md)
- [SubDialogHelper](modules/SubDialogHelper.md)
- [TabsExtensions](modules/TabsExtensions.md)
- [UploadHelper](modules/UploadHelper.md)
- [ValidationHelper](modules/ValidationHelper.md)

### Enumerations

- [CaptureOperationType](enums/CaptureOperationType.md)
- [ColumnSelection](enums/ColumnSelection.md)
- [CriteriaOperator](enums/CriteriaOperator.md)
- [MemberType](enums/MemberType.md)
- [PropertyGridMode](enums/PropertyGridMode.md)
- [RetrieveColumnSelection](enums/RetrieveColumnSelection.md)
- [SummaryType](enums/SummaryType.md)

### Classes

- [ArgumentNullException](classes/ArgumentNullException.md)
- [AutoNumeric](classes/AutoNumeric.md)
- [BaseEditorFiltering](classes/BaseEditorFiltering.md)
- [BaseFiltering](classes/BaseFiltering.md)
- [BooleanEditor](classes/BooleanEditor.md)
- [BooleanFiltering](classes/BooleanFiltering.md)
- [BooleanFormatter](classes/BooleanFormatter.md)
- [CascadedWidgetLink](classes/CascadedWidgetLink.md)
- [CategoryAttribute](classes/CategoryAttribute.md)
- [CheckLookupEditor](classes/CheckLookupEditor.md)
- [CheckTreeEditor](classes/CheckTreeEditor.md)
- [CheckboxFormatter](classes/CheckboxFormatter.md)
- [CloseButtonAttribute](classes/CloseButtonAttribute.md)
- [ColumnPickerDialog](classes/ColumnPickerDialog.md)
- [ColumnsBase](classes/ColumnsBase.md)
- [ColumnsKeyAttribute](classes/ColumnsKeyAttribute.md)
- [Combobox](classes/Combobox.md)
- [ComboboxEditor](classes/ComboboxEditor.md)
- [CriteriaBuilder](classes/CriteriaBuilder.md)
- [CssClassAttribute](classes/CssClassAttribute.md)
- [DataGrid](classes/DataGrid.md)
- [DateEditor](classes/DateEditor.md)
- [DateFiltering](classes/DateFiltering.md)
- [DateFormatter](classes/DateFormatter.md)
- [DateTimeEditor](classes/DateTimeEditor.md)
- [DateTimeFiltering](classes/DateTimeFiltering.md)
- [DateTimeFormatter](classes/DateTimeFormatter.md)
- [DateYearEditor](classes/DateYearEditor.md)
- [DecimalEditor](classes/DecimalEditor.md)
- [DecimalFiltering](classes/DecimalFiltering.md)
- [DefaultValueAttribute](classes/DefaultValueAttribute.md)
- [Dialog](classes/Dialog.md)
- [DialogTypeAttribute](classes/DialogTypeAttribute.md)
- [DisplayNameAttribute](classes/DisplayNameAttribute.md)
- [EditorAttribute](classes/EditorAttribute.md)
- [EditorFiltering](classes/EditorFiltering.md)
- [EditorOptionAttribute](classes/EditorOptionAttribute.md)
- [EditorTypeAttribute](classes/EditorTypeAttribute.md)
- [EditorTypeAttributeBase](classes/EditorTypeAttributeBase.md)
- [EditorWidget](classes/EditorWidget.md)
- [ElementAttribute](classes/ElementAttribute.md)
- [EmailAddressEditor](classes/EmailAddressEditor.md)
- [EmailEditor](classes/EmailEditor.md)
- [EntityDialog](classes/EntityDialog.md)
- [EntityGrid](classes/EntityGrid.md)
- [EntityTypeAttribute](classes/EntityTypeAttribute.md)
- [EnumEditor](classes/EnumEditor.md)
- [EnumFiltering](classes/EnumFiltering.md)
- [EnumFormatter](classes/EnumFormatter.md)
- [EnumKeyAttribute](classes/EnumKeyAttribute.md)
- [Exception](classes/Exception.md)
- [FileDownloadFormatter](classes/FileDownloadFormatter.md)
- [FileUploadEditor](classes/FileUploadEditor.md)
- [FilterDialog](classes/FilterDialog.md)
- [FilterDisplayBar](classes/FilterDisplayBar.md)
- [FilterPanel](classes/FilterPanel.md)
- [FilterStore](classes/FilterStore.md)
- [FilterWidgetBase](classes/FilterWidgetBase.md)
- [FilterableAttribute](classes/FilterableAttribute.md)
- [FlexifyAttribute](classes/FlexifyAttribute.md)
- [FormKeyAttribute](classes/FormKeyAttribute.md)
- [GeneratedCodeAttribute](classes/GeneratedCodeAttribute.md)
- [GridRadioSelectionMixin](classes/GridRadioSelectionMixin.md)
- [GridRowSelectionMixin](classes/GridRowSelectionMixin.md)
- [HiddenAttribute](classes/HiddenAttribute.md)
- [HintAttribute](classes/HintAttribute.md)
- [HtmlContentEditor](classes/HtmlContentEditor.md)
- [HtmlNoteContentEditor](classes/HtmlNoteContentEditor.md)
- [HtmlReportContentEditor](classes/HtmlReportContentEditor.md)
- [IBooleanValue](classes/IBooleanValue.md)
- [IDialog](classes/IDialog.md)
- [IDoubleValue](classes/IDoubleValue.md)
- [IEditDialog](classes/IEditDialog.md)
- [IFiltering](classes/IFiltering.md)
- [IGetEditValue](classes/IGetEditValue.md)
- [IInitializeColumn](classes/IInitializeColumn.md)
- [IQuickFiltering](classes/IQuickFiltering.md)
- [IReadOnly](classes/IReadOnly.md)
- [ISetEditValue](classes/ISetEditValue.md)
- [ISlickFormatter](classes/ISlickFormatter.md)
- [IStringValue](classes/IStringValue.md)
- [IValidateRequired](classes/IValidateRequired.md)
- [IdPropertyAttribute](classes/IdPropertyAttribute.md)
- [ImageUploadEditor](classes/ImageUploadEditor.md)
- [InsertableAttribute](classes/InsertableAttribute.md)
- [IntegerEditor](classes/IntegerEditor.md)
- [IntegerFiltering](classes/IntegerFiltering.md)
- [InvalidCastException](classes/InvalidCastException.md)
- [IsActivePropertyAttribute](classes/IsActivePropertyAttribute.md)
- [ItemNameAttribute](classes/ItemNameAttribute.md)
- [LocalTextPrefixAttribute](classes/LocalTextPrefixAttribute.md)
- [Lookup](classes/Lookup.md)
- [LookupEditor](classes/LookupEditor.md)
- [LookupEditorBase](classes/LookupEditorBase.md)
- [LookupFiltering](classes/LookupFiltering.md)
- [MaskedEditor](classes/MaskedEditor.md)
- [MaxLengthAttribute](classes/MaxLengthAttribute.md)
- [MaximizableAttribute](classes/MaximizableAttribute.md)
- [MinuteFormatter](classes/MinuteFormatter.md)
- [MultipleFileUploadEditor](classes/MultipleFileUploadEditor.md)
- [MultipleImageUploadEditor](classes/MultipleImageUploadEditor.md)
- [NamePropertyAttribute](classes/NamePropertyAttribute.md)
- [NumberFormatter](classes/NumberFormatter.md)
- [OneWayAttribute](classes/OneWayAttribute.md)
- [OptionAttribute](classes/OptionAttribute.md)
- [OptionsTypeAttribute](classes/OptionsTypeAttribute.md)
- [PanelAttribute](classes/PanelAttribute.md)
- [PasswordEditor](classes/PasswordEditor.md)
- [PlaceholderAttribute](classes/PlaceholderAttribute.md)
- [PrefixedContext](classes/PrefixedContext.md)
- [PropertyDialog](classes/PropertyDialog.md)
- [PropertyGrid](classes/PropertyGrid.md)
- [PropertyPanel](classes/PropertyPanel.md)
- [QuickFilterBar](classes/QuickFilterBar.md)
- [QuickSearchInput](classes/QuickSearchInput.md)
- [RadioButtonEditor](classes/RadioButtonEditor.md)
- [ReadOnlyAttribute](classes/ReadOnlyAttribute.md)
- [Recaptcha](classes/Recaptcha.md)
- [RemoteView](classes/RemoteView.md)
- [RequiredAttribute](classes/RequiredAttribute.md)
- [ResizableAttribute](classes/ResizableAttribute.md)
- [ResponsiveAttribute](classes/ResponsiveAttribute.md)
- [Select2](classes/Select2.md)
- [SelectEditor](classes/SelectEditor.md)
- [ServiceAttribute](classes/ServiceAttribute.md)
- [ServiceLookupEditor](classes/ServiceLookupEditor.md)
- [ServiceLookupEditorBase](classes/ServiceLookupEditorBase.md)
- [ServiceLookupFiltering](classes/ServiceLookupFiltering.md)
- [SlickPager](classes/SlickPager.md)
- [StaticPanelAttribute](classes/StaticPanelAttribute.md)
- [StringEditor](classes/StringEditor.md)
- [StringFiltering](classes/StringFiltering.md)
- [TemplatedDialog](classes/TemplatedDialog.md)
- [TemplatedPanel](classes/TemplatedPanel.md)
- [TemplatedWidget](classes/TemplatedWidget.md)
- [TextAreaEditor](classes/TextAreaEditor.md)
- [TimeEditor](classes/TimeEditor.md)
- [Toastr](classes/Toastr.md)
- [Toolbar](classes/Toolbar.md)
- [Tooltip](classes/Tooltip.md)
- [TreeGridMixin](classes/TreeGridMixin.md)
- [URLEditor](classes/URLEditor.md)
- [UpdatableAttribute](classes/UpdatableAttribute.md)
- [Uploader](classes/Uploader.md)
- [UrlFormatter](classes/UrlFormatter.md)
- [Validator](classes/Validator.md)
- [Widget](classes/Widget.md)

### Interfaces

- [AutoNumericOptions](interfaces/AutoNumericOptions.md)
- [CKEditorConfig](interfaces/CKEditorConfig.md)
- [CheckLookupEditorOptions](interfaces/CheckLookupEditorOptions.md)
- [CheckTreeItem](interfaces/CheckTreeItem.md)
- [ComboboxCommonOptions](interfaces/ComboboxCommonOptions.md)
- [ComboboxEditorOptions](interfaces/ComboboxEditorOptions.md)
- [ComboboxFilterOptions](interfaces/ComboboxFilterOptions.md)
- [ComboboxInplaceAddOptions](interfaces/ComboboxInplaceAddOptions.md)
- [ComboboxItem](interfaces/ComboboxItem.md)
- [ComboboxOptions](interfaces/ComboboxOptions.md)
- [ComboboxSearchQuery](interfaces/ComboboxSearchQuery.md)
- [ComboboxSearchResult](interfaces/ComboboxSearchResult.md)
- [ConfirmDialogOptions](interfaces/ConfirmDialogOptions.md)
- [CreateWidgetParams](interfaces/CreateWidgetParams.md)
- [CriteriaWithText](interfaces/CriteriaWithText.md)
- [DataChangeInfo](interfaces/DataChangeInfo.md)
- [DateEditorOptions](interfaces/DateEditorOptions.md)
- [DateFormat](interfaces/DateFormat.md)
- [DateTimeEditorOptions](interfaces/DateTimeEditorOptions.md)
- [DateYearEditorOptions](interfaces/DateYearEditorOptions.md)
- [DebouncedFunction](interfaces/DebouncedFunction.md)
- [DecimalEditorOptions](interfaces/DecimalEditorOptions.md)
- [DeleteRequest](interfaces/DeleteRequest.md)
- [DeleteResponse](interfaces/DeleteResponse.md)
- [DialogButton](interfaces/DialogButton.md)
- [DialogOptions](interfaces/DialogOptions.md)
- [EmailEditorOptions](interfaces/EmailEditorOptions.md)
- [EnumEditorOptions](interfaces/EnumEditorOptions.md)
- [FileUploadConstraints](interfaces/FileUploadConstraints.md)
- [FileUploadEditorOptions](interfaces/FileUploadEditorOptions.md)
- [FilterFieldSelectOptions](interfaces/FilterFieldSelectOptions.md)
- [FilterLine](interfaces/FilterLine.md)
- [FilterOperator](interfaces/FilterOperator.md)
- [Fluent](interfaces/Fluent.md)
- [Formatter](interfaces/Formatter.md)
- [GridPersistanceFlags](interfaces/GridPersistanceFlags.md)
- [GridRadioSelectionMixinOptions](interfaces/GridRadioSelectionMixinOptions.md)
- [GridRowSelectionMixinOptions](interfaces/GridRowSelectionMixinOptions.md)
- [GroupInfo](interfaces/GroupInfo.md)
- [HandleRouteEvent](interfaces/HandleRouteEvent.md)
- [HtmlContentEditorOptions](interfaces/HtmlContentEditorOptions.md)
- [IDataGrid](interfaces/IDataGrid.md)
- [IFrameDialogOptions](interfaces/IFrameDialogOptions.md)
- [IRowDefinition](interfaces/IRowDefinition.md)
- [ImageUploadEditorOptions](interfaces/ImageUploadEditorOptions.md)
- [IntegerEditorOptions](interfaces/IntegerEditorOptions.md)
- [ListRequest](interfaces/ListRequest.md)
- [ListResponse](interfaces/ListResponse.md)
- [Locale](interfaces/Locale.md)
- [LookupEditorOptions](interfaces/LookupEditorOptions.md)
- [LookupOptions](interfaces/LookupOptions.md)
- [MaskedEditorOptions](interfaces/MaskedEditorOptions.md)
- [MessageDialogOptions](interfaces/MessageDialogOptions.md)
- [MultipleFileUploadEditorOptions](interfaces/MultipleFileUploadEditorOptions.md)
- [NumberFormat](interfaces/NumberFormat.md)
- [PagerOptions](interfaces/PagerOptions.md)
- [PagingInfo](interfaces/PagingInfo.md)
- [PagingOptions](interfaces/PagingOptions.md)
- [PersistedGridColumn](interfaces/PersistedGridColumn.md)
- [PersistedGridSettings](interfaces/PersistedGridSettings.md)
- [PostToServiceOptions](interfaces/PostToServiceOptions.md)
- [PostToUrlOptions](interfaces/PostToUrlOptions.md)
- [PropertyGridOptions](interfaces/PropertyGridOptions.md)
- [PropertyItem](interfaces/PropertyItem.md)
- [PropertyItemsData](interfaces/PropertyItemsData.md)
- [QuickFilter](interfaces/QuickFilter.md)
- [QuickFilterArgs](interfaces/QuickFilterArgs.md)
- [QuickFilterBarOptions](interfaces/QuickFilterBarOptions.md)
- [QuickSearchField](interfaces/QuickSearchField.md)
- [QuickSearchInputOptions](interfaces/QuickSearchInputOptions.md)
- [RadioButtonEditorOptions](interfaces/RadioButtonEditorOptions.md)
- [RecaptchaOptions](interfaces/RecaptchaOptions.md)
- [RemoteViewOptions](interfaces/RemoteViewOptions.md)
- [RequestErrorInfo](interfaces/RequestErrorInfo.md)
- [RetrieveLocalizationRequest](interfaces/RetrieveLocalizationRequest.md)
- [RetrieveLocalizationResponse](interfaces/RetrieveLocalizationResponse.md)
- [RetrieveRequest](interfaces/RetrieveRequest.md)
- [RetrieveResponse](interfaces/RetrieveResponse.md)
- [SaveRequest](interfaces/SaveRequest.md)
- [SaveRequestWithAttachment](interfaces/SaveRequestWithAttachment.md)
- [SaveResponse](interfaces/SaveResponse.md)
- [SaveWithLocalizationRequest](interfaces/SaveWithLocalizationRequest.md)
- [Select2AjaxOptions](interfaces/Select2AjaxOptions.md)
- [Select2Item](interfaces/Select2Item.md)
- [Select2Options](interfaces/Select2Options.md)
- [Select2QueryOptions](interfaces/Select2QueryOptions.md)
- [Select2Result](interfaces/Select2Result.md)
- [SelectEditorOptions](interfaces/SelectEditorOptions.md)
- [ServiceError](interfaces/ServiceError.md)
- [ServiceLookupEditorOptions](interfaces/ServiceLookupEditorOptions.md)
- [ServiceOptions](interfaces/ServiceOptions.md)
- [ServiceRequest](interfaces/ServiceRequest.md)
- [ServiceResponse](interfaces/ServiceResponse.md)
- [SettingStorage](interfaces/SettingStorage.md)
- [SummaryOptions](interfaces/SummaryOptions.md)
- [TextAreaEditorOptions](interfaces/TextAreaEditorOptions.md)
- [TimeEditorOptions](interfaces/TimeEditorOptions.md)
- [ToolButton](interfaces/ToolButton.md)
- [ToolButtonProps](interfaces/ToolButtonProps.md)
- [ToolbarOptions](interfaces/ToolbarOptions.md)
- [TooltipOptions](interfaces/TooltipOptions.md)
- [TreeGridMixinOptions](interfaces/TreeGridMixinOptions.md)
- [TypeMember](interfaces/TypeMember.md)
- [UndeleteRequest](interfaces/UndeleteRequest.md)
- [UndeleteResponse](interfaces/UndeleteResponse.md)
- [UploadInputOptions](interfaces/UploadInputOptions.md)
- [UploadResponse](interfaces/UploadResponse.md)
- [UploadedFile](interfaces/UploadedFile.md)
- [UploaderBatch](interfaces/UploaderBatch.md)
- [UploaderErrorData](interfaces/UploaderErrorData.md)
- [UploaderOptions](interfaces/UploaderOptions.md)
- [UploaderRequest](interfaces/UploaderRequest.md)
- [UploaderSuccessData](interfaces/UploaderSuccessData.md)
- [UserDefinition](interfaces/UserDefinition.md)
- [ValidatableElement](interfaces/ValidatableElement.md)
- [ValidationErrorItem](interfaces/ValidationErrorItem.md)
- [ValidationErrorMap](interfaces/ValidationErrorMap.md)
- [ValidationRulesMap](interfaces/ValidationRulesMap.md)
- [ValidatorOptions](interfaces/ValidatorOptions.md)

### Type Aliases

- [AnyIconClass](README.md#anyiconclass)
- [CancellableViewCallback](README.md#cancellableviewcallback)
- [ClassTypeInfo](README.md#classtypeinfo)
- [ComboboxFormatResult](README.md#comboboxformatresult)
- [ComboboxType](README.md#comboboxtype)
- [Constructor](README.md#constructor)
- [DialogType](README.md#dialogtype)
- [Dictionary](README.md#dictionary)
- [EditorProps](README.md#editorprops)
- [EditorTypeInfo](README.md#editortypeinfo)
- [Format](README.md#format)
- [FormatterTypeInfo](README.md#formattertypeinfo)
- [GroupByElement](README.md#groupbyelement)
- [GroupByResult](README.md#groupbyresult)
- [Grouping](README.md#grouping)
- [IconClassName](README.md#iconclassname)
- [IdPrefixType](README.md#idprefixtype)
- [InterfaceTypeInfo](README.md#interfacetypeinfo)
- [KnownIconClass](README.md#knowniconclass)
- [NoInfer](README.md#noinfer)
- [NotifyMap](README.md#notifymap)
- [RemoteViewAjaxCallback](README.md#remoteviewajaxcallback)
- [RemoteViewFilter](README.md#remoteviewfilter)
- [RemoteViewProcessCallback](README.md#remoteviewprocesscallback)
- [Select2Element](README.md#select2element)
- [Select2FormatResult](README.md#select2formatresult)
- [StringLiteral](README.md#stringliteral)
- [TextColor](README.md#textcolor)
- [ToastContainerOptions](README.md#toastcontaineroptions)
- [ToastrOptions](README.md#toastroptions)
- [Type](README.md#type)
- [TypeInfo](README.md#typeinfo)
- [UtilityColor](README.md#utilitycolor)
- [ValidateEventDelegate](README.md#validateeventdelegate)
- [ValidationErrorList](README.md#validationerrorlist)
- [ValidationProvider](README.md#validationprovider)
- [ValidationRules](README.md#validationrules)
- [ValidationValue](README.md#validationvalue)
- [WidgetProps](README.md#widgetprops)
- [faIconKey](README.md#faiconkey)
- [fabIconKey](README.md#fabiconkey)

### Variables

- [Config](README.md#config)
- [Culture](README.md#culture)
- [Invariant](README.md#invariant)
- [defaultNotifyOptions](README.md#defaultnotifyoptions)
- [typeInfoProperty](README.md#typeinfoproperty)

### Functions

- [Criteria](README.md#criteria)
- [Fluent](README.md#fluent)
- [GridPageInit](README.md#gridpageinit)
- [PanelPageInit](README.md#panelpageinit)
- [ToolbarButton](README.md#toolbarbutton)
- [addClass](README.md#addclass)
- [addCustomAttribute](README.md#addcustomattribute)
- [addEmptyOption](README.md#addemptyoption)
- [addLocalText](README.md#addlocaltext)
- [addOption](README.md#addoption)
- [addTypeMember](README.md#addtypemember)
- [addValidationRule](README.md#addvalidationrule)
- [alert](README.md#alert)
- [alertDialog](README.md#alertdialog)
- [any](README.md#any)
- [appendChild](README.md#appendchild)
- [associateWidget](README.md#associatewidget)
- [attrEncode](README.md#attrencode)
- [bgColor](README.md#bgcolor)
- [blockUI](README.md#blockui)
- [blockUndo](README.md#blockundo)
- [canLoadScriptData](README.md#canloadscriptdata)
- [cancelDialogButton](README.md#canceldialogbutton)
- [cast](README.md#cast)
- [centerDialog](README.md#centerdialog)
- [classTypeInfo](README.md#classtypeinfo-1)
- [clearKeys](README.md#clearkeys)
- [clearOptions](README.md#clearoptions)
- [coalesce](README.md#coalesce)
- [compareStringFactory](README.md#comparestringfactory)
- [confirm](README.md#confirm)
- [confirmDialog](README.md#confirmdialog)
- [count](README.md#count)
- [dbText](README.md#dbtext)
- [dbTryText](README.md#dbtrytext)
- [deassociateWidget](README.md#deassociatewidget)
- [debounce](README.md#debounce)
- [deepClone](README.md#deepclone)
- [delegateCombine](README.md#delegatecombine)
- [delegateContains](README.md#delegatecontains)
- [delegateRemove](README.md#delegateremove)
- [editorTypeInfo](README.md#editortypeinfo-1)
- [endsWith](README.md#endswith)
- [executeEverytimeWhenVisible](README.md#executeeverytimewhenvisible)
- [executeOnceWhenVisible](README.md#executeoncewhenvisible)
- [extend](README.md#extend)
- [faIcon](README.md#faicon)
- [fabIcon](README.md#fabicon)
- [fetchScriptData](README.md#fetchscriptdata)
- [fieldsProxy](README.md#fieldsproxy)
- [findElementWithRelativeId](README.md#findelementwithrelativeid)
- [first](README.md#first)
- [format](README.md#format-1)
- [formatDate](README.md#formatdate)
- [formatDayHourAndMin](README.md#formatdayhourandmin)
- [formatISODateTimeUTC](README.md#formatisodatetimeutc)
- [formatNumber](README.md#formatnumber)
- [formatterTypeInfo](README.md#formattertypeinfo-1)
- [getActiveRequests](README.md#getactiverequests)
- [getBaseType](README.md#getbasetype)
- [getColumns](README.md#getcolumns)
- [getColumnsAsync](README.md#getcolumnsasync)
- [getColumnsData](README.md#getcolumnsdata)
- [getColumnsDataAsync](README.md#getcolumnsdataasync)
- [getColumnsScript](README.md#getcolumnsscript)
- [getCookie](README.md#getcookie)
- [getCustomAttribute](README.md#getcustomattribute)
- [getCustomAttributes](README.md#getcustomattributes)
- [getForm](README.md#getform)
- [getFormAsync](README.md#getformasync)
- [getFormData](README.md#getformdata)
- [getFormDataAsync](README.md#getformdataasync)
- [getFormScript](README.md#getformscript)
- [getGlobalObject](README.md#getglobalobject)
- [getInstanceType](README.md#getinstancetype)
- [getLookup](README.md#getlookup)
- [getLookupAsync](README.md#getlookupasync)
- [getMembers](README.md#getmembers)
- [getNested](README.md#getnested)
- [getRemoteData](README.md#getremotedata)
- [getRemoteDataAsync](README.md#getremotedataasync)
- [getScriptData](README.md#getscriptdata)
- [getScriptDataHash](README.md#getscriptdatahash)
- [getTemplate](README.md#gettemplate)
- [getType](README.md#gettype)
- [getTypeFullName](README.md#gettypefullname)
- [getTypeNameProp](README.md#gettypenameprop)
- [getTypeRegistry](README.md#gettyperegistry)
- [getTypeShortName](README.md#gettypeshortname)
- [getTypes](README.md#gettypes)
- [getWidgetFrom](README.md#getwidgetfrom)
- [getWidgetName](README.md#getwidgetname)
- [getjQuery](README.md#getjquery)
- [gridPageInit](README.md#gridpageinit-1)
- [groupBy](README.md#groupby)
- [handleScriptDataError](README.md#handlescriptdataerror)
- [hasBSModal](README.md#hasbsmodal)
- [hasCustomAttribute](README.md#hascustomattribute)
- [hasUIDialog](README.md#hasuidialog)
- [htmlEncode](README.md#htmlencode)
- [iconClassName](README.md#iconclassname-1)
- [iframeDialog](README.md#iframedialog)
- [indexOf](README.md#indexof)
- [information](README.md#information)
- [informationDialog](README.md#informationdialog)
- [initFormType](README.md#initformtype)
- [initFullHeightGridPage](README.md#initfullheightgridpage)
- [initializeTypes](README.md#initializetypes)
- [insert](README.md#insert)
- [interfaceTypeInfo](README.md#interfacetypeinfo-1)
- [isArray](README.md#isarray)
- [isArrayLike](README.md#isarraylike)
- [isAssignableFrom](README.md#isassignablefrom)
- [isBS3](README.md#isbs3)
- [isBS5Plus](README.md#isbs5plus)
- [isEmptyOrNull](README.md#isemptyornull)
- [isEnum](README.md#isenum)
- [isInstanceOfType](README.md#isinstanceoftype)
- [isMobileView](README.md#ismobileview)
- [isPromiseLike](README.md#ispromiselike)
- [isSameOrigin](README.md#issameorigin)
- [isTrimmedEmpty](README.md#istrimmedempty)
- [isValue](README.md#isvalue)
- [keyOf](README.md#keyof)
- [layoutFillHeight](README.md#layoutfillheight)
- [layoutFillHeightValue](README.md#layoutfillheightvalue)
- [localText](README.md#localtext)
- [localeFormat](README.md#localeformat)
- [newBodyDiv](README.md#newbodydiv)
- [noDialogButton](README.md#nodialogbutton)
- [notifyError](README.md#notifyerror)
- [notifyInfo](README.md#notifyinfo)
- [notifySuccess](README.md#notifysuccess)
- [notifyWarning](README.md#notifywarning)
- [okDialogButton](README.md#okdialogbutton)
- [omitUndefined](README.md#omitundefined)
- [outerHtml](README.md#outerhtml)
- [padLeft](README.md#padleft)
- [panelPageInit](README.md#panelpageinit-1)
- [parseCriteria](README.md#parsecriteria)
- [parseDate](README.md#parsedate)
- [parseDayHourAndMin](README.md#parsedayhourandmin)
- [parseDecimal](README.md#parsedecimal)
- [parseHourAndMin](README.md#parsehourandmin)
- [parseISODateTime](README.md#parseisodatetime)
- [parseInteger](README.md#parseinteger)
- [parseQueryString](README.md#parsequerystring)
- [peekScriptData](README.md#peekscriptdata)
- [positionToastContainer](README.md#positiontoastcontainer)
- [postToService](README.md#posttoservice)
- [postToUrl](README.md#posttourl)
- [prefixedText](README.md#prefixedtext)
- [proxyTexts](README.md#proxytexts)
- [registerClass](README.md#registerclass)
- [registerEditor](README.md#registereditor)
- [registerEnum](README.md#registerenum)
- [registerFormatter](README.md#registerformatter)
- [registerInterface](README.md#registerinterface)
- [registerType](README.md#registertype)
- [reloadLookup](README.md#reloadlookup)
- [reloadLookupAsync](README.md#reloadlookupasync)
- [removeClass](README.md#removeclass)
- [removeValidationRule](README.md#removevalidationrule)
- [replaceAll](README.md#replaceall)
- [requestFinished](README.md#requestfinished)
- [requestStarting](README.md#requeststarting)
- [resolveServiceUrl](README.md#resolveserviceurl)
- [resolveUrl](README.md#resolveurl)
- [round](README.md#round)
- [safeCast](README.md#safecast)
- [serviceCall](README.md#servicecall)
- [serviceRequest](README.md#servicerequest)
- [setEquality](README.md#setequality)
- [setRegisteredScripts](README.md#setregisteredscripts)
- [setScriptData](README.md#setscriptdata)
- [setTypeNameProp](README.md#settypenameprop)
- [single](README.md#single)
- [splitDateString](README.md#splitdatestring)
- [startsWith](README.md#startswith)
- [stringFormat](README.md#stringformat)
- [stringFormatLocale](README.md#stringformatlocale)
- [stripDiacritics](README.md#stripdiacritics)
- [success](README.md#success)
- [successDialog](README.md#successdialog)
- [text](README.md#text)
- [textColor](README.md#textcolor-1)
- [toGrouping](README.md#togrouping)
- [toId](README.md#toid)
- [toSingleLine](README.md#tosingleline)
- [today](README.md#today)
- [toggleClass](README.md#toggleclass)
- [triggerLayoutOnShow](README.md#triggerlayoutonshow)
- [trim](README.md#trim)
- [trimEnd](README.md#trimend)
- [trimStart](README.md#trimstart)
- [trimToEmpty](README.md#trimtoempty)
- [trimToNull](README.md#trimtonull)
- [trunc](README.md#trunc)
- [tryFirst](README.md#tryfirst)
- [tryGetText](README.md#trygettext)
- [tryGetWidget](README.md#trygetwidget)
- [turkishLocaleCompare](README.md#turkishlocalecompare)
- [turkishLocaleToLower](README.md#turkishlocaletolower)
- [turkishLocaleToUpper](README.md#turkishlocaletoupper)
- [uiAndBSButtonNoConflict](README.md#uiandbsbuttonnoconflict)
- [useIdPrefix](README.md#useidprefix)
- [validateOptions](README.md#validateoptions)
- [validatorAbortHandler](README.md#validatoraborthandler)
- [warning](README.md#warning)
- [warningDialog](README.md#warningdialog)
- [yesDialogButton](README.md#yesdialogbutton)
- [zeroPad](README.md#zeropad)

## Type Aliases

### AnyIconClass

Ƭ **AnyIconClass**: [`KnownIconClass`](README.md#knowniconclass) \| `string` & {}

#### Defined in

[src/base/icons.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L21)

___

### CancellableViewCallback

Ƭ **CancellableViewCallback**\<`TEntity`\>: (`view`: [`RemoteView`](classes/RemoteView.md)\<`TEntity`\>) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](classes/RemoteView.md)\<`TEntity`\> |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L38)

___

### ClassTypeInfo

Ƭ **ClassTypeInfo**\<`T`\>: [`TypeInfo`](README.md#typeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/base/system.ts:279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L279)

___

### ComboboxFormatResult

Ƭ **ComboboxFormatResult**: `string` \| `Element` \| `DocumentFragment`

#### Defined in

[src/ui/editors/combobox.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L5)

___

### ComboboxType

Ƭ **ComboboxType**: ``"select2"``

#### Defined in

[src/ui/editors/combobox.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L4)

___

### Constructor

Ƭ **Constructor**\<`T`\>: (...`args`: `any`[]) => `T`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Type declaration

• (`...args`): `T`

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

##### Returns

`T`

#### Defined in

[src/index.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/index.ts#L98)

___

### DialogType

Ƭ **DialogType**: ``"bsmodal"`` \| ``"uidialog"`` \| ``"panel"``

#### Defined in

[src/base/dialogs.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L28)

___

### Dictionary

Ƭ **Dictionary**\<`TItem`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[src/q/system-compat.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L3)

___

### EditorProps

Ƭ **EditorProps**\<`T`\>: [`WidgetProps`](README.md#widgetprops)\<`T`\> & \{ `initialValue?`: `any` ; `maxLength?`: `number` ; `name?`: `string` ; `placeholder?`: `string` ; `readOnly?`: `boolean` ; `required?`: `boolean`  }

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/ui/widgets/widgetutils.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L129)

___

### EditorTypeInfo

Ƭ **EditorTypeInfo**\<`T`\>: [`TypeInfo`](README.md#typeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/base/system.ts:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L280)

___

### Format

Ƭ **Format**\<`TItem`\>: (`ctx`: `FormatterContext`\<`TItem`\>) => `FormatterResult`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`ctx`): `FormatterResult`

##### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`\<`TItem`\> |

##### Returns

`FormatterResult`

#### Defined in

[src/slick/slicktypes.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L4)

___

### FormatterTypeInfo

Ƭ **FormatterTypeInfo**\<`T`\>: [`TypeInfo`](README.md#typeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/base/system.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L281)

___

### GroupByElement

Ƭ **GroupByElement**\<`TItem`\>: `Object`

A group item returned by `groupBy()`.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Type declaration

| Name | Type | Description |
| :------ | :------ | :------ |
| `items` | `TItem`[] | the items in the group |
| `key` | `string` | key of the group |
| `order` | `number` | index of the item in `inOrder` array |
| `start` | `number` | index of the first item of this group in the original array |

#### Defined in

[src/q/arrays-compat.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L43)

___

### GroupByResult

Ƭ **GroupByResult**\<`TItem`\>: `Object`

Return type of the `groupBy` function.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `byKey` | \{ `[key: string]`: [`GroupByElement`](README.md#groupbyelement)\<`TItem`\>;  } |
| `inOrder` | [`GroupByElement`](README.md#groupbyelement)\<`TItem`\>[] |

#### Defined in

[src/q/arrays-compat.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L57)

___

### Grouping

Ƭ **Grouping**\<`TItem`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Index signature

▪ [key: `string`]: `TItem`[]

#### Defined in

[src/q/arrays-compat.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L169)

___

### IconClassName

Ƭ **IconClassName**: [`AnyIconClass`](README.md#anyiconclass) \| [`AnyIconClass`](README.md#anyiconclass)[]

#### Defined in

[src/base/icons.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L22)

___

### IdPrefixType

Ƭ **IdPrefixType**: `Object`

#### Index signature

▪ [key: `string`]: `string`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `Form` | `string` |
| `PropertyGrid` | `string` |
| `Tabs` | `string` |
| `Toolbar` | `string` |

#### Defined in

[src/ui/widgets/widgetutils.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L108)

___

### InterfaceTypeInfo

Ƭ **InterfaceTypeInfo**\<`T`\>: [`TypeInfo`](README.md#typeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/base/system.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L282)

___

### KnownIconClass

Ƭ **KnownIconClass**: \`fa fa-$\{faIconKey}\` \| \`fab fa-$\{fabIconKey}\`

#### Defined in

[src/base/icons.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L20)

___

### NoInfer

Ƭ **NoInfer**\<`T`\>: [`T`][`T` extends `any` ? ``0`` : `never`]

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/base/system.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L211)

___

### NotifyMap

Ƭ **NotifyMap**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `iconClass` | `string` |
| `message?` | `string` |
| `title?` | `string` |
| `type` | `string` |

#### Defined in

[src/base/toastr2.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L39)

___

### RemoteViewAjaxCallback

Ƭ **RemoteViewAjaxCallback**\<`TEntity`\>: (`view`: [`RemoteView`](classes/RemoteView.md)\<`TEntity`\>, `options`: [`ServiceOptions`](interfaces/ServiceOptions.md)\<[`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\>\>) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`, `options`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](classes/RemoteView.md)\<`TEntity`\> |
| `options` | [`ServiceOptions`](interfaces/ServiceOptions.md)\<[`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\>\> |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L39)

___

### RemoteViewFilter

Ƭ **RemoteViewFilter**\<`TEntity`\>: (`item`: `TEntity`, `view`: [`RemoteView`](classes/RemoteView.md)\<`TEntity`\>) => `boolean`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`item`, `view`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TEntity` |
| `view` | [`RemoteView`](classes/RemoteView.md)\<`TEntity`\> |

##### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L40)

___

### RemoteViewProcessCallback

Ƭ **RemoteViewProcessCallback**\<`TEntity`\>: (`data`: [`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\>, `view`: [`RemoteView`](classes/RemoteView.md)\<`TEntity`\>) => [`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\>

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`data`, `view`): [`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\> |
| `view` | [`RemoteView`](classes/RemoteView.md)\<`TEntity`\> |

##### Returns

[`ListResponse`](interfaces/ListResponse.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L41)

___

### Select2Element

Ƭ **Select2Element**: `HTMLInputElement` \| `HTMLSelectElement`

#### Defined in

[src/ui/editors/select2.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L7)

___

### Select2FormatResult

Ƭ **Select2FormatResult**: `string` \| `Element` \| `DocumentFragment`

#### Defined in

[src/ui/editors/select2.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L8)

___

### StringLiteral

Ƭ **StringLiteral**\<`T`\>: `T` extends `string` ? `string` extends `T` ? `never` : `T` : `never`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Defined in

[src/base/system-internal.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L23)

___

### TextColor

Ƭ **TextColor**: [`UtilityColor`](README.md#utilitycolor) \| ``"aqua"`` \| ``"blue"`` \| ``"fuschia"`` \| ``"gray"`` \| ``"green"`` \| ``"light-blue"`` \| ``"lime"`` \| ``"maroon"`` \| ``"navy"`` \| ``"olive"`` \| ``"orange"`` \| ``"purple"`` \| ``"red"`` \| ``"teal"`` \| ``"yellow"``

#### Defined in

[src/base/icons.ts:2](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L2)

___

### ToastContainerOptions

Ƭ **ToastContainerOptions**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `containerId?` | `string` |
| `positionClass?` | `string` |
| `target?` | `string` |

#### Defined in

[src/base/toastr2.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L4)

___

### ToastrOptions

Ƭ **ToastrOptions**: [`ToastContainerOptions`](README.md#toastcontaineroptions) & \{ `closeButton?`: `boolean` ; `closeClass?`: `string` ; `closeDuration?`: `number` \| ``false`` ; `closeEasing?`: `boolean` ; `closeHtml?`: `string` ; `closeMethod?`: `boolean` ; `closeOnHover?`: `boolean` ; `escapeHtml?`: `boolean` ; `extendedTimeOut?`: `number` ; `hideDuration?`: `number` ; `iconClass?`: `string` ; `messageClass?`: `string` ; `newestOnTop?`: `boolean` ; `onCloseClick?`: (`event`: `Event`) => `void` ; `onHidden?`: () => `void` ; `onShown?`: () => `void` ; `onclick?`: (`event`: `MouseEvent`) => `void` ; `positionClass?`: `string` ; `preventDuplicates?`: `boolean` ; `rtl?`: `boolean` ; `showDuration?`: `number` ; `tapToDismiss?`: `boolean` ; `target?`: `string` ; `timeOut?`: `number` ; `titleClass?`: `string` ; `toastClass?`: `string`  }

#### Defined in

[src/base/toastr2.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L10)

___

### Type

Ƭ **Type**: `Function` \| `Object`

#### Defined in

[src/base/system.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L17)

___

### TypeInfo

Ƭ **TypeInfo**\<`T`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `customAttributes?` | `any`[] |
| `enumFlags?` | `boolean` |
| `interfaces?` | `any`[] |
| `registered?` | `boolean` |
| `typeKind` | ``"class"`` \| ``"enum"`` \| ``"interface"`` \| ``"editor"`` \| ``"formatter"`` |
| `typeName` | [`StringLiteral`](README.md#stringliteral)\<`T`\> \| `string` & {} |

#### Defined in

[src/base/system-internal.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L25)

___

### UtilityColor

Ƭ **UtilityColor**: ``"primary"`` \| ``"secondary"`` \| ``"success"`` \| ``"danger"`` \| ``"warning"`` \| ``"info"`` \| ``"light"`` \| ``"dark"`` \| ``"muted"`` \| ``"white"``

#### Defined in

[src/base/icons.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L1)

___

### ValidateEventDelegate

Ƭ **ValidateEventDelegate**: (`element`: [`ValidatableElement`](interfaces/ValidatableElement.md), `event`: `Event`, `validator`: [`Validator`](classes/Validator.md)) => `void`

#### Type declaration

▸ (`element`, `event`, `validator`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](interfaces/ValidatableElement.md) |
| `event` | `Event` |
| `validator` | [`Validator`](classes/Validator.md) |

##### Returns

`void`

#### Defined in

[src/base/validator.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L52)

___

### ValidationErrorList

Ƭ **ValidationErrorList**: [`ValidationErrorItem`](interfaces/ValidationErrorItem.md)[]

#### Defined in

[src/base/validator.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L44)

___

### ValidationProvider

Ƭ **ValidationProvider**: (`value`: [`ValidationValue`](README.md#validationvalue), `element`: [`ValidatableElement`](interfaces/ValidatableElement.md), `params?`: `any`) => `boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>

Validation plugin signature with multitype return.
Boolean return signifies the validation result, which uses the default validation error message read from the element attribute.
String return signifies failed validation, which then will be used as the validation error message.
Promise return signifies asynchronous plugin behavior, with same behavior as Boolean or String.

#### Type declaration

▸ (`value`, `element`, `params?`): `boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`ValidationValue`](README.md#validationvalue) |
| `element` | [`ValidatableElement`](interfaces/ValidatableElement.md) |
| `params?` | `any` |

##### Returns

`boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>

#### Defined in

[src/base/validator.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L32)

___

### ValidationRules

Ƭ **ValidationRules**: `Record`\<`string`, `any`\>

#### Defined in

[src/base/validator.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L46)

___

### ValidationValue

Ƭ **ValidationValue**: `string` \| `string`[] \| `number` \| `boolean`

#### Defined in

[src/base/validator.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L24)

___

### WidgetProps

Ƭ **WidgetProps**\<`P`\>: \{ `class?`: `string` ; `element?`: (`el`: `HTMLElement`) => `void` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| `string` ; `id?`: `string`  } & [`NoInfer`](README.md#noinfer)\<`P`\>

#### Type parameters

| Name |
| :------ |
| `P` |

#### Defined in

[src/ui/widgets/widgetutils.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L123)

___

### faIconKey

Ƭ **faIconKey**: ``"ad"`` \| ``"address-book"`` \| ``"address-card"`` \| ``"adjust"`` \| ``"air-freshener"`` \| ``"align-center"`` \| ``"align-justify"`` \| ``"align-left"`` \| ``"align-right"`` \| ``"allergies"`` \| ``"ambulance"`` \| ``"american-sign-language-interpreting"`` \| ``"anchor"`` \| ``"angle-double-down"`` \| ``"angle-double-left"`` \| ``"angle-double-right"`` \| ``"angle-double-up"`` \| ``"angle-down"`` \| ``"angle-left"`` \| ``"angle-right"`` \| ``"angle-up"`` \| ``"angry"`` \| ``"ankh"`` \| ``"apple-alt"`` \| ``"archive"`` \| ``"archway"`` \| ``"arrow-alt-circle-down"`` \| ``"arrow-alt-circle-left"`` \| ``"arrow-alt-circle-right"`` \| ``"arrow-alt-circle-up"`` \| ``"arrow-circle-down"`` \| ``"arrow-circle-left"`` \| ``"arrow-circle-right"`` \| ``"arrow-circle-up"`` \| ``"arrow-down"`` \| ``"arrow-left"`` \| ``"arrow-right"`` \| ``"arrow-up"`` \| ``"arrows-alt"`` \| ``"arrows-alt-h"`` \| ``"arrows-alt-v"`` \| ``"assistive-listening-systems"`` \| ``"asterisk"`` \| ``"at"`` \| ``"atlas"`` \| ``"atom"`` \| ``"audio-description"`` \| ``"award"`` \| ``"baby"`` \| ``"baby-carriage"`` \| ``"backspace"`` \| ``"backward"`` \| ``"bacon"`` \| ``"balance-scale"`` \| ``"balance-scale-left"`` \| ``"balance-scale-right"`` \| ``"ban"`` \| ``"band-aid"`` \| ``"barcode"`` \| ``"bars"`` \| ``"baseball-ball"`` \| ``"basketball-ball"`` \| ``"bath"`` \| ``"battery-empty"`` \| ``"battery-full"`` \| ``"battery-half"`` \| ``"battery-quarter"`` \| ``"battery-three-quarters"`` \| ``"bed"`` \| ``"beer"`` \| ``"bell"`` \| ``"bell-o"`` \| ``"bell-slash"`` \| ``"bezier-curve"`` \| ``"bible"`` \| ``"bicycle"`` \| ``"biking"`` \| ``"binoculars"`` \| ``"biohazard"`` \| ``"birthday-cake"`` \| ``"blender"`` \| ``"blender-phone"`` \| ``"blind"`` \| ``"blog"`` \| ``"bold"`` \| ``"bolt"`` \| ``"bomb"`` \| ``"bone"`` \| ``"bong"`` \| ``"book"`` \| ``"book-dead"`` \| ``"book-medical"`` \| ``"book-open"`` \| ``"book-reader"`` \| ``"bookmark"`` \| ``"border-all"`` \| ``"border-none"`` \| ``"border-style"`` \| ``"bowling-ball"`` \| ``"box"`` \| ``"box-open"`` \| ``"boxes"`` \| ``"braille"`` \| ``"brain"`` \| ``"bread-slice"`` \| ``"briefcase"`` \| ``"briefcase-medical"`` \| ``"broadcast-tower"`` \| ``"broom"`` \| ``"brush"`` \| ``"bug"`` \| ``"building"`` \| ``"bullhorn"`` \| ``"bullseye"`` \| ``"burn"`` \| ``"bus"`` \| ``"bus-alt"`` \| ``"business-time"`` \| ``"calculator"`` \| ``"calendar"`` \| ``"calendar-alt"`` \| ``"calendar-check"`` \| ``"calendar-day"`` \| ``"calendar-minus"`` \| ``"calendar-plus"`` \| ``"calendar-times"`` \| ``"calendar-week"`` \| ``"camera"`` \| ``"camera-retro"`` \| ``"campground"`` \| ``"candy-cane"`` \| ``"cannabis"`` \| ``"capsules"`` \| ``"car"`` \| ``"car-alt"`` \| ``"car-battery"`` \| ``"car-crash"`` \| ``"car-side"`` \| ``"caret-down"`` \| ``"caret-left"`` \| ``"caret-right"`` \| ``"caret-square-down"`` \| ``"caret-square-left"`` \| ``"caret-square-right"`` \| ``"caret-square-up"`` \| ``"caret-up"`` \| ``"carrot"`` \| ``"cart-arrow-down"`` \| ``"cart-plus"`` \| ``"cash-register"`` \| ``"cat"`` \| ``"certificate"`` \| ``"chair"`` \| ``"chalkboard"`` \| ``"chalkboard-teacher"`` \| ``"charging-station"`` \| ``"chart-area"`` \| ``"chart-bar"`` \| ``"chart-line"`` \| ``"chart-pie"`` \| ``"check"`` \| ``"check-circle"`` \| ``"check-double"`` \| ``"check-square"`` \| ``"cheese"`` \| ``"chess"`` \| ``"chess-bishop"`` \| ``"chess-board"`` \| ``"chess-king"`` \| ``"chess-knight"`` \| ``"chess-pawn"`` \| ``"chess-queen"`` \| ``"chess-rook"`` \| ``"chevron-circle-down"`` \| ``"chevron-circle-left"`` \| ``"chevron-circle-right"`` \| ``"chevron-circle-up"`` \| ``"chevron-down"`` \| ``"chevron-left"`` \| ``"chevron-right"`` \| ``"chevron-up"`` \| ``"child"`` \| ``"church"`` \| ``"circle"`` \| ``"circle-notch"`` \| ``"city"`` \| ``"clinic-medical"`` \| ``"clipboard"`` \| ``"clipboard-check"`` \| ``"clipboard-list"`` \| ``"clock"`` \| ``"clock-o"`` \| ``"clone"`` \| ``"closed-captioning"`` \| ``"cloud"`` \| ``"cloud-download-alt"`` \| ``"cloud-meatball"`` \| ``"cloud-moon"`` \| ``"cloud-moon-rain"`` \| ``"cloud-rain"`` \| ``"cloud-showers-heavy"`` \| ``"cloud-sun"`` \| ``"cloud-sun-rain"`` \| ``"cloud-upload-alt"`` \| ``"cocktail"`` \| ``"code"`` \| ``"code-branch"`` \| ``"coffee"`` \| ``"cog"`` \| ``"cogs"`` \| ``"coins"`` \| ``"columns"`` \| ``"comment"`` \| ``"comment-alt"`` \| ``"comment-dollar"`` \| ``"comment-dots"`` \| ``"comment-medical"`` \| ``"comment-slash"`` \| ``"comments"`` \| ``"comments-dollar"`` \| ``"compact-disc"`` \| ``"compass"`` \| ``"compress"`` \| ``"compress-arrows-alt"`` \| ``"concierge-bell"`` \| ``"cookie"`` \| ``"cookie-bite"`` \| ``"copy"`` \| ``"copyright"`` \| ``"couch"`` \| ``"credit-card"`` \| ``"crop"`` \| ``"crop-alt"`` \| ``"cross"`` \| ``"crosshairs"`` \| ``"crow"`` \| ``"crown"`` \| ``"crutch"`` \| ``"cube"`` \| ``"cubes"`` \| ``"cut"`` \| ``"database"`` \| ``"deaf"`` \| ``"democrat"`` \| ``"desktop"`` \| ``"dharmachakra"`` \| ``"diagnoses"`` \| ``"dice"`` \| ``"dice-d20"`` \| ``"dice-d6"`` \| ``"dice-five"`` \| ``"dice-four"`` \| ``"dice-one"`` \| ``"dice-six"`` \| ``"dice-three"`` \| ``"dice-two"`` \| ``"digital-tachograph"`` \| ``"directions"`` \| ``"divide"`` \| ``"dizzy"`` \| ``"dna"`` \| ``"dog"`` \| ``"dollar-sign"`` \| ``"dolly"`` \| ``"dolly-flatbed"`` \| ``"donate"`` \| ``"door-closed"`` \| ``"door-open"`` \| ``"dot-circle"`` \| ``"dove"`` \| ``"download"`` \| ``"drafting-compass"`` \| ``"dragon"`` \| ``"draw-polygon"`` \| ``"drum"`` \| ``"drum-steelpan"`` \| ``"drumstick-bite"`` \| ``"dumbbell"`` \| ``"dumpster"`` \| ``"dumpster-fire"`` \| ``"dungeon"`` \| ``"edit"`` \| ``"egg"`` \| ``"eject"`` \| ``"ellipsis-h"`` \| ``"ellipsis-v"`` \| ``"envelope"`` \| ``"envelope-o"`` \| ``"envelope-open"`` \| ``"envelope-open-text"`` \| ``"envelope-square"`` \| ``"equals"`` \| ``"eraser"`` \| ``"ethernet"`` \| ``"euro-sign"`` \| ``"exchange-alt"`` \| ``"exclamation"`` \| ``"exclamation-circle"`` \| ``"exclamation-triangle"`` \| ``"expand"`` \| ``"expand-arrows-alt"`` \| ``"external-link-alt"`` \| ``"external-link-square-alt"`` \| ``"eye"`` \| ``"eye-dropper"`` \| ``"eye-slash"`` \| ``"fan"`` \| ``"fast-backward"`` \| ``"fast-forward"`` \| ``"fax"`` \| ``"feather"`` \| ``"feather-alt"`` \| ``"female"`` \| ``"fighter-jet"`` \| ``"file"`` \| ``"file-alt"`` \| ``"file-archive"`` \| ``"file-audio"`` \| ``"file-code"`` \| ``"file-contract"`` \| ``"file-csv"`` \| ``"file-download"`` \| ``"file-excel"`` \| ``"file-excel-o"`` \| ``"file-export"`` \| ``"file-image"`` \| ``"file-import"`` \| ``"file-invoice"`` \| ``"file-invoice-dollar"`` \| ``"file-medical"`` \| ``"file-medical-alt"`` \| ``"file-pdf"`` \| ``"file-pdf-o"`` \| ``"file-powerpoint"`` \| ``"file-prescription"`` \| ``"file-signature"`` \| ``"file-upload"`` \| ``"file-text"`` \| ``"file-text-o"`` \| ``"file-video"`` \| ``"file-word"`` \| ``"fill"`` \| ``"fill-drip"`` \| ``"film"`` \| ``"filter"`` \| ``"fingerprint"`` \| ``"fire"`` \| ``"floppy-o"`` \| ``"fire-alt"`` \| ``"fire-extinguisher"`` \| ``"first-aid"`` \| ``"fish"`` \| ``"fist-raised"`` \| ``"flag"`` \| ``"flag-checkered"`` \| ``"flag-usa"`` \| ``"flask"`` \| ``"flushed"`` \| ``"folder"`` \| ``"folder-minus"`` \| ``"folder-open"`` \| ``"folder-open-o"`` \| ``"folder-plus"`` \| ``"font"`` \| ``"football-ball"`` \| ``"forward"`` \| ``"frog"`` \| ``"frown"`` \| ``"frown-open"`` \| ``"funnel-dollar"`` \| ``"futbol"`` \| ``"gamepad"`` \| ``"gas-pump"`` \| ``"gavel"`` \| ``"gem"`` \| ``"genderless"`` \| ``"ghost"`` \| ``"gift"`` \| ``"gifts"`` \| ``"glass-cheers"`` \| ``"glass-martini"`` \| ``"glass-martini-alt"`` \| ``"glass-whiskey"`` \| ``"glasses"`` \| ``"globe"`` \| ``"globe-africa"`` \| ``"globe-americas"`` \| ``"globe-asia"`` \| ``"globe-europe"`` \| ``"golf-ball"`` \| ``"gopuram"`` \| ``"graduation-cap"`` \| ``"greater-than"`` \| ``"greater-than-equal"`` \| ``"grimace"`` \| ``"grin"`` \| ``"grin-alt"`` \| ``"grin-beam"`` \| ``"grin-beam-sweat"`` \| ``"grin-hearts"`` \| ``"grin-squint"`` \| ``"grin-squint-tears"`` \| ``"grin-stars"`` \| ``"grin-tears"`` \| ``"grin-tongue"`` \| ``"grin-tongue-squint"`` \| ``"grin-tongue-wink"`` \| ``"grin-wink"`` \| ``"grip-horizontal"`` \| ``"grip-lines"`` \| ``"grip-lines-vertical"`` \| ``"grip-vertical"`` \| ``"guitar"`` \| ``"h-square"`` \| ``"hamburger"`` \| ``"hammer"`` \| ``"hamsa"`` \| ``"hand-holding"`` \| ``"hand-holding-heart"`` \| ``"hand-holding-usd"`` \| ``"hand-lizard"`` \| ``"hand-middle-finger"`` \| ``"hand-paper"`` \| ``"hand-peace"`` \| ``"hand-point-down"`` \| ``"hand-point-left"`` \| ``"hand-point-right"`` \| ``"hand-point-up"`` \| ``"hand-pointer"`` \| ``"hand-rock"`` \| ``"hand-scissors"`` \| ``"hand-spock"`` \| ``"hands"`` \| ``"hands-helping"`` \| ``"handshake"`` \| ``"hanukiah"`` \| ``"hard-hat"`` \| ``"hashtag"`` \| ``"hat-cowboy"`` \| ``"hat-cowboy-side"`` \| ``"hat-wizard"`` \| ``"haykal"`` \| ``"hdd"`` \| ``"heading"`` \| ``"headphones"`` \| ``"headphones-alt"`` \| ``"headset"`` \| ``"heart"`` \| ``"heart-broken"`` \| ``"heartbeat"`` \| ``"helicopter"`` \| ``"highlighter"`` \| ``"hiking"`` \| ``"hippo"`` \| ``"history"`` \| ``"hockey-puck"`` \| ``"holly-berry"`` \| ``"home"`` \| ``"horse"`` \| ``"horse-head"`` \| ``"hospital"`` \| ``"hospital-alt"`` \| ``"hospital-symbol"`` \| ``"hot-tub"`` \| ``"hotdog"`` \| ``"hotel"`` \| ``"hourglass"`` \| ``"hourglass-end"`` \| ``"hourglass-half"`` \| ``"hourglass-start"`` \| ``"house-damage"`` \| ``"hryvnia"`` \| ``"i-cursor"`` \| ``"ice-cream"`` \| ``"icicles"`` \| ``"icons"`` \| ``"id-badge"`` \| ``"id-card"`` \| ``"id-card-alt"`` \| ``"igloo"`` \| ``"image"`` \| ``"images"`` \| ``"inbox"`` \| ``"indent"`` \| ``"industry"`` \| ``"infinity"`` \| ``"info"`` \| ``"info-circle"`` \| ``"italic"`` \| ``"jedi"`` \| ``"joint"`` \| ``"journal-whills"`` \| ``"kaaba"`` \| ``"key"`` \| ``"keyboard"`` \| ``"khanda"`` \| ``"kiss"`` \| ``"kiss-beam"`` \| ``"kiss-wink-heart"`` \| ``"kiwi-bird"`` \| ``"landmark"`` \| ``"language"`` \| ``"laptop"`` \| ``"laptop-code"`` \| ``"laptop-medical"`` \| ``"laugh"`` \| ``"laugh-beam"`` \| ``"laugh-squint"`` \| ``"laugh-wink"`` \| ``"layer-group"`` \| ``"leaf"`` \| ``"lemon"`` \| ``"less-than"`` \| ``"less-than-equal"`` \| ``"level-down-alt"`` \| ``"level-up-alt"`` \| ``"life-ring"`` \| ``"lightbulb"`` \| ``"link"`` \| ``"lira-sign"`` \| ``"list"`` \| ``"list-alt"`` \| ``"list-ol"`` \| ``"list-ul"`` \| ``"location-arrow"`` \| ``"lock"`` \| ``"lock-open"`` \| ``"long-arrow-alt-down"`` \| ``"long-arrow-alt-left"`` \| ``"long-arrow-alt-right"`` \| ``"long-arrow-alt-up"`` \| ``"low-vision"`` \| ``"luggage-cart"`` \| ``"magic"`` \| ``"magnet"`` \| ``"mail-bulk"`` \| ``"mail-forward"`` \| ``"mail-reply"`` \| ``"male"`` \| ``"map"`` \| ``"map-marked"`` \| ``"map-marked-alt"`` \| ``"map-marker"`` \| ``"map-marker-alt"`` \| ``"map-pin"`` \| ``"map-signs"`` \| ``"marker"`` \| ``"mars"`` \| ``"mars-double"`` \| ``"mars-stroke"`` \| ``"mars-stroke-h"`` \| ``"mars-stroke-v"`` \| ``"mask"`` \| ``"medal"`` \| ``"medkit"`` \| ``"meh"`` \| ``"meh-blank"`` \| ``"meh-rolling-eyes"`` \| ``"memory"`` \| ``"menorah"`` \| ``"mercury"`` \| ``"meteor"`` \| ``"microchip"`` \| ``"microphone"`` \| ``"microphone-alt"`` \| ``"microphone-alt-slash"`` \| ``"microphone-slash"`` \| ``"microscope"`` \| ``"minus"`` \| ``"minus-circle"`` \| ``"minus-square"`` \| ``"mitten"`` \| ``"mobile"`` \| ``"mobile-alt"`` \| ``"money-bill"`` \| ``"money-bill-alt"`` \| ``"money-bill-wave"`` \| ``"money-bill-wave-alt"`` \| ``"money-check"`` \| ``"money-check-alt"`` \| ``"monument"`` \| ``"moon"`` \| ``"mortar-pestle"`` \| ``"mosque"`` \| ``"motorcycle"`` \| ``"mountain"`` \| ``"mouse"`` \| ``"mouse-pointer"`` \| ``"mug-hot"`` \| ``"music"`` \| ``"network-wired"`` \| ``"neuter"`` \| ``"newspaper"`` \| ``"not-equal"`` \| ``"notes-medical"`` \| ``"object-group"`` \| ``"object-ungroup"`` \| ``"oil-can"`` \| ``"om"`` \| ``"otter"`` \| ``"outdent"`` \| ``"pager"`` \| ``"paint-brush"`` \| ``"paint-roller"`` \| ``"palette"`` \| ``"pallet"`` \| ``"paper-plane"`` \| ``"paperclip"`` \| ``"parachute-box"`` \| ``"paragraph"`` \| ``"parking"`` \| ``"passport"`` \| ``"pastafarianism"`` \| ``"paste"`` \| ``"pause"`` \| ``"pause-circle"`` \| ``"paw"`` \| ``"peace"`` \| ``"pen"`` \| ``"pen-alt"`` \| ``"pen-fancy"`` \| ``"pen-nib"`` \| ``"pen-square"`` \| ``"pencil-alt"`` \| ``"pencil-ruler"`` \| ``"pencil-square-o"`` \| ``"people-carry"`` \| ``"pepper-hot"`` \| ``"percent"`` \| ``"percentage"`` \| ``"person-booth"`` \| ``"phone"`` \| ``"phone-alt"`` \| ``"phone-slash"`` \| ``"phone-square"`` \| ``"phone-square-alt"`` \| ``"phone-volume"`` \| ``"photo-video"`` \| ``"piggy-bank"`` \| ``"pills"`` \| ``"pizza-slice"`` \| ``"place-of-worship"`` \| ``"plane"`` \| ``"plane-arrival"`` \| ``"plane-departure"`` \| ``"play"`` \| ``"play-circle"`` \| ``"plug"`` \| ``"plus"`` \| ``"plus-circle"`` \| ``"plus-square"`` \| ``"podcast"`` \| ``"poll"`` \| ``"poll-h"`` \| ``"poo"`` \| ``"poo-storm"`` \| ``"poop"`` \| ``"portrait"`` \| ``"pound-sign"`` \| ``"power-off"`` \| ``"pray"`` \| ``"praying-hands"`` \| ``"prescription"`` \| ``"prescription-bottle"`` \| ``"prescription-bottle-alt"`` \| ``"print"`` \| ``"procedures"`` \| ``"project-diagram"`` \| ``"puzzle-piece"`` \| ``"qrcode"`` \| ``"question"`` \| ``"question-circle"`` \| ``"quidditch"`` \| ``"quote-left"`` \| ``"quote-right"`` \| ``"quran"`` \| ``"radiation"`` \| ``"radiation-alt"`` \| ``"rainbow"`` \| ``"random"`` \| ``"receipt"`` \| ``"record-vinyl"`` \| ``"recycle"`` \| ``"redo"`` \| ``"refresh"`` \| ``"redo-alt"`` \| ``"registered"`` \| ``"remove-format"`` \| ``"reply"`` \| ``"reply-all"`` \| ``"republican"`` \| ``"restroom"`` \| ``"retweet"`` \| ``"ribbon"`` \| ``"ring"`` \| ``"road"`` \| ``"robot"`` \| ``"rocket"`` \| ``"route"`` \| ``"rss"`` \| ``"rss-square"`` \| ``"ruble-sign"`` \| ``"ruler"`` \| ``"ruler-combined"`` \| ``"ruler-horizontal"`` \| ``"ruler-vertical"`` \| ``"running"`` \| ``"rupee-sign"`` \| ``"sad-cry"`` \| ``"sad-tear"`` \| ``"satellite"`` \| ``"satellite-dish"`` \| ``"save"`` \| ``"school"`` \| ``"screwdriver"`` \| ``"scroll"`` \| ``"sd-card"`` \| ``"search"`` \| ``"search-dollar"`` \| ``"search-location"`` \| ``"search-minus"`` \| ``"search-plus"`` \| ``"seedling"`` \| ``"server"`` \| ``"shapes"`` \| ``"share"`` \| ``"share-alt"`` \| ``"share-alt-square"`` \| ``"share-square"`` \| ``"shekel-sign"`` \| ``"shield-alt"`` \| ``"ship"`` \| ``"shipping-fast"`` \| ``"shoe-prints"`` \| ``"shopping-bag"`` \| ``"shopping-basket"`` \| ``"shopping-cart"`` \| ``"shower"`` \| ``"shuttle-van"`` \| ``"sign"`` \| ``"sign-in-alt"`` \| ``"sign-language"`` \| ``"sign-out"`` \| ``"sign-out-alt"`` \| ``"signal"`` \| ``"signature"`` \| ``"sim-card"`` \| ``"sitemap"`` \| ``"skating"`` \| ``"skiing"`` \| ``"skiing-nordic"`` \| ``"skull"`` \| ``"skull-crossbones"`` \| ``"slash"`` \| ``"sleigh"`` \| ``"sliders-h"`` \| ``"smile"`` \| ``"smile-beam"`` \| ``"smile-wink"`` \| ``"smog"`` \| ``"smoking"`` \| ``"smoking-ban"`` \| ``"sms"`` \| ``"snowboarding"`` \| ``"snowflake"`` \| ``"snowman"`` \| ``"snowplow"`` \| ``"socks"`` \| ``"solar-panel"`` \| ``"sort"`` \| ``"sort-alpha-down"`` \| ``"sort-alpha-down-alt"`` \| ``"sort-alpha-up"`` \| ``"sort-alpha-up-alt"`` \| ``"sort-amount-down"`` \| ``"sort-amount-down-alt"`` \| ``"sort-amount-up"`` \| ``"sort-amount-up-alt"`` \| ``"sort-down"`` \| ``"sort-numeric-down"`` \| ``"sort-numeric-down-alt"`` \| ``"sort-numeric-up"`` \| ``"sort-numeric-up-alt"`` \| ``"sort-up"`` \| ``"spa"`` \| ``"space-shuttle"`` \| ``"spell-check"`` \| ``"spider"`` \| ``"spinner"`` \| ``"splotch"`` \| ``"spray-can"`` \| ``"square"`` \| ``"square-full"`` \| ``"square-root-alt"`` \| ``"stamp"`` \| ``"star"`` \| ``"star-and-crescent"`` \| ``"star-half"`` \| ``"star-half-alt"`` \| ``"star-o"`` \| ``"star-of-david"`` \| ``"star-of-life"`` \| ``"step-backward"`` \| ``"step-forward"`` \| ``"stethoscope"`` \| ``"sticky-note"`` \| ``"stop"`` \| ``"stop-circle"`` \| ``"stopwatch"`` \| ``"store"`` \| ``"store-alt"`` \| ``"stream"`` \| ``"street-view"`` \| ``"strikethrough"`` \| ``"stroopwafel"`` \| ``"subscript"`` \| ``"subway"`` \| ``"suitcase"`` \| ``"suitcase-rolling"`` \| ``"sun"`` \| ``"superscript"`` \| ``"surprise"`` \| ``"swatchbook"`` \| ``"swimmer"`` \| ``"swimming-pool"`` \| ``"synagogue"`` \| ``"sync"`` \| ``"sync-alt"`` \| ``"syringe"`` \| ``"table"`` \| ``"table-tennis"`` \| ``"tablet"`` \| ``"tablet-alt"`` \| ``"tablets"`` \| ``"tachometer-alt"`` \| ``"tag"`` \| ``"tags"`` \| ``"tape"`` \| ``"tasks"`` \| ``"taxi"`` \| ``"teeth"`` \| ``"teeth-open"`` \| ``"temperature-high"`` \| ``"temperature-low"`` \| ``"tenge"`` \| ``"terminal"`` \| ``"text-height"`` \| ``"text-width"`` \| ``"th"`` \| ``"th-large"`` \| ``"th-list"`` \| ``"theater-masks"`` \| ``"thermometer"`` \| ``"thermometer-empty"`` \| ``"thermometer-full"`` \| ``"thermometer-half"`` \| ``"thermometer-quarter"`` \| ``"thermometer-three-quarters"`` \| ``"thumbs-down"`` \| ``"thumbs-up"`` \| ``"thumbtack"`` \| ``"ticket-alt"`` \| ``"times"`` \| ``"times-circle"`` \| ``"tint"`` \| ``"tint-slash"`` \| ``"tired"`` \| ``"toggle-off"`` \| ``"toggle-on"`` \| ``"toilet"`` \| ``"toilet-paper"`` \| ``"toolbox"`` \| ``"tools"`` \| ``"tooth"`` \| ``"torah"`` \| ``"torii-gate"`` \| ``"tractor"`` \| ``"trademark"`` \| ``"traffic-light"`` \| ``"train"`` \| ``"tram"`` \| ``"transgender"`` \| ``"transgender-alt"`` \| ``"trash"`` \| ``"trash-alt"`` \| ``"trash-o"`` \| ``"trash-restore"`` \| ``"trash-restore-alt"`` \| ``"tree"`` \| ``"trophy"`` \| ``"truck"`` \| ``"truck-loading"`` \| ``"truck-monster"`` \| ``"truck-moving"`` \| ``"truck-pickup"`` \| ``"tshirt"`` \| ``"tty"`` \| ``"tv"`` \| ``"umbrella"`` \| ``"umbrella-beach"`` \| ``"underline"`` \| ``"undo"`` \| ``"undo-alt"`` \| ``"universal-access"`` \| ``"university"`` \| ``"unlink"`` \| ``"unlock"`` \| ``"unlock-alt"`` \| ``"upload"`` \| ``"user"`` \| ``"user-alt"`` \| ``"user-alt-slash"`` \| ``"user-astronaut"`` \| ``"user-check"`` \| ``"user-circle"`` \| ``"user-clock"`` \| ``"user-cog"`` \| ``"user-edit"`` \| ``"user-friends"`` \| ``"user-graduate"`` \| ``"user-injured"`` \| ``"user-lock"`` \| ``"user-md"`` \| ``"user-minus"`` \| ``"user-ninja"`` \| ``"user-nurse"`` \| ``"user-plus"`` \| ``"user-secret"`` \| ``"user-shield"`` \| ``"user-slash"`` \| ``"user-tag"`` \| ``"user-tie"`` \| ``"user-times"`` \| ``"users"`` \| ``"users-cog"`` \| ``"utensil-spoon"`` \| ``"utensils"`` \| ``"vector-square"`` \| ``"venus"`` \| ``"venus-double"`` \| ``"venus-mars"`` \| ``"vial"`` \| ``"vials"`` \| ``"video"`` \| ``"video-slash"`` \| ``"vihara"`` \| ``"voicemail"`` \| ``"volleyball-ball"`` \| ``"volume-down"`` \| ``"volume-mute"`` \| ``"volume-off"`` \| ``"volume-up"`` \| ``"vote-yea"`` \| ``"vr-cardboard"`` \| ``"walking"`` \| ``"wallet"`` \| ``"warehouse"`` \| ``"water"`` \| ``"wave-square"`` \| ``"weight"`` \| ``"weight-hanging"`` \| ``"wheelchair"`` \| ``"wifi"`` \| ``"wind"`` \| ``"window-close"`` \| ``"window-maximize"`` \| ``"window-minimize"`` \| ``"window-restore"`` \| ``"wine-bottle"`` \| ``"wine-glass"`` \| ``"wine-glass-alt"`` \| ``"won-sign"`` \| ``"wrench"`` \| ``"x-ray"`` \| ``"yen-sign"`` \| ``"yin-yang"``

#### Defined in

[src/base/icons.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L41)

___

### fabIconKey

Ƭ **fabIconKey**: ``"500px"`` \| ``"accessible-icon"`` \| ``"accusoft"`` \| ``"acquisitions-incorporated"`` \| ``"adn"`` \| ``"adobe"`` \| ``"adversal"`` \| ``"affiliatetheme"`` \| ``"airbnb"`` \| ``"algolia"`` \| ``"alipay"`` \| ``"amazon"`` \| ``"amazon-pay"`` \| ``"amilia"`` \| ``"android"`` \| ``"angellist"`` \| ``"angrycreative"`` \| ``"angular"`` \| ``"app-store"`` \| ``"app-store-ios"`` \| ``"apper"`` \| ``"apple"`` \| ``"apple-pay"`` \| ``"artstation"`` \| ``"asymmetrik"`` \| ``"atlassian"`` \| ``"audible"`` \| ``"autoprefixer"`` \| ``"avianex"`` \| ``"aviato"`` \| ``"aws"`` \| ``"bandcamp"`` \| ``"battle-net"`` \| ``"behance"`` \| ``"behance-square"`` \| ``"bimobject"`` \| ``"bitbucket"`` \| ``"bitcoin"`` \| ``"bity"`` \| ``"black-tie"`` \| ``"blackberry"`` \| ``"blogger"`` \| ``"blogger-b"`` \| ``"bluetooth"`` \| ``"bluetooth-b"`` \| ``"bootstrap"`` \| ``"btc"`` \| ``"buffer"`` \| ``"buromobelexperte"`` \| ``"buy-n-large"`` \| ``"buysellads"`` \| ``"canadian-maple-leaf"`` \| ``"cc-amazon-pay"`` \| ``"cc-amex"`` \| ``"cc-apple-pay"`` \| ``"cc-diners-club"`` \| ``"cc-discover"`` \| ``"cc-jcb"`` \| ``"cc-mastercard"`` \| ``"cc-paypal"`` \| ``"cc-stripe"`` \| ``"cc-visa"`` \| ``"centercode"`` \| ``"centos"`` \| ``"chrome"`` \| ``"chromecast"`` \| ``"cloudscale"`` \| ``"cloudsmith"`` \| ``"cloudversify"`` \| ``"codepen"`` \| ``"codiepie"`` \| ``"confluence"`` \| ``"connectdevelop"`` \| ``"contao"`` \| ``"cotton-bureau"`` \| ``"cpanel"`` \| ``"creative-commons"`` \| ``"creative-commons-by"`` \| ``"creative-commons-nc"`` \| ``"creative-commons-nc-eu"`` \| ``"creative-commons-nc-jp"`` \| ``"creative-commons-nd"`` \| ``"creative-commons-pd"`` \| ``"creative-commons-pd-alt"`` \| ``"creative-commons-remix"`` \| ``"creative-commons-sa"`` \| ``"creative-commons-sampling"`` \| ``"creative-commons-sampling-plus"`` \| ``"creative-commons-share"`` \| ``"creative-commons-zero"`` \| ``"critical-role"`` \| ``"css3"`` \| ``"css3-alt"`` \| ``"cuttlefish"`` \| ``"d-and-d"`` \| ``"d-and-d-beyond"`` \| ``"dashcube"`` \| ``"delicious"`` \| ``"deploydog"`` \| ``"deskpro"`` \| ``"dev"`` \| ``"deviantart"`` \| ``"dhl"`` \| ``"diaspora"`` \| ``"digg"`` \| ``"digital-ocean"`` \| ``"discord"`` \| ``"discourse"`` \| ``"dochub"`` \| ``"docker"`` \| ``"draft2digital"`` \| ``"dribbble"`` \| ``"dribbble-square"`` \| ``"dropbox"`` \| ``"drupal"`` \| ``"dyalog"`` \| ``"earlybirds"`` \| ``"ebay"`` \| ``"edge"`` \| ``"elementor"`` \| ``"ello"`` \| ``"ember"`` \| ``"empire"`` \| ``"envira"`` \| ``"erlang"`` \| ``"ethereum"`` \| ``"etsy"`` \| ``"evernote"`` \| ``"expeditedssl"`` \| ``"facebook"`` \| ``"facebook-f"`` \| ``"facebook-messenger"`` \| ``"facebook-square"`` \| ``"fantasy-flight-games"`` \| ``"fedex"`` \| ``"fedora"`` \| ``"figma"`` \| ``"firefox"`` \| ``"first-order"`` \| ``"first-order-alt"`` \| ``"firstdraft"`` \| ``"flickr"`` \| ``"flipboard"`` \| ``"fly"`` \| ``"font-awesome"`` \| ``"font-awesome-alt"`` \| ``"font-awesome-flag"`` \| ``"fonticons"`` \| ``"fonticons-fi"`` \| ``"fort-awesome"`` \| ``"fort-awesome-alt"`` \| ``"forumbee"`` \| ``"foursquare"`` \| ``"free-code-camp"`` \| ``"freebsd"`` \| ``"fulcrum"`` \| ``"galactic-republic"`` \| ``"galactic-senate"`` \| ``"get-pocket"`` \| ``"gg"`` \| ``"gg-circle"`` \| ``"git"`` \| ``"git-alt"`` \| ``"git-square"`` \| ``"github"`` \| ``"github-alt"`` \| ``"github-square"`` \| ``"gitkraken"`` \| ``"gitlab"`` \| ``"gitter"`` \| ``"glide"`` \| ``"glide-g"`` \| ``"gofore"`` \| ``"goodreads"`` \| ``"goodreads-g"`` \| ``"google"`` \| ``"google-drive"`` \| ``"google-play"`` \| ``"google-plus"`` \| ``"google-plus-g"`` \| ``"google-plus-square"`` \| ``"google-wallet"`` \| ``"gratipay"`` \| ``"grav"`` \| ``"gripfire"`` \| ``"grunt"`` \| ``"gulp"`` \| ``"hacker-news"`` \| ``"hacker-news-square"`` \| ``"hackerrank"`` \| ``"hips"`` \| ``"hire-a-helper"`` \| ``"hooli"`` \| ``"hornbill"`` \| ``"hotjar"`` \| ``"houzz"`` \| ``"html5"`` \| ``"hubspot"`` \| ``"imdb"`` \| ``"instagram"`` \| ``"intercom"`` \| ``"internet-explorer"`` \| ``"invision"`` \| ``"ioxhost"`` \| ``"itch-io"`` \| ``"itunes"`` \| ``"itunes-note"`` \| ``"java"`` \| ``"jedi-order"`` \| ``"jenkins"`` \| ``"jira"`` \| ``"joget"`` \| ``"joomla"`` \| ``"js"`` \| ``"js-square"`` \| ``"jsfiddle"`` \| ``"kaggle"`` \| ``"keybase"`` \| ``"keycdn"`` \| ``"kickstarter"`` \| ``"kickstarter-k"`` \| ``"korvue"`` \| ``"laravel"`` \| ``"lastfm"`` \| ``"lastfm-square"`` \| ``"leanpub"`` \| ``"less"`` \| ``"line"`` \| ``"linkedin"`` \| ``"linkedin-in"`` \| ``"linode"`` \| ``"linux"`` \| ``"lyft"`` \| ``"magento"`` \| ``"mailchimp"`` \| ``"mandalorian"`` \| ``"markdown"`` \| ``"mastodon"`` \| ``"maxcdn"`` \| ``"mdb"`` \| ``"medapps"`` \| ``"medium"`` \| ``"medium-m"`` \| ``"medrt"`` \| ``"meetup"`` \| ``"megaport"`` \| ``"mendeley"`` \| ``"microsoft"`` \| ``"mix"`` \| ``"mixcloud"`` \| ``"mizuni"`` \| ``"modx"`` \| ``"monero"`` \| ``"napster"`` \| ``"neos"`` \| ``"nimblr"`` \| ``"node"`` \| ``"node-js"`` \| ``"npm"`` \| ``"ns8"`` \| ``"nutritionix"`` \| ``"odnoklassniki"`` \| ``"odnoklassniki-square"`` \| ``"old-republic"`` \| ``"opencart"`` \| ``"openid"`` \| ``"opera"`` \| ``"optin-monster"`` \| ``"orcid"`` \| ``"osi"`` \| ``"page4"`` \| ``"pagelines"`` \| ``"palfed"`` \| ``"patreon"`` \| ``"paypal"`` \| ``"penny-arcade"`` \| ``"periscope"`` \| ``"phabricator"`` \| ``"phoenix-framework"`` \| ``"phoenix-squadron"`` \| ``"php"`` \| ``"pied-piper"`` \| ``"pied-piper-alt"`` \| ``"pied-piper-hat"`` \| ``"pied-piper-pp"`` \| ``"pinterest"`` \| ``"pinterest-p"`` \| ``"pinterest-square"`` \| ``"playstation"`` \| ``"product-hunt"`` \| ``"pushed"`` \| ``"python"`` \| ``"qq"`` \| ``"quinscape"`` \| ``"quora"`` \| ``"r-project"`` \| ``"raspberry-pi"`` \| ``"ravelry"`` \| ``"react"`` \| ``"reacteurope"`` \| ``"readme"`` \| ``"rebel"`` \| ``"red-river"`` \| ``"reddit"`` \| ``"reddit-alien"`` \| ``"reddit-square"`` \| ``"redhat"`` \| ``"renren"`` \| ``"replyd"`` \| ``"researchgate"`` \| ``"resolving"`` \| ``"rev"`` \| ``"rocketchat"`` \| ``"rockrms"`` \| ``"safari"`` \| ``"salesforce"`` \| ``"sass"`` \| ``"schlix"`` \| ``"scribd"`` \| ``"searchengin"`` \| ``"sellcast"`` \| ``"sellsy"`` \| ``"servicestack"`` \| ``"shirtsinbulk"`` \| ``"shopware"`` \| ``"simplybuilt"`` \| ``"sistrix"`` \| ``"sith"`` \| ``"sketch"`` \| ``"skyatlas"`` \| ``"skype"`` \| ``"slack"`` \| ``"slack-hash"`` \| ``"slideshare"`` \| ``"snapchat"`` \| ``"snapchat-ghost"`` \| ``"snapchat-square"`` \| ``"soundcloud"`` \| ``"sourcetree"`` \| ``"speakap"`` \| ``"speaker-deck"`` \| ``"spotify"`` \| ``"squarespace"`` \| ``"stack-exchange"`` \| ``"stack-overflow"`` \| ``"stackpath"`` \| ``"staylinked"`` \| ``"steam"`` \| ``"steam-square"`` \| ``"steam-symbol"`` \| ``"sticker-mule"`` \| ``"strava"`` \| ``"stripe"`` \| ``"stripe-s"`` \| ``"studiovinari"`` \| ``"stumbleupon"`` \| ``"stumbleupon-circle"`` \| ``"superpowers"`` \| ``"supple"`` \| ``"suse"`` \| ``"swift"`` \| ``"symfony"`` \| ``"teamspeak"`` \| ``"telegram"`` \| ``"telegram-plane"`` \| ``"tencent-weibo"`` \| ``"the-red-yeti"`` \| ``"themeco"`` \| ``"themeisle"`` \| ``"think-peaks"`` \| ``"trade-federation"`` \| ``"trello"`` \| ``"tripadvisor"`` \| ``"tumblr"`` \| ``"tumblr-square"`` \| ``"twitch"`` \| ``"twitter"`` \| ``"twitter-square"`` \| ``"typo3"`` \| ``"uber"`` \| ``"ubuntu"`` \| ``"uikit"`` \| ``"umbraco"`` \| ``"uniregistry"`` \| ``"untappd"`` \| ``"ups"`` \| ``"usb"`` \| ``"usps"`` \| ``"ussunnah"`` \| ``"vaadin"`` \| ``"viacoin"`` \| ``"viadeo"`` \| ``"viadeo-square"`` \| ``"viber"`` \| ``"vimeo"`` \| ``"vimeo-square"`` \| ``"vimeo-v"`` \| ``"vine"`` \| ``"vk"`` \| ``"vnv"`` \| ``"vuejs"`` \| ``"waze"`` \| ``"weebly"`` \| ``"weibo"`` \| ``"weixin"`` \| ``"whatsapp"`` \| ``"whatsapp-square"`` \| ``"whmcs"`` \| ``"wikipedia-w"`` \| ``"windows"`` \| ``"wix"`` \| ``"wizards-of-the-coast"`` \| ``"wolf-pack-battalion"`` \| ``"wordpress"`` \| ``"wordpress-simple"`` \| ``"wpbeginner"`` \| ``"wpexplorer"`` \| ``"wpforms"`` \| ``"wpressr"`` \| ``"xbox"`` \| ``"xing"`` \| ``"xing-square"`` \| ``"y-combinator"`` \| ``"yahoo"`` \| ``"yammer"`` \| ``"yandex"`` \| ``"yandex-international"`` \| ``"yarn"`` \| ``"yelp"`` \| ``"yoast"`` \| ``"youtube"`` \| ``"youtube-square"`` \| ``"zhihu"``

#### Defined in

[src/base/icons.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L142)

## Variables

### Config

• **Config**: `Object`

#### Type declaration

| Name | Type | Description |
| :------ | :------ | :------ |
| `applicationPath` | `string` | This is the root path of your application. If your application resides under http://localhost/mysite/, your root path is "/mysite/". This variable is automatically initialized by reading from a <link> element with ID "ApplicationPath" from current page, which is usually located in your _LayoutHead.cshtml file |
| `emailAllowOnlyAscii` | `boolean` | Email validation by default only allows ASCII characters. Set this to true if you want to allow unicode. |
| `notLoggedInHandler` | `Function` | This is an optional method for handling when user is not logged in. If a users session is expired and when a NotAuthorized response is received from a service call, Serenity will call this handler, so you may intercept it and notify user about this situation and ask if she wants to login again... |
| `rootNamespaces` | `string`[] | This is the list of root namespaces that may be searched for types. For example, if you specify an editor type of "MyEditor", first a class with name "MyEditor" will be searched, if not found, search will be followed by "Serenity.MyEditor" and "MyApp.MyEditor" if you added "MyApp" to the list of root namespaces. You should usually add your application root namespace to this list in ScriptInit(ialization).ts file. |

#### Defined in

[src/base/config.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/config.ts#L1)

___

### Culture

• **Culture**: [`Locale`](interfaces/Locale.md)

Current culture, e.g. CultureInfo.CurrentCulture. This is overridden by
settings passed from a `<script>` element in the page with id `ScriptCulture`
containing a JSON object if available. This element is generally created in 
the _LayoutHead.cshtml file for Serenity applications, so that the culture
settings determined server, can be passed to the client.

#### Defined in

[src/base/formatting.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L130)

___

### Invariant

• **Invariant**: [`Locale`](interfaces/Locale.md)

Invariant locale (e.g. CultureInfo.InvariantCulture)

#### Defined in

[src/base/formatting.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L62)

___

### defaultNotifyOptions

• **defaultNotifyOptions**: [`ToastrOptions`](README.md#toastroptions)

#### Defined in

[src/base/notify.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L3)

___

### typeInfoProperty

• `Const` **typeInfoProperty**: ``"typeInfo"``

#### Defined in

[src/base/system-internal.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L3)

## Functions

### Criteria

▸ **Criteria**(`field`): [`CriteriaBuilder`](classes/CriteriaBuilder.md)

Creates a new criteria builder containg the passed field name.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `field` | `string` | The field name. |

#### Returns

[`CriteriaBuilder`](classes/CriteriaBuilder.md)

#### Defined in

[src/base/criteria.ts:750](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L750)

___

### Fluent

▸ **Fluent**\<`K`\>(`tag`): [`Fluent`](interfaces/Fluent.md)\<`HTMLElementTagNameMap`[`K`]\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementTagNameMap` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `tag` | `K` |

#### Returns

[`Fluent`](interfaces/Fluent.md)\<`HTMLElementTagNameMap`[`K`]\>

#### Defined in

[src/base/fluent.ts:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L408)

▸ **Fluent**\<`TElement`\>(`element`): [`Fluent`](interfaces/Fluent.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `TElement` |

#### Returns

[`Fluent`](interfaces/Fluent.md)\<`TElement`\>

#### Defined in

[src/base/fluent.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L409)

▸ **Fluent**(`element`): [`Fluent`](interfaces/Fluent.md)\<`HTMLElement`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |

#### Returns

[`Fluent`](interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/base/fluent.ts:410](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L410)

___

### GridPageInit

▸ **GridPageInit**\<`TGrid`, `P`\>(`«destructured»`): `HTMLElement`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TGrid` | extends [`Widget`](classes/Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | `Object` |
| › `props?` | [`WidgetProps`](README.md#widgetprops)\<`P`\> |
| › `type` | (`options?`: `P`) => `TGrid` |
| › `type.prototype` | `TGrid` |

#### Returns

`HTMLElement`

#### Defined in

[src/q/layout.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L38)

___

### PanelPageInit

▸ **PanelPageInit**\<`TPanel`, `P`\>(`«destructured»`): `HTMLElement`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TPanel` | extends [`Widget`](classes/Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | `Object` |
| › `props?` | [`WidgetProps`](README.md#widgetprops)\<`P`\> |
| › `type` | (`options?`: `P`) => `TPanel` |
| › `type.prototype` | `TPanel` |

#### Returns

`HTMLElement`

#### Defined in

[src/q/layout.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L42)

___

### ToolbarButton

▸ **ToolbarButton**(`tb`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tb` | [`ToolButtonProps`](interfaces/ToolButtonProps.md) |

#### Returns

`HTMLElement`

#### Defined in

[src/ui/widgets/toolbar.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L28)

___

### addClass

▸ **addClass**(`el`, `cls`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `Element` |
| `cls` | `string` |

#### Returns

`void`

#### Defined in

[src/base/html.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L48)

___

### addCustomAttribute

▸ **addCustomAttribute**(`type`, `attr`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `attr` | `any` |

#### Returns

`void`

#### Defined in

[src/base/system.ts:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L229)

___

### addEmptyOption

▸ **addEmptyOption**(`select`): `void`

Adds an empty option to the select.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `select` | `HTMLSelectElement` \| `ArrayLike`\<`HTMLElement`\> | the select element |

#### Returns

`void`

#### Defined in

[src/q/html-compat.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L7)

___

### addLocalText

▸ **addLocalText**(`obj`, `pre?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `obj` | `string` \| `Record`\<`string`, `string` \| `Record`\<`string`, `any`\>\> |
| `pre?` | `string` |

#### Returns

`void`

#### Defined in

[src/base/localtext.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L11)

___

### addOption

▸ **addOption**(`select`, `key`, `text`): `void`

Adds an option to the select.

#### Parameters

| Name | Type |
| :------ | :------ |
| `select` | `HTMLSelectElement` \| `ArrayLike`\<`HTMLElement`\> |
| `key` | `string` |
| `text` | `string` |

#### Returns

`void`

#### Defined in

[src/q/html-compat.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L14)

___

### addTypeMember

▸ **addTypeMember**(`type`, `member`): [`TypeMember`](interfaces/TypeMember.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `member` | [`TypeMember`](interfaces/TypeMember.md) |

#### Returns

[`TypeMember`](interfaces/TypeMember.md)

#### Defined in

[src/q/system-compat.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L119)

___

### addValidationRule

▸ **addValidationRule**(`element`, `rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `rule` | (`input`: [`ValidatableElement`](interfaces/ValidatableElement.md)) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1669](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1669)

___

### alert

▸ **alert**(`message`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`Deprecated`**

use alertDialog

#### Defined in

[src/q/dialogs-compat.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L4)

___

### alertDialog

▸ **alertDialog**(`message`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

Displays an alert dialog

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) | Additional options. |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`See`**

AlertOptions

**`Example`**

```ts
alertDialog("An error occured!"); }
```

#### Defined in

[src/base/dialogs.ts:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L805)

___

### any

▸ **any**\<`TItem`\>(`array`, `predicate`): `boolean`

Tests if any of array elements matches given predicate. Prefer Array.some() over this function (e.g. `[1, 2, 3].some(predicate)`).

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `array` | `TItem`[] | Array to test. |
| `predicate` | (`x`: `TItem`) => `boolean` | Predicate to test elements. |

#### Returns

`boolean`

True if any element matches.

#### Defined in

[src/q/arrays-compat.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L7)

___

### appendChild

▸ **appendChild**(`child`, `node`): `void`

Appends child at first argument to given node at second argument. 
From https://github.com/alex-kinokon/jsx-dom.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `child` | `any` | Child element or elements |
| `node` | `HTMLElement` | Target parent element |

#### Returns

`void`

#### Defined in

[src/q/html-compat.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L102)

___

### associateWidget

▸ **associateWidget**(`widget`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | `Object` |
| `widget.domNode` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/widgetutils.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L9)

___

### attrEncode

▸ **attrEncode**(`s`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `any` |

#### Returns

`string`

**`Deprecated`**

use htmlEncode as it also encodes quotes

#### Defined in

[src/q/html-compat.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L22)

___

### bgColor

▸ **bgColor**(`color`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `color` | [`UtilityColor`](README.md#utilitycolor) |

#### Returns

`string`

#### Defined in

[src/base/icons.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L4)

___

### blockUI

▸ **blockUI**(`options?`): `void`

Tries to block the page

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | `Object` |
| `options.useTimeout?` | `boolean` |
| `options.zIndex?` | `number` |

#### Returns

`void`

#### Defined in

[src/base/blockui.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/blockui.ts#L6)

___

### blockUndo

▸ **blockUndo**(): `void`

Unblocks the page.

#### Returns

`void`

#### Defined in

[src/base/blockui.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/blockui.ts#L25)

___

### canLoadScriptData

▸ **canLoadScriptData**(`name`): `boolean`

Check if a dynamic script with provided name is available in the cache
or it is a registered script name

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | Dynamic script name |

#### Returns

`boolean`

True if already available or registered

#### Defined in

[src/q/scriptdata-compat.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L78)

___

### cancelDialogButton

▸ **cancelDialogButton**(`opt?`): [`DialogButton`](interfaces/DialogButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt?` | [`DialogButton`](interfaces/DialogButton.md) |

#### Returns

[`DialogButton`](interfaces/DialogButton.md)

#### Defined in

[src/base/dialogs.ts:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L580)

___

### cast

▸ **cast**(`instance`, `type`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `instance` | `any` |
| `type` | [`Type`](README.md#type) |

#### Returns

`any`

#### Defined in

[src/q/system-compat.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L189)

___

### centerDialog

▸ **centerDialog**(`el`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L152)

___

### classTypeInfo

▸ **classTypeInfo**\<`T`\>(`typeName`, `interfaces?`): [`ClassTypeInfo`](README.md#classtypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`ClassTypeInfo`](README.md#classtypeinfo)\<`T`\>

#### Defined in

[src/base/system.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L284)

___

### clearKeys

▸ **clearKeys**(`d`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `d` | `any` |

#### Returns

`void`

#### Defined in

[src/q/system-compat.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L178)

___

### clearOptions

▸ **clearOptions**(`select`): `void`

Clears the options in the select element

#### Parameters

| Name | Type |
| :------ | :------ |
| `select` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/q/html-compat.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L25)

___

### coalesce

▸ **coalesce**(`a`, `b`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `any` |
| `b` | `any` |

#### Returns

`any`

**`Deprecated`**

Use ?? operator

#### Defined in

[src/q/system-compat.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L6)

___

### compareStringFactory

▸ **compareStringFactory**(`order`): (`a`: `string`, `b`: `string`) => `number`

Factory for a function that compares two strings, based on a character order 
passed in the `order` argument.

#### Parameters

| Name | Type |
| :------ | :------ |
| `order` | `string` |

#### Returns

`fn`

▸ (`a`, `b`): `number`

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |
| `b` | `string` |

##### Returns

`number`

#### Defined in

[src/base/formatting.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L90)

___

### confirm

▸ **confirm**(`message`, `onYes`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `onYes` | () => `void` |
| `options?` | [`ConfirmDialogOptions`](interfaces/ConfirmDialogOptions.md) |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`Deprecated`**

use confirmDialog

#### Defined in

[src/q/dialogs-compat.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L7)

___

### confirmDialog

▸ **confirmDialog**(`message`, `onYes`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

Display a confirmation dialog

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `onYes` | () => `void` | Callback for Yes button click |
| `options?` | [`ConfirmDialogOptions`](interfaces/ConfirmDialogOptions.md) | Additional options. |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`See`**

ConfirmOptions

**`Example`**

```ts
confirmDialog("Are you sure you want to delete?", () => { 
    // do something when yes is clicked
}
```

#### Defined in

[src/base/dialogs.ts:840](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L840)

___

### count

▸ **count**\<`TItem`\>(`array`, `predicate`): `number`

Counts number of array elements that matches a given predicate.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `array` | `TItem`[] | Array to test. |
| `predicate` | (`x`: `TItem`) => `boolean` | Predicate to test elements. |

#### Returns

`number`

#### Defined in

[src/q/arrays-compat.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L16)

___

### dbText

▸ **dbText**(`prefix`): (`key`: `string`) => `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `prefix` | `string` |

#### Returns

`fn`

▸ (`key`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

##### Returns

`string`

#### Defined in

[src/q/localtext-compat.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext-compat.ts#L6)

___

### dbTryText

▸ **dbTryText**(`prefix`): (`key`: `string`) => `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `prefix` | `string` |

#### Returns

`fn`

▸ (`key`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

##### Returns

`string`

#### Defined in

[src/q/localtext-compat.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext-compat.ts#L39)

___

### deassociateWidget

▸ **deassociateWidget**(`widget`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | `Object` |
| `widget.domNode` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/widgetutils.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L28)

___

### debounce

▸ **debounce**\<`T`\>(`func`, `wait?`, `immediate?`): [`DebouncedFunction`](interfaces/DebouncedFunction.md)\<`T`\>

Returns a function, that, as long as it continues to be invoked, will not
be triggered. The function also has a property 'clear' that can be used 
to clear the timer to prevent previously scheduled executions, and flush method
to invoke scheduled executions now if any.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends (...`args`: `any`) => `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `func` | `T` | - |
| `wait?` | `number` | The function will be called after it stops being called for N milliseconds. |
| `immediate?` | `boolean` | If passed, trigger the function on the leading edge, instead of the trailing. |

#### Returns

[`DebouncedFunction`](interfaces/DebouncedFunction.md)\<`T`\>

**`Source`**

underscore.js

#### Defined in

[src/base/debounce.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L39)

___

### deepClone

▸ **deepClone**\<`T`\>(`a`, `a2?`, `a3?`): `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `T` |
| `a2?` | `any` |
| `a3?` | `any` |

#### Returns

`T`

#### Defined in

[src/q/system-compat.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L27)

___

### delegateCombine

▸ **delegateCombine**(`delegate1`, `delegate2`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `delegate1` | `any` |
| `delegate2` | `any` |

#### Returns

`any`

#### Defined in

[src/ui/filtering/filterstore.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L195)

___

### delegateContains

▸ **delegateContains**(`targets`, `object`, `method`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `targets` | `any`[] |
| `object` | `any` |
| `method` | `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterstore.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L248)

___

### delegateRemove

▸ **delegateRemove**(`delegate1`, `delegate2`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `delegate1` | `any` |
| `delegate2` | `any` |

#### Returns

`any`

#### Defined in

[src/ui/filtering/filterstore.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L215)

___

### editorTypeInfo

▸ **editorTypeInfo**\<`T`\>(`typeName`, `interfaces?`): [`EditorTypeInfo`](README.md#editortypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`EditorTypeInfo`](README.md#editortypeinfo)\<`T`\>

#### Defined in

[src/base/system.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L288)

___

### endsWith

▸ **endsWith**(`s`, `suffix`): `boolean`

Checks if the string ends with the specified substring.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | String to check. |
| `suffix` | `string` | Suffix to check. |

#### Returns

`boolean`

True if the string ends with the specified substring.

**`Deprecated`**

Use .endsWith method of String directly

#### Defined in

[src/q/strings-compat.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L8)

___

### executeEverytimeWhenVisible

▸ **executeEverytimeWhenVisible**(`el`, `callback`, `callNowIfVisible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `callback` | `Function` |
| `callNowIfVisible` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/layouttimer.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L153)

___

### executeOnceWhenVisible

▸ **executeOnceWhenVisible**(`el`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `callback` | `Function` |

#### Returns

`void`

#### Defined in

[src/q/layouttimer.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L140)

___

### extend

▸ **extend**\<`T`\>(`a`, `b`): `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `T` |
| `b` | `T` |

#### Returns

`T`

#### Defined in

[src/q/system-compat.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L20)

___

### faIcon

▸ **faIcon**(`key`, `color?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | [`faIconKey`](README.md#faiconkey) |
| `color?` | [`TextColor`](README.md#textcolor) |

#### Returns

`string`

#### Defined in

[src/base/icons.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L12)

___

### fabIcon

▸ **fabIcon**(`key`, `color?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | [`fabIconKey`](README.md#fabiconkey) |
| `color?` | [`TextColor`](README.md#textcolor) |

#### Returns

`string`

#### Defined in

[src/base/icons.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L16)

___

### fetchScriptData

▸ **fetchScriptData**\<`TData`\>(`name`): `Promise`\<`TData`\>

Fetches a script data with given name via ~/DynamicData endpoint

#### Type parameters

| Name |
| :------ |
| `TData` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | Dynamic script name |

#### Returns

`Promise`\<`TData`\>

A promise that will return data if successfull

#### Defined in

[src/base/scriptdata.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L54)

___

### fieldsProxy

▸ **fieldsProxy**\<`TRow`\>(): `Readonly`\<`Record`\<keyof `TRow`, `string`\>\>

#### Type parameters

| Name |
| :------ |
| `TRow` |

#### Returns

`Readonly`\<`Record`\<keyof `TRow`, `string`\>\>

#### Defined in

[src/base/system.ts:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L199)

___

### findElementWithRelativeId

▸ **findElementWithRelativeId**(`element`, `relativeId`, `context?`): `HTMLElement`

Finds the first element with the given relative id to the source element.
It can handle underscores in the source element id.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> | the source element |
| `relativeId` | `string` | the relative id to the source element |
| `context?` | `HTMLElement` | the context element (optional) |

#### Returns

`HTMLElement`

the element with the given relative id to the source element.

#### Defined in

[src/q/html-compat.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L39)

___

### first

▸ **first**\<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate similar to LINQ's First.
Throws an error if no match is found.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `array` | `TItem`[] | Array to test. |
| `predicate` | (`x`: `TItem`) => `boolean` | Predicate to test elements. |

#### Returns

`TItem`

First element that matches.

#### Defined in

[src/q/arrays-compat.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L32)

___

### format

▸ **format**(`format`, `...prm`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `format` | `string` |
| `...prm` | `any`[] |

#### Returns

`string`

**`Deprecated`**

Use stringFormat

#### Defined in

[src/q/formatting-compat.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L28)

___

### formatDate

▸ **formatDate**(`d`, `format?`, `locale?`): `string`

Formats a date using the specified format string and optional culture.
Supports .NET style format strings including custom formats.
See .NET documentation for supported formats.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `d` | `string` \| `Date` | the date to format. If null, it returns empty string. |
| `format?` | `string` | the format string to use. If null, it uses the current culture's default format. 'G' uses the culture's datetime format. 'g' uses the culture's datetime format with secs removed. 'd' uses the culture's date format. 't' uses the culture's time format. 'u' uses the sortable ISO format with UTC time. 'U' uses the culture's date format with UTC time. |
| `locale?` | [`Locale`](interfaces/Locale.md) | the locale to use |

#### Returns

`string`

the formatted date

**`Example`**

```ts
// returns "2019-01-01"
formatDate(new Date(2019, 0, 1), "yyyy-MM-dd");
```

**`Example`**

```ts
// returns "2019-01-01 12:00:00"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss");
```

**`Example`**

```ts
// returns "2019-01-01 12:00:00.000"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss.fff");
```

**`Example`**

```ts
// returns "2019-01-01 12:00:00.000 AM"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss.fff tt");
```

#### Defined in

[src/base/formatting.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L644)

___

### formatDayHourAndMin

▸ **formatDayHourAndMin**(`n`): `string`

Formats a number containing number of minutes into a string in the format "d.hh:mm".

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `n` | `number` | The number of minutes. |

#### Returns

`string`

#### Defined in

[src/q/formatting-compat.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L37)

___

### formatISODateTimeUTC

▸ **formatISODateTimeUTC**(`d`): `string`

Formats a date as the ISO 8601 UTC date/time format.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `d` | `Date` | The date. |

#### Returns

`string`

#### Defined in

[src/base/formatting.ts:818](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L818)

___

### formatNumber

▸ **formatNumber**(`num`, `format?`, `decOrLoc?`, `grp?`): `string`

Formats a number using the current `Culture` locale (or the passed locale) settings.
It supports format specifiers similar to .NET numeric formatting strings.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `num` | `number` | the number to format |
| `format?` | `string` | the format specifier. default is 'g'. See .NET numeric formatting strings documentation for more information. |
| `decOrLoc?` | `string` \| [`NumberFormat`](interfaces/NumberFormat.md) | - |
| `grp?` | `string` | - |

#### Returns

`string`

#### Defined in

[src/base/formatting.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L291)

___

### formatterTypeInfo

▸ **formatterTypeInfo**\<`T`\>(`typeName`, `interfaces?`): [`FormatterTypeInfo`](README.md#formattertypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`FormatterTypeInfo`](README.md#formattertypeinfo)\<`T`\>

#### Defined in

[src/base/system.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L292)

___

### getActiveRequests

▸ **getActiveRequests**(): `number`

#### Returns

`number`

#### Defined in

[src/base/services.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L98)

___

### getBaseType

▸ **getBaseType**(`type`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |

#### Returns

`any`

#### Defined in

[src/base/system.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L91)

___

### getColumns

▸ **getColumns**(`key`): [`PropertyItem`](interfaces/PropertyItem.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`PropertyItem`](interfaces/PropertyItem.md)[]

#### Defined in

[src/q/scriptdata-compat.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L94)

___

### getColumnsAsync

▸ **getColumnsAsync**(`key`): `Promise`\<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`\<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Defined in

[src/q/scriptdata-compat.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L98)

___

### getColumnsData

▸ **getColumnsData**(`key`): [`PropertyItemsData`](interfaces/PropertyItemsData.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`PropertyItemsData`](interfaces/PropertyItemsData.md)

#### Defined in

[src/q/scriptdata-compat.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L102)

___

### getColumnsDataAsync

▸ **getColumnsDataAsync**(`key`): `Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

Gets or loads a [ColumnsScript] data

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Form key |

#### Returns

`Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

A property items data object containing items and additionalItems properties

#### Defined in

[src/q/scriptdata-compat.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L106)

___

### getColumnsScript

▸ **getColumnsScript**(`key`): `Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

Gets or loads a [ColumnsScript] data

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Form key |

#### Returns

`Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

A property items data object containing items and additionalItems properties

#### Defined in

[src/base/scriptdata.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L129)

___

### getCookie

▸ **getCookie**(`name`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`any`

#### Defined in

[src/base/services.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L33)

___

### getCustomAttribute

▸ **getCustomAttribute**\<`TAttr`\>(`type`, `attrType`, `inherit?`): `TAttr`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `type` | `any` | `undefined` |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`

#### Defined in

[src/base/system.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L237)

___

### getCustomAttributes

▸ **getCustomAttributes**\<`TAttr`\>(`type`, `attrType`, `inherit?`): `TAttr`[]

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `type` | `any` | `undefined` |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`[]

#### Defined in

[src/base/system.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L258)

___

### getForm

▸ **getForm**(`key`): [`PropertyItem`](interfaces/PropertyItem.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`PropertyItem`](interfaces/PropertyItem.md)[]

#### Defined in

[src/q/scriptdata-compat.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L108)

___

### getFormAsync

▸ **getFormAsync**(`key`): `Promise`\<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`\<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Defined in

[src/q/scriptdata-compat.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L112)

___

### getFormData

▸ **getFormData**(`key`): [`PropertyItemsData`](interfaces/PropertyItemsData.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`PropertyItemsData`](interfaces/PropertyItemsData.md)

#### Defined in

[src/q/scriptdata-compat.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L116)

___

### getFormDataAsync

▸ **getFormDataAsync**(`key`): `Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

Gets or loads a [FormScript] data

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Form key |

#### Returns

`Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

A property items data object containing items and additionalItems properties

#### Defined in

[src/q/scriptdata-compat.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L120)

___

### getFormScript

▸ **getFormScript**(`key`): `Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

Gets or loads a [FormScript] data

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Form key |

#### Returns

`Promise`\<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

A property items data object containing items and additionalItems properties

#### Defined in

[src/base/scriptdata.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L138)

___

### getGlobalObject

▸ **getGlobalObject**(): `any`

#### Returns

`any`

#### Defined in

[src/base/system.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L5)

___

### getInstanceType

▸ **getInstanceType**(`instance`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `instance` | `any` |

#### Returns

`any`

#### Defined in

[src/base/system.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L58)

___

### getLookup

▸ **getLookup**\<`TItem`\>(`key`): [`Lookup`](classes/Lookup.md)\<`TItem`\>

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`Lookup`](classes/Lookup.md)\<`TItem`\>

#### Defined in

[src/q/scriptdata-compat.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L86)

___

### getLookupAsync

▸ **getLookupAsync**\<`TItem`\>(`key`): `Promise`\<[`Lookup`](classes/Lookup.md)\<`TItem`\>\>

Gets or loads a Lookup

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Lookup key |

#### Returns

`Promise`\<[`Lookup`](classes/Lookup.md)\<`TItem`\>\>

#### Defined in

[src/base/scriptdata.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L146)

___

### getMembers

▸ **getMembers**(`type`, `memberTypes`): [`TypeMember`](interfaces/TypeMember.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `memberTypes` | [`MemberType`](enums/MemberType.md) |

#### Returns

[`TypeMember`](interfaces/TypeMember.md)[]

#### Defined in

[src/q/system-compat.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L86)

___

### getNested

▸ **getNested**(`from`, `name`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `from` | `any` |
| `name` | `string` |

#### Returns

`any`

#### Defined in

[src/base/system.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L19)

___

### getRemoteData

▸ **getRemoteData**\<`TData`\>(`key`): `TData`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`TData`

#### Defined in

[src/q/scriptdata-compat.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L82)

___

### getRemoteDataAsync

▸ **getRemoteDataAsync**\<`TData`\>(`key`): `Promise`\<`TData`\>

Gets or loads a [RemoteData]

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Remote data key |

#### Returns

`Promise`\<`TData`\>

#### Defined in

[src/base/scriptdata.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L154)

___

### getScriptData

▸ **getScriptData**\<`TData`\>(`name`, `reload?`): `Promise`\<`TData`\>

Returns the script data from cache if available, or via a fetch
request to ~/DynamicData endpoint

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` |  |
| `reload?` | `boolean` | Clear cache and force reload |

#### Returns

`Promise`\<`TData`\>

#### Defined in

[src/base/scriptdata.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L110)

___

### getScriptDataHash

▸ **getScriptDataHash**(`name`, `reload?`): `string`

Gets the known hash value for a given dynamic script name. They are usually
registered server-side via dynamic script manager and their latest known
hashes are passed to the client-side via a script element named RegisteredScripts.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | The dynamic script name |
| `reload?` | `boolean` | True to force resetting the script hash client side, e.g. for loading lookups etc. |

#### Returns

`string`

The hash or null if no such known registration

#### Defined in

[src/base/scriptdata.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L19)

___

### getTemplate

▸ **getTemplate**(`key`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`string`

#### Defined in

[src/q/scriptdata-compat.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L122)

___

### getType

▸ **getType**(`name`, `target?`): [`Type`](README.md#type)

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `target?` | `any` |

#### Returns

[`Type`](README.md#type)

#### Defined in

[src/base/system.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L29)

___

### getTypeFullName

▸ **getTypeFullName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`Type`](README.md#type) |

#### Returns

`string`

#### Defined in

[src/base/system.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L46)

___

### getTypeNameProp

▸ **getTypeNameProp**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |

#### Returns

`string`

#### Defined in

[src/base/system-internal.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L122)

___

### getTypeRegistry

▸ **getTypeRegistry**(): `any`

#### Returns

`any`

#### Defined in

[src/base/system-internal.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L34)

___

### getTypeShortName

▸ **getTypeShortName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`Type`](README.md#type) |

#### Returns

`string`

#### Defined in

[src/base/system.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L51)

___

### getTypes

▸ **getTypes**(`from?`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `from?` | `any` |

#### Returns

`any`[]

#### Defined in

[src/q/system-compat.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L153)

___

### getWidgetFrom

▸ **getWidgetFrom**\<`TWidget`\>(`element`, `type?`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `string` \| `Element` \| `ArrayLike`\<`HTMLElement`\> |
| `type?` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`TWidget`

#### Defined in

[src/ui/widgets/widgetutils.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L77)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Defined in

[src/ui/widgets/widgetutils.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L5)

___

### getjQuery

▸ **getjQuery**(): `any`

#### Returns

`any`

#### Defined in

[src/base/environment.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/environment.ts#L1)

___

### gridPageInit

▸ **gridPageInit**\<`TGrid`, `P`\>(`grid`): `TGrid`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TGrid` | extends [`Widget`](classes/Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | `TGrid` & \{ `domNode`: `HTMLElement`  } |

#### Returns

`TGrid`

#### Defined in

[src/q/layout.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L46)

▸ **gridPageInit**\<`TGrid`, `P`\>(`type`, `props?`): `TGrid`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TGrid` | extends [`Widget`](classes/Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (`options?`: `P`) => `TGrid` |
| `type.prototype` | `TGrid` |
| `props?` | [`WidgetProps`](README.md#widgetprops)\<`P`\> |

#### Returns

`TGrid`

#### Defined in

[src/q/layout.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L47)

___

### groupBy

▸ **groupBy**\<`TItem`\>(`items`, `getKey`): [`GroupByResult`](README.md#groupbyresult)\<`TItem`\>

Groups an array with keys determined by specified getKey() callback.
Resulting object contains group objects in order and a dictionary to access by key.
This is similar to LINQ's ToLookup function with some additional details like start index.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `items` | `TItem`[] | Array to group. |
| `getKey` | (`x`: `TItem`) => `any` | Function that returns key for each item. |

#### Returns

[`GroupByResult`](README.md#groupbyresult)\<`TItem`\>

GroupByResult object.

#### Defined in

[src/q/arrays-compat.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L70)

___

### handleScriptDataError

▸ **handleScriptDataError**(`name`, `status?`, `statusText?`, `shouldThrow?`): `string`

Shows a suitable error message for errors occured during loading of
a dynamic script data.

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `name` | `string` | `undefined` | Name of the dynamic script |
| `status?` | `number` | `undefined` | HTTP status returned if available |
| `statusText?` | `string` | `undefined` | HTTP status text returned if available |
| `shouldThrow` | `boolean` | `true` | - |

#### Returns

`string`

#### Defined in

[src/base/scriptdata.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L165)

___

### hasBSModal

▸ **hasBSModal**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/dialogs.ts:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L505)

___

### hasCustomAttribute

▸ **hasCustomAttribute**\<`TAttr`\>(`type`, `attrType`, `inherit?`): `boolean`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `type` | `any` | `undefined` |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`boolean`

#### Defined in

[src/base/system.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L254)

___

### hasUIDialog

▸ **hasUIDialog**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/dialogs.ts:509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L509)

___

### htmlEncode

▸ **htmlEncode**(`s`): `string`

Html encodes a string (encodes single and double quotes, & (ampersand), > and < characters)

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `any` | String (or number etc.) to be HTML encoded |

#### Returns

`string`

#### Defined in

[src/base/html.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L18)

___

### iconClassName

▸ **iconClassName**(`icon`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `icon` | [`IconClassName`](README.md#iconclassname) |

#### Returns

`string`

#### Defined in

[src/base/icons.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L24)

___

### iframeDialog

▸ **iframeDialog**(`options`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

Display a dialog that shows an HTML block in an IFRAME, which is usually returned from server callbacks

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `options` | [`IFrameDialogOptions`](interfaces/IFrameDialogOptions.md) | The options |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

#### Defined in

[src/base/dialogs.ts:949](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L949)

___

### indexOf

▸ **indexOf**\<`TItem`\>(`array`, `predicate`): `number`

Gets index of first element in an array that matches given predicate.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `array` | `TItem`[] | Array to test. |
| `predicate` | (`x`: `TItem`) => `boolean` | Predicate to test elements. |

#### Returns

`number`

#### Defined in

[src/q/arrays-compat.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L103)

___

### information

▸ **information**(`message`, `onOk?`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `onOk?` | () => `void` |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`Deprecated`**

use informationDialog

#### Defined in

[src/q/dialogs-compat.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L10)

___

### informationDialog

▸ **informationDialog**(`message`, `onOk?`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

Display an information dialog

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `onOk?` | () => `void` | Callback for OK button click |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) | Additional options. |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`See`**

ConfirmOptions

**`Example`**

```ts
informationDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

#### Defined in

[src/base/dialogs.ts:877](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L877)

___

### initFormType

▸ **initFormType**(`typ`, `nameWidgetPairs`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `typ` | `Function` |
| `nameWidgetPairs` | `any`[] |

#### Returns

`void`

#### Defined in

[src/base/system.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L183)

___

### initFullHeightGridPage

▸ **initFullHeightGridPage**(`gridDiv`, `opt?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `gridDiv` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| \{ `domNode`: `HTMLElement`  } |
| `opt?` | `Object` |
| `opt.noRoute?` | `boolean` |
| `opt.setHeight?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L58)

___

### initializeTypes

▸ **initializeTypes**(`root`, `pre`, `limit`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `root` | `any` |
| `pre` | `string` |
| `limit` | `number` |

#### Returns

`void`

#### Defined in

[src/q/system-compat.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L204)

___

### insert

▸ **insert**(`obj`, `index`, `item`): `void`

Inserts an item to the array at specified index. Prefer Array.splice unless
you need to support IE.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `obj` | `any` | Array or array like object to insert to. |
| `index` | `number` | Index to insert at. |
| `item` | `any` | Item to insert. |

#### Returns

`void`

**`Throws`**

Error if object does not support insert.

**`Example`**

```ts
insert([1, 2, 3], 1, 4); // [1, 4, 2, 3]
insert({ insert: (index, item) => { this.splice(index, 0, item); } }
```

#### Defined in

[src/q/arrays-compat.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L122)

___

### interfaceTypeInfo

▸ **interfaceTypeInfo**\<`T`\>(`typeName`, `interfaces?`): [`InterfaceTypeInfo`](README.md#interfacetypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`InterfaceTypeInfo`](README.md#interfacetypeinfo)\<`T`\>

#### Defined in

[src/base/system.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L296)

___

### isArray

▸ **isArray**(`arg`): arg is any[]

Determines if the object is an array. Prefer Array.isArray over this function (e.g. `Array.isArray(obj)`).

#### Parameters

| Name | Type |
| :------ | :------ |
| `arg` | `any` |

#### Returns

arg is any[]

True if the object is an array.

**`Example`**

```ts
isArray([1, 2, 3]); // true
isArray({}); // false
```

#### Defined in

[src/q/arrays-compat.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L139)

___

### isArrayLike

▸ **isArrayLike**(`obj`): obj is ArrayLike\<any\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `obj` | `any` |

#### Returns

obj is ArrayLike\<any\>

#### Defined in

[src/base/system.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L203)

___

### isAssignableFrom

▸ **isAssignableFrom**(`target`, `type`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `any` |
| `type` | [`Type`](README.md#type) |

#### Returns

`any`

#### Defined in

[src/base/system.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L71)

___

### isBS3

▸ **isBS3**(): `boolean`

Returns true if Bootstrap 3 is loaded

#### Returns

`boolean`

#### Defined in

[src/base/environment.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/environment.ts#L7)

___

### isBS5Plus

▸ **isBS5Plus**(): `boolean`

Returns true if Bootstrap 5+ is loaded

#### Returns

`boolean`

#### Defined in

[src/base/environment.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/environment.ts#L12)

___

### isEmptyOrNull

▸ **isEmptyOrNull**(`s`): `boolean`

Checks if the string is empty or null. Prefer (!s) instead.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | String to check. |

#### Returns

`boolean`

True if the string is empty or null.

#### Defined in

[src/q/strings-compat.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L17)

___

### isEnum

▸ **isEnum**(`type`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |

#### Returns

`boolean`

#### Defined in

[src/base/system.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L178)

___

### isInstanceOfType

▸ **isInstanceOfType**(`instance`, `type`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `instance` | `any` |
| `type` | [`Type`](README.md#type) |

#### Returns

`any`

#### Defined in

[src/base/system.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L81)

___

### isMobileView

▸ **isMobileView**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/q/layout.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L125)

___

### isPromiseLike

▸ **isPromiseLike**(`obj`): obj is PromiseLike\<any\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `obj` | `any` |

#### Returns

obj is PromiseLike\<any\>

#### Defined in

[src/base/system.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L207)

___

### isSameOrigin

▸ **isSameOrigin**(`url`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |

#### Returns

`boolean`

#### Defined in

[src/base/services.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L44)

___

### isTrimmedEmpty

▸ **isTrimmedEmpty**(`s`): `boolean`

Checks if the string is empty or null or whitespace. Prefer !s?.Trim() instead.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | String to check. |

#### Returns

`boolean`

True if the string is empty or null or whitespace.

#### Defined in

[src/q/strings-compat.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L26)

___

### isValue

▸ **isValue**(`a`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `any` |

#### Returns

`boolean`

**`Deprecated`**

Use a != null

#### Defined in

[src/q/system-compat.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L11)

___

### keyOf

▸ **keyOf**\<`T`\>(`prop`): keyof `T`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `prop` | keyof `T` |

#### Returns

keyof `T`

#### Defined in

[src/q/system-compat.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L185)

___

### layoutFillHeight

▸ **layoutFillHeight**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L117)

___

### layoutFillHeightValue

▸ **layoutFillHeightValue**(`element`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`number`

#### Defined in

[src/q/layout.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L97)

___

### localText

▸ **localText**(`key`, `defaultText?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `defaultText?` | `string` |

#### Returns

`string`

#### Defined in

[src/base/localtext.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L35)

___

### localeFormat

▸ **localeFormat**(`l`, `format`, `...prm`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `l` | [`Locale`](interfaces/Locale.md) |
| `format` | `string` |
| `...prm` | `any`[] |

#### Returns

`string`

**`Deprecated`**

Use stringFormatLocale

#### Defined in

[src/q/formatting-compat.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L31)

___

### newBodyDiv

▸ **newBodyDiv**(): `HTMLDivElement`

Creates a new DIV and appends it to the body.

#### Returns

`HTMLDivElement`

the new DIV element.

#### Defined in

[src/q/html-compat.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L81)

___

### noDialogButton

▸ **noDialogButton**(`opt?`): [`DialogButton`](interfaces/DialogButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt?` | [`DialogButton`](interfaces/DialogButton.md) |

#### Returns

[`DialogButton`](interfaces/DialogButton.md)

#### Defined in

[src/base/dialogs.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L571)

___

### notifyError

▸ **notifyError**(`message`, `title?`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `title?` | `string` |
| `options?` | [`ToastrOptions`](README.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/base/notify.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L47)

___

### notifyInfo

▸ **notifyInfo**(`message`, `title?`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `title?` | `string` |
| `options?` | [`ToastrOptions`](README.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/base/notify.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L51)

___

### notifySuccess

▸ **notifySuccess**(`message`, `title?`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `title?` | `string` |
| `options?` | [`ToastrOptions`](README.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/base/notify.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L55)

___

### notifyWarning

▸ **notifyWarning**(`message`, `title?`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `title?` | `string` |
| `options?` | [`ToastrOptions`](README.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/base/notify.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L59)

___

### okDialogButton

▸ **okDialogButton**(`opt?`): [`DialogButton`](interfaces/DialogButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt?` | [`DialogButton`](interfaces/DialogButton.md) |

#### Returns

[`DialogButton`](interfaces/DialogButton.md)

#### Defined in

[src/base/dialogs.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L553)

___

### omitUndefined

▸ **omitUndefined**(`x`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `Object` |

#### Returns

`any`

#### Defined in

[src/base/system.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L9)

___

### outerHtml

▸ **outerHtml**(`element`): `string`

Returns the outer HTML of the element.

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `Element` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`string`

#### Defined in

[src/q/html-compat.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L90)

___

### padLeft

▸ **padLeft**(`s`, `len`, `ch?`): `any`

Pads the string to the left with the specified character.

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `s` | `string` \| `number` | `undefined` | String to pad. |
| `len` | `number` | `undefined` | Target length of the string. |
| `ch` | `string` | `' '` | Character to pad with. |

#### Returns

`any`

Padded string.

#### Defined in

[src/q/strings-compat.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L37)

___

### panelPageInit

▸ **panelPageInit**\<`TGrid`, `P`\>(`panel`): `TGrid`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TGrid` | extends [`Widget`](classes/Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `panel` | `TGrid` & \{ `domNode`: `HTMLElement`  } |

#### Returns

`TGrid`

#### Defined in

[src/q/layout.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L52)

▸ **panelPageInit**\<`TGrid`, `P`\>(`type`, `props?`): `TGrid`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TGrid` | extends [`Widget`](classes/Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (`options?`: `P`) => `TGrid` |
| `type.prototype` | `TGrid` |
| `props?` | [`WidgetProps`](README.md#widgetprops)\<`P`\> |

#### Returns

`TGrid`

#### Defined in

[src/q/layout.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L53)

___

### parseCriteria

▸ **parseCriteria**(`expression`, `params?`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The string may optionally contain parameters like `A >= @p1 and B < @p2`.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `expression` | `string` | The criteria expression. |
| `params?` | `any` | The dictionary containing parameter values like { p1: 10, p2: 20 }. |

#### Returns

`any`[]

**`Example`**

```ts
parseCriteria('A >=
```

**`P1`**

and B < @p2', { p1: 5, p2: 4 }) // [[[a], '>=' 5], 'and', [[b], '<', 4]]

#### Defined in

[src/base/criteria.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L694)

▸ **parseCriteria**(`strings`, `...values`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The expression may contain parameter placeholders like `A >= ${p1}`
where p1 is a variable in the scope.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `strings` | `TemplateStringsArray` | The string fragments. |
| `...values` | `any`[] | The tagged template arguments. |

#### Returns

`any`[]

**`Example`**

```ts
var a = 5, b = 4;
parseCriteria`A >= ${a} and B < ${b}` // [[[a], '>=' 5], 'and', [[b], '<', 4]]
```

#### Defined in

[src/base/criteria.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L705)

___

### parseDate

▸ **parseDate**(`s`, `dateOrder?`): `Date`

Parses a string to a date. If the string is empty or whitespace, returns null.
Returns a NaN Date if the string is not a valid date.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | The string to parse. |
| `dateOrder?` | `string` | The order of the date parts in the string. Defaults to culture's default date order. |

#### Returns

`Date`

#### Defined in

[src/base/formatting.ts:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L862)

___

### parseDayHourAndMin

▸ **parseDayHourAndMin**(`s`): `number`

Parses a string in the format "d.hh:mm" into a number containing number of minutes.
Returns NaN if the hours not in range 0-23 or minutes not in range 0-59.
Returns NULL if the string is empty or whitespace.

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

#### Returns

`number`

#### Defined in

[src/q/formatting-compat.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L88)

___

### parseDecimal

▸ **parseDecimal**(`s`): `number`

Converts a string to a decimal. The difference between parseFloat and parseDecimal
is that parseDecimal will return null if the string is empty or null, whereas
parseFloat will return NaN and parseDecimal will use the current culture's group
and decimal separators.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | the string to parse |

#### Returns

`number`

#### Defined in

[src/base/formatting.ts:547](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L547)

___

### parseHourAndMin

▸ **parseHourAndMin**(`value`): `number`

Parses a time string in the format "hh:mm" into a number containing number of minutes.
Returns NaN if the hours not in range 0-23 or minutes not in range 0-59.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | The string to parse. |

#### Returns

`number`

#### Defined in

[src/q/formatting-compat.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L61)

___

### parseISODateTime

▸ **parseISODateTime**(`s`): `Date`

Parses a string in the ISO 8601 UTC date/time format.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | The string to parse. |

#### Returns

`Date`

#### Defined in

[src/base/formatting.ts:840](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L840)

___

### parseInteger

▸ **parseInteger**(`s`): `number`

Converts a string to an integer. The difference between parseInt and parseInteger 
is that parseInteger will return null if the string is empty or null, whereas
parseInt will return NaN and parseInteger will use the current culture's group
and decimal separators.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | the string to parse |

#### Returns

`number`

#### Defined in

[src/base/formatting.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L525)

___

### parseQueryString

▸ **parseQueryString**(`s?`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `s?` | `string` |

#### Returns

`Object`

#### Defined in

[src/q/services-compat.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services-compat.ts#L23)

___

### peekScriptData

▸ **peekScriptData**(`name`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`any`

#### Defined in

[src/base/scriptdata.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L213)

___

### positionToastContainer

▸ **positionToastContainer**(`options?`, `create?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `options?` | [`ToastrOptions`](README.md#toastroptions) | `undefined` |
| `create` | `boolean` | `true` |

#### Returns

`void`

#### Defined in

[src/base/notify.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L12)

___

### postToService

▸ **postToService**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`PostToServiceOptions`](interfaces/PostToServiceOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/services-compat.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services-compat.ts#L61)

___

### postToUrl

▸ **postToUrl**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`PostToUrlOptions`](interfaces/PostToUrlOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/services-compat.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services-compat.ts#L78)

___

### prefixedText

▸ **prefixedText**(`prefix`): (`text`: `string`, `key`: `string` \| (`p?`: `string`) => `string`) => `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `prefix` | `string` |

#### Returns

`fn`

▸ (`text`, `key`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |
| `key` | `string` \| (`p?`: `string`) => `string` |

##### Returns

`string`

#### Defined in

[src/q/localtext-compat.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext-compat.ts#L12)

___

### proxyTexts

▸ **proxyTexts**(`o`, `p`, `t`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `o` | `Record`\<`string`, `any`\> |
| `p` | `string` |
| `t` | `Record`\<`string`, `any`\> |

#### Returns

`Object`

#### Defined in

[src/base/localtext.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L43)

___

### registerClass

▸ **registerClass**(`type`, `name`, `intf?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `name` | `string` |
| `intf?` | `any`[] |

#### Returns

`void`

#### Defined in

[src/base/system.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L111)

___

### registerEditor

▸ **registerEditor**(`type`, `name`, `intf?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `name` | `string` |
| `intf?` | `any`[] |

#### Returns

`void`

#### Defined in

[src/base/system.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L223)

___

### registerEnum

▸ **registerEnum**(`type`, `name`, `enumKey?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `name` | `string` |
| `enumKey?` | `string` |

#### Returns

`void`

#### Defined in

[src/base/system.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L116)

___

### registerFormatter

▸ **registerFormatter**(`type`, `name`, `intf?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `name` | `string` |
| `intf?` | `any`[] |

#### Returns

`void`

#### Defined in

[src/base/system.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L219)

___

### registerInterface

▸ **registerInterface**(`type`, `name`, `intf?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `name` | `string` |
| `intf?` | `any`[] |

#### Returns

`void`

#### Defined in

[src/base/system.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L126)

___

### registerType

▸ **registerType**(`type`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Object` |
| `type.name` | `string` |
| `type.typeInfo` | [`TypeInfo`](README.md#typeinfo)\<`any`\> |

#### Returns

`void`

#### Defined in

[src/base/system.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L300)

___

### reloadLookup

▸ **reloadLookup**\<`TItem`\>(`key`): [`Lookup`](classes/Lookup.md)\<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`Lookup`](classes/Lookup.md)\<`TItem`\>

#### Defined in

[src/q/scriptdata-compat.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L90)

___

### reloadLookupAsync

▸ **reloadLookupAsync**\<`TItem`\>(`key`): `Promise`\<[`Lookup`](classes/Lookup.md)\<`TItem`\>\>

Forces reload of a lookup from the server. Note that only the
client side cache is cleared. This does not force reloading in the server-side.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | Lookup key |

#### Returns

`Promise`\<[`Lookup`](classes/Lookup.md)\<`TItem`\>\>

Lookup

#### Defined in

[src/base/scriptdata.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L223)

___

### removeClass

▸ **removeClass**(`el`, `cls`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `Element` |
| `cls` | `string` |

#### Returns

`void`

#### Defined in

[src/base/html.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L52)

___

### removeValidationRule

▸ **removeValidationRule**(`element`, `uniqueName`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `uniqueName` | `string` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1683)

___

### replaceAll

▸ **replaceAll**(`str`, `find`, `replace`): `string`

Replaces all occurrences of the search string with the replacement string.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `str` | `string` | String to replace. |
| `find` | `string` | String to find. |
| `replace` | `string` | String to replace with. |

#### Returns

`string`

Replaced string.

#### Defined in

[src/q/strings-compat.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L113)

___

### requestFinished

▸ **requestFinished**(): `void`

#### Returns

`void`

#### Defined in

[src/base/services.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L87)

___

### requestStarting

▸ **requestStarting**(): `void`

#### Returns

`void`

#### Defined in

[src/base/services.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L76)

___

### resolveServiceUrl

▸ **resolveServiceUrl**(`url`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |

#### Returns

`string`

#### Defined in

[src/base/services.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L13)

___

### resolveUrl

▸ **resolveUrl**(`url`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |

#### Returns

`string`

#### Defined in

[src/base/services.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L7)

___

### round

▸ **round**(`n`, `d?`, `rounding?`): `number`

Rounds a number to specified digits or an integer number if digits are not specified.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `n` | `number` | the number to round |
| `d?` | `number` | the number of digits to round to. default is zero. |
| `rounding?` | `boolean` | whether to use banker's rounding |

#### Returns

`number`

the rounded number

#### Defined in

[src/base/formatting.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L267)

___

### safeCast

▸ **safeCast**(`instance`, `type`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `instance` | `any` |
| `type` | [`Type`](README.md#type) |

#### Returns

`any`

#### Defined in

[src/q/system-compat.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L197)

___

### serviceCall

▸ **serviceCall**\<`TResponse`\>(`options`): `PromiseLike`\<`TResponse`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TResponse` | extends [`ServiceResponse`](interfaces/ServiceResponse.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](interfaces/ServiceOptions.md)\<`TResponse`\> |

#### Returns

`PromiseLike`\<`TResponse`\>

#### Defined in

[src/base/services.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L186)

___

### serviceRequest

▸ **serviceRequest**\<`TResponse`\>(`service`, `request?`, `onSuccess?`, `options?`): `PromiseLike`\<`TResponse`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TResponse` | extends [`ServiceResponse`](interfaces/ServiceResponse.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `service` | `string` |
| `request?` | `any` |
| `onSuccess?` | (`response`: `TResponse`) => `void` |
| `options?` | [`ServiceOptions`](interfaces/ServiceOptions.md)\<`TResponse`\> |

#### Returns

`PromiseLike`\<`TResponse`\>

#### Defined in

[src/base/services.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L255)

___

### setEquality

▸ **setEquality**(`request`, `field`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `request` | [`ListRequest`](interfaces/ListRequest.md) |
| `field` | `string` |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/q/services-compat.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services-compat.ts#L3)

___

### setRegisteredScripts

▸ **setRegisteredScripts**(`scripts`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `scripts` | `any`[] |

#### Returns

`void`

#### Defined in

[src/base/scriptdata.ts:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L227)

___

### setScriptData

▸ **setScriptData**(`name`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/base/scriptdata.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L237)

___

### setTypeNameProp

▸ **setTypeNameProp**(`type`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/base/system-internal.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L126)

___

### single

▸ **single**\<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate.
Throws an error if no matches is found, or there are multiple matches.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `array` | `TItem`[] | Array to test. |
| `predicate` | (`x`: `TItem`) => `boolean` | Predicate to test elements. |

#### Returns

`TItem`

First element that matches.

**`Example`**

```ts
first([1, 2, 3], x => x == 2); // 2
first([1, 2, 3], x => x == 4); // throws error.
```

#### Defined in

[src/q/arrays-compat.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L151)

___

### splitDateString

▸ **splitDateString**(`s`): `string`[]

Splits a date string into an array of strings, each containing a single date part.
It can handle separators "/", ".", "-" and "\".

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | The string to split. |

#### Returns

`string`[]

#### Defined in

[src/base/formatting.ts:936](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L936)

___

### startsWith

▸ **startsWith**(`s`, `prefix`): `boolean`

Checks if the string starts with the prefix

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | String to check. |
| `prefix` | `string` | Prefix to check. |

#### Returns

`boolean`

True if the string starts with the prefix.

**`Deprecated`**

Use .startsWith method of String directly

#### Defined in

[src/q/strings-compat.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L53)

___

### stringFormat

▸ **stringFormat**(`format`, `...prm`): `string`

Formats a string with parameters similar to .NET's String.Format function
using current `Culture` locale settings.

#### Parameters

| Name | Type |
| :------ | :------ |
| `format` | `string` |
| `...prm` | `any`[] |

#### Returns

`string`

#### Defined in

[src/base/formatting.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L238)

___

### stringFormatLocale

▸ **stringFormatLocale**(`l`, `format`, `...prm`): `string`

Formats a string with parameters similar to .NET's String.Format function
using the locale passed as the first argument.

#### Parameters

| Name | Type |
| :------ | :------ |
| `l` | [`Locale`](interfaces/Locale.md) |
| `format` | `string` |
| `...prm` | `any`[] |

#### Returns

`string`

#### Defined in

[src/base/formatting.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L246)

___

### stripDiacritics

▸ **stripDiacritics**(`str`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `str` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/editors/combobox.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L393)

___

### success

▸ **success**(`message`, `onOk?`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `onOk?` | () => `void` |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`Deprecated`**

use successDialog

#### Defined in

[src/q/dialogs-compat.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L13)

___

### successDialog

▸ **successDialog**(`message`, `onOk?`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

Display a success dialog

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `onOk?` | () => `void` | Callback for OK button click |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) | Additional options. |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`See`**

MessageDialogOptions

**`Example`**

```ts
successDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

#### Defined in

[src/base/dialogs.ts:903](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L903)

___

### text

▸ **text**(`key`, `defaultText?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `defaultText?` | `string` |

#### Returns

`string`

**`Deprecated`**

prefer localText for better discoverability

#### Defined in

[src/q/localtext-compat.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext-compat.ts#L4)

___

### textColor

▸ **textColor**(`color`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `color` | [`TextColor`](README.md#textcolor) |

#### Returns

`string`

#### Defined in

[src/base/icons.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L8)

___

### toGrouping

▸ **toGrouping**\<`TItem`\>(`items`, `getKey`): [`Grouping`](README.md#grouping)\<`TItem`\>

Maps an array into a dictionary with keys determined by specified getKey() callback,
and values that are arrays containing elements for a particular key.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `items` | `TItem`[] | Array to map. |
| `getKey` | (`x`: `TItem`) => `any` | Function that returns key for each item. |

#### Returns

[`Grouping`](README.md#grouping)\<`TItem`\>

Grouping object.

**`Example`**

```ts
toGrouping([1, 2, 3], x => x % 2 == 0 ? "even" : "odd"); // { odd: [1, 3], even: [2] }
```

#### Defined in

[src/q/arrays-compat.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L180)

___

### toId

▸ **toId**(`id`): `any`

Converts a string to an ID. If the string is a number, it is returned as-is.
If the string is empty, null or whitespace, null is returned.
Otherwise, it is converted to a number if possible. If the string is not a
valid number or longer than 14 digits, the trimmed string is returned as-is.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `id` | `any` | the string to convert to an ID |

#### Returns

`any`

#### Defined in

[src/base/formatting.ts:601](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L601)

___

### toSingleLine

▸ **toSingleLine**(`str`): `string`

Converts the string to single line by removing line end characters

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `str` | `string` | String to convert. |

#### Returns

`string`

#### Defined in

[src/q/strings-compat.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L61)

___

### today

▸ **today**(): `Date`

#### Returns

`Date`

#### Defined in

[src/q/system-compat.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system-compat.ts#L15)

___

### toggleClass

▸ **toggleClass**(`el`, `cls`, `add?`): `void`

Toggles the class on the element handling spaces like addClass does.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `el` | `Element` | the element |
| `cls` | `string` | the class to toggle |
| `add?` | `boolean` | if true, the class will be added, if false the class will be removed, otherwise it will be toggled. |

#### Returns

`void`

#### Defined in

[src/base/html.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L34)

___

### triggerLayoutOnShow

▸ **triggerLayoutOnShow**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L143)

___

### trim

▸ **trim**(`s`): `string`

Trims the whitespace characters from the start and end of the string
This returns empty string even when the string is null or undefined.

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

#### Returns

`string`

#### Defined in

[src/q/strings-compat.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L83)

___

### trimEnd

▸ **trimEnd**(`s`): `any`

Trims the whitespace characters from the end of the string

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

#### Returns

`any`

#### Defined in

[src/q/strings-compat.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L68)

___

### trimStart

▸ **trimStart**(`s`): `any`

Trims the whitespace characters from the start of the string

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

#### Returns

`any`

#### Defined in

[src/q/strings-compat.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L75)

___

### trimToEmpty

▸ **trimToEmpty**(`s`): `string`

Trims the whitespace characters from the start and end of the string
Returns empty string if the string is null or undefined.

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

#### Returns

`string`

#### Defined in

[src/q/strings-compat.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L91)

___

### trimToNull

▸ **trimToNull**(`s`): `string`

Trims the whitespace characters from the start and end of the string
Returns null if the string is null, undefined or whitespace.

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

#### Returns

`string`

#### Defined in

[src/q/strings-compat.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L99)

___

### trunc

▸ **trunc**(`n`): `number`

Truncates a number to an integer number.

#### Parameters

| Name | Type |
| :------ | :------ |
| `n` | `number` |

#### Returns

`number`

#### Defined in

[src/base/formatting.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L282)

___

### tryFirst

▸ **tryFirst**\<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate (similar to LINQ's FirstOrDefault).
Returns null if no match is found.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `array` | `TItem`[] | Array to test. |
| `predicate` | (`x`: `TItem`) => `boolean` | Predicate to test elements. |

#### Returns

`TItem`

First element that matches.

**`Example`**

```ts
tryFirst([1, 2, 3], x => x == 2); // 2
tryFirst([1, 2, 3], x => x == 4); // null
```

#### Defined in

[src/q/arrays-compat.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L204)

___

### tryGetText

▸ **tryGetText**(`key`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`string`

#### Defined in

[src/base/localtext.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L39)

___

### tryGetWidget

▸ **tryGetWidget**\<`TWidget`\>(`element`, `type?`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `string` \| `Element` \| `ArrayLike`\<`HTMLElement`\> |
| `type?` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`TWidget`

#### Defined in

[src/ui/widgets/widgetutils.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L41)

___

### turkishLocaleCompare

▸ **turkishLocaleCompare**(`a`, `b`): `number`

This is an alias for Culture.stringCompare, left in for compatibility reasons.

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |
| `b` | `string` |

#### Returns

`number`

#### Defined in

[src/q/formatting-compat.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L25)

___

### turkishLocaleToLower

▸ **turkishLocaleToLower**(`a`): `string`

A string to lowercase function that handles special Turkish
characters like 'ı'. Left in for compatibility reasons.

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |

#### Returns

`string`

#### Defined in

[src/q/formatting-compat.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L6)

___

### turkishLocaleToUpper

▸ **turkishLocaleToUpper**(`a`): `string`

A string to uppercase function that handles special Turkish
characters like 'ı'. Left in for compatibility reasons.

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `string` |

#### Returns

`string`

#### Defined in

[src/q/formatting-compat.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting-compat.ts#L16)

___

### uiAndBSButtonNoConflict

▸ **uiAndBSButtonNoConflict**(): `void`

#### Returns

`void`

#### Defined in

[src/base/dialogs.ts:513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L513)

___

### useIdPrefix

▸ **useIdPrefix**(`prefix`): [`IdPrefixType`](README.md#idprefixtype)

#### Parameters

| Name | Type |
| :------ | :------ |
| `prefix` | `string` |

#### Returns

[`IdPrefixType`](README.md#idprefixtype)

#### Defined in

[src/ui/widgets/widgetutils.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L110)

___

### validateOptions

▸ **validateOptions**(`options?`): [`ValidatorOptions`](interfaces/ValidatorOptions.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`ValidatorOptions`](interfaces/ValidatorOptions.md) |

#### Returns

[`ValidatorOptions`](interfaces/ValidatorOptions.md)

#### Defined in

[src/q/validation.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L11)

___

### validatorAbortHandler

▸ **validatorAbortHandler**(`validator`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `validator` | [`Validator`](classes/Validator.md) |

#### Returns

`void`

#### Defined in

[src/q/validation.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L4)

___

### warning

▸ **warning**(`message`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`Deprecated`**

use warningDialog

#### Defined in

[src/q/dialogs-compat.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L16)

___

### warningDialog

▸ **warningDialog**(`message`, `options?`): `Partial`\<[`Dialog`](classes/Dialog.md)\>

Display a warning dialog

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `options?` | [`MessageDialogOptions`](interfaces/MessageDialogOptions.md) | Additional options. |

#### Returns

`Partial`\<[`Dialog`](classes/Dialog.md)\>

**`See`**

MessageDialogOptions

**`Example`**

```ts
warningDialog("Something is odd!");
```

#### Defined in

[src/base/dialogs.ts:926](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L926)

___

### yesDialogButton

▸ **yesDialogButton**(`opt?`): [`DialogButton`](interfaces/DialogButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt?` | [`DialogButton`](interfaces/DialogButton.md) |

#### Returns

[`DialogButton`](interfaces/DialogButton.md)

#### Defined in

[src/base/dialogs.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L562)

___

### zeroPad

▸ **zeroPad**(`n`, `len`): `string`

Pads the start of string to make it the specified length.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `n` | `number` | The number to pad. |
| `len` | `number` | Target length of the string. |

#### Returns

`string`

#### Defined in

[src/q/strings-compat.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings-compat.ts#L123)
