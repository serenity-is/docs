[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DataGrid

# Class: DataGrid<TItem, TOptions\>

[corelib](../modules/corelib.md).DataGrid

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`Widget`](corelib.Widget.md)<`TOptions`\>

  ↳ **`DataGrid`**

  ↳↳ [`CheckTreeEditor`](corelib.CheckTreeEditor.md)

  ↳↳ [`EntityGrid`](corelib.EntityGrid.md)

## Implements

- [`IDataGrid`](../interfaces/corelib.IDataGrid.md)
- [`IReadOnly`](corelib.IReadOnly.md)

## Table of contents

### Constructors

- [constructor](corelib.DataGrid.md#constructor)

### Properties

- [\_idProperty](corelib.DataGrid.md#_idproperty)
- [\_isActiveProperty](corelib.DataGrid.md#_isactiveproperty)
- [\_isDisabled](corelib.DataGrid.md#_isdisabled)
- [\_layoutTimer](corelib.DataGrid.md#_layouttimer)
- [\_localTextDbPrefix](corelib.DataGrid.md#_localtextdbprefix)
- [\_readonly](corelib.DataGrid.md#_readonly)
- [\_slickGridOnClick](corelib.DataGrid.md#_slickgridonclick)
- [\_slickGridOnSort](corelib.DataGrid.md#_slickgridonsort)
- [allColumns](corelib.DataGrid.md#allcolumns)
- [element](corelib.DataGrid.md#element)
- [filterBar](corelib.DataGrid.md#filterbar)
- [idPrefix](corelib.DataGrid.md#idprefix)
- [initialSettings](corelib.DataGrid.md#initialsettings)
- [openDialogsAsPanel](corelib.DataGrid.md#opendialogsaspanel)
- [options](corelib.DataGrid.md#options)
- [propertyItemsData](corelib.DataGrid.md#propertyitemsdata)
- [quickFiltersBar](corelib.DataGrid.md#quickfiltersbar)
- [quickFiltersDiv](corelib.DataGrid.md#quickfiltersdiv)
- [restoringSettings](corelib.DataGrid.md#restoringsettings)
- [slickContainer](corelib.DataGrid.md#slickcontainer)
- [slickGrid](corelib.DataGrid.md#slickgrid)
- [titleDiv](corelib.DataGrid.md#titlediv)
- [toolbar](corelib.DataGrid.md#toolbar)
- [uniqueName](corelib.DataGrid.md#uniquename)
- [view](corelib.DataGrid.md#view)
- [widgetName](corelib.DataGrid.md#widgetname)
- [defaultColumnWidthDelta](corelib.DataGrid.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](corelib.DataGrid.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](corelib.DataGrid.md#defaultheaderheight)
- [defaultPersistanceStorage](corelib.DataGrid.md#defaultpersistancestorage)
- [defaultRowHeight](corelib.DataGrid.md#defaultrowheight)

### Accessors

- [readOnly](corelib.DataGrid.md#readonly)

### Methods

- [addBooleanFilter](corelib.DataGrid.md#addbooleanfilter)
- [addCssClass](corelib.DataGrid.md#addcssclass)
- [addDateRangeFilter](corelib.DataGrid.md#adddaterangefilter)
- [addDateTimeRangeFilter](corelib.DataGrid.md#adddatetimerangefilter)
- [addFilterSeparator](corelib.DataGrid.md#addfilterseparator)
- [addQuickFilter](corelib.DataGrid.md#addquickfilter)
- [addValidationRule](corelib.DataGrid.md#addvalidationrule)
- [afterInit](corelib.DataGrid.md#afterinit)
- [attrs](corelib.DataGrid.md#attrs)
- [bindToSlickEvents](corelib.DataGrid.md#bindtoslickevents)
- [bindToViewEvents](corelib.DataGrid.md#bindtoviewevents)
- [booleanQuickFilter](corelib.DataGrid.md#booleanquickfilter)
- [canFilterColumn](corelib.DataGrid.md#canfiltercolumn)
- [canShowColumn](corelib.DataGrid.md#canshowcolumn)
- [change](corelib.DataGrid.md#change)
- [changeSelect2](corelib.DataGrid.md#changeselect2)
- [createFilterBar](corelib.DataGrid.md#createfilterbar)
- [createIncludeDeletedButton](corelib.DataGrid.md#createincludedeletedbutton)
- [createPager](corelib.DataGrid.md#createpager)
- [createQuickFilters](corelib.DataGrid.md#createquickfilters)
- [createQuickSearchInput](corelib.DataGrid.md#createquicksearchinput)
- [createSlickContainer](corelib.DataGrid.md#createslickcontainer)
- [createSlickGrid](corelib.DataGrid.md#createslickgrid)
- [createToolbar](corelib.DataGrid.md#createtoolbar)
- [createToolbarExtensions](corelib.DataGrid.md#createtoolbarextensions)
- [createView](corelib.DataGrid.md#createview)
- [dateRangeQuickFilter](corelib.DataGrid.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](corelib.DataGrid.md#datetimerangequickfilter)
- [destroy](corelib.DataGrid.md#destroy)
- [determineText](corelib.DataGrid.md#determinetext)
- [editItem](corelib.DataGrid.md#edititem)
- [editItemOfType](corelib.DataGrid.md#edititemoftype)
- [enableFiltering](corelib.DataGrid.md#enablefiltering)
- [ensureQuickFilterBar](corelib.DataGrid.md#ensurequickfilterbar)
- [findQuickFilter](corelib.DataGrid.md#findquickfilter)
- [getAddButtonCaption](corelib.DataGrid.md#getaddbuttoncaption)
- [getButtons](corelib.DataGrid.md#getbuttons)
- [getColumnWidthDelta](corelib.DataGrid.md#getcolumnwidthdelta)
- [getColumnWidthScale](corelib.DataGrid.md#getcolumnwidthscale)
- [getColumns](corelib.DataGrid.md#getcolumns)
- [getColumnsKey](corelib.DataGrid.md#getcolumnskey)
- [getCssClass](corelib.DataGrid.md#getcssclass)
- [getCurrentSettings](corelib.DataGrid.md#getcurrentsettings)
- [getDefaultSortBy](corelib.DataGrid.md#getdefaultsortby)
- [getElement](corelib.DataGrid.md#getelement)
- [getFilterStore](corelib.DataGrid.md#getfilterstore)
- [getGrid](corelib.DataGrid.md#getgrid)
- [getGridCanLoad](corelib.DataGrid.md#getgridcanload)
- [getGridField](corelib.DataGrid.md#getgridfield)
- [getIdProperty](corelib.DataGrid.md#getidproperty)
- [getIncludeColumns](corelib.DataGrid.md#getincludecolumns)
- [getInitialTitle](corelib.DataGrid.md#getinitialtitle)
- [getIsActiveProperty](corelib.DataGrid.md#getisactiveproperty)
- [getIsDeletedProperty](corelib.DataGrid.md#getisdeletedproperty)
- [getItemCssClass](corelib.DataGrid.md#getitemcssclass)
- [getItemMetadata](corelib.DataGrid.md#getitemmetadata)
- [getItemType](corelib.DataGrid.md#getitemtype)
- [getItems](corelib.DataGrid.md#getitems)
- [getLocalTextDbPrefix](corelib.DataGrid.md#getlocaltextdbprefix)
- [getLocalTextPrefix](corelib.DataGrid.md#getlocaltextprefix)
- [getPagerOptions](corelib.DataGrid.md#getpageroptions)
- [getPersistanceKey](corelib.DataGrid.md#getpersistancekey)
- [getPersistanceStorage](corelib.DataGrid.md#getpersistancestorage)
- [getPersistedSettings](corelib.DataGrid.md#getpersistedsettings)
- [getPropertyItems](corelib.DataGrid.md#getpropertyitems)
- [getPropertyItemsData](corelib.DataGrid.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](corelib.DataGrid.md#getpropertyitemsdataasync)
- [getQuickFilters](corelib.DataGrid.md#getquickfilters)
- [getQuickSearchFields](corelib.DataGrid.md#getquicksearchfields)
- [getRowDefinition](corelib.DataGrid.md#getrowdefinition)
- [getSlickOptions](corelib.DataGrid.md#getslickoptions)
- [getTitle](corelib.DataGrid.md#gettitle)
- [getView](corelib.DataGrid.md#getview)
- [getViewOptions](corelib.DataGrid.md#getviewoptions)
- [get\_readOnly](corelib.DataGrid.md#get_readonly)
- [gridPersistanceFlags](corelib.DataGrid.md#gridpersistanceflags)
- [init](corelib.DataGrid.md#init)
- [initAsync](corelib.DataGrid.md#initasync)
- [initSync](corelib.DataGrid.md#initsync)
- [initialPopulate](corelib.DataGrid.md#initialpopulate)
- [initialize](corelib.DataGrid.md#initialize)
- [initializeFilterBar](corelib.DataGrid.md#initializefilterbar)
- [internalInit](corelib.DataGrid.md#internalinit)
- [internalRefresh](corelib.DataGrid.md#internalrefresh)
- [invokeSubmitHandlers](corelib.DataGrid.md#invokesubmithandlers)
- [itemAt](corelib.DataGrid.md#itemat)
- [itemLink](corelib.DataGrid.md#itemlink)
- [layout](corelib.DataGrid.md#layout)
- [markupReady](corelib.DataGrid.md#markupready)
- [onClick](corelib.DataGrid.md#onclick)
- [onViewFilter](corelib.DataGrid.md#onviewfilter)
- [onViewProcessData](corelib.DataGrid.md#onviewprocessdata)
- [onViewSubmit](corelib.DataGrid.md#onviewsubmit)
- [persistSettings](corelib.DataGrid.md#persistsettings)
- [populateLock](corelib.DataGrid.md#populatelock)
- [populateUnlock](corelib.DataGrid.md#populateunlock)
- [populateWhenVisible](corelib.DataGrid.md#populatewhenvisible)
- [postProcessColumns](corelib.DataGrid.md#postprocesscolumns)
- [propertyItemsToSlickColumns](corelib.DataGrid.md#propertyitemstoslickcolumns)
- [quickFilterChange](corelib.DataGrid.md#quickfilterchange)
- [refresh](corelib.DataGrid.md#refresh)
- [refreshIfNeeded](corelib.DataGrid.md#refreshifneeded)
- [renderContents](corelib.DataGrid.md#rendercontents)
- [resizeCanvas](corelib.DataGrid.md#resizecanvas)
- [restoreSettings](corelib.DataGrid.md#restoresettings)
- [rowCount](corelib.DataGrid.md#rowcount)
- [setCriteriaParameter](corelib.DataGrid.md#setcriteriaparameter)
- [setEquality](corelib.DataGrid.md#setequality)
- [setIncludeColumnsParameter](corelib.DataGrid.md#setincludecolumnsparameter)
- [setInitialSortOrder](corelib.DataGrid.md#setinitialsortorder)
- [setIsDisabled](corelib.DataGrid.md#setisdisabled)
- [setItems](corelib.DataGrid.md#setitems)
- [setTitle](corelib.DataGrid.md#settitle)
- [set\_readOnly](corelib.DataGrid.md#set_readonly)
- [subDialogDataChange](corelib.DataGrid.md#subdialogdatachange)
- [tryFindQuickFilter](corelib.DataGrid.md#tryfindquickfilter)
- [updateDisabledState](corelib.DataGrid.md#updatedisabledstate)
- [updateInterface](corelib.DataGrid.md#updateinterface)
- [useAsync](corelib.DataGrid.md#useasync)
- [useLayoutTimer](corelib.DataGrid.md#uselayouttimer)
- [usePager](corelib.DataGrid.md#usepager)
- [viewDataChanged](corelib.DataGrid.md#viewdatachanged)
- [create](corelib.DataGrid.md#create)
- [elementFor](corelib.DataGrid.md#elementfor)
- [getWidgetName](corelib.DataGrid.md#getwidgetname)
- [propertyItemToQuickFilter](corelib.DataGrid.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new DataGrid**<`TItem`, `TOptions`\>(`container`, `options?`)

#### Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `options?` | `TOptions` |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/datagrid/datagrid.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L117)

## Properties

### \_idProperty

• `Private` **\_idProperty**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1088](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1088)

___

### \_isActiveProperty

• `Private` **\_isActiveProperty**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1109)

___

### \_isDisabled

• `Private` **\_isDisabled**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L93)

___

### \_layoutTimer

• `Private` **\_layoutTimer**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L94)

___

### \_localTextDbPrefix

• `Private` **\_localTextDbPrefix**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1063](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1063)

___

### \_readonly

• `Private` **\_readonly**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:1034](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1034)

___

### \_slickGridOnClick

• `Private` **\_slickGridOnClick**: `any`

#### Defined in

[src/ui/datagrid/datagrid.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L96)

___

### \_slickGridOnSort

• `Private` **\_slickGridOnSort**: `any`

#### Defined in

[src/ui/datagrid/datagrid.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L95)

___

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L103)

___

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L109)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Defined in

[src/ui/datagrid/datagrid.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L106)

___

### slickContainer

• `Protected` **slickContainer**: `JQuery`

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### view

• **view**: [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Defined in

[src/ui/datagrid/datagrid.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L111)

## Accessors

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:1036](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1036)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1040](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1040)

## Methods

### addBooleanFilter

▸ `Protected` **addBooleanFilter**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](corelib.SelectEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`SelectEditor`](corelib.SelectEditor.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1174)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addDateRangeFilter

▸ `Protected` **addDateRangeFilter**(`field`, `title?`): [`DateEditor`](corelib.DateEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateEditor`](corelib.DateEditor.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1158)

___

### addDateTimeRangeFilter

▸ `Protected` **addDateTimeRangeFilter**(`field`, `title?`): [`DateTimeEditor`](corelib.DateTimeEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateTimeEditor`](corelib.DateTimeEditor.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1166)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1138)

___

### addQuickFilter

▸ `Protected` **addQuickFilter**<`TWidget`, `TOptions`\>(`opt`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`any`, `TWidget`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<`TWidget`, `TOptions`\> |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/datagrid.ts:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1154)

___

### addValidationRule

▸ **addValidationRule**(`eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[addValidationRule](corelib.Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L191)

___

### attrs

▸ `Protected` **attrs**<`TAttr`\>(`attrType`): `TAttr`[]

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` |

#### Returns

`TAttr`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L202)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L578)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L678)

___

### booleanQuickFilter

▸ `Protected` **booleanQuickFilter**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`SelectEditor`](corelib.SelectEditor.md), [`SelectEditorOptions`](../interfaces/corelib.SelectEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`SelectEditor`](corelib.SelectEditor.md), [`SelectEditorOptions`](../interfaces/corelib.SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1178)

___

### canFilterColumn

▸ `Protected` **canFilterColumn**(`column`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`<`any`\> |

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L495)

___

### canShowColumn

▸ `Protected` **canShowColumn**(`column`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`<`any`\> |

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:1213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1213)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L259)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:807](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L807)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L360)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:821](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L821)

___

### createQuickFilters

▸ `Protected` **createQuickFilters**(`filters?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filters?` | [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L256)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L371)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L760)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L518)

___

### createToolbar

▸ `Protected` **createToolbar**(`buttons`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `buttons` | [`ToolButton`](../interfaces/corelib.ToolButton.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L848)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L245)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L764)

___

### dateRangeQuickFilter

▸ `Protected` **dateRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateEditor`](corelib.DateEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateEditor`](corelib.DateEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1162)

___

### dateTimeRangeQuickFilter

▸ `Protected` **dateTimeRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateTimeEditor`](corelib.DateTimeEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateTimeEditor`](corelib.DateTimeEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1170)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/datagrid/datagrid.ts:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L375)

___

### determineText

▸ `Protected` **determineText**(`getKey`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `getKey` | (`prefix`: `string`) => `string` |

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1142)

___

### editItem

▸ `Protected` **editItem**(`entityOrId`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entityOrId` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L644)

___

### editItemOfType

▸ `Protected` **editItemOfType**(`itemType`, `entityOrId`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `entityOrId` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L648)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L798)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L248)

___

### findQuickFilter

▸ `Protected` **findQuickFilter**<`TWidget`\>(`type`, `field`): `TWidget`

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

[src/ui/datagrid/datagrid.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L342)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L636)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:640](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L640)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L472)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L476)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:941](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L941)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L899)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getCurrentSettings

▸ `Protected` **getCurrentSettings**(`flags?`): [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md) |

#### Returns

[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1414)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:769](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L769)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Implementation of

[IDataGrid](../interfaces/corelib.IDataGrid.md).[getElement](../interfaces/corelib.IDataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1504)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Implementation of

[IDataGrid](../interfaces/corelib.IDataGrid.md).[getFilterStore](../interfaces/corelib.IDataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1516)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Implementation of

[IDataGrid](../interfaces/corelib.IDataGrid.md).[getGrid](../interfaces/corelib.IDataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1508)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L995)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1090](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1090)

___

### getIncludeColumns

▸ `Protected` **getIncludeColumns**(`include`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `include` | `Object` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L706)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L241)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1111)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1105)

___

### getItemCssClass

▸ `Protected` **getItemCssClass**(`item`, `index`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `index` | `number` |

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L409)

___

### getItemMetadata

▸ `Protected` **getItemMetadata**(`item`, `index`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `index` | `number` |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/datagrid.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L443)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L881)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L570)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1065](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1065)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1077](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1077)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L813)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1198)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1194)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Returns

[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1234)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L908)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:912](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L912)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L932)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L278)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L367)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1059](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1059)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:975](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L975)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L853)

___

### getView

▸ **getView**(): [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Implementation of

[IDataGrid](../interfaces/corelib.IDataGrid.md).[getView](../interfaces/corelib.IDataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1512)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L826)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1044](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1044)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1209)

___

### init

▸ **init**(`action?`): [`DataGrid`](corelib.DataGrid.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`DataGrid`](corelib.DataGrid.md)<`TItem`, `TOptions`\>

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L185)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L179)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L480)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L502)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1019)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1182)

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

[src/ui/datagrid/datagrid.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L562)

___

### itemLink

▸ `Protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../modules/corelib_slick.md#format)<`TItem`\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../modules/corelib_slick.md#format)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L885)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L206)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L757)

___

### onClick

▸ `Protected` **onClick**(`e`, `row`, `cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:657](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L657)

___

### onViewFilter

▸ `Protected` **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L702)

___

### onViewProcessData

▸ `Protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TItem`\> |

#### Returns

[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L698)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L745)

___

### persistSettings

▸ `Protected` **persistSettings**(`flags?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1404)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:987](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L987)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:991](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L991)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:803](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L803)

___

### postProcessColumns

▸ `Protected` **postProcessColumns**(`columns`): `Column`<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `columns` | `Column`<`any`\>[] |

#### Returns

`Column`<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L451)

___

### propertyItemsToSlickColumns

▸ `Protected` **propertyItemsToSlickColumns**(`propertyItems`): `Column`<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `propertyItems` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[] |

#### Returns

`Column`<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:945](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L945)

___

### quickFilterChange

▸ `Protected` **quickFilterChange**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1188)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L999)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1012)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1130)

___

### restoreSettings

▸ `Protected` **restoreSettings**(`settings?`, `flags?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings?` | [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1246)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L566)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:721](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L721)

___

### setEquality

▸ `Protected` **setEquality**(`field`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L731)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L735)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:537](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L537)

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

[src/ui/datagrid/datagrid.ts:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1023)

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

[src/ui/datagrid/datagrid.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L574)

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

[src/ui/datagrid/datagrid.ts:861](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L861)

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

[IReadOnly](corelib.IReadOnly.md).[set_readOnly](corelib.IReadOnly.md#set_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1048)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1134)

___

### tryFindQuickFilter

▸ `Protected` **tryFindQuickFilter**<`TWidget`\>(`type`, `field`): `TWidget`

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

[src/ui/datagrid/datagrid.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L349)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1126)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1055](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1055)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L198)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L794)

___

### viewDataChanged

▸ `Protected` **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |
| `rows` | `TItem`[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:673](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L673)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/corelib.CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](corelib.Widget.md).[create](corelib.Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

___

### elementFor

▸ `Static` **elementFor**<`TWidget`\>(`editorType`): `JQuery`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[elementFor](corelib.Widget.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

___

### getWidgetName

▸ `Static` **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getWidgetName](corelib.Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

___

### propertyItemToQuickFilter

▸ `Static` **propertyItemToQuickFilter**(`item`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/datagrid.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L288)
