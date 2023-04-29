[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / CheckTreeEditor

# Class: CheckTreeEditor<TItem, TOptions\>

[corelib](../modules/corelib.md).CheckTreeEditor

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | extends [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`any`\> |
| `TOptions` | `TOptions` |

## Hierarchy

- [`DataGrid`](corelib.DataGrid.md)<`TItem`, `TOptions`\>

  ↳ **`CheckTreeEditor`**

  ↳↳ [`CheckLookupEditor`](corelib.CheckLookupEditor.md)

## Implements

- [`IGetEditValue`](corelib.IGetEditValue.md)
- [`ISetEditValue`](corelib.ISetEditValue.md)
- [`IReadOnly`](corelib.IReadOnly.md)

## Table of contents

### Constructors

- [constructor](corelib.CheckTreeEditor.md#constructor)

### Properties

- [\_readOnly](corelib.CheckTreeEditor.md#_readonly)
- [allColumns](corelib.CheckTreeEditor.md#allcolumns)
- [byId](corelib.CheckTreeEditor.md#byid)
- [element](corelib.CheckTreeEditor.md#element)
- [filterBar](corelib.CheckTreeEditor.md#filterbar)
- [idPrefix](corelib.CheckTreeEditor.md#idprefix)
- [initialSettings](corelib.CheckTreeEditor.md#initialsettings)
- [openDialogsAsPanel](corelib.CheckTreeEditor.md#opendialogsaspanel)
- [options](corelib.CheckTreeEditor.md#options)
- [propertyItemsData](corelib.CheckTreeEditor.md#propertyitemsdata)
- [quickFiltersBar](corelib.CheckTreeEditor.md#quickfiltersbar)
- [quickFiltersDiv](corelib.CheckTreeEditor.md#quickfiltersdiv)
- [restoringSettings](corelib.CheckTreeEditor.md#restoringsettings)
- [slickContainer](corelib.CheckTreeEditor.md#slickcontainer)
- [slickGrid](corelib.CheckTreeEditor.md#slickgrid)
- [titleDiv](corelib.CheckTreeEditor.md#titlediv)
- [toolbar](corelib.CheckTreeEditor.md#toolbar)
- [uniqueName](corelib.CheckTreeEditor.md#uniquename)
- [view](corelib.CheckTreeEditor.md#view)
- [widgetName](corelib.CheckTreeEditor.md#widgetname)
- [defaultColumnWidthDelta](corelib.CheckTreeEditor.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](corelib.CheckTreeEditor.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](corelib.CheckTreeEditor.md#defaultheaderheight)
- [defaultPersistanceStorage](corelib.CheckTreeEditor.md#defaultpersistancestorage)
- [defaultRowHeight](corelib.CheckTreeEditor.md#defaultrowheight)

### Accessors

- [readOnly](corelib.CheckTreeEditor.md#readonly)
- [value](corelib.CheckTreeEditor.md#value)

### Methods

- [addBooleanFilter](corelib.CheckTreeEditor.md#addbooleanfilter)
- [addCssClass](corelib.CheckTreeEditor.md#addcssclass)
- [addDateRangeFilter](corelib.CheckTreeEditor.md#adddaterangefilter)
- [addDateTimeRangeFilter](corelib.CheckTreeEditor.md#adddatetimerangefilter)
- [addFilterSeparator](corelib.CheckTreeEditor.md#addfilterseparator)
- [addQuickFilter](corelib.CheckTreeEditor.md#addquickfilter)
- [addValidationRule](corelib.CheckTreeEditor.md#addvalidationrule)
- [afterInit](corelib.CheckTreeEditor.md#afterinit)
- [allDescendantsSelected](corelib.CheckTreeEditor.md#alldescendantsselected)
- [allItemsSelected](corelib.CheckTreeEditor.md#allitemsselected)
- [anyDescendantsSelected](corelib.CheckTreeEditor.md#anydescendantsselected)
- [attrs](corelib.CheckTreeEditor.md#attrs)
- [bindToSlickEvents](corelib.CheckTreeEditor.md#bindtoslickevents)
- [bindToViewEvents](corelib.CheckTreeEditor.md#bindtoviewevents)
- [booleanQuickFilter](corelib.CheckTreeEditor.md#booleanquickfilter)
- [canFilterColumn](corelib.CheckTreeEditor.md#canfiltercolumn)
- [canShowColumn](corelib.CheckTreeEditor.md#canshowcolumn)
- [change](corelib.CheckTreeEditor.md#change)
- [changeSelect2](corelib.CheckTreeEditor.md#changeselect2)
- [createFilterBar](corelib.CheckTreeEditor.md#createfilterbar)
- [createIncludeDeletedButton](corelib.CheckTreeEditor.md#createincludedeletedbutton)
- [createPager](corelib.CheckTreeEditor.md#createpager)
- [createQuickFilters](corelib.CheckTreeEditor.md#createquickfilters)
- [createQuickSearchInput](corelib.CheckTreeEditor.md#createquicksearchinput)
- [createSlickContainer](corelib.CheckTreeEditor.md#createslickcontainer)
- [createSlickGrid](corelib.CheckTreeEditor.md#createslickgrid)
- [createToolbar](corelib.CheckTreeEditor.md#createtoolbar)
- [createToolbarExtensions](corelib.CheckTreeEditor.md#createtoolbarextensions)
- [createView](corelib.CheckTreeEditor.md#createview)
- [dateRangeQuickFilter](corelib.CheckTreeEditor.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](corelib.CheckTreeEditor.md#datetimerangequickfilter)
- [destroy](corelib.CheckTreeEditor.md#destroy)
- [determineText](corelib.CheckTreeEditor.md#determinetext)
- [editItem](corelib.CheckTreeEditor.md#edititem)
- [editItemOfType](corelib.CheckTreeEditor.md#edititemoftype)
- [enableFiltering](corelib.CheckTreeEditor.md#enablefiltering)
- [ensureQuickFilterBar](corelib.CheckTreeEditor.md#ensurequickfilterbar)
- [findQuickFilter](corelib.CheckTreeEditor.md#findquickfilter)
- [getAddButtonCaption](corelib.CheckTreeEditor.md#getaddbuttoncaption)
- [getButtons](corelib.CheckTreeEditor.md#getbuttons)
- [getColumnWidthDelta](corelib.CheckTreeEditor.md#getcolumnwidthdelta)
- [getColumnWidthScale](corelib.CheckTreeEditor.md#getcolumnwidthscale)
- [getColumns](corelib.CheckTreeEditor.md#getcolumns)
- [getColumnsKey](corelib.CheckTreeEditor.md#getcolumnskey)
- [getCssClass](corelib.CheckTreeEditor.md#getcssclass)
- [getCurrentSettings](corelib.CheckTreeEditor.md#getcurrentsettings)
- [getDefaultSortBy](corelib.CheckTreeEditor.md#getdefaultsortby)
- [getDelimited](corelib.CheckTreeEditor.md#getdelimited)
- [getDescendantsSelected](corelib.CheckTreeEditor.md#getdescendantsselected)
- [getEditValue](corelib.CheckTreeEditor.md#geteditvalue)
- [getElement](corelib.CheckTreeEditor.md#getelement)
- [getFilterStore](corelib.CheckTreeEditor.md#getfilterstore)
- [getGrid](corelib.CheckTreeEditor.md#getgrid)
- [getGridCanLoad](corelib.CheckTreeEditor.md#getgridcanload)
- [getGridField](corelib.CheckTreeEditor.md#getgridfield)
- [getIdProperty](corelib.CheckTreeEditor.md#getidproperty)
- [getIncludeColumns](corelib.CheckTreeEditor.md#getincludecolumns)
- [getInitialCollapse](corelib.CheckTreeEditor.md#getinitialcollapse)
- [getInitialTitle](corelib.CheckTreeEditor.md#getinitialtitle)
- [getIsActiveProperty](corelib.CheckTreeEditor.md#getisactiveproperty)
- [getIsDeletedProperty](corelib.CheckTreeEditor.md#getisdeletedproperty)
- [getItemCssClass](corelib.CheckTreeEditor.md#getitemcssclass)
- [getItemMetadata](corelib.CheckTreeEditor.md#getitemmetadata)
- [getItemText](corelib.CheckTreeEditor.md#getitemtext)
- [getItemType](corelib.CheckTreeEditor.md#getitemtype)
- [getItems](corelib.CheckTreeEditor.md#getitems)
- [getLocalTextDbPrefix](corelib.CheckTreeEditor.md#getlocaltextdbprefix)
- [getLocalTextPrefix](corelib.CheckTreeEditor.md#getlocaltextprefix)
- [getPagerOptions](corelib.CheckTreeEditor.md#getpageroptions)
- [getPersistanceKey](corelib.CheckTreeEditor.md#getpersistancekey)
- [getPersistanceStorage](corelib.CheckTreeEditor.md#getpersistancestorage)
- [getPersistedSettings](corelib.CheckTreeEditor.md#getpersistedsettings)
- [getPropertyItems](corelib.CheckTreeEditor.md#getpropertyitems)
- [getPropertyItemsData](corelib.CheckTreeEditor.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](corelib.CheckTreeEditor.md#getpropertyitemsdataasync)
- [getQuickFilters](corelib.CheckTreeEditor.md#getquickfilters)
- [getQuickSearchFields](corelib.CheckTreeEditor.md#getquicksearchfields)
- [getRowDefinition](corelib.CheckTreeEditor.md#getrowdefinition)
- [getSelectAllText](corelib.CheckTreeEditor.md#getselectalltext)
- [getSlickOptions](corelib.CheckTreeEditor.md#getslickoptions)
- [getTitle](corelib.CheckTreeEditor.md#gettitle)
- [getTreeItems](corelib.CheckTreeEditor.md#gettreeitems)
- [getView](corelib.CheckTreeEditor.md#getview)
- [getViewOptions](corelib.CheckTreeEditor.md#getviewoptions)
- [get\_readOnly](corelib.CheckTreeEditor.md#get_readonly)
- [get\_value](corelib.CheckTreeEditor.md#get_value)
- [gridPersistanceFlags](corelib.CheckTreeEditor.md#gridpersistanceflags)
- [init](corelib.CheckTreeEditor.md#init)
- [initAsync](corelib.CheckTreeEditor.md#initasync)
- [initSync](corelib.CheckTreeEditor.md#initsync)
- [initialPopulate](corelib.CheckTreeEditor.md#initialpopulate)
- [initialize](corelib.CheckTreeEditor.md#initialize)
- [initializeFilterBar](corelib.CheckTreeEditor.md#initializefilterbar)
- [internalInit](corelib.CheckTreeEditor.md#internalinit)
- [internalRefresh](corelib.CheckTreeEditor.md#internalrefresh)
- [invokeSubmitHandlers](corelib.CheckTreeEditor.md#invokesubmithandlers)
- [isThreeStateHierarchy](corelib.CheckTreeEditor.md#isthreestatehierarchy)
- [itemAt](corelib.CheckTreeEditor.md#itemat)
- [itemLink](corelib.CheckTreeEditor.md#itemlink)
- [itemSelectedChanged](corelib.CheckTreeEditor.md#itemselectedchanged)
- [layout](corelib.CheckTreeEditor.md#layout)
- [markupReady](corelib.CheckTreeEditor.md#markupready)
- [moveSelectedUp](corelib.CheckTreeEditor.md#moveselectedup)
- [onClick](corelib.CheckTreeEditor.md#onclick)
- [onViewFilter](corelib.CheckTreeEditor.md#onviewfilter)
- [onViewProcessData](corelib.CheckTreeEditor.md#onviewprocessdata)
- [onViewSubmit](corelib.CheckTreeEditor.md#onviewsubmit)
- [persistSettings](corelib.CheckTreeEditor.md#persistsettings)
- [populateLock](corelib.CheckTreeEditor.md#populatelock)
- [populateUnlock](corelib.CheckTreeEditor.md#populateunlock)
- [populateWhenVisible](corelib.CheckTreeEditor.md#populatewhenvisible)
- [postProcessColumns](corelib.CheckTreeEditor.md#postprocesscolumns)
- [propertyItemsToSlickColumns](corelib.CheckTreeEditor.md#propertyitemstoslickcolumns)
- [quickFilterChange](corelib.CheckTreeEditor.md#quickfilterchange)
- [refresh](corelib.CheckTreeEditor.md#refresh)
- [refreshIfNeeded](corelib.CheckTreeEditor.md#refreshifneeded)
- [renderContents](corelib.CheckTreeEditor.md#rendercontents)
- [resizeCanvas](corelib.CheckTreeEditor.md#resizecanvas)
- [restoreSettings](corelib.CheckTreeEditor.md#restoresettings)
- [rowCount](corelib.CheckTreeEditor.md#rowcount)
- [setAllSubTreeSelected](corelib.CheckTreeEditor.md#setallsubtreeselected)
- [setCriteriaParameter](corelib.CheckTreeEditor.md#setcriteriaparameter)
- [setEditValue](corelib.CheckTreeEditor.md#seteditvalue)
- [setEquality](corelib.CheckTreeEditor.md#setequality)
- [setIncludeColumnsParameter](corelib.CheckTreeEditor.md#setincludecolumnsparameter)
- [setInitialSortOrder](corelib.CheckTreeEditor.md#setinitialsortorder)
- [setIsDisabled](corelib.CheckTreeEditor.md#setisdisabled)
- [setItems](corelib.CheckTreeEditor.md#setitems)
- [setTitle](corelib.CheckTreeEditor.md#settitle)
- [set\_readOnly](corelib.CheckTreeEditor.md#set_readonly)
- [set\_value](corelib.CheckTreeEditor.md#set_value)
- [sortItems](corelib.CheckTreeEditor.md#sortitems)
- [subDialogDataChange](corelib.CheckTreeEditor.md#subdialogdatachange)
- [tryFindQuickFilter](corelib.CheckTreeEditor.md#tryfindquickfilter)
- [updateDisabledState](corelib.CheckTreeEditor.md#updatedisabledstate)
- [updateFlags](corelib.CheckTreeEditor.md#updateflags)
- [updateInterface](corelib.CheckTreeEditor.md#updateinterface)
- [updateItems](corelib.CheckTreeEditor.md#updateitems)
- [updateSelectAll](corelib.CheckTreeEditor.md#updateselectall)
- [useAsync](corelib.CheckTreeEditor.md#useasync)
- [useLayoutTimer](corelib.CheckTreeEditor.md#uselayouttimer)
- [usePager](corelib.CheckTreeEditor.md#usepager)
- [viewDataChanged](corelib.CheckTreeEditor.md#viewdatachanged)
- [create](corelib.CheckTreeEditor.md#create)
- [elementFor](corelib.CheckTreeEditor.md#elementfor)
- [getWidgetName](corelib.CheckTreeEditor.md#getwidgetname)
- [propertyItemToQuickFilter](corelib.CheckTreeEditor.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new CheckTreeEditor**<`TItem`, `TOptions`\>(`div`, `opt?`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | extends [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`any`, `TItem`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt?` | `TOptions` |

#### Overrides

[DataGrid](corelib.DataGrid.md).[constructor](corelib.DataGrid.md#constructor)

#### Defined in

[src/ui/editors/checktreeeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;31)

## Properties

### \_readOnly

• `Private` **\_readOnly**: `boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:391](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;391)

___

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[allColumns](corelib.DataGrid.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;103)

___

### byId

• `Private` **byId**: `Object`

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[src/ui/editors/checktreeeditor.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;29)

___

### element

• **element**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[element](corelib.DataGrid.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[filterBar](corelib.DataGrid.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[idPrefix](corelib.DataGrid.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initialSettings](corelib.DataGrid.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[openDialogsAsPanel](corelib.DataGrid.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;109)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[options](corelib.DataGrid.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[propertyItemsData](corelib.DataGrid.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[quickFiltersBar](corelib.DataGrid.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[quickFiltersDiv](corelib.DataGrid.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[restoringSettings](corelib.DataGrid.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;106)

___

### slickContainer

• `Protected` **slickContainer**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[slickContainer](corelib.DataGrid.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[slickGrid](corelib.DataGrid.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[titleDiv](corelib.DataGrid.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[toolbar](corelib.DataGrid.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[uniqueName](corelib.DataGrid.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### view

• **view**: [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[view](corelib.DataGrid.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[widgetName](corelib.DataGrid.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultColumnWidthDelta](corelib.DataGrid.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultColumnWidthScale](corelib.DataGrid.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultHeaderHeight](corelib.DataGrid.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultPersistanceStorage](corelib.DataGrid.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[defaultRowHeight](corelib.DataGrid.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;111)

## Accessors

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

DataGrid.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:1036](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1036)

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

[src/ui/datagrid/datagrid.ts:1040](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1040)

___

### value

• `get` **value**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;415)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;454)

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

[src/ui/datagrid/datagrid.ts:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1174)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addCssClass](corelib.DataGrid.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;100)

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

[src/ui/datagrid/datagrid.ts:1158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1158)

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

[src/ui/datagrid/datagrid.ts:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1166)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[addFilterSeparator](corelib.DataGrid.md#addfilterseparator)

#### Defined in

[src/ui/datagrid/datagrid.ts:1138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1138)

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

[src/ui/datagrid/datagrid.ts:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1154)

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

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[afterInit](corelib.DataGrid.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;191)

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

[src/ui/editors/checktreeeditor.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;283)

___

### allItemsSelected

▸ `Protected` **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;272)

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

[src/ui/editors/checktreeeditor.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;303)

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

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;202)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[bindToSlickEvents](corelib.DataGrid.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;578)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[bindToViewEvents](corelib.DataGrid.md#bindtoviewevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;678)

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

[src/ui/datagrid/datagrid.ts:1178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1178)

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

[src/ui/datagrid/datagrid.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;495)

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

[src/ui/datagrid/datagrid.ts:1213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1213)

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

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

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

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;259)

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

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;146)

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

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createFilterBar](corelib.DataGrid.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:807](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;807)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createIncludeDeletedButton](corelib.DataGrid.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;360)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createPager](corelib.DataGrid.md#createpager)

#### Defined in

[src/ui/datagrid/datagrid.ts:821](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;821)

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

[src/ui/datagrid/datagrid.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;256)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createQuickSearchInput](corelib.DataGrid.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;371)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createSlickContainer](corelib.DataGrid.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;760)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Overrides

[DataGrid](corelib.DataGrid.md).[createSlickGrid](corelib.DataGrid.md#createslickgrid)

#### Defined in

[src/ui/editors/checktreeeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;116)

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

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;848)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createToolbarExtensions](corelib.DataGrid.md#createtoolbarextensions)

#### Defined in

[src/ui/datagrid/datagrid.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;245)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[createView](corelib.DataGrid.md#createview)

#### Defined in

[src/ui/datagrid/datagrid.ts:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;764)

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

[src/ui/datagrid/datagrid.ts:1162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1162)

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

[src/ui/datagrid/datagrid.ts:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1170)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[destroy](corelib.DataGrid.md#destroy)

#### Defined in

[src/ui/datagrid/datagrid.ts:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;375)

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

[src/ui/datagrid/datagrid.ts:1142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1142)

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

[DataGrid](corelib.DataGrid.md).[editItem](corelib.DataGrid.md#edititem)

#### Defined in

[src/ui/datagrid/datagrid.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;644)

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

[DataGrid](corelib.DataGrid.md).[editItemOfType](corelib.DataGrid.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;648)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[enableFiltering](corelib.DataGrid.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;798)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[ensureQuickFilterBar](corelib.DataGrid.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;248)

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

[src/ui/datagrid/datagrid.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;342)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getAddButtonCaption](corelib.DataGrid.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;636)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Overrides

[DataGrid](corelib.DataGrid.md).[getButtons](corelib.DataGrid.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;79)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumnWidthDelta](corelib.DataGrid.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;472)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumnWidthScale](corelib.DataGrid.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;476)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Overrides

[DataGrid](corelib.DataGrid.md).[getColumns](corelib.DataGrid.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;318)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getColumnsKey](corelib.DataGrid.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;899)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getCssClass](corelib.DataGrid.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

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

[src/ui/datagrid/datagrid.ts:1414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1414)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getDefaultSortBy](corelib.DataGrid.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:769](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;769)

___

### getDelimited

▸ `Protected` **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;299)

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

[src/ui/editors/checktreeeditor.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;251)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Implementation of

[IGetEditValue](corelib.IGetEditValue.md).[getEditValue](corelib.IGetEditValue.md#geteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;67)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getElement](corelib.DataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1504)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getFilterStore](corelib.DataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1516)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getGrid](corelib.DataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1508)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getGridCanLoad](corelib.DataGrid.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;995)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getGridField](corelib.DataGrid.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](corelib.DataGrid.md).[getIdProperty](corelib.DataGrid.md#getidproperty)

#### Defined in

[src/ui/editors/checktreeeditor.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;38)

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

[src/ui/datagrid/datagrid.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;706)

___

### getInitialCollapse

▸ `Protected` **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;150)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getInitialTitle](corelib.DataGrid.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;241)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getIsActiveProperty](corelib.DataGrid.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1111)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getIsDeletedProperty](corelib.DataGrid.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1105)

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

[src/ui/datagrid/datagrid.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;409)

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

[src/ui/datagrid/datagrid.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;443)

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

[src/ui/editors/checktreeeditor.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;349)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getItemType](corelib.DataGrid.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.ts:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;881)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getItems](corelib.DataGrid.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;570)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getLocalTextDbPrefix](corelib.DataGrid.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1065](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1065)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getLocalTextPrefix](corelib.DataGrid.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1077](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1077)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPagerOptions](corelib.DataGrid.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;813)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPersistanceKey](corelib.DataGrid.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1198)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPersistanceStorage](corelib.DataGrid.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1194)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Returns

[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPersistedSettings](corelib.DataGrid.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1234)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPropertyItems](corelib.DataGrid.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;908)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPropertyItemsData](corelib.DataGrid.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:912](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;912)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getPropertyItemsDataAsync](corelib.DataGrid.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;932)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getQuickFilters](corelib.DataGrid.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;278)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getQuickSearchFields](corelib.DataGrid.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;367)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getRowDefinition](corelib.DataGrid.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:1059](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1059)

___

### getSelectAllText

▸ `Protected` **getSelectAllText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;108)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Overrides

[DataGrid](corelib.DataGrid.md).[getSlickOptions](corelib.DataGrid.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;353)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getTitle](corelib.DataGrid.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;853)

___

### getTreeItems

▸ `Protected` **getTreeItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;42)

___

### getView

▸ **getView**(): [`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<`TItem`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getView](corelib.DataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1512)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[getViewOptions](corelib.DataGrid.md#getviewoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;826)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Overrides

[DataGrid](corelib.DataGrid.md).[get_readOnly](corelib.DataGrid.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;393)

___

### get\_value

▸ `Private` **get_value**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;404)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Inherited from

[DataGrid](corelib.DataGrid.md).[gridPersistanceFlags](corelib.DataGrid.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1209)

___

### init

▸ **init**(`action?`): [`CheckTreeEditor`](corelib.CheckTreeEditor.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`CheckTreeEditor`](corelib.CheckTreeEditor.md)<`TItem`, `TOptions`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[init](corelib.DataGrid.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initAsync](corelib.DataGrid.md#initasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;185)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initSync](corelib.DataGrid.md#initsync)

#### Defined in

[src/ui/datagrid/datagrid.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;179)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initialPopulate](corelib.DataGrid.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;480)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initialize](corelib.DataGrid.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[initializeFilterBar](corelib.DataGrid.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;502)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[internalInit](corelib.DataGrid.md#internalinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[internalRefresh](corelib.DataGrid.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1019)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[invokeSubmitHandlers](corelib.DataGrid.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1182)

___

### isThreeStateHierarchy

▸ `Protected` **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;112)

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

[src/ui/datagrid/datagrid.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;562)

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

[src/ui/datagrid/datagrid.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;885)

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

[src/ui/editors/checktreeeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;105)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[layout](corelib.DataGrid.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;206)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[markupReady](corelib.DataGrid.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;757)

___

### moveSelectedUp

▸ `Protected` **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:387](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;387)

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

[DataGrid](corelib.DataGrid.md).[onClick](corelib.DataGrid.md#onclick)

#### Defined in

[src/ui/editors/checktreeeditor.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;165)

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

[DataGrid](corelib.DataGrid.md).[onViewFilter](corelib.DataGrid.md#onviewfilter)

#### Defined in

[src/ui/editors/checktreeeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;124)

___

### onViewProcessData

▸ `Protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TItem`\> |

#### Returns

[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TItem`\>

#### Overrides

[DataGrid](corelib.DataGrid.md).[onViewProcessData](corelib.DataGrid.md#onviewprocessdata)

#### Defined in

[src/ui/editors/checktreeeditor.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;154)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[onViewSubmit](corelib.DataGrid.md#onviewsubmit)

#### Defined in

[src/ui/datagrid/datagrid.ts:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;745)

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

[src/ui/datagrid/datagrid.ts:1404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1404)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[populateLock](corelib.DataGrid.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:987](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;987)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[populateUnlock](corelib.DataGrid.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:991](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;991)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[populateWhenVisible](corelib.DataGrid.md#populatewhenvisible)

#### Defined in

[src/ui/datagrid/datagrid.ts:803](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;803)

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

[src/ui/datagrid/datagrid.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;451)

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

[src/ui/datagrid/datagrid.ts:945](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;945)

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

[src/ui/datagrid/datagrid.ts:1188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1188)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[refresh](corelib.DataGrid.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;999)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[refreshIfNeeded](corelib.DataGrid.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.ts:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1012)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[renderContents](corelib.DataGrid.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[resizeCanvas](corelib.DataGrid.md#resizecanvas)

#### Defined in

[src/ui/datagrid/datagrid.ts:1130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1130)

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

[src/ui/datagrid/datagrid.ts:1246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1246)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[rowCount](corelib.DataGrid.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;566)

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

[src/ui/editors/checktreeeditor.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;255)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setCriteriaParameter](corelib.DataGrid.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:721](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;721)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`void`

#### Implementation of

[ISetEditValue](corelib.ISetEditValue.md).[setEditValue](corelib.ISetEditValue.md#seteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;74)

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

[src/ui/datagrid/datagrid.ts:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;731)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setIncludeColumnsParameter](corelib.DataGrid.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;735)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[setInitialSortOrder](corelib.DataGrid.md#setinitialsortorder)

#### Defined in

[src/ui/datagrid/datagrid.ts:537](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;537)

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

[src/ui/datagrid/datagrid.ts:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1023)

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

[src/ui/datagrid/datagrid.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;574)

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

[src/ui/datagrid/datagrid.ts:861](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;861)

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

#### Overrides

[DataGrid](corelib.DataGrid.md).[set_readOnly](corelib.DataGrid.md#set_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;397)

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

[src/ui/editors/checktreeeditor.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;419)

___

### sortItems

▸ `Protected` **sortItems**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;359)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[subDialogDataChange](corelib.DataGrid.md#subdialogdatachange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1134)

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

[src/ui/datagrid/datagrid.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;349)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[updateDisabledState](corelib.DataGrid.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1126)

___

### updateFlags

▸ `Protected` **updateFlags**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;214)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[updateInterface](corelib.DataGrid.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1055](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1055)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;46)

___

### updateSelectAll

▸ `Protected` **updateSelectAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;208)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[useAsync](corelib.DataGrid.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;194)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[useLayoutTimer](corelib.DataGrid.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;198)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](corelib.DataGrid.md).[usePager](corelib.DataGrid.md#usepager)

#### Defined in

[src/ui/datagrid/datagrid.ts:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;794)

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

[src/ui/datagrid/datagrid.ts:673](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;673)

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

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;153)

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

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

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

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)

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

[src/ui/datagrid/datagrid.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;288)
