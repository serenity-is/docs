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

- [AggregateFormatting](corelib.md#aggregateformatting)
- [Aggregators](corelib.md#aggregators)
- [AlertOptions](corelib.md#alertoptions)
- [ArgumentNullException](corelib.md#argumentnullexception)
- [Authorization](corelib.md#authorization)
- [CancellableViewCallback](corelib.md#cancellableviewcallback)
- [ColumnSelection](corelib.md#columnselection)
- [CommonDialogOptions](corelib.md#commondialogoptions)
- [Config](corelib.md#config)
- [ConfirmOptions](corelib.md#confirmoptions)
- [Criteria](corelib.md#criteria)
- [CriteriaBuilder](corelib.md#criteriabuilder)
- [CriteriaOperator](corelib.md#criteriaoperator)
- [Culture](corelib.md#culture)
- [DateFormat](corelib.md#dateformat)
- [DebouncedFunction](corelib.md#debouncedfunction)
- [DeleteRequest](corelib.md#deleterequest)
- [DeleteResponse](corelib.md#deleteresponse)
- [DialogButton](corelib.md#dialogbutton)
- [Dictionary](corelib.md#dictionary)
- [EditorAttribute](corelib.md#editorattribute)
- [Enum](corelib.md#enum)
- [ErrorHandling](corelib.md#errorhandling)
- [Exception](corelib.md#exception)
- [Format](corelib.md#format)
- [Formatter](corelib.md#formatter)
- [GroupByElement](corelib.md#groupbyelement)
- [GroupByResult](corelib.md#groupbyresult)
- [GroupInfo](corelib.md#groupinfo)
- [Grouping](corelib.md#grouping)
- [HandleRouteEventArgs](corelib.md#handlerouteeventargs)
- [IFrameDialogOptions](corelib.md#iframedialogoptions)
- [ISlickFormatter](corelib.md#islickformatter)
- [InvalidCastException](corelib.md#invalidcastexception)
- [Invariant](corelib.md#invariant)
- [JQBlockUIOptions](corelib.md#jqblockuioptions)
- [LT](corelib.md#lt)
- [LayoutTimer](corelib.md#layouttimer)
- [ListRequest](corelib.md#listrequest)
- [ListResponse](corelib.md#listresponse)
- [Locale](corelib.md#locale)
- [Lookup](corelib.md#lookup)
- [LookupOptions](corelib.md#lookupoptions)
- [MemberType](corelib.md#membertype)
- [NotifyMap](corelib.md#notifymap)
- [NumberFormat](corelib.md#numberformat)
- [PagerOptions](corelib.md#pageroptions)
- [PagingInfo](corelib.md#paginginfo)
- [PagingOptions](corelib.md#pagingoptions)
- [PostToServiceOptions](corelib.md#posttoserviceoptions)
- [PostToUrlOptions](corelib.md#posttourloptions)
- [PropertyItem](corelib.md#propertyitem)
- [PropertyItemsData](corelib.md#propertyitemsdata)
- [RemoteView](corelib.md#remoteview)
- [RemoteViewAjaxCallback](corelib.md#remoteviewajaxcallback)
- [RemoteViewFilter](corelib.md#remoteviewfilter)
- [RemoteViewOptions](corelib.md#remoteviewoptions)
- [RemoteViewProcessCallback](corelib.md#remoteviewprocesscallback)
- [RetrieveColumnSelection](corelib.md#retrievecolumnselection)
- [RetrieveLocalizationRequest](corelib.md#retrievelocalizationrequest)
- [RetrieveLocalizationResponse](corelib.md#retrievelocalizationresponse)
- [RetrieveRequest](corelib.md#retrieverequest)
- [RetrieveResponse](corelib.md#retrieveresponse)
- [Router](corelib.md#router)
- [SaveRequest](corelib.md#saverequest)
- [SaveRequestWithAttachment](corelib.md#saverequestwithattachment)
- [SaveResponse](corelib.md#saveresponse)
- [SaveWithLocalizationRequest](corelib.md#savewithlocalizationrequest)
- [ScriptData](corelib.md#scriptdata)
- [ServiceError](corelib.md#serviceerror)
- [ServiceOptions](corelib.md#serviceoptions)
- [ServiceRequest](corelib.md#servicerequest)
- [ServiceResponse](corelib.md#serviceresponse)
- [SummaryOptions](corelib.md#summaryoptions)
- [SummaryType](corelib.md#summarytype)
- [ToastContainerOptions](corelib.md#toastcontaineroptions)
- [Toastr](corelib.md#toastr)
- [ToastrOptions](corelib.md#toastroptions)
- [Type](corelib.md#type)
- [TypeMember](corelib.md#typemember)
- [UndeleteRequest](corelib.md#undeleterequest)
- [UndeleteResponse](corelib.md#undeleteresponse)
- [UserDefinition](corelib.md#userdefinition)
- [addAttribute](corelib.md#addattribute)
- [addEmptyOption](corelib.md#addemptyoption)
- [addOption](corelib.md#addoption)
- [addTypeMember](corelib.md#addtypemember)
- [addValidationRule](corelib.md#addvalidationrule)
- [alert](corelib.md#alert)
- [alertDialog](corelib.md#alertdialog)
- [any](corelib.md#any)
- [attrEncode](corelib.md#attrencode)
- [baseValidateOptions](corelib.md#basevalidateoptions)
- [blockUI](corelib.md#blockui)
- [blockUndo](corelib.md#blockundo)
- [bsModalMarkup](corelib.md#bsmodalmarkup)
- [canLoadScriptData](corelib.md#canloadscriptdata)
- [cast](corelib.md#cast)
- [centerDialog](corelib.md#centerdialog)
- [clearKeys](corelib.md#clearkeys)
- [clearOptions](corelib.md#clearoptions)
- [closePanel](corelib.md#closepanel)
- [coalesce](corelib.md#coalesce)
- [compareStringFactory](corelib.md#comparestringfactory)
- [confirm](corelib.md#confirm)
- [confirmDialog](corelib.md#confirmdialog)
- [count](corelib.md#count)
- [dbText](corelib.md#dbtext)
- [dbTryText](corelib.md#dbtrytext)
- [debounce](corelib.md#debounce)
- [deepClone](corelib.md#deepclone)
- [defaultNotifyOptions](corelib.md#defaultnotifyoptions)
- [delegateCombine](corelib.md#delegatecombine)
- [delegateRemove](corelib.md#delegateremove)
- [dialogButtonToBS](corelib.md#dialogbuttontobs)
- [dialogButtonToUI](corelib.md#dialogbuttontoui)
- [endsWith](corelib.md#endswith)
- [executeEverytimeWhenVisible](corelib.md#executeeverytimewhenvisible)
- [executeOnceWhenVisible](corelib.md#executeoncewhenvisible)
- [extend](corelib.md#extend)
- [fieldsProxy](corelib.md#fieldsproxy)
- [findElementWithRelativeId](corelib.md#findelementwithrelativeid)
- [first](corelib.md#first)
- [format](corelib.md#format-1)
- [formatDate](corelib.md#formatdate)
- [formatDayHourAndMin](corelib.md#formatdayhourandmin)
- [formatISODateTimeUTC](corelib.md#formatisodatetimeutc)
- [formatNumber](corelib.md#formatnumber)
- [getAttributes](corelib.md#getattributes)
- [getBaseType](corelib.md#getbasetype)
- [getColumns](corelib.md#getcolumns)
- [getColumnsAsync](corelib.md#getcolumnsasync)
- [getColumnsData](corelib.md#getcolumnsdata)
- [getColumnsDataAsync](corelib.md#getcolumnsdataasync)
- [getCookie](corelib.md#getcookie)
- [getForm](corelib.md#getform)
- [getFormAsync](corelib.md#getformasync)
- [getFormData](corelib.md#getformdata)
- [getFormDataAsync](corelib.md#getformdataasync)
- [getGlobalThis](corelib.md#getglobalthis)
- [getHighlightTarget](corelib.md#gethighlighttarget)
- [getInstanceType](corelib.md#getinstancetype)
- [getLookup](corelib.md#getlookup)
- [getLookupAsync](corelib.md#getlookupasync)
- [getMembers](corelib.md#getmembers)
- [getNested](corelib.md#getnested)
- [getRemoteData](corelib.md#getremotedata)
- [getRemoteDataAsync](corelib.md#getremotedataasync)
- [getStateStore](corelib.md#getstatestore)
- [getTemplate](corelib.md#gettemplate)
- [getTemplateAsync](corelib.md#gettemplateasync)
- [getType](corelib.md#gettype)
- [getTypeFullName](corelib.md#gettypefullname)
- [getTypeNameProp](corelib.md#gettypenameprop)
- [getTypeShortName](corelib.md#gettypeshortname)
- [getTypes](corelib.md#gettypes)
- [groupBy](corelib.md#groupby)
- [htmlEncode](corelib.md#htmlencode)
- [iframeDialog](corelib.md#iframedialog)
- [indexOf](corelib.md#indexof)
- [information](corelib.md#information)
- [informationDialog](corelib.md#informationdialog)
- [initFormType](corelib.md#initformtype)
- [initFullHeightGridPage](corelib.md#initfullheightgridpage)
- [initializeTypes](corelib.md#initializetypes)
- [insert](corelib.md#insert)
- [isArray](corelib.md#isarray)
- [isAssignableFrom](corelib.md#isassignablefrom)
- [isBS3](corelib.md#isbs3)
- [isBS5Plus](corelib.md#isbs5plus)
- [isEmptyOrNull](corelib.md#isemptyornull)
- [isEnum](corelib.md#isenum)
- [isInstanceOfType](corelib.md#isinstanceoftype)
- [isMobileView](corelib.md#ismobileview)
- [isTrimmedEmpty](corelib.md#istrimmedempty)
- [isValue](corelib.md#isvalue)
- [keyOf](corelib.md#keyof)
- [layoutFillHeight](corelib.md#layoutfillheight)
- [layoutFillHeightValue](corelib.md#layoutfillheightvalue)
- [loadValidationErrorMessages](corelib.md#loadvalidationerrormessages)
- [localText](corelib.md#localtext)
- [localeFormat](corelib.md#localeformat)
- [newBodyDiv](corelib.md#newbodydiv)
- [notifyError](corelib.md#notifyerror)
- [notifyInfo](corelib.md#notifyinfo)
- [notifySuccess](corelib.md#notifysuccess)
- [notifyWarning](corelib.md#notifywarning)
- [openPanel](corelib.md#openpanel)
- [outerHtml](corelib.md#outerhtml)
- [padLeft](corelib.md#padleft)
- [parseCriteria](corelib.md#parsecriteria)
- [parseDate](corelib.md#parsedate)
- [parseDayHourAndMin](corelib.md#parsedayhourandmin)
- [parseDecimal](corelib.md#parsedecimal)
- [parseHourAndMin](corelib.md#parsehourandmin)
- [parseISODateTime](corelib.md#parseisodatetime)
- [parseInteger](corelib.md#parseinteger)
- [parseQueryString](corelib.md#parsequerystring)
- [positionToastContainer](corelib.md#positiontoastcontainer)
- [postToService](corelib.md#posttoservice)
- [postToUrl](corelib.md#posttourl)
- [prefixedText](corelib.md#prefixedtext)
- [prop](corelib.md#prop)
- [proxyTexts](corelib.md#proxytexts)
- [registerClass](corelib.md#registerclass)
- [registerEditor](corelib.md#registereditor)
- [registerEnum](corelib.md#registerenum)
- [registerInterface](corelib.md#registerinterface)
- [reloadLookup](corelib.md#reloadlookup)
- [reloadLookupAsync](corelib.md#reloadlookupasync)
- [removeValidationRule](corelib.md#removevalidationrule)
- [replaceAll](corelib.md#replaceall)
- [resolveUrl](corelib.md#resolveurl)
- [round](corelib.md#round)
- [safeCast](corelib.md#safecast)
- [serviceCall](corelib.md#servicecall)
- [serviceRequest](corelib.md#servicerequest-1)
- [setEquality](corelib.md#setequality)
- [setTypeNameProp](corelib.md#settypenameprop)
- [single](corelib.md#single)
- [splitDateString](corelib.md#splitdatestring)
- [startsWith](corelib.md#startswith)
- [success](corelib.md#success)
- [successDialog](corelib.md#successdialog)
- [text](corelib.md#text)
- [toGrouping](corelib.md#togrouping)
- [toId](corelib.md#toid)
- [toSingleLine](corelib.md#tosingleline)
- [today](corelib.md#today)
- [toggleClass](corelib.md#toggleclass)
- [triggerLayoutOnShow](corelib.md#triggerlayoutonshow)
- [trim](corelib.md#trim)
- [trimEnd](corelib.md#trimend)
- [trimStart](corelib.md#trimstart)
- [trimToEmpty](corelib.md#trimtoempty)
- [trimToNull](corelib.md#trimtonull)
- [trunc](corelib.md#trunc)
- [tryFirst](corelib.md#tryfirst)
- [tryGetText](corelib.md#trygettext)
- [turkishLocaleCompare](corelib.md#turkishlocalecompare)
- [turkishLocaleToLower](corelib.md#turkishlocaletolower)
- [turkishLocaleToUpper](corelib.md#turkishlocaletoupper)
- [validateForm](corelib.md#validateform)
- [validateOptions](corelib.md#validateoptions)
- [validatorAbortHandler](corelib.md#validatoraborthandler)
- [warning](corelib.md#warning)
- [warningDialog](corelib.md#warningdialog)
- [zeroPad](corelib.md#zeropad)

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
- [ColumnsBase](../classes/corelib.ColumnsBase.md)
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
- [JsxDomWidget](../interfaces/corelib.JsxDomWidget.md)
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

### AggregateFormatting

Re-exports [AggregateFormatting](slick.AggregateFormatting.md)

___

### Aggregators

Re-exports [Aggregators](slick.Aggregators.md)

___

### AlertOptions

Re-exports [AlertOptions](../interfaces/q.AlertOptions.md)

___

### ArgumentNullException

Re-exports [ArgumentNullException](../classes/q.ArgumentNullException.md)

___

### Authorization

Re-exports [Authorization](q.Authorization.md)

___

### CancellableViewCallback

Re-exports [CancellableViewCallback](slick.md#cancellableviewcallback)

___

### ColumnSelection

Re-exports [ColumnSelection](../enums/q.ColumnSelection.md)

___

### CommonDialogOptions

Re-exports [CommonDialogOptions](../interfaces/q.CommonDialogOptions.md)

___

### Config

Re-exports [Config](q.md#config)

___

### ConfirmOptions

Re-exports [ConfirmOptions](../interfaces/q.ConfirmOptions.md)

___

### Criteria

Re-exports [Criteria](q.md#criteria)

___

### CriteriaBuilder

Re-exports [CriteriaBuilder](../classes/q.CriteriaBuilder.md)

___

### CriteriaOperator

Re-exports [CriteriaOperator](../enums/q.CriteriaOperator.md)

___

### Culture

Re-exports [Culture](q.md#culture)

___

### DateFormat

Re-exports [DateFormat](../interfaces/q.DateFormat.md)

___

### DebouncedFunction

Re-exports [DebouncedFunction](../interfaces/q.DebouncedFunction.md)

___

### DeleteRequest

Re-exports [DeleteRequest](../interfaces/q.DeleteRequest.md)

___

### DeleteResponse

Re-exports [DeleteResponse](../interfaces/q.DeleteResponse.md)

___

### DialogButton

Re-exports [DialogButton](../interfaces/q.DialogButton.md)

___

### Dictionary

Re-exports [Dictionary](q.md#dictionary)

___

### EditorAttribute

Re-exports [EditorAttribute](../classes/q.EditorAttribute.md)

___

### Enum

Re-exports [Enum](q.Enum.md)

___

### ErrorHandling

Re-exports [ErrorHandling](q.ErrorHandling.md)

___

### Exception

Re-exports [Exception](../classes/q.Exception.md)

___

### Format

Re-exports [Format](slick.md#format)

___

### Formatter

Re-exports [Formatter](../interfaces/slick.Formatter.md)

___

### GroupByElement

Re-exports [GroupByElement](q.md#groupbyelement)

___

### GroupByResult

Re-exports [GroupByResult](q.md#groupbyresult)

___

### GroupInfo

Re-exports [GroupInfo](../interfaces/slick.GroupInfo.md)

___

### Grouping

Re-exports [Grouping](q.md#grouping)

___

### HandleRouteEventArgs

Re-exports [HandleRouteEventArgs](../interfaces/q.HandleRouteEventArgs.md)

___

### IFrameDialogOptions

Re-exports [IFrameDialogOptions](../interfaces/q.IFrameDialogOptions.md)

___

### ISlickFormatter

Re-exports [ISlickFormatter](../classes/q.ISlickFormatter.md)

___

### InvalidCastException

Re-exports [InvalidCastException](../classes/q.InvalidCastException.md)

___

### Invariant

Re-exports [Invariant](q.md#invariant)

___

### JQBlockUIOptions

Re-exports [JQBlockUIOptions](../interfaces/q.JQBlockUIOptions.md)

___

### LT

Re-exports [LT](../classes/q.LT.md)

___

### LayoutTimer

Re-exports [LayoutTimer](q.LayoutTimer.md)

___

### ListRequest

Re-exports [ListRequest](../interfaces/q.ListRequest.md)

___

### ListResponse

Re-exports [ListResponse](../interfaces/q.ListResponse.md)

___

### Locale

Re-exports [Locale](../interfaces/q.Locale.md)

___

### Lookup

Re-exports [Lookup](../classes/q.Lookup.md)

___

### LookupOptions

Re-exports [LookupOptions](../interfaces/q.LookupOptions.md)

___

### MemberType

Re-exports [MemberType](../enums/q.MemberType.md)

___

### NotifyMap

Re-exports [NotifyMap](q.md#notifymap)

___

### NumberFormat

Re-exports [NumberFormat](../interfaces/q.NumberFormat.md)

___

### PagerOptions

Re-exports [PagerOptions](../interfaces/slick.PagerOptions.md)

___

### PagingInfo

Re-exports [PagingInfo](../interfaces/slick.PagingInfo.md)

___

### PagingOptions

Re-exports [PagingOptions](../interfaces/slick.PagingOptions.md)

___

### PostToServiceOptions

Re-exports [PostToServiceOptions](../interfaces/q.PostToServiceOptions.md)

___

### PostToUrlOptions

Re-exports [PostToUrlOptions](../interfaces/q.PostToUrlOptions.md)

___

### PropertyItem

Re-exports [PropertyItem](../interfaces/q.PropertyItem.md)

___

### PropertyItemsData

Re-exports [PropertyItemsData](../interfaces/q.PropertyItemsData.md)

___

### RemoteView

Re-exports [RemoteView](../classes/slick.RemoteView.md)

___

### RemoteViewAjaxCallback

Re-exports [RemoteViewAjaxCallback](slick.md#remoteviewajaxcallback)

___

### RemoteViewFilter

Re-exports [RemoteViewFilter](slick.md#remoteviewfilter)

___

### RemoteViewOptions

Re-exports [RemoteViewOptions](../interfaces/slick.RemoteViewOptions.md)

___

### RemoteViewProcessCallback

Re-exports [RemoteViewProcessCallback](slick.md#remoteviewprocesscallback)

___

### RetrieveColumnSelection

Re-exports [RetrieveColumnSelection](../enums/q.RetrieveColumnSelection.md)

___

### RetrieveLocalizationRequest

Re-exports [RetrieveLocalizationRequest](../interfaces/q.RetrieveLocalizationRequest.md)

___

### RetrieveLocalizationResponse

Re-exports [RetrieveLocalizationResponse](../interfaces/q.RetrieveLocalizationResponse.md)

___

### RetrieveRequest

Re-exports [RetrieveRequest](../interfaces/q.RetrieveRequest.md)

___

### RetrieveResponse

Re-exports [RetrieveResponse](../interfaces/q.RetrieveResponse.md)

___

### Router

Re-exports [Router](q.Router.md)

___

### SaveRequest

Re-exports [SaveRequest](../interfaces/q.SaveRequest.md)

___

### SaveRequestWithAttachment

Re-exports [SaveRequestWithAttachment](../interfaces/q.SaveRequestWithAttachment.md)

___

### SaveResponse

Re-exports [SaveResponse](../interfaces/q.SaveResponse.md)

___

### SaveWithLocalizationRequest

Re-exports [SaveWithLocalizationRequest](../interfaces/q.SaveWithLocalizationRequest.md)

___

### ScriptData

Re-exports [ScriptData](q.ScriptData.md)

___

### ServiceError

Re-exports [ServiceError](../interfaces/q.ServiceError.md)

___

### ServiceOptions

Re-exports [ServiceOptions](../interfaces/q.ServiceOptions.md)

___

### ServiceRequest

Re-exports [ServiceRequest](../interfaces/q.ServiceRequest.md)

___

### ServiceResponse

Re-exports [ServiceResponse](../interfaces/q.ServiceResponse.md)

___

### SummaryOptions

Re-exports [SummaryOptions](../interfaces/slick.SummaryOptions.md)

___

### SummaryType

Re-exports [SummaryType](../enums/q.SummaryType.md)

___

### ToastContainerOptions

Re-exports [ToastContainerOptions](q.md#toastcontaineroptions)

___

### Toastr

Re-exports [Toastr](../classes/q.Toastr.md)

___

### ToastrOptions

Re-exports [ToastrOptions](q.md#toastroptions)

___

### Type

Re-exports [Type](q.md#type)

___

### TypeMember

Re-exports [TypeMember](../interfaces/q.TypeMember.md)

___

### UndeleteRequest

Re-exports [UndeleteRequest](../interfaces/q.UndeleteRequest.md)

___

### UndeleteResponse

Re-exports [UndeleteResponse](../interfaces/q.UndeleteResponse.md)

___

### UserDefinition

Re-exports [UserDefinition](../interfaces/q.UserDefinition.md)

___

### addAttribute

Re-exports [addAttribute](q.md#addattribute)

___

### addEmptyOption

Re-exports [addEmptyOption](q.md#addemptyoption)

___

### addOption

Re-exports [addOption](q.md#addoption)

___

### addTypeMember

Re-exports [addTypeMember](q.md#addtypemember)

___

### addValidationRule

Re-exports [addValidationRule](q.md#addvalidationrule)

___

### alert

Re-exports [alert](q.md#alert)

___

### alertDialog

Re-exports [alertDialog](q.md#alertdialog)

___

### any

Re-exports [any](q.md#any)

___

### attrEncode

Re-exports [attrEncode](q.md#attrencode)

___

### baseValidateOptions

Re-exports [baseValidateOptions](q.md#basevalidateoptions)

___

### blockUI

Re-exports [blockUI](q.md#blockui)

___

### blockUndo

Re-exports [blockUndo](q.md#blockundo)

___

### bsModalMarkup

Re-exports [bsModalMarkup](q.md#bsmodalmarkup)

___

### canLoadScriptData

Re-exports [canLoadScriptData](q.md#canloadscriptdata)

___

### cast

Re-exports [cast](q.md#cast)

___

### centerDialog

Re-exports [centerDialog](q.md#centerdialog)

___

### clearKeys

Re-exports [clearKeys](q.md#clearkeys)

___

### clearOptions

Re-exports [clearOptions](q.md#clearoptions)

___

### closePanel

Re-exports [closePanel](q.md#closepanel)

___

### coalesce

Re-exports [coalesce](q.md#coalesce)

___

### compareStringFactory

Re-exports [compareStringFactory](q.md#comparestringfactory)

___

### confirm

Re-exports [confirm](q.md#confirm)

___

### confirmDialog

Re-exports [confirmDialog](q.md#confirmdialog)

___

### count

Re-exports [count](q.md#count)

___

### dbText

Re-exports [dbText](q.md#dbtext)

___

### dbTryText

Re-exports [dbTryText](q.md#dbtrytext)

___

### debounce

Re-exports [debounce](q.md#debounce)

___

### deepClone

Re-exports [deepClone](q.md#deepclone)

___

### defaultNotifyOptions

Re-exports [defaultNotifyOptions](q.md#defaultnotifyoptions)

___

### delegateCombine

Re-exports [delegateCombine](q.md#delegatecombine)

___

### delegateRemove

Re-exports [delegateRemove](q.md#delegateremove)

___

### dialogButtonToBS

Re-exports [dialogButtonToBS](q.md#dialogbuttontobs)

___

### dialogButtonToUI

Re-exports [dialogButtonToUI](q.md#dialogbuttontoui)

___

### endsWith

Re-exports [endsWith](q.md#endswith)

___

### executeEverytimeWhenVisible

Re-exports [executeEverytimeWhenVisible](q.md#executeeverytimewhenvisible)

___

### executeOnceWhenVisible

Re-exports [executeOnceWhenVisible](q.md#executeoncewhenvisible)

___

### extend

Re-exports [extend](q.md#extend)

___

### fieldsProxy

Re-exports [fieldsProxy](q.md#fieldsproxy)

___

### findElementWithRelativeId

Re-exports [findElementWithRelativeId](q.md#findelementwithrelativeid)

___

### first

Re-exports [first](q.md#first)

___

### format

Re-exports [format](q.md#format)

___

### formatDate

Re-exports [formatDate](q.md#formatdate)

___

### formatDayHourAndMin

Re-exports [formatDayHourAndMin](q.md#formatdayhourandmin)

___

### formatISODateTimeUTC

Re-exports [formatISODateTimeUTC](q.md#formatisodatetimeutc)

___

### formatNumber

Re-exports [formatNumber](q.md#formatnumber)

___

### getAttributes

Re-exports [getAttributes](q.md#getattributes)

___

### getBaseType

Re-exports [getBaseType](q.md#getbasetype)

___

### getColumns

Re-exports [getColumns](q.md#getcolumns)

___

### getColumnsAsync

Re-exports [getColumnsAsync](q.md#getcolumnsasync)

___

### getColumnsData

Re-exports [getColumnsData](q.md#getcolumnsdata)

___

### getColumnsDataAsync

Re-exports [getColumnsDataAsync](q.md#getcolumnsdataasync)

___

### getCookie

Re-exports [getCookie](q.md#getcookie)

___

### getForm

Re-exports [getForm](q.md#getform)

___

### getFormAsync

Re-exports [getFormAsync](q.md#getformasync)

___

### getFormData

Re-exports [getFormData](q.md#getformdata)

___

### getFormDataAsync

Re-exports [getFormDataAsync](q.md#getformdataasync)

___

### getGlobalThis

Re-exports [getGlobalThis](q.md#getglobalthis)

___

### getHighlightTarget

Re-exports [getHighlightTarget](q.md#gethighlighttarget)

___

### getInstanceType

Re-exports [getInstanceType](q.md#getinstancetype)

___

### getLookup

Re-exports [getLookup](q.md#getlookup)

___

### getLookupAsync

Re-exports [getLookupAsync](q.md#getlookupasync)

___

### getMembers

Re-exports [getMembers](q.md#getmembers)

___

### getNested

Re-exports [getNested](q.md#getnested)

___

### getRemoteData

Re-exports [getRemoteData](q.md#getremotedata)

___

### getRemoteDataAsync

Re-exports [getRemoteDataAsync](q.md#getremotedataasync)

___

### getStateStore

Re-exports [getStateStore](q.md#getstatestore)

___

### getTemplate

Re-exports [getTemplate](q.md#gettemplate)

___

### getTemplateAsync

Re-exports [getTemplateAsync](q.md#gettemplateasync)

___

### getType

Re-exports [getType](q.md#gettype)

___

### getTypeFullName

Re-exports [getTypeFullName](q.md#gettypefullname)

___

### getTypeNameProp

Re-exports [getTypeNameProp](q.md#gettypenameprop)

___

### getTypeShortName

Re-exports [getTypeShortName](q.md#gettypeshortname)

___

### getTypes

Re-exports [getTypes](q.md#gettypes)

___

### groupBy

Re-exports [groupBy](q.md#groupby)

___

### htmlEncode

Re-exports [htmlEncode](q.md#htmlencode)

___

### iframeDialog

Re-exports [iframeDialog](q.md#iframedialog)

___

### indexOf

Re-exports [indexOf](q.md#indexof)

___

### information

Re-exports [information](q.md#information)

___

### informationDialog

Re-exports [informationDialog](q.md#informationdialog)

___

### initFormType

Re-exports [initFormType](q.md#initformtype)

___

### initFullHeightGridPage

Re-exports [initFullHeightGridPage](q.md#initfullheightgridpage)

___

### initializeTypes

Re-exports [initializeTypes](q.md#initializetypes)

___

### insert

Re-exports [insert](q.md#insert)

___

### isArray

Re-exports [isArray](q.md#isarray)

___

### isAssignableFrom

Re-exports [isAssignableFrom](q.md#isassignablefrom)

___

### isBS3

Re-exports [isBS3](q.md#isbs3)

___

### isBS5Plus

Re-exports [isBS5Plus](q.md#isbs5plus)

___

### isEmptyOrNull

Re-exports [isEmptyOrNull](q.md#isemptyornull)

___

### isEnum

Re-exports [isEnum](q.md#isenum)

___

### isInstanceOfType

Re-exports [isInstanceOfType](q.md#isinstanceoftype)

___

### isMobileView

Re-exports [isMobileView](q.md#ismobileview)

___

### isTrimmedEmpty

Re-exports [isTrimmedEmpty](q.md#istrimmedempty)

___

### isValue

Re-exports [isValue](q.md#isvalue)

___

### keyOf

Re-exports [keyOf](q.md#keyof)

___

### layoutFillHeight

Re-exports [layoutFillHeight](q.md#layoutfillheight)

___

### layoutFillHeightValue

Re-exports [layoutFillHeightValue](q.md#layoutfillheightvalue)

___

### loadValidationErrorMessages

Re-exports [loadValidationErrorMessages](q.md#loadvalidationerrormessages)

___

### localText

Re-exports [localText](q.md#localtext)

___

### localeFormat

Re-exports [localeFormat](q.md#localeformat)

___

### newBodyDiv

Re-exports [newBodyDiv](q.md#newbodydiv)

___

### notifyError

Re-exports [notifyError](q.md#notifyerror)

___

### notifyInfo

Re-exports [notifyInfo](q.md#notifyinfo)

___

### notifySuccess

Re-exports [notifySuccess](q.md#notifysuccess)

___

### notifyWarning

Re-exports [notifyWarning](q.md#notifywarning)

___

### openPanel

Re-exports [openPanel](q.md#openpanel)

___

### outerHtml

Re-exports [outerHtml](q.md#outerhtml)

___

### padLeft

Re-exports [padLeft](q.md#padleft)

___

### parseCriteria

Re-exports [parseCriteria](q.md#parsecriteria)

___

### parseDate

Re-exports [parseDate](q.md#parsedate)

___

### parseDayHourAndMin

Re-exports [parseDayHourAndMin](q.md#parsedayhourandmin)

___

### parseDecimal

Re-exports [parseDecimal](q.md#parsedecimal)

___

### parseHourAndMin

Re-exports [parseHourAndMin](q.md#parsehourandmin)

___

### parseISODateTime

Re-exports [parseISODateTime](q.md#parseisodatetime)

___

### parseInteger

Re-exports [parseInteger](q.md#parseinteger)

___

### parseQueryString

Re-exports [parseQueryString](q.md#parsequerystring)

___

### positionToastContainer

Re-exports [positionToastContainer](q.md#positiontoastcontainer)

___

### postToService

Re-exports [postToService](q.md#posttoservice)

___

### postToUrl

Re-exports [postToUrl](q.md#posttourl)

___

### prefixedText

Re-exports [prefixedText](q.md#prefixedtext)

___

### prop

Re-exports [prop](q.md#prop)

___

### proxyTexts

Re-exports [proxyTexts](q.md#proxytexts)

___

### registerClass

Re-exports [registerClass](q.md#registerclass)

___

### registerEditor

Re-exports [registerEditor](q.md#registereditor)

___

### registerEnum

Re-exports [registerEnum](q.md#registerenum)

___

### registerInterface

Re-exports [registerInterface](q.md#registerinterface)

___

### reloadLookup

Re-exports [reloadLookup](q.md#reloadlookup)

___

### reloadLookupAsync

Re-exports [reloadLookupAsync](q.md#reloadlookupasync)

___

### removeValidationRule

Re-exports [removeValidationRule](q.md#removevalidationrule)

___

### replaceAll

Re-exports [replaceAll](q.md#replaceall)

___

### resolveUrl

Re-exports [resolveUrl](q.md#resolveurl)

___

### round

Re-exports [round](q.md#round)

___

### safeCast

Re-exports [safeCast](q.md#safecast)

___

### serviceCall

Re-exports [serviceCall](q.md#servicecall)

___

### serviceRequest

Re-exports [serviceRequest](q.md#servicerequest)

___

### setEquality

Re-exports [setEquality](q.md#setequality)

___

### setTypeNameProp

Re-exports [setTypeNameProp](q.md#settypenameprop)

___

### single

Re-exports [single](q.md#single)

___

### splitDateString

Re-exports [splitDateString](q.md#splitdatestring)

___

### startsWith

Re-exports [startsWith](q.md#startswith)

___

### success

Re-exports [success](q.md#success)

___

### successDialog

Re-exports [successDialog](q.md#successdialog)

___

### text

Re-exports [text](q.md#text)

___

### toGrouping

Re-exports [toGrouping](q.md#togrouping)

___

### toId

Re-exports [toId](q.md#toid)

___

### toSingleLine

Re-exports [toSingleLine](q.md#tosingleline)

___

### today

Re-exports [today](q.md#today)

___

### toggleClass

Re-exports [toggleClass](q.md#toggleclass)

___

### triggerLayoutOnShow

Re-exports [triggerLayoutOnShow](q.md#triggerlayoutonshow)

___

### trim

Re-exports [trim](q.md#trim)

___

### trimEnd

Re-exports [trimEnd](q.md#trimend)

___

### trimStart

Re-exports [trimStart](q.md#trimstart)

___

### trimToEmpty

Re-exports [trimToEmpty](q.md#trimtoempty)

___

### trimToNull

Re-exports [trimToNull](q.md#trimtonull)

___

### trunc

Re-exports [trunc](q.md#trunc)

___

### tryFirst

Re-exports [tryFirst](q.md#tryfirst)

___

### tryGetText

Re-exports [tryGetText](q.md#trygettext)

___

### turkishLocaleCompare

Re-exports [turkishLocaleCompare](q.md#turkishlocalecompare)

___

### turkishLocaleToLower

Re-exports [turkishLocaleToLower](q.md#turkishlocaletolower)

___

### turkishLocaleToUpper

Re-exports [turkishLocaleToUpper](q.md#turkishlocaletoupper)

___

### validateForm

Re-exports [validateForm](q.md#validateform)

___

### validateOptions

Re-exports [validateOptions](q.md#validateoptions)

___

### validatorAbortHandler

Re-exports [validatorAbortHandler](q.md#validatoraborthandler)

___

### warning

Re-exports [warning](q.md#warning)

___

### warningDialog

Re-exports [warningDialog](q.md#warningdialog)

___

### zeroPad

Re-exports [zeroPad](q.md#zeropad)

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

[src/index.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/index.ts#L105)

## Variables

### datePickerIconSvg

• **datePickerIconSvg**: `string` = `'<svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 0 17 17"><g></g><path d="M14 2v-1h-3v1h-5v-1h-3v1h-3v15h17v-15h-3zM12 2h1v2h-1v-2zM4 2h1v2h-1v-2zM16 16h-15v-8.921h15v8.921zM1 6.079v-3.079h2v2h3v-2h5v2h3v-2h2v3.079h-15z" fill="currentColor"></path></svg>'`

#### Defined in

[src/ui/editors/dateeditor.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L6)

## Functions

### jsxDomWidget

▸ **jsxDomWidget**<`TWidget`, `TOptions`\>(`type`): [`JsxDomWidget`](../interfaces/corelib.JsxDomWidget.md)<`TOptions` & { `ref?`: (`r`: `TWidget`) => `void`  }\>

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

[`JsxDomWidget`](../interfaces/corelib.JsxDomWidget.md)<`TOptions` & { `ref?`: (`r`: `TWidget`) => `void`  }\>

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
