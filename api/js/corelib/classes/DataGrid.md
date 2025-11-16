[corelib](../README.md) / DataGrid

# Class: DataGrid\<TItem, P\>

Defined in: [src/ui/datagrid/datagrid.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L37)

## Extends

- [`Widget`](Widget.md)\<`P`\>

## Extended by

- [`EntityGrid`](EntityGrid.md)
- [`CheckTreeEditor`](CheckTreeEditor.md)

## Type Parameters

### TItem

`TItem`

### P

`P` = \{ \}

## Implements

- [`IDataGrid`](../interfaces/IDataGrid.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new DataGrid**\<`TItem`, `P`\>(`props`): `DataGrid`\<`TItem`, `P`\>

Defined in: [src/ui/datagrid/datagrid.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L76)

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

`DataGrid`\<`TItem`, `P`\>

#### Overrides

[`Widget`](Widget.md).[`constructor`](Widget.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`Widget`](Widget.md).[`domNode`](Widget.md#domnode)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L47)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`Widget`](Widget.md).[`idPrefix`](Widget.md#idprefix)

***

### onAfterInit

> `readonly` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L68)

***

### onCanSubmit

> `readonly` **onCanSubmit**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

***

### onDataChanged

> `readonly` **onDataChanged**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L70)

***

### onFiltering

> `readonly` **onFiltering**: `PubSub`\<[`DataGridFilteringEvent`](../interfaces/DataGridFilteringEvent.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L71)

***

### onPersistence

> `readonly` **onPersistence**: `PubSub`\<[`DataGridPersistenceEvent`](../interfaces/DataGridPersistenceEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

***

### onProcessData

> `readonly` **onProcessData**: `PubSub`\<[`DataGridProcessEvent`](../interfaces/DataGridProcessEvent.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L73)

***

### onSubmitting

> `readonly` **onSubmitting**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L74)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L55)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`Widget`](Widget.md).[`options`](Widget.md#options)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L51)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L49)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L48)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

Defined in: [src/ui/datagrid/datagrid.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L52)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L50)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L45)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L46)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`Widget`](Widget.md).[`uniqueName`](Widget.md#uniquename)

***

### view

> **view**: [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L53)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/datagrid/datagrid.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L39)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`Widget`](Widget.md).[`[typeInfo]`](Widget.md#typeinfo)

***

### defaultOptions

> `readonly` `static` **defaultOptions**: `object` = `dataGridDefaults`

Defined in: [src/ui/datagrid/datagrid.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L57)

#### columnWidthDelta

> **columnWidthDelta**: `number`

Default column width delta. This value if specified, is added to the width of columns defined server side. Default is null

#### columnWidthScale

> **columnWidthScale**: `number`

Default column width scale. This value if specified, is multiplied with the width of columns defined server side. Default is null

#### enableAdvancedFiltering

> **enableAdvancedFiltering**: `boolean` \| (`grid`) => `boolean`

Controls whether to enable advanced filtering, e.g. via filter dialog/bar. Default is null.

#### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

Controls whether to open dialogs as panels. Default is null.

#### persistenceFlags

> **persistenceFlags**: [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md) = `defaultGridPersistenceFlags`

Default persistence flags. Defaults are true except quickSearch and quickFilterText

#### persistenceStorage

> **persistenceStorage**: [`SettingStorage`](../interfaces/SettingStorage.md)

Default persistence storage. Default is null

#### rowHeight

> **rowHeight**: `number`

Default row height. Default is null.

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`Widget`](Widget.md).[`isComponent`](Widget.md#iscomponent)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L67)

## Accessors

### allColumns

#### Get Signature

> **get** **allColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1260)

##### Returns

`Column`\<`any`\>[]

***

### columns

#### Get Signature

> **get** **columns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1261)

##### Returns

`Column`\<`TItem`\>[]

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`Widget`](Widget.md).[`element`](Widget.md#element)

***

### initialSettings

#### Get Signature

> **get** **initialSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1262)

##### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Set Signature

> **set** **initialSettings**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1263)

##### Parameters

###### value

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### Returns

`void`

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`props`](Widget.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:921](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L921)

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:925](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L925)

##### Parameters

###### value

`boolean`

##### Returns

`void`

***

### sleekGrid

#### Get Signature

> **get** **sleekGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1246)

##### Returns

`ISleekGrid`\<`TItem`\>

#### Set Signature

> **set** **sleekGrid**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1247)

##### Parameters

###### value

`ISleekGrid`\<`TItem`\>

##### Returns

`void`

***

### slickGrid

#### Get Signature

> **get** **slickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1250)

##### Deprecated

Use sleekGrid or getGrid()

##### Returns

`ISleekGrid`\<`TItem`\>

***

### defaultColumnWidthDelta

#### Get Signature

> **get** `static` **defaultColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L64)

##### Returns

`number`

#### Set Signature

> **set** `static` **defaultColumnWidthDelta**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L65)

##### Parameters

###### value

`number`

##### Returns

`void`

***

### defaultColumnWidthScale

#### Get Signature

> **get** `static` **defaultColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L62)

##### Returns

`number`

#### Set Signature

> **set** `static` **defaultColumnWidthScale**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L63)

##### Parameters

###### value

`number`

##### Returns

`void`

***

### defaultPersistanceStorage

#### Get Signature

> **get** `static` **defaultPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1266)

##### Obsolete

use defaultPersistenceStorage, this one has a typo

##### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Set Signature

> **set** `static` **defaultPersistanceStorage**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1268)

##### Obsolete

use defaultPersistenceStorage, this one has a typo

##### Parameters

###### value

[`SettingStorage`](../interfaces/SettingStorage.md)

##### Returns

`void`

***

### defaultPersistenceStorage

#### Get Signature

> **get** `static` **defaultPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L60)

##### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Set Signature

> **set** `static` **defaultPersistenceStorage**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L61)

##### Parameters

###### value

[`SettingStorage`](../interfaces/SettingStorage.md)

##### Returns

`void`

***

### defaultRowHeight

#### Get Signature

> **get** `static` **defaultRowHeight**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L59)

##### Returns

`number`

## Methods

### addBooleanFilter()

> `protected` **addBooleanFilter**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](SelectEditor.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1044](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1044)

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

[`SelectEditor`](SelectEditor.md)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`addCssClass`](Widget.md#addcssclass)

***

### addDateRangeFilter()

> `protected` **addDateRangeFilter**(`field`, `title?`): [`DateEditor`](DateEditor.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1028](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1028)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateEditor`](DateEditor.md)

***

### addDateTimeRangeFilter()

> `protected` **addDateTimeRangeFilter**(`field`, `title?`): [`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1036](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1036)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1008](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1008)

#### Returns

`void`

***

### addQuickFilter()

> `protected` **addQuickFilter**\<`TWidget`, `P`\>(`opt`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:1024](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1024)

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`any`\>

##### P

`P`

#### Parameters

##### opt

[`QuickFilter`](../interfaces/QuickFilter.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L96)

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L150)

#### Returns

`void`

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`afterRender`](Widget.md#afterrender)

***

### autoRegisteringPlugin()

> `protected` **autoRegisteringPlugin**(`args`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L103)

#### Parameters

##### args

[`AutoRegisterArgs`](../interfaces/AutoRegisterArgs.md)

#### Returns

`void`

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L478)

#### Returns

`void`

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L529)

#### Returns

`void`

***

### booleanQuickFilter()

> `protected` **booleanQuickFilter**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1048)

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

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L102)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`Widget`](Widget.md).[`byId`](Widget.md#byid)

***

### canFilterColumn()

> `protected` **canFilterColumn**(`column`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L359)

#### Parameters

##### column

`Column`

#### Returns

`boolean`

***

### canShowColumn()

> `protected` **canShowColumn**(`column`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1089](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1089)

#### Parameters

##### column

`Column`

#### Returns

`boolean`

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`change`](Widget.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`changeSelect2`](Widget.md#changeselect2)

***

### createColumns()

> `protected` **createColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L389)

Creates initial column set for this grid. This column set is then passed
to postProcessColumns to adjust widths etc, and then used as the initial
columns for the slickgrid.

#### Returns

`Column`\<`TItem`\>[]

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L650)

#### Returns

`void`

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L250)

#### Returns

`void`

***

### createPager()

> `protected` **createPager**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L668)

#### Returns

`void`

***

### createQuickFilters()

> `protected` **createQuickFilters**(`filters?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L198)

#### Parameters

##### filters?

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

`void`

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L259)

#### Returns

`void`

***

### createSleekColumns()

> `protected` **createSleekColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L398)

Creates the SleekGrid columns. This method calls createColumns (via getColumns for compatibility) and then post processes them.

#### Returns

`Column`\<`TItem`\>[]

The SleekGrid columns.

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:622](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L622)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L404)

Override initSleekGrid to add plugins to the sleekgrid

#### Returns

`ISleekGrid`\<`TItem`\>

***

### createToolbar()

> `protected` **createToolbar**(`buttons`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L694)

#### Parameters

##### buttons

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

`void`

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L187)

#### Returns

`void`

***

### createView()

> `protected` **createView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L626)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

***

### dateRangeQuickFilter()

> `protected` **dateRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1032](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1032)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

***

### dateTimeRangeQuickFilter()

> `protected` **dateTimeRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1040](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1040)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`deferRender`](Widget.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L264)

#### Returns

`void`

#### Overrides

[`Widget`](Widget.md).[`destroy`](Widget.md#destroy)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1012)

#### Parameters

##### getKey

(`prefix`) => `string`

#### Returns

`string`

***

### editItem()

> `protected` **editItem**(`entityOrId`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:494](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L494)

#### Parameters

##### entityOrId

`any`

#### Returns

`void`

***

### editItemOfType()

> `protected` **editItemOfType**(`itemType`, `entityOrId`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:498](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L498)

#### Parameters

##### itemType

`string`

##### entityOrId

`any`

#### Returns

`void`

***

### EditLink()

> **EditLink**(`props`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L740)

Renders an edit link for the item in current row. Returns a DocumentFragment for non-data rows, and an anchor element otherwise.

#### Parameters

##### props

###### children?

`any`

The link text. If not provided it will be taken from ctx.escape(ctx.value)

###### context?

`FormatterContext`

formatter context (contains item, value etc)

###### cssClass?

`string`

Extra CSS class to add to the link element besides s-EditLink. Optional.

###### id?

`string`

The id of the entity to link to. If not provided it will be taken from ctx.item[idField]

###### idField?

`string`

The name of the field in item that contains the entity id. Defaults to idProperty. Used if id is not provided.

###### itemType?

`string`

The item type to link to. Defaults to this.getItemType()

###### tabindex?

`number`

The tabindex to assign to the link, default is undefined

###### tabIndex?

`number`

**Deprecated**

Use tabindex.

#### Returns

`any`

***

### enableAdvancedFiltering()

> `protected` **enableAdvancedFiltering**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L639)

#### Returns

`boolean`

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L190)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L376)

#### Returns

`void`

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`Widget`](Widget.md).[`findById`](Widget.md#findbyid)

***

### findQuickFilter()

> `protected` **findQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L234)

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### type

(...`args`) => `TWidget`

##### field

`string`

#### Returns

`TWidget`

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:929](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L929)

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L486)

#### Returns

`string`

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:490](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L490)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

***

### ~~getColumns()~~

> `protected` **getColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:822](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L822)

#### Returns

`Column`\<`TItem`\>[]

#### Deprecated

override createColumns

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:784](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L784)

#### Returns

`string`

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L336)

#### Returns

`number`

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L340)

#### Returns

`number`

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getCssClass`](Widget.md#getcssclass)

***

### getCurrentSettings()

> **getCurrentSettings**(`flags?`): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1208)

#### Parameters

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`Widget`](Widget.md).[`getCustomAttribute`](Widget.md#getcustomattribute)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

Defined in: [src/ui/datagrid/datagrid.tsx:631](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L631)

#### Returns

`any`[]

***

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/datagrid.tsx:1238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1238)

#### Returns

`HTMLElement`

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getElement`](../interfaces/IDataGrid.md#getelement)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1256)

#### Returns

[`FilterStore`](FilterStore.md)

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getFilterStore`](../interfaces/IDataGrid.md#getfilterstore)

***

### getGrid()

> **getGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1242)

#### Returns

`ISleekGrid`\<`TItem`\>

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getGrid`](../interfaces/IDataGrid.md#getgrid)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:874](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L874)

#### Returns

`boolean`

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`Widget`](Widget.md).[`getGridField`](Widget.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:972](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L972)

#### Returns

`string`

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L570)

#### Parameters

##### include

#### Returns

`void`

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L183)

#### Returns

`string`

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:989](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L989)

#### Returns

`string`

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:983](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L983)

#### Returns

`string`

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L303)

#### Parameters

##### item

`TItem`

##### index

`number`

#### Returns

`string`

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L307)

#### Parameters

##### item

`TItem`

##### index

`number`

#### Returns

`any`

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/ui/datagrid/datagrid.tsx:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L453)

#### Returns

`TItem`[]

***

### getItemType()

> `protected` **getItemType**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:730](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L730)

#### Returns

`string`

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:950](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L950)

#### Returns

`string`

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:962](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L962)

#### Returns

`string`

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

Defined in: [src/ui/datagrid/datagrid.tsx:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L660)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1110)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

***

### getPersistenceKey()

> `protected` **getPersistenceKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1070](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1070)

#### Returns

`string`

***

### getPersistenceStorage()

> `protected` **getPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1064](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1064)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L788)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:792](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L792)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:812](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L812)

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L220)

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L255)

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/datagrid/datagrid.tsx:944](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L944)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`

Defined in: [src/ui/datagrid/datagrid.tsx:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L852)

#### Returns

`GridOptions`

***

### getTitle()

> **getTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L702)

#### Returns

`string`

***

### getView()

> **getView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1252)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

#### Implementation of

[`IDataGrid`](../interfaces/IDataGrid.md).[`getView`](../interfaces/IDataGrid.md#getview)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L672)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

***

### gridPersistenceFlags()

> `protected` **gridPersistenceFlags**(): [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1083)

#### Returns

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

***

### handleGridClick()

> `protected` **handleGridClick**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L466)

#### Parameters

##### e

`CellMouseEvent`

#### Returns

`void`

***

### handleGridColumnsReordered()

> `protected` **handleGridColumnsReordered**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L470)

#### Returns

`void`

***

### handleGridColumnsResized()

> `protected` **handleGridColumnsResized**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L474)

#### Returns

`void`

***

### handleGridSort()

> `protected` **handleGridSort**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L461)

#### Parameters

##### e

`GridSortEvent`

#### Returns

`void`

***

### handleViewFilter()

> `protected` **handleViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:537](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L537)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

***

### handleViewProcessData()

> `protected` **handleViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L546)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

***

### handleViewSubmit()

> `protected` **handleViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L553)

#### Returns

`boolean`

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`Widget`](Widget.md).[`init`](Widget.md#init)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L366)

#### Returns

`void`

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L344)

#### Returns

`void`

***

### initSleekGrid()

> `protected` **initSleekGrid**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L413)

#### Returns

`void`

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:915](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L915)

#### Returns

`void`

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`internalRenderContents`](Widget.md#internalrendercontents)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

#### Returns

`void`

***

### itemAt()

> **itemAt**(`row`): `TItem`

Defined in: [src/ui/datagrid/datagrid.tsx:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L441)

#### Parameters

##### row

`number`

#### Returns

`TItem`

***

### itemId()

> **itemId**(`item`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L445)

#### Parameters

##### item

`TItem`

#### Returns

`any`

***

### itemLink()

> `protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../type-aliases/Format.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:734](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L734)

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

***

### layout()

> `protected` **layout**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L161)

#### Returns

`void`

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`legacyTemplateRender`](Widget.md#legacytemplaterender)

***

### markupReady()

> `protected` **markupReady**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L618)

#### Returns

`void`

***

### onClick()

> `protected` **onClick**(`e`, `row`, `cell`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L507)

#### Parameters

##### e

`Event`

##### row

`number`

##### cell

`number`

#### Returns

`void`

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L566)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L562)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:609](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L609)

#### Returns

`boolean`

***

### persistenceLock()

> **persistenceLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1187)

#### Returns

`void`

***

### persistenceUnlock()

> **persistenceUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1191)

#### Returns

`void`

***

### persistSettings()

> **persistSettings**(`flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1195)

#### Parameters

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

`void` \| `Promise`\<`void`\>

***

### populateLock()

> `protected` **populateLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:866](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L866)

#### Returns

`void`

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:870](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L870)

#### Returns

`void`

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L646)

#### Returns

`boolean`

***

### postProcessColumns()

> `protected` **postProcessColumns**(`columns`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L315)

#### Parameters

##### columns

`Column`\<`any`\>[]

#### Returns

`Column`\<`any`\>[]

***

### prepareSubmit()

> **prepareSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:886](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L886)

Prepares submit arguments in this.view.params by calling this.view.onSubmit if available, or this.handleViewSubmit if not. 
Note that if getGridCanLoad returns false, the prepared arguments might be in a incomplete state.

#### Returns

`boolean`

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L112)

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

`void`

***

### propertyItemsToColumns()

> `protected` **propertyItemsToColumns**(`propertyItems`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:841](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L841)

#### Parameters

##### propertyItems

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

`Column`\<`any`\>[]

***

### quickFilterChange()

> `protected` **quickFilterChange**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1058](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1058)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### refresh()

> **refresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L895)

#### Returns

`void`

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L908)

#### Returns

`void`

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`render`](Widget.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`renderContents`](Widget.md#rendercontents)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1000)

#### Returns

`void`

***

### restoreSettings()

> `protected` **restoreSettings**(`settings?`, `flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1129)

#### Parameters

##### settings?

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

`void` \| `Promise`\<`void`\>

***

### restoreSettingsFrom()

> `protected` **restoreSettingsFrom**(`settings`, `flags?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1140)

#### Parameters

##### settings

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

`void`

***

### rowCount()

> **rowCount**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:449](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L449)

#### Returns

`number`

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:933](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L933)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:585](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L585)

#### Returns

`void`

***

### setEquality()

> `protected` **setEquality**(`field`, `value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L595)

#### Parameters

##### field

`string`

##### value

`any`

#### Returns

`void`

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L599)

#### Returns

`void`

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L416)

#### Returns

`void`

***

### setItems()

> **setItems**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L457)

#### Parameters

##### value

`TItem`[]

#### Returns

`void`

***

### setTitle()

> **setTitle**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L710)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1004](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1004)

#### Returns

`void`

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

#### Type Parameters

##### T

`T`

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

***

### tryFindQuickFilter()

> `protected` **tryFindQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L242)

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### type

(...`args`) => `TWidget`

##### field

`string`

#### Returns

`TWidget`

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:940](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L940)

#### Returns

`void`

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L153)

#### Returns

`boolean`

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`Widget`](Widget.md).[`useIdPrefix`](Widget.md#useidprefix)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L157)

#### Returns

`boolean`

***

### usePager()

> `protected` **usePager**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L635)

#### Returns

`boolean`

***

### viewDataChanged()

> `protected` **viewDataChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:523](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L523)

#### Returns

`void`

***

### wrapFormatterWithEditLink()

> `protected` **wrapFormatterWithEditLink**(`column`, `item`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L826)

#### Parameters

##### column

`Column`

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`Widget`](Widget.md).[`create`](Widget.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L52)

#### Returns

`HTMLElement`

#### Inherited from

[`Widget`](Widget.md).[`createDefaultElement`](Widget.md#createdefaultelement)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L91)

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getWidgetName`](Widget.md#getwidgetname)

***

### propertyItemToQuickFilter()

> `static` **propertyItemToQuickFilter**(`item`): [`QuickFilter`](../interfaces/QuickFilter.md)\<`any`, `any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L230)

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<`any`, `any`\>

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L221)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`Widget`](Widget.md).[`registerClass`](Widget.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L230)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`Widget`](Widget.md).[`registerEditor`](Widget.md#registereditor)
