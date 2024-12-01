[@serenity-is/corelib](../README.md) / EntityGrid

# Class: EntityGrid\<TItem, P\>

## Extends

- [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

## Type Parameters

• **TItem**

• **P** = \{\}

## Constructors

### new EntityGrid()

> **new EntityGrid**\<`TItem`, `P`\>(`props`): [`EntityGrid`](EntityGrid.md)\<`TItem`, `P`\>

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

[`EntityGrid`](EntityGrid.md)\<`TItem`, `P`\>

#### Overrides

[`DataGrid`](DataGrid.md).[`constructor`](DataGrid.md#constructors)

#### Defined in

[src/ui/datagrid/entitygrid.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L20)

## Properties

### allColumns

> `protected` **allColumns**: `Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`allColumns`](DataGrid.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L75)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`domNode`](DataGrid.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)\<`object`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`filterBar`](DataGrid.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L71)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`idPrefix`](DataGrid.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### initialSettings

> `protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`initialSettings`](DataGrid.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L77)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`openDialogsAsPanel`](DataGrid.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L81)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`options`](DataGrid.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsData`](DataGrid.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L76)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFiltersBar`](DataGrid.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L73)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFiltersDiv`](DataGrid.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoringSettings`](DataGrid.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L78)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`slickContainer`](DataGrid.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L74)

***

### slickGrid

> **slickGrid**: `Grid`\<`any`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`slickGrid`](DataGrid.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L80)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`titleDiv`](DataGrid.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`toolbar`](DataGrid.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L70)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`uniqueName`](DataGrid.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### view

> **view**: [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`view`](DataGrid.md#view)

#### Defined in

[src/ui/datagrid/datagrid.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L79)

***

### defaultColumnWidthDelta

> `static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultColumnWidthDelta`](DataGrid.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L87)

***

### defaultColumnWidthScale

> `static` **defaultColumnWidthScale**: `number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultColumnWidthScale`](DataGrid.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.tsx:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L86)

***

### defaultHeaderHeight

> `static` **defaultHeaderHeight**: `number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultHeaderHeight`](DataGrid.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L84)

***

### defaultPersistanceStorage

> `static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultPersistanceStorage`](DataGrid.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L85)

***

### defaultRowHeight

> `static` **defaultRowHeight**: `number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultRowHeight`](DataGrid.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L83)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`DataGrid`](DataGrid.md).[`isComponent`](DataGrid.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`typeInfo`](DataGrid.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`element`](DataGrid.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`props`](DataGrid.md#props)

#### Defined in

[src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`readOnly`](DataGrid.md#readonly)

#### Defined in

[src/ui/datagrid/datagrid.tsx:980](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L980)

## Methods

### addBooleanFilter()

> `protected` **addBooleanFilter**(`field`, `title`?, `yes`?, `no`?): [`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

##### yes?

`string`

##### no?

`string`

#### Returns

[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`addBooleanFilter`](DataGrid.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1115)

***

### addButtonClick()

> `protected` **addButtonClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L210)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addCssClass`](DataGrid.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

***

### addDateRangeFilter()

> `protected` **addDateRangeFilter**(`field`, `title`?): [`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`addDateRangeFilter`](DataGrid.md#adddaterangefilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1099](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1099)

***

### addDateTimeRangeFilter()

> `protected` **addDateTimeRangeFilter**(`field`, `title`?): [`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`addDateTimeRangeFilter`](DataGrid.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1107)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addFilterSeparator`](DataGrid.md#addfilterseparator)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1079](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1079)

***

### addQuickFilter()

> `protected` **addQuickFilter**\<`TWidget`, `P`\>(`opt`): `TWidget`

#### Type Parameters

• **TWidget** *extends* [`Widget`](Widget.md)\<`any`\>

• **P**

#### Parameters

##### opt

[`QuickFilter`](../interfaces/QuickFilter.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addQuickFilter`](DataGrid.md#addquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1095](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1095)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName`?): `void`

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`DataGrid`](DataGrid.md).[`addValidationRule`](DataGrid.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`DataGrid`](DataGrid.md).[`addValidationRule`](DataGrid.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterInit()

> `protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`afterInit`](DataGrid.md#afterinit)

#### Defined in

[src/ui/datagrid/datagrid.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L155)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`afterRender`](DataGrid.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToSlickEvents`](DataGrid.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.tsx:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L525)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToViewEvents`](DataGrid.md#bindtoviewevents)

#### Defined in

[src/ui/datagrid/datagrid.tsx:625](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L625)

***

### booleanQuickFilter()

> `protected` **booleanQuickFilter**(`field`, `title`?, `yes`?, `no`?): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

##### yes?

`string`

##### no?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`booleanQuickFilter`](DataGrid.md#booleanquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1119)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`byId`](DataGrid.md#byid)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

***

### canFilterColumn()

> `protected` **canFilterColumn**(`column`): `boolean`

#### Parameters

##### column

`Column`\<`any`\>

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`canFilterColumn`](DataGrid.md#canfiltercolumn)

#### Defined in

[src/ui/datagrid/datagrid.tsx:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L438)

***

### canShowColumn()

> `protected` **canShowColumn**(`column`): `boolean`

#### Parameters

##### column

`Column`\<`any`\>

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`canShowColumn`](DataGrid.md#canshowcolumn)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1154)

***

### change()

> **change**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`change`](DataGrid.md#change)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`changeSelect2`](DataGrid.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### createEntityDialog()

> `protected` **createEntityDialog**(`itemType`, `callback`?): [`Widget`](Widget.md)\<`any`\> \| `PromiseLike`\<[`Widget`](Widget.md)\<`any`\>\>

#### Parameters

##### itemType

`string`

##### callback?

(`dlg`) => `void`

#### Returns

[`Widget`](Widget.md)\<`any`\> \| `PromiseLike`\<[`Widget`](Widget.md)\<`any`\>\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L339)

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createFilterBar`](DataGrid.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L753)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createIncludeDeletedButton`](DataGrid.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.tsx:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L305)

***

### createPager()

> `protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createPager`](DataGrid.md#createpager)

#### Defined in

[src/ui/datagrid/datagrid.tsx:768](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L768)

***

### createQuickFilters()

> `protected` **createQuickFilters**(`filters`?): `void`

#### Parameters

##### filters?

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createQuickFilters`](DataGrid.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L203)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createQuickSearchInput`](DataGrid.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.tsx:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L314)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickContainer`](DataGrid.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.tsx:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L707)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickGrid`](DataGrid.md#createslickgrid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L461)

***

### createToolbar()

> `protected` **createToolbar**(`buttons`): `void`

#### Parameters

##### buttons

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createToolbar`](DataGrid.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L794)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`createToolbarExtensions`](DataGrid.md#createtoolbarextensions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L83)

***

### createView()

> `protected` **createView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createView`](DataGrid.md#createview)

#### Defined in

[src/ui/datagrid/datagrid.tsx:711](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L711)

***

### dateRangeQuickFilter()

> `protected` **dateRangeQuickFilter**(`field`, `title`?): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`dateRangeQuickFilter`](DataGrid.md#daterangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1103)

***

### dateTimeRangeQuickFilter()

> `protected` **dateTimeRangeQuickFilter**(`field`, `title`?): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`dateTimeRangeQuickFilter`](DataGrid.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1111)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`deferRender`](DataGrid.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`destroy`](DataGrid.md#destroy)

#### Defined in

[src/ui/datagrid/entitygrid.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L26)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

#### Parameters

##### getKey

(`prefix`) => `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`determineText`](DataGrid.md#determinetext)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1083)

***

### editItem()

> `protected` **editItem**(`entityOrId`): `void`

#### Parameters

##### entityOrId

`any`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`editItem`](DataGrid.md#edititem)

#### Defined in

[src/ui/datagrid/entitygrid.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L214)

***

### editItemOfType()

> `protected` **editItemOfType**(`itemType`, `entityOrId`): `void`

#### Parameters

##### itemType

`string`

##### entityOrId

`any`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`editItemOfType`](DataGrid.md#edititemoftype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L231)

***

### enableFiltering()

> `protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`enableFiltering`](DataGrid.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L745)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`ensureQuickFilterBar`](DataGrid.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L195)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`findById`](DataGrid.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### findQuickFilter()

> `protected` **findQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

#### Type Parameters

• **TWidget**

#### Parameters

##### type

(...`args`) => `TWidget`

##### field

`string`

#### Returns

`TWidget`

#### Inherited from

[`DataGrid`](DataGrid.md).[`findQuickFilter`](DataGrid.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L289)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`get_readOnly`](DataGrid.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.tsx:988](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L988)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getAddButtonCaption`](DataGrid.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/entitygrid.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L172)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`DataGrid`](DataGrid.md).[`getButtons`](DataGrid.md#getbuttons)

#### Defined in

[src/ui/datagrid/entitygrid.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L176)

***

### getColumns()

> `protected` **getColumns**(): `Column`\<`TItem`\>[]

#### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumns`](DataGrid.md#getcolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L885)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnsKey`](DataGrid.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.tsx:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L848)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthDelta`](DataGrid.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.tsx:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L415)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthScale`](DataGrid.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L419)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getCssClass`](DataGrid.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

***

### getCurrentSettings()

> `protected` **getCurrentSettings**(`flags`?): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Parameters

##### flags?

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getCurrentSettings`](DataGrid.md#getcurrentsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1367)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

#### Type Parameters

• **TAttr**

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getCustomAttribute`](DataGrid.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getDefaultSortBy`](DataGrid.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.tsx:716](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L716)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L360)

***

### getDialogOptionsFor()

> `protected` **getDialogOptionsFor**(`itemType`): `any`

#### Parameters

##### itemType

`string`

#### Returns

`any`

#### Defined in

[src/ui/datagrid/entitygrid.ts:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L364)

***

### getDialogType()

> `protected` **getDialogType**(): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L382)

***

### getDialogTypeFor()

> `protected` **getDialogTypeFor**(`itemType`): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

#### Parameters

##### itemType

`string`

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

#### Defined in

[src/ui/datagrid/entitygrid.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L371)

***

### getDisplayName()

> `protected` **getDisplayName**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L134)

***

### getElement()

> **getElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getElement`](DataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1457)

***

### getEntityType()

> `protected` **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L104)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getFilterStore`](DataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1469)

***

### getGrid()

> **getGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGrid`](DataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1461)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGridCanLoad`](DataGrid.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.tsx:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L939)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGridField`](DataGrid.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIdProperty`](DataGrid.md#getidproperty)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1031)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

#### Parameters

##### include

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIncludeColumns`](DataGrid.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:653](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L653)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getInitialTitle`](DataGrid.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/entitygrid.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L88)

***

### getInsertPermission()

> `protected` **getInsertPermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L302)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsActiveProperty`](DataGrid.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsDeletedProperty`](DataGrid.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1046)

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

#### Parameters

##### item

`TItem`

##### index

`number`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemCssClass`](DataGrid.md#getitemcssclass)

#### Defined in

[src/ui/datagrid/datagrid.tsx:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L353)

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

#### Parameters

##### item

`TItem`

##### index

`number`

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemMetadata`](DataGrid.md#getitemmetadata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L386)

***

### getItemName()

> `protected` **getItemName**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L154)

***

### getItems()

> **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItems`](DataGrid.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.tsx:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L517)

***

### getItemType()

> `protected` **getItemType**(): `string`

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getItemType`](DataGrid.md#getitemtype)

#### Defined in

[src/ui/datagrid/entitygrid.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L282)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getLocalTextDbPrefix`](DataGrid.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1009](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1009)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getLocalTextPrefix`](DataGrid.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/entitygrid.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L92)

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPagerOptions`](DataGrid.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.tsx:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L760)

***

### getPersistanceKey()

> `protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistanceKey`](DataGrid.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1139)

***

### getPersistanceStorage()

> `protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistanceStorage`](DataGrid.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1135)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistedSettings`](DataGrid.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1175)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItems`](DataGrid.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.tsx:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L852)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsData`](DataGrid.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:856](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L856)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsDataAsync`](DataGrid.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.tsx:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L876)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickFilters`](DataGrid.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.tsx:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L225)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickSearchFields`](DataGrid.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.tsx:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L310)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getRowDefinition`](DataGrid.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1003)

***

### getService()

> `protected` **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L255)

***

### getServiceMethod()

> `protected` **getServiceMethod**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L268)

***

### getServiceUrl()

> `protected` **getServiceUrl**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/entitygrid.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L272)

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`\<`any`\>

#### Returns

`GridOptions`\<`any`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getSlickOptions`](DataGrid.md#getslickoptions)

#### Defined in

[src/ui/datagrid/datagrid.tsx:915](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L915)

***

### getTitle()

> **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getTitle`](DataGrid.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.tsx:802](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L802)

***

### getView()

> **getView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getView`](DataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1465)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Overrides

[`DataGrid`](DataGrid.md).[`getViewOptions`](DataGrid.md#getviewoptions)

#### Defined in

[src/ui/datagrid/entitygrid.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L276)

***

### gridPersistanceFlags()

> `protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`gridPersistanceFlags`](DataGrid.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1150)

***

### handleRoute()

> `protected` **handleRoute**(`e`): `void`

#### Parameters

##### e

[`HandleRouteEvent`](../interfaces/HandleRouteEvent.md)

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L31)

***

### hasInsertPermission()

> `protected` **hasInsertPermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/entitygrid.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L306)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`DataGrid`](DataGrid.md).[`init`](DataGrid.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initDialog()

> `protected` **initDialog**(`dialog`): `void`

#### Parameters

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L316)

***

### initEntityDialog()

> `protected` **initEntityDialog**(`itemType`, `dialog`): `void`

#### Parameters

##### itemType

`string`

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L325)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initializeFilterBar`](DataGrid.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L445)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initialPopulate`](DataGrid.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.tsx:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L423)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`internalRefresh`](DataGrid.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.tsx:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L963)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`internalRenderContents`](DataGrid.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`invokeSubmitHandlers`](DataGrid.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1123)

***

### itemAt()

> **itemAt**(`row`): `TItem`

#### Parameters

##### row

`number`

#### Returns

`TItem`

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemAt`](DataGrid.md#itemat)

#### Defined in

[src/ui/datagrid/datagrid.tsx:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L505)

***

### itemId()

> **itemId**(`item`): `any`

#### Parameters

##### item

`TItem`

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemId`](DataGrid.md#itemid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L509)

***

### itemLink()

> `protected` **itemLink**(`itemType`?, `idField`?, `text`?, `cssClass`?, `encode`?): [`Format`](../type-aliases/Format.md)\<`TItem`\>

#### Parameters

##### itemType?

`string`

##### idField?

`string`

##### text?

[`Format`](../type-aliases/Format.md)\<`TItem`\>

##### cssClass?

(`ctx`) => `string`

##### encode?

`boolean` = `true`

#### Returns

[`Format`](../type-aliases/Format.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemLink`](DataGrid.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.tsx:834](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L834)

***

### layout()

> `protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`layout`](DataGrid.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L166)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`legacyTemplateRender`](DataGrid.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### markupReady()

> `protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`markupReady`](DataGrid.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.tsx:704](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L704)

***

### newRefreshButton()

> `protected` **newRefreshButton**(`noText`?): [`ToolButton`](../interfaces/ToolButton.md)

#### Parameters

##### noText?

`boolean`

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

#### Defined in

[src/ui/datagrid/entitygrid.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L197)

***

### onClick()

> `protected` **onClick**(`e`, `row`, `cell`): `void`

#### Parameters

##### e

`Event`

##### row

`number`

##### cell

`number`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`onClick`](DataGrid.md#onclick)

#### Defined in

[src/ui/datagrid/datagrid.tsx:604](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L604)

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewFilter`](DataGrid.md#onviewfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:649](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L649)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewProcessData`](DataGrid.md#onviewprocessdata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:645](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L645)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewSubmit`](DataGrid.md#onviewsubmit)

#### Defined in

[src/ui/datagrid/datagrid.tsx:692](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L692)

***

### persistSettings()

> `protected` **persistSettings**(`flags`?): `void` \| `Promise`\<`void`\>

#### Parameters

##### flags?

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

`void` \| `Promise`\<`void`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistSettings`](DataGrid.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1357)

***

### populateLock()

> `protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateLock`](DataGrid.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.tsx:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L931)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateUnlock`](DataGrid.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.tsx:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L935)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateWhenVisible`](DataGrid.md#populatewhenvisible)

#### Defined in

[src/ui/datagrid/datagrid.tsx:749](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L749)

***

### postProcessColumns()

> `protected` **postProcessColumns**(`columns`): `Column`\<`any`\>[]

#### Parameters

##### columns

`Column`\<`any`\>[]

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`postProcessColumns`](DataGrid.md#postprocesscolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L394)

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsReady`](DataGrid.md#propertyitemsready)

#### Defined in

[src/ui/datagrid/datagrid.tsx:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L122)

***

### propertyItemsToSlickColumns()

> `protected` **propertyItemsToSlickColumns**(`propertyItems`): `Column`\<`any`\>[]

#### Parameters

##### propertyItems

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsToSlickColumns`](DataGrid.md#propertyitemstoslickcolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:904](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L904)

***

### quickFilterChange()

> `protected` **quickFilterChange**(`e`): `void`

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFilterChange`](DataGrid.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1129)

***

### refresh()

> **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refresh`](DataGrid.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.tsx:943](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L943)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refreshIfNeeded`](DataGrid.md#refreshifneeded)

#### Defined in

[src/ui/datagrid/datagrid.tsx:956](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L956)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`render`](DataGrid.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`renderContents`](DataGrid.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`resizeCanvas`](DataGrid.md#resizecanvas)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1071](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1071)

***

### restoreSettings()

> `protected` **restoreSettings**(`settings`?, `flags`?): `void` \| `Promise`\<`void`\>

#### Parameters

##### settings?

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### flags?

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

`void` \| `Promise`\<`void`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoreSettings`](DataGrid.md#restoresettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1194)

***

### restoreSettingsFrom()

> `protected` **restoreSettingsFrom**(`settings`, `flags`?): `void`

#### Parameters

##### settings

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### flags?

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoreSettingsFrom`](DataGrid.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1205)

***

### routeDialog()

> `protected` **routeDialog**(`itemType`, `dialog`): `void`

#### Parameters

##### itemType

`string`

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L286)

***

### rowCount()

> **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`rowCount`](DataGrid.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.tsx:513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L513)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`set_readOnly`](DataGrid.md#set_readonly)

#### Defined in

[src/ui/datagrid/datagrid.tsx:992](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L992)

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setCriteriaParameter`](DataGrid.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L668)

***

### setEquality()

> `protected` **setEquality**(`field`, `value`): `void`

#### Parameters

##### field

`string`

##### value

`any`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setEquality`](DataGrid.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.tsx:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L678)

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setIncludeColumnsParameter`](DataGrid.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L682)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setInitialSortOrder`](DataGrid.md#setinitialsortorder)

#### Defined in

[src/ui/datagrid/datagrid.tsx:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L480)

***

### setIsDisabled()

> **setIsDisabled**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setIsDisabled`](DataGrid.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.tsx:967](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L967)

***

### setItems()

> **setItems**(`value`): `void`

#### Parameters

##### value

`TItem`[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setItems`](DataGrid.md#setitems)

#### Defined in

[src/ui/datagrid/datagrid.tsx:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L521)

***

### setTitle()

> **setTitle**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setTitle`](DataGrid.md#settitle)

#### Defined in

[src/ui/datagrid/datagrid.tsx:810](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L810)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`subDialogDataChange`](DataGrid.md#subdialogdatachange)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1075](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1075)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type Parameters

• **T**

#### Parameters

##### syncMethod

() => `T`

##### asyncMethod

() => `PromiseLike`\<`T`\>

##### then

(`v`) => `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`syncOrAsyncThen`](DataGrid.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### transferDialogReadOnly()

> `protected` **transferDialogReadOnly**(`dialog`): `void`

#### Parameters

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

#### Defined in

[src/ui/datagrid/entitygrid.ts:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L311)

***

### tryFindQuickFilter()

> `protected` **tryFindQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

#### Type Parameters

• **TWidget**

#### Parameters

##### type

(...`args`) => `TWidget`

##### field

`string`

#### Returns

`TWidget`

#### Inherited from

[`DataGrid`](DataGrid.md).[`tryFindQuickFilter`](DataGrid.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L297)

***

### updateDisabledState()

> `protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`updateDisabledState`](DataGrid.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1067](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1067)

***

### updateInterface()

> **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`updateInterface`](DataGrid.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.tsx:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L999)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`useAsync`](DataGrid.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L158)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`useIdPrefix`](DataGrid.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`useLayoutTimer`](DataGrid.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.tsx:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L162)

***

### usePager()

> `protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Overrides

[`DataGrid`](DataGrid.md).[`usePager`](DataGrid.md#usepager)

#### Defined in

[src/ui/datagrid/entitygrid.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L79)

***

### viewDataChanged()

> `protected` **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

##### e

`any`

##### rows

`TItem`[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`viewDataChanged`](DataGrid.md#viewdatachanged)

#### Defined in

[src/ui/datagrid/datagrid.tsx:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L620)

***

### wrapFormatterWithEditLink()

> `protected` **wrapFormatterWithEditLink**(`column`, `item`): `void`

#### Parameters

##### column

`Column`\<`any`\>

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`wrapFormatterWithEditLink`](DataGrid.md#wrapformatterwitheditlink)

#### Defined in

[src/ui/datagrid/datagrid.tsx:889](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L889)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type Parameters

• **TWidget** *extends* [`Widget`](Widget.md)\<`P`\>

• **P**

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`DataGrid`](DataGrid.md).[`create`](DataGrid.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createDefaultElement`](DataGrid.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L56)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getWidgetName`](DataGrid.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

***

### propertyItemToQuickFilter()

> `static` **propertyItemToQuickFilter**(`item`): `any`

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemToQuickFilter`](DataGrid.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L235)
