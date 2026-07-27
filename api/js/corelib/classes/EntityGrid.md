[@serenity-is/corelib](../README.md) / EntityGrid

# Class: EntityGrid\<TItem, P\>

Defined in: [src/ui/datagrid/entitygrid.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L18)

## Extends

- [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

## Type Parameters

### TItem

`TItem`

### P

`P` = \{ \}

## Constructors

### Constructor

> **new EntityGrid**\<`TItem`, `P`\>(`props`): `EntityGrid`\<`TItem`, `P`\>

Defined in: [src/ui/datagrid/entitygrid.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L21)

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

`EntityGrid`\<`TItem`, `P`\>

#### Overrides

[`DataGrid`](DataGrid.md).[`constructor`](DataGrid.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`DataGrid`](DataGrid.md).[`domNode`](DataGrid.md#domnode)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L47)

#### Inherited from

[`DataGrid`](DataGrid.md).[`filterBar`](DataGrid.md#filterbar)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`DataGrid`](DataGrid.md).[`idPrefix`](DataGrid.md#idprefix)

***

### onAfterInit

> `readonly` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L68)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onAfterInit`](DataGrid.md#onafterinit)

***

### onCanSubmit

> `readonly` **onCanSubmit**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onCanSubmit`](DataGrid.md#oncansubmit)

***

### onDataChanged

> `readonly` **onDataChanged**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L70)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onDataChanged`](DataGrid.md#ondatachanged)

***

### onFiltering

> `readonly` **onFiltering**: `PubSub`\<[`DataGridFilteringEvent`](../interfaces/DataGridFilteringEvent.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L71)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onFiltering`](DataGrid.md#onfiltering)

***

### onPersistence

> `readonly` **onPersistence**: `PubSub`\<[`DataGridPersistenceEvent`](../interfaces/DataGridPersistenceEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onPersistence`](DataGrid.md#onpersistence)

***

### onProcessData

> `readonly` **onProcessData**: `PubSub`\<[`DataGridProcessEvent`](../interfaces/DataGridProcessEvent.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L73)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onProcessData`](DataGrid.md#onprocessdata)

***

### onSetViewParams

> `readonly` **onSetViewParams**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L75)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onSetViewParams`](DataGrid.md#onsetviewparams)

***

### onSubmitting

> `readonly` **onSubmitting**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L74)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onSubmitting`](DataGrid.md#onsubmitting)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L55)

#### Inherited from

[`DataGrid`](DataGrid.md).[`openDialogsAsPanel`](DataGrid.md#opendialogsaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`DataGrid`](DataGrid.md).[`options`](DataGrid.md#options)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L51)

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsData`](DataGrid.md#propertyitemsdata)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L49)

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFiltersBar`](DataGrid.md#quickfiltersbar)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L48)

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFiltersDiv`](DataGrid.md#quickfiltersdiv)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

Defined in: [src/ui/datagrid/datagrid.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L52)

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoringSettings`](DataGrid.md#restoringsettings)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L50)

#### Inherited from

[`DataGrid`](DataGrid.md).[`slickContainer`](DataGrid.md#slickcontainer)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L45)

#### Inherited from

[`DataGrid`](DataGrid.md).[`titleDiv`](DataGrid.md#titlediv)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L46)

#### Inherited from

[`DataGrid`](DataGrid.md).[`toolbar`](DataGrid.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`DataGrid`](DataGrid.md).[`uniqueName`](DataGrid.md#uniquename)

***

### view

> **view**: [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L53)

#### Inherited from

[`DataGrid`](DataGrid.md).[`view`](DataGrid.md#view)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/datagrid/entitygrid.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L19)

#### Overrides

[`DataGrid`](DataGrid.md).[`[typeInfo]`](DataGrid.md#typeinfo)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultOptions`](DataGrid.md#defaultoptions)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`DataGrid`](DataGrid.md).[`isComponent`](DataGrid.md#iscomponent)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L67)

#### Inherited from

[`DataGrid`](DataGrid.md).[`onAfterInit`](DataGrid.md#onafterinit-1)

## Accessors

### allColumns

#### Get Signature

> **get** **allColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1249)

##### Returns

`Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`allColumns`](DataGrid.md#allcolumns)

***

### columns

#### Get Signature

> **get** **columns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1250)

##### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`columns`](DataGrid.md#columns)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`element`](DataGrid.md#element)

***

### initialSettings

#### Get Signature

> **get** **initialSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1251)

##### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Set Signature

> **set** **initialSettings**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1252)

##### Parameters

###### value

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initialSettings`](DataGrid.md#initialsettings)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`props`](DataGrid.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L932)

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:936](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L936)

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`readOnly`](DataGrid.md#readonly)

***

### sleekGrid

#### Get Signature

> **get** **sleekGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1235)

##### Returns

`ISleekGrid`\<`TItem`\>

#### Set Signature

> **set** **sleekGrid**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1236)

##### Parameters

###### value

`ISleekGrid`\<`TItem`\>

##### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`sleekGrid`](DataGrid.md#sleekgrid)

***

### slickGrid

#### Get Signature

> **get** **slickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1239)

##### Deprecated

Use sleekGrid or getGrid()

##### Returns

`ISleekGrid`\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`slickGrid`](DataGrid.md#slickgrid)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultColumnWidthDelta`](DataGrid.md#defaultcolumnwidthdelta)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultColumnWidthScale`](DataGrid.md#defaultcolumnwidthscale)

***

### defaultPersistanceStorage

#### Get Signature

> **get** `static` **defaultPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1255)

##### Deprecated

use defaultPersistenceStorage, this one has a typo

##### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Set Signature

> **set** `static` **defaultPersistanceStorage**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1257)

##### Deprecated

use defaultPersistenceStorage, this one has a typo

##### Parameters

###### value

[`SettingStorage`](../interfaces/SettingStorage.md)

##### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultPersistanceStorage`](DataGrid.md#defaultpersistancestorage)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultPersistenceStorage`](DataGrid.md#defaultpersistencestorage)

***

### defaultRowHeight

#### Get Signature

> **get** `static` **defaultRowHeight**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L59)

##### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultRowHeight`](DataGrid.md#defaultrowheight)

## Methods

### addBooleanFilter()

> `protected` **addBooleanFilter**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](SelectEditor.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1055](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1055)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`addBooleanFilter`](DataGrid.md#addbooleanfilter)

***

### addButtonClick()

> `protected` **addButtonClick**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L214)

#### Returns

`void`

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addCssClass`](DataGrid.md#addcssclass)

***

### addDateRangeFilter()

> `protected` **addDateRangeFilter**(`field`, `title?`): [`DateEditor`](DateEditor.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1039](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1039)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateEditor`](DateEditor.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`addDateRangeFilter`](DataGrid.md#adddaterangefilter)

***

### addDateTimeRangeFilter()

> `protected` **addDateTimeRangeFilter**(`field`, `title?`): [`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1047](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1047)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`addDateTimeRangeFilter`](DataGrid.md#adddatetimerangefilter)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1019)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addFilterSeparator`](DataGrid.md#addfilterseparator)

***

### addQuickFilter()

> `protected` **addQuickFilter**\<`TWidget`, `P`\>(`opt`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:1035](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1035)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`addQuickFilter`](DataGrid.md#addquickfilter)

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

[`DataGrid`](DataGrid.md).[`addValidationRule`](DataGrid.md#addvalidationrule)

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

[`DataGrid`](DataGrid.md).[`addValidationRule`](DataGrid.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L151)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`afterInit`](DataGrid.md#afterinit)

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

[`DataGrid`](DataGrid.md).[`afterRender`](DataGrid.md#afterrender)

***

### autoRegisteringPlugin()

> `protected` **autoRegisteringPlugin**(`args`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L104)

#### Parameters

##### args

[`AutoRegisterArgs`](../interfaces/AutoRegisterArgs.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`autoRegisteringPlugin`](DataGrid.md#autoregisteringplugin)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:484](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L484)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToSlickEvents`](DataGrid.md#bindtoslickevents)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:535](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L535)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToViewEvents`](DataGrid.md#bindtoviewevents)

***

### booleanQuickFilter()

> `protected` **booleanQuickFilter**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1059](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1059)

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

[`DataGrid`](DataGrid.md).[`byId`](DataGrid.md#byid)

***

### canFilterColumn()

> `protected` **canFilterColumn**(`column`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L365)

#### Parameters

##### column

`Column`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`canFilterColumn`](DataGrid.md#canfiltercolumn)

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

[`DataGrid`](DataGrid.md).[`change`](DataGrid.md#change)

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

[`DataGrid`](DataGrid.md).[`changeSelect2`](DataGrid.md#changeselect2)

***

### createColumns()

> `protected` **createColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L395)

Creates initial column set for this grid. This column set is then passed
to postProcessColumns to adjust widths etc, and then used as the initial
columns for the slickgrid.

#### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`createColumns`](DataGrid.md#createcolumns)

***

### createEntityDialog()

> `protected` **createEntityDialog**(`itemType`, `callback?`): [`Widget`](Widget.md)\<`any`\> \| `PromiseLike`\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/datagrid/entitygrid.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L355)

#### Parameters

##### itemType

`string`

##### callback?

(`dlg`) => `void`

#### Returns

[`Widget`](Widget.md)\<`any`\> \| `PromiseLike`\<[`Widget`](Widget.md)\<`any`\>\>

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L191)

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`createFilterBar`](DataGrid.md#createfilterbar)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L251)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createIncludeDeletedButton`](DataGrid.md#createincludedeletedbutton)

***

### createPager()

> `protected` **createPager**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:681](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L681)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createPager`](DataGrid.md#createpager)

***

### createQuickFilters()

> `protected` **createQuickFilters**(`filters?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L199)

#### Parameters

##### filters?

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createQuickFilters`](DataGrid.md#createquickfilters)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L260)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createQuickSearchInput`](DataGrid.md#createquicksearchinput)

***

### createSleekColumns()

> `protected` **createSleekColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L404)

Creates the SleekGrid columns. This method calls createColumns (via getColumns for compatibility) and then post processes them.

#### Returns

`Column`\<`TItem`\>[]

The SleekGrid columns.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSleekColumns`](DataGrid.md#createsleekcolumns)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L635)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickContainer`](DataGrid.md#createslickcontainer)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:410](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L410)

Override initSleekGrid to add plugins to the sleekgrid

#### Returns

`ISleekGrid`\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickGrid`](DataGrid.md#createslickgrid)

***

### createToolbar()

> `protected` **createToolbar**(`buttons`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L707)

#### Parameters

##### buttons

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createToolbar`](DataGrid.md#createtoolbar)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L84)

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`createToolbarExtensions`](DataGrid.md#createtoolbarextensions)

***

### createView()

> `protected` **createView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L639)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createView`](DataGrid.md#createview)

***

### dateRangeQuickFilter()

> `protected` **dateRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1043](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1043)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`dateRangeQuickFilter`](DataGrid.md#daterangequickfilter)

***

### dateTimeRangeQuickFilter()

> `protected` **dateTimeRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1051](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1051)

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`dateTimeRangeQuickFilter`](DataGrid.md#datetimerangequickfilter)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`deferRender`](DataGrid.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L27)

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`destroy`](DataGrid.md#destroy)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1023)

#### Parameters

##### getKey

(`prefix`) => `string`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`determineText`](DataGrid.md#determinetext)

***

### editItem()

> `protected` **editItem**(`entityOrId`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L218)

#### Parameters

##### entityOrId

`any`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`editItem`](DataGrid.md#edititem)

***

### editItemOfType()

> `protected` **editItemOfType**(`itemType`, `entityOrId`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L235)

#### Parameters

##### itemType

`string`

##### entityOrId

`any`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`editItemOfType`](DataGrid.md#edititemoftype)

***

### EditLink()

> **EditLink**(`props`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L753)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`EditLink`](DataGrid.md#editlink)

***

### enableAdvancedFiltering()

> `protected` **enableAdvancedFiltering**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L652)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`enableAdvancedFiltering`](DataGrid.md#enableadvancedfiltering)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L191)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`ensureQuickFilterBar`](DataGrid.md#ensurequickfilterbar)

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L196)

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`filterStoreChanged`](DataGrid.md#filterstorechanged)

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

[`DataGrid`](DataGrid.md).[`findById`](DataGrid.md#findbyid)

***

### findQuickFilter()

> `protected` **findQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L235)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`findQuickFilter`](DataGrid.md#findquickfilter)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:940](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L940)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`get_readOnly`](DataGrid.md#get_readonly)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L146)

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getAddButtonCaption`](DataGrid.md#getaddbuttoncaption)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/datagrid/entitygrid.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L150)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`DataGrid`](DataGrid.md).[`getButtons`](DataGrid.md#getbuttons)

***

### ~~getColumns()~~

> `protected` **getColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:833](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L833)

#### Returns

`Column`\<`TItem`\>[]

#### Deprecated

override createColumns

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumns`](DataGrid.md#getcolumns)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:795](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L795)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnsKey`](DataGrid.md#getcolumnskey)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L342)

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthDelta`](DataGrid.md#getcolumnwidthdelta)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L346)

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthScale`](DataGrid.md#getcolumnwidthscale)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getCssClass`](DataGrid.md#getcssclass)

***

### getCurrentSettings()

> **getCurrentSettings**(`flags?`): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1197)

#### Parameters

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getCurrentSettings`](DataGrid.md#getcurrentsettings)

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

[`DataGrid`](DataGrid.md).[`getCustomAttribute`](DataGrid.md#getcustomattribute)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

Defined in: [src/ui/datagrid/datagrid.tsx:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L644)

#### Returns

`any`[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getDefaultSortBy`](DataGrid.md#getdefaultsortby)

***

### getDeletePermission()

> `protected` **getDeletePermission**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L308)

#### Returns

`string`

***

### getDialogOptions()

> `protected` **getDialogOptions**(): `any`

Defined in: [src/ui/datagrid/entitygrid.ts:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L376)

#### Returns

`any`

***

### getDialogOptionsFor()

> `protected` **getDialogOptionsFor**(`itemType`): `any`

Defined in: [src/ui/datagrid/entitygrid.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L380)

#### Parameters

##### itemType

`string`

#### Returns

`any`

***

### getDialogType()

> `protected` **getDialogType**(): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/datagrid/entitygrid.ts:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L398)

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

***

### getDialogTypeFor()

> `protected` **getDialogTypeFor**(`itemType`): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/datagrid/entitygrid.ts:387](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L387)

#### Parameters

##### itemType

`string`

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

***

### getDisplayName()

> `protected` **getDisplayName**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L130)

#### Returns

`string`

***

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/datagrid.tsx:1227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1227)

#### Returns

`HTMLElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getElement`](DataGrid.md#getelement)

***

### getEntityType()

> `protected` **getEntityType**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L105)

#### Returns

`string`

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1245)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getFilterStore`](DataGrid.md#getfilterstore)

***

### getGrid()

> **getGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1231)

#### Returns

`ISleekGrid`\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGrid`](DataGrid.md#getgrid)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L885)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGridCanLoad`](DataGrid.md#getgridcanload)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGridField`](DataGrid.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:983](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L983)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIdProperty`](DataGrid.md#getidproperty)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L576)

#### Parameters

##### include

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIncludeColumns`](DataGrid.md#getincludecolumns)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L89)

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getInitialTitle`](DataGrid.md#getinitialtitle)

***

### getInsertPermission()

> `protected` **getInsertPermission**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L300)

#### Returns

`string`

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1000)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsActiveProperty`](DataGrid.md#getisactiveproperty)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:994](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L994)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsDeletedProperty`](DataGrid.md#getisdeletedproperty)

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L309)

#### Parameters

##### item

`TItem`

##### index

`number`

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemCssClass`](DataGrid.md#getitemcssclass)

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:313](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L313)

#### Parameters

##### item

`TItem`

##### index

`number`

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemMetadata`](DataGrid.md#getitemmetadata)

***

### getItemName()

> `protected` **getItemName**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L139)

#### Returns

`string`

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/ui/datagrid/datagrid.tsx:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L459)

#### Returns

`TItem`[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItems`](DataGrid.md#getitems)

***

### getItemType()

> `protected` **getItemType**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L280)

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getItemType`](DataGrid.md#getitemtype)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:961](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L961)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getLocalTextDbPrefix`](DataGrid.md#getlocaltextdbprefix)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L93)

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getLocalTextPrefix`](DataGrid.md#getlocaltextprefix)

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

Defined in: [src/ui/datagrid/datagrid.tsx:673](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L673)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPagerOptions`](DataGrid.md#getpageroptions)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1100)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistedSettings`](DataGrid.md#getpersistedsettings)

***

### getPersistenceKey()

> `protected` **getPersistenceKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1081](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1081)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistenceKey`](DataGrid.md#getpersistencekey)

***

### getPersistenceStorage()

> `protected` **getPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1075](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1075)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistenceStorage`](DataGrid.md#getpersistencestorage)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:799](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L799)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItems`](DataGrid.md#getpropertyitems)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:803](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L803)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsData`](DataGrid.md#getpropertyitemsdata)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:823](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L823)

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsDataAsync`](DataGrid.md#getpropertyitemsdataasync)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L221)

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickFilters`](DataGrid.md#getquickfilters)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L256)

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickSearchFields`](DataGrid.md#getquicksearchfields)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/datagrid/datagrid.tsx:955](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L955)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getRowDefinition`](DataGrid.md#getrowdefinition)

***

### getService()

> `protected` **getService**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L259)

#### Returns

`string`

***

### getServiceMethod()

> `protected` **getServiceMethod**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L266)

#### Returns

`string`

***

### getServiceUrl()

> `protected` **getServiceUrl**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L270)

#### Returns

`string`

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`

Defined in: [src/ui/datagrid/datagrid.tsx:863](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L863)

#### Returns

`GridOptions`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getSlickOptions`](DataGrid.md#getslickoptions)

***

### getTitle()

> **getTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:715](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L715)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getTitle`](DataGrid.md#gettitle)

***

### getUpdatePermission()

> `protected` **getUpdatePermission**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L304)

#### Returns

`string`

***

### getView()

> **getView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1241)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getView`](DataGrid.md#getview)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

Defined in: [src/ui/datagrid/entitygrid.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L274)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Overrides

[`DataGrid`](DataGrid.md).[`getViewOptions`](DataGrid.md#getviewoptions)

***

### gridPersistenceFlags()

> `protected` **gridPersistenceFlags**(): [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1094](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1094)

#### Returns

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`gridPersistenceFlags`](DataGrid.md#gridpersistenceflags)

***

### handleGridClick()

> `protected` **handleGridClick**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L472)

#### Parameters

##### e

`CellMouseEvent`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridClick`](DataGrid.md#handlegridclick)

***

### handleGridColumnsReordered()

> `protected` **handleGridColumnsReordered**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L476)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridColumnsReordered`](DataGrid.md#handlegridcolumnsreordered)

***

### handleGridColumnsResized()

> `protected` **handleGridColumnsResized**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L480)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridColumnsResized`](DataGrid.md#handlegridcolumnsresized)

***

### handleGridSort()

> `protected` **handleGridSort**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:467](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L467)

#### Parameters

##### e

`GridSortEvent`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridSort`](DataGrid.md#handlegridsort)

***

### handleRoute()

> `protected` **handleRoute**(`e`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L32)

#### Parameters

##### e

[`HandleRouteEvent`](../interfaces/HandleRouteEvent.md)

#### Returns

`void`

***

### handleViewFilter()

> `protected` **handleViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:543](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L543)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewFilter`](DataGrid.md#handleviewfilter)

***

### handleViewProcessData()

> `protected` **handleViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L552)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewProcessData`](DataGrid.md#handleviewprocessdata)

***

### handleViewSubmit()

> `protected` **handleViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L559)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewSubmit`](DataGrid.md#handleviewsubmit)

***

### hasDeletePermission()

> `protected` **hasDeletePermission**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L312)

#### Returns

`boolean`

***

### hasInsertPermission()

> `protected` **hasInsertPermission**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L317)

#### Returns

`boolean`

***

### hasUpdatePermission()

> `protected` **hasUpdatePermission**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L322)

#### Returns

`boolean`

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`DataGrid`](DataGrid.md).[`init`](DataGrid.md#init)

***

### initDialog()

> `protected` **initDialog**(`dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L332)

#### Parameters

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

***

### initEntityDialog()

> `protected` **initEntityDialog**(`itemType`, `dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L341)

#### Parameters

##### itemType

`string`

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:372](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L372)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initializeFilterBar`](DataGrid.md#initializefilterbar)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L350)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initialPopulate`](DataGrid.md#initialpopulate)

***

### initSleekGrid()

> `protected` **initSleekGrid**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L419)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initSleekGrid`](DataGrid.md#initsleekgrid)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:926](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L926)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`internalRefresh`](DataGrid.md#internalrefresh)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`internalRenderContents`](DataGrid.md#internalrendercontents)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1063](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1063)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`invokeSubmitHandlers`](DataGrid.md#invokesubmithandlers)

***

### itemAt()

> **itemAt**(`row`): `TItem`

Defined in: [src/ui/datagrid/datagrid.tsx:447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L447)

#### Parameters

##### row

`number`

#### Returns

`TItem`

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemAt`](DataGrid.md#itemat)

***

### itemId()

> **itemId**(`item`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L451)

#### Parameters

##### item

`TItem`

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemId`](DataGrid.md#itemid)

***

### itemLink()

> `protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../type-aliases/Format.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L747)

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

***

### layout()

> `protected` **layout**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L162)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`layout`](DataGrid.md#layout)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`legacyTemplateRender`](DataGrid.md#legacytemplaterender)

***

### markupReady()

> `protected` **markupReady**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:631](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L631)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`markupReady`](DataGrid.md#markupready)

***

### newRefreshButton()

> `protected` **newRefreshButton**(`noText?`): [`ToolButton`](../interfaces/ToolButton.md)

Defined in: [src/ui/datagrid/entitygrid.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L201)

#### Parameters

##### noText?

`boolean`

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

***

### onClick()

> `protected` **onClick**(`e`, `row`, `cell`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L513)

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

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L572)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewFilter`](DataGrid.md#onviewfilter)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L568)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewProcessData`](DataGrid.md#onviewprocessdata)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:622](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L622)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewSubmit`](DataGrid.md#onviewsubmit)

***

### persistenceLock()

> **persistenceLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1176)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistenceLock`](DataGrid.md#persistencelock)

***

### persistenceUnlock()

> **persistenceUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1180)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistenceUnlock`](DataGrid.md#persistenceunlock)

***

### persistSettings()

> **persistSettings**(`flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1184)

#### Parameters

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

`void` \| `Promise`\<`void`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistSettings`](DataGrid.md#persistsettings)

***

### populateLock()

> `protected` **populateLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:877](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L877)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateLock`](DataGrid.md#populatelock)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L881)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateUnlock`](DataGrid.md#populateunlock)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L659)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateWhenVisible`](DataGrid.md#populatewhenvisible)

***

### postProcessColumns()

> `protected` **postProcessColumns**(`columns`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L321)

#### Parameters

##### columns

`Column`\<`any`\>[]

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`postProcessColumns`](DataGrid.md#postprocesscolumns)

***

### prepareSubmit()

> **prepareSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:897](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L897)

Prepares submit arguments in this.view.params by calling this.view.onSubmit if available, or this.handleViewSubmit if not. 
Note that if getGridCanLoad returns false, the prepared arguments might be in a incomplete state.

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`prepareSubmit`](DataGrid.md#preparesubmit)

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L113)

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsReady`](DataGrid.md#propertyitemsready)

***

### propertyItemsToColumns()

> `protected` **propertyItemsToColumns**(`propertyItems`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L852)

#### Parameters

##### propertyItems

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsToColumns`](DataGrid.md#propertyitemstocolumns)

***

### quickFilterChange()

> `protected` **quickFilterChange**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1069](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1069)

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFilterChange`](DataGrid.md#quickfilterchange)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:906](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L906)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refresh`](DataGrid.md#refresh)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:919](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L919)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refreshIfNeeded`](DataGrid.md#refreshifneeded)

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

[`DataGrid`](DataGrid.md).[`render`](DataGrid.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`DataGrid`](DataGrid.md).[`renderContents`](DataGrid.md#rendercontents)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1011](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1011)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`resizeCanvas`](DataGrid.md#resizecanvas)

***

### restoreSettings()

> `protected` **restoreSettings**(`settings?`, `flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1119)

#### Parameters

##### settings?

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

`void` \| `Promise`\<`void`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoreSettings`](DataGrid.md#restoresettings)

***

### restoreSettingsFrom()

> `protected` **restoreSettingsFrom**(`settings`, `flags?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1130)

#### Parameters

##### settings

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoreSettingsFrom`](DataGrid.md#restoresettingsfrom)

***

### routeDialog()

> `protected` **routeDialog**(`itemType`, `dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L284)

#### Parameters

##### itemType

`string`

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

***

### rowCount()

> **rowCount**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:455](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L455)

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`rowCount`](DataGrid.md#rowcount)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:944](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L944)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`set_readOnly`](DataGrid.md#set_readonly)

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:591](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L591)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setCriteriaParameter`](DataGrid.md#setcriteriaparameter)

***

### setEquality()

> `protected` **setEquality**(`field`, `value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:601](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L601)

#### Parameters

##### field

`string`

##### value

`any`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setEquality`](DataGrid.md#setequality)

***

### setFilterBarVisibility()

> `protected` **setFilterBarVisibility**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L181)

#### Returns

`void`

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:605](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L605)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setIncludeColumnsParameter`](DataGrid.md#setincludecolumnsparameter)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L422)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setInitialSortOrder`](DataGrid.md#setinitialsortorder)

***

### setItems()

> **setItems**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L463)

#### Parameters

##### value

`TItem`[]

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setItems`](DataGrid.md#setitems)

***

### setTitle()

> **setTitle**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:723](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L723)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setTitle`](DataGrid.md#settitle)

***

### setViewParams()

> `protected` **setViewParams**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:615](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L615)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setViewParams`](DataGrid.md#setviewparams)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1015](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1015)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`subDialogDataChange`](DataGrid.md#subdialogdatachange)

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

[`DataGrid`](DataGrid.md).[`syncOrAsyncThen`](DataGrid.md#syncorasyncthen)

***

### transferDialogReadOnly()

> `protected` **transferDialogReadOnly**(`dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:327](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L327)

#### Parameters

##### dialog

[`Widget`](Widget.md)\<`any`\>

#### Returns

`void`

***

### tryFindQuickFilter()

> `protected` **tryFindQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L243)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`tryFindQuickFilter`](DataGrid.md#tryfindquickfilter)

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:951](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L951)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`updateInterface`](DataGrid.md#updateinterface)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L154)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`useAsync`](DataGrid.md#useasync)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`useIdPrefix`](DataGrid.md#useidprefix)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L158)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`useLayoutTimer`](DataGrid.md#uselayouttimer)

***

### usePager()

> `protected` **usePager**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L80)

#### Returns

`boolean`

#### Overrides

[`DataGrid`](DataGrid.md).[`usePager`](DataGrid.md#usepager)

***

### viewDataChanged()

> `protected` **viewDataChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L529)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`viewDataChanged`](DataGrid.md#viewdatachanged)

***

### wrapFormatterWithEditLink()

> `protected` **wrapFormatterWithEditLink**(`column`, `item`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:837](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L837)

#### Parameters

##### column

`Column`

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`wrapFormatterWithEditLink`](DataGrid.md#wrapformatterwitheditlink)

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

[`DataGrid`](DataGrid.md).[`create`](DataGrid.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L52)

#### Returns

`HTMLElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createDefaultElement`](DataGrid.md#createdefaultelement)

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

[`DataGrid`](DataGrid.md).[`getWidgetName`](DataGrid.md#getwidgetname)

***

### propertyItemToQuickFilter()

> `static` **propertyItemToQuickFilter**(`item`): [`QuickFilter`](../interfaces/QuickFilter.md)\<`any`, `any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L231)

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<`any`, `any`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemToQuickFilter`](DataGrid.md#propertyitemtoquickfilter)

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

[`DataGrid`](DataGrid.md).[`registerClass`](DataGrid.md#registerclass)

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

[`DataGrid`](DataGrid.md).[`registerEditor`](DataGrid.md#registereditor)
