[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / CheckLookupEditor

# Class: CheckLookupEditor<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Hierarchy

- [`CheckTreeEditor`](CheckTreeEditor.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>, [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md)\>

  ↳ **`CheckLookupEditor`**

## Table of contents

### Constructors

- [constructor](CheckLookupEditor.md#constructor)

### Properties

- [allColumns](CheckLookupEditor.md#allcolumns)
- [cascadeLink](CheckLookupEditor.md#cascadelink)
- [element](CheckLookupEditor.md#element)
- [enableUpdateItems](CheckLookupEditor.md#enableupdateitems)
- [filterBar](CheckLookupEditor.md#filterbar)
- [idPrefix](CheckLookupEditor.md#idprefix)
- [initialSettings](CheckLookupEditor.md#initialsettings)
- [openDialogsAsPanel](CheckLookupEditor.md#opendialogsaspanel)
- [options](CheckLookupEditor.md#options)
- [propertyItemsData](CheckLookupEditor.md#propertyitemsdata)
- [quickFiltersBar](CheckLookupEditor.md#quickfiltersbar)
- [quickFiltersDiv](CheckLookupEditor.md#quickfiltersdiv)
- [restoringSettings](CheckLookupEditor.md#restoringsettings)
- [searchText](CheckLookupEditor.md#searchtext)
- [slickContainer](CheckLookupEditor.md#slickcontainer)
- [slickGrid](CheckLookupEditor.md#slickgrid)
- [titleDiv](CheckLookupEditor.md#titlediv)
- [toolbar](CheckLookupEditor.md#toolbar)
- [uniqueName](CheckLookupEditor.md#uniquename)
- [view](CheckLookupEditor.md#view)
- [widgetName](CheckLookupEditor.md#widgetname)
- [defaultColumnWidthDelta](CheckLookupEditor.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](CheckLookupEditor.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](CheckLookupEditor.md#defaultheaderheight)
- [defaultPersistanceStorage](CheckLookupEditor.md#defaultpersistancestorage)
- [defaultRowHeight](CheckLookupEditor.md#defaultrowheight)

### Accessors

- [cascadeField](CheckLookupEditor.md#cascadefield)
- [cascadeFrom](CheckLookupEditor.md#cascadefrom)
- [cascadeValue](CheckLookupEditor.md#cascadevalue)
- [filterField](CheckLookupEditor.md#filterfield)
- [filterValue](CheckLookupEditor.md#filtervalue)
- [readOnly](CheckLookupEditor.md#readonly)
- [value](CheckLookupEditor.md#value)

### Methods

- [addBooleanFilter](CheckLookupEditor.md#addbooleanfilter)
- [addCssClass](CheckLookupEditor.md#addcssclass)
- [addDateRangeFilter](CheckLookupEditor.md#adddaterangefilter)
- [addDateTimeRangeFilter](CheckLookupEditor.md#adddatetimerangefilter)
- [addFilterSeparator](CheckLookupEditor.md#addfilterseparator)
- [addQuickFilter](CheckLookupEditor.md#addquickfilter)
- [addValidationRule](CheckLookupEditor.md#addvalidationrule)
- [afterInit](CheckLookupEditor.md#afterinit)
- [allDescendantsSelected](CheckLookupEditor.md#alldescendantsselected)
- [allItemsSelected](CheckLookupEditor.md#allitemsselected)
- [anyDescendantsSelected](CheckLookupEditor.md#anydescendantsselected)
- [attrs](CheckLookupEditor.md#attrs)
- [bindToSlickEvents](CheckLookupEditor.md#bindtoslickevents)
- [bindToViewEvents](CheckLookupEditor.md#bindtoviewevents)
- [booleanQuickFilter](CheckLookupEditor.md#booleanquickfilter)
- [canFilterColumn](CheckLookupEditor.md#canfiltercolumn)
- [canShowColumn](CheckLookupEditor.md#canshowcolumn)
- [cascadeItems](CheckLookupEditor.md#cascadeitems)
- [change](CheckLookupEditor.md#change)
- [changeSelect2](CheckLookupEditor.md#changeselect2)
- [createFilterBar](CheckLookupEditor.md#createfilterbar)
- [createIncludeDeletedButton](CheckLookupEditor.md#createincludedeletedbutton)
- [createPager](CheckLookupEditor.md#createpager)
- [createQuickFilters](CheckLookupEditor.md#createquickfilters)
- [createQuickSearchInput](CheckLookupEditor.md#createquicksearchinput)
- [createSlickContainer](CheckLookupEditor.md#createslickcontainer)
- [createSlickGrid](CheckLookupEditor.md#createslickgrid)
- [createToolbar](CheckLookupEditor.md#createtoolbar)
- [createToolbarExtensions](CheckLookupEditor.md#createtoolbarextensions)
- [createView](CheckLookupEditor.md#createview)
- [dateRangeQuickFilter](CheckLookupEditor.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](CheckLookupEditor.md#datetimerangequickfilter)
- [destroy](CheckLookupEditor.md#destroy)
- [determineText](CheckLookupEditor.md#determinetext)
- [editItem](CheckLookupEditor.md#edititem)
- [editItemOfType](CheckLookupEditor.md#edititemoftype)
- [enableFiltering](CheckLookupEditor.md#enablefiltering)
- [ensureQuickFilterBar](CheckLookupEditor.md#ensurequickfilterbar)
- [filterItems](CheckLookupEditor.md#filteritems)
- [findQuickFilter](CheckLookupEditor.md#findquickfilter)
- [getAddButtonCaption](CheckLookupEditor.md#getaddbuttoncaption)
- [getButtons](CheckLookupEditor.md#getbuttons)
- [getCascadeFromValue](CheckLookupEditor.md#getcascadefromvalue)
- [getColumnWidthDelta](CheckLookupEditor.md#getcolumnwidthdelta)
- [getColumnWidthScale](CheckLookupEditor.md#getcolumnwidthscale)
- [getColumns](CheckLookupEditor.md#getcolumns)
- [getColumnsKey](CheckLookupEditor.md#getcolumnskey)
- [getCssClass](CheckLookupEditor.md#getcssclass)
- [getCurrentSettings](CheckLookupEditor.md#getcurrentsettings)
- [getDefaultSortBy](CheckLookupEditor.md#getdefaultsortby)
- [getDelimited](CheckLookupEditor.md#getdelimited)
- [getDescendantsSelected](CheckLookupEditor.md#getdescendantsselected)
- [getEditValue](CheckLookupEditor.md#geteditvalue)
- [getElement](CheckLookupEditor.md#getelement)
- [getFilterStore](CheckLookupEditor.md#getfilterstore)
- [getGrid](CheckLookupEditor.md#getgrid)
- [getGridCanLoad](CheckLookupEditor.md#getgridcanload)
- [getGridField](CheckLookupEditor.md#getgridfield)
- [getIdProperty](CheckLookupEditor.md#getidproperty)
- [getIncludeColumns](CheckLookupEditor.md#getincludecolumns)
- [getInitialCollapse](CheckLookupEditor.md#getinitialcollapse)
- [getInitialTitle](CheckLookupEditor.md#getinitialtitle)
- [getIsActiveProperty](CheckLookupEditor.md#getisactiveproperty)
- [getIsDeletedProperty](CheckLookupEditor.md#getisdeletedproperty)
- [getItemCssClass](CheckLookupEditor.md#getitemcssclass)
- [getItemMetadata](CheckLookupEditor.md#getitemmetadata)
- [getItemText](CheckLookupEditor.md#getitemtext)
- [getItemType](CheckLookupEditor.md#getitemtype)
- [getItems](CheckLookupEditor.md#getitems)
- [getLocalTextDbPrefix](CheckLookupEditor.md#getlocaltextdbprefix)
- [getLocalTextPrefix](CheckLookupEditor.md#getlocaltextprefix)
- [getLookupItems](CheckLookupEditor.md#getlookupitems)
- [getLookupKey](CheckLookupEditor.md#getlookupkey)
- [getPagerOptions](CheckLookupEditor.md#getpageroptions)
- [getPersistanceKey](CheckLookupEditor.md#getpersistancekey)
- [getPersistanceStorage](CheckLookupEditor.md#getpersistancestorage)
- [getPersistedSettings](CheckLookupEditor.md#getpersistedsettings)
- [getPropertyItems](CheckLookupEditor.md#getpropertyitems)
- [getPropertyItemsData](CheckLookupEditor.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](CheckLookupEditor.md#getpropertyitemsdataasync)
- [getQuickFilters](CheckLookupEditor.md#getquickfilters)
- [getQuickSearchFields](CheckLookupEditor.md#getquicksearchfields)
- [getRowDefinition](CheckLookupEditor.md#getrowdefinition)
- [getSelectAllText](CheckLookupEditor.md#getselectalltext)
- [getSlickOptions](CheckLookupEditor.md#getslickoptions)
- [getTitle](CheckLookupEditor.md#gettitle)
- [getTreeItems](CheckLookupEditor.md#gettreeitems)
- [getView](CheckLookupEditor.md#getview)
- [getViewOptions](CheckLookupEditor.md#getviewoptions)
- [get\_cascadeField](CheckLookupEditor.md#get_cascadefield)
- [get\_cascadeFrom](CheckLookupEditor.md#get_cascadefrom)
- [get\_cascadeValue](CheckLookupEditor.md#get_cascadevalue)
- [get\_filterField](CheckLookupEditor.md#get_filterfield)
- [get\_filterValue](CheckLookupEditor.md#get_filtervalue)
- [get\_readOnly](CheckLookupEditor.md#get_readonly)
- [gridPersistanceFlags](CheckLookupEditor.md#gridpersistanceflags)
- [init](CheckLookupEditor.md#init)
- [initAsync](CheckLookupEditor.md#initasync)
- [initSync](CheckLookupEditor.md#initsync)
- [initialPopulate](CheckLookupEditor.md#initialpopulate)
- [initialize](CheckLookupEditor.md#initialize)
- [initializeFilterBar](CheckLookupEditor.md#initializefilterbar)
- [internalInit](CheckLookupEditor.md#internalinit)
- [internalRefresh](CheckLookupEditor.md#internalrefresh)
- [invokeSubmitHandlers](CheckLookupEditor.md#invokesubmithandlers)
- [isThreeStateHierarchy](CheckLookupEditor.md#isthreestatehierarchy)
- [itemAt](CheckLookupEditor.md#itemat)
- [itemLink](CheckLookupEditor.md#itemlink)
- [itemSelectedChanged](CheckLookupEditor.md#itemselectedchanged)
- [layout](CheckLookupEditor.md#layout)
- [markupReady](CheckLookupEditor.md#markupready)
- [moveSelectedUp](CheckLookupEditor.md#moveselectedup)
- [onClick](CheckLookupEditor.md#onclick)
- [onViewFilter](CheckLookupEditor.md#onviewfilter)
- [onViewProcessData](CheckLookupEditor.md#onviewprocessdata)
- [onViewSubmit](CheckLookupEditor.md#onviewsubmit)
- [persistSettings](CheckLookupEditor.md#persistsettings)
- [populateLock](CheckLookupEditor.md#populatelock)
- [populateUnlock](CheckLookupEditor.md#populateunlock)
- [populateWhenVisible](CheckLookupEditor.md#populatewhenvisible)
- [postProcessColumns](CheckLookupEditor.md#postprocesscolumns)
- [propertyItemsToSlickColumns](CheckLookupEditor.md#propertyitemstoslickcolumns)
- [quickFilterChange](CheckLookupEditor.md#quickfilterchange)
- [refresh](CheckLookupEditor.md#refresh)
- [refreshIfNeeded](CheckLookupEditor.md#refreshifneeded)
- [renderContents](CheckLookupEditor.md#rendercontents)
- [resizeCanvas](CheckLookupEditor.md#resizecanvas)
- [restoreSettings](CheckLookupEditor.md#restoresettings)
- [restoreSettingsFrom](CheckLookupEditor.md#restoresettingsfrom)
- [rowCount](CheckLookupEditor.md#rowcount)
- [setAllSubTreeSelected](CheckLookupEditor.md#setallsubtreeselected)
- [setCascadeFrom](CheckLookupEditor.md#setcascadefrom)
- [setCriteriaParameter](CheckLookupEditor.md#setcriteriaparameter)
- [setEditValue](CheckLookupEditor.md#seteditvalue)
- [setEquality](CheckLookupEditor.md#setequality)
- [setIncludeColumnsParameter](CheckLookupEditor.md#setincludecolumnsparameter)
- [setInitialSortOrder](CheckLookupEditor.md#setinitialsortorder)
- [setIsDisabled](CheckLookupEditor.md#setisdisabled)
- [setItems](CheckLookupEditor.md#setitems)
- [setTitle](CheckLookupEditor.md#settitle)
- [set\_cascadeField](CheckLookupEditor.md#set_cascadefield)
- [set\_cascadeFrom](CheckLookupEditor.md#set_cascadefrom)
- [set\_cascadeValue](CheckLookupEditor.md#set_cascadevalue)
- [set\_filterField](CheckLookupEditor.md#set_filterfield)
- [set\_filterValue](CheckLookupEditor.md#set_filtervalue)
- [set\_readOnly](CheckLookupEditor.md#set_readonly)
- [sortItems](CheckLookupEditor.md#sortitems)
- [subDialogDataChange](CheckLookupEditor.md#subdialogdatachange)
- [tryFindQuickFilter](CheckLookupEditor.md#tryfindquickfilter)
- [updateDisabledState](CheckLookupEditor.md#updatedisabledstate)
- [updateFlags](CheckLookupEditor.md#updateflags)
- [updateInterface](CheckLookupEditor.md#updateinterface)
- [updateItems](CheckLookupEditor.md#updateitems)
- [updateSelectAll](CheckLookupEditor.md#updateselectall)
- [useAsync](CheckLookupEditor.md#useasync)
- [useLayoutTimer](CheckLookupEditor.md#uselayouttimer)
- [usePager](CheckLookupEditor.md#usepager)
- [viewDataChanged](CheckLookupEditor.md#viewdatachanged)
- [create](CheckLookupEditor.md#create)
- [elementFor](CheckLookupEditor.md#elementfor)
- [getWidgetName](CheckLookupEditor.md#getwidgetname)
- [propertyItemToQuickFilter](CheckLookupEditor.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new CheckLookupEditor**<`TItem`\>(`div`, `options`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `options` | [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) |

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[constructor](CheckTreeEditor.md#constructor)

#### Defined in

[src/ui/editors/checktreeeditor.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L478)

## Properties

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[allColumns](CheckTreeEditor.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L103)

___

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)<[`Widget`](Widget.md)<`any`\>\>

#### Defined in

[src/ui/editors/checktreeeditor.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L592)

___

### element

• **element**: `JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[element](CheckTreeEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### enableUpdateItems

• `Private` **enableUpdateItems**: `boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L476)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[filterBar](CheckTreeEditor.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[idPrefix](CheckTreeEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initialSettings](CheckTreeEditor.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[openDialogsAsPanel](CheckTreeEditor.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L109)

___

### options

• `Protected` **options**: [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[options](CheckTreeEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemsData](CheckTreeEditor.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[quickFiltersBar](CheckTreeEditor.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[quickFiltersDiv](CheckTreeEditor.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[restoringSettings](CheckTreeEditor.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L106)

___

### searchText

• `Private` **searchText**: `string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:475](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L475)

___

### slickContainer

• `Protected` **slickContainer**: `JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[slickContainer](CheckTreeEditor.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[slickGrid](CheckTreeEditor.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[titleDiv](CheckTreeEditor.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[toolbar](CheckTreeEditor.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[uniqueName](CheckTreeEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### view

• **view**: [`RemoteView`](RemoteView.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[view](CheckTreeEditor.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[widgetName](CheckTreeEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultColumnWidthDelta](CheckTreeEditor.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultColumnWidthScale](CheckTreeEditor.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultHeaderHeight](CheckTreeEditor.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultPersistanceStorage](CheckTreeEditor.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultRowHeight](CheckTreeEditor.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L111)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L628)

• `set` **cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L636)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L584)

• `set` **cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L620)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L644)

• `set` **cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L656)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L664)

• `set` **filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L672)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L680)

• `set` **filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:692](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L692)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

CheckTreeEditor.readOnly

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

CheckTreeEditor.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1031)

___

### value

• `get` **value**(): `string`[]

#### Returns

`string`[]

#### Inherited from

CheckTreeEditor.value

#### Defined in

[src/ui/editors/checktreeeditor.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L415)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string`[] |

#### Returns

`void`

#### Inherited from

CheckTreeEditor.value

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

[CheckTreeEditor](CheckTreeEditor.md).[addBooleanFilter](CheckTreeEditor.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1165)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addCssClass](CheckTreeEditor.md#addcssclass)

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

[CheckTreeEditor](CheckTreeEditor.md).[addDateRangeFilter](CheckTreeEditor.md#adddaterangefilter)

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

[CheckTreeEditor](CheckTreeEditor.md).[addDateTimeRangeFilter](CheckTreeEditor.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1157)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addFilterSeparator](CheckTreeEditor.md#addfilterseparator)

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

[CheckTreeEditor](CheckTreeEditor.md).[addQuickFilter](CheckTreeEditor.md#addquickfilter)

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

[CheckTreeEditor](CheckTreeEditor.md).[addValidationRule](CheckTreeEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[afterInit](CheckTreeEditor.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### allDescendantsSelected

▸ `Protected` **allDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[allDescendantsSelected](CheckTreeEditor.md#alldescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L283)

___

### allItemsSelected

▸ `Protected` **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[allItemsSelected](CheckTreeEditor.md#allitemsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L272)

___

### anyDescendantsSelected

▸ `Protected` **anyDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[anyDescendantsSelected](CheckTreeEditor.md#anydescendantsselected)

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

[CheckTreeEditor](CheckTreeEditor.md).[attrs](CheckTreeEditor.md#attrs)

#### Defined in

[src/ui/datagrid/datagrid.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L205)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[bindToSlickEvents](CheckTreeEditor.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L569)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[bindToViewEvents](CheckTreeEditor.md#bindtoviewevents)

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

[CheckTreeEditor](CheckTreeEditor.md).[booleanQuickFilter](CheckTreeEditor.md#booleanquickfilter)

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

[CheckTreeEditor](CheckTreeEditor.md).[canFilterColumn](CheckTreeEditor.md#canfiltercolumn)

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

[CheckTreeEditor](CheckTreeEditor.md).[canShowColumn](CheckTreeEditor.md#canshowcolumn)

#### Defined in

[src/ui/datagrid/datagrid.ts:1204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1204)

___

### cascadeItems

▸ `Protected` **cascadeItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L517)

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

[CheckTreeEditor](CheckTreeEditor.md).[change](CheckTreeEditor.md#change)

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

[CheckTreeEditor](CheckTreeEditor.md).[change](CheckTreeEditor.md#change)

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

[CheckTreeEditor](CheckTreeEditor.md).[changeSelect2](CheckTreeEditor.md#changeselect2)

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

[CheckTreeEditor](CheckTreeEditor.md).[changeSelect2](CheckTreeEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createFilterBar](CheckTreeEditor.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L798)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createIncludeDeletedButton](CheckTreeEditor.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L350)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createPager](CheckTreeEditor.md#createpager)

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

[CheckTreeEditor](CheckTreeEditor.md).[createQuickFilters](CheckTreeEditor.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L246)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createQuickSearchInput](CheckTreeEditor.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L361)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createSlickContainer](CheckTreeEditor.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:751](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L751)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createSlickGrid](CheckTreeEditor.md#createslickgrid)

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

[CheckTreeEditor](CheckTreeEditor.md).[createToolbar](CheckTreeEditor.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L839)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[createToolbarExtensions](CheckTreeEditor.md#createtoolbarextensions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L501)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](RemoteView.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Returns

[`RemoteView`](RemoteView.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createView](CheckTreeEditor.md#createview)

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

[CheckTreeEditor](CheckTreeEditor.md).[dateRangeQuickFilter](CheckTreeEditor.md#daterangequickfilter)

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

[CheckTreeEditor](CheckTreeEditor.md).[dateTimeRangeQuickFilter](CheckTreeEditor.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1161)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[destroy](CheckTreeEditor.md#destroy)

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

[CheckTreeEditor](CheckTreeEditor.md).[determineText](CheckTreeEditor.md#determinetext)

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

[CheckTreeEditor](CheckTreeEditor.md).[editItem](CheckTreeEditor.md#edititem)

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

[CheckTreeEditor](CheckTreeEditor.md).[editItemOfType](CheckTreeEditor.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L639)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[enableFiltering](CheckTreeEditor.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L789)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[ensureQuickFilterBar](CheckTreeEditor.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L238)

___

### filterItems

▸ `Protected` **filterItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L539)

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

[CheckTreeEditor](CheckTreeEditor.md).[findQuickFilter](CheckTreeEditor.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L332)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getAddButtonCaption](CheckTreeEditor.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L627)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[getButtons](CheckTreeEditor.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:497](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L497)

___

### getCascadeFromValue

▸ `Protected` **getCascadeFromValue**(`parent`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | [`Widget`](Widget.md)<`any`\> |

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:588](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L588)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumnWidthDelta](CheckTreeEditor.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L463)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumnWidthScale](CheckTreeEditor.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:467](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L467)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumns](CheckTreeEditor.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L318)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumnsKey](CheckTreeEditor.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:890](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L890)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getCssClass](CheckTreeEditor.md#getcssclass)

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

[CheckTreeEditor](CheckTreeEditor.md).[getCurrentSettings](CheckTreeEditor.md#getcurrentsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1417)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getDefaultSortBy](CheckTreeEditor.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L760)

___

### getDelimited

▸ `Protected` **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getDelimited](CheckTreeEditor.md#getdelimited)

#### Defined in

[src/ui/editors/checktreeeditor.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L299)

___

### getDescendantsSelected

▸ `Protected` **getDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getDescendantsSelected](CheckTreeEditor.md#getdescendantsselected)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getEditValue](CheckTreeEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L67)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getElement](CheckTreeEditor.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1507)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getFilterStore](CheckTreeEditor.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1519)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getGrid](CheckTreeEditor.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1511)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getGridCanLoad](CheckTreeEditor.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:986](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L986)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getGridField](CheckTreeEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIdProperty](CheckTreeEditor.md#getidproperty)

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

[CheckTreeEditor](CheckTreeEditor.md).[getIncludeColumns](CheckTreeEditor.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L697)

___

### getInitialCollapse

▸ `Protected` **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getInitialCollapse](CheckTreeEditor.md#getinitialcollapse)

#### Defined in

[src/ui/editors/checktreeeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L150)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getInitialTitle](CheckTreeEditor.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L231)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIsActiveProperty](CheckTreeEditor.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1102)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIsDeletedProperty](CheckTreeEditor.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1096](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1096)

___

### getItemCssClass

▸ `Protected` **getItemCssClass**(`item`, `index`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |
| `index` | `number` |

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemCssClass](CheckTreeEditor.md#getitemcssclass)

#### Defined in

[src/ui/datagrid/datagrid.ts:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L400)

___

### getItemMetadata

▸ `Protected` **getItemMetadata**(`item`, `index`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |
| `index` | `number` |

#### Returns

`any`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemMetadata](CheckTreeEditor.md#getitemmetadata)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemText](CheckTreeEditor.md#getitemtext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L349)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemType](CheckTreeEditor.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getItems

▸ **getItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItems](CheckTreeEditor.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L561)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getLocalTextDbPrefix](CheckTreeEditor.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1056](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1056)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getLocalTextPrefix](CheckTreeEditor.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1068](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1068)

___

### getLookupItems

▸ `Protected` **getLookupItems**(`lookup`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `lookup` | [`Lookup`](Lookup.md)<`TItem`\> |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:555](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L555)

___

### getLookupKey

▸ `Protected` **getLookupKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L493)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPagerOptions](CheckTreeEditor.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPersistanceKey](CheckTreeEditor.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1189)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPersistanceStorage](CheckTreeEditor.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1185)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPersistedSettings](CheckTreeEditor.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1225)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPropertyItems](CheckTreeEditor.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L899)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPropertyItemsData](CheckTreeEditor.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:903](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L903)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPropertyItemsDataAsync](CheckTreeEditor.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:923](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L923)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getQuickFilters](CheckTreeEditor.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L268)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getQuickSearchFields](CheckTreeEditor.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L357)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getRowDefinition](CheckTreeEditor.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:1050](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1050)

___

### getSelectAllText

▸ `Protected` **getSelectAllText**(): `string`

#### Returns

`string`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[getSelectAllText](CheckTreeEditor.md#getselectalltext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L510)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getSlickOptions](CheckTreeEditor.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L353)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getTitle](CheckTreeEditor.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getTreeItems

▸ `Protected` **getTreeItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>[]

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[getTreeItems](CheckTreeEditor.md#gettreeitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L559)

___

### getView

▸ **getView**(): [`RemoteView`](RemoteView.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Returns

[`RemoteView`](RemoteView.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getView](CheckTreeEditor.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1515)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getViewOptions](CheckTreeEditor.md#getviewoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:817](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L817)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L624)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L580)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:640](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L640)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L660)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L676)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[get_readOnly](CheckTreeEditor.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L393)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[gridPersistanceFlags](CheckTreeEditor.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1200)

___

### init

▸ **init**(`action?`): [`CheckLookupEditor`](CheckLookupEditor.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`CheckLookupEditor`](CheckLookupEditor.md)<`TItem`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[init](CheckTreeEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initAsync](CheckTreeEditor.md#initasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L188)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initSync](CheckTreeEditor.md#initsync)

#### Defined in

[src/ui/datagrid/datagrid.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L182)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initialPopulate](CheckTreeEditor.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L471)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initialize](CheckTreeEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initializeFilterBar](CheckTreeEditor.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L493)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[internalInit](CheckTreeEditor.md#internalinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[internalRefresh](CheckTreeEditor.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:1010](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1010)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[invokeSubmitHandlers](CheckTreeEditor.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1173)

___

### isThreeStateHierarchy

▸ `Protected` **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[isThreeStateHierarchy](CheckTreeEditor.md#isthreestatehierarchy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L112)

___

### itemAt

▸ **itemAt**(`row`): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[itemAt](CheckTreeEditor.md#itemat)

#### Defined in

[src/ui/datagrid/datagrid.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L553)

___

### itemLink

▸ `Protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../modules.md#format)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../modules.md#format)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[itemLink](CheckTreeEditor.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L876)

___

### itemSelectedChanged

▸ `Protected` **itemSelectedChanged**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[itemSelectedChanged](CheckTreeEditor.md#itemselectedchanged)

#### Defined in

[src/ui/editors/checktreeeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L105)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[layout](CheckTreeEditor.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L209)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[markupReady](CheckTreeEditor.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:748](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L748)

___

### moveSelectedUp

▸ `Protected` **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[moveSelectedUp](CheckTreeEditor.md#moveselectedup)

#### Defined in

[src/ui/editors/checktreeeditor.ts:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L576)

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

[CheckTreeEditor](CheckTreeEditor.md).[onClick](CheckTreeEditor.md#onclick)

#### Defined in

[src/ui/editors/checktreeeditor.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L165)

___

### onViewFilter

▸ `Protected` **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[onViewFilter](CheckTreeEditor.md#onviewfilter)

#### Defined in

[src/ui/editors/checktreeeditor.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L569)

___

### onViewProcessData

▸ `Protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/ListResponse.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\> |

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[onViewProcessData](CheckTreeEditor.md#onviewprocessdata)

#### Defined in

[src/ui/editors/checktreeeditor.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L154)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[onViewSubmit](CheckTreeEditor.md#onviewsubmit)

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

[CheckTreeEditor](CheckTreeEditor.md).[persistSettings](CheckTreeEditor.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1407](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1407)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[populateLock](CheckTreeEditor.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:978](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L978)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[populateUnlock](CheckTreeEditor.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L982)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[populateWhenVisible](CheckTreeEditor.md#populatewhenvisible)

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

[CheckTreeEditor](CheckTreeEditor.md).[postProcessColumns](CheckTreeEditor.md#postprocesscolumns)

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

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemsToSlickColumns](CheckTreeEditor.md#propertyitemstoslickcolumns)

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

[CheckTreeEditor](CheckTreeEditor.md).[quickFilterChange](CheckTreeEditor.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1179)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[refresh](CheckTreeEditor.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L990)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[refreshIfNeeded](CheckTreeEditor.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.ts:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1003)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[renderContents](CheckTreeEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[resizeCanvas](CheckTreeEditor.md#resizecanvas)

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

[CheckTreeEditor](CheckTreeEditor.md).[restoreSettings](CheckTreeEditor.md#restoresettings)

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

[CheckTreeEditor](CheckTreeEditor.md).[restoreSettingsFrom](CheckTreeEditor.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.ts:1255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1255)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[rowCount](CheckTreeEditor.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L557)

___

### setAllSubTreeSelected

▸ `Protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\> |
| `selected` | `boolean` |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setAllSubTreeSelected](CheckTreeEditor.md#setallsubtreeselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L255)

___

### setCascadeFrom

▸ `Protected` **setCascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L594)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setCriteriaParameter](CheckTreeEditor.md#setcriteriaparameter)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setEditValue](CheckTreeEditor.md#seteditvalue)

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

[CheckTreeEditor](CheckTreeEditor.md).[setEquality](CheckTreeEditor.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L722)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setIncludeColumnsParameter](CheckTreeEditor.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L726)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setInitialSortOrder](CheckTreeEditor.md#setinitialsortorder)

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

[CheckTreeEditor](CheckTreeEditor.md).[setIsDisabled](CheckTreeEditor.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.ts:1014](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1014)

___

### setItems

▸ **setItems**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setItems](CheckTreeEditor.md#setitems)

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

[CheckTreeEditor](CheckTreeEditor.md).[setTitle](CheckTreeEditor.md#settitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L852)

___

### set\_cascadeField

▸ `Protected` **set_cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:632](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L632)

___

### set\_cascadeFrom

▸ `Protected` **set_cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:613](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L613)

___

### set\_cascadeValue

▸ `Protected` **set_cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L648)

___

### set\_filterField

▸ `Protected` **set_filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L668)

___

### set\_filterValue

▸ `Protected` **set_filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:684](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L684)

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

[CheckTreeEditor](CheckTreeEditor.md).[set_readOnly](CheckTreeEditor.md#set_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L397)

___

### sortItems

▸ `Protected` **sortItems**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[sortItems](CheckTreeEditor.md#sortitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L359)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[subDialogDataChange](CheckTreeEditor.md#subdialogdatachange)

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

[CheckTreeEditor](CheckTreeEditor.md).[tryFindQuickFilter](CheckTreeEditor.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L339)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateDisabledState](CheckTreeEditor.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1117)

___

### updateFlags

▸ `Protected` **updateFlags**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateFlags](CheckTreeEditor.md#updateflags)

#### Defined in

[src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L214)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateInterface](CheckTreeEditor.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1046)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[updateItems](CheckTreeEditor.md#updateitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L488)

___

### updateSelectAll

▸ `Protected` **updateSelectAll**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateSelectAll](CheckTreeEditor.md#updateselectall)

#### Defined in

[src/ui/editors/checktreeeditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L208)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[useAsync](CheckTreeEditor.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L197)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[useLayoutTimer](CheckTreeEditor.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L201)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[usePager](CheckTreeEditor.md#usepager)

#### Defined in

[src/ui/datagrid/datagrid.ts:785](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L785)

___

### viewDataChanged

▸ `Protected` **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |
| `rows` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[viewDataChanged](CheckTreeEditor.md#viewdatachanged)

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

[CheckTreeEditor](CheckTreeEditor.md).[create](CheckTreeEditor.md#create)

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

[CheckTreeEditor](CheckTreeEditor.md).[elementFor](CheckTreeEditor.md#elementfor)

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

[CheckTreeEditor](CheckTreeEditor.md).[getWidgetName](CheckTreeEditor.md#getwidgetname)

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

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemToQuickFilter](CheckTreeEditor.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L278)
