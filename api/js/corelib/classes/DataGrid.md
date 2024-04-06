[@serenity-is/corelib](../README.md) / DataGrid

# Class: DataGrid\<TItem, P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `TItem` |
| `P` | {} |

## Hierarchy

- [`Widget`](Widget.md)\<`P`\>

  ↳ **`DataGrid`**

  ↳↳ [`CheckTreeEditor`](CheckTreeEditor.md)

  ↳↳ [`EntityGrid`](EntityGrid.md)

## Implements

- [`IDataGrid`](../interfaces/IDataGrid.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](DataGrid.md#constructor)

### Properties

- [\_idProperty](DataGrid.md#_idproperty)
- [\_isActiveProperty](DataGrid.md#_isactiveproperty)
- [\_isDisabled](DataGrid.md#_isdisabled)
- [\_layoutTimer](DataGrid.md#_layouttimer)
- [\_localTextDbPrefix](DataGrid.md#_localtextdbprefix)
- [\_readonly](DataGrid.md#_readonly)
- [\_slickGridOnClick](DataGrid.md#_slickgridonclick)
- [\_slickGridOnSort](DataGrid.md#_slickgridonsort)
- [allColumns](DataGrid.md#allcolumns)
- [domNode](DataGrid.md#domnode)
- [filterBar](DataGrid.md#filterbar)
- [idPrefix](DataGrid.md#idprefix)
- [initialSettings](DataGrid.md#initialsettings)
- [openDialogsAsPanel](DataGrid.md#opendialogsaspanel)
- [options](DataGrid.md#options)
- [propertyItemsData](DataGrid.md#propertyitemsdata)
- [quickFiltersBar](DataGrid.md#quickfiltersbar)
- [quickFiltersDiv](DataGrid.md#quickfiltersdiv)
- [restoringSettings](DataGrid.md#restoringsettings)
- [slickContainer](DataGrid.md#slickcontainer)
- [slickGrid](DataGrid.md#slickgrid)
- [titleDiv](DataGrid.md#titlediv)
- [toolbar](DataGrid.md#toolbar)
- [uniqueName](DataGrid.md#uniquename)
- [view](DataGrid.md#view)
- [defaultColumnWidthDelta](DataGrid.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](DataGrid.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](DataGrid.md#defaultheaderheight)
- [defaultPersistanceStorage](DataGrid.md#defaultpersistancestorage)
- [defaultRowHeight](DataGrid.md#defaultrowheight)
- [typeInfo](DataGrid.md#typeinfo)

### Accessors

- [element](DataGrid.md#element)
- [props](DataGrid.md#props)
- [readOnly](DataGrid.md#readonly)

### Methods

- [addBooleanFilter](DataGrid.md#addbooleanfilter)
- [addCssClass](DataGrid.md#addcssclass)
- [addDateRangeFilter](DataGrid.md#adddaterangefilter)
- [addDateTimeRangeFilter](DataGrid.md#adddatetimerangefilter)
- [addFilterSeparator](DataGrid.md#addfilterseparator)
- [addQuickFilter](DataGrid.md#addquickfilter)
- [addValidationRule](DataGrid.md#addvalidationrule)
- [afterInit](DataGrid.md#afterinit)
- [bindToSlickEvents](DataGrid.md#bindtoslickevents)
- [bindToViewEvents](DataGrid.md#bindtoviewevents)
- [booleanQuickFilter](DataGrid.md#booleanquickfilter)
- [canFilterColumn](DataGrid.md#canfiltercolumn)
- [canShowColumn](DataGrid.md#canshowcolumn)
- [change](DataGrid.md#change)
- [changeSelect2](DataGrid.md#changeselect2)
- [createFilterBar](DataGrid.md#createfilterbar)
- [createIncludeDeletedButton](DataGrid.md#createincludedeletedbutton)
- [createPager](DataGrid.md#createpager)
- [createQuickFilters](DataGrid.md#createquickfilters)
- [createQuickSearchInput](DataGrid.md#createquicksearchinput)
- [createSlickContainer](DataGrid.md#createslickcontainer)
- [createSlickGrid](DataGrid.md#createslickgrid)
- [createToolbar](DataGrid.md#createtoolbar)
- [createToolbarExtensions](DataGrid.md#createtoolbarextensions)
- [createView](DataGrid.md#createview)
- [dateRangeQuickFilter](DataGrid.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](DataGrid.md#datetimerangequickfilter)
- [destroy](DataGrid.md#destroy)
- [determineText](DataGrid.md#determinetext)
- [editItem](DataGrid.md#edititem)
- [editItemOfType](DataGrid.md#edititemoftype)
- [enableFiltering](DataGrid.md#enablefiltering)
- [ensureQuickFilterBar](DataGrid.md#ensurequickfilterbar)
- [findQuickFilter](DataGrid.md#findquickfilter)
- [getAddButtonCaption](DataGrid.md#getaddbuttoncaption)
- [getButtons](DataGrid.md#getbuttons)
- [getColumnWidthDelta](DataGrid.md#getcolumnwidthdelta)
- [getColumnWidthScale](DataGrid.md#getcolumnwidthscale)
- [getColumns](DataGrid.md#getcolumns)
- [getColumnsKey](DataGrid.md#getcolumnskey)
- [getCssClass](DataGrid.md#getcssclass)
- [getCurrentSettings](DataGrid.md#getcurrentsettings)
- [getCustomAttribute](DataGrid.md#getcustomattribute)
- [getDefaultSortBy](DataGrid.md#getdefaultsortby)
- [getElement](DataGrid.md#getelement)
- [getFieldElement](DataGrid.md#getfieldelement)
- [getFilterStore](DataGrid.md#getfilterstore)
- [getGrid](DataGrid.md#getgrid)
- [getGridCanLoad](DataGrid.md#getgridcanload)
- [getGridField](DataGrid.md#getgridfield)
- [getIdProperty](DataGrid.md#getidproperty)
- [getIncludeColumns](DataGrid.md#getincludecolumns)
- [getInitialTitle](DataGrid.md#getinitialtitle)
- [getIsActiveProperty](DataGrid.md#getisactiveproperty)
- [getIsDeletedProperty](DataGrid.md#getisdeletedproperty)
- [getItemCssClass](DataGrid.md#getitemcssclass)
- [getItemMetadata](DataGrid.md#getitemmetadata)
- [getItemType](DataGrid.md#getitemtype)
- [getItems](DataGrid.md#getitems)
- [getLocalTextDbPrefix](DataGrid.md#getlocaltextdbprefix)
- [getLocalTextPrefix](DataGrid.md#getlocaltextprefix)
- [getPagerOptions](DataGrid.md#getpageroptions)
- [getPersistanceKey](DataGrid.md#getpersistancekey)
- [getPersistanceStorage](DataGrid.md#getpersistancestorage)
- [getPersistedSettings](DataGrid.md#getpersistedsettings)
- [getPropertyItems](DataGrid.md#getpropertyitems)
- [getPropertyItemsData](DataGrid.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](DataGrid.md#getpropertyitemsdataasync)
- [getQuickFilters](DataGrid.md#getquickfilters)
- [getQuickSearchFields](DataGrid.md#getquicksearchfields)
- [getRowDefinition](DataGrid.md#getrowdefinition)
- [getSlickOptions](DataGrid.md#getslickoptions)
- [getTitle](DataGrid.md#gettitle)
- [getView](DataGrid.md#getview)
- [getViewOptions](DataGrid.md#getviewoptions)
- [get\_readOnly](DataGrid.md#get_readonly)
- [gridPersistanceFlags](DataGrid.md#gridpersistanceflags)
- [init](DataGrid.md#init)
- [initialPopulate](DataGrid.md#initialpopulate)
- [initializeFilterBar](DataGrid.md#initializefilterbar)
- [internalInit](DataGrid.md#internalinit)
- [internalRefresh](DataGrid.md#internalrefresh)
- [internalRenderContents](DataGrid.md#internalrendercontents)
- [invokeSubmitHandlers](DataGrid.md#invokesubmithandlers)
- [itemAt](DataGrid.md#itemat)
- [itemLink](DataGrid.md#itemlink)
- [layout](DataGrid.md#layout)
- [markupReady](DataGrid.md#markupready)
- [onClick](DataGrid.md#onclick)
- [onViewFilter](DataGrid.md#onviewfilter)
- [onViewProcessData](DataGrid.md#onviewprocessdata)
- [onViewSubmit](DataGrid.md#onviewsubmit)
- [persistSettings](DataGrid.md#persistsettings)
- [populateLock](DataGrid.md#populatelock)
- [populateUnlock](DataGrid.md#populateunlock)
- [populateWhenVisible](DataGrid.md#populatewhenvisible)
- [postProcessColumns](DataGrid.md#postprocesscolumns)
- [propertyItemsReady](DataGrid.md#propertyitemsready)
- [propertyItemsToSlickColumns](DataGrid.md#propertyitemstoslickcolumns)
- [quickFilterChange](DataGrid.md#quickfilterchange)
- [refresh](DataGrid.md#refresh)
- [refreshIfNeeded](DataGrid.md#refreshifneeded)
- [render](DataGrid.md#render)
- [renderContents](DataGrid.md#rendercontents)
- [resizeCanvas](DataGrid.md#resizecanvas)
- [restoreSettings](DataGrid.md#restoresettings)
- [restoreSettingsFrom](DataGrid.md#restoresettingsfrom)
- [rowCount](DataGrid.md#rowcount)
- [setCriteriaParameter](DataGrid.md#setcriteriaparameter)
- [setEquality](DataGrid.md#setequality)
- [setIncludeColumnsParameter](DataGrid.md#setincludecolumnsparameter)
- [setInitialSortOrder](DataGrid.md#setinitialsortorder)
- [setIsDisabled](DataGrid.md#setisdisabled)
- [setItems](DataGrid.md#setitems)
- [setTitle](DataGrid.md#settitle)
- [set\_readOnly](DataGrid.md#set_readonly)
- [subDialogDataChange](DataGrid.md#subdialogdatachange)
- [syncOrAsyncThen](DataGrid.md#syncorasyncthen)
- [tryFindQuickFilter](DataGrid.md#tryfindquickfilter)
- [updateDisabledState](DataGrid.md#updatedisabledstate)
- [updateInterface](DataGrid.md#updateinterface)
- [useAsync](DataGrid.md#useasync)
- [useIdPrefix](DataGrid.md#useidprefix)
- [useLayoutTimer](DataGrid.md#uselayouttimer)
- [usePager](DataGrid.md#usepager)
- [viewDataChanged](DataGrid.md#viewdatachanged)
- [wrapFormatterWithEditLink](DataGrid.md#wrapformatterwitheditlink)
- [create](DataGrid.md#create)
- [createDefaultElement](DataGrid.md#createdefaultelement)
- [getWidgetName](DataGrid.md#getwidgetname)
- [propertyItemToQuickFilter](DataGrid.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new DataGrid**\<`TItem`, `P`\>(`props`): [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `TItem` |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/datagrid/datagrid.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L89)

## Properties

### \_idProperty

• `Private` **\_idProperty**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1025](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1025)

___

### \_isActiveProperty

• `Private` **\_isActiveProperty**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1046)

___

### \_isDisabled

• `Private` **\_isDisabled**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L65)

___

### \_layoutTimer

• `Private` **\_layoutTimer**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L66)

___

### \_localTextDbPrefix

• `Private` **\_localTextDbPrefix**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1003)

___

### \_readonly

• `Private` **\_readonly**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:974](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L974)

___

### \_slickGridOnClick

• `Private` **\_slickGridOnClick**: `any`

#### Defined in

[src/ui/datagrid/datagrid.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L68)

___

### \_slickGridOnSort

• `Private` **\_slickGridOnSort**: `any`

#### Defined in

[src/ui/datagrid/datagrid.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L67)

___

### allColumns

• `Protected` **allColumns**: `Column`\<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L75)

___

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[Widget](Widget.md).[domNode](Widget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)\<{}\>

#### Defined in

[src/ui/datagrid/datagrid.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L71)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L77)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L81)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L76)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L73)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L72)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Defined in

[src/ui/datagrid/datagrid.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L78)

___

### slickContainer

• `Protected` **slickContainer**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L74)

___

### slickGrid

• **slickGrid**: `Grid`\<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L80)

___

### titleDiv

• `Protected` **titleDiv**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L69)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L70)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### view

• **view**: [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L79)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L87)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L86)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L84)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L85)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L83)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[Widget](Widget.md).[typeInfo](Widget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

Widget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

Widget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:976](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L976)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:980](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L980)

## Methods

### addBooleanFilter

▸ **addBooleanFilter**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1111)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addDateRangeFilter

▸ **addDateRangeFilter**(`field`, `title?`): [`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1095](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1095)

___

### addDateTimeRangeFilter

▸ **addDateTimeRangeFilter**(`field`, `title?`): [`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1103)

___

### addFilterSeparator

▸ **addFilterSeparator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1075](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1075)

___

### addQuickFilter

▸ **addQuickFilter**\<`TWidget`, `P`\>(`opt`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)\<`any`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`QuickFilter`](../interfaces/QuickFilter.md)\<`TWidget`, `P`\> |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/datagrid.ts:1091](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1091)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLSelectElement` \| `HTMLInputElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLSelectElement` \| `HTMLInputElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### afterInit

▸ **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L154)

___

### bindToSlickEvents

▸ **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L519)

___

### bindToViewEvents

▸ **bindToViewEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:619](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L619)

___

### booleanQuickFilter

▸ **booleanQuickFilter**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1115)

___

### canFilterColumn

▸ **canFilterColumn**(`column`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`\<`any`\> |

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L436)

___

### canShowColumn

▸ **canShowColumn**(`column`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`\<`any`\> |

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1150)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[change](Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### createFilterBar

▸ **createFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L747)

___

### createIncludeDeletedButton

▸ **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L303)

___

### createPager

▸ **createPager**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:762](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L762)

___

### createQuickFilters

▸ **createQuickFilters**(`filters?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filters?` | [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L202)

___

### createQuickSearchInput

▸ **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L312)

___

### createSlickContainer

▸ **createSlickContainer**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L701)

___

### createSlickGrid

▸ **createSlickGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L459)

___

### createToolbar

▸ **createToolbar**(`buttons`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `buttons` | [`ToolButton`](../interfaces/ToolButton.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L788)

___

### createToolbarExtensions

▸ **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L191)

___

### createView

▸ **createView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L705)

___

### dateRangeQuickFilter

▸ **dateRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1099](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1099)

___

### dateTimeRangeQuickFilter

▸ **dateTimeRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1107)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/datagrid/datagrid.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L317)

___

### determineText

▸ **determineText**(`getKey`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `getKey` | (`prefix`: `string`) => `string` |

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1079](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1079)

___

### editItem

▸ **editItem**(`entityOrId`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entityOrId` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:585](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L585)

___

### editItemOfType

▸ **editItemOfType**(`itemType`, `entityOrId`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `entityOrId` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:589](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L589)

___

### enableFiltering

▸ **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:739](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L739)

___

### ensureQuickFilterBar

▸ **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### findQuickFilter

▸ **findQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (...`args`: `any`[]) => `TWidget` |
| `field` | `string` |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/datagrid.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L289)

___

### getAddButtonCaption

▸ **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:577](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L577)

___

### getButtons

▸ **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:581](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L581)

___

### getColumnWidthDelta

▸ **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L413)

___

### getColumnWidthScale

▸ **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L417)

___

### getColumns

▸ **getColumns**(): `Column`\<`TItem`\>[]

#### Returns

`Column`\<`TItem`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L881)

___

### getColumnsKey

▸ **getColumnsKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

___

### getCurrentSettings

▸ **getCurrentSettings**(`flags?`): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1363)

___

### getCustomAttribute

▸ **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit?`): `TAttr`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`

#### Inherited from

[Widget](Widget.md).[getCustomAttribute](Widget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDefaultSortBy

▸ **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L710)

___

### getElement

▸ **getElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getElement](../interfaces/IDataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1453)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[Widget](Widget.md).[getFieldElement](Widget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getFilterStore](../interfaces/IDataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1465)

___

### getGrid

▸ **getGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getGrid](../interfaces/IDataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1457)

___

### getGridCanLoad

▸ **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L935)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getIdProperty

▸ **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1027](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1027)

___

### getIncludeColumns

▸ **getIncludeColumns**(`include`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `include` | `Object` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:647](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L647)

___

### getInitialTitle

▸ **getInitialTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L187)

___

### getIsActiveProperty

▸ **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1048)

___

### getIsDeletedProperty

▸ **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1042](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1042)

___

### getItemCssClass

▸ **getItemCssClass**(`item`, `index`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `index` | `number` |

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L351)

___

### getItemMetadata

▸ **getItemMetadata**(`item`, `index`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `index` | `number` |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/datagrid.ts:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L384)

___

### getItemType

▸ **getItemType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L826)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L511)

___

### getLocalTextDbPrefix

▸ **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1005](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1005)

___

### getLocalTextPrefix

▸ **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1017](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1017)

___

### getPagerOptions

▸ **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:754](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L754)

___

### getPersistanceKey

▸ **getPersistanceKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1135)

___

### getPersistanceStorage

▸ **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1131)

___

### getPersistedSettings

▸ **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1171)

___

### getPropertyItems

▸ **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L848)

___

### getPropertyItemsData

▸ **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L852)

___

### getPropertyItemsDataAsync

▸ **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getQuickFilters

▸ **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L225)

___

### getQuickSearchFields

▸ **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L308)

___

### getRowDefinition

▸ **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L999)

___

### getSlickOptions

▸ **getSlickOptions**(): `GridOptions`\<`any`\>

#### Returns

`GridOptions`\<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:911](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L911)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:796](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L796)

___

### getView

▸ **getView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getView](../interfaces/IDataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1461)

___

### getViewOptions

▸ **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:766](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L766)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:984](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L984)

___

### gridPersistanceFlags

▸ **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1146)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initialPopulate

▸ **initialPopulate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L421)

___

### initializeFilterBar

▸ **initializeFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L443)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[internalInit](Widget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRefresh

▸ **internalRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:959](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L959)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[internalRenderContents](Widget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### invokeSubmitHandlers

▸ **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1119)

___

### itemAt

▸ **itemAt**(`row`): `TItem`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`TItem`

#### Defined in

[src/ui/datagrid/datagrid.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L503)

___

### itemLink

▸ **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../README.md#format)\<`TItem`\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | [`Format`](../README.md#format)\<`TItem`\> | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`\<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../README.md#format)\<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:830](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L830)

___

### layout

▸ **layout**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L165)

___

### markupReady

▸ **markupReady**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L698)

___

### onClick

▸ **onClick**(`e`, `row`, `cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L598)

___

### onViewFilter

▸ **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L643)

___

### onViewProcessData

▸ **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\> |

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L639)

___

### onViewSubmit

▸ **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L686)

___

### persistSettings

▸ **persistSettings**(`flags?`): `void` \| `Promise`\<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

`void` \| `Promise`\<`void`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1353)

___

### populateLock

▸ **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:927](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L927)

___

### populateUnlock

▸ **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L931)

___

### populateWhenVisible

▸ **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:743](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L743)

___

### postProcessColumns

▸ **postProcessColumns**(`columns`): `Column`\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `columns` | `Column`\<`any`\>[] |

#### Returns

`Column`\<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L392)

___

### propertyItemsReady

▸ **propertyItemsReady**(`itemsData`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemsData` | [`PropertyItemsData`](../interfaces/PropertyItemsData.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L121)

___

### propertyItemsToSlickColumns

▸ **propertyItemsToSlickColumns**(`propertyItems`): `Column`\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `propertyItems` | [`PropertyItem`](../interfaces/PropertyItem.md)[] |

#### Returns

`Column`\<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:900](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L900)

___

### quickFilterChange

▸ **quickFilterChange**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1125)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L939)

___

### refreshIfNeeded

▸ **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:952](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L952)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[Widget](Widget.md).[render](Widget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

___

### resizeCanvas

▸ **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1067](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1067)

___

### restoreSettings

▸ **restoreSettings**(`settings?`, `flags?`): `void` \| `Promise`\<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings?` | [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

`void` \| `Promise`\<`void`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1190)

___

### restoreSettingsFrom

▸ **restoreSettingsFrom**(`settings`, `flags?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings` | [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1201)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L507)

___

### setCriteriaParameter

▸ **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L662)

___

### setEquality

▸ **setEquality**(`field`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L672)

___

### setIncludeColumnsParameter

▸ **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L676)

___

### setInitialSortOrder

▸ **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L478)

___

### setIsDisabled

▸ **setIsDisabled**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L963)

___

### setItems

▸ **setItems**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem`[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L515)

___

### setTitle

▸ **setTitle**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

___

### set\_readOnly

▸ **set_readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Implementation of

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:988](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L988)

___

### subDialogDataChange

▸ **subDialogDataChange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1071](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1071)

___

### syncOrAsyncThen

▸ **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `syncMethod` | () => `T` |
| `asyncMethod` | () => `PromiseLike`\<`T`\> |
| `then` | (`v`: `T`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[syncOrAsyncThen](Widget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### tryFindQuickFilter

▸ **tryFindQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (...`args`: `any`[]) => `TWidget` |
| `field` | `string` |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/datagrid.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L296)

___

### updateDisabledState

▸ **updateDisabledState**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1063](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1063)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L995)

___

### useAsync

▸ **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L157)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[Widget](Widget.md).[useIdPrefix](Widget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### useLayoutTimer

▸ **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L161)

___

### usePager

▸ **usePager**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L735)

___

### viewDataChanged

▸ **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |
| `rows` | `TItem`[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:614](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L614)

___

### wrapFormatterWithEditLink

▸ **wrapFormatterWithEditLink**(`column`, `item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`\<`any`\> |
| `item` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L885)

___

### create

▸ **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](Widget.md).[create](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[Widget](Widget.md).[createDefaultElement](Widget.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L60)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

___

### propertyItemToQuickFilter

▸ **propertyItemToQuickFilter**(`item`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/datagrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L235)
