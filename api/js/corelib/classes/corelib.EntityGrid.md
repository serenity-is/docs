[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / EntityGrid

# Class: EntityGrid<TItem, TOptions\>

[corelib](../modules/corelib.md).EntityGrid

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`DataGrid`](corelib.DataGrid.md)<`TItem`, `TOptions`\>

  ↳ **`EntityGrid`**

## Table of contents

### Constructors

- [constructor](corelib.EntityGrid.md#constructor)

### Properties

- [\_dialogType](corelib.EntityGrid.md#_dialogtype)
- [\_displayName](corelib.EntityGrid.md#_displayname)
- [\_entityType](corelib.EntityGrid.md#_entitytype)
- [\_itemName](corelib.EntityGrid.md#_itemname)
- [\_service](corelib.EntityGrid.md#_service)
- [allColumns](corelib.EntityGrid.md#allcolumns)
- [element](corelib.EntityGrid.md#element)
- [filterBar](corelib.EntityGrid.md#filterbar)
- [idPrefix](corelib.EntityGrid.md#idprefix)
- [initialSettings](corelib.EntityGrid.md#initialsettings)
- [openDialogsAsPanel](corelib.EntityGrid.md#opendialogsaspanel)
- [options](corelib.EntityGrid.md#options)
- [propertyItemsData](corelib.EntityGrid.md#propertyitemsdata)
- [quickFiltersBar](corelib.EntityGrid.md#quickfiltersbar)
- [quickFiltersDiv](corelib.EntityGrid.md#quickfiltersdiv)
- [restoringSettings](corelib.EntityGrid.md#restoringsettings)
- [slickContainer](corelib.EntityGrid.md#slickcontainer)
- [slickGrid](corelib.EntityGrid.md#slickgrid)
- [titleDiv](corelib.EntityGrid.md#titlediv)
- [toolbar](corelib.EntityGrid.md#toolbar)
- [uniqueName](corelib.EntityGrid.md#uniquename)
- [view](corelib.EntityGrid.md#view)
- [widgetName](corelib.EntityGrid.md#widgetname)
- [defaultColumnWidthDelta](corelib.EntityGrid.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](corelib.EntityGrid.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](corelib.EntityGrid.md#defaultheaderheight)
- [defaultPersistanceStorage](corelib.EntityGrid.md#defaultpersistancestorage)
- [defaultRowHeight](corelib.EntityGrid.md#defaultrowheight)

### Accessors

- [readOnly](corelib.EntityGrid.md#readonly)

### Methods

- [addBooleanFilter](corelib.EntityGrid.md#addbooleanfilter)
- [addButtonClick](corelib.EntityGrid.md#addbuttonclick)
- [addCssClass](corelib.EntityGrid.md#addcssclass)
- [addDateRangeFilter](corelib.EntityGrid.md#adddaterangefilter)
- [addDateTimeRangeFilter](corelib.EntityGrid.md#adddatetimerangefilter)
- [addFilterSeparator](corelib.EntityGrid.md#addfilterseparator)
- [addQuickFilter](corelib.EntityGrid.md#addquickfilter)
- [addValidationRule](corelib.EntityGrid.md#addvalidationrule)
- [afterInit](corelib.EntityGrid.md#afterinit)
- [attrs](corelib.EntityGrid.md#attrs)
- [bindToSlickEvents](corelib.EntityGrid.md#bindtoslickevents)
- [bindToViewEvents](corelib.EntityGrid.md#bindtoviewevents)
- [booleanQuickFilter](corelib.EntityGrid.md#booleanquickfilter)
- [canFilterColumn](corelib.EntityGrid.md#canfiltercolumn)
- [canShowColumn](corelib.EntityGrid.md#canshowcolumn)
- [change](corelib.EntityGrid.md#change)
- [changeSelect2](corelib.EntityGrid.md#changeselect2)
- [createEntityDialog](corelib.EntityGrid.md#createentitydialog)
- [createFilterBar](corelib.EntityGrid.md#createfilterbar)
- [createIncludeDeletedButton](corelib.EntityGrid.md#createincludedeletedbutton)
- [createPager](corelib.EntityGrid.md#createpager)
- [createQuickFilters](corelib.EntityGrid.md#createquickfilters)
- [createQuickSearchInput](corelib.EntityGrid.md#createquicksearchinput)
- [createSlickContainer](corelib.EntityGrid.md#createslickcontainer)
- [createSlickGrid](corelib.EntityGrid.md#createslickgrid)
- [createToolbar](corelib.EntityGrid.md#createtoolbar)
- [createToolbarExtensions](corelib.EntityGrid.md#createtoolbarextensions)
- [createView](corelib.EntityGrid.md#createview)
- [dateRangeQuickFilter](corelib.EntityGrid.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](corelib.EntityGrid.md#datetimerangequickfilter)
- [destroy](corelib.EntityGrid.md#destroy)
- [determineText](corelib.EntityGrid.md#determinetext)
- [editItem](corelib.EntityGrid.md#edititem)
- [editItemOfType](corelib.EntityGrid.md#edititemoftype)
- [enableFiltering](corelib.EntityGrid.md#enablefiltering)
- [ensureQuickFilterBar](corelib.EntityGrid.md#ensurequickfilterbar)
- [findQuickFilter](corelib.EntityGrid.md#findquickfilter)
- [getAddButtonCaption](corelib.EntityGrid.md#getaddbuttoncaption)
- [getButtons](corelib.EntityGrid.md#getbuttons)
- [getColumnWidthDelta](corelib.EntityGrid.md#getcolumnwidthdelta)
- [getColumnWidthScale](corelib.EntityGrid.md#getcolumnwidthscale)
- [getColumns](corelib.EntityGrid.md#getcolumns)
- [getColumnsKey](corelib.EntityGrid.md#getcolumnskey)
- [getCssClass](corelib.EntityGrid.md#getcssclass)
- [getCurrentSettings](corelib.EntityGrid.md#getcurrentsettings)
- [getDefaultSortBy](corelib.EntityGrid.md#getdefaultsortby)
- [getDialogOptions](corelib.EntityGrid.md#getdialogoptions)
- [getDialogOptionsFor](corelib.EntityGrid.md#getdialogoptionsfor)
- [getDialogType](corelib.EntityGrid.md#getdialogtype)
- [getDialogTypeFor](corelib.EntityGrid.md#getdialogtypefor)
- [getDisplayName](corelib.EntityGrid.md#getdisplayname)
- [getElement](corelib.EntityGrid.md#getelement)
- [getEntityType](corelib.EntityGrid.md#getentitytype)
- [getFilterStore](corelib.EntityGrid.md#getfilterstore)
- [getGrid](corelib.EntityGrid.md#getgrid)
- [getGridCanLoad](corelib.EntityGrid.md#getgridcanload)
- [getGridField](corelib.EntityGrid.md#getgridfield)
- [getIdProperty](corelib.EntityGrid.md#getidproperty)
- [getIncludeColumns](corelib.EntityGrid.md#getincludecolumns)
- [getInitialTitle](corelib.EntityGrid.md#getinitialtitle)
- [getInsertPermission](corelib.EntityGrid.md#getinsertpermission)
- [getIsActiveProperty](corelib.EntityGrid.md#getisactiveproperty)
- [getIsDeletedProperty](corelib.EntityGrid.md#getisdeletedproperty)
- [getItemCssClass](corelib.EntityGrid.md#getitemcssclass)
- [getItemMetadata](corelib.EntityGrid.md#getitemmetadata)
- [getItemName](corelib.EntityGrid.md#getitemname)
- [getItemType](corelib.EntityGrid.md#getitemtype)
- [getItems](corelib.EntityGrid.md#getitems)
- [getLocalTextDbPrefix](corelib.EntityGrid.md#getlocaltextdbprefix)
- [getLocalTextPrefix](corelib.EntityGrid.md#getlocaltextprefix)
- [getPagerOptions](corelib.EntityGrid.md#getpageroptions)
- [getPersistanceKey](corelib.EntityGrid.md#getpersistancekey)
- [getPersistanceStorage](corelib.EntityGrid.md#getpersistancestorage)
- [getPersistedSettings](corelib.EntityGrid.md#getpersistedsettings)
- [getPropertyItems](corelib.EntityGrid.md#getpropertyitems)
- [getPropertyItemsData](corelib.EntityGrid.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](corelib.EntityGrid.md#getpropertyitemsdataasync)
- [getQuickFilters](corelib.EntityGrid.md#getquickfilters)
- [getQuickSearchFields](corelib.EntityGrid.md#getquicksearchfields)
- [getRowDefinition](corelib.EntityGrid.md#getrowdefinition)
- [getService](corelib.EntityGrid.md#getservice)
- [getSlickOptions](corelib.EntityGrid.md#getslickoptions)
- [getTitle](corelib.EntityGrid.md#gettitle)
- [getView](corelib.EntityGrid.md#getview)
- [getViewOptions](corelib.EntityGrid.md#getviewoptions)
- [get\_readOnly](corelib.EntityGrid.md#get_readonly)
- [gridPersistanceFlags](corelib.EntityGrid.md#gridpersistanceflags)
- [handleRoute](corelib.EntityGrid.md#handleroute)
- [hasInsertPermission](corelib.EntityGrid.md#hasinsertpermission)
- [init](corelib.EntityGrid.md#init)
- [initAsync](corelib.EntityGrid.md#initasync)
- [initDialog](corelib.EntityGrid.md#initdialog)
- [initEntityDialog](corelib.EntityGrid.md#initentitydialog)
- [initSync](corelib.EntityGrid.md#initsync)
- [initialPopulate](corelib.EntityGrid.md#initialpopulate)
- [initialize](corelib.EntityGrid.md#initialize)
- [initializeFilterBar](corelib.EntityGrid.md#initializefilterbar)
- [internalInit](corelib.EntityGrid.md#internalinit)
- [internalRefresh](corelib.EntityGrid.md#internalrefresh)
- [invokeSubmitHandlers](corelib.EntityGrid.md#invokesubmithandlers)
- [itemAt](corelib.EntityGrid.md#itemat)
- [itemLink](corelib.EntityGrid.md#itemlink)
- [layout](corelib.EntityGrid.md#layout)
- [markupReady](corelib.EntityGrid.md#markupready)
- [newRefreshButton](corelib.EntityGrid.md#newrefreshbutton)
- [onClick](corelib.EntityGrid.md#onclick)
- [onViewFilter](corelib.EntityGrid.md#onviewfilter)
- [onViewProcessData](corelib.EntityGrid.md#onviewprocessdata)
- [onViewSubmit](corelib.EntityGrid.md#onviewsubmit)
- [persistSettings](corelib.EntityGrid.md#persistsettings)
- [populateLock](corelib.EntityGrid.md#populatelock)
- [populateUnlock](corelib.EntityGrid.md#populateunlock)
- [populateWhenVisible](corelib.EntityGrid.md#populatewhenvisible)
- [postProcessColumns](corelib.EntityGrid.md#postprocesscolumns)
- [propertyItemsToSlickColumns](corelib.EntityGrid.md#propertyitemstoslickcolumns)
- [quickFilterChange](corelib.EntityGrid.md#quickfilterchange)
- [refresh](corelib.EntityGrid.md#refresh)
- [refreshIfNeeded](corelib.EntityGrid.md#refreshifneeded)
- [renderContents](corelib.EntityGrid.md#rendercontents)
- [resizeCanvas](corelib.EntityGrid.md#resizecanvas)
- [restoreSettings](corelib.EntityGrid.md#restoresettings)
- [routeDialog](corelib.EntityGrid.md#routedialog)
- [rowCount](corelib.EntityGrid.md#rowcount)
- [setCriteriaParameter](corelib.EntityGrid.md#setcriteriaparameter)
- [setEquality](corelib.EntityGrid.md#setequality)
- [setIncludeColumnsParameter](corelib.EntityGrid.md#setincludecolumnsparameter)
- [setInitialSortOrder](corelib.EntityGrid.md#setinitialsortorder)
- [setIsDisabled](corelib.EntityGrid.md#setisdisabled)
- [setItems](corelib.EntityGrid.md#setitems)
- [setTitle](corelib.EntityGrid.md#settitle)
- [set\_readOnly](corelib.EntityGrid.md#set_readonly)
- [subDialogDataChange](corelib.EntityGrid.md#subdialogdatachange)
- [transferDialogReadOnly](corelib.EntityGrid.md#transferdialogreadonly)
- [tryFindQuickFilter](corelib.EntityGrid.md#tryfindquickfilter)
- [updateDisabledState](corelib.EntityGrid.md#updatedisabledstate)
- [updateInterface](corelib.EntityGrid.md#updateinterface)
- [useAsync](corelib.EntityGrid.md#useasync)
- [useLayoutTimer](corelib.EntityGrid.md#uselayouttimer)
- [usePager](corelib.EntityGrid.md#usepager)
- [viewDataChanged](corelib.EntityGrid.md#viewdatachanged)
- [create](corelib.EntityGrid.md#create)
- [elementFor](corelib.EntityGrid.md#elementfor)
- [getWidgetName](corelib.EntityGrid.md#getwidgetname)
- [propertyItemToQuickFilter](corelib.EntityGrid.md#propertyitemtoquickfilter)

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

[DataGrid](corelib.DataGrid.md).[constructor](corelib.DataGrid.md#constructor)

#### Defined in

[src/ui/datagrid/entitygrid.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L17)

## Properties

### \_dialogType

• `Private` **\_dialogType**: [`WidgetDialogClass`](../interfaces/corelib.WidgetDialogClass.md)<`object`\>

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

[DataGrid](corelib.DataGrid.md).[allColumns](corelib.DataGrid.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L103)

___

### element

• **element**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[element](corelib.DataGrid.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[filterBar](corelib.DataGrid.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[idPrefix](corelib.DataGrid.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initialSettings](corelib.DataGrid.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[openDialogsAsPanel](corelib.DataGrid.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L109)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[options](corelib.DataGrid.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[propertyItemsData](corelib.DataGrid.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[quickFiltersBar](corelib.DataGrid.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[quickFiltersDiv](corelib.DataGrid.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[restoringSettings](corelib.DataGrid.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L106)

___

### slickContainer

• `Protected` **slickContainer**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[slickContainer](corelib.DataGrid.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[slickGrid](corelib.DataGrid.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[titleDiv](corelib.DataGrid.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[toolbar](corelib.DataGrid.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[uniqueName](corelib.DataGrid.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### view

• **view**: [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[view](corelib.DataGrid.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[widgetName](corelib.DataGrid.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultColumnWidthDelta](corelib.DataGrid.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultColumnWidthScale](corelib.DataGrid.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultHeaderHeight](corelib.DataGrid.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultPersistanceStorage](corelib.DataGrid.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultRowHeight](corelib.DataGrid.md#defaultrowheight)

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

[src/ui/datagrid/datagrid.ts:1036](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1036)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addBooleanFilter](corelib.DataGrid.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1174)

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

[DataGrid](corelib.DataGrid.md).[addCssClass](corelib.DataGrid.md#addcssclass)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addDateRangeFilter](corelib.DataGrid.md#adddaterangefilter)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addDateTimeRangeFilter](corelib.DataGrid.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1166)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addFilterSeparator](corelib.DataGrid.md#addfilterseparator)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addQuickFilter](corelib.DataGrid.md#addquickfilter)

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

[DataGrid](corelib.DataGrid.md).[addValidationRule](corelib.DataGrid.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[afterInit](corelib.DataGrid.md#afterinit)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[attrs](corelib.DataGrid.md#attrs)

#### Defined in

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L202)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[bindToSlickEvents](corelib.DataGrid.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L578)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[bindToViewEvents](corelib.DataGrid.md#bindtoviewevents)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[booleanQuickFilter](corelib.DataGrid.md#booleanquickfilter)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[canFilterColumn](corelib.DataGrid.md#canfiltercolumn)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[canShowColumn](corelib.DataGrid.md#canshowcolumn)

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

[DataGrid](corelib.DataGrid.md).[change](corelib.DataGrid.md#change)

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

[DataGrid](corelib.DataGrid.md).[change](corelib.DataGrid.md#change)

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

[DataGrid](corelib.DataGrid.md).[changeSelect2](corelib.DataGrid.md#changeselect2)

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

[DataGrid](corelib.DataGrid.md).[changeSelect2](corelib.DataGrid.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createEntityDialog

▸ `Protected` **createEntityDialog**(`itemType`, `callback?`): [`Widget`](corelib.Widget.md)<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `callback?` | (`dlg`: [`Widget`](corelib.Widget.md)<`any`\>) => `void` |

#### Returns

[`Widget`](corelib.Widget.md)<`any`\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L311)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createFilterBar](corelib.DataGrid.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:807](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L807)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createIncludeDeletedButton](corelib.DataGrid.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L360)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createPager](corelib.DataGrid.md#createpager)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createQuickFilters](corelib.DataGrid.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L256)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createQuickSearchInput](corelib.DataGrid.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L371)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createSlickContainer](corelib.DataGrid.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L760)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createSlickGrid](corelib.DataGrid.md#createslickgrid)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createToolbar](corelib.DataGrid.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L848)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[DataGrid](corelib.DataGrid.md).[createToolbarExtensions](corelib.DataGrid.md#createtoolbarextensions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L63)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createView](corelib.DataGrid.md#createview)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[dateRangeQuickFilter](corelib.DataGrid.md#daterangequickfilter)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[dateTimeRangeQuickFilter](corelib.DataGrid.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1170)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[destroy](corelib.DataGrid.md#destroy)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[determineText](corelib.DataGrid.md#determinetext)

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

#### Overrides

[DataGrid](corelib.DataGrid.md).[editItem](corelib.DataGrid.md#edititem)

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

[DataGrid](corelib.DataGrid.md).[editItemOfType](corelib.DataGrid.md#edititemoftype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L212)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[enableFiltering](corelib.DataGrid.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L798)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[ensureQuickFilterBar](corelib.DataGrid.md#ensurequickfilterbar)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[findQuickFilter](corelib.DataGrid.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L342)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](corelib.DataGrid.md).[getAddButtonCaption](corelib.DataGrid.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/entitygrid.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L153)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Overrides

[DataGrid](corelib.DataGrid.md).[getButtons](corelib.DataGrid.md#getbuttons)

#### Defined in

[src/ui/datagrid/entitygrid.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L157)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumnWidthDelta](corelib.DataGrid.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L472)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumnWidthScale](corelib.DataGrid.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L476)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumns](corelib.DataGrid.md#getcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:941](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L941)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumnsKey](corelib.DataGrid.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L899)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getCssClass](corelib.DataGrid.md#getcssclass)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getCurrentSettings](corelib.DataGrid.md#getcurrentsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1414)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getDefaultSortBy](corelib.DataGrid.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:769](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L769)

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

▸ `Protected` **getDialogType**(): (...`args`: `any`[]) => [`Widget`](corelib.Widget.md)<`any`\>

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

▸ `Protected` **getDialogTypeFor**(`itemType`): (...`args`: `any`[]) => [`Widget`](corelib.Widget.md)<`any`\>

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

[DataGrid](corelib.DataGrid.md).[getElement](corelib.DataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1504)

___

### getEntityType

▸ `Protected` **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L84)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getFilterStore](corelib.DataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1516)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getGrid](corelib.DataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1508)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getGridCanLoad](corelib.DataGrid.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L995)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getGridField](corelib.DataGrid.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getIdProperty](corelib.DataGrid.md#getidproperty)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getIncludeColumns](corelib.DataGrid.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L706)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](corelib.DataGrid.md).[getInitialTitle](corelib.DataGrid.md#getinitialtitle)

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

[DataGrid](corelib.DataGrid.md).[getIsActiveProperty](corelib.DataGrid.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1111)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getIsDeletedProperty](corelib.DataGrid.md#getisdeletedproperty)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getItemCssClass](corelib.DataGrid.md#getitemcssclass)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getItemMetadata](corelib.DataGrid.md#getitemmetadata)

#### Defined in

[src/ui/datagrid/datagrid.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L443)

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

[DataGrid](corelib.DataGrid.md).[getItemType](corelib.DataGrid.md#getitemtype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L254)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getItems](corelib.DataGrid.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L570)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getLocalTextDbPrefix](corelib.DataGrid.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1065](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1065)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](corelib.DataGrid.md).[getLocalTextPrefix](corelib.DataGrid.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/entitygrid.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L72)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPagerOptions](corelib.DataGrid.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L813)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPersistanceKey](corelib.DataGrid.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1198)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPersistanceStorage](corelib.DataGrid.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1194)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Returns

[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPersistedSettings](corelib.DataGrid.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1234)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPropertyItems](corelib.DataGrid.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L908)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPropertyItemsData](corelib.DataGrid.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:912](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L912)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPropertyItemsDataAsync](corelib.DataGrid.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L932)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getQuickFilters](corelib.DataGrid.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L278)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getQuickSearchFields](corelib.DataGrid.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L367)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getRowDefinition](corelib.DataGrid.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:1059](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1059)

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

[DataGrid](corelib.DataGrid.md).[getSlickOptions](corelib.DataGrid.md#getslickoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:975](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L975)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getTitle](corelib.DataGrid.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L853)

___

### getView

▸ **getView**(): [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getView](corelib.DataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1512)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Overrides

[DataGrid](corelib.DataGrid.md).[getViewOptions](corelib.DataGrid.md#getviewoptions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L248)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[get_readOnly](corelib.DataGrid.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1044](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1044)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[gridPersistanceFlags](corelib.DataGrid.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1209)

___

### handleRoute

▸ `Protected` **handleRoute**(`args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`HandleRouteEventArgs`](../interfaces/corelib_q.HandleRouteEventArgs.md) |

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

▸ **init**(`action?`): [`EntityGrid`](corelib.EntityGrid.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`EntityGrid`](corelib.EntityGrid.md)<`TItem`, `TOptions`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[init](corelib.DataGrid.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initAsync](corelib.DataGrid.md#initasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L185)

___

### initDialog

▸ `Protected` **initDialog**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](corelib.Widget.md)<`any`\> |

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
| `dialog` | [`Widget`](corelib.Widget.md)<`any`\> |

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

[DataGrid](corelib.DataGrid.md).[initSync](corelib.DataGrid.md#initsync)

#### Defined in

[src/ui/datagrid/datagrid.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L179)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initialPopulate](corelib.DataGrid.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L480)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initialize](corelib.DataGrid.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initializeFilterBar](corelib.DataGrid.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L502)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[internalInit](corelib.DataGrid.md#internalinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[internalRefresh](corelib.DataGrid.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1019)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[invokeSubmitHandlers](corelib.DataGrid.md#invokesubmithandlers)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[itemAt](corelib.DataGrid.md#itemat)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[itemLink](corelib.DataGrid.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L885)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[layout](corelib.DataGrid.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L206)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[markupReady](corelib.DataGrid.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L757)

___

### newRefreshButton

▸ `Protected` **newRefreshButton**(`noText?`): [`ToolButton`](../interfaces/corelib.ToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `noText?` | `boolean` |

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)

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

[DataGrid](corelib.DataGrid.md).[onClick](corelib.DataGrid.md#onclick)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[onViewFilter](corelib.DataGrid.md#onviewfilter)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[onViewProcessData](corelib.DataGrid.md#onviewprocessdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L698)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[onViewSubmit](corelib.DataGrid.md#onviewsubmit)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[persistSettings](corelib.DataGrid.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1404)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[populateLock](corelib.DataGrid.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:987](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L987)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[populateUnlock](corelib.DataGrid.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:991](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L991)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[populateWhenVisible](corelib.DataGrid.md#populatewhenvisible)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[postProcessColumns](corelib.DataGrid.md#postprocesscolumns)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[propertyItemsToSlickColumns](corelib.DataGrid.md#propertyitemstoslickcolumns)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[quickFilterChange](corelib.DataGrid.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1188)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[refresh](corelib.DataGrid.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L999)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[refreshIfNeeded](corelib.DataGrid.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.ts:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1012)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[renderContents](corelib.DataGrid.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[resizeCanvas](corelib.DataGrid.md#resizecanvas)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[restoreSettings](corelib.DataGrid.md#restoresettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1246)

___

### routeDialog

▸ `Protected` **routeDialog**(`itemType`, `dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `dialog` | [`Widget`](corelib.Widget.md)<`any`\> |

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

[DataGrid](corelib.DataGrid.md).[rowCount](corelib.DataGrid.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L566)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setCriteriaParameter](corelib.DataGrid.md#setcriteriaparameter)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setEquality](corelib.DataGrid.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L731)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setIncludeColumnsParameter](corelib.DataGrid.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L735)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setInitialSortOrder](corelib.DataGrid.md#setinitialsortorder)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setIsDisabled](corelib.DataGrid.md#setisdisabled)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setItems](corelib.DataGrid.md#setitems)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setTitle](corelib.DataGrid.md#settitle)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[set_readOnly](corelib.DataGrid.md#set_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:1048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1048)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[subDialogDataChange](corelib.DataGrid.md#subdialogdatachange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1134)

___

### transferDialogReadOnly

▸ `Protected` **transferDialogReadOnly**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](corelib.Widget.md)<`any`\> |

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

[DataGrid](corelib.DataGrid.md).[tryFindQuickFilter](corelib.DataGrid.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L349)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[updateDisabledState](corelib.DataGrid.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1126)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[updateInterface](corelib.DataGrid.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1055](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1055)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[useAsync](corelib.DataGrid.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[useLayoutTimer](corelib.DataGrid.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L198)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Overrides

[DataGrid](corelib.DataGrid.md).[usePager](corelib.DataGrid.md#usepager)

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

[DataGrid](corelib.DataGrid.md).[viewDataChanged](corelib.DataGrid.md#viewdatachanged)

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

[DataGrid](corelib.DataGrid.md).[create](corelib.DataGrid.md#create)

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

[DataGrid](corelib.DataGrid.md).[elementFor](corelib.DataGrid.md#elementfor)

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

[DataGrid](corelib.DataGrid.md).[getWidgetName](corelib.DataGrid.md#getwidgetname)

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

#### Inherited from

[DataGrid](corelib.DataGrid.md).[propertyItemToQuickFilter](corelib.DataGrid.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L288)
