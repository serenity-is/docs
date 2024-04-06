[@serenity-is/corelib](../README.md) / CheckLookupEditor

# Class: CheckLookupEditor\<TItem, P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | extends [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> = `any` |
| `P` | extends [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) = [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) |

## Hierarchy

- [`CheckTreeEditor`](CheckTreeEditor.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>, `P`\>

  ↳ **`CheckLookupEditor`**

## Table of contents

### Constructors

- [constructor](CheckLookupEditor.md#constructor)

### Properties

- [allColumns](CheckLookupEditor.md#allcolumns)
- [cascadeLink](CheckLookupEditor.md#cascadelink)
- [domNode](CheckLookupEditor.md#domnode)
- [enableUpdateItems](CheckLookupEditor.md#enableupdateitems)
- [filterBar](CheckLookupEditor.md#filterbar)
- [idPrefix](CheckLookupEditor.md#idprefix)
- [initialSettings](CheckLookupEditor.md#initialsettings)
- [lookupChangeUnbind](CheckLookupEditor.md#lookupchangeunbind)
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
- [defaultColumnWidthDelta](CheckLookupEditor.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](CheckLookupEditor.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](CheckLookupEditor.md#defaultheaderheight)
- [defaultPersistanceStorage](CheckLookupEditor.md#defaultpersistancestorage)
- [defaultRowHeight](CheckLookupEditor.md#defaultrowheight)
- [typeInfo](CheckLookupEditor.md#typeinfo)

### Accessors

- [cascadeField](CheckLookupEditor.md#cascadefield)
- [cascadeFrom](CheckLookupEditor.md#cascadefrom)
- [cascadeValue](CheckLookupEditor.md#cascadevalue)
- [element](CheckLookupEditor.md#element)
- [filterField](CheckLookupEditor.md#filterfield)
- [filterValue](CheckLookupEditor.md#filtervalue)
- [props](CheckLookupEditor.md#props)
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
- [getCustomAttribute](CheckLookupEditor.md#getcustomattribute)
- [getDefaultSortBy](CheckLookupEditor.md#getdefaultsortby)
- [getDelimited](CheckLookupEditor.md#getdelimited)
- [getDescendantsSelected](CheckLookupEditor.md#getdescendantsselected)
- [getEditValue](CheckLookupEditor.md#geteditvalue)
- [getElement](CheckLookupEditor.md#getelement)
- [getFieldElement](CheckLookupEditor.md#getfieldelement)
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
- [initialPopulate](CheckLookupEditor.md#initialpopulate)
- [initializeFilterBar](CheckLookupEditor.md#initializefilterbar)
- [internalInit](CheckLookupEditor.md#internalinit)
- [internalRefresh](CheckLookupEditor.md#internalrefresh)
- [internalRenderContents](CheckLookupEditor.md#internalrendercontents)
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
- [propertyItemsReady](CheckLookupEditor.md#propertyitemsready)
- [propertyItemsToSlickColumns](CheckLookupEditor.md#propertyitemstoslickcolumns)
- [quickFilterChange](CheckLookupEditor.md#quickfilterchange)
- [refresh](CheckLookupEditor.md#refresh)
- [refreshIfNeeded](CheckLookupEditor.md#refreshifneeded)
- [render](CheckLookupEditor.md#render)
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
- [syncOrAsyncThen](CheckLookupEditor.md#syncorasyncthen)
- [tryFindQuickFilter](CheckLookupEditor.md#tryfindquickfilter)
- [updateDisabledState](CheckLookupEditor.md#updatedisabledstate)
- [updateFlags](CheckLookupEditor.md#updateflags)
- [updateInterface](CheckLookupEditor.md#updateinterface)
- [updateItems](CheckLookupEditor.md#updateitems)
- [updateSelectAll](CheckLookupEditor.md#updateselectall)
- [useAsync](CheckLookupEditor.md#useasync)
- [useIdPrefix](CheckLookupEditor.md#useidprefix)
- [useLayoutTimer](CheckLookupEditor.md#uselayouttimer)
- [usePager](CheckLookupEditor.md#usepager)
- [viewDataChanged](CheckLookupEditor.md#viewdatachanged)
- [wrapFormatterWithEditLink](CheckLookupEditor.md#wrapformatterwitheditlink)
- [create](CheckLookupEditor.md#create)
- [createDefaultElement](CheckLookupEditor.md#createdefaultelement)
- [getWidgetName](CheckLookupEditor.md#getwidgetname)
- [propertyItemToQuickFilter](CheckLookupEditor.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new CheckLookupEditor**\<`TItem`, `P`\>(`props`): [`CheckLookupEditor`](CheckLookupEditor.md)\<`TItem`, `P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | extends [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> = `any` |
| `P` | extends [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) = [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`CheckLookupEditor`](CheckLookupEditor.md)\<`TItem`, `P`\>

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[constructor](CheckTreeEditor.md#constructor)

#### Defined in

[src/ui/editors/checktreeeditor.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L481)

## Properties

### allColumns

• `Protected` **allColumns**: `Column`\<`any`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[allColumns](CheckTreeEditor.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L75)

___

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Defined in

[src/ui/editors/checktreeeditor.ts:602](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L602)

___

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[domNode](CheckTreeEditor.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### enableUpdateItems

• `Private` **enableUpdateItems**: `boolean`

#### Defined in

[src/ui/editors/checktreeeditor.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L478)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)\<{}\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[filterBar](CheckTreeEditor.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L71)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[idPrefix](CheckTreeEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initialSettings](CheckTreeEditor.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L77)

___

### lookupChangeUnbind

• `Private` **lookupChangeUnbind**: `any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:479](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L479)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[openDialogsAsPanel](CheckTreeEditor.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L81)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[options](CheckTreeEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemsData](CheckTreeEditor.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L76)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[quickFiltersBar](CheckTreeEditor.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L73)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[quickFiltersDiv](CheckTreeEditor.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L72)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[restoringSettings](CheckTreeEditor.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L78)

___

### searchText

• `Private` **searchText**: `string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:477](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L477)

___

### slickContainer

• `Protected` **slickContainer**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[slickContainer](CheckTreeEditor.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L74)

___

### slickGrid

• **slickGrid**: `Grid`\<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[slickGrid](CheckTreeEditor.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L80)

___

### titleDiv

• `Protected` **titleDiv**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[titleDiv](CheckTreeEditor.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L69)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[toolbar](CheckTreeEditor.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L70)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[uniqueName](CheckTreeEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### view

• **view**: [`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[view](CheckTreeEditor.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L79)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultColumnWidthDelta](CheckTreeEditor.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L87)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultColumnWidthScale](CheckTreeEditor.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L86)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultHeaderHeight](CheckTreeEditor.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L84)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultPersistanceStorage](CheckTreeEditor.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L85)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[defaultRowHeight](CheckTreeEditor.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L83)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[typeInfo](CheckTreeEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:638](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L638)

• `set` **cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L646)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L594)

• `set` **cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L630)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:654](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L654)

• `set` **cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L666)

___

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

CheckTreeEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:674](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L674)

• `set` **filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L682)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:690](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L690)

• `set` **filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L702)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

CheckTreeEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

CheckTreeEditor.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:976](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L976)

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

[src/ui/datagrid/datagrid.ts:980](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L980)

___

### value

• `get` **value**(): `string`[]

#### Returns

`string`[]

#### Inherited from

CheckTreeEditor.value

#### Defined in

[src/ui/editors/checktreeeditor.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L417)

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

[src/ui/editors/checktreeeditor.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L456)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addBooleanFilter](CheckTreeEditor.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1111)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addCssClass](CheckTreeEditor.md#addcssclass)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addDateRangeFilter](CheckTreeEditor.md#adddaterangefilter)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addDateTimeRangeFilter](CheckTreeEditor.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1103)

___

### addFilterSeparator

▸ **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addFilterSeparator](CheckTreeEditor.md#addfilterseparator)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[addQuickFilter](CheckTreeEditor.md#addquickfilter)

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

[CheckTreeEditor](CheckTreeEditor.md).[addValidationRule](CheckTreeEditor.md#addvalidationrule)

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

[CheckTreeEditor](CheckTreeEditor.md).[addValidationRule](CheckTreeEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### afterInit

▸ **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[afterInit](CheckTreeEditor.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L154)

___

### allDescendantsSelected

▸ **allDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[allDescendantsSelected](CheckTreeEditor.md#alldescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L285)

___

### allItemsSelected

▸ **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[allItemsSelected](CheckTreeEditor.md#allitemsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L274)

___

### anyDescendantsSelected

▸ **anyDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[anyDescendantsSelected](CheckTreeEditor.md#anydescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L305)

___

### bindToSlickEvents

▸ **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[bindToSlickEvents](CheckTreeEditor.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L519)

___

### bindToViewEvents

▸ **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[bindToViewEvents](CheckTreeEditor.md#bindtoviewevents)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[booleanQuickFilter](CheckTreeEditor.md#booleanquickfilter)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[canFilterColumn](CheckTreeEditor.md#canfiltercolumn)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[canShowColumn](CheckTreeEditor.md#canshowcolumn)

#### Defined in

[src/ui/datagrid/datagrid.ts:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1150)

___

### cascadeItems

▸ **cascadeItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L528)

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

[CheckTreeEditor](CheckTreeEditor.md).[change](CheckTreeEditor.md#change)

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

[CheckTreeEditor](CheckTreeEditor.md).[changeSelect2](CheckTreeEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### createFilterBar

▸ **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createFilterBar](CheckTreeEditor.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L747)

___

### createIncludeDeletedButton

▸ **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createIncludeDeletedButton](CheckTreeEditor.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L303)

___

### createPager

▸ **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createPager](CheckTreeEditor.md#createpager)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createQuickFilters](CheckTreeEditor.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L202)

___

### createQuickSearchInput

▸ **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createQuickSearchInput](CheckTreeEditor.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L312)

___

### createSlickContainer

▸ **createSlickContainer**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createSlickContainer](CheckTreeEditor.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L701)

___

### createSlickGrid

▸ **createSlickGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createSlickGrid](CheckTreeEditor.md#createslickgrid)

#### Defined in

[src/ui/editors/checktreeeditor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L119)

___

### createToolbar

▸ **createToolbar**(`buttons`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `buttons` | [`ToolButton`](../interfaces/ToolButton.md)[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createToolbar](CheckTreeEditor.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L788)

___

### createToolbarExtensions

▸ **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[createToolbarExtensions](CheckTreeEditor.md#createtoolbarextensions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L512)

___

### createView

▸ **createView**(): [`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createView](CheckTreeEditor.md#createview)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[dateRangeQuickFilter](CheckTreeEditor.md#daterangequickfilter)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[dateTimeRangeQuickFilter](CheckTreeEditor.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1107)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[destroy](CheckTreeEditor.md#destroy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:490](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L490)

___

### determineText

▸ **determineText**(`getKey`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `getKey` | (`prefix`: `string`) => `string` |

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[determineText](CheckTreeEditor.md#determinetext)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[editItem](CheckTreeEditor.md#edititem)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[editItemOfType](CheckTreeEditor.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.ts:589](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L589)

___

### enableFiltering

▸ **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[enableFiltering](CheckTreeEditor.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:739](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L739)

___

### ensureQuickFilterBar

▸ **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[ensureQuickFilterBar](CheckTreeEditor.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

___

### filterItems

▸ **filterItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L550)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[findQuickFilter](CheckTreeEditor.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L289)

___

### getAddButtonCaption

▸ **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getAddButtonCaption](CheckTreeEditor.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.ts:577](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L577)

___

### getButtons

▸ **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[getButtons](CheckTreeEditor.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L508)

___

### getCascadeFromValue

▸ **getCascadeFromValue**(`parent`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | [`Widget`](Widget.md)\<`any`\> |

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L598)

___

### getColumnWidthDelta

▸ **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumnWidthDelta](CheckTreeEditor.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L413)

___

### getColumnWidthScale

▸ **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumnWidthScale](CheckTreeEditor.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L417)

___

### getColumns

▸ **getColumns**(): `Column`\<`any`\>[]

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumns](CheckTreeEditor.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:320](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L320)

___

### getColumnsKey

▸ **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getColumnsKey](CheckTreeEditor.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getCssClass](CheckTreeEditor.md#getcssclass)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getCurrentSettings](CheckTreeEditor.md#getcurrentsettings)

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

[CheckTreeEditor](CheckTreeEditor.md).[getCustomAttribute](CheckTreeEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDefaultSortBy

▸ **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getDefaultSortBy](CheckTreeEditor.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L710)

___

### getDelimited

▸ **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getDelimited](CheckTreeEditor.md#getdelimited)

#### Defined in

[src/ui/editors/checktreeeditor.ts:301](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L301)

___

### getDescendantsSelected

▸ **getDescendantsSelected**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getDescendantsSelected](CheckTreeEditor.md#getdescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L253)

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

[src/ui/editors/checktreeeditor.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L70)

___

### getElement

▸ **getElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getElement](CheckTreeEditor.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1453)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getFieldElement](CheckTreeEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getFilterStore](CheckTreeEditor.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1465)

___

### getGrid

▸ **getGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getGrid](CheckTreeEditor.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1457)

___

### getGridCanLoad

▸ **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getGridCanLoad](CheckTreeEditor.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L935)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getGridField](CheckTreeEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getIdProperty

▸ **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIdProperty](CheckTreeEditor.md#getidproperty)

#### Defined in

[src/ui/editors/checktreeeditor.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L41)

___

### getIncludeColumns

▸ **getIncludeColumns**(`include`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `include` | `Object` |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIncludeColumns](CheckTreeEditor.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:647](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L647)

___

### getInitialCollapse

▸ **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getInitialCollapse](CheckTreeEditor.md#getinitialcollapse)

#### Defined in

[src/ui/editors/checktreeeditor.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L152)

___

### getInitialTitle

▸ **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getInitialTitle](CheckTreeEditor.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L187)

___

### getIsActiveProperty

▸ **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIsActiveProperty](CheckTreeEditor.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1048)

___

### getIsDeletedProperty

▸ **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getIsDeletedProperty](CheckTreeEditor.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1042](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1042)

___

### getItemCssClass

▸ **getItemCssClass**(`item`, `index`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |
| `index` | `number` |

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemCssClass](CheckTreeEditor.md#getitemcssclass)

#### Defined in

[src/ui/datagrid/datagrid.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L351)

___

### getItemMetadata

▸ **getItemMetadata**(`item`, `index`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |
| `index` | `number` |

#### Returns

`any`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemMetadata](CheckTreeEditor.md#getitemmetadata)

#### Defined in

[src/ui/datagrid/datagrid.ts:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L384)

___

### getItemText

▸ **getItemText**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`\<`any`\> |

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemText](CheckTreeEditor.md#getitemtext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L351)

___

### getItemType

▸ **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItemType](CheckTreeEditor.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.ts:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L826)

___

### getItems

▸ **getItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getItems](CheckTreeEditor.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L511)

___

### getLocalTextDbPrefix

▸ **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getLocalTextDbPrefix](CheckTreeEditor.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1005](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1005)

___

### getLocalTextPrefix

▸ **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getLocalTextPrefix](CheckTreeEditor.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1017](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1017)

___

### getLookupItems

▸ **getLookupItems**(`lookup`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `lookup` | [`Lookup`](Lookup.md)\<`TItem`\> |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L566)

___

### getLookupKey

▸ **getLookupKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L504)

___

### getPagerOptions

▸ **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPagerOptions](CheckTreeEditor.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:754](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L754)

___

### getPersistanceKey

▸ **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPersistanceKey](CheckTreeEditor.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1135)

___

### getPersistanceStorage

▸ **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPersistanceStorage](CheckTreeEditor.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1131)

___

### getPersistedSettings

▸ **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPersistedSettings](CheckTreeEditor.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1171)

___

### getPropertyItems

▸ **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPropertyItems](CheckTreeEditor.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L848)

___

### getPropertyItemsData

▸ **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPropertyItemsData](CheckTreeEditor.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L852)

___

### getPropertyItemsDataAsync

▸ **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getPropertyItemsDataAsync](CheckTreeEditor.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getQuickFilters

▸ **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getQuickFilters](CheckTreeEditor.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L225)

___

### getQuickSearchFields

▸ **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getQuickSearchFields](CheckTreeEditor.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L308)

___

### getRowDefinition

▸ **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getRowDefinition](CheckTreeEditor.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L999)

___

### getSelectAllText

▸ **getSelectAllText**(): `string`

#### Returns

`string`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[getSelectAllText](CheckTreeEditor.md#getselectalltext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L521)

___

### getSlickOptions

▸ **getSlickOptions**(): `GridOptions`\<`any`\>

#### Returns

`GridOptions`\<`any`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getSlickOptions](CheckTreeEditor.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L355)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getTitle](CheckTreeEditor.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:796](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L796)

___

### getTreeItems

▸ **getTreeItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[getTreeItems](CheckTreeEditor.md#gettreeitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L570)

___

### getView

▸ **getView**(): [`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getView](CheckTreeEditor.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1461)

___

### getViewOptions

▸ **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[getViewOptions](CheckTreeEditor.md#getviewoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:766](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L766)

___

### get\_cascadeField

▸ **get_cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:634](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L634)

___

### get\_cascadeFrom

▸ **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L590)

___

### get\_cascadeValue

▸ **get_cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L650)

___

### get\_filterField

▸ **get_filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:670](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L670)

___

### get\_filterValue

▸ **get_filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L686)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[get_readOnly](CheckTreeEditor.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L395)

___

### gridPersistanceFlags

▸ **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[gridPersistanceFlags](CheckTreeEditor.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1146)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[init](CheckTreeEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initialPopulate

▸ **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initialPopulate](CheckTreeEditor.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L421)

___

### initializeFilterBar

▸ **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[initializeFilterBar](CheckTreeEditor.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L443)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[internalInit](CheckTreeEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRefresh

▸ **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[internalRefresh](CheckTreeEditor.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:959](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L959)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[internalRenderContents](CheckTreeEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### invokeSubmitHandlers

▸ **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[invokeSubmitHandlers](CheckTreeEditor.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1119)

___

### isThreeStateHierarchy

▸ **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[isThreeStateHierarchy](CheckTreeEditor.md#isthreestatehierarchy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L115)

___

### itemAt

▸ **itemAt**(`row`): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[itemAt](CheckTreeEditor.md#itemat)

#### Defined in

[src/ui/datagrid/datagrid.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L503)

___

### itemLink

▸ **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../README.md#format)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | [`Format`](../README.md#format)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\> | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`\<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../README.md#format)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[itemLink](CheckTreeEditor.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:830](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L830)

___

### itemSelectedChanged

▸ **itemSelectedChanged**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[itemSelectedChanged](CheckTreeEditor.md#itemselectedchanged)

#### Defined in

[src/ui/editors/checktreeeditor.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L108)

___

### layout

▸ **layout**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[layout](CheckTreeEditor.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L165)

___

### markupReady

▸ **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[markupReady](CheckTreeEditor.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L698)

___

### moveSelectedUp

▸ **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[moveSelectedUp](CheckTreeEditor.md#moveselectedup)

#### Defined in

[src/ui/editors/checktreeeditor.ts:586](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L586)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[onClick](CheckTreeEditor.md#onclick)

#### Defined in

[src/ui/editors/checktreeeditor.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L167)

___

### onViewFilter

▸ **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |

#### Returns

`boolean`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[onViewFilter](CheckTreeEditor.md#onviewfilter)

#### Defined in

[src/ui/editors/checktreeeditor.ts:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L580)

___

### onViewProcessData

▸ **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\> |

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[onViewProcessData](CheckTreeEditor.md#onviewprocessdata)

#### Defined in

[src/ui/editors/checktreeeditor.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L156)

___

### onViewSubmit

▸ **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[onViewSubmit](CheckTreeEditor.md#onviewsubmit)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[persistSettings](CheckTreeEditor.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1353)

___

### populateLock

▸ **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[populateLock](CheckTreeEditor.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:927](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L927)

___

### populateUnlock

▸ **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[populateUnlock](CheckTreeEditor.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L931)

___

### populateWhenVisible

▸ **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[populateWhenVisible](CheckTreeEditor.md#populatewhenvisible)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[postProcessColumns](CheckTreeEditor.md#postprocesscolumns)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemsReady](CheckTreeEditor.md#propertyitemsready)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemsToSlickColumns](CheckTreeEditor.md#propertyitemstoslickcolumns)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[quickFilterChange](CheckTreeEditor.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1125)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[refresh](CheckTreeEditor.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L939)

___

### refreshIfNeeded

▸ **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[refreshIfNeeded](CheckTreeEditor.md#refreshifneeded)

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

[CheckTreeEditor](CheckTreeEditor.md).[render](CheckTreeEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[renderContents](CheckTreeEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

___

### resizeCanvas

▸ **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[resizeCanvas](CheckTreeEditor.md#resizecanvas)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[restoreSettings](CheckTreeEditor.md#restoresettings)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[restoreSettingsFrom](CheckTreeEditor.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.ts:1201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1201)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[rowCount](CheckTreeEditor.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L507)

___

### setAllSubTreeSelected

▸ **setAllSubTreeSelected**(`item`, `selected`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> |
| `selected` | `boolean` |

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setAllSubTreeSelected](CheckTreeEditor.md#setallsubtreeselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L257)

___

### setCascadeFrom

▸ **setCascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:604](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L604)

___

### setCriteriaParameter

▸ **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setCriteriaParameter](CheckTreeEditor.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L662)

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

[src/ui/editors/checktreeeditor.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L77)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setEquality](CheckTreeEditor.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L672)

___

### setIncludeColumnsParameter

▸ **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setIncludeColumnsParameter](CheckTreeEditor.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L676)

___

### setInitialSortOrder

▸ **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setInitialSortOrder](CheckTreeEditor.md#setinitialsortorder)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setIsDisabled](CheckTreeEditor.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.ts:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L963)

___

### setItems

▸ **setItems**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setItems](CheckTreeEditor.md#setitems)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[setTitle](CheckTreeEditor.md#settitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

___

### set\_cascadeField

▸ **set_cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L642)

___

### set\_cascadeFrom

▸ **set_cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L623)

___

### set\_cascadeValue

▸ **set_cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:658](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L658)

___

### set\_filterField

▸ **set_filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L678)

___

### set\_filterValue

▸ **set_filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L694)

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

[src/ui/editors/checktreeeditor.ts:399](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L399)

___

### sortItems

▸ **sortItems**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[sortItems](CheckTreeEditor.md#sortitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L361)

___

### subDialogDataChange

▸ **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[subDialogDataChange](CheckTreeEditor.md#subdialogdatachange)

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

[CheckTreeEditor](CheckTreeEditor.md).[syncOrAsyncThen](CheckTreeEditor.md#syncorasyncthen)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[tryFindQuickFilter](CheckTreeEditor.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L296)

___

### updateDisabledState

▸ **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateDisabledState](CheckTreeEditor.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1063](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1063)

___

### updateFlags

▸ **updateFlags**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateFlags](CheckTreeEditor.md#updateflags)

#### Defined in

[src/ui/editors/checktreeeditor.ts:216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L216)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateInterface](CheckTreeEditor.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L995)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[CheckTreeEditor](CheckTreeEditor.md).[updateItems](CheckTreeEditor.md#updateitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L499)

___

### updateSelectAll

▸ **updateSelectAll**(): `void`

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[updateSelectAll](CheckTreeEditor.md#updateselectall)

#### Defined in

[src/ui/editors/checktreeeditor.ts:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L210)

___

### useAsync

▸ **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[useAsync](CheckTreeEditor.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L157)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[useIdPrefix](CheckTreeEditor.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### useLayoutTimer

▸ **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[useLayoutTimer](CheckTreeEditor.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L161)

___

### usePager

▸ **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[usePager](CheckTreeEditor.md#usepager)

#### Defined in

[src/ui/datagrid/datagrid.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L735)

___

### viewDataChanged

▸ **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |
| `rows` | [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[viewDataChanged](CheckTreeEditor.md#viewdatachanged)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[wrapFormatterWithEditLink](CheckTreeEditor.md#wrapformatterwitheditlink)

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

[CheckTreeEditor](CheckTreeEditor.md).[create](CheckTreeEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[createDefaultElement](CheckTreeEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/checktreeeditor.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L30)

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

[CheckTreeEditor](CheckTreeEditor.md).[getWidgetName](CheckTreeEditor.md#getwidgetname)

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

#### Inherited from

[CheckTreeEditor](CheckTreeEditor.md).[propertyItemToQuickFilter](CheckTreeEditor.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L235)
