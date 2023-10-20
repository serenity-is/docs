[@serenity-is/corelib](../README.md) / CheckTreeEditor

# Class: CheckTreeEditor<TItem, TOptions\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | extends [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`any`\> |
| `TOptions` | `TOptions` |

## Hierarchy

- [`DataGrid`](DataGrid.md)<`TItem`, `TOptions`\>

  ↳ **`CheckTreeEditor`**

  ↳↳ [`CheckLookupEditor`](CheckLookupEditor.md)

## Implements

- [`IGetEditValue`](IGetEditValue.md)
- [`ISetEditValue`](ISetEditValue.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](CheckTreeEditor.md#constructor)

### Properties

- [\_readOnly](CheckTreeEditor.md#_readonly)
- [allColumns](CheckTreeEditor.md#allcolumns)
- [byId](CheckTreeEditor.md#byid)
- [element](CheckTreeEditor.md#element)
- [filterBar](CheckTreeEditor.md#filterbar)
- [idPrefix](CheckTreeEditor.md#idprefix)
- [initialSettings](CheckTreeEditor.md#initialsettings)
- [openDialogsAsPanel](CheckTreeEditor.md#opendialogsaspanel)
- [options](CheckTreeEditor.md#options)
- [propertyItemsData](CheckTreeEditor.md#propertyitemsdata)
- [quickFiltersBar](CheckTreeEditor.md#quickfiltersbar)
- [quickFiltersDiv](CheckTreeEditor.md#quickfiltersdiv)
- [restoringSettings](CheckTreeEditor.md#restoringsettings)
- [slickContainer](CheckTreeEditor.md#slickcontainer)
- [slickGrid](CheckTreeEditor.md#slickgrid)
- [titleDiv](CheckTreeEditor.md#titlediv)
- [toolbar](CheckTreeEditor.md#toolbar)
- [uniqueName](CheckTreeEditor.md#uniquename)
- [view](CheckTreeEditor.md#view)
- [widgetName](CheckTreeEditor.md#widgetname)
- [defaultColumnWidthDelta](CheckTreeEditor.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](CheckTreeEditor.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](CheckTreeEditor.md#defaultheaderheight)
- [defaultPersistanceStorage](CheckTreeEditor.md#defaultpersistancestorage)
- [defaultRowHeight](CheckTreeEditor.md#defaultrowheight)

### Accessors

- [readOnly](CheckTreeEditor.md#readonly)
- [value](CheckTreeEditor.md#value)

### Methods

- [addBooleanFilter](CheckTreeEditor.md#addbooleanfilter)
- [addCssClass](CheckTreeEditor.md#addcssclass)
- [addDateRangeFilter](CheckTreeEditor.md#adddaterangefilter)
- [addDateTimeRangeFilter](CheckTreeEditor.md#adddatetimerangefilter)
- [addFilterSeparator](CheckTreeEditor.md#addfilterseparator)
- [addQuickFilter](CheckTreeEditor.md#addquickfilter)
- [addValidationRule](CheckTreeEditor.md#addvalidationrule)
- [afterInit](CheckTreeEditor.md#afterinit)
- [allDescendantsSelected](CheckTreeEditor.md#alldescendantsselected)
- [allItemsSelected](CheckTreeEditor.md#allitemsselected)
- [anyDescendantsSelected](CheckTreeEditor.md#anydescendantsselected)
- [attrs](CheckTreeEditor.md#attrs)
- [bindToSlickEvents](CheckTreeEditor.md#bindtoslickevents)
- [bindToViewEvents](CheckTreeEditor.md#bindtoviewevents)
- [booleanQuickFilter](CheckTreeEditor.md#booleanquickfilter)
- [canFilterColumn](CheckTreeEditor.md#canfiltercolumn)
- [canShowColumn](CheckTreeEditor.md#canshowcolumn)
- [change](CheckTreeEditor.md#change)
- [changeSelect2](CheckTreeEditor.md#changeselect2)
- [createFilterBar](CheckTreeEditor.md#createfilterbar)
- [createIncludeDeletedButton](CheckTreeEditor.md#createincludedeletedbutton)
- [createPager](CheckTreeEditor.md#createpager)
- [createQuickFilters](CheckTreeEditor.md#createquickfilters)
- [createQuickSearchInput](CheckTreeEditor.md#createquicksearchinput)
- [createSlickContainer](CheckTreeEditor.md#createslickcontainer)
- [createSlickGrid](CheckTreeEditor.md#createslickgrid)
- [createToolbar](CheckTreeEditor.md#createtoolbar)
- [createToolbarExtensions](CheckTreeEditor.md#createtoolbarextensions)
- [createView](CheckTreeEditor.md#createview)
- [dateRangeQuickFilter](CheckTreeEditor.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](CheckTreeEditor.md#datetimerangequickfilter)
- [destroy](CheckTreeEditor.md#destroy)
- [determineText](CheckTreeEditor.md#determinetext)
- [editItem](CheckTreeEditor.md#edititem)
- [editItemOfType](CheckTreeEditor.md#edititemoftype)
- [enableFiltering](CheckTreeEditor.md#enablefiltering)
- [ensureQuickFilterBar](CheckTreeEditor.md#ensurequickfilterbar)
- [findQuickFilter](CheckTreeEditor.md#findquickfilter)
- [getAddButtonCaption](CheckTreeEditor.md#getaddbuttoncaption)
- [getButtons](CheckTreeEditor.md#getbuttons)
- [getColumnWidthDelta](CheckTreeEditor.md#getcolumnwidthdelta)
- [getColumnWidthScale](CheckTreeEditor.md#getcolumnwidthscale)
- [getColumns](CheckTreeEditor.md#getcolumns)
- [getColumnsKey](CheckTreeEditor.md#getcolumnskey)
- [getCssClass](CheckTreeEditor.md#getcssclass)
- [getCurrentSettings](CheckTreeEditor.md#getcurrentsettings)
- [getDefaultSortBy](CheckTreeEditor.md#getdefaultsortby)
- [getDelimited](CheckTreeEditor.md#getdelimited)
- [getDescendantsSelected](CheckTreeEditor.md#getdescendantsselected)
- [getEditValue](CheckTreeEditor.md#geteditvalue)
- [getElement](CheckTreeEditor.md#getelement)
- [getFilterStore](CheckTreeEditor.md#getfilterstore)
- [getGrid](CheckTreeEditor.md#getgrid)
- [getGridCanLoad](CheckTreeEditor.md#getgridcanload)
- [getGridField](CheckTreeEditor.md#getgridfield)
- [getIdProperty](CheckTreeEditor.md#getidproperty)
- [getIncludeColumns](CheckTreeEditor.md#getincludecolumns)
- [getInitialCollapse](CheckTreeEditor.md#getinitialcollapse)
- [getInitialTitle](CheckTreeEditor.md#getinitialtitle)
- [getIsActiveProperty](CheckTreeEditor.md#getisactiveproperty)
- [getIsDeletedProperty](CheckTreeEditor.md#getisdeletedproperty)
- [getItemCssClass](CheckTreeEditor.md#getitemcssclass)
- [getItemMetadata](CheckTreeEditor.md#getitemmetadata)
- [getItemText](CheckTreeEditor.md#getitemtext)
- [getItemType](CheckTreeEditor.md#getitemtype)
- [getItems](CheckTreeEditor.md#getitems)
- [getLocalTextDbPrefix](CheckTreeEditor.md#getlocaltextdbprefix)
- [getLocalTextPrefix](CheckTreeEditor.md#getlocaltextprefix)
- [getPagerOptions](CheckTreeEditor.md#getpageroptions)
- [getPersistanceKey](CheckTreeEditor.md#getpersistancekey)
- [getPersistanceStorage](CheckTreeEditor.md#getpersistancestorage)
- [getPersistedSettings](CheckTreeEditor.md#getpersistedsettings)
- [getPropertyItems](CheckTreeEditor.md#getpropertyitems)
- [getPropertyItemsData](CheckTreeEditor.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](CheckTreeEditor.md#getpropertyitemsdataasync)
- [getQuickFilters](CheckTreeEditor.md#getquickfilters)
- [getQuickSearchFields](CheckTreeEditor.md#getquicksearchfields)
- [getRowDefinition](CheckTreeEditor.md#getrowdefinition)
- [getSelectAllText](CheckTreeEditor.md#getselectalltext)
- [getSlickOptions](CheckTreeEditor.md#getslickoptions)
- [getTitle](CheckTreeEditor.md#gettitle)
- [getTreeItems](CheckTreeEditor.md#gettreeitems)
- [getView](CheckTreeEditor.md#getview)
- [getViewOptions](CheckTreeEditor.md#getviewoptions)
- [get\_readOnly](CheckTreeEditor.md#get_readonly)
- [get\_value](CheckTreeEditor.md#get_value)
- [gridPersistanceFlags](CheckTreeEditor.md#gridpersistanceflags)
- [init](CheckTreeEditor.md#init)
- [initAsync](CheckTreeEditor.md#initasync)
- [initSync](CheckTreeEditor.md#initsync)
- [initialPopulate](CheckTreeEditor.md#initialpopulate)
- [initialize](CheckTreeEditor.md#initialize)
- [initializeFilterBar](CheckTreeEditor.md#initializefilterbar)
- [internalInit](CheckTreeEditor.md#internalinit)
- [internalRefresh](CheckTreeEditor.md#internalrefresh)
- [invokeSubmitHandlers](CheckTreeEditor.md#invokesubmithandlers)
- [isThreeStateHierarchy](CheckTreeEditor.md#isthreestatehierarchy)
- [itemAt](CheckTreeEditor.md#itemat)
- [itemLink](CheckTreeEditor.md#itemlink)
- [itemSelectedChanged](CheckTreeEditor.md#itemselectedchanged)
- [layout](CheckTreeEditor.md#layout)
- [markupReady](CheckTreeEditor.md#markupready)
- [moveSelectedUp](CheckTreeEditor.md#moveselectedup)
- [onClick](CheckTreeEditor.md#onclick)
- [onViewFilter](CheckTreeEditor.md#onviewfilter)
- [onViewProcessData](CheckTreeEditor.md#onviewprocessdata)
- [onViewSubmit](CheckTreeEditor.md#onviewsubmit)
- [persistSettings](CheckTreeEditor.md#persistsettings)
- [populateLock](CheckTreeEditor.md#populatelock)
- [populateUnlock](CheckTreeEditor.md#populateunlock)
- [populateWhenVisible](CheckTreeEditor.md#populatewhenvisible)
- [postProcessColumns](CheckTreeEditor.md#postprocesscolumns)
- [propertyItemsToSlickColumns](CheckTreeEditor.md#propertyitemstoslickcolumns)
- [quickFilterChange](CheckTreeEditor.md#quickfilterchange)
- [refresh](CheckTreeEditor.md#refresh)
- [refreshIfNeeded](CheckTreeEditor.md#refreshifneeded)
- [renderContents](CheckTreeEditor.md#rendercontents)
- [resizeCanvas](CheckTreeEditor.md#resizecanvas)
- [restoreSettings](CheckTreeEditor.md#restoresettings)
- [restoreSettingsFrom](CheckTreeEditor.md#restoresettingsfrom)
- [rowCount](CheckTreeEditor.md#rowcount)
- [setAllSubTreeSelected](CheckTreeEditor.md#setallsubtreeselected)
- [setCriteriaParameter](CheckTreeEditor.md#setcriteriaparameter)
- [setEditValue](CheckTreeEditor.md#seteditvalue)
- [setEquality](CheckTreeEditor.md#setequality)
- [setIncludeColumnsParameter](CheckTreeEditor.md#setincludecolumnsparameter)
- [setInitialSortOrder](CheckTreeEditor.md#setinitialsortorder)
- [setIsDisabled](CheckTreeEditor.md#setisdisabled)
- [setItems](CheckTreeEditor.md#setitems)
- [setTitle](CheckTreeEditor.md#settitle)
- [set\_readOnly](CheckTreeEditor.md#set_readonly)
- [set\_value](CheckTreeEditor.md#set_value)
- [sortItems](CheckTreeEditor.md#sortitems)
- [subDialogDataChange](CheckTreeEditor.md#subdialogdatachange)
- [tryFindQuickFilter](CheckTreeEditor.md#tryfindquickfilter)
- [updateDisabledState](CheckTreeEditor.md#updatedisabledstate)
- [updateFlags](CheckTreeEditor.md#updateflags)
- [updateInterface](CheckTreeEditor.md#updateinterface)
- [updateItems](CheckTreeEditor.md#updateitems)
- [updateSelectAll](CheckTreeEditor.md#updateselectall)
- [useAsync](CheckTreeEditor.md#useasync)
- [useLayoutTimer](CheckTreeEditor.md#uselayouttimer)
- [usePager](CheckTreeEditor.md#usepager)
- [viewDataChanged](CheckTreeEditor.md#viewdatachanged)
- [create](CheckTreeEditor.md#create)
- [elementFor](CheckTreeEditor.md#elementfor)
- [getWidgetName](CheckTreeEditor.md#getwidgetname)
- [propertyItemToQuickFilter](CheckTreeEditor.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new CheckTreeEditor**<`TItem`, `TOptions`\>(`div`, `opt?`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | extends [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`any`, `TItem`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt?` | `TOptions` |

#### Overrides

[DataGrid](DataGrid.md).[constructor](DataGrid.md#constructor)

#### Defined in

[src/ui/editors/checktreeeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L31)

## Properties

### \_readOnly

• `Private` **\_readOnly**: `boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:391](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L391)

___

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[allColumns](DataGrid.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L103)

___

### byId

• `Private` **byId**: `Object`

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[src/ui/editors/checktreeeditor.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L29)

___

### element

• **element**: `JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[element](DataGrid.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

#### Inherited from

[DataGrid](DataGrid.md).[filterBar](DataGrid.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[DataGrid](DataGrid.md).[idPrefix](DataGrid.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[DataGrid](DataGrid.md).[initialSettings](DataGrid.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[DataGrid](DataGrid.md).[openDialogsAsPanel](DataGrid.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L109)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[DataGrid](DataGrid.md).[options](DataGrid.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[DataGrid](DataGrid.md).[propertyItemsData](DataGrid.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[DataGrid](DataGrid.md).[quickFiltersBar](DataGrid.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[quickFiltersDiv](DataGrid.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[DataGrid](DataGrid.md).[restoringSettings](DataGrid.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L106)

___

### slickContainer

• `Protected` **slickContainer**: `JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[slickContainer](DataGrid.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[slickGrid](DataGrid.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[titleDiv](DataGrid.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Inherited from

[DataGrid](DataGrid.md).[toolbar](DataGrid.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[DataGrid](DataGrid.md).[uniqueName](DataGrid.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### view

• **view**: [`RemoteView`](RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[view](DataGrid.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[DataGrid](DataGrid.md).[widgetName](DataGrid.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultColumnWidthDelta](DataGrid.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultColumnWidthScale](DataGrid.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultHeaderHeight](DataGrid.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[DataGrid](DataGrid.md).[defaultPersistanceStorage](DataGrid.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultRowHeight](DataGrid.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L111)

## Accessors

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

DataGrid.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:1027](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1027)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Inherited from

DataGrid.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1031)

___

### value

• `get` **value**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L415)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L454)

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

#### Inherited from

[DataGrid](DataGrid.md).[addBooleanFilter](DataGrid.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1165)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[addCssClass](DataGrid.md#addcssclass)

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

#### Inherited from

[DataGrid](DataGrid.md).[addDateRangeFilter](DataGrid.md#adddaterangefilter)

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

#### Inherited from

[DataGrid](DataGrid.md).[addDateTimeRangeFilter](DataGrid.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1157)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[addFilterSeparator](DataGrid.md#addfilterseparator)

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

#### Inherited from

[DataGrid](DataGrid.md).[addQuickFilter](DataGrid.md#addquickfilter)

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

[DataGrid](DataGrid.md).[addValidationRule](DataGrid.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[afterInit](DataGrid.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### allDescendantsSelected

▸ `Protected` **allDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L283)

___

### allItemsSelected

▸ `Protected` **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L272)

___

### anyDescendantsSelected

▸ `Protected` **anyDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L303)

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

#### Inherited from

[DataGrid](DataGrid.md).[attrs](DataGrid.md#attrs)

#### Defined in

[src/ui/datagrid/datagrid.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L205)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[bindToSlickEvents](DataGrid.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L569)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[bindToViewEvents](DataGrid.md#bindtoviewevents)

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

#### Inherited from

[DataGrid](DataGrid.md).[booleanQuickFilter](DataGrid.md#booleanquickfilter)

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

#### Inherited from

[DataGrid](DataGrid.md).[canFilterColumn](DataGrid.md#canfiltercolumn)

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

#### Inherited from

[DataGrid](DataGrid.md).[canShowColumn](DataGrid.md#canshowcolumn)

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

[DataGrid](DataGrid.md).[change](DataGrid.md#change)

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

[DataGrid](DataGrid.md).[change](DataGrid.md#change)

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

[DataGrid](DataGrid.md).[changeSelect2](DataGrid.md#changeselect2)

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

[DataGrid](DataGrid.md).[changeSelect2](DataGrid.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createFilterBar](DataGrid.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L798)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createIncludeDeletedButton](DataGrid.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L350)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createPager](DataGrid.md#createpager)

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

#### Inherited from

[DataGrid](DataGrid.md).[createQuickFilters](DataGrid.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L246)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createQuickSearchInput](DataGrid.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L361)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[createSlickContainer](DataGrid.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:751](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L751)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Overrides

[DataGrid](DataGrid.md).[createSlickGrid](DataGrid.md#createslickgrid)

#### Defined in

[src/ui/editors/checktreeeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L116)

___

### createToolbar

▸ `Protected` **createToolbar**(`buttons`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `buttons` | [`ToolButton`](../interfaces/ToolButton.md)[] |

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createToolbar](DataGrid.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L839)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createToolbarExtensions](DataGrid.md#createtoolbarextensions)

#### Defined in

[src/ui/datagrid/datagrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L235)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[createView](DataGrid.md#createview)

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

#### Inherited from

[DataGrid](DataGrid.md).[dateRangeQuickFilter](DataGrid.md#daterangequickfilter)

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

#### Inherited from

[DataGrid](DataGrid.md).[dateTimeRangeQuickFilter](DataGrid.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1161)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[destroy](DataGrid.md#destroy)

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

#### Inherited from

[DataGrid](DataGrid.md).[determineText](DataGrid.md#determinetext)

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

#### Inherited from

[DataGrid](DataGrid.md).[editItem](DataGrid.md#edititem)

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

#### Inherited from

[DataGrid](DataGrid.md).[editItemOfType](DataGrid.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L639)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[enableFiltering](DataGrid.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L789)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[DataGrid](DataGrid.md).[ensureQuickFilterBar](DataGrid.md#ensurequickfilterbar)

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

#### Inherited from

[DataGrid](DataGrid.md).[findQuickFilter](DataGrid.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L332)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getAddButtonCaption](DataGrid.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L627)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[DataGrid](DataGrid.md).[getButtons](DataGrid.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L79)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](DataGrid.md).[getColumnWidthDelta](DataGrid.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L463)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](DataGrid.md).[getColumnWidthScale](DataGrid.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:467](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L467)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Overrides

[DataGrid](DataGrid.md).[getColumns](DataGrid.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L318)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getColumnsKey](DataGrid.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:890](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L890)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getCssClass](DataGrid.md#getcssclass)

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

#### Inherited from

[DataGrid](DataGrid.md).[getCurrentSettings](DataGrid.md#getcurrentsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1417)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[DataGrid](DataGrid.md).[getDefaultSortBy](DataGrid.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L760)

___

### getDelimited

▸ `Protected` **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L299)

___

### getDescendantsSelected

▸ `Protected` **getDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L251)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Implementation of

[IGetEditValue](IGetEditValue.md).[getEditValue](IGetEditValue.md#geteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L67)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[getElement](DataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1507)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[DataGrid](DataGrid.md).[getFilterStore](DataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1519)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[getGrid](DataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1511)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[getGridCanLoad](DataGrid.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:986](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L986)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](DataGrid.md).[getGridField](DataGrid.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getIdProperty](DataGrid.md#getidproperty)

#### Defined in

[src/ui/editors/checktreeeditor.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L38)

___

### getIncludeColumns

▸ `Protected` **getIncludeColumns**(`include`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `include` | `Object` |

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[getIncludeColumns](DataGrid.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L697)

___

### getInitialCollapse

▸ `Protected` **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L150)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getInitialTitle](DataGrid.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L231)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getIsActiveProperty](DataGrid.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1102)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getIsDeletedProperty](DataGrid.md#getisdeletedproperty)

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

#### Inherited from

[DataGrid](DataGrid.md).[getItemCssClass](DataGrid.md#getitemcssclass)

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

#### Inherited from

[DataGrid](DataGrid.md).[getItemMetadata](DataGrid.md#getitemmetadata)

#### Defined in

[src/ui/datagrid/datagrid.ts:434](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L434)

___

### getItemText

▸ `Protected` **getItemText**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`<`any`\> |

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L349)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getItemType](DataGrid.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[DataGrid](DataGrid.md).[getItems](DataGrid.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L561)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getLocalTextDbPrefix](DataGrid.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1056](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1056)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getLocalTextPrefix](DataGrid.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1068](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1068)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[DataGrid](DataGrid.md).[getPagerOptions](DataGrid.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getPersistanceKey](DataGrid.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1189)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[DataGrid](DataGrid.md).[getPersistanceStorage](DataGrid.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1185)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[getPersistedSettings](DataGrid.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1225)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[DataGrid](DataGrid.md).[getPropertyItems](DataGrid.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L899)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[DataGrid](DataGrid.md).[getPropertyItemsData](DataGrid.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:903](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L903)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[getPropertyItemsDataAsync](DataGrid.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:923](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L923)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[getQuickFilters](DataGrid.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L268)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[DataGrid](DataGrid.md).[getQuickSearchFields](DataGrid.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L357)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[DataGrid](DataGrid.md).[getRowDefinition](DataGrid.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:1050](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1050)

___

### getSelectAllText

▸ `Protected` **getSelectAllText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L108)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Overrides

[DataGrid](DataGrid.md).[getSlickOptions](DataGrid.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L353)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getTitle](DataGrid.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getTreeItems

▸ `Protected` **getTreeItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L42)

___

### getView

▸ **getView**(): [`RemoteView`](RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[getView](DataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1515)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Inherited from

[DataGrid](DataGrid.md).[getViewOptions](DataGrid.md#getviewoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:817](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L817)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Overrides

[DataGrid](DataGrid.md).[get_readOnly](DataGrid.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L393)

___

### get\_value

▸ `Private` **get_value**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L404)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Inherited from

[DataGrid](DataGrid.md).[gridPersistanceFlags](DataGrid.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1200)

___

### init

▸ **init**(`action?`): [`CheckTreeEditor`](CheckTreeEditor.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`CheckTreeEditor`](CheckTreeEditor.md)<`TItem`, `TOptions`\>

#### Inherited from

[DataGrid](DataGrid.md).[init](DataGrid.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Inherited from

[DataGrid](DataGrid.md).[initAsync](DataGrid.md#initasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L188)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[initSync](DataGrid.md#initsync)

#### Defined in

[src/ui/datagrid/datagrid.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L182)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[initialPopulate](DataGrid.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L471)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[initialize](DataGrid.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[initializeFilterBar](DataGrid.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L493)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[internalInit](DataGrid.md#internalinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[internalRefresh](DataGrid.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:1010](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1010)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[invokeSubmitHandlers](DataGrid.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1173)

___

### isThreeStateHierarchy

▸ `Protected` **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L112)

___

### itemAt

▸ **itemAt**(`row`): `TItem`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`TItem`

#### Inherited from

[DataGrid](DataGrid.md).[itemAt](DataGrid.md#itemat)

#### Defined in

[src/ui/datagrid/datagrid.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L553)

___

### itemLink

▸ `Protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../README.md#format)<`TItem`\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../README.md#format)<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[itemLink](DataGrid.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L876)

___

### itemSelectedChanged

▸ `Protected` **itemSelectedChanged**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L105)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[layout](DataGrid.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L209)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[markupReady](DataGrid.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:748](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L748)

___

### moveSelectedUp

▸ `Protected` **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:387](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L387)

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

#### Overrides

[DataGrid](DataGrid.md).[onClick](DataGrid.md#onclick)

#### Defined in

[src/ui/editors/checktreeeditor.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L165)

___

### onViewFilter

▸ `Protected` **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Overrides

[DataGrid](DataGrid.md).[onViewFilter](DataGrid.md#onviewfilter)

#### Defined in

[src/ui/editors/checktreeeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L124)

___

### onViewProcessData

▸ `Protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/ListResponse.md)<`TItem`\> |

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)<`TItem`\>

#### Overrides

[DataGrid](DataGrid.md).[onViewProcessData](DataGrid.md#onviewprocessdata)

#### Defined in

[src/ui/editors/checktreeeditor.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L154)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[onViewSubmit](DataGrid.md#onviewsubmit)

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

#### Inherited from

[DataGrid](DataGrid.md).[persistSettings](DataGrid.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1407](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1407)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[populateLock](DataGrid.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:978](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L978)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[populateUnlock](DataGrid.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L982)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[populateWhenVisible](DataGrid.md#populatewhenvisible)

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

#### Inherited from

[DataGrid](DataGrid.md).[postProcessColumns](DataGrid.md#postprocesscolumns)

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

#### Inherited from

[DataGrid](DataGrid.md).[propertyItemsToSlickColumns](DataGrid.md#propertyitemstoslickcolumns)

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

#### Inherited from

[DataGrid](DataGrid.md).[quickFilterChange](DataGrid.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1179)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[refresh](DataGrid.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L990)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[refreshIfNeeded](DataGrid.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.ts:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1003)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[renderContents](DataGrid.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[resizeCanvas](DataGrid.md#resizecanvas)

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

#### Inherited from

[DataGrid](DataGrid.md).[restoreSettings](DataGrid.md#restoresettings)

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

#### Inherited from

[DataGrid](DataGrid.md).[restoreSettingsFrom](DataGrid.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.ts:1255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1255)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](DataGrid.md).[rowCount](DataGrid.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L557)

___

### setAllSubTreeSelected

▸ `Protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `selected` | `boolean` |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L255)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setCriteriaParameter](DataGrid.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:712](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L712)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`void`

#### Implementation of

[ISetEditValue](ISetEditValue.md).[setEditValue](ISetEditValue.md#seteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L74)

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

#### Inherited from

[DataGrid](DataGrid.md).[setEquality](DataGrid.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L722)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setIncludeColumnsParameter](DataGrid.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L726)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setInitialSortOrder](DataGrid.md#setinitialsortorder)

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

#### Inherited from

[DataGrid](DataGrid.md).[setIsDisabled](DataGrid.md#setisdisabled)

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

#### Inherited from

[DataGrid](DataGrid.md).[setItems](DataGrid.md#setitems)

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

#### Inherited from

[DataGrid](DataGrid.md).[setTitle](DataGrid.md#settitle)

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

#### Overrides

[DataGrid](DataGrid.md).[set_readOnly](DataGrid.md#set_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L397)

___

### set\_value

▸ `Private` **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` \| `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L419)

___

### sortItems

▸ `Protected` **sortItems**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L359)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[subDialogDataChange](DataGrid.md#subdialogdatachange)

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

#### Inherited from

[DataGrid](DataGrid.md).[tryFindQuickFilter](DataGrid.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L339)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[updateDisabledState](DataGrid.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1117)

___

### updateFlags

▸ `Protected` **updateFlags**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L214)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[updateInterface](DataGrid.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1046)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L46)

___

### updateSelectAll

▸ `Protected` **updateSelectAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L208)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[useAsync](DataGrid.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L197)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[useLayoutTimer](DataGrid.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L201)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[usePager](DataGrid.md#usepager)

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

#### Inherited from

[DataGrid](DataGrid.md).[viewDataChanged](DataGrid.md#viewdatachanged)

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

[DataGrid](DataGrid.md).[create](DataGrid.md#create)

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

[DataGrid](DataGrid.md).[elementFor](DataGrid.md#elementfor)

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

[DataGrid](DataGrid.md).[getWidgetName](DataGrid.md#getwidgetname)

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

#### Inherited from

[DataGrid](DataGrid.md).[propertyItemToQuickFilter](DataGrid.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L278)
