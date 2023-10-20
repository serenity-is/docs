@serenity-is/corelib

# @serenity-is/corelib

## Serenity Core Library

This is the package containing core TypeScript classes and functions used in Serenity applications. 

It should be installed by default in your projects created from `Serene` or `StartSharp` template:

```json
{
  "dependencies": {
    // ...
    "@serenity-is/corelib": "6.9.0"
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
- [Criteria](modules/Criteria.md)
- [Decorators](modules/Decorators.md)
- [DialogExtensions](modules/DialogExtensions.md)
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
- [LayoutTimer](modules/LayoutTimer.md)
- [LazyLoadHelper](modules/LazyLoadHelper.md)
- [PropertyItemSlickConverter](modules/PropertyItemSlickConverter.md)
- [ReflectionOptionsSetter](modules/ReflectionOptionsSetter.md)
- [ReflectionUtils](modules/ReflectionUtils.md)
- [Reporting](modules/Reporting.md)
- [Router](modules/Router.md)
- [ScriptData](modules/ScriptData.md)
- [SlickFormatting](modules/SlickFormatting.md)
- [SlickHelper](modules/SlickHelper.md)
- [SlickTreeHelper](modules/SlickTreeHelper.md)
- [SubDialogHelper](modules/SubDialogHelper.md)
- [TabsExtensions](modules/TabsExtensions.md)
- [UploadHelper](modules/UploadHelper.md)
- [VX](modules/VX.md)
- [ValidationHelper](modules/ValidationHelper.md)
- [WX](modules/WX.md)

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
- [ColumnPickerDialog](classes/ColumnPickerDialog.md)
- [ColumnsBase](classes/ColumnsBase.md)
- [ColumnsKeyAttribute](classes/ColumnsKeyAttribute.md)
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
- [DialogTypeAttribute](classes/DialogTypeAttribute.md)
- [DisplayNameAttribute](classes/DisplayNameAttribute.md)
- [EditorAttribute](classes/EditorAttribute.md)
- [EditorFiltering](classes/EditorFiltering.md)
- [EditorOptionAttribute](classes/EditorOptionAttribute.md)
- [EditorTypeAttribute](classes/EditorTypeAttribute.md)
- [EditorTypeAttributeBase](classes/EditorTypeAttributeBase.md)
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
- [Flexify](classes/Flexify.md)
- [FlexifyAttribute](classes/FlexifyAttribute.md)
- [FormKeyAttribute](classes/FormKeyAttribute.md)
- [GeneratedCodeAttribute](classes/GeneratedCodeAttribute.md)
- [GoogleMap](classes/GoogleMap.md)
- [GridRadioSelectionMixin](classes/GridRadioSelectionMixin.md)
- [GridRowSelectionMixin](classes/GridRowSelectionMixin.md)
- [HiddenAttribute](classes/HiddenAttribute.md)
- [HintAttribute](classes/HintAttribute.md)
- [HtmlContentEditor](classes/HtmlContentEditor.md)
- [HtmlNoteContentEditor](classes/HtmlNoteContentEditor.md)
- [HtmlReportContentEditor](classes/HtmlReportContentEditor.md)
- [IAsyncInit](classes/IAsyncInit.md)
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
- [LT](classes/LT.md)
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
- [PopupMenuButton](classes/PopupMenuButton.md)
- [PopupToolButton](classes/PopupToolButton.md)
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
- [ScriptContext](classes/ScriptContext.md)
- [Select2AjaxEditor](classes/Select2AjaxEditor.md)
- [Select2Editor](classes/Select2Editor.md)
- [SelectEditor](classes/SelectEditor.md)
- [ServiceAttribute](classes/ServiceAttribute.md)
- [ServiceLookupEditor](classes/ServiceLookupEditor.md)
- [ServiceLookupEditorBase](classes/ServiceLookupEditorBase.md)
- [ServiceLookupFiltering](classes/ServiceLookupFiltering.md)
- [SlickPager](classes/SlickPager.md)
- [StringEditor](classes/StringEditor.md)
- [StringFiltering](classes/StringFiltering.md)
- [TemplatedDialog](classes/TemplatedDialog.md)
- [TemplatedPanel](classes/TemplatedPanel.md)
- [TemplatedWidget](classes/TemplatedWidget.md)
- [TextAreaEditor](classes/TextAreaEditor.md)
- [TimeEditor](classes/TimeEditor.md)
- [Toastr](classes/Toastr.md)
- [Toolbar](classes/Toolbar.md)
- [TreeGridMixin](classes/TreeGridMixin.md)
- [URLEditor](classes/URLEditor.md)
- [UpdatableAttribute](classes/UpdatableAttribute.md)
- [UrlFormatter](classes/UrlFormatter.md)
- [Widget](classes/Widget.md)

### Interfaces

- [AlertOptions](interfaces/AlertOptions.md)
- [CKEditorConfig](interfaces/CKEditorConfig.md)
- [CheckLookupEditorOptions](interfaces/CheckLookupEditorOptions.md)
- [CheckTreeItem](interfaces/CheckTreeItem.md)
- [CommonDialogOptions](interfaces/CommonDialogOptions.md)
- [ConfirmOptions](interfaces/ConfirmOptions.md)
- [CreateWidgetParams](interfaces/CreateWidgetParams.md)
- [CriteriaWithText](interfaces/CriteriaWithText.md)
- [DataChangeInfo](interfaces/DataChangeInfo.md)
- [DateFormat](interfaces/DateFormat.md)
- [DateTimeEditorOptions](interfaces/DateTimeEditorOptions.md)
- [DateYearEditorOptions](interfaces/DateYearEditorOptions.md)
- [DebouncedFunction](interfaces/DebouncedFunction.md)
- [DecimalEditorOptions](interfaces/DecimalEditorOptions.md)
- [DeleteRequest](interfaces/DeleteRequest.md)
- [DeleteResponse](interfaces/DeleteResponse.md)
- [DialogButton](interfaces/DialogButton.md)
- [EmailEditorOptions](interfaces/EmailEditorOptions.md)
- [EnumEditorOptions](interfaces/EnumEditorOptions.md)
- [FileUploadConstraints](interfaces/FileUploadConstraints.md)
- [FileUploadEditorOptions](interfaces/FileUploadEditorOptions.md)
- [FilterLine](interfaces/FilterLine.md)
- [FilterOperator](interfaces/FilterOperator.md)
- [FlexifyOptions](interfaces/FlexifyOptions.md)
- [Formatter](interfaces/Formatter.md)
- [GoogleMapOptions](interfaces/GoogleMapOptions.md)
- [GridPersistanceFlags](interfaces/GridPersistanceFlags.md)
- [GridRadioSelectionMixinOptions](interfaces/GridRadioSelectionMixinOptions.md)
- [GridRowSelectionMixinOptions](interfaces/GridRowSelectionMixinOptions.md)
- [GroupInfo](interfaces/GroupInfo.md)
- [HandleRouteEventArgs](interfaces/HandleRouteEventArgs.md)
- [HtmlContentEditorOptions](interfaces/HtmlContentEditorOptions.md)
- [IDataGrid](interfaces/IDataGrid.md)
- [IFrameDialogOptions](interfaces/IFrameDialogOptions.md)
- [IRowDefinition](interfaces/IRowDefinition.md)
- [ImageUploadEditorOptions](interfaces/ImageUploadEditorOptions.md)
- [IntegerEditorOptions](interfaces/IntegerEditorOptions.md)
- [JQBlockUIOptions](interfaces/JQBlockUIOptions.md)
- [JsxDomWidget](interfaces/JsxDomWidget.md)
- [ListRequest](interfaces/ListRequest.md)
- [ListResponse](interfaces/ListResponse.md)
- [Locale](interfaces/Locale.md)
- [LookupEditorOptions](interfaces/LookupEditorOptions.md)
- [LookupOptions](interfaces/LookupOptions.md)
- [MaskedEditorOptions](interfaces/MaskedEditorOptions.md)
- [ModalOptions](interfaces/ModalOptions.md)
- [NumberFormat](interfaces/NumberFormat.md)
- [PagerOptions](interfaces/PagerOptions.md)
- [PagingInfo](interfaces/PagingInfo.md)
- [PagingOptions](interfaces/PagingOptions.md)
- [PersistedGridColumn](interfaces/PersistedGridColumn.md)
- [PersistedGridSettings](interfaces/PersistedGridSettings.md)
- [PopupMenuButtonOptions](interfaces/PopupMenuButtonOptions.md)
- [PopupToolButtonOptions](interfaces/PopupToolButtonOptions.md)
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
- [RetrieveLocalizationRequest](interfaces/RetrieveLocalizationRequest.md)
- [RetrieveLocalizationResponse](interfaces/RetrieveLocalizationResponse.md)
- [RetrieveRequest](interfaces/RetrieveRequest.md)
- [RetrieveResponse](interfaces/RetrieveResponse.md)
- [SaveRequest](interfaces/SaveRequest.md)
- [SaveRequestWithAttachment](interfaces/SaveRequestWithAttachment.md)
- [SaveResponse](interfaces/SaveResponse.md)
- [SaveWithLocalizationRequest](interfaces/SaveWithLocalizationRequest.md)
- [Select2CommonOptions](interfaces/Select2CommonOptions.md)
- [Select2EditorOptions](interfaces/Select2EditorOptions.md)
- [Select2FilterOptions](interfaces/Select2FilterOptions.md)
- [Select2InplaceAddOptions](interfaces/Select2InplaceAddOptions.md)
- [Select2SearchPromise](interfaces/Select2SearchPromise.md)
- [Select2SearchQuery](interfaces/Select2SearchQuery.md)
- [Select2SearchResult](interfaces/Select2SearchResult.md)
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
- [ToolbarOptions](interfaces/ToolbarOptions.md)
- [TreeGridMixinOptions](interfaces/TreeGridMixinOptions.md)
- [TypeMember](interfaces/TypeMember.md)
- [UndeleteRequest](interfaces/UndeleteRequest.md)
- [UndeleteResponse](interfaces/UndeleteResponse.md)
- [UploadInputOptions](interfaces/UploadInputOptions.md)
- [UploadResponse](interfaces/UploadResponse.md)
- [UploadedFile](interfaces/UploadedFile.md)
- [UserDefinition](interfaces/UserDefinition.md)
- [WidgetClass](interfaces/WidgetClass.md)
- [WidgetComponentProps](interfaces/WidgetComponentProps.md)
- [WidgetDialogClass](interfaces/WidgetDialogClass.md)

### Type Aliases

- [AnyWidgetClass](README.md#anywidgetclass)
- [CancellableViewCallback](README.md#cancellableviewcallback)
- [Constructor](README.md#constructor)
- [Dictionary](README.md#dictionary)
- [Format](README.md#format)
- [GroupByElement](README.md#groupbyelement)
- [GroupByResult](README.md#groupbyresult)
- [Grouping](README.md#grouping)
- [NotifyMap](README.md#notifymap)
- [RemoteViewAjaxCallback](README.md#remoteviewajaxcallback)
- [RemoteViewFilter](README.md#remoteviewfilter)
- [RemoteViewProcessCallback](README.md#remoteviewprocesscallback)
- [ToastContainerOptions](README.md#toastcontaineroptions)
- [ToastrOptions](README.md#toastroptions)
- [Type](README.md#type)

### Variables

- [Config](README.md#config)
- [Culture](README.md#culture)
- [Invariant](README.md#invariant)
- [datePickerIconSvg](README.md#datepickericonsvg)
- [defaultNotifyOptions](README.md#defaultnotifyoptions)

### Functions

- [Criteria](README.md#criteria)
- [addAttribute](README.md#addattribute)
- [addEmptyOption](README.md#addemptyoption)
- [addOption](README.md#addoption)
- [addTypeMember](README.md#addtypemember)
- [addValidationRule](README.md#addvalidationrule)
- [alert](README.md#alert)
- [alertDialog](README.md#alertdialog)
- [any](README.md#any)
- [attrEncode](README.md#attrencode)
- [baseValidateOptions](README.md#basevalidateoptions)
- [blockUI](README.md#blockui)
- [blockUndo](README.md#blockundo)
- [bsModalMarkup](README.md#bsmodalmarkup)
- [canLoadScriptData](README.md#canloadscriptdata)
- [cast](README.md#cast)
- [centerDialog](README.md#centerdialog)
- [clearKeys](README.md#clearkeys)
- [clearOptions](README.md#clearoptions)
- [closePanel](README.md#closepanel)
- [coalesce](README.md#coalesce)
- [compareStringFactory](README.md#comparestringfactory)
- [confirm](README.md#confirm)
- [confirmDialog](README.md#confirmdialog)
- [count](README.md#count)
- [dbText](README.md#dbtext)
- [dbTryText](README.md#dbtrytext)
- [debounce](README.md#debounce)
- [deepClone](README.md#deepclone)
- [delegateCombine](README.md#delegatecombine)
- [delegateRemove](README.md#delegateremove)
- [dialogButtonToBS](README.md#dialogbuttontobs)
- [dialogButtonToUI](README.md#dialogbuttontoui)
- [endsWith](README.md#endswith)
- [executeEverytimeWhenVisible](README.md#executeeverytimewhenvisible)
- [executeOnceWhenVisible](README.md#executeoncewhenvisible)
- [extend](README.md#extend)
- [fieldsProxy](README.md#fieldsproxy)
- [findElementWithRelativeId](README.md#findelementwithrelativeid)
- [first](README.md#first)
- [format](README.md#format-1)
- [formatDate](README.md#formatdate)
- [formatDayHourAndMin](README.md#formatdayhourandmin)
- [formatISODateTimeUTC](README.md#formatisodatetimeutc)
- [formatNumber](README.md#formatnumber)
- [getAttributes](README.md#getattributes)
- [getBaseType](README.md#getbasetype)
- [getColumns](README.md#getcolumns)
- [getColumnsAsync](README.md#getcolumnsasync)
- [getColumnsData](README.md#getcolumnsdata)
- [getColumnsDataAsync](README.md#getcolumnsdataasync)
- [getCookie](README.md#getcookie)
- [getForm](README.md#getform)
- [getFormAsync](README.md#getformasync)
- [getFormData](README.md#getformdata)
- [getFormDataAsync](README.md#getformdataasync)
- [getGlobalThis](README.md#getglobalthis)
- [getHighlightTarget](README.md#gethighlighttarget)
- [getInstanceType](README.md#getinstancetype)
- [getLookup](README.md#getlookup)
- [getLookupAsync](README.md#getlookupasync)
- [getMembers](README.md#getmembers)
- [getNested](README.md#getnested)
- [getRemoteData](README.md#getremotedata)
- [getRemoteDataAsync](README.md#getremotedataasync)
- [getStateStore](README.md#getstatestore)
- [getTemplate](README.md#gettemplate)
- [getTemplateAsync](README.md#gettemplateasync)
- [getType](README.md#gettype)
- [getTypeFullName](README.md#gettypefullname)
- [getTypeNameProp](README.md#gettypenameprop)
- [getTypeShortName](README.md#gettypeshortname)
- [getTypes](README.md#gettypes)
- [groupBy](README.md#groupby)
- [htmlEncode](README.md#htmlencode)
- [iframeDialog](README.md#iframedialog)
- [indexOf](README.md#indexof)
- [information](README.md#information)
- [informationDialog](README.md#informationdialog)
- [initFormType](README.md#initformtype)
- [initFullHeightGridPage](README.md#initfullheightgridpage)
- [initializeTypes](README.md#initializetypes)
- [insert](README.md#insert)
- [isArray](README.md#isarray)
- [isAssignableFrom](README.md#isassignablefrom)
- [isBS3](README.md#isbs3)
- [isBS5Plus](README.md#isbs5plus)
- [isEmptyOrNull](README.md#isemptyornull)
- [isEnum](README.md#isenum)
- [isInstanceOfType](README.md#isinstanceoftype)
- [isMobileView](README.md#ismobileview)
- [isTrimmedEmpty](README.md#istrimmedempty)
- [isValue](README.md#isvalue)
- [jsxDomWidget](README.md#jsxdomwidget)
- [keyOf](README.md#keyof)
- [layoutFillHeight](README.md#layoutfillheight)
- [layoutFillHeightValue](README.md#layoutfillheightvalue)
- [loadValidationErrorMessages](README.md#loadvalidationerrormessages)
- [localText](README.md#localtext)
- [localeFormat](README.md#localeformat)
- [newBodyDiv](README.md#newbodydiv)
- [notifyError](README.md#notifyerror)
- [notifyInfo](README.md#notifyinfo)
- [notifySuccess](README.md#notifysuccess)
- [notifyWarning](README.md#notifywarning)
- [openPanel](README.md#openpanel)
- [outerHtml](README.md#outerhtml)
- [padLeft](README.md#padleft)
- [parseCriteria](README.md#parsecriteria)
- [parseDate](README.md#parsedate)
- [parseDayHourAndMin](README.md#parsedayhourandmin)
- [parseDecimal](README.md#parsedecimal)
- [parseHourAndMin](README.md#parsehourandmin)
- [parseISODateTime](README.md#parseisodatetime)
- [parseInteger](README.md#parseinteger)
- [parseQueryString](README.md#parsequerystring)
- [positionToastContainer](README.md#positiontoastcontainer)
- [postToService](README.md#posttoservice)
- [postToUrl](README.md#posttourl)
- [prefixedText](README.md#prefixedtext)
- [prop](README.md#prop)
- [proxyTexts](README.md#proxytexts)
- [reactPatch](README.md#reactpatch)
- [registerClass](README.md#registerclass)
- [registerEditor](README.md#registereditor)
- [registerEnum](README.md#registerenum)
- [registerInterface](README.md#registerinterface)
- [reloadLookup](README.md#reloadlookup)
- [reloadLookupAsync](README.md#reloadlookupasync)
- [removeValidationRule](README.md#removevalidationrule)
- [replaceAll](README.md#replaceall)
- [resolveUrl](README.md#resolveurl)
- [round](README.md#round)
- [safeCast](README.md#safecast)
- [serviceCall](README.md#servicecall)
- [serviceRequest](README.md#servicerequest)
- [setEquality](README.md#setequality)
- [setTypeNameProp](README.md#settypenameprop)
- [single](README.md#single)
- [splitDateString](README.md#splitdatestring)
- [startsWith](README.md#startswith)
- [success](README.md#success)
- [successDialog](README.md#successdialog)
- [text](README.md#text)
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
- [turkishLocaleCompare](README.md#turkishlocalecompare)
- [turkishLocaleToLower](README.md#turkishlocaletolower)
- [turkishLocaleToUpper](README.md#turkishlocaletoupper)
- [useIdPrefix](README.md#useidprefix)
- [validateForm](README.md#validateform)
- [validateOptions](README.md#validateoptions)
- [validatorAbortHandler](README.md#validatoraborthandler)
- [warning](README.md#warning)
- [warningDialog](README.md#warningdialog)
- [zeroPad](README.md#zeropad)

## Type Aliases

### AnyWidgetClass

Ƭ **AnyWidgetClass**<`TOptions`\>: [`WidgetClass`](interfaces/WidgetClass.md)<`TOptions`\> \| [`WidgetDialogClass`](interfaces/WidgetDialogClass.md)<`TOptions`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | `object` |

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### CancellableViewCallback

Ƭ **CancellableViewCallback**<`TEntity`\>: (`view`: [`RemoteView`](classes/RemoteView.md)<`TEntity`\>) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](classes/RemoteView.md)<`TEntity`\> |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L37)

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

[src/index.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/index.ts#L109)

___

### Dictionary

Ƭ **Dictionary**<`TItem`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[src/q/system.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L1)

___

### Format

Ƭ **Format**<`TItem`\>: (`ctx`: `FormatterContext`<`TItem`\>) => `string`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`ctx`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`<`TItem`\> |

##### Returns

`string`

#### Defined in

[src/slick/slicktypes.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L4)

___

### GroupByElement

Ƭ **GroupByElement**<`TItem`\>: `Object`

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

[src/q/arrays.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L43)

___

### GroupByResult

Ƭ **GroupByResult**<`TItem`\>: `Object`

Return type of the `groupBy` function.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `byKey` | { `[key: string]`: [`GroupByElement`](README.md#groupbyelement)<`TItem`\>;  } |
| `inOrder` | [`GroupByElement`](README.md#groupbyelement)<`TItem`\>[] |

#### Defined in

[src/q/arrays.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L57)

___

### Grouping

Ƭ **Grouping**<`TItem`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Index signature

▪ [key: `string`]: `TItem`[]

#### Defined in

[src/q/arrays.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L169)

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

[src/q/toastr2.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L40)

___

### RemoteViewAjaxCallback

Ƭ **RemoteViewAjaxCallback**<`TEntity`\>: (`view`: [`RemoteView`](classes/RemoteView.md)<`TEntity`\>, `options`: `JQueryAjaxSettings`) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`, `options`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](classes/RemoteView.md)<`TEntity`\> |
| `options` | `JQueryAjaxSettings` |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L38)

___

### RemoteViewFilter

Ƭ **RemoteViewFilter**<`TEntity`\>: (`item`: `TEntity`, `view`: [`RemoteView`](classes/RemoteView.md)<`TEntity`\>) => `boolean`

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
| `view` | [`RemoteView`](classes/RemoteView.md)<`TEntity`\> |

##### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L39)

___

### RemoteViewProcessCallback

Ƭ **RemoteViewProcessCallback**<`TEntity`\>: (`data`: [`ListResponse`](interfaces/ListResponse.md)<`TEntity`\>, `view`: [`RemoteView`](classes/RemoteView.md)<`TEntity`\>) => [`ListResponse`](interfaces/ListResponse.md)<`TEntity`\>

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`data`, `view`): [`ListResponse`](interfaces/ListResponse.md)<`TEntity`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](interfaces/ListResponse.md)<`TEntity`\> |
| `view` | [`RemoteView`](classes/RemoteView.md)<`TEntity`\> |

##### Returns

[`ListResponse`](interfaces/ListResponse.md)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L40)

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

[src/q/toastr2.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L5)

___

### ToastrOptions

Ƭ **ToastrOptions**: [`ToastContainerOptions`](README.md#toastcontaineroptions) & { `closeButton?`: `boolean` ; `closeClass?`: `string` ; `closeDuration?`: `number` \| ``false`` ; `closeEasing?`: `boolean` ; `closeHtml?`: `string` ; `closeMethod?`: `boolean` ; `closeOnHover?`: `boolean` ; `escapeHtml?`: `boolean` ; `extendedTimeOut?`: `number` ; `hideDuration?`: `number` ; `iconClass?`: `string` ; `messageClass?`: `string` ; `newestOnTop?`: `boolean` ; `onCloseClick?`: (`event`: `Event`) => `void` ; `onHidden?`: () => `void` ; `onShown?`: () => `void` ; `onclick?`: (`event`: `MouseEvent`) => `void` ; `positionClass?`: `string` ; `preventDuplicates?`: `boolean` ; `rtl?`: `boolean` ; `showDuration?`: `number` ; `tapToDismiss?`: `boolean` ; `target?`: `string` ; `timeOut?`: `number` ; `titleClass?`: `string` ; `toastClass?`: `string`  }

#### Defined in

[src/q/toastr2.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L11)

___

### Type

Ƭ **Type**: `Function` \| `Object`

#### Defined in

[src/q/system.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L84)

## Variables

### Config

• **Config**: `Object`

#### Type declaration

| Name | Type | Description |
| :------ | :------ | :------ |
| `applicationPath` | `string` | This is the root path of your application. If your application resides under http://localhost/mysite/, your root path is "mysite/". This variable is automatically initialized by reading from a <link> element with ID "ApplicationPath" from current page, which is usually located in your _LayoutHead.cshtml file |
| `bootstrapMessages` | `boolean` | Set this to true, to prefer bootstrap dialogs over jQuery UI dialogs by default for message dialogs |
| `emailAllowOnlyAscii` | `boolean` | Email validation by default only allows ASCII characters. Set this to true if you want to allow unicode. |
| `notLoggedInHandler` | `Function` | This is an optional method for handling when user is not logged in. If a users session is expired and when a NotAuthorized response is received from a service call, Serenity will call this handler, so you may intercept it and notify user about this situation and ask if she wants to login again... |
| `responsiveDialogs` | `boolean` | **`Obsolete`** defaulted to false before for backward compatibility, now it is true by default |
| `rootNamespaces` | `string`[] | This is the list of root namespaces that may be searched for types. For example, if you specify an editor type of "MyEditor", first a class with name "MyEditor" will be searched, if not found, search will be followed by "Serenity.MyEditor" and "MyApp.MyEditor" if you added "MyApp" to the list of root namespaces. You should usually add your application root namespace to this list in ScriptInit(ialization).ts file. |

#### Defined in

[src/q/config.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/config.ts#L1)

___

### Culture

• **Culture**: [`Locale`](interfaces/Locale.md)

Current culture, e.g. CultureInfo.CurrentCulture. This is overridden by
settings passed from a `<script>` element in the page with id `ScriptCulture`
containing a JSON object if available. This element is generally created in 
the _LayoutHead.cshtml file for Serenity applications, so that the culture
settings determined server, can be passed to the client.

#### Defined in

[src/q/formatting.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L132)

___

### Invariant

• **Invariant**: [`Locale`](interfaces/Locale.md)

Invariant locale (e.g. CultureInfo.InvariantCulture)

#### Defined in

[src/q/formatting.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L64)

___

### datePickerIconSvg

• **datePickerIconSvg**: `string` = `'<svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 0 17 17"><g></g><path d="M14 2v-1h-3v1h-5v-1h-3v1h-3v15h17v-15h-3zM12 2h1v2h-1v-2zM4 2h1v2h-1v-2zM16 16h-15v-8.921h15v8.921zM1 6.079v-3.079h2v2h3v-2h5v2h3v-2h2v3.079h-15z" fill="currentColor"></path></svg>'`

#### Defined in

[src/ui/editors/dateeditor.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L6)

___

### defaultNotifyOptions

• **defaultNotifyOptions**: [`ToastrOptions`](README.md#toastroptions)

#### Defined in

[src/q/notify.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/notify.ts#L10)

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

[src/q/criteria.ts:750](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L750)

___

### addAttribute

▸ **addAttribute**(`type`, `attr`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `attr` | `any` |

#### Returns

`void`

#### Defined in

[src/q/system.ts:605](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L605)

___

### addEmptyOption

▸ **addEmptyOption**(`select`): `void`

Adds an empty option to the select.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `select` | `JQuery` \| `HTMLSelectElement` | the select element |

#### Returns

`void`

#### Defined in

[src/q/html.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L8)

___

### addOption

▸ **addOption**(`select`, `key`, `text`): `void`

Adds an option to the select.

#### Parameters

| Name | Type |
| :------ | :------ |
| `select` | `JQuery` \| `HTMLSelectElement` |
| `key` | `string` |
| `text` | `string` |

#### Returns

`void`

#### Defined in

[src/q/html.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L15)

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

[src/q/system.ts:279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L279)

___

### addValidationRule

▸ **addValidationRule**(`element`, `eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Defined in

[src/q/validation.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L234)

___

### alert

▸ **alert**(`message`, `options?`): `void`

**`Obsolete`**

use alertDialog

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `options?` | [`AlertOptions`](interfaces/AlertOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L328)

___

### alertDialog

▸ **alertDialog**(`message`, `options?`): `void`

Displays an alert dialog

**`See`**

AlertOptions

**`Example`**

```ts
alertDialog("An error occured!"); }
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `options?` | [`AlertOptions`](interfaces/AlertOptions.md) | Additional options. |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L328)

___

### any

▸ **any**<`TItem`\>(`array`, `predicate`): `boolean`

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

[src/q/arrays.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L7)

___

### attrEncode

▸ **attrEncode**(`s`): `string`

**`Obsolete`**

use htmlEncode as it also encodes quotes

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `any` |

#### Returns

`string`

#### Defined in

[src/q/html.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L100)

___

### baseValidateOptions

▸ **baseValidateOptions**(): `JQueryValidation.ValidationOptions`

#### Returns

`JQueryValidation.ValidationOptions`

#### Defined in

[src/q/validation.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L157)

___

### blockUI

▸ **blockUI**(`options`): `void`

Uses jQuery BlockUI plugin to block access to whole page (default) or 
a part of it, by using a transparent overlay covering the whole area.

**`Remarks`**

If options are not specified, this function blocks 
whole page with a transparent overlay. Default z-order of the overlay
div is 2000, so a higher z-order shouldn't be used in page.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `options` | [`JQBlockUIOptions`](interfaces/JQBlockUIOptions.md) | Parameters for the BlockUI plugin |

#### Returns

`void`

#### Defined in

[src/q/blockui.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/blockui.ts#L36)

___

### blockUndo

▸ **blockUndo**(): `void`

Unblocks the page.

#### Returns

`void`

#### Defined in

[src/q/blockui.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/blockui.ts#L60)

___

### bsModalMarkup

▸ **bsModalMarkup**(`title`, `body`, `modalClass?`, `escapeHtml?`): `HTMLDivElement`

Builds HTML DIV element for a Bootstrap modal dialog

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `title` | `string` | `undefined` | Modal title |
| `body` | `string` | `undefined` | Modal body, it will not be HTML encoded, so make sure it is encoded |
| `modalClass?` | `string` | `undefined` | Optional class to add to the modal element |
| `escapeHtml` | `boolean` | `true` | True to html encode body, default is true |

#### Returns

`HTMLDivElement`

#### Defined in

[src/q/dialogs.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L147)

___

### canLoadScriptData

▸ **canLoadScriptData**(`name`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`boolean`

#### Defined in

[src/q/scriptdata.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L281)

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

[src/q/system.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L195)

___

### centerDialog

▸ **centerDialog**(`el`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L99)

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

[src/q/system.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L335)

___

### clearOptions

▸ **clearOptions**(`select`): `void`

Clears the options in the select element

#### Parameters

| Name | Type |
| :------ | :------ |
| `select` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/q/html.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L23)

___

### closePanel

▸ **closePanel**(`element`, `e?`): `void`

Closes a panel, triggering panelbeforeclose and panelclose events on the panel element.
If the panelbeforeclose prevents the default, the operation is cancelled.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `HTMLElement` \| `JQuery` | The panel element |
| `e?` | `Event` | The event triggering the close |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:602](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L602)

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

#### Defined in

[src/q/system.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L3)

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

[src/q/formatting.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L92)

___

### confirm

▸ **confirm**(`message`, `onYes`, `options?`): `void`

**`Obsolete`**

use confirmDialog

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `onYes` | () => `void` |
| `options?` | [`ConfirmOptions`](interfaces/ConfirmOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:396](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L396)

___

### confirmDialog

▸ **confirmDialog**(`message`, `onYes`, `options?`): `void`

Display a confirmation dialog

**`See`**

ConfirmOptions

**`Example`**

```ts
confirmDialog("Are you sure you want to delete?", () => { 
    // do something when yes is clicked
}
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `onYes` | () => `void` | Callback for Yes button click |
| `options?` | [`ConfirmOptions`](interfaces/ConfirmOptions.md) | Additional options. |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:396](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L396)

___

### count

▸ **count**<`TItem`\>(`array`, `predicate`): `number`

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

[src/q/arrays.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L16)

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

[src/q/localtext.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L15)

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

[src/q/localtext.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L57)

___

### debounce

▸ **debounce**<`T`\>(`func`, `wait?`, `immediate?`): [`DebouncedFunction`](interfaces/DebouncedFunction.md)<`T`\>

Returns a function, that, as long as it continues to be invoked, will not
be triggered. The function also has a property 'clear' that can be used 
to clear the timer to prevent previously scheduled executions, and flush method
to invoke scheduled executions now if any.

**`Source`**

underscore.js

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

[`DebouncedFunction`](interfaces/DebouncedFunction.md)<`T`\>

#### Defined in

[src/q/debounce.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/debounce.ts#L39)

___

### deepClone

▸ **deepClone**<`T`\>(`a`, `a2?`, `a3?`): `T`

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

[src/q/system.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L23)

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

[src/q/system.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L342)

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

[src/q/system.ts:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L454)

___

### dialogButtonToBS

▸ **dialogButtonToBS**(`x`): `HTMLButtonElement`

Converts a `DialogButton` declaration to Bootstrap button element

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `x` | [`DialogButton`](interfaces/DialogButton.md) | Dialog button declaration |

#### Returns

`HTMLButtonElement`

Bootstrap button element

#### Defined in

[src/q/dialogs.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L172)

___

### dialogButtonToUI

▸ **dialogButtonToUI**(`x`): `any`

Converts a `DialogButton` declaration to jQuery UI button type

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `x` | [`DialogButton`](interfaces/DialogButton.md) | Dialog button declaration |

#### Returns

`any`

jQuery UI button type

#### Defined in

[src/q/dialogs.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L191)

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

#### Defined in

[src/q/strings.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L7)

___

### executeEverytimeWhenVisible

▸ **executeEverytimeWhenVisible**(`element`, `callback`, `callNowIfVisible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `callback` | `Function` |
| `callNowIfVisible` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/layouttimer.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L154)

___

### executeOnceWhenVisible

▸ **executeOnceWhenVisible**(`element`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `callback` | `Function` |

#### Returns

`void`

#### Defined in

[src/q/layouttimer.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L138)

___

### extend

▸ **extend**<`T`\>(`a`, `b`): `T`

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

[src/q/system.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L16)

___

### fieldsProxy

▸ **fieldsProxy**<`TRow`\>(): `Readonly`<`Record`<keyof `TRow`, `string`\>\>

#### Type parameters

| Name |
| :------ |
| `TRow` |

#### Returns

`Readonly`<`Record`<keyof `TRow`, `string`\>\>

#### Defined in

[src/q/system.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L538)

___

### findElementWithRelativeId

▸ **findElementWithRelativeId**(`element`, `relativeId`, `context?`): `JQuery`

Finds the first element with the given relative id to the source element.
It can handle underscores in the source element id.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `JQuery` | the source element |
| `relativeId` | `string` | the relative id to the source element |
| `context?` | `HTMLElement` | the context element (optional) |

#### Returns

`JQuery`

the element with the given relative id to the source element.

#### Defined in

[src/q/html.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L35)

▸ **findElementWithRelativeId**(`element`, `relativeId`, `context?`): `HTMLElement`

Finds the first element with the given relative id to the source element.
It can handle underscores in the source element id.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `HTMLElement` | the source element |
| `relativeId` | `string` | the relative id to the source element |
| `context?` | `HTMLElement` | the context element (optional) |

#### Returns

`HTMLElement`

the element with the given relative id to the source element.

#### Defined in

[src/q/html.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L44)

___

### first

▸ **first**<`TItem`\>(`array`, `predicate`): `TItem`

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

[src/q/arrays.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L32)

___

### format

▸ **format**(`format`, `...prm`): `string`

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

[src/q/formatting.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L265)

___

### formatDate

▸ **formatDate**(`d`, `format?`, `locale?`): `string`

Formats a date using the specified format string and optional culture.
Supports .NET style format strings including custom formats.
See .NET documentation for supported formats.

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

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `d` | `string` \| `Date` | the date to format. If null, it returns empty string. |
| `format?` | `string` | the format string to use. If null, it uses the current culture's default format. 'G' uses the culture's datetime format. 'g' uses the culture's datetime format with secs removed. 'd' uses the culture's date format. 't' uses the culture's time format. 'u' uses the sortable ISO format with UTC time. 'U' uses the culture's date format with UTC time. |
| `locale?` | [`Locale`](interfaces/Locale.md) | the locale to use |

#### Returns

`string`

the formatted date

#### Defined in

[src/q/formatting.ts:671](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L671)

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

[src/q/formatting.ts:842](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L842)

___

### formatISODateTimeUTC

▸ **formatISODateTimeUTC**(`d`): `string`

Formats a date as the ISO 8601 UTC date/time format.

#### Parameters

| Name | Type |
| :------ | :------ |
| `d` | `Date` |

#### Returns

`string`

#### Defined in

[src/q/formatting.ts:865](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L865)

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

[src/q/formatting.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L318)

___

### getAttributes

▸ **getAttributes**(`type`, `attrType`, `inherit?`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `attrType` | `any` |
| `inherit?` | `boolean` |

#### Returns

`any`[]

#### Defined in

[src/q/system.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L228)

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

[src/q/system.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L203)

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

[src/q/scriptdata.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L241)

___

### getColumnsAsync

▸ **getColumnsAsync**(`key`): `Promise`<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Defined in

[src/q/scriptdata.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L249)

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

[src/q/scriptdata.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L245)

___

### getColumnsDataAsync

▸ **getColumnsDataAsync**(`key`): `Promise`<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

#### Defined in

[src/q/scriptdata.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L253)

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

[src/q/services.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L8)

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

[src/q/scriptdata.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L257)

___

### getFormAsync

▸ **getFormAsync**(`key`): `Promise`<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<[`PropertyItem`](interfaces/PropertyItem.md)[]\>

#### Defined in

[src/q/scriptdata.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L265)

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

[src/q/scriptdata.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L261)

___

### getFormDataAsync

▸ **getFormDataAsync**(`key`): `Promise`<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<[`PropertyItemsData`](interfaces/PropertyItemsData.md)\>

#### Defined in

[src/q/scriptdata.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L269)

___

### getGlobalThis

▸ **getGlobalThis**(): `any`

#### Returns

`any`

#### Defined in

[src/q/system.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L116)

___

### getHighlightTarget

▸ **getHighlightTarget**(`el`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` |

#### Returns

`HTMLElement`

#### Defined in

[src/q/validation.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L149)

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

[src/q/system.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L158)

___

### getLookup

▸ **getLookup**<`TItem`\>(`key`): [`Lookup`](classes/Lookup.md)<`TItem`\>

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`Lookup`](classes/Lookup.md)<`TItem`\>

#### Defined in

[src/q/scriptdata.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L225)

___

### getLookupAsync

▸ **getLookupAsync**<`TItem`\>(`key`): `Promise`<[`Lookup`](classes/Lookup.md)<`TItem`\>\>

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<[`Lookup`](classes/Lookup.md)<`TItem`\>\>

#### Defined in

[src/q/scriptdata.ts:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L229)

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

[src/q/system.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L262)

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

[src/q/system.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L98)

___

### getRemoteData

▸ **getRemoteData**<`TData`\>(`key`): `TData`

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

[src/q/scriptdata.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L217)

___

### getRemoteDataAsync

▸ **getRemoteDataAsync**<`TData`\>(`key`): `Promise`<`TData`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<`TData`\>

#### Defined in

[src/q/scriptdata.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L221)

___

### getStateStore

▸ **getStateStore**(`key?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

`any`

#### Defined in

[src/q/system.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L365)

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

[src/q/scriptdata.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L273)

___

### getTemplateAsync

▸ **getTemplateAsync**(`key`): `Promise`<`string`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<`string`\>

#### Defined in

[src/q/scriptdata.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L277)

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

[src/q/system.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L120)

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

[src/q/system.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L146)

___

### getTypeNameProp

▸ **getTypeNameProp**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`Type`](README.md#type) |

#### Returns

`string`

#### Defined in

[src/q/system.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L138)

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

[src/q/system.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L151)

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

[src/q/system.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L310)

___

### groupBy

▸ **groupBy**<`TItem`\>(`items`, `getKey`): [`GroupByResult`](README.md#groupbyresult)<`TItem`\>

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

[`GroupByResult`](README.md#groupbyresult)<`TItem`\>

GroupByResult object.

#### Defined in

[src/q/arrays.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L70)

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

[src/q/html.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L100)

___

### iframeDialog

▸ **iframeDialog**(`options`): `void`

Display a dialog that shows an HTML block in an IFRAME, which is usually returned from server callbacks

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `options` | [`IFrameDialogOptions`](interfaces/IFrameDialogOptions.md) | The options |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L465)

___

### indexOf

▸ **indexOf**<`TItem`\>(`array`, `predicate`): `number`

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

[src/q/arrays.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L103)

___

### information

▸ **information**(`message`, `onOk?`, `options?`): `void`

**`Obsolete`**

use informationDialog

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `onOk?` | () => `void` |
| `options?` | [`ConfirmOptions`](interfaces/ConfirmOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L525)

___

### informationDialog

▸ **informationDialog**(`message`, `onOk?`, `options?`): `void`

Display an information dialog

**`See`**

ConfirmOptions

**`Example`**

```ts
informationDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `onOk?` | () => `void` | Callback for OK button click |
| `options?` | [`ConfirmOptions`](interfaces/ConfirmOptions.md) | Additional options. |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L525)

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

[src/q/system.ts:492](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L492)

___

### initFullHeightGridPage

▸ **initFullHeightGridPage**(`gridDiv`, `opt?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `gridDiv` | `HTMLElement` \| `JQuery` |
| `opt?` | `Object` |
| `opt.noRoute?` | `boolean` |
| `opt.setHeight?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L7)

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

[src/q/system.ts:621](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L621)

___

### insert

▸ **insert**(`obj`, `index`, `item`): `void`

Inserts an item to the array at specified index. Prefer Array.splice unless
you need to support IE.

**`Throws`**

Error if object does not support insert.

**`Example`**

```ts
insert([1, 2, 3], 1, 4); // [1, 4, 2, 3]
insert({ insert: (index, item) => { this.splice(index, 0, item); } }
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `obj` | `any` | Array or array like object to insert to. |
| `index` | `number` | Index to insert at. |
| `item` | `any` | Item to insert. |

#### Returns

`void`

#### Defined in

[src/q/arrays.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L122)

___

### isArray

▸ **isArray**(`arg`): arg is any[]

Determines if the object is an array. Prefer Array.isArray over this function (e.g. `Array.isArray(obj)`).

**`Example`**

```ts
isArray([1, 2, 3]); // true
isArray({}); // false
```

#### Parameters

| Name | Type |
| :------ | :------ |
| `arg` | `any` |

#### Returns

arg is any[]

True if the object is an array.

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1491

___

### isAssignableFrom

▸ **isAssignableFrom**(`target`, `type`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `any` |
| `type` | [`Type`](README.md#type) |

#### Returns

`boolean`

#### Defined in

[src/q/system.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L171)

___

### isBS3

▸ **isBS3**(): `boolean`

Returns true if Bootstrap 3 is loaded

#### Returns

`boolean`

#### Defined in

[src/q/dialogs.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L109)

___

### isBS5Plus

▸ **isBS5Plus**(): `boolean`

Returns true if Bootstrap 5+ is loaded

#### Returns

`boolean`

#### Defined in

[src/q/dialogs.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L117)

___

### isEmptyOrNull

▸ **isEmptyOrNull**(`s`): `boolean`

Checks if the string is empty or null.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | String to check. |

#### Returns

`boolean`

True if the string is empty or null.

#### Defined in

[src/q/strings.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L16)

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

[src/q/system.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L487)

___

### isInstanceOfType

▸ **isInstanceOfType**(`instance`, `type`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `instance` | `any` |
| `type` | [`Type`](README.md#type) |

#### Returns

`boolean`

#### Defined in

[src/q/system.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L181)

___

### isMobileView

▸ **isMobileView**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/q/layout.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L69)

___

### isTrimmedEmpty

▸ **isTrimmedEmpty**(`s`): `boolean`

Checks if the string is empty or null or whitespace.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `s` | `string` | String to check. |

#### Returns

`boolean`

True if the string is empty or null or whitespace.

#### Defined in

[src/q/strings.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L25)

___

### isValue

▸ **isValue**(`a`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `any` |

#### Returns

`boolean`

#### Defined in

[src/q/system.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L7)

___

### jsxDomWidget

▸ **jsxDomWidget**<`TWidget`, `TOptions`\>(`type`): [`JsxDomWidget`](interfaces/JsxDomWidget.md)<`TOptions` & { `ref?`: (`r`: `TWidget`) => `void`  }\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](classes/Widget.md)<`TOptions`, `TWidget`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (`element`: `JQuery`, `options?`: `TOptions`) => `TWidget` |

#### Returns

[`JsxDomWidget`](interfaces/JsxDomWidget.md)<`TOptions` & { `ref?`: (`r`: `TWidget`) => `void`  }\>

#### Defined in

[src/ui/widgets/jsx.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/jsx.ts#L74)

___

### keyOf

▸ **keyOf**<`T`\>(`prop`): keyof `T`

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

[src/q/system.ts:542](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L542)

___

### layoutFillHeight

▸ **layoutFillHeight**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L61)

___

### layoutFillHeightValue

▸ **layoutFillHeightValue**(`element`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`number`

#### Defined in

[src/q/layout.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L46)

___

### loadValidationErrorMessages

▸ **loadValidationErrorMessages**(): `void`

#### Returns

`void`

#### Defined in

[src/q/validation.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L116)

___

### localText

▸ **localText**(`key`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`string`

#### Defined in

[src/q/localtext.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L4)

___

### localeFormat

▸ **localeFormat**(`l`, `format`, `...prm`): `string`

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

[src/q/formatting.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L273)

___

### newBodyDiv

▸ **newBodyDiv**(): `JQuery`

Creates a new DIV and appends it to the body.

#### Returns

`JQuery`

the new DIV element.

#### Defined in

[src/q/html.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L114)

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

[src/q/notify.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/notify.ts#L78)

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

[src/q/notify.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/notify.ts#L74)

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

[src/q/notify.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/notify.ts#L70)

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

[src/q/notify.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/notify.ts#L66)

___

### openPanel

▸ **openPanel**(`element`, `uniqueName?`): `void`

Opens a panel, triggering panelbeforeopen and panelopen events on the panel element,
and panelopening and panelopened events on the window.
If the panelbeforeopen prevents the default, the operation is cancelled.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `HTMLElement` \| `JQuery` | The panel element |
| `uniqueName?` | `string` | A unique name for the panel. If not specified, the panel id is used. If the panel has no id, a timestamp is used. |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:674](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L674)

___

### outerHtml

▸ **outerHtml**(`element`): `string`

Returns the outer HTML of the element.

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`string`

#### Defined in

[src/q/html.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L121)

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

[src/q/strings.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L36)

___

### parseCriteria

▸ **parseCriteria**(`expression`, `params?`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The string may optionally contain parameters like `A >= @p1 and B < @p2`.

**`Example`**

```ts
parseCriteria('A >=
```

**`P1`**

and B < @p2', { p1: 5, p2: 4 }) // [[[a], '>=' 5], 'and', [[b], '<', 4]]

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `expression` | `string` | The criteria expression. |
| `params?` | `any` | The dictionary containing parameter values like { p1: 10, p2: 20 }. |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L694)

▸ **parseCriteria**(`strings`, `...values`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The expression may contain parameter placeholders like `A >= ${p1}`
where p1 is a variable in the scope.

**`Example`**

```ts
var a = 5, b = 4;
parseCriteria`A >= ${a} and B < ${b}` // [[[a], '>=' 5], 'and', [[b], '<', 4]]
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `strings` | `TemplateStringsArray` | The string fragments. |
| `...values` | `any`[] | The tagged template arguments. |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L705)

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

[src/q/formatting.ts:964](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L964)

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

[src/q/formatting.ts:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L935)

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

[src/q/formatting.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L574)

___

### parseHourAndMin

▸ **parseHourAndMin**(`value`): `number`

Parses a time string in the format "hh:mm" into a number containing number of minutes.
Returns NaN if the hours not in range 0-23 or minutes not in range 0-59.

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`number`

#### Defined in

[src/q/formatting.ts:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L908)

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

[src/q/formatting.ts:887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L887)

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

[src/q/formatting.ts:552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L552)

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

[src/q/services.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L153)

___

### positionToastContainer

▸ **positionToastContainer**(`create`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `create` | `boolean` |
| `options?` | [`ToastrOptions`](README.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/q/notify.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/notify.ts#L82)

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

[src/q/services.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L169)

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

[src/q/services.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L191)

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

[src/q/localtext.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L25)

___

### prop

▸ **prop**(`type`, `name`, `getter?`, `setter?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `name` | `string` |
| `getter?` | `string` |
| `setter?` | `string` |

#### Returns

`void`

#### Defined in

[src/q/system.ts:506](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L506)

___

### proxyTexts

▸ **proxyTexts**(`o`, `p`, `t`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `o` | `Record`<`string`, `any`\> |
| `p` | `string` |
| `t` | `Record`<`string`, `any`\> |

#### Returns

`Object`

#### Defined in

[src/q/localtext.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L63)

___

### reactPatch

▸ **reactPatch**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L19)

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

[src/q/system.ts:579](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L579)

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

[src/q/system.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L584)

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

[src/q/system.ts:589](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L589)

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

[src/q/system.ts:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L599)

___

### reloadLookup

▸ **reloadLookup**<`TItem`\>(`key`): [`Lookup`](classes/Lookup.md)<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`Lookup`](classes/Lookup.md)<`TItem`\>

#### Defined in

[src/q/scriptdata.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L233)

___

### reloadLookupAsync

▸ **reloadLookupAsync**<`TItem`\>(`key`): `Promise`<[`Lookup`](classes/Lookup.md)<`TItem`\>\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`Promise`<[`Lookup`](classes/Lookup.md)<`TItem`\>\>

#### Defined in

[src/q/scriptdata.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L237)

___

### removeValidationRule

▸ **removeValidationRule**(`element`, `eventClass`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `eventClass` | `string` |

#### Returns

`JQuery`

#### Defined in

[src/q/validation.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L243)

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

[src/q/strings.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L111)

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

[src/q/services.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L217)

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

[src/q/formatting.ts:294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L294)

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

[src/q/system.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L191)

___

### serviceCall

▸ **serviceCall**<`TResponse`\>(`options`): `JQueryXHR`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TResponse` | extends [`ServiceResponse`](interfaces/ServiceResponse.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](interfaces/ServiceOptions.md)<`TResponse`\> |

#### Returns

`JQueryXHR`

#### Defined in

[src/q/services.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L28)

___

### serviceRequest

▸ **serviceRequest**<`TResponse`\>(`service`, `request?`, `onSuccess?`, `options?`): `JQueryXHR`

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
| `options?` | [`ServiceOptions`](interfaces/ServiceOptions.md)<`TResponse`\> |

#### Returns

`JQueryXHR`

#### Defined in

[src/q/services.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L124)

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

[src/q/services.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/services.ts#L133)

___

### setTypeNameProp

▸ **setTypeNameProp**(`type`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`Type`](README.md#type) |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/q/system.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L142)

___

### single

▸ **single**<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate.
Throws an error if no matches is found, or there are multiple matches.

**`Example`**

```ts
first([1, 2, 3], x => x == 2); // 2
first([1, 2, 3], x => x == 4); // throws error.
```

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

[src/q/arrays.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L151)

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

[src/q/formatting.ts:1038](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L1038)

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

#### Defined in

[src/q/strings.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L51)

___

### success

▸ **success**(`message`, `onOk?`, `options?`): `void`

**`Obsolete`**

use successDialog

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `onOk?` | () => `void` |
| `options?` | [`ConfirmOptions`](interfaces/ConfirmOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:556](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L556)

___

### successDialog

▸ **successDialog**(`message`, `onOk?`, `options?`): `void`

Display a success dialog

**`See`**

ConfirmOptions

**`Example`**

```ts
successDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `onOk?` | () => `void` | Callback for OK button click |
| `options?` | [`ConfirmOptions`](interfaces/ConfirmOptions.md) | Additional options. |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:556](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L556)

___

### text

▸ **text**(`key`): `string`

**`Obsolete`**

prefer localText for better discoverability

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`string`

#### Defined in

[src/q/localtext.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L4)

___

### toGrouping

▸ **toGrouping**<`TItem`\>(`items`, `getKey`): [`Grouping`](README.md#grouping)<`TItem`\>

Maps an array into a dictionary with keys determined by specified getKey() callback,
and values that are arrays containing elements for a particular key.

**`Example`**

```ts
toGrouping([1, 2, 3], x => x % 2 == 0 ? "even" : "odd"); // { odd: [1, 3], even: [2] }
```

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

[`Grouping`](README.md#grouping)<`TItem`\>

Grouping object.

#### Defined in

[src/q/arrays.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L180)

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

[src/q/formatting.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L628)

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

[src/q/strings.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L59)

___

### today

▸ **today**(): `Date`

#### Returns

`Date`

#### Defined in

[src/q/system.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/system.ts#L11)

___

### toggleClass

▸ **toggleClass**(`el`, `cls`, `remove?`): `void`

Toggles the class on the element handling spaces like jQuery addClass does.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `el` | `Element` | the element |
| `cls` | `string` | the class to toggle |
| `remove?` | `boolean` | if true, the class will be added, if false the class will be removed, otherwise it will be toggled. |

#### Returns

`void`

#### Defined in

[src/q/html.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html.ts#L132)

___

### triggerLayoutOnShow

▸ **triggerLayoutOnShow**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/q/layout.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layout.ts#L93)

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

[src/q/strings.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L81)

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

[src/q/strings.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L66)

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

[src/q/strings.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L73)

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

[src/q/strings.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L89)

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

[src/q/strings.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L97)

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

[src/q/formatting.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L309)

___

### tryFirst

▸ **tryFirst**<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate (similar to LINQ's FirstOrDefault).
Returns null if no match is found.

**`Example`**

```ts
tryFirst([1, 2, 3], x => x == 2); // 2
tryFirst([1, 2, 3], x => x == 4); // null
```

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

[src/q/arrays.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays.ts#L204)

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

[src/q/localtext.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L52)

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

[src/q/formatting.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L58)

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

[src/q/formatting.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L170)

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

[src/q/formatting.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/formatting.ts#L180)

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

___

### validateForm

▸ **validateForm**(`form`, `opt`): `JQueryValidation.Validator`

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `JQuery` |
| `opt` | `ValidationOptions` |

#### Returns

`JQueryValidation.Validator`

#### Defined in

[src/q/validation.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L230)

___

### validateOptions

▸ **validateOptions**(`options?`): `ValidationOptions`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | `ValidationOptions` |

#### Returns

`ValidationOptions`

#### Defined in

[src/q/validateoptions.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validateoptions.ts#L61)

___

### validatorAbortHandler

▸ **validatorAbortHandler**(`validator`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `validator` | `any` |

#### Returns

`void`

#### Defined in

[src/q/validateoptions.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validateoptions.ts#L54)

___

### warning

▸ **warning**(`message`, `options?`): `void`

**`Obsolete`**

use warningDialog

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `options?` | [`AlertOptions`](interfaces/AlertOptions.md) |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L584)

___

### warningDialog

▸ **warningDialog**(`message`, `options?`): `void`

Display a warning dialog

**`See`**

AlertOptions

**`Example`**

```ts
warningDialog("Something is odd!");
```

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `message` | `string` | The message to display |
| `options?` | [`AlertOptions`](interfaces/AlertOptions.md) | Additional options. |

#### Returns

`void`

#### Defined in

[src/q/dialogs.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L584)

___

### zeroPad

▸ **zeroPad**(`n`, `len`): `string`

Pads the start of string to make it the specified length.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `n` | `number` | - |
| `len` | `number` | Target length of the string. |

#### Returns

`string`

#### Defined in

[src/q/strings.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/strings.ts#L121)
