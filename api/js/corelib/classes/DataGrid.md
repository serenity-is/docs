[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / DataGrid

# Class: DataGrid<TItem, TOptions\>

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`Widget`](Widget.md)<`TOptions`\>

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
- [element](DataGrid.md#element)
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
- [widgetName](DataGrid.md#widgetname)
- [defaultColumnWidthDelta](DataGrid.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](DataGrid.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](DataGrid.md#defaultheaderheight)
- [defaultPersistanceStorage](DataGrid.md#defaultpersistancestorage)
- [defaultRowHeight](DataGrid.md#defaultrowheight)

### Accessors

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
- [attrs](DataGrid.md#attrs)
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
- [getDefaultSortBy](DataGrid.md#getdefaultsortby)
- [getElement](DataGrid.md#getelement)
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
- [initAsync](DataGrid.md#initasync)
- [initSync](DataGrid.md#initsync)
- [initialPopulate](DataGrid.md#initialpopulate)
- [initialize](DataGrid.md#initialize)
- [initializeFilterBar](DataGrid.md#initializefilterbar)
- [internalInit](DataGrid.md#internalinit)
- [internalRefresh](DataGrid.md#internalrefresh)
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
- [propertyItemsToSlickColumns](DataGrid.md#propertyitemstoslickcolumns)
- [quickFilterChange](DataGrid.md#quickfilterchange)
- [refresh](DataGrid.md#refresh)
- [refreshIfNeeded](DataGrid.md#refreshifneeded)
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
- [tryFindQuickFilter](DataGrid.md#tryfindquickfilter)
- [updateDisabledState](DataGrid.md#updatedisabledstate)
- [updateInterface](DataGrid.md#updateinterface)
- [useAsync](DataGrid.md#useasync)
- [useLayoutTimer](DataGrid.md#uselayouttimer)
- [usePager](DataGrid.md#usepager)
- [viewDataChanged](DataGrid.md#viewdatachanged)
- [create](DataGrid.md#create)
- [elementFor](DataGrid.md#elementfor)
- [getWidgetName](DataGrid.md#getwidgetname)
- [propertyItemToQuickFilter](DataGrid.md#propertyitemtoquickfilter)

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

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/datagrid/datagrid.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L117)

## Properties

### \_idProperty

• `Private` **\_idProperty**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1079](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1079)

___

### \_isActiveProperty

• `Private` **\_isActiveProperty**: `string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1100)

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

[src/ui/datagrid/datagrid.ts:1054](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1054)

___

### \_readonly

• `Private` **\_readonly**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:1025](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1025)

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

[Widget](Widget.md).[element](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

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

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

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

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### view

• **view**: [`RemoteView`](RemoteView.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](Widget.md).[widgetName](Widget.md#widgetname)

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

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

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

[src/ui/datagrid/datagrid.ts:1027](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1027)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1031)

## Methods

### addBooleanFilter

▸ `Protected` **addBooleanFilter**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](SelectEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`SelectEditor`](SelectEditor.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1165)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addDateRangeFilter

▸ `Protected` **addDateRangeFilter**(`field`, `title?`): [`DateEditor`](DateEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateEditor`](DateEditor.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1149)

___

### addDateTimeRangeFilter

▸ `Protected` **addDateTimeRangeFilter**(`field`, `title?`): [`DateTimeEditor`](DateTimeEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1157)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1129)

___

### addQuickFilter

▸ `Protected` **addQuickFilter**<`TWidget`, `TOptions`\>(`opt`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)<`any`, `TWidget`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`QuickFilter`](../interfaces/QuickFilter.md)<`TWidget`, `TOptions`\> |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/datagrid.ts:1145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1145)

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

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

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

[src/ui/datagrid/datagrid.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L205)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L569)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:669](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L669)

___

### booleanQuickFilter

▸ `Protected` **booleanQuickFilter**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/QuickFilter.md)<[`SelectEditor`](SelectEditor.md), [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)<[`SelectEditor`](SelectEditor.md), [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1169)

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

[src/ui/datagrid/datagrid.ts:486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L486)

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

[src/ui/datagrid/datagrid.ts:1204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1204)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L798)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L350)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:812](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L812)

___

### createQuickFilters

▸ `Protected` **createQuickFilters**(`filters?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filters?` | [`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L246)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L361)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/datagrid/datagrid.ts:751](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L751)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L509)

___

### createToolbar

▸ `Protected` **createToolbar**(`buttons`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `buttons` | [`ToolButton`](../interfaces/ToolButton.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L839)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L235)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:755](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L755)

___

### dateRangeQuickFilter

▸ `Protected` **dateRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)<[`DateEditor`](DateEditor.md), [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)<[`DateEditor`](DateEditor.md), [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1153)

___

### dateTimeRangeQuickFilter

▸ `Protected` **dateTimeRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)<[`DateTimeEditor`](DateTimeEditor.md), [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)<[`DateTimeEditor`](DateTimeEditor.md), [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1161)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/datagrid/datagrid.ts:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L366)

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

[src/ui/datagrid/datagrid.ts:1133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1133)

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

[src/ui/datagrid/datagrid.ts:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L635)

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

[src/ui/datagrid/datagrid.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L639)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L789)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L238)

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

[src/ui/datagrid/datagrid.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L332)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L627)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:631](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L631)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L463)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:467](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L467)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`TItem`\>[]

#### Returns

`Column`<`TItem`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L932)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:890](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L890)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getCurrentSettings

▸ `Protected` **getCurrentSettings**(`flags?`): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1417)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L760)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getElement](../interfaces/IDataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1507)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getFilterStore](../interfaces/IDataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1519)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getGrid](../interfaces/IDataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1511)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:986](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L986)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1081](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1081)

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

[src/ui/datagrid/datagrid.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L697)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L231)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1102)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1096](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1096)

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

[src/ui/datagrid/datagrid.ts:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L400)

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

[src/ui/datagrid/datagrid.ts:434](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L434)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/datagrid/datagrid.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L561)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1056](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1056)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1068](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1068)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:1189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1189)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1185)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1225)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L899)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:903](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L903)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/datagrid/datagrid.ts:923](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L923)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L268)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Defined in

[src/ui/datagrid/datagrid.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L357)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1050](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1050)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:966](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L966)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getView

▸ **getView**(): [`RemoteView`](RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)<`TItem`\>

#### Implementation of

[IDataGrid](../interfaces/IDataGrid.md).[getView](../interfaces/IDataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1515)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:817](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L817)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1035](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1035)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Defined in

[src/ui/datagrid/datagrid.ts:1200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1200)

___

### init

▸ **init**(`action?`): [`DataGrid`](DataGrid.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`DataGrid`](DataGrid.md)<`TItem`, `TOptions`\>

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L188)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L182)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L471)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[initialize](Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L493)

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

[src/ui/datagrid/datagrid.ts:1010](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1010)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1173)

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

[src/ui/datagrid/datagrid.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L553)

___

### itemLink

▸ `Protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../modules.md#format)<`TItem`\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../modules.md#format)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L876)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L209)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:748](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L748)

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

[src/ui/datagrid/datagrid.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L648)

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

[src/ui/datagrid/datagrid.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L693)

___

### onViewProcessData

▸ `Protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/ListResponse.md)<`TItem`\> |

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:689](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L689)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:736](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L736)

___

### persistSettings

▸ `Protected` **persistSettings**(`flags?`): `void` \| `Promise`<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

`void` \| `Promise`<`void`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1407](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1407)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:978](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L978)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L982)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L794)

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

[src/ui/datagrid/datagrid.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L442)

___

### propertyItemsToSlickColumns

▸ `Protected` **propertyItemsToSlickColumns**(`propertyItems`): `Column`<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `propertyItems` | [`PropertyItem`](../interfaces/PropertyItem.md)[] |

#### Returns

`Column`<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.ts:936](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L936)

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

[src/ui/datagrid/datagrid.ts:1179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1179)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L990)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1003)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1121)

___

### restoreSettings

▸ `Protected` **restoreSettings**(`settings?`, `flags?`): `void` \| `Promise`<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings?` | [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

`void` \| `Promise`<`void`\>

#### Defined in

[src/ui/datagrid/datagrid.ts:1244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1244)

___

### restoreSettingsFrom

▸ `Protected` **restoreSettingsFrom**(`settings`, `flags?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings` | [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1255)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L557)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:712](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L712)

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

[src/ui/datagrid/datagrid.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L722)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L726)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L528)

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

[src/ui/datagrid/datagrid.ts:1014](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1014)

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

[src/ui/datagrid/datagrid.ts:565](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L565)

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

[src/ui/datagrid/datagrid.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L852)

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

[src/ui/datagrid/datagrid.ts:1039](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1039)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1125)

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

[src/ui/datagrid/datagrid.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L339)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1117)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.ts:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1046)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L197)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L201)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.ts:785](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L785)

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

[src/ui/datagrid/datagrid.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L664)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](Widget.md).[create](Widget.md#create)

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

[Widget](Widget.md).[elementFor](Widget.md#elementfor)

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

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

___

### propertyItemToQuickFilter

▸ `Static` **propertyItemToQuickFilter**(`item`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L278)
