[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / EntityGrid

# Class: EntityGrid<TItem, TOptions\>

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`DataGrid`](DataGrid.md)<`TItem`, `TOptions`\>

  ↳ **`EntityGrid`**

## Table of contents

### Constructors

- [constructor](EntityGrid.md#constructor)

### Properties

- [\_dialogType](EntityGrid.md#_dialogtype)
- [\_displayName](EntityGrid.md#_displayname)
- [\_entityType](EntityGrid.md#_entitytype)
- [\_itemName](EntityGrid.md#_itemname)
- [\_service](EntityGrid.md#_service)
- [allColumns](EntityGrid.md#allcolumns)
- [element](EntityGrid.md#element)
- [filterBar](EntityGrid.md#filterbar)
- [idPrefix](EntityGrid.md#idprefix)
- [initialSettings](EntityGrid.md#initialsettings)
- [openDialogsAsPanel](EntityGrid.md#opendialogsaspanel)
- [options](EntityGrid.md#options)
- [propertyItemsData](EntityGrid.md#propertyitemsdata)
- [quickFiltersBar](EntityGrid.md#quickfiltersbar)
- [quickFiltersDiv](EntityGrid.md#quickfiltersdiv)
- [restoringSettings](EntityGrid.md#restoringsettings)
- [slickContainer](EntityGrid.md#slickcontainer)
- [slickGrid](EntityGrid.md#slickgrid)
- [titleDiv](EntityGrid.md#titlediv)
- [toolbar](EntityGrid.md#toolbar)
- [uniqueName](EntityGrid.md#uniquename)
- [view](EntityGrid.md#view)
- [widgetName](EntityGrid.md#widgetname)
- [defaultColumnWidthDelta](EntityGrid.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](EntityGrid.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](EntityGrid.md#defaultheaderheight)
- [defaultPersistanceStorage](EntityGrid.md#defaultpersistancestorage)
- [defaultRowHeight](EntityGrid.md#defaultrowheight)

### Accessors

- [readOnly](EntityGrid.md#readonly)

### Methods

- [addBooleanFilter](EntityGrid.md#addbooleanfilter)
- [addButtonClick](EntityGrid.md#addbuttonclick)
- [addCssClass](EntityGrid.md#addcssclass)
- [addDateRangeFilter](EntityGrid.md#adddaterangefilter)
- [addDateTimeRangeFilter](EntityGrid.md#adddatetimerangefilter)
- [addFilterSeparator](EntityGrid.md#addfilterseparator)
- [addQuickFilter](EntityGrid.md#addquickfilter)
- [addValidationRule](EntityGrid.md#addvalidationrule)
- [afterInit](EntityGrid.md#afterinit)
- [attrs](EntityGrid.md#attrs)
- [bindToSlickEvents](EntityGrid.md#bindtoslickevents)
- [bindToViewEvents](EntityGrid.md#bindtoviewevents)
- [booleanQuickFilter](EntityGrid.md#booleanquickfilter)
- [canFilterColumn](EntityGrid.md#canfiltercolumn)
- [canShowColumn](EntityGrid.md#canshowcolumn)
- [change](EntityGrid.md#change)
- [changeSelect2](EntityGrid.md#changeselect2)
- [createEntityDialog](EntityGrid.md#createentitydialog)
- [createFilterBar](EntityGrid.md#createfilterbar)
- [createIncludeDeletedButton](EntityGrid.md#createincludedeletedbutton)
- [createPager](EntityGrid.md#createpager)
- [createQuickFilters](EntityGrid.md#createquickfilters)
- [createQuickSearchInput](EntityGrid.md#createquicksearchinput)
- [createSlickContainer](EntityGrid.md#createslickcontainer)
- [createSlickGrid](EntityGrid.md#createslickgrid)
- [createToolbar](EntityGrid.md#createtoolbar)
- [createToolbarExtensions](EntityGrid.md#createtoolbarextensions)
- [createView](EntityGrid.md#createview)
- [dateRangeQuickFilter](EntityGrid.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](EntityGrid.md#datetimerangequickfilter)
- [destroy](EntityGrid.md#destroy)
- [determineText](EntityGrid.md#determinetext)
- [editItem](EntityGrid.md#edititem)
- [editItemOfType](EntityGrid.md#edititemoftype)
- [enableFiltering](EntityGrid.md#enablefiltering)
- [ensureQuickFilterBar](EntityGrid.md#ensurequickfilterbar)
- [findQuickFilter](EntityGrid.md#findquickfilter)
- [getAddButtonCaption](EntityGrid.md#getaddbuttoncaption)
- [getButtons](EntityGrid.md#getbuttons)
- [getColumnWidthDelta](EntityGrid.md#getcolumnwidthdelta)
- [getColumnWidthScale](EntityGrid.md#getcolumnwidthscale)
- [getColumns](EntityGrid.md#getcolumns)
- [getColumnsKey](EntityGrid.md#getcolumnskey)
- [getCssClass](EntityGrid.md#getcssclass)
- [getCurrentSettings](EntityGrid.md#getcurrentsettings)
- [getDefaultSortBy](EntityGrid.md#getdefaultsortby)
- [getDialogOptions](EntityGrid.md#getdialogoptions)
- [getDialogOptionsFor](EntityGrid.md#getdialogoptionsfor)
- [getDialogType](EntityGrid.md#getdialogtype)
- [getDialogTypeFor](EntityGrid.md#getdialogtypefor)
- [getDisplayName](EntityGrid.md#getdisplayname)
- [getElement](EntityGrid.md#getelement)
- [getEntityType](EntityGrid.md#getentitytype)
- [getFilterStore](EntityGrid.md#getfilterstore)
- [getGrid](EntityGrid.md#getgrid)
- [getGridCanLoad](EntityGrid.md#getgridcanload)
- [getGridField](EntityGrid.md#getgridfield)
- [getIdProperty](EntityGrid.md#getidproperty)
- [getIncludeColumns](EntityGrid.md#getincludecolumns)
- [getInitialTitle](EntityGrid.md#getinitialtitle)
- [getInsertPermission](EntityGrid.md#getinsertpermission)
- [getIsActiveProperty](EntityGrid.md#getisactiveproperty)
- [getIsDeletedProperty](EntityGrid.md#getisdeletedproperty)
- [getItemCssClass](EntityGrid.md#getitemcssclass)
- [getItemMetadata](EntityGrid.md#getitemmetadata)
- [getItemName](EntityGrid.md#getitemname)
- [getItemType](EntityGrid.md#getitemtype)
- [getItems](EntityGrid.md#getitems)
- [getLocalTextDbPrefix](EntityGrid.md#getlocaltextdbprefix)
- [getLocalTextPrefix](EntityGrid.md#getlocaltextprefix)
- [getPagerOptions](EntityGrid.md#getpageroptions)
- [getPersistanceKey](EntityGrid.md#getpersistancekey)
- [getPersistanceStorage](EntityGrid.md#getpersistancestorage)
- [getPersistedSettings](EntityGrid.md#getpersistedsettings)
- [getPropertyItems](EntityGrid.md#getpropertyitems)
- [getPropertyItemsData](EntityGrid.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](EntityGrid.md#getpropertyitemsdataasync)
- [getQuickFilters](EntityGrid.md#getquickfilters)
- [getQuickSearchFields](EntityGrid.md#getquicksearchfields)
- [getRowDefinition](EntityGrid.md#getrowdefinition)
- [getService](EntityGrid.md#getservice)
- [getSlickOptions](EntityGrid.md#getslickoptions)
- [getTitle](EntityGrid.md#gettitle)
- [getView](EntityGrid.md#getview)
- [getViewOptions](EntityGrid.md#getviewoptions)
- [get\_readOnly](EntityGrid.md#get_readonly)
- [gridPersistanceFlags](EntityGrid.md#gridpersistanceflags)
- [handleRoute](EntityGrid.md#handleroute)
- [hasInsertPermission](EntityGrid.md#hasinsertpermission)
- [init](EntityGrid.md#init)
- [initAsync](EntityGrid.md#initasync)
- [initDialog](EntityGrid.md#initdialog)
- [initEntityDialog](EntityGrid.md#initentitydialog)
- [initSync](EntityGrid.md#initsync)
- [initialPopulate](EntityGrid.md#initialpopulate)
- [initialize](EntityGrid.md#initialize)
- [initializeFilterBar](EntityGrid.md#initializefilterbar)
- [internalInit](EntityGrid.md#internalinit)
- [internalRefresh](EntityGrid.md#internalrefresh)
- [invokeSubmitHandlers](EntityGrid.md#invokesubmithandlers)
- [itemAt](EntityGrid.md#itemat)
- [itemLink](EntityGrid.md#itemlink)
- [layout](EntityGrid.md#layout)
- [markupReady](EntityGrid.md#markupready)
- [newRefreshButton](EntityGrid.md#newrefreshbutton)
- [onClick](EntityGrid.md#onclick)
- [onViewFilter](EntityGrid.md#onviewfilter)
- [onViewProcessData](EntityGrid.md#onviewprocessdata)
- [onViewSubmit](EntityGrid.md#onviewsubmit)
- [persistSettings](EntityGrid.md#persistsettings)
- [populateLock](EntityGrid.md#populatelock)
- [populateUnlock](EntityGrid.md#populateunlock)
- [populateWhenVisible](EntityGrid.md#populatewhenvisible)
- [postProcessColumns](EntityGrid.md#postprocesscolumns)
- [propertyItemsToSlickColumns](EntityGrid.md#propertyitemstoslickcolumns)
- [quickFilterChange](EntityGrid.md#quickfilterchange)
- [refresh](EntityGrid.md#refresh)
- [refreshIfNeeded](EntityGrid.md#refreshifneeded)
- [renderContents](EntityGrid.md#rendercontents)
- [resizeCanvas](EntityGrid.md#resizecanvas)
- [restoreSettings](EntityGrid.md#restoresettings)
- [restoreSettingsFrom](EntityGrid.md#restoresettingsfrom)
- [routeDialog](EntityGrid.md#routedialog)
- [rowCount](EntityGrid.md#rowcount)
- [setCriteriaParameter](EntityGrid.md#setcriteriaparameter)
- [setEquality](EntityGrid.md#setequality)
- [setIncludeColumnsParameter](EntityGrid.md#setincludecolumnsparameter)
- [setInitialSortOrder](EntityGrid.md#setinitialsortorder)
- [setIsDisabled](EntityGrid.md#setisdisabled)
- [setItems](EntityGrid.md#setitems)
- [setTitle](EntityGrid.md#settitle)
- [set\_readOnly](EntityGrid.md#set_readonly)
- [subDialogDataChange](EntityGrid.md#subdialogdatachange)
- [transferDialogReadOnly](EntityGrid.md#transferdialogreadonly)
- [tryFindQuickFilter](EntityGrid.md#tryfindquickfilter)
- [updateDisabledState](EntityGrid.md#updatedisabledstate)
- [updateInterface](EntityGrid.md#updateinterface)
- [useAsync](EntityGrid.md#useasync)
- [useLayoutTimer](EntityGrid.md#uselayouttimer)
- [usePager](EntityGrid.md#usepager)
- [viewDataChanged](EntityGrid.md#viewdatachanged)
- [create](EntityGrid.md#create)
- [elementFor](EntityGrid.md#elementfor)
- [getWidgetName](EntityGrid.md#getwidgetname)
- [propertyItemToQuickFilter](EntityGrid.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new EntityGrid**<`TItem`, `TOptions`\>(`container`, `options?`)

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

[DataGrid](DataGrid.md).[constructor](DataGrid.md#constructor)

#### Defined in

[src/ui/datagrid/entitygrid.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L17)

## Properties

### \_dialogType

• `Private` **\_dialogType**: [`WidgetDialogClass`](../interfaces/WidgetDialogClass.md)<`object`\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L345)

___

### \_displayName

• `Private` **\_displayName**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L113)

___

### \_entityType

• `Private` **\_entityType**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L82)

___

### \_itemName

• `Private` **\_itemName**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L133)

___

### \_service

• `Private` **\_service**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L233)

___

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[allColumns](DataGrid.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L103)

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

### addButtonClick

▸ `Protected` **addButtonClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L191)

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

### createEntityDialog

▸ `Protected` **createEntityDialog**(`itemType`, `callback?`): [`Widget`](Widget.md)<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `callback?` | (`dlg`: [`Widget`](Widget.md)<`any`\>) => `void` |

#### Returns

[`Widget`](Widget.md)<`any`\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L311)

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

#### Inherited from

[DataGrid](DataGrid.md).[createSlickGrid](DataGrid.md#createslickgrid)

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

#### Inherited from

[DataGrid](DataGrid.md).[createToolbar](DataGrid.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L839)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[DataGrid](DataGrid.md).[createToolbarExtensions](DataGrid.md#createtoolbarextensions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L63)

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

#### Overrides

[DataGrid](DataGrid.md).[editItem](DataGrid.md#edititem)

#### Defined in

[src/ui/datagrid/entitygrid.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L195)

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

#### Overrides

[DataGrid](DataGrid.md).[editItemOfType](DataGrid.md#edititemoftype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L212)

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

#### Overrides

[DataGrid](DataGrid.md).[getAddButtonCaption](DataGrid.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/entitygrid.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L153)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[DataGrid](DataGrid.md).[getButtons](DataGrid.md#getbuttons)

#### Defined in

[src/ui/datagrid/entitygrid.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L157)

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

▸ `Protected` **getColumns**(): `Column`<`TItem`\>[]

#### Returns

`Column`<`TItem`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[getColumns](DataGrid.md#getcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L932)

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

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L325)

___

### getDialogOptionsFor

▸ `Protected` **getDialogOptionsFor**(`itemType`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L329)

___

### getDialogType

▸ `Protected` **getDialogType**(): (...`args`: `any`[]) => [`Widget`](Widget.md)<`any`\>

#### Returns

`fn`

• **new getDialogType**(`...args`)

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

#### Defined in

[src/ui/datagrid/entitygrid.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L347)

___

### getDialogTypeFor

▸ `Protected` **getDialogTypeFor**(`itemType`): (...`args`: `any`[]) => [`Widget`](Widget.md)<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |

#### Returns

`fn`

• **new getDialogTypeFor**(`...args`)

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

#### Defined in

[src/ui/datagrid/entitygrid.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L336)

___

### getDisplayName

▸ `Protected` **getDisplayName**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L115)

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

### getEntityType

▸ `Protected` **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L84)

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

#### Inherited from

[DataGrid](DataGrid.md).[getIdProperty](DataGrid.md#getidproperty)

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

#### Inherited from

[DataGrid](DataGrid.md).[getIncludeColumns](DataGrid.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L697)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getInitialTitle](DataGrid.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/entitygrid.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L68)

___

### getInsertPermission

▸ `Protected` **getInsertPermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L274)

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

### getItemName

▸ `Protected` **getItemName**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L135)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getItemType](DataGrid.md#getitemtype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L254)

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

#### Overrides

[DataGrid](DataGrid.md).[getLocalTextPrefix](DataGrid.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/entitygrid.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L72)

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

### getService

▸ `Protected` **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L235)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[getSlickOptions](DataGrid.md#getslickoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:966](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L966)

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

#### Overrides

[DataGrid](DataGrid.md).[getViewOptions](DataGrid.md#getviewoptions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L248)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[get_readOnly](DataGrid.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1035](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1035)

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

### handleRoute

▸ `Protected` **handleRoute**(`args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`HandleRouteEventArgs`](../interfaces/HandleRouteEventArgs.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L24)

___

### hasInsertPermission

▸ `Protected` **hasInsertPermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/entitygrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L278)

___

### init

▸ **init**(`action?`): [`EntityGrid`](EntityGrid.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`EntityGrid`](EntityGrid.md)<`TItem`, `TOptions`\>

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

### initDialog

▸ `Protected` **initDialog**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](Widget.md)<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L288)

___

### initEntityDialog

▸ `Protected` **initEntityDialog**(`itemType`, `dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `dialog` | [`Widget`](Widget.md)<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L297)

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

#### Inherited from

[DataGrid](DataGrid.md).[itemLink](DataGrid.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L876)

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

### newRefreshButton

▸ `Protected` **newRefreshButton**(`noText?`): [`ToolButton`](../interfaces/ToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `noText?` | `boolean` |

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

#### Defined in

[src/ui/datagrid/entitygrid.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L178)

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

#### Inherited from

[DataGrid](DataGrid.md).[onClick](DataGrid.md#onclick)

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

#### Inherited from

[DataGrid](DataGrid.md).[onViewFilter](DataGrid.md#onviewfilter)

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

#### Inherited from

[DataGrid](DataGrid.md).[onViewProcessData](DataGrid.md#onviewprocessdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:689](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L689)

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

### routeDialog

▸ `Protected` **routeDialog**(`itemType`, `dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `dialog` | [`Widget`](Widget.md)<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L258)

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

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setCriteriaParameter](DataGrid.md#setcriteriaparameter)

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

#### Inherited from

[DataGrid](DataGrid.md).[set_readOnly](DataGrid.md#set_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1039](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1039)

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

### transferDialogReadOnly

▸ `Protected` **transferDialogReadOnly**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](Widget.md)<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L283)

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

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[updateInterface](DataGrid.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1046)

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

#### Overrides

[DataGrid](DataGrid.md).[usePager](DataGrid.md#usepager)

#### Defined in

[src/ui/datagrid/entitygrid.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L59)

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
