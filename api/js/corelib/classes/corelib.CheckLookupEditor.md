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

[src/ui/editors/checktreeeditor.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;478)

## Properties

### allColumns

• `Protected` **allColumns**: `Column`<`any`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[allColumns](corelib.CheckTreeEditor.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;103)

___

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](corelib.CascadedWidgetLink.md)<[`Widget`](corelib.Widget.md)<`any`\>\>

#### Defined in

[src/ui/editors/checktreeeditor.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;592)

___

### element

• **element**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[element](corelib.CheckTreeEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### enableUpdateItems

• `Private` **enableUpdateItems**: `boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;476)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[filterBar](corelib.CheckTreeEditor.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;99)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[idPrefix](corelib.CheckTreeEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initialSettings](corelib.CheckTreeEditor.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;105)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[openDialogsAsPanel](corelib.CheckTreeEditor.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;109)

___

### options

• `Protected` **options**: [`CheckLookupEditorOptions`](../interfaces/corelib.CheckLookupEditorOptions.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[options](corelib.CheckTreeEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[propertyItemsData](corelib.CheckTreeEditor.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;104)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[quickFiltersBar](corelib.CheckTreeEditor.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;101)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[quickFiltersDiv](corelib.CheckTreeEditor.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;100)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[restoringSettings](corelib.CheckTreeEditor.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;106)

___

### searchText

• `Private` **searchText**: `string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:475](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;475)

___

### slickContainer

• `Protected` **slickContainer**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[slickContainer](corelib.CheckTreeEditor.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;102)

___

### slickGrid

• **slickGrid**: `Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[slickGrid](corelib.CheckTreeEditor.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;108)

___

### titleDiv

• `Protected` **titleDiv**: `JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[titleDiv](corelib.CheckTreeEditor.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;97)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[toolbar](corelib.CheckTreeEditor.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;98)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[uniqueName](corelib.CheckTreeEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### view

• **view**: [`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[view](corelib.CheckTreeEditor.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;107)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[widgetName](corelib.CheckTreeEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultColumnWidthDelta](corelib.CheckTreeEditor.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;115)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultColumnWidthScale](corelib.CheckTreeEditor.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;114)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultHeaderHeight](corelib.CheckTreeEditor.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;112)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultPersistanceStorage](corelib.CheckTreeEditor.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;113)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[defaultRowHeight](corelib.CheckTreeEditor.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;111)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;628)

• `set` **cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;636)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;584)

• `set` **cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;620)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;644)

• `set` **cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;656)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;664)

• `set` **filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;672)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;680)

• `set` **filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:692](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;692)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

CheckTreeEditor.readOnly

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

CheckTreeEditor.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:1040](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1040)

___

### value

• `get` **value**(): `string`[]

#### Returns

`string`[]

#### Inherited from

CheckTreeEditor.value

#### Defined in

[src/ui/editors/checktreeeditor.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;415)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addBooleanFilter](corelib.CheckTreeEditor.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1174)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addCssClass](corelib.CheckTreeEditor.md#addcssclass)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addDateRangeFilter](corelib.CheckTreeEditor.md#adddaterangefilter)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addDateTimeRangeFilter](corelib.CheckTreeEditor.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1166)

___

### addFilterSeparator

▸ `Protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addFilterSeparator](corelib.CheckTreeEditor.md#addfilterseparator)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addQuickFilter](corelib.CheckTreeEditor.md#addquickfilter)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[addValidationRule](corelib.CheckTreeEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[afterInit](corelib.CheckTreeEditor.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;191)

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

[src/ui/editors/checktreeeditor.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;283)

___

### allItemsSelected

▸ `Protected` **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[allItemsSelected](corelib.CheckTreeEditor.md#allitemsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;272)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[attrs](corelib.CheckTreeEditor.md#attrs)

#### Defined in

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;202)

___

### bindToSlickEvents

▸ `Protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[bindToSlickEvents](corelib.CheckTreeEditor.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;578)

___

### bindToViewEvents

▸ `Protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[bindToViewEvents](corelib.CheckTreeEditor.md#bindtoviewevents)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[booleanQuickFilter](corelib.CheckTreeEditor.md#booleanquickfilter)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[canFilterColumn](corelib.CheckTreeEditor.md#canfiltercolumn)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[canShowColumn](corelib.CheckTreeEditor.md#canshowcolumn)

#### Defined in

[src/ui/datagrid/datagrid.ts:1213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1213)

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

[src/ui/editors/checktreeeditor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;517)

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

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[changeSelect2](corelib.CheckTreeEditor.md#changeselect2)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[changeSelect2](corelib.CheckTreeEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### createFilterBar

▸ `Protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createFilterBar](corelib.CheckTreeEditor.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:807](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;807)

___

### createIncludeDeletedButton

▸ `Protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createIncludeDeletedButton](corelib.CheckTreeEditor.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;360)

___

### createPager

▸ `Protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createPager](corelib.CheckTreeEditor.md#createpager)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createQuickFilters](corelib.CheckTreeEditor.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;256)

___

### createQuickSearchInput

▸ `Protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createQuickSearchInput](corelib.CheckTreeEditor.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;371)

___

### createSlickContainer

▸ `Protected` **createSlickContainer**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createSlickContainer](corelib.CheckTreeEditor.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;760)

___

### createSlickGrid

▸ `Protected` **createSlickGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createSlickGrid](corelib.CheckTreeEditor.md#createslickgrid)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createToolbar](corelib.CheckTreeEditor.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;848)

___

### createToolbarExtensions

▸ `Protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createToolbarExtensions](corelib.CheckTreeEditor.md#createtoolbarextensions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;501)

___

### createView

▸ `Protected` **createView**(): [`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[createView](corelib.CheckTreeEditor.md#createview)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[dateRangeQuickFilter](corelib.CheckTreeEditor.md#daterangequickfilter)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[dateTimeRangeQuickFilter](corelib.CheckTreeEditor.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1170)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[destroy](corelib.CheckTreeEditor.md#destroy)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[determineText](corelib.CheckTreeEditor.md#determinetext)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[editItem](corelib.CheckTreeEditor.md#edititem)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[editItemOfType](corelib.CheckTreeEditor.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;648)

___

### enableFiltering

▸ `Protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[enableFiltering](corelib.CheckTreeEditor.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;798)

___

### ensureQuickFilterBar

▸ `Protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Returns

[`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[ensureQuickFilterBar](corelib.CheckTreeEditor.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;248)

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

[src/ui/editors/checktreeeditor.ts:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;539)

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

[src/ui/datagrid/datagrid.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;342)

___

### getAddButtonCaption

▸ `Protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getAddButtonCaption](corelib.CheckTreeEditor.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;636)

___

### getButtons

▸ `Protected` **getButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getButtons](corelib.CheckTreeEditor.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:497](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;497)

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

[src/ui/editors/checktreeeditor.ts:588](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;588)

___

### getColumnWidthDelta

▸ `Protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumnWidthDelta](corelib.CheckTreeEditor.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;472)

___

### getColumnWidthScale

▸ `Protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumnWidthScale](corelib.CheckTreeEditor.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;476)

___

### getColumns

▸ `Protected` **getColumns**(): `Column`<`any`\>[]

#### Returns

`Column`<`any`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumns](corelib.CheckTreeEditor.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;318)

___

### getColumnsKey

▸ `Protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getColumnsKey](corelib.CheckTreeEditor.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;899)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getCssClass](corelib.CheckTreeEditor.md#getcssclass)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getCurrentSettings](corelib.CheckTreeEditor.md#getcurrentsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1414)

___

### getDefaultSortBy

▸ `Protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getDefaultSortBy](corelib.CheckTreeEditor.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:769](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;769)

___

### getDelimited

▸ `Protected` **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getDelimited](corelib.CheckTreeEditor.md#getdelimited)

#### Defined in

[src/ui/editors/checktreeeditor.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;299)

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

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getEditValue](corelib.CheckTreeEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;67)

___

### getElement

▸ **getElement**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getElement](corelib.CheckTreeEditor.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1504)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getFilterStore](corelib.CheckTreeEditor.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1516)

___

### getGrid

▸ **getGrid**(): `Grid`<`any`\>

#### Returns

`Grid`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getGrid](corelib.CheckTreeEditor.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1508)

___

### getGridCanLoad

▸ `Protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getGridCanLoad](corelib.CheckTreeEditor.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;995)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getGridField](corelib.CheckTreeEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIdProperty](corelib.CheckTreeEditor.md#getidproperty)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIncludeColumns](corelib.CheckTreeEditor.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;706)

___

### getInitialCollapse

▸ `Protected` **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getInitialCollapse](corelib.CheckTreeEditor.md#getinitialcollapse)

#### Defined in

[src/ui/editors/checktreeeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;150)

___

### getInitialTitle

▸ `Protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getInitialTitle](corelib.CheckTreeEditor.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;241)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIsActiveProperty](corelib.CheckTreeEditor.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1111)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getIsDeletedProperty](corelib.CheckTreeEditor.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1105)

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

[src/ui/datagrid/datagrid.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;409)

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

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItemText](corelib.CheckTreeEditor.md#getitemtext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;349)

___

### getItemType

▸ `Protected` **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItemType](corelib.CheckTreeEditor.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.ts:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;881)

___

### getItems

▸ **getItems**(): [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getItems](corelib.CheckTreeEditor.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;570)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getLocalTextDbPrefix](corelib.CheckTreeEditor.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1065](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1065)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getLocalTextPrefix](corelib.CheckTreeEditor.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1077](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1077)

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

[src/ui/editors/checktreeeditor.ts:555](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;555)

___

### getLookupKey

▸ `Protected` **getLookupKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;493)

___

### getPagerOptions

▸ `Protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/corelib_slick.PagerOptions.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPagerOptions](corelib.CheckTreeEditor.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;813)

___

### getPersistanceKey

▸ `Protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPersistanceKey](corelib.CheckTreeEditor.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1198)

___

### getPersistanceStorage

▸ `Protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/corelib.SettingStorage.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPersistanceStorage](corelib.CheckTreeEditor.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1194)

___

### getPersistedSettings

▸ `Protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Returns

[`PersistedGridSettings`](../interfaces/corelib.PersistedGridSettings.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPersistedSettings](corelib.CheckTreeEditor.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1234)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPropertyItems](corelib.CheckTreeEditor.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;908)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPropertyItemsData](corelib.CheckTreeEditor.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:912](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;912)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getPropertyItemsDataAsync](corelib.CheckTreeEditor.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;932)

___

### getQuickFilters

▸ `Protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\>[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getQuickFilters](corelib.CheckTreeEditor.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;278)

___

### getQuickSearchFields

▸ `Protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[]

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getQuickSearchFields](corelib.CheckTreeEditor.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;367)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getRowDefinition](corelib.CheckTreeEditor.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:1059](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1059)

___

### getSelectAllText

▸ `Protected` **getSelectAllText**(): `string`

#### Returns

`string`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getSelectAllText](corelib.CheckTreeEditor.md#getselectalltext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;510)

___

### getSlickOptions

▸ `Protected` **getSlickOptions**(): `GridOptions`<`any`\>

#### Returns

`GridOptions`<`any`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getSlickOptions](corelib.CheckTreeEditor.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;353)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getTitle](corelib.CheckTreeEditor.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;853)

___

### getTreeItems

▸ `Protected` **getTreeItems**(): [`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>[]

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getTreeItems](corelib.CheckTreeEditor.md#gettreeitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;559)

___

### getView

▸ **getView**(): [`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Returns

[`RemoteView`](corelib_slick.RemoteView.md)<[`CheckTreeItem`](../interfaces/corelib.CheckTreeItem.md)<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getView](corelib.CheckTreeEditor.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1512)

___

### getViewOptions

▸ `Protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getViewOptions](corelib.CheckTreeEditor.md#getviewoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;826)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;624)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;580)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:640](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;640)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;660)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;676)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[get_readOnly](corelib.CheckTreeEditor.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;393)

___

### gridPersistanceFlags

▸ `Protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/corelib.GridPersistanceFlags.md)

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[gridPersistanceFlags](corelib.CheckTreeEditor.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1209)

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

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initAsync](corelib.CheckTreeEditor.md#initasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;185)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initSync](corelib.CheckTreeEditor.md#initsync)

#### Defined in

[src/ui/datagrid/datagrid.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;179)

___

### initialPopulate

▸ `Protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initialPopulate](corelib.CheckTreeEditor.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;480)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initialize](corelib.CheckTreeEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### initializeFilterBar

▸ `Protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[initializeFilterBar](corelib.CheckTreeEditor.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;502)

___

### internalInit

▸ `Protected` **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[internalInit](corelib.CheckTreeEditor.md#internalinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;150)

___

### internalRefresh

▸ `Protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[internalRefresh](corelib.CheckTreeEditor.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1019)

___

### invokeSubmitHandlers

▸ `Protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[invokeSubmitHandlers](corelib.CheckTreeEditor.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1182)

___

### isThreeStateHierarchy

▸ `Protected` **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[isThreeStateHierarchy](corelib.CheckTreeEditor.md#isthreestatehierarchy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;112)

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

[src/ui/datagrid/datagrid.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;562)

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

[src/ui/datagrid/datagrid.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;885)

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

[src/ui/editors/checktreeeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;105)

___

### layout

▸ `Protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[layout](corelib.CheckTreeEditor.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;206)

___

### markupReady

▸ `Protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[markupReady](corelib.CheckTreeEditor.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;757)

___

### moveSelectedUp

▸ `Protected` **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[moveSelectedUp](corelib.CheckTreeEditor.md#moveselectedup)

#### Defined in

[src/ui/editors/checktreeeditor.ts:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;576)

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

[src/ui/editors/checktreeeditor.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;165)

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

[src/ui/editors/checktreeeditor.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;569)

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

[src/ui/editors/checktreeeditor.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;154)

___

### onViewSubmit

▸ `Protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[onViewSubmit](corelib.CheckTreeEditor.md#onviewsubmit)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[persistSettings](corelib.CheckTreeEditor.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1404)

___

### populateLock

▸ `Protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[populateLock](corelib.CheckTreeEditor.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:987](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;987)

___

### populateUnlock

▸ `Protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[populateUnlock](corelib.CheckTreeEditor.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:991](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;991)

___

### populateWhenVisible

▸ `Protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[populateWhenVisible](corelib.CheckTreeEditor.md#populatewhenvisible)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[postProcessColumns](corelib.CheckTreeEditor.md#postprocesscolumns)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[propertyItemsToSlickColumns](corelib.CheckTreeEditor.md#propertyitemstoslickcolumns)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[quickFilterChange](corelib.CheckTreeEditor.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1188)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[refresh](corelib.CheckTreeEditor.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;999)

___

### refreshIfNeeded

▸ `Protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[refreshIfNeeded](corelib.CheckTreeEditor.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.ts:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1012)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[renderContents](corelib.CheckTreeEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;184)

___

### resizeCanvas

▸ `Protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[resizeCanvas](corelib.CheckTreeEditor.md#resizecanvas)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[restoreSettings](corelib.CheckTreeEditor.md#restoresettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1246)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[rowCount](corelib.CheckTreeEditor.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;566)

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

[src/ui/editors/checktreeeditor.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;255)

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

[src/ui/editors/checktreeeditor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;594)

___

### setCriteriaParameter

▸ `Protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setCriteriaParameter](corelib.CheckTreeEditor.md#setcriteriaparameter)

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

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setEditValue](corelib.CheckTreeEditor.md#seteditvalue)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setEquality](corelib.CheckTreeEditor.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;731)

___

### setIncludeColumnsParameter

▸ `Protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setIncludeColumnsParameter](corelib.CheckTreeEditor.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;735)

___

### setInitialSortOrder

▸ `Protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setInitialSortOrder](corelib.CheckTreeEditor.md#setinitialsortorder)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setIsDisabled](corelib.CheckTreeEditor.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.ts:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1023)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[setTitle](corelib.CheckTreeEditor.md#settitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:861](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;861)

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

[src/ui/editors/checktreeeditor.ts:632](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;632)

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

[src/ui/editors/checktreeeditor.ts:613](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;613)

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

[src/ui/editors/checktreeeditor.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;648)

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

[src/ui/editors/checktreeeditor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;668)

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

[src/ui/editors/checktreeeditor.ts:684](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;684)

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

[src/ui/editors/checktreeeditor.ts:397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;397)

___

### sortItems

▸ `Protected` **sortItems**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[sortItems](corelib.CheckTreeEditor.md#sortitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;359)

___

### subDialogDataChange

▸ `Protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[subDialogDataChange](corelib.CheckTreeEditor.md#subdialogdatachange)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[tryFindQuickFilter](corelib.CheckTreeEditor.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;349)

___

### updateDisabledState

▸ `Protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateDisabledState](corelib.CheckTreeEditor.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1126)

___

### updateFlags

▸ `Protected` **updateFlags**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateFlags](corelib.CheckTreeEditor.md#updateflags)

#### Defined in

[src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;214)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateInterface](corelib.CheckTreeEditor.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:1055](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;1055)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateItems](corelib.CheckTreeEditor.md#updateitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;488)

___

### updateSelectAll

▸ `Protected` **updateSelectAll**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[updateSelectAll](corelib.CheckTreeEditor.md#updateselectall)

#### Defined in

[src/ui/editors/checktreeeditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#line&#x3D;208)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[useAsync](corelib.CheckTreeEditor.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;194)

___

### useLayoutTimer

▸ `Protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[useLayoutTimer](corelib.CheckTreeEditor.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;198)

___

### usePager

▸ `Protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](corelib.CheckTreeEditor.md).[usePager](corelib.CheckTreeEditor.md#usepager)

#### Defined in

[src/ui/datagrid/datagrid.ts:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;794)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[create](corelib.CheckTreeEditor.md#create)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[elementFor](corelib.CheckTreeEditor.md#elementfor)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[getWidgetName](corelib.CheckTreeEditor.md#getwidgetname)

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

[CheckTreeEditor](corelib.CheckTreeEditor.md).[propertyItemToQuickFilter](corelib.CheckTreeEditor.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#line&#x3D;288)
