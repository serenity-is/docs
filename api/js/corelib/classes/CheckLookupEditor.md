[@serenity-is/corelib](../README.md) / CheckLookupEditor

# Class: CheckLookupEditor\<TItem, P\>

## Extends

- [`CheckTreeEditor`](CheckTreeEditor.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>, `P`\>

## Type Parameters

• **TItem** *extends* [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> = `any`

• **P** *extends* [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) = [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md)

## Constructors

### new CheckLookupEditor()

> **new CheckLookupEditor**\<`TItem`, `P`\>(`props`): [`CheckLookupEditor`](CheckLookupEditor.md)\<`TItem`, `P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`CheckLookupEditor`](CheckLookupEditor.md)\<`TItem`, `P`\>

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`constructor`](CheckTreeEditor.md#constructors)

#### Defined in

[src/ui/editors/checktreeeditor.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L482)

## Properties

### allColumns

> `protected` **allColumns**: `Column`\<`any`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allColumns`](CheckTreeEditor.md#allcolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L75)

***

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Defined in

[src/ui/editors/checktreeeditor.ts:603](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L603)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`domNode`](CheckTreeEditor.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)\<`object`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`filterBar`](CheckTreeEditor.md#filterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L71)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`idPrefix`](CheckTreeEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### initialSettings

> `protected` **initialSettings**: [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initialSettings`](CheckTreeEditor.md#initialsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L77)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`openDialogsAsPanel`](CheckTreeEditor.md#opendialogsaspanel)

#### Defined in

[src/ui/datagrid/datagrid.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L81)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`options`](CheckTreeEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsData`](CheckTreeEditor.md#propertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L76)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFiltersBar`](CheckTreeEditor.md#quickfiltersbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L73)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFiltersDiv`](CheckTreeEditor.md#quickfiltersdiv)

#### Defined in

[src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoringSettings`](CheckTreeEditor.md#restoringsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L78)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`slickContainer`](CheckTreeEditor.md#slickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L74)

***

### slickGrid

> **slickGrid**: `Grid`\<`any`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`slickGrid`](CheckTreeEditor.md#slickgrid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L80)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`titleDiv`](CheckTreeEditor.md#titlediv)

#### Defined in

[src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`toolbar`](CheckTreeEditor.md#toolbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L70)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`uniqueName`](CheckTreeEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### view

> **view**: [`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`view`](CheckTreeEditor.md#view)

#### Defined in

[src/ui/datagrid/datagrid.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L79)

***

### defaultColumnWidthDelta

> `static` **defaultColumnWidthDelta**: `number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultColumnWidthDelta`](CheckTreeEditor.md#defaultcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L87)

***

### defaultColumnWidthScale

> `static` **defaultColumnWidthScale**: `number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultColumnWidthScale`](CheckTreeEditor.md#defaultcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.tsx:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L86)

***

### defaultHeaderHeight

> `static` **defaultHeaderHeight**: `number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultHeaderHeight`](CheckTreeEditor.md#defaultheaderheight)

#### Defined in

[src/ui/datagrid/datagrid.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L84)

***

### defaultPersistanceStorage

> `static` **defaultPersistanceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultPersistanceStorage`](CheckTreeEditor.md#defaultpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L85)

***

### defaultRowHeight

> `static` **defaultRowHeight**: `number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultRowHeight`](CheckTreeEditor.md#defaultrowheight)

#### Defined in

[src/ui/datagrid/datagrid.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L83)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`isComponent`](CheckTreeEditor.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`typeInfo`](CheckTreeEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

## Accessors

### cascadeField

#### Get Signature

> **get** **cascadeField**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **cascadeField**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L639)

***

### cascadeFrom

#### Get Signature

> **get** **cascadeFrom**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **cascadeFrom**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L595)

***

### cascadeValue

#### Get Signature

> **get** **cascadeValue**(): `any`

##### Returns

`any`

#### Set Signature

> **set** **cascadeValue**(`value`): `void`

##### Parameters

###### value

`any`

##### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:655](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L655)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`element`](CheckTreeEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### filterField

#### Get Signature

> **get** **filterField**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **filterField**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:675](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L675)

***

### filterValue

#### Get Signature

> **get** **filterValue**(): `any`

##### Returns

`any`

#### Set Signature

> **set** **filterValue**(`value`): `void`

##### Parameters

###### value

`any`

##### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:691](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L691)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`props`](CheckTreeEditor.md#props)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`readOnly`](CheckTreeEditor.md#readonly)

#### Defined in

[src/ui/datagrid/datagrid.tsx:980](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L980)

***

### value

#### Get Signature

> **get** **value**(): `string`[]

##### Returns

`string`[]

#### Set Signature

> **set** **value**(`v`): `void`

##### Parameters

###### v

`string`[]

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`value`](CheckTreeEditor.md#value)

#### Defined in

[src/ui/editors/checktreeeditor.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L418)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addBooleanFilter`](CheckTreeEditor.md#addbooleanfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1115)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addCssClass`](CheckTreeEditor.md#addcssclass)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addDateRangeFilter`](CheckTreeEditor.md#adddaterangefilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addDateTimeRangeFilter`](CheckTreeEditor.md#adddatetimerangefilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1107)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addFilterSeparator`](CheckTreeEditor.md#addfilterseparator)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addQuickFilter`](CheckTreeEditor.md#addquickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addValidationRule`](CheckTreeEditor.md#addvalidationrule)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addValidationRule`](CheckTreeEditor.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterInit()

> `protected` **afterInit**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`afterInit`](CheckTreeEditor.md#afterinit)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`afterRender`](CheckTreeEditor.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### allDescendantsSelected()

> `protected` **allDescendantsSelected**(`item`): `boolean`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allDescendantsSelected`](CheckTreeEditor.md#alldescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L286)

***

### allItemsSelected()

> `protected` **allItemsSelected**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allItemsSelected`](CheckTreeEditor.md#allitemsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L275)

***

### anyDescendantsSelected()

> `protected` **anyDescendantsSelected**(`item`): `boolean`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`anyDescendantsSelected`](CheckTreeEditor.md#anydescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L306)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`bindToSlickEvents`](CheckTreeEditor.md#bindtoslickevents)

#### Defined in

[src/ui/datagrid/datagrid.tsx:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L525)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`bindToViewEvents`](CheckTreeEditor.md#bindtoviewevents)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`booleanQuickFilter`](CheckTreeEditor.md#booleanquickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`byId`](CheckTreeEditor.md#byid)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`canFilterColumn`](CheckTreeEditor.md#canfiltercolumn)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`canShowColumn`](CheckTreeEditor.md#canshowcolumn)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1154)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `TItem`[]

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L529)

***

### change()

> **change**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`change`](CheckTreeEditor.md#change)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`changeSelect2`](CheckTreeEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createFilterBar`](CheckTreeEditor.md#createfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L753)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createIncludeDeletedButton`](CheckTreeEditor.md#createincludedeletedbutton)

#### Defined in

[src/ui/datagrid/datagrid.tsx:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L305)

***

### createPager()

> `protected` **createPager**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createPager`](CheckTreeEditor.md#createpager)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`createQuickFilters`](CheckTreeEditor.md#createquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L203)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createQuickSearchInput`](CheckTreeEditor.md#createquicksearchinput)

#### Defined in

[src/ui/datagrid/datagrid.tsx:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L314)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSlickContainer`](CheckTreeEditor.md#createslickcontainer)

#### Defined in

[src/ui/datagrid/datagrid.tsx:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L707)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSlickGrid`](CheckTreeEditor.md#createslickgrid)

#### Defined in

[src/ui/editors/checktreeeditor.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L120)

***

### createToolbar()

> `protected` **createToolbar**(`buttons`): `void`

#### Parameters

##### buttons

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createToolbar`](CheckTreeEditor.md#createtoolbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:794](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L794)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`createToolbarExtensions`](CheckTreeEditor.md#createtoolbarextensions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L513)

***

### createView()

> `protected` **createView**(): [`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createView`](CheckTreeEditor.md#createview)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`dateRangeQuickFilter`](CheckTreeEditor.md#daterangequickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`dateTimeRangeQuickFilter`](CheckTreeEditor.md#datetimerangequickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1111)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`deferRender`](CheckTreeEditor.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`destroy`](CheckTreeEditor.md#destroy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L491)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

#### Parameters

##### getKey

(`prefix`) => `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`determineText`](CheckTreeEditor.md#determinetext)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`editItem`](CheckTreeEditor.md#edititem)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`editItemOfType`](CheckTreeEditor.md#edititemoftype)

#### Defined in

[src/ui/datagrid/datagrid.tsx:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L595)

***

### enableFiltering()

> `protected` **enableFiltering**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`enableFiltering`](CheckTreeEditor.md#enablefiltering)

#### Defined in

[src/ui/datagrid/datagrid.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L745)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<[`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`ensureQuickFilterBar`](CheckTreeEditor.md#ensurequickfilterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L195)

***

### filterItems()

> `protected` **filterItems**(`items`): `TItem`[]

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L551)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`findById`](CheckTreeEditor.md#findbyid)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`findQuickFilter`](CheckTreeEditor.md#findquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L289)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L635)

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:591](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L591)

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:651](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L651)

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:671](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L671)

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L687)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`get_readOnly`](CheckTreeEditor.md#get_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:396](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L396)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getAddButtonCaption`](CheckTreeEditor.md#getaddbuttoncaption)

#### Defined in

[src/ui/datagrid/datagrid.tsx:583](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L583)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getButtons`](CheckTreeEditor.md#getbuttons)

#### Defined in

[src/ui/editors/checktreeeditor.ts:509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L509)

***

### getCascadeFromValue()

> `protected` **getCascadeFromValue**(`parent`): `any`

#### Parameters

##### parent

[`Widget`](Widget.md)\<`any`\>

#### Returns

`any`

#### Defined in

[src/ui/editors/checktreeeditor.ts:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L599)

***

### getColumns()

> `protected` **getColumns**(): `Column`\<`any`\>[]

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumns`](CheckTreeEditor.md#getcolumns)

#### Defined in

[src/ui/editors/checktreeeditor.ts:321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L321)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnsKey`](CheckTreeEditor.md#getcolumnskey)

#### Defined in

[src/ui/datagrid/datagrid.tsx:848](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L848)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

#### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnWidthDelta`](CheckTreeEditor.md#getcolumnwidthdelta)

#### Defined in

[src/ui/datagrid/datagrid.tsx:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L415)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

#### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnWidthScale`](CheckTreeEditor.md#getcolumnwidthscale)

#### Defined in

[src/ui/datagrid/datagrid.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L419)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCssClass`](CheckTreeEditor.md#getcssclass)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCurrentSettings`](CheckTreeEditor.md#getcurrentsettings)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCustomAttribute`](CheckTreeEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDefaultSortBy`](CheckTreeEditor.md#getdefaultsortby)

#### Defined in

[src/ui/datagrid/datagrid.tsx:716](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L716)

***

### getDelimited()

> `protected` **getDelimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDelimited`](CheckTreeEditor.md#getdelimited)

#### Defined in

[src/ui/editors/checktreeeditor.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L302)

***

### getDescendantsSelected()

> `protected` **getDescendantsSelected**(`item`): `boolean`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDescendantsSelected`](CheckTreeEditor.md#getdescendantsselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L254)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

##### target

`any`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getEditValue`](CheckTreeEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L71)

***

### getElement()

> **getElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getElement`](CheckTreeEditor.md#getelement)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1457)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getFilterStore`](CheckTreeEditor.md#getfilterstore)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1469)

***

### getGrid()

> **getGrid**(): `Grid`\<`any`\>

#### Returns

`Grid`\<`any`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGrid`](CheckTreeEditor.md#getgrid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1461)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGridCanLoad`](CheckTreeEditor.md#getgridcanload)

#### Defined in

[src/ui/datagrid/datagrid.tsx:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L939)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGridField`](CheckTreeEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIdProperty`](CheckTreeEditor.md#getidproperty)

#### Defined in

[src/ui/editors/checktreeeditor.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L42)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

#### Parameters

##### include

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIncludeColumns`](CheckTreeEditor.md#getincludecolumns)

#### Defined in

[src/ui/datagrid/datagrid.tsx:653](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L653)

***

### getInitialCollapse()

> `protected` **getInitialCollapse**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getInitialCollapse`](CheckTreeEditor.md#getinitialcollapse)

#### Defined in

[src/ui/editors/checktreeeditor.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L153)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getInitialTitle`](CheckTreeEditor.md#getinitialtitle)

#### Defined in

[src/ui/datagrid/datagrid.tsx:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L188)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIsActiveProperty`](CheckTreeEditor.md#getisactiveproperty)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIsDeletedProperty`](CheckTreeEditor.md#getisdeletedproperty)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1046](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1046)

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

##### index

`number`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemCssClass`](CheckTreeEditor.md#getitemcssclass)

#### Defined in

[src/ui/datagrid/datagrid.tsx:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L353)

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

##### index

`number`

#### Returns

`any`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemMetadata`](CheckTreeEditor.md#getitemmetadata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L386)

***

### getItems()

> **getItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItems`](CheckTreeEditor.md#getitems)

#### Defined in

[src/ui/datagrid/datagrid.tsx:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L517)

***

### getItemText()

> `protected` **getItemText**(`ctx`): `string`

#### Parameters

##### ctx

`FormatterContext`\<`any`\>

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemText`](CheckTreeEditor.md#getitemtext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L352)

***

### getItemType()

> `protected` **getItemType**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemType`](CheckTreeEditor.md#getitemtype)

#### Defined in

[src/ui/datagrid/datagrid.tsx:830](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L830)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getLocalTextDbPrefix`](CheckTreeEditor.md#getlocaltextdbprefix)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1009](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1009)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getLocalTextPrefix`](CheckTreeEditor.md#getlocaltextprefix)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1021](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1021)

***

### getLookupItems()

> `protected` **getLookupItems**(`lookup`): `TItem`[]

#### Parameters

##### lookup

[`Lookup`](Lookup.md)\<`TItem`\>

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/checktreeeditor.ts:567](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L567)

***

### getLookupKey()

> `protected` **getLookupKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/checktreeeditor.ts:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L505)

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPagerOptions`](CheckTreeEditor.md#getpageroptions)

#### Defined in

[src/ui/datagrid/datagrid.tsx:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L760)

***

### getPersistanceKey()

> `protected` **getPersistanceKey**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistanceKey`](CheckTreeEditor.md#getpersistancekey)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1139)

***

### getPersistanceStorage()

> `protected` **getPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistanceStorage`](CheckTreeEditor.md#getpersistancestorage)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1135)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistedSettings`](CheckTreeEditor.md#getpersistedsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1175)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItems`](CheckTreeEditor.md#getpropertyitems)

#### Defined in

[src/ui/datagrid/datagrid.tsx:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L852)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItemsData`](CheckTreeEditor.md#getpropertyitemsdata)

#### Defined in

[src/ui/datagrid/datagrid.tsx:856](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L856)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItemsDataAsync`](CheckTreeEditor.md#getpropertyitemsdataasync)

#### Defined in

[src/ui/datagrid/datagrid.tsx:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L876)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getQuickFilters`](CheckTreeEditor.md#getquickfilters)

#### Defined in

[src/ui/datagrid/datagrid.tsx:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L225)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getQuickSearchFields`](CheckTreeEditor.md#getquicksearchfields)

#### Defined in

[src/ui/datagrid/datagrid.tsx:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L310)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getRowDefinition`](CheckTreeEditor.md#getrowdefinition)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1003)

***

### getSelectAllText()

> `protected` **getSelectAllText**(): `string`

#### Returns

`string`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getSelectAllText`](CheckTreeEditor.md#getselectalltext)

#### Defined in

[src/ui/editors/checktreeeditor.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L522)

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`\<`any`\>

#### Returns

`GridOptions`\<`any`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getSlickOptions`](CheckTreeEditor.md#getslickoptions)

#### Defined in

[src/ui/editors/checktreeeditor.ts:356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L356)

***

### getTitle()

> **getTitle**(): `string`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getTitle`](CheckTreeEditor.md#gettitle)

#### Defined in

[src/ui/datagrid/datagrid.tsx:802](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L802)

***

### getTreeItems()

> `protected` **getTreeItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getTreeItems`](CheckTreeEditor.md#gettreeitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L571)

***

### getView()

> **getView**(): [`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`RemoteView`](RemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getView`](CheckTreeEditor.md#getview)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1465)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getViewOptions`](CheckTreeEditor.md#getviewoptions)

#### Defined in

[src/ui/datagrid/datagrid.tsx:772](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L772)

***

### gridPersistanceFlags()

> `protected` **gridPersistanceFlags**(): [`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Returns

[`GridPersistanceFlags`](../interfaces/GridPersistanceFlags.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`gridPersistanceFlags`](CheckTreeEditor.md#gridpersistanceflags)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1150)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`init`](CheckTreeEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initializeFilterBar`](CheckTreeEditor.md#initializefilterbar)

#### Defined in

[src/ui/datagrid/datagrid.tsx:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L445)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initialPopulate`](CheckTreeEditor.md#initialpopulate)

#### Defined in

[src/ui/datagrid/datagrid.tsx:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L423)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`internalRefresh`](CheckTreeEditor.md#internalrefresh)

#### Defined in

[src/ui/datagrid/datagrid.tsx:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L963)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`internalRenderContents`](CheckTreeEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`invokeSubmitHandlers`](CheckTreeEditor.md#invokesubmithandlers)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1123)

***

### isThreeStateHierarchy()

> `protected` **isThreeStateHierarchy**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`isThreeStateHierarchy`](CheckTreeEditor.md#isthreestatehierarchy)

#### Defined in

[src/ui/editors/checktreeeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L116)

***

### itemAt()

> **itemAt**(`row`): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Parameters

##### row

`number`

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemAt`](CheckTreeEditor.md#itemat)

#### Defined in

[src/ui/datagrid/datagrid.tsx:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L505)

***

### itemId()

> **itemId**(`item`): `any`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`any`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemId`](CheckTreeEditor.md#itemid)

#### Defined in

[src/ui/datagrid/datagrid.tsx:509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L509)

***

### itemLink()

> `protected` **itemLink**(`itemType`?, `idField`?, `text`?, `cssClass`?, `encode`?): [`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Parameters

##### itemType?

`string`

##### idField?

`string`

##### text?

[`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

##### cssClass?

(`ctx`) => `string`

##### encode?

`boolean` = `true`

#### Returns

[`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemLink`](CheckTreeEditor.md#itemlink)

#### Defined in

[src/ui/datagrid/datagrid.tsx:834](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L834)

***

### itemSelectedChanged()

> `protected` **itemSelectedChanged**(`item`): `void`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemSelectedChanged`](CheckTreeEditor.md#itemselectedchanged)

#### Defined in

[src/ui/editors/checktreeeditor.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L109)

***

### layout()

> `protected` **layout**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`layout`](CheckTreeEditor.md#layout)

#### Defined in

[src/ui/datagrid/datagrid.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L166)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`legacyTemplateRender`](CheckTreeEditor.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### markupReady()

> `protected` **markupReady**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`markupReady`](CheckTreeEditor.md#markupready)

#### Defined in

[src/ui/datagrid/datagrid.tsx:704](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L704)

***

### moveSelectedUp()

> `protected` **moveSelectedUp**(): `boolean`

#### Returns

`boolean`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`moveSelectedUp`](CheckTreeEditor.md#moveselectedup)

#### Defined in

[src/ui/editors/checktreeeditor.ts:587](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L587)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`onClick`](CheckTreeEditor.md#onclick)

#### Defined in

[src/ui/editors/checktreeeditor.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L168)

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`boolean`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewFilter`](CheckTreeEditor.md#onviewfilter)

#### Defined in

[src/ui/editors/checktreeeditor.ts:581](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L581)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewProcessData`](CheckTreeEditor.md#onviewprocessdata)

#### Defined in

[src/ui/editors/checktreeeditor.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L157)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewSubmit`](CheckTreeEditor.md#onviewsubmit)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistSettings`](CheckTreeEditor.md#persistsettings)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1357)

***

### populateLock()

> `protected` **populateLock**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateLock`](CheckTreeEditor.md#populatelock)

#### Defined in

[src/ui/datagrid/datagrid.tsx:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L931)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateUnlock`](CheckTreeEditor.md#populateunlock)

#### Defined in

[src/ui/datagrid/datagrid.tsx:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L935)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateWhenVisible`](CheckTreeEditor.md#populatewhenvisible)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`postProcessColumns`](CheckTreeEditor.md#postprocesscolumns)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsReady`](CheckTreeEditor.md#propertyitemsready)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsToSlickColumns`](CheckTreeEditor.md#propertyitemstoslickcolumns)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFilterChange`](CheckTreeEditor.md#quickfilterchange)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1129)

***

### refresh()

> **refresh**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`refresh`](CheckTreeEditor.md#refresh)

#### Defined in

[src/ui/datagrid/datagrid.tsx:943](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L943)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`refreshIfNeeded`](CheckTreeEditor.md#refreshifneeded)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`render`](CheckTreeEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`renderContents`](CheckTreeEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`resizeCanvas`](CheckTreeEditor.md#resizecanvas)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoreSettings`](CheckTreeEditor.md#restoresettings)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoreSettingsFrom`](CheckTreeEditor.md#restoresettingsfrom)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1205)

***

### rowCount()

> **rowCount**(): `number`

#### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`rowCount`](CheckTreeEditor.md#rowcount)

#### Defined in

[src/ui/datagrid/datagrid.tsx:513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L513)

***

### set\_cascadeField()

> `protected` **set\_cascadeField**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L643)

***

### set\_cascadeFrom()

> `protected` **set\_cascadeFrom**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L624)

***

### set\_cascadeValue()

> `protected` **set\_cascadeValue**(`value`): `void`

#### Parameters

##### value

`any`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L659)

***

### set\_filterField()

> `protected` **set\_filterField**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:679](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L679)

***

### set\_filterValue()

> `protected` **set\_filterValue**(`value`): `void`

#### Parameters

##### value

`any`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:695](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L695)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`set_readOnly`](CheckTreeEditor.md#set_readonly)

#### Defined in

[src/ui/editors/checktreeeditor.ts:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L400)

***

### setAllSubTreeSelected()

> `protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

##### selected

`boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setAllSubTreeSelected`](CheckTreeEditor.md#setallsubtreeselected)

#### Defined in

[src/ui/editors/checktreeeditor.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L258)

***

### setCascadeFrom()

> `protected` **setCascadeFrom**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/checktreeeditor.ts:605](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L605)

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setCriteriaParameter`](CheckTreeEditor.md#setcriteriaparameter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L668)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

#### Parameters

##### source

`any`

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setEditValue`](CheckTreeEditor.md#seteditvalue)

#### Defined in

[src/ui/editors/checktreeeditor.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L78)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`setEquality`](CheckTreeEditor.md#setequality)

#### Defined in

[src/ui/datagrid/datagrid.tsx:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L678)

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setIncludeColumnsParameter`](CheckTreeEditor.md#setincludecolumnsparameter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L682)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setInitialSortOrder`](CheckTreeEditor.md#setinitialsortorder)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`setIsDisabled`](CheckTreeEditor.md#setisdisabled)

#### Defined in

[src/ui/datagrid/datagrid.tsx:967](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L967)

***

### setItems()

> **setItems**(`value`): `void`

#### Parameters

##### value

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setItems`](CheckTreeEditor.md#setitems)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`setTitle`](CheckTreeEditor.md#settitle)

#### Defined in

[src/ui/datagrid/datagrid.tsx:810](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L810)

***

### sortItems()

> `protected` **sortItems**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`sortItems`](CheckTreeEditor.md#sortitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L362)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`subDialogDataChange`](CheckTreeEditor.md#subdialogdatachange)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`syncOrAsyncThen`](CheckTreeEditor.md#syncorasyncthen)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`tryFindQuickFilter`](CheckTreeEditor.md#tryfindquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L297)

***

### updateDisabledState()

> `protected` **updateDisabledState**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateDisabledState`](CheckTreeEditor.md#updatedisabledstate)

#### Defined in

[src/ui/datagrid/datagrid.tsx:1067](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1067)

***

### updateFlags()

> `protected` **updateFlags**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateFlags`](CheckTreeEditor.md#updateflags)

#### Defined in

[src/ui/editors/checktreeeditor.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L217)

***

### updateInterface()

> **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateInterface`](CheckTreeEditor.md#updateinterface)

#### Defined in

[src/ui/datagrid/datagrid.tsx:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L999)

***

### updateItems()

> `protected` **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateItems`](CheckTreeEditor.md#updateitems)

#### Defined in

[src/ui/editors/checktreeeditor.ts:500](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L500)

***

### updateSelectAll()

> `protected` **updateSelectAll**(): `void`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateSelectAll`](CheckTreeEditor.md#updateselectall)

#### Defined in

[src/ui/editors/checktreeeditor.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L211)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useAsync`](CheckTreeEditor.md#useasync)

#### Defined in

[src/ui/datagrid/datagrid.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L158)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useIdPrefix`](CheckTreeEditor.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useLayoutTimer`](CheckTreeEditor.md#uselayouttimer)

#### Defined in

[src/ui/datagrid/datagrid.tsx:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L162)

***

### usePager()

> `protected` **usePager**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`usePager`](CheckTreeEditor.md#usepager)

#### Defined in

[src/ui/datagrid/datagrid.tsx:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L741)

***

### viewDataChanged()

> `protected` **viewDataChanged**(`e`, `rows`): `void`

#### Parameters

##### e

`any`

##### rows

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`viewDataChanged`](CheckTreeEditor.md#viewdatachanged)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`wrapFormatterWithEditLink`](CheckTreeEditor.md#wrapformatterwitheditlink)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`create`](CheckTreeEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createDefaultElement`](CheckTreeEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/checktreeeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L31)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getWidgetName`](CheckTreeEditor.md#getwidgetname)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemToQuickFilter`](CheckTreeEditor.md#propertyitemtoquickfilter)

#### Defined in

[src/ui/datagrid/datagrid.tsx:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L235)
