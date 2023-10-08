[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / CheckLookupEditor

# Class: CheckLookupEditor<TItem\>

[corelib](../modules/corelib.md).CheckLookupEditor

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Hierarchy

- [`CheckTreeEditor`](corelib.CheckTreeEditor.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>, [`CheckLookupEditorOptions`](../interfaces/corelib.CheckLookupEditorOptions.md)\>

  ↳ **`CheckLookupEditor`**

## Table of contents

### Constructors

- [constructor](corelib.CheckLookupEditor.md#constructor)

### Properties

- [allColumns](corelib.CheckLookupEditor.md#allcolumns)
- [cascadeLink](corelib.CheckLookupEditor.md#cascadelink)
- [element](corelib.CheckLookupEditor.md#element)
- [enableUpdateItems](corelib.CheckLookupEditor.md#enableupdateitems)
- [filterBar](corelib.CheckLookupEditor.md#filterbar)
- [idPrefix](corelib.CheckLookupEditor.md#idprefix)
- [initialSettings](corelib.CheckLookupEditor.md#initialsettings)
- [openDialogsAsPanel](corelib.CheckLookupEditor.md#opendialogsaspanel)
- [options](corelib.CheckLookupEditor.md#options)
- [propertyItemsData](corelib.CheckLookupEditor.md#propertyitemsdata)
- [quickFiltersBar](corelib.CheckLookupEditor.md#quickfiltersbar)
- [quickFiltersDiv](corelib.CheckLookupEditor.md#quickfiltersdiv)
- [restoringSettings](corelib.CheckLookupEditor.md#restoringsettings)
- [searchText](corelib.CheckLookupEditor.md#searchtext)
- [slickContainer](corelib.CheckLookupEditor.md#slickcontainer)
- [slickGrid](corelib.CheckLookupEditor.md#slickgrid)
- [titleDiv](corelib.CheckLookupEditor.md#titlediv)
- [toolbar](corelib.CheckLookupEditor.md#toolbar)
- [uniqueName](corelib.CheckLookupEditor.md#uniquename)
- [view](corelib.CheckLookupEditor.md#view)
- [widgetName](corelib.CheckLookupEditor.md#widgetname)
- [defaultColumnWidthDelta](corelib.CheckLookupEditor.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](corelib.CheckLookupEditor.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](corelib.CheckLookupEditor.md#defaultheaderheight)
- [defaultPersistanceStorage](corelib.CheckLookupEditor.md#defaultpersistancestorage)
- [defaultRowHeight](corelib.CheckLookupEditor.md#defaultrowheight)

### Accessors

- [cascadeField](corelib.CheckLookupEditor.md#cascadefield)
- [cascadeFrom](corelib.CheckLookupEditor.md#cascadefrom)
- [cascadeValue](corelib.CheckLookupEditor.md#cascadevalue)
- [filterField](corelib.CheckLookupEditor.md#filterfield)
- [filterValue](corelib.CheckLookupEditor.md#filtervalue)
- [readOnly](corelib.CheckLookupEditor.md#readonly)
- [value](corelib.CheckLookupEditor.md#value)

### Methods

- [addBooleanFilter](corelib.CheckLookupEditor.md#addbooleanfilter)
- [addCssClass](corelib.CheckLookupEditor.md#addcssclass)
- [addDateRangeFilter](corelib.CheckLookupEditor.md#adddaterangefilter)
- [addDateTimeRangeFilter](corelib.CheckLookupEditor.md#adddatetimerangefilter)
- [addFilterSeparator](corelib.CheckLookupEditor.md#addfilterseparator)
- [addQuickFilter](corelib.CheckLookupEditor.md#addquickfilter)
- [addValidationRule](corelib.CheckLookupEditor.md#addvalidationrule)
- [afterInit](corelib.CheckLookupEditor.md#afterinit)
- [allDescendantsSelected](corelib.CheckLookupEditor.md#alldescendantsselected)
- [allItemsSelected](corelib.CheckLookupEditor.md#allitemsselected)
- [anyDescendantsSelected](corelib.CheckLookupEditor.md#anydescendantsselected)
- [attrs](corelib.CheckLookupEditor.md#attrs)
- [bindToSlickEvents](corelib.CheckLookupEditor.md#bindtoslickevents)
- [bindToViewEvents](corelib.CheckLookupEditor.md#bindtoviewevents)
- [booleanQuickFilter](corelib.CheckLookupEditor.md#booleanquickfilter)
- [canFilterColumn](corelib.CheckLookupEditor.md#canfiltercolumn)
- [canShowColumn](corelib.CheckLookupEditor.md#canshowcolumn)
- [cascadeItems](corelib.CheckLookupEditor.md#cascadeitems)
- [change](corelib.CheckLookupEditor.md#change)
- [changeSelect2](corelib.CheckLookupEditor.md#changeselect2)
- [createFilterBar](corelib.CheckLookupEditor.md#createfilterbar)
- [createIncludeDeletedButton](corelib.CheckLookupEditor.md#createincludedeletedbutton)
- [createPager](corelib.CheckLookupEditor.md#createpager)
- [createQuickFilters](corelib.CheckLookupEditor.md#createquickfilters)
- [createQuickSearchInput](corelib.CheckLookupEditor.md#createquicksearchinput)
- [createSlickContainer](corelib.CheckLookupEditor.md#createslickcontainer)
- [createSlickGrid](corelib.CheckLookupEditor.md#createslickgrid)
- [createToolbar](corelib.CheckLookupEditor.md#createtoolbar)
- [createToolbarExtensions](corelib.CheckLookupEditor.md#createtoolbarextensions)
- [createView](corelib.CheckLookupEditor.md#createview)
- [dateRangeQuickFilter](corelib.CheckLookupEditor.md#daterangequickfilter)
- [dateTimeRangeQuickFilter](corelib.CheckLookupEditor.md#datetimerangequickfilter)
- [destroy](corelib.CheckLookupEditor.md#destroy)
- [determineText](corelib.CheckLookupEditor.md#determinetext)
- [editItem](corelib.CheckLookupEditor.md#edititem)
- [editItemOfType](corelib.CheckLookupEditor.md#edititemoftype)
- [enableFiltering](corelib.CheckLookupEditor.md#enablefiltering)
- [ensureQuickFilterBar](corelib.CheckLookupEditor.md#ensurequickfilterbar)
- [filterItems](corelib.CheckLookupEditor.md#filteritems)
- [findQuickFilter](corelib.CheckLookupEditor.md#findquickfilter)
- [getAddButtonCaption](corelib.CheckLookupEditor.md#getaddbuttoncaption)
- [getButtons](corelib.CheckLookupEditor.md#getbuttons)
- [getCascadeFromValue](corelib.CheckLookupEditor.md#getcascadefromvalue)
- [getColumnWidthDelta](corelib.CheckLookupEditor.md#getcolumnwidthdelta)
- [getColumnWidthScale](corelib.CheckLookupEditor.md#getcolumnwidthscale)
- [getColumns](corelib.CheckLookupEditor.md#getcolumns)
- [getColumnsKey](corelib.CheckLookupEditor.md#getcolumnskey)
- [getCssClass](corelib.CheckLookupEditor.md#getcssclass)
- [getCurrentSettings](corelib.CheckLookupEditor.md#getcurrentsettings)
- [getDefaultSortBy](corelib.CheckLookupEditor.md#getdefaultsortby)
- [getDelimited](corelib.CheckLookupEditor.md#getdelimited)
- [getDescendantsSelected](corelib.CheckLookupEditor.md#getdescendantsselected)
- [getEditValue](corelib.CheckLookupEditor.md#geteditvalue)
- [getElement](corelib.CheckLookupEditor.md#getelement)
- [getFilterStore](corelib.CheckLookupEditor.md#getfilterstore)
- [getGrid](corelib.CheckLookupEditor.md#getgrid)
- [getGridCanLoad](corelib.CheckLookupEditor.md#getgridcanload)
- [getGridField](corelib.CheckLookupEditor.md#getgridfield)
- [getIdProperty](corelib.CheckLookupEditor.md#getidproperty)
- [getIncludeColumns](corelib.CheckLookupEditor.md#getincludecolumns)
- [getInitialCollapse](corelib.CheckLookupEditor.md#getinitialcollapse)
- [getInitialTitle](corelib.CheckLookupEditor.md#getinitialtitle)
- [getIsActiveProperty](corelib.CheckLookupEditor.md#getisactiveproperty)
- [getIsDeletedProperty](corelib.CheckLookupEditor.md#getisdeletedproperty)
- [getItemCssClass](corelib.CheckLookupEditor.md#getitemcssclass)
- [getItemMetadata](corelib.CheckLookupEditor.md#getitemmetadata)
- [getItemText](corelib.CheckLookupEditor.md#getitemtext)
- [getItemType](corelib.CheckLookupEditor.md#getitemtype)
- [getItems](corelib.CheckLookupEditor.md#getitems)
- [getLocalTextDbPrefix](corelib.CheckLookupEditor.md#getlocaltextdbprefix)
- [getLocalTextPrefix](corelib.CheckLookupEditor.md#getlocaltextprefix)
- [getLookupItems](corelib.CheckLookupEditor.md#getlookupitems)
- [getLookupKey](corelib.CheckLookupEditor.md#getlookupkey)
- [getPagerOptions](corelib.CheckLookupEditor.md#getpageroptions)
- [getPersistanceKey](corelib.CheckLookupEditor.md#getpersistancekey)
- [getPersistanceStorage](corelib.CheckLookupEditor.md#getpersistancestorage)
- [getPersistedSettings](corelib.CheckLookupEditor.md#getpersistedsettings)
- [getPropertyItems](corelib.CheckLookupEditor.md#getpropertyitems)
- [getPropertyItemsData](corelib.CheckLookupEditor.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](corelib.CheckLookupEditor.md#getpropertyitemsdataasync)
- [getQuickFilters](corelib.CheckLookupEditor.md#getquickfilters)
- [getQuickSearchFields](corelib.CheckLookupEditor.md#getquicksearchfields)
- [getRowDefinition](corelib.CheckLookupEditor.md#getrowdefinition)
- [getSelectAllText](corelib.CheckLookupEditor.md#getselectalltext)
- [getSlickOptions](corelib.CheckLookupEditor.md#getslickoptions)
- [getTitle](corelib.CheckLookupEditor.md#gettitle)
- [getTreeItems](corelib.CheckLookupEditor.md#gettreeitems)
- [getView](corelib.CheckLookupEditor.md#getview)
- [getViewOptions](corelib.CheckLookupEditor.md#getviewoptions)
- [get\_cascadeField](corelib.CheckLookupEditor.md#get_cascadefield)
- [get\_cascadeFrom](corelib.CheckLookupEditor.md#get_cascadefrom)
- [get\_cascadeValue](corelib.CheckLookupEditor.md#get_cascadevalue)
- [get\_filterField](corelib.CheckLookupEditor.md#get_filterfield)
- [get\_filterValue](corelib.CheckLookupEditor.md#get_filtervalue)
- [get\_readOnly](corelib.CheckLookupEditor.md#get_readonly)
- [gridPersistanceFlags](corelib.CheckLookupEditor.md#gridpersistanceflags)
- [init](corelib.CheckLookupEditor.md#init)
- [initAsync](corelib.CheckLookupEditor.md#initasync)
- [initSync](corelib.CheckLookupEditor.md#initsync)
- [initialPopulate](corelib.CheckLookupEditor.md#initialpopulate)
- [initialize](corelib.CheckLookupEditor.md#initialize)
- [initializeFilterBar](corelib.CheckLookupEditor.md#initializefilterbar)
- [internalInit](corelib.CheckLookupEditor.md#internalinit)
- [internalRefresh](corelib.CheckLookupEditor.md#internalrefresh)
- [invokeSubmitHandlers](corelib.CheckLookupEditor.md#invokesubmithandlers)
- [isThreeStateHierarchy](corelib.CheckLookupEditor.md#isthreestatehierarchy)
- [itemAt](corelib.CheckLookupEditor.md#itemat)
- [itemLink](corelib.CheckLookupEditor.md#itemlink)
- [itemSelectedChanged](corelib.CheckLookupEditor.md#itemselectedchanged)
- [layout](corelib.CheckLookupEditor.md#layout)
- [markupReady](corelib.CheckLookupEditor.md#markupready)
- [moveSelectedUp](corelib.CheckLookupEditor.md#moveselectedup)
- [onClick](corelib.CheckLookupEditor.md#onclick)
- [onViewFilter](corelib.CheckLookupEditor.md#onviewfilter)
- [onViewProcessData](corelib.CheckLookupEditor.md#onviewprocessdata)
- [onViewSubmit](corelib.CheckLookupEditor.md#onviewsubmit)
- [persistSettings](corelib.CheckLookupEditor.md#persistsettings)
- [populateLock](corelib.CheckLookupEditor.md#populatelock)
- [populateUnlock](corelib.CheckLookupEditor.md#populateunlock)
- [populateWhenVisible](corelib.CheckLookupEditor.md#populatewhenvisible)
- [postProcessColumns](corelib.CheckLookupEditor.md#postprocesscolumns)
- [propertyItemsToSlickColumns](corelib.CheckLookupEditor.md#propertyitemstoslickcolumns)
- [quickFilterChange](corelib.CheckLookupEditor.md#quickfilterchange)
- [refresh](corelib.CheckLookupEditor.md#refresh)
- [refreshIfNeeded](corelib.CheckLookupEditor.md#refreshifneeded)
- [renderContents](corelib.CheckLookupEditor.md#rendercontents)
- [resizeCanvas](corelib.CheckLookupEditor.md#resizecanvas)
- [restoreSettings](corelib.CheckLookupEditor.md#restoresettings)
- [restoreSettingsFrom](corelib.CheckLookupEditor.md#restoresettingsfrom)
- [rowCount](corelib.CheckLookupEditor.md#rowcount)
- [setAllSubTreeSelected](corelib.CheckLookupEditor.md#setallsubtreeselected)
- [setCascadeFrom](corelib.CheckLookupEditor.md#setcascadefrom)
- [setCriteriaParameter](corelib.CheckLookupEditor.md#setcriteriaparameter)
- [setEditValue](corelib.CheckLookupEditor.md#seteditvalue)
- [setEquality](corelib.CheckLookupEditor.md#setequality)
- [setIncludeColumnsParameter](corelib.CheckLookupEditor.md#setincludecolumnsparameter)
- [setInitialSortOrder](corelib.CheckLookupEditor.md#setinitialsortorder)
- [setIsDisabled](corelib.CheckLookupEditor.md#setisdisabled)
- [setItems](corelib.CheckLookupEditor.md#setitems)
- [setTitle](corelib.CheckLookupEditor.md#settitle)
- [set\_cascadeField](corelib.CheckLookupEditor.md#set_cascadefield)
- [set\_cascadeFrom](corelib.CheckLookupEditor.md#set_cascadefrom)
- [set\_cascadeValue](corelib.CheckLookupEditor.md#set_cascadevalue)
- [set\_filterField](corelib.CheckLookupEditor.md#set_filterfield)
- [set\_filterValue](corelib.CheckLookupEditor.md#set_filtervalue)
- [set\_readOnly](corelib.CheckLookupEditor.md#set_readonly)
- [sortItems](corelib.CheckLookupEditor.md#sortitems)
- [subDialogDataChange](corelib.CheckLookupEditor.md#subdialogdatachange)
- [tryFindQuickFilter](corelib.CheckLookupEditor.md#tryfindquickfilter)
- [updateDisabledState](corelib.CheckLookupEditor.md#updatedisabledstate)
- [updateFlags](corelib.CheckLookupEditor.md#updateflags)
- [updateInterface](corelib.CheckLookupEditor.md#updateinterface)
- [updateItems](corelib.CheckLookupEditor.md#updateitems)
- [updateSelectAll](corelib.CheckLookupEditor.md#updateselectall)
- [useAsync](corelib.CheckLookupEditor.md#useasync)
- [useLayoutTimer](corelib.CheckLookupEditor.md#uselayouttimer)
- [usePager](corelib.CheckLookupEditor.md#usepager)
- [viewDataChanged](corelib.CheckLookupEditor.md#viewdatachanged)
- [create](corelib.CheckLookupEditor.md#create)
- [elementFor](corelib.CheckLookupEditor.md#elementfor)
- [getWidgetName](corelib.CheckLookupEditor.md#getwidgetname)
- [propertyItemToQuickFilter](corelib.CheckLookupEditor.md#propertyitemtoquickfilter)

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
| `options` | [`CheckLookupEditorOptions`](../interfaces/corelib.CheckLookupEditorOptions.md) |

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[constructor](corelib.CheckTreeEditor.md#constructor)

#### Defined in

[src/ui/editors/checktreeeditor.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L478)

## Properties

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[allColumns](corelib.CheckTreeEditor.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L103)

___

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](corelib.CascadedWidgetLink.md)<[`Widget`](corelib.Widget.md)<`any`\>\>

#### Defined in

[src/ui/editors/checktreeeditor.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L592)

___

### element

• **element**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[element](corelib.CheckTreeEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### enableUpdateItems

• `Private` **enableUpdateItems**: `boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L476)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[filterBar](corelib.CheckTreeEditor.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[idPrefix](corelib.CheckTreeEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initialSettings](corelib.CheckTreeEditor.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[openDialogsAsPanel](corelib.CheckTreeEditor.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L109)

___

### options

• `Protected` **options**: [`CheckLookupEditorOptions`](../interfaces/corelib.CheckLookupEditorOptions.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[options](corelib.CheckTreeEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[propertyItemsData](corelib.CheckTreeEditor.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[quickFiltersBar](corelib.CheckTreeEditor.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[quickFiltersDiv](corelib.CheckTreeEditor.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[restoringSettings](corelib.CheckTreeEditor.md#restoringsettings)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[slickContainer](corelib.CheckTreeEditor.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[slickGrid](corelib.CheckTreeEditor.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[titleDiv](corelib.CheckTreeEditor.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[toolbar](corelib.CheckTreeEditor.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[uniqueName](corelib.CheckTreeEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### view

• **view**: [`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[view](corelib.CheckTreeEditor.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[widgetName](corelib.CheckTreeEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultColumnWidthDelta](corelib.CheckTreeEditor.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultColumnWidthScale](corelib.CheckTreeEditor.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultHeaderHeight](corelib.CheckTreeEditor.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultPersistanceStorage](corelib.CheckTreeEditor.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultRowHeight](corelib.CheckTreeEditor.md#defaultrowheight)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addBooleanFilter](corelib.CheckTreeEditor.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1165)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addCssClass](corelib.CheckTreeEditor.md#addcssclass)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addDateRangeFilter](corelib.CheckTreeEditor.md#adddaterangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1149)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addDateTimeRangeFilter](corelib.CheckTreeEditor.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1157)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addFilterSeparator](corelib.CheckTreeEditor.md#addfilterseparator)

#### Defined in

[src/ui/datagrid/datagrid.ts:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1129)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addQuickFilter](corelib.CheckTreeEditor.md#addquickfilter)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addValidationRule](corelib.CheckTreeEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[afterInit](corelib.CheckTreeEditor.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### allDescendantsSelected

▸ `Protected` **allDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[allDescendantsSelected](corelib.CheckTreeEditor.md#alldescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L283)

___

### allItemsSelected

▸ `Protected` **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[allItemsSelected](corelib.CheckTreeEditor.md#allitemsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L272)

___

### anyDescendantsSelected

▸ `Protected` **anyDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[anyDescendantsSelected](corelib.CheckTreeEditor.md#anydescendantsselected)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[attrs](corelib.CheckTreeEditor.md#attrs)

#### Defined in

[src/ui/datagrid/datagrid.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L205)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[bindToSlickEvents](corelib.CheckTreeEditor.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L569)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[bindToViewEvents](corelib.CheckTreeEditor.md#bindtoviewevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:669](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L669)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[booleanQuickFilter](corelib.CheckTreeEditor.md#booleanquickfilter)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[canFilterColumn](corelib.CheckTreeEditor.md#canfiltercolumn)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[canShowColumn](corelib.CheckTreeEditor.md#canshowcolumn)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[change](corelib.CheckTreeEditor.md#change)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[change](corelib.CheckTreeEditor.md#change)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[changeSelect2](corelib.CheckTreeEditor.md#changeselect2)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[changeSelect2](corelib.CheckTreeEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createFilterBar](corelib.CheckTreeEditor.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L798)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createIncludeDeletedButton](corelib.CheckTreeEditor.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L350)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createPager](corelib.CheckTreeEditor.md#createpager)

#### Defined in

[src/ui/datagrid/datagrid.ts:812](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L812)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createQuickFilters](corelib.CheckTreeEditor.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L246)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createQuickSearchInput](corelib.CheckTreeEditor.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L361)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createSlickContainer](corelib.CheckTreeEditor.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:751](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L751)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createSlickGrid](corelib.CheckTreeEditor.md#createslickgrid)

#### Defined in

[src/ui/editors/checktreeeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L116)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createToolbar](corelib.CheckTreeEditor.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L839)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createToolbarExtensions](corelib.CheckTreeEditor.md#createtoolbarextensions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L501)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createView](corelib.CheckTreeEditor.md#createview)

#### Defined in

[src/ui/datagrid/datagrid.ts:755](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L755)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[dateRangeQuickFilter](corelib.CheckTreeEditor.md#daterangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1153)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[dateTimeRangeQuickFilter](corelib.CheckTreeEditor.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1161)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[destroy](corelib.CheckTreeEditor.md#destroy)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[determineText](corelib.CheckTreeEditor.md#determinetext)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[editItem](corelib.CheckTreeEditor.md#edititem)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[editItemOfType](corelib.CheckTreeEditor.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L639)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[enableFiltering](corelib.CheckTreeEditor.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L789)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[ensureQuickFilterBar](corelib.CheckTreeEditor.md#ensurequickfilterbar)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[findQuickFilter](corelib.CheckTreeEditor.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L332)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getAddButtonCaption](corelib.CheckTreeEditor.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L627)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getButtons](corelib.CheckTreeEditor.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:497](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L497)

___

### getCascadeFromValue

▸ `Protected` **getCascadeFromValue**(`parent`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | [`Widget`](corelib.Widget.md)<`any`\> |

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumnWidthDelta](corelib.CheckTreeEditor.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L463)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumnWidthScale](corelib.CheckTreeEditor.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:467](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L467)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumns](corelib.CheckTreeEditor.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L318)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumnsKey](corelib.CheckTreeEditor.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:890](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L890)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getCssClass](corelib.CheckTreeEditor.md#getcssclass)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getCurrentSettings](corelib.CheckTreeEditor.md#getcurrentsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1417)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getDefaultSortBy](corelib.CheckTreeEditor.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L760)

___

### getDelimited

▸ `Protected` **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getDelimited](corelib.CheckTreeEditor.md#getdelimited)

#### Defined in

[src/ui/editors/checktreeeditor.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L299)

___

### getDescendantsSelected

▸ `Protected` **getDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getDescendantsSelected](corelib.CheckTreeEditor.md#getdescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L251)

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

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getEditValue](corelib.CheckTreeEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L67)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getElement](corelib.CheckTreeEditor.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1507)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getFilterStore](corelib.CheckTreeEditor.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1519)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getGrid](corelib.CheckTreeEditor.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1511)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getGridCanLoad](corelib.CheckTreeEditor.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:986](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L986)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getGridField](corelib.CheckTreeEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIdProperty](corelib.CheckTreeEditor.md#getidproperty)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIncludeColumns](corelib.CheckTreeEditor.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L697)

___

### getInitialCollapse

▸ `Protected` **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getInitialCollapse](corelib.CheckTreeEditor.md#getinitialcollapse)

#### Defined in

[src/ui/editors/checktreeeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L150)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getInitialTitle](corelib.CheckTreeEditor.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L231)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIsActiveProperty](corelib.CheckTreeEditor.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1102)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIsDeletedProperty](corelib.CheckTreeEditor.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1096](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1096)

___

### getItemCssClass

▸ `Protected` **getItemCssClass**(`item`, `index`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |
| `index` | `number` |

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItemCssClass](corelib.CheckTreeEditor.md#getitemcssclass)

#### Defined in

[src/ui/datagrid/datagrid.ts:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L400)

___

### getItemMetadata

▸ `Protected` **getItemMetadata**(`item`, `index`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |
| `index` | `number` |

#### Returns

`any`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItemMetadata](corelib.CheckTreeEditor.md#getitemmetadata)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItemText](corelib.CheckTreeEditor.md#getitemtext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L349)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItemType](corelib.CheckTreeEditor.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getItems

▸ **getItems**(): [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItems](corelib.CheckTreeEditor.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L561)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getLocalTextDbPrefix](corelib.CheckTreeEditor.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1056](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1056)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getLocalTextPrefix](corelib.CheckTreeEditor.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1068](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1068)

___

### getLookupItems

▸ `Protected` **getLookupItems**(`lookup`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `lookup` | [`Lookup`](corelib_q.Lookup.md)<`TItem`\> |

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

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPagerOptions](corelib.CheckTreeEditor.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPersistanceKey](corelib.CheckTreeEditor.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1189)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPersistanceStorage](corelib.CheckTreeEditor.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1185)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md) \| `Promise`<[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPersistedSettings](corelib.CheckTreeEditor.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1225)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPropertyItems](corelib.CheckTreeEditor.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L899)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPropertyItemsData](corelib.CheckTreeEditor.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:903](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L903)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPropertyItemsDataAsync](corelib.CheckTreeEditor.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:923](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L923)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getQuickFilters](corelib.CheckTreeEditor.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L268)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getQuickSearchFields](corelib.CheckTreeEditor.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L357)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getRowDefinition](corelib.CheckTreeEditor.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:1050](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1050)

___

### getSelectAllText

▸ `Protected` **getSelectAllText**(): `string`

#### Returns

`string`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getSelectAllText](corelib.CheckTreeEditor.md#getselectalltext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L510)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getSlickOptions](corelib.CheckTreeEditor.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L353)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getTitle](corelib.CheckTreeEditor.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getTreeItems

▸ `Protected` **getTreeItems**(): [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getTreeItems](corelib.CheckTreeEditor.md#gettreeitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L559)

___

### getView

▸ **getView**(): [`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getView](corelib.CheckTreeEditor.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1515)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getViewOptions](corelib.CheckTreeEditor.md#getviewoptions)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[get_readOnly](corelib.CheckTreeEditor.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L393)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[gridPersistanceFlags](corelib.CheckTreeEditor.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1200)

___

### init

▸ **init**(`action?`): [`CheckLookupEditor`](corelib.CheckLookupEditor.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`CheckLookupEditor`](corelib.CheckLookupEditor.md)<`TItem`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[init](corelib.CheckTreeEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initAsync](corelib.CheckTreeEditor.md#initasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L188)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initSync](corelib.CheckTreeEditor.md#initsync)

#### Defined in

[src/ui/datagrid/datagrid.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L182)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initialPopulate](corelib.CheckTreeEditor.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L471)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initialize](corelib.CheckTreeEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initializeFilterBar](corelib.CheckTreeEditor.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L493)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[internalInit](corelib.CheckTreeEditor.md#internalinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[internalRefresh](corelib.CheckTreeEditor.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:1010](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1010)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[invokeSubmitHandlers](corelib.CheckTreeEditor.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1173)

___

### isThreeStateHierarchy

▸ `Protected` **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[isThreeStateHierarchy](corelib.CheckTreeEditor.md#isthreestatehierarchy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L112)

___

### itemAt

▸ **itemAt**(`row`): [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[itemAt](corelib.CheckTreeEditor.md#itemat)

#### Defined in

[src/ui/datagrid/datagrid.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L553)

___

### itemLink

▸ `Protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../modules/corelib_slick.md#format)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../modules/corelib_slick.md#format)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[itemLink](corelib.CheckTreeEditor.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L876)

___

### itemSelectedChanged

▸ `Protected` **itemSelectedChanged**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[itemSelectedChanged](corelib.CheckTreeEditor.md#itemselectedchanged)

#### Defined in

[src/ui/editors/checktreeeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L105)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[layout](corelib.CheckTreeEditor.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L209)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[markupReady](corelib.CheckTreeEditor.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:748](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L748)

___

### moveSelectedUp

▸ `Protected` **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[moveSelectedUp](corelib.CheckTreeEditor.md#moveselectedup)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[onClick](corelib.CheckTreeEditor.md#onclick)

#### Defined in

[src/ui/editors/checktreeeditor.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L165)

___

### onViewFilter

▸ `Protected` **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[onViewFilter](corelib.CheckTreeEditor.md#onviewfilter)

#### Defined in

[src/ui/editors/checktreeeditor.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L569)

___

### onViewProcessData

▸ `Protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\> |

#### Returns

[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[onViewProcessData](corelib.CheckTreeEditor.md#onviewprocessdata)

#### Defined in

[src/ui/editors/checktreeeditor.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L154)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[onViewSubmit](corelib.CheckTreeEditor.md#onviewsubmit)

#### Defined in

[src/ui/datagrid/datagrid.ts:736](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L736)

___

### persistSettings

▸ `Protected` **persistSettings**(`flags?`): `void` \| `Promise`<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `flags?` | [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md) |

#### Returns

`void` \| `Promise`<`void`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[persistSettings](corelib.CheckTreeEditor.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1407](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1407)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[populateLock](corelib.CheckTreeEditor.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:978](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L978)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[populateUnlock](corelib.CheckTreeEditor.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L982)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[populateWhenVisible](corelib.CheckTreeEditor.md#populatewhenvisible)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[postProcessColumns](corelib.CheckTreeEditor.md#postprocesscolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L442)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[propertyItemsToSlickColumns](corelib.CheckTreeEditor.md#propertyitemstoslickcolumns)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[quickFilterChange](corelib.CheckTreeEditor.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1179)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[refresh](corelib.CheckTreeEditor.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L990)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[refreshIfNeeded](corelib.CheckTreeEditor.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.ts:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1003)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[renderContents](corelib.CheckTreeEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[resizeCanvas](corelib.CheckTreeEditor.md#resizecanvas)

#### Defined in

[src/ui/datagrid/datagrid.ts:1121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1121)

___

### restoreSettings

▸ `Protected` **restoreSettings**(`settings?`, `flags?`): `void` \| `Promise`<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings?` | [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md) |

#### Returns

`void` \| `Promise`<`void`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[restoreSettings](corelib.CheckTreeEditor.md#restoresettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1244)

___

### restoreSettingsFrom

▸ `Protected` **restoreSettingsFrom**(`settings`, `flags?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `settings` | [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md) |
| `flags?` | [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md) |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[restoreSettingsFrom](corelib.CheckTreeEditor.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.ts:1255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1255)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[rowCount](corelib.CheckTreeEditor.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L557)

___

### setAllSubTreeSelected

▸ `Protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\> |
| `selected` | `boolean` |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setAllSubTreeSelected](corelib.CheckTreeEditor.md#setallsubtreeselected)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setCriteriaParameter](corelib.CheckTreeEditor.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:712](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L712)

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

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setEditValue](corelib.CheckTreeEditor.md#seteditvalue)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setEquality](corelib.CheckTreeEditor.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L722)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setIncludeColumnsParameter](corelib.CheckTreeEditor.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L726)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setInitialSortOrder](corelib.CheckTreeEditor.md#setinitialsortorder)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setIsDisabled](corelib.CheckTreeEditor.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.ts:1014](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1014)

___

### setItems

▸ **setItems**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setItems](corelib.CheckTreeEditor.md#setitems)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setTitle](corelib.CheckTreeEditor.md#settitle)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[set_readOnly](corelib.CheckTreeEditor.md#set_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L397)

___

### sortItems

▸ `Protected` **sortItems**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[sortItems](corelib.CheckTreeEditor.md#sortitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L359)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[subDialogDataChange](corelib.CheckTreeEditor.md#subdialogdatachange)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[tryFindQuickFilter](corelib.CheckTreeEditor.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L339)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateDisabledState](corelib.CheckTreeEditor.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1117)

___

### updateFlags

▸ `Protected` **updateFlags**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateFlags](corelib.CheckTreeEditor.md#updateflags)

#### Defined in

[src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L214)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateInterface](corelib.CheckTreeEditor.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1046)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateItems](corelib.CheckTreeEditor.md#updateitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L488)

___

### updateSelectAll

▸ `Protected` **updateSelectAll**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateSelectAll](corelib.CheckTreeEditor.md#updateselectall)

#### Defined in

[src/ui/editors/checktreeeditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L208)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[useAsync](corelib.CheckTreeEditor.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L197)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[useLayoutTimer](corelib.CheckTreeEditor.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L201)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[usePager](corelib.CheckTreeEditor.md#usepager)

#### Defined in

[src/ui/datagrid/datagrid.ts:785](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L785)

___

### viewDataChanged

▸ `Protected` **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |
| `rows` | [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[viewDataChanged](corelib.CheckTreeEditor.md#viewdatachanged)

#### Defined in

[src/ui/datagrid/datagrid.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L664)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[create](corelib.CheckTreeEditor.md#create)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[elementFor](corelib.CheckTreeEditor.md#elementfor)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getWidgetName](corelib.CheckTreeEditor.md#getwidgetname)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[propertyItemToQuickFilter](corelib.CheckTreeEditor.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L278)