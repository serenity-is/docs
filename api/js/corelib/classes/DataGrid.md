[@serenity-is/corelib](../README.md) / DataGrid

# Class: DataGrid\<TItem, P\>

## Extends

- [`Widget`](Widget.md)\<`P`\>

## Extended by

- [`CheckTreeEditor`](CheckTreeEditor.md)
- [`EntityGrid`](EntityGrid.md)

## Type Parameters

• **TItem**

• **P** = \{\}

## Implements

- [`IDataGrid`](../interfaces/IDataGrid.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### new DataGrid()

> **new DataGrid**\<`TItem`, `P`\>(`props`): [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

[`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

#### Overrides

[`Widget`](Widget.md).[`constructor`](Widget.md#constructors)

#### Defined in

[src/ui/datagrid/datagrid.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L89)

## Properties

### allColumns

> `protected` **allColumns**: `Column`\<`any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L75)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`Widget`](Widget.md).[`domNode`](Widget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)\<`object`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L71)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`Widget`](Widget.md).[`idPrefix`](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### initialSettings

> `protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L77)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

#### Defined in

[src/ui/datagrid/datagrid.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L81)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`options`](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L76)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L73)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L78)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L74)

***

### slickGrid

> **slickGrid**: `Grid`\<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L80)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L70)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`Widget`](Widget.md).[`uniqueName`](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### view

> **view**: [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L79)

***

### defaultColumnWidthDelta

> `static` **defaultColumnWidthDelta**: `number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L87)

***

### defaultColumnWidthScale

> `static` **defaultColumnWidthScale**: `number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L86)

***

### defaultHeaderHeight

> `static` **defaultHeaderHeight**: `number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L84)

***

### defaultPersistanceStorage

> `static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L85)

***

### defaultRowHeight

> `static` **defaultRowHeight**: `number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L83)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`Widget`](Widget.md).[`isComponent`](Widget.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`Widget`](Widget.md).[`typeInfo`](Widget.md#typeinfo)

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

[`Widget`](Widget.md).[`element`](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`props`](Widget.md#props)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:1115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1115)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`addCssClass`](Widget.md#addcssclass)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1107)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

#### Returns

`void`

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

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

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

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterInit()

> `protected` **afterInit**(): `void`

#### Returns

`void`

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

[`Widget`](Widget.md).[`afterRender`](Widget.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L525)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

#### Returns

`void`

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

[`Widget`](Widget.md).[`byId`](Widget.md#byid)

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

[`Widget`](Widget.md).[`change`](Widget.md#change)

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

[`Widget`](Widget.md).[`changeSelect2`](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L753)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L305)

***

### createPager()

> `protected` **createPager**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L203)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L314)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L707)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L794)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L192)

***

### createView()

> `protected` **createView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1111)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`deferRender`](Widget.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`Widget`](Widget.md).[`destroy`](Widget.md#destroy)

#### Defined in

[src/ui/datagrid/datagrid.tsx:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L319)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

#### Parameters

##### getKey

(`prefix`) => `string`

#### Returns

`string`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:591](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L591)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L595)

***

### enableFiltering()

> `protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L745)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

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

[`Widget`](Widget.md).[`findById`](Widget.md#findbyid)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L289)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/datagrid/datagrid.tsx:988](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L988)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:583](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L583)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:587](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L587)

***

### getColumns()

> `protected` **getColumns**(): `Column`\<`TItem`\>[]

#### Returns

`Column`\<`TItem`\>[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L885)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L848)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L415)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/datagrid/datagrid.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L419)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getCssClass`](Widget.md#getcssclass)

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

[`Widget`](Widget.md).[`getCustomAttribute`](Widget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:716](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L716)

***

### getElement()

> **getElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getElement`](../interfaces/IDataGrid.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1457)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getFilterStore`](../interfaces/IDataGrid.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1469)

***

### getGrid()

> **getGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getGrid`](../interfaces/IDataGrid.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1461)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.tsx:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L939)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`Widget`](Widget.md).[`getGridField`](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1031)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

#### Parameters

##### include

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:653](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L653)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L188)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L386)

***

### getItems()

> **getItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L517)

***

### getItemType()

> `protected` **getItemType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:830](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L830)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:1009](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1009)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:1021](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1021)

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L760)

***

### getPersistanceKey()

> `protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:1139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1139)

***

### getPersistanceStorage()

> `protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1135)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1175)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L852)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:856](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L856)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L876)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L225)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Defined in

[src/ui/datagrid/datagrid.tsx:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L310)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1003)

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`\<`any`\>

#### Returns

`GridOptions`\<`any`\>

#### Defined in

[src/ui/datagrid/datagrid.tsx:915](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L915)

***

### getTitle()

> **getTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/datagrid.tsx:802](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L802)

***

### getView()

> **getView**(): [`RemoteView`](RemoteView.md)\<`TItem`\>

#### Returns

[`RemoteView`](RemoteView.md)\<`TItem`\>

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getView`](../interfaces/IDataGrid.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1465)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:772](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L772)

***

### gridPersistanceFlags()

> `protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1150)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`Widget`](Widget.md).[`init`](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L445)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L423)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L963)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`internalRenderContents`](Widget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:834](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L834)

***

### layout()

> `protected` **layout**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L166)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`legacyTemplateRender`](Widget.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### markupReady()

> `protected` **markupReady**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:704](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L704)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:645](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L645)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:1357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1357)

***

### populateLock()

> `protected` **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L931)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L935)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1129)

***

### refresh()

> **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:943](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L943)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

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

[`Widget`](Widget.md).[`render`](Widget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`renderContents`](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:1205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1205)

***

### rowCount()

> **rowCount**(): `number`

#### Returns

`number`

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

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/datagrid/datagrid.tsx:992](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L992)

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L678)

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L682)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:810](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L810)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

#### Returns

`void`

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

[`Widget`](Widget.md).[`syncOrAsyncThen`](Widget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L297)

***

### updateDisabledState()

> `protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:1067](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1067)

***

### updateInterface()

> **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/datagrid.tsx:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L999)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L158)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`Widget`](Widget.md).[`useIdPrefix`](Widget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.tsx:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L162)

***

### usePager()

> `protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/datagrid/datagrid.tsx:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L741)

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

[`Widget`](Widget.md).[`create`](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`Widget`](Widget.md).[`createDefaultElement`](Widget.md#createdefaultelement)

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

[`Widget`](Widget.md).[`getWidgetName`](Widget.md#getwidgetname)

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

#### Defined in

[src/ui/datagrid/datagrid.tsx:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L235)
