[@serenity-is/corelib](../README.md) / EntityGrid

# Class: EntityGrid\<TItem, P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `TItem` |
| `P` | {} |

## Hierarchy

- [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

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
- [domNode](EntityGrid.md#domnode)
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
- [defaultColumnWidthDelta](EntityGrid.md#defaultcolumnwidthdelta)
- [defaultColumnWidthScale](EntityGrid.md#defaultcolumnwidthscale)
- [defaultHeaderHeight](EntityGrid.md#defaultheaderheight)
- [defaultPersistanceStorage](EntityGrid.md#defaultpersistancestorage)
- [defaultRowHeight](EntityGrid.md#defaultrowheight)
- [typeInfo](EntityGrid.md#typeinfo)

### Accessors

- [element](EntityGrid.md#element)
- [props](EntityGrid.md#props)
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
- [getCustomAttribute](EntityGrid.md#getcustomattribute)
- [getDefaultSortBy](EntityGrid.md#getdefaultsortby)
- [getDialogOptions](EntityGrid.md#getdialogoptions)
- [getDialogOptionsFor](EntityGrid.md#getdialogoptionsfor)
- [getDialogType](EntityGrid.md#getdialogtype)
- [getDialogTypeFor](EntityGrid.md#getdialogtypefor)
- [getDisplayName](EntityGrid.md#getdisplayname)
- [getElement](EntityGrid.md#getelement)
- [getEntityType](EntityGrid.md#getentitytype)
- [getFieldElement](EntityGrid.md#getfieldelement)
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
- [initDialog](EntityGrid.md#initdialog)
- [initEntityDialog](EntityGrid.md#initentitydialog)
- [initialPopulate](EntityGrid.md#initialpopulate)
- [initializeFilterBar](EntityGrid.md#initializefilterbar)
- [internalInit](EntityGrid.md#internalinit)
- [internalRefresh](EntityGrid.md#internalrefresh)
- [internalRenderContents](EntityGrid.md#internalrendercontents)
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
- [propertyItemsReady](EntityGrid.md#propertyitemsready)
- [propertyItemsToSlickColumns](EntityGrid.md#propertyitemstoslickcolumns)
- [quickFilterChange](EntityGrid.md#quickfilterchange)
- [refresh](EntityGrid.md#refresh)
- [refreshIfNeeded](EntityGrid.md#refreshifneeded)
- [render](EntityGrid.md#render)
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
- [syncOrAsyncThen](EntityGrid.md#syncorasyncthen)
- [transferDialogReadOnly](EntityGrid.md#transferdialogreadonly)
- [tryFindQuickFilter](EntityGrid.md#tryfindquickfilter)
- [updateDisabledState](EntityGrid.md#updatedisabledstate)
- [updateInterface](EntityGrid.md#updateinterface)
- [useAsync](EntityGrid.md#useasync)
- [useIdPrefix](EntityGrid.md#useidprefix)
- [useLayoutTimer](EntityGrid.md#uselayouttimer)
- [usePager](EntityGrid.md#usepager)
- [viewDataChanged](EntityGrid.md#viewdatachanged)
- [wrapFormatterWithEditLink](EntityGrid.md#wrapformatterwitheditlink)
- [create](EntityGrid.md#create)
- [createDefaultElement](EntityGrid.md#createdefaultelement)
- [getWidgetName](EntityGrid.md#getwidgetname)
- [propertyItemToQuickFilter](EntityGrid.md#propertyitemtoquickfilter)

## Constructors

### constructor

• **new EntityGrid**\<`TItem`, `P`\>(`props`): [`EntityGrid`](EntityGrid.md)\<`TItem`, `P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `TItem` |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`EntityGrid`](EntityGrid.md)\<`TItem`, `P`\>

#### Overrides

[DataGrid](DataGrid.md).[constructor](DataGrid.md#constructor)

#### Defined in

[src/ui/datagrid/entitygrid.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L18)

## Properties

### \_dialogType

• `Private` **\_dialogType**: `any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L358)

___

### \_displayName

• `Private` **\_displayName**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L130)

___

### \_entityType

• `Private` **\_entityType**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L100)

___

### \_itemName

• `Private` **\_itemName**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L150)

___

### \_service

• `Private` **\_service**: `string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L250)

___

### allColumns

• `Protected` **allColumns**: `Column`\<`any`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[allColumns](DataGrid.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L75)

___

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[DataGrid](DataGrid.md).[domNode](DataGrid.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### filterBar

• `Protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)\<{}\>

#### Inherited from

[DataGrid](DataGrid.md).[filterBar](DataGrid.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L71)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[DataGrid](DataGrid.md).[idPrefix](DataGrid.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### initialSettings

• `Protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[DataGrid](DataGrid.md).[initialSettings](DataGrid.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L77)

___

### openDialogsAsPanel

• **openDialogsAsPanel**: `boolean`

#### Inherited from

[DataGrid](DataGrid.md).[openDialogsAsPanel](DataGrid.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L81)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[DataGrid](DataGrid.md).[options](DataGrid.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[DataGrid](DataGrid.md).[propertyItemsData](DataGrid.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L76)

___

### quickFiltersBar

• `Protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[quickFiltersBar](DataGrid.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L73)

___

### quickFiltersDiv

• `Protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[DataGrid](DataGrid.md).[quickFiltersDiv](DataGrid.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L72)

___

### restoringSettings

• `Protected` **restoringSettings**: `number` = `0`

#### Inherited from

[DataGrid](DataGrid.md).[restoringSettings](DataGrid.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L78)

___

### slickContainer

• `Protected` **slickContainer**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[DataGrid](DataGrid.md).[slickContainer](DataGrid.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L74)

___

### slickGrid

• **slickGrid**: `Grid`\<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[slickGrid](DataGrid.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L80)

___

### titleDiv

• `Protected` **titleDiv**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[DataGrid](DataGrid.md).[titleDiv](DataGrid.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L69)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[toolbar](DataGrid.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L70)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[DataGrid](DataGrid.md).[uniqueName](DataGrid.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### view

• **view**: [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[view](DataGrid.md#view)

#### Defined in

[src/ui/datagrid/datagrid.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L79)

___

### defaultColumnWidthDelta

▪ `Static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultColumnWidthDelta](DataGrid.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L87)

___

### defaultColumnWidthScale

▪ `Static` **defaultColumnWidthScale**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultColumnWidthScale](DataGrid.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L86)

___

### defaultHeaderHeight

▪ `Static` **defaultHeaderHeight**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultHeaderHeight](DataGrid.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L84)

___

### defaultPersistanceStorage

▪ `Static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[DataGrid](DataGrid.md).[defaultPersistanceStorage](DataGrid.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L85)

___

### defaultRowHeight

▪ `Static` **defaultRowHeight**: `number`

#### Inherited from

[DataGrid](DataGrid.md).[defaultRowHeight](DataGrid.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L83)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[DataGrid](DataGrid.md).[typeInfo](DataGrid.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

DataGrid.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

DataGrid.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

DataGrid.readOnly

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

DataGrid.readOnly

#### Defined in

[src/ui/datagrid/datagrid.ts:980](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L980)

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

[DataGrid](DataGrid.md).[addBooleanFilter](DataGrid.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1111)

___

### addButtonClick

▸ **addButtonClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L208)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[addCssClass](DataGrid.md#addcssclass)

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

[DataGrid](DataGrid.md).[addDateRangeFilter](DataGrid.md#adddaterangefilter)

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

[DataGrid](DataGrid.md).[addDateTimeRangeFilter](DataGrid.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1103)

___

### addFilterSeparator

▸ **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[addFilterSeparator](DataGrid.md#addfilterseparator)

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

[DataGrid](DataGrid.md).[addQuickFilter](DataGrid.md#addquickfilter)

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

[DataGrid](DataGrid.md).[addValidationRule](DataGrid.md#addvalidationrule)

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

[DataGrid](DataGrid.md).[addValidationRule](DataGrid.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### afterInit

▸ **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[afterInit](DataGrid.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L154)

___

### bindToSlickEvents

▸ **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[bindToSlickEvents](DataGrid.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L519)

___

### bindToViewEvents

▸ **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[bindToViewEvents](DataGrid.md#bindtoviewevents)

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

[DataGrid](DataGrid.md).[booleanQuickFilter](DataGrid.md#booleanquickfilter)

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

[DataGrid](DataGrid.md).[canFilterColumn](DataGrid.md#canfiltercolumn)

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

[DataGrid](DataGrid.md).[canShowColumn](DataGrid.md#canshowcolumn)

#### Defined in

[src/ui/datagrid/datagrid.ts:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1150)

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

[DataGrid](DataGrid.md).[change](DataGrid.md#change)

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

[DataGrid](DataGrid.md).[changeSelect2](DataGrid.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### createEntityDialog

▸ **createEntityDialog**(`itemType`, `callback?`): [`Widget`](Widget.md)\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `callback?` | (`dlg`: [`Widget`](Widget.md)\<`any`\>) => `void` |

#### Returns

[`Widget`](Widget.md)\<`any`\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L328)

___

### createFilterBar

▸ **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createFilterBar](DataGrid.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L747)

___

### createIncludeDeletedButton

▸ **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createIncludeDeletedButton](DataGrid.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L303)

___

### createPager

▸ **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createPager](DataGrid.md#createpager)

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

[DataGrid](DataGrid.md).[createQuickFilters](DataGrid.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L202)

___

### createQuickSearchInput

▸ **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[createQuickSearchInput](DataGrid.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.ts:312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L312)

___

### createSlickContainer

▸ **createSlickContainer**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[DataGrid](DataGrid.md).[createSlickContainer](DataGrid.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L701)

___

### createSlickGrid

▸ **createSlickGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[createSlickGrid](DataGrid.md#createslickgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L459)

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

[DataGrid](DataGrid.md).[createToolbar](DataGrid.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L788)

___

### createToolbarExtensions

▸ **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[DataGrid](DataGrid.md).[createToolbarExtensions](DataGrid.md#createtoolbarextensions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L81)

___

### createView

▸ **createView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[createView](DataGrid.md#createview)

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

[DataGrid](DataGrid.md).[dateRangeQuickFilter](DataGrid.md#daterangequickfilter)

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

[DataGrid](DataGrid.md).[dateTimeRangeQuickFilter](DataGrid.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1107)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[DataGrid](DataGrid.md).[destroy](DataGrid.md#destroy)

#### Defined in

[src/ui/datagrid/entitygrid.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L24)

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

[DataGrid](DataGrid.md).[determineText](DataGrid.md#determinetext)

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

#### Overrides

[DataGrid](DataGrid.md).[editItem](DataGrid.md#edititem)

#### Defined in

[src/ui/datagrid/entitygrid.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L212)

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

#### Overrides

[DataGrid](DataGrid.md).[editItemOfType](DataGrid.md#edititemoftype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L229)

___

### enableFiltering

▸ **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[enableFiltering](DataGrid.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.ts:739](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L739)

___

### ensureQuickFilterBar

▸ **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[ensureQuickFilterBar](DataGrid.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L194)

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

[DataGrid](DataGrid.md).[findQuickFilter](DataGrid.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L289)

___

### getAddButtonCaption

▸ **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getAddButtonCaption](DataGrid.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/entitygrid.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L170)

___

### getButtons

▸ **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[DataGrid](DataGrid.md).[getButtons](DataGrid.md#getbuttons)

#### Defined in

[src/ui/datagrid/entitygrid.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L174)

___

### getColumnWidthDelta

▸ **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](DataGrid.md).[getColumnWidthDelta](DataGrid.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L413)

___

### getColumnWidthScale

▸ **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](DataGrid.md).[getColumnWidthScale](DataGrid.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L417)

___

### getColumns

▸ **getColumns**(): `Column`\<`TItem`\>[]

#### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[getColumns](DataGrid.md#getcolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L881)

___

### getColumnsKey

▸ **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getColumnsKey](DataGrid.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.ts:844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L844)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getCssClass](DataGrid.md#getcssclass)

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

[DataGrid](DataGrid.md).[getCurrentSettings](DataGrid.md#getcurrentsettings)

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

[DataGrid](DataGrid.md).[getCustomAttribute](DataGrid.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDefaultSortBy

▸ **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[DataGrid](DataGrid.md).[getDefaultSortBy](DataGrid.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.ts:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L710)

___

### getDialogOptions

▸ **getDialogOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L338)

___

### getDialogOptionsFor

▸ **getDialogOptionsFor**(`itemType`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |

#### Returns

`any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L342)

___

### getDialogType

▸ **getDialogType**(): (...`args`: `any`[]) => [`Widget`](Widget.md)\<`any`\>

#### Returns

`fn`

• **new getDialogType**(`...args`): [`Widget`](Widget.md)\<`any`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

##### Returns

[`Widget`](Widget.md)\<`any`\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L360)

___

### getDialogTypeFor

▸ **getDialogTypeFor**(`itemType`): (...`args`: `any`[]) => [`Widget`](Widget.md)\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |

#### Returns

`fn`

• **new getDialogTypeFor**(`...args`): [`Widget`](Widget.md)\<`any`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

##### Returns

[`Widget`](Widget.md)\<`any`\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L349)

___

### getDisplayName

▸ **getDisplayName**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L132)

___

### getElement

▸ **getElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[DataGrid](DataGrid.md).[getElement](DataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.ts:1453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1453)

___

### getEntityType

▸ **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L102)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[DataGrid](DataGrid.md).[getFieldElement](DataGrid.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getFilterStore

▸ **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[DataGrid](DataGrid.md).[getFilterStore](DataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.ts:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1465)

___

### getGrid

▸ **getGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[getGrid](DataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.ts:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1457)

___

### getGridCanLoad

▸ **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[getGridCanLoad](DataGrid.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.ts:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L935)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[DataGrid](DataGrid.md).[getGridField](DataGrid.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getIdProperty

▸ **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getIdProperty](DataGrid.md#getidproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1027](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1027)

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

[DataGrid](DataGrid.md).[getIncludeColumns](DataGrid.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.ts:647](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L647)

___

### getInitialTitle

▸ **getInitialTitle**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getInitialTitle](DataGrid.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/entitygrid.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L86)

___

### getInsertPermission

▸ **getInsertPermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L291)

___

### getIsActiveProperty

▸ **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getIsActiveProperty](DataGrid.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1048)

___

### getIsDeletedProperty

▸ **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getIsDeletedProperty](DataGrid.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.ts:1042](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1042)

___

### getItemCssClass

▸ **getItemCssClass**(`item`, `index`): `string`

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

[src/ui/datagrid/datagrid.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L351)

___

### getItemMetadata

▸ **getItemMetadata**(`item`, `index`): `any`

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

[src/ui/datagrid/datagrid.ts:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L384)

___

### getItemName

▸ **getItemName**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L152)

___

### getItemType

▸ **getItemType**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getItemType](DataGrid.md#getitemtype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L271)

___

### getItems

▸ **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[DataGrid](DataGrid.md).[getItems](DataGrid.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L511)

___

### getLocalTextDbPrefix

▸ **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getLocalTextDbPrefix](DataGrid.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.ts:1005](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1005)

___

### getLocalTextPrefix

▸ **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Overrides

[DataGrid](DataGrid.md).[getLocalTextPrefix](DataGrid.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/entitygrid.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L90)

___

### getPagerOptions

▸ **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[DataGrid](DataGrid.md).[getPagerOptions](DataGrid.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:754](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L754)

___

### getPersistanceKey

▸ **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getPersistanceKey](DataGrid.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.ts:1135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1135)

___

### getPersistanceStorage

▸ **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[DataGrid](DataGrid.md).[getPersistanceStorage](DataGrid.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.ts:1131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1131)

___

### getPersistedSettings

▸ **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[getPersistedSettings](DataGrid.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1171)

___

### getPropertyItems

▸ **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[DataGrid](DataGrid.md).[getPropertyItems](DataGrid.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.ts:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L848)

___

### getPropertyItemsData

▸ **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[DataGrid](DataGrid.md).[getPropertyItemsData](DataGrid.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L852)

___

### getPropertyItemsDataAsync

▸ **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[DataGrid](DataGrid.md).[getPropertyItemsDataAsync](DataGrid.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L872)

___

### getQuickFilters

▸ **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[DataGrid](DataGrid.md).[getQuickFilters](DataGrid.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L225)

___

### getQuickSearchFields

▸ **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[DataGrid](DataGrid.md).[getQuickSearchFields](DataGrid.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L308)

___

### getRowDefinition

▸ **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[DataGrid](DataGrid.md).[getRowDefinition](DataGrid.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L999)

___

### getService

▸ **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L252)

___

### getSlickOptions

▸ **getSlickOptions**(): `GridOptions`\<`any`\>

#### Returns

`GridOptions`\<`any`\>

#### Inherited from

[DataGrid](DataGrid.md).[getSlickOptions](DataGrid.md#getslickoptions)

#### Defined in

[src/ui/datagrid/datagrid.ts:911](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L911)

___

### getTitle

▸ **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[DataGrid](DataGrid.md).[getTitle](DataGrid.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:796](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L796)

___

### getView

▸ **getView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[getView](DataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.ts:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1461)

___

### getViewOptions

▸ **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Overrides

[DataGrid](DataGrid.md).[getViewOptions](DataGrid.md#getviewoptions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L265)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[get_readOnly](DataGrid.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.ts:984](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L984)

___

### gridPersistanceFlags

▸ **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Inherited from

[DataGrid](DataGrid.md).[gridPersistanceFlags](DataGrid.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.ts:1146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1146)

___

### handleRoute

▸ **handleRoute**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`HandleRouteEvent`](../interfaces/HandleRouteEvent.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L29)

___

### hasInsertPermission

▸ **hasInsertPermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/entitygrid.ts:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L295)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[DataGrid](DataGrid.md).[init](DataGrid.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initDialog

▸ **initDialog**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](Widget.md)\<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L305)

___

### initEntityDialog

▸ **initEntityDialog**(`itemType`, `dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `dialog` | [`Widget`](Widget.md)\<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L314)

___

### initialPopulate

▸ **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[initialPopulate](DataGrid.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.ts:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L421)

___

### initializeFilterBar

▸ **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[initializeFilterBar](DataGrid.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L443)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[internalInit](DataGrid.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRefresh

▸ **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[internalRefresh](DataGrid.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:959](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L959)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[internalRenderContents](DataGrid.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### invokeSubmitHandlers

▸ **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[invokeSubmitHandlers](DataGrid.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.ts:1119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1119)

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

[src/ui/datagrid/datagrid.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L503)

___

### itemLink

▸ **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../README.md#format)\<`TItem`\>

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `itemType?` | `string` | `undefined` |
| `idField?` | `string` | `undefined` |
| `text?` | [`Format`](../README.md#format)\<`TItem`\> | `undefined` |
| `cssClass?` | (`ctx`: `FormatterContext`\<`any`\>) => `string` | `undefined` |
| `encode` | `boolean` | `true` |

#### Returns

[`Format`](../README.md#format)\<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[itemLink](DataGrid.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.ts:830](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L830)

___

### layout

▸ **layout**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[layout](DataGrid.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L165)

___

### markupReady

▸ **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[markupReady](DataGrid.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L698)

___

### newRefreshButton

▸ **newRefreshButton**(`noText?`): [`ToolButton`](../interfaces/ToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `noText?` | `boolean` |

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

#### Defined in

[src/ui/datagrid/entitygrid.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L195)

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

[DataGrid](DataGrid.md).[onClick](DataGrid.md#onclick)

#### Defined in

[src/ui/datagrid/datagrid.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L598)

___

### onViewFilter

▸ **onViewFilter**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[onViewFilter](DataGrid.md#onviewfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L643)

___

### onViewProcessData

▸ **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\> |

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Inherited from

[DataGrid](DataGrid.md).[onViewProcessData](DataGrid.md#onviewprocessdata)

#### Defined in

[src/ui/datagrid/datagrid.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L639)

___

### onViewSubmit

▸ **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[onViewSubmit](DataGrid.md#onviewsubmit)

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

[DataGrid](DataGrid.md).[persistSettings](DataGrid.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.ts:1353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1353)

___

### populateLock

▸ **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[populateLock](DataGrid.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.ts:927](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L927)

___

### populateUnlock

▸ **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[populateUnlock](DataGrid.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.ts:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L931)

___

### populateWhenVisible

▸ **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[populateWhenVisible](DataGrid.md#populatewhenvisible)

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

[DataGrid](DataGrid.md).[postProcessColumns](DataGrid.md#postprocesscolumns)

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

[DataGrid](DataGrid.md).[propertyItemsReady](DataGrid.md#propertyitemsready)

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

[DataGrid](DataGrid.md).[propertyItemsToSlickColumns](DataGrid.md#propertyitemstoslickcolumns)

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

[DataGrid](DataGrid.md).[quickFilterChange](DataGrid.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.ts:1125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1125)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[refresh](DataGrid.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.ts:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L939)

___

### refreshIfNeeded

▸ **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[refreshIfNeeded](DataGrid.md#refreshifneeded)

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

[DataGrid](DataGrid.md).[render](DataGrid.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[DataGrid](DataGrid.md).[renderContents](DataGrid.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

___

### resizeCanvas

▸ **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[resizeCanvas](DataGrid.md#resizecanvas)

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

[DataGrid](DataGrid.md).[restoreSettings](DataGrid.md#restoresettings)

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

[DataGrid](DataGrid.md).[restoreSettingsFrom](DataGrid.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.ts:1201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1201)

___

### routeDialog

▸ **routeDialog**(`itemType`, `dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `dialog` | [`Widget`](Widget.md)\<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L275)

___

### rowCount

▸ **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[DataGrid](DataGrid.md).[rowCount](DataGrid.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L507)

___

### setCriteriaParameter

▸ **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setCriteriaParameter](DataGrid.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L662)

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

[DataGrid](DataGrid.md).[setEquality](DataGrid.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L672)

___

### setIncludeColumnsParameter

▸ **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setIncludeColumnsParameter](DataGrid.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L676)

___

### setInitialSortOrder

▸ **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[setInitialSortOrder](DataGrid.md#setinitialsortorder)

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

[DataGrid](DataGrid.md).[setIsDisabled](DataGrid.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.ts:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L963)

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

[DataGrid](DataGrid.md).[setTitle](DataGrid.md#settitle)

#### Defined in

[src/ui/datagrid/datagrid.ts:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L804)

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

[src/ui/datagrid/datagrid.ts:988](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L988)

___

### subDialogDataChange

▸ **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[subDialogDataChange](DataGrid.md#subdialogdatachange)

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

[DataGrid](DataGrid.md).[syncOrAsyncThen](DataGrid.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### transferDialogReadOnly

▸ **transferDialogReadOnly**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](Widget.md)\<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L300)

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

[DataGrid](DataGrid.md).[tryFindQuickFilter](DataGrid.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L296)

___

### updateDisabledState

▸ **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[updateDisabledState](DataGrid.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.ts:1063](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L1063)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[DataGrid](DataGrid.md).[updateInterface](DataGrid.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L995)

___

### useAsync

▸ **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[useAsync](DataGrid.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L157)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[DataGrid](DataGrid.md).[useIdPrefix](DataGrid.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### useLayoutTimer

▸ **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DataGrid](DataGrid.md).[useLayoutTimer](DataGrid.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L161)

___

### usePager

▸ **usePager**(): `boolean`

#### Returns

`boolean`

#### Overrides

[DataGrid](DataGrid.md).[usePager](DataGrid.md#usepager)

#### Defined in

[src/ui/datagrid/entitygrid.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L77)

___

### viewDataChanged

▸ **viewDataChanged**(`e`, `rows`): `void`

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

[DataGrid](DataGrid.md).[wrapFormatterWithEditLink](DataGrid.md#wrapformatterwitheditlink)

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

[DataGrid](DataGrid.md).[create](DataGrid.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[DataGrid](DataGrid.md).[createDefaultElement](DataGrid.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L60)

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

[DataGrid](DataGrid.md).[getWidgetName](DataGrid.md#getwidgetname)

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

[DataGrid](DataGrid.md).[propertyItemToQuickFilter](DataGrid.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.ts#L235)
