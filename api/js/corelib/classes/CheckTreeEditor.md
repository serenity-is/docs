[serenity-is/corelib](../README.md) / CheckTreeEditor

# Class: CheckTreeEditor\<TItem, P\>

Defined in: [src/ui/editors/checktreeeditor.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L29)

## Extends

- [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

## Extended by

- [`CheckLookupEditor`](CheckLookupEditor.md)

## Type Parameters

### TItem

`TItem` *extends* [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

### P

`P` = \{ \}

## Implements

- [`IGetEditValue`](IGetEditValue.md)
- [`ISetEditValue`](ISetEditValue.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new CheckTreeEditor**\<`TItem`, `P`\>(`props`): `CheckTreeEditor`\<`TItem`, `P`\>

Defined in: [src/ui/editors/checktreeeditor.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L37)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`CheckTreeEditor`\<`TItem`, `P`\>

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

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/checktreeeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L31)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1260)

##### Returns

`Column`\<`any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`allColumns`](DataGrid.md#allcolumns)

***

### columns

#### Get Signature

> **get** **columns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1261)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`readOnly`](DataGrid.md#readonly)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`sleekGrid`](DataGrid.md#sleekgrid)

***

### slickGrid

#### Get Signature

> **get** **slickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1250)

##### Deprecated

Use sleekGrid or getGrid()

##### Returns

`ISleekGrid`\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`slickGrid`](DataGrid.md#slickgrid)

***

### value

#### Get Signature

> **get** **value**(): `string`[]

Defined in: [src/ui/editors/checktreeeditor.ts:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L421)

##### Returns

`string`[]

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:460](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L460)

##### Parameters

###### v

`string`[]

##### Returns

`void`

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`addBooleanFilter`](DataGrid.md#addbooleanfilter)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1028](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1028)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1036](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1036)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1008](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1008)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addFilterSeparator`](DataGrid.md#addfilterseparator)

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

Defined in: [src/ui/datagrid/datagrid.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L150)

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

### allDescendantsSelected()

> `protected` **allDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L289)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

***

### allItemsSelected()

> `protected` **allItemsSelected**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L278)

#### Returns

`boolean`

***

### anyDescendantsSelected()

> `protected` **anyDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L309)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

***

### autoRegisteringPlugin()

> `protected` **autoRegisteringPlugin**(`args`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L103)

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

Defined in: [src/ui/datagrid/datagrid.tsx:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L478)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToSlickEvents`](DataGrid.md#bindtoslickevents)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L529)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToViewEvents`](DataGrid.md#bindtoviewevents)

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

Defined in: [src/ui/datagrid/datagrid.tsx:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L359)

#### Parameters

##### column

`Column`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`canFilterColumn`](DataGrid.md#canfiltercolumn)

***

### canShowColumn()

> `protected` **canShowColumn**(`column`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1089](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1089)

#### Parameters

##### column

`Column`

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`canShowColumn`](DataGrid.md#canshowcolumn)

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

> `protected` **createColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/editors/checktreeeditor.ts:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L324)

Creates initial column set for this grid. This column set is then passed
to postProcessColumns to adjust widths etc, and then used as the initial
columns for the slickgrid.

#### Returns

`Column`\<`any`\>[]

#### Overrides

[`DataGrid`](DataGrid.md).[`createColumns`](DataGrid.md#createcolumns)

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L650)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createFilterBar`](DataGrid.md#createfilterbar)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L250)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createIncludeDeletedButton`](DataGrid.md#createincludedeletedbutton)

***

### createPager()

> `protected` **createPager**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L668)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createPager`](DataGrid.md#createpager)

***

### createQuickFilters()

> `protected` **createQuickFilters**(`filters?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L198)

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

Defined in: [src/ui/datagrid/datagrid.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L259)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createQuickSearchInput`](DataGrid.md#createquicksearchinput)

***

### createSleekColumns()

> `protected` **createSleekColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L398)

Creates the SleekGrid columns. This method calls createColumns (via getColumns for compatibility) and then post processes them.

#### Returns

`Column`\<`TItem`\>[]

The SleekGrid columns.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSleekColumns`](DataGrid.md#createsleekcolumns)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:622](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L622)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickContainer`](DataGrid.md#createslickcontainer)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L404)

Override initSleekGrid to add plugins to the sleekgrid

#### Returns

`ISleekGrid`\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickGrid`](DataGrid.md#createslickgrid)

***

### createToolbar()

> `protected` **createToolbar**(`buttons`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L694)

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

Defined in: [src/ui/datagrid/datagrid.tsx:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L187)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createToolbarExtensions`](DataGrid.md#createtoolbarextensions)

***

### createView()

> `protected` **createView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L626)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`createView`](DataGrid.md#createview)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`dateRangeQuickFilter`](DataGrid.md#daterangequickfilter)

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

Defined in: [src/ui/datagrid/datagrid.tsx:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L264)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`destroy`](DataGrid.md#destroy)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1012)

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

Defined in: [src/ui/datagrid/datagrid.tsx:494](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L494)

#### Parameters

##### entityOrId

`any`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`editItem`](DataGrid.md#edititem)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`editItemOfType`](DataGrid.md#edititemoftype)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`EditLink`](DataGrid.md#editlink)

***

### enableAdvancedFiltering()

> `protected` **enableAdvancedFiltering**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L639)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`enableAdvancedFiltering`](DataGrid.md#enableadvancedfiltering)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L190)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`ensureQuickFilterBar`](DataGrid.md#ensurequickfilterbar)

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L376)

#### Returns

`void`

#### Inherited from

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`findQuickFilter`](DataGrid.md#findquickfilter)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:399](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L399)

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

#### Overrides

[`DataGrid`](DataGrid.md).[`get_readOnly`](DataGrid.md#get_readonly)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L486)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getAddButtonCaption`](DataGrid.md#getaddbuttoncaption)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/editors/checktreeeditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L85)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`DataGrid`](DataGrid.md).[`getButtons`](DataGrid.md#getbuttons)

***

### ~~getColumns()~~

> `protected` **getColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:822](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L822)

#### Returns

`Column`\<`TItem`\>[]

#### Deprecated

override createColumns

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumns`](DataGrid.md#getcolumns)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:784](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L784)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnsKey`](DataGrid.md#getcolumnskey)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L336)

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthDelta`](DataGrid.md#getcolumnwidthdelta)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L340)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1208)

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

Defined in: [src/ui/datagrid/datagrid.tsx:631](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L631)

#### Returns

`any`[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getDefaultSortBy`](DataGrid.md#getdefaultsortby)

***

### getDelimited()

> `protected` **getDelimited**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L305)

#### Returns

`boolean`

***

### getDescendantsSelected()

> `protected` **getDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L257)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L73)

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

##### target

`any`

#### Returns

`void`

#### Implementation of

[`IGetEditValue`](IGetEditValue.md).[`getEditValue`](IGetEditValue.md#geteditvalue)

***

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/datagrid.tsx:1238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1238)

#### Returns

`HTMLElement`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getElement`](DataGrid.md#getelement)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1256)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getFilterStore`](DataGrid.md#getfilterstore)

***

### getGrid()

> **getGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1242)

#### Returns

`ISleekGrid`\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGrid`](DataGrid.md#getgrid)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:874](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L874)

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

Defined in: [src/ui/editors/checktreeeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L44)

#### Returns

`string`

#### Overrides

[`DataGrid`](DataGrid.md).[`getIdProperty`](DataGrid.md#getidproperty)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L570)

#### Parameters

##### include

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIncludeColumns`](DataGrid.md#getincludecolumns)

***

### getInitialCollapse()

> `protected` **getInitialCollapse**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L156)

#### Returns

`boolean`

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L183)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getInitialTitle`](DataGrid.md#getinitialtitle)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:989](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L989)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsActiveProperty`](DataGrid.md#getisactiveproperty)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:983](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L983)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsDeletedProperty`](DataGrid.md#getisdeletedproperty)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemCssClass`](DataGrid.md#getitemcssclass)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemMetadata`](DataGrid.md#getitemmetadata)

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/ui/datagrid/datagrid.tsx:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L453)

#### Returns

`TItem`[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItems`](DataGrid.md#getitems)

***

### getItemText()

> `protected` **getItemText**(`ctx`): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L355)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`string`

***

### getItemType()

> `protected` **getItemType**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:730](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L730)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemType`](DataGrid.md#getitemtype)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:950](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L950)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getLocalTextDbPrefix`](DataGrid.md#getlocaltextdbprefix)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:962](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L962)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getLocalTextPrefix`](DataGrid.md#getlocaltextprefix)

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

Defined in: [src/ui/datagrid/datagrid.tsx:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L660)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPagerOptions`](DataGrid.md#getpageroptions)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1110)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistedSettings`](DataGrid.md#getpersistedsettings)

***

### getPersistenceKey()

> `protected` **getPersistenceKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1070](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1070)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistenceKey`](DataGrid.md#getpersistencekey)

***

### getPersistenceStorage()

> `protected` **getPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1064](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1064)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistenceStorage`](DataGrid.md#getpersistencestorage)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L788)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItems`](DataGrid.md#getpropertyitems)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:792](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L792)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsData`](DataGrid.md#getpropertyitemsdata)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:812](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L812)

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsDataAsync`](DataGrid.md#getpropertyitemsdataasync)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L220)

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickFilters`](DataGrid.md#getquickfilters)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L255)

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickSearchFields`](DataGrid.md#getquicksearchfields)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/datagrid/datagrid.tsx:944](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L944)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`getRowDefinition`](DataGrid.md#getrowdefinition)

***

### getSelectAllText()

> `protected` **getSelectAllText**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L114)

#### Returns

`string`

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`

Defined in: [src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L359)

#### Returns

`GridOptions`

#### Overrides

[`DataGrid`](DataGrid.md).[`getSlickOptions`](DataGrid.md#getslickoptions)

***

### getTitle()

> **getTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L702)

#### Returns

`string`

#### Inherited from

[`DataGrid`](DataGrid.md).[`getTitle`](DataGrid.md#gettitle)

***

### getTreeItems()

> `protected` **getTreeItems**(): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L48)

#### Returns

`TItem`[]

***

### getView()

> **getView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1252)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getView`](DataGrid.md#getview)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L672)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`getViewOptions`](DataGrid.md#getviewoptions)

***

### gridPersistenceFlags()

> `protected` **gridPersistenceFlags**(): [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1083)

#### Returns

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`gridPersistenceFlags`](DataGrid.md#gridpersistenceflags)

***

### handleGridClick()

> `protected` **handleGridClick**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L466)

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

Defined in: [src/ui/datagrid/datagrid.tsx:470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L470)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridColumnsReordered`](DataGrid.md#handlegridcolumnsreordered)

***

### handleGridColumnsResized()

> `protected` **handleGridColumnsResized**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L474)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridColumnsResized`](DataGrid.md#handlegridcolumnsresized)

***

### handleGridSort()

> `protected` **handleGridSort**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L461)

#### Parameters

##### e

`GridSortEvent`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridSort`](DataGrid.md#handlegridsort)

***

### handleViewFilter()

> `protected` **handleViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:537](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L537)

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

Defined in: [src/ui/datagrid/datagrid.tsx:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L546)

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

Defined in: [src/ui/datagrid/datagrid.tsx:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L553)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewSubmit`](DataGrid.md#handleviewsubmit)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`DataGrid`](DataGrid.md).[`init`](DataGrid.md#init)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L366)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initializeFilterBar`](DataGrid.md#initializefilterbar)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L344)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initialPopulate`](DataGrid.md#initialpopulate)

***

### initSleekGrid()

> `protected` **initSleekGrid**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L122)

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`initSleekGrid`](DataGrid.md#initsleekgrid)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:915](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L915)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`invokeSubmitHandlers`](DataGrid.md#invokesubmithandlers)

***

### isThreeStateHierarchy()

> `protected` **isThreeStateHierarchy**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L118)

#### Returns

`boolean`

***

### itemAt()

> **itemAt**(`row`): `TItem`

Defined in: [src/ui/datagrid/datagrid.tsx:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L441)

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

Defined in: [src/ui/datagrid/datagrid.tsx:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L445)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemLink`](DataGrid.md#itemlink)

***

### itemSelectedChanged()

> `protected` **itemSelectedChanged**(`item`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L111)

#### Parameters

##### item

`TItem`

#### Returns

`void`

***

### layout()

> `protected` **layout**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L161)

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

Defined in: [src/ui/datagrid/datagrid.tsx:618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L618)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`markupReady`](DataGrid.md#markupready)

***

### moveSelectedUp()

> `protected` **moveSelectedUp**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L393)

#### Returns

`boolean`

***

### onClick()

> `protected` **onClick**(`e`, `row`, `cell`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L171)

#### Parameters

##### e

`Event`

##### row

`number`

##### cell

`number`

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`onClick`](DataGrid.md#onclick)

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L130)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

#### Overrides

[`DataGrid`](DataGrid.md).[`onViewFilter`](DataGrid.md#onviewfilter)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/editors/checktreeeditor.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L160)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

#### Overrides

[`DataGrid`](DataGrid.md).[`onViewProcessData`](DataGrid.md#onviewprocessdata)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:609](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L609)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewSubmit`](DataGrid.md#onviewsubmit)

***

### persistenceLock()

> **persistenceLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1187)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistenceLock`](DataGrid.md#persistencelock)

***

### persistenceUnlock()

> **persistenceUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1191)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistenceUnlock`](DataGrid.md#persistenceunlock)

***

### persistSettings()

> **persistSettings**(`flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1195)

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

Defined in: [src/ui/datagrid/datagrid.tsx:866](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L866)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateLock`](DataGrid.md#populatelock)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:870](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L870)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateUnlock`](DataGrid.md#populateunlock)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L646)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateWhenVisible`](DataGrid.md#populatewhenvisible)

***

### postProcessColumns()

> `protected` **postProcessColumns**(`columns`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L315)

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

Defined in: [src/ui/datagrid/datagrid.tsx:886](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L886)

Prepares submit arguments in this.view.params by calling this.view.onSubmit if available, or this.handleViewSubmit if not. 
Note that if getGridCanLoad returns false, the prepared arguments might be in a incomplete state.

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`prepareSubmit`](DataGrid.md#preparesubmit)

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L112)

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

Defined in: [src/ui/datagrid/datagrid.tsx:841](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L841)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1058](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1058)

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

Defined in: [src/ui/datagrid/datagrid.tsx:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L895)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refresh`](DataGrid.md#refresh)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L908)

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

Defined in: [src/ui/datagrid/datagrid.tsx:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1000)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`resizeCanvas`](DataGrid.md#resizecanvas)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoreSettings`](DataGrid.md#restoresettings)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoreSettingsFrom`](DataGrid.md#restoresettingsfrom)

***

### rowCount()

> **rowCount**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:449](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L449)

#### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`rowCount`](DataGrid.md#rowcount)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:403](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L403)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

#### Overrides

[`DataGrid`](DataGrid.md).[`set_readOnly`](DataGrid.md#set_readonly)

***

### setAllSubTreeSelected()

> `protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L261)

#### Parameters

##### item

`TItem`

##### selected

`boolean`

#### Returns

`boolean`

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:585](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L585)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setCriteriaParameter`](DataGrid.md#setcriteriaparameter)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L80)

#### Parameters

##### source

`any`

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Implementation of

[`ISetEditValue`](ISetEditValue.md).[`setEditValue`](ISetEditValue.md#seteditvalue)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`setEquality`](DataGrid.md#setequality)

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L599)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setIncludeColumnsParameter`](DataGrid.md#setincludecolumnsparameter)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L416)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setInitialSortOrder`](DataGrid.md#setinitialsortorder)

***

### setItems()

> **setItems**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L457)

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

Defined in: [src/ui/datagrid/datagrid.tsx:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L710)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setTitle`](DataGrid.md#settitle)

***

### sortItems()

> `protected` **sortItems**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L365)

#### Returns

`void`

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1004](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1004)

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

#### Inherited from

[`DataGrid`](DataGrid.md).[`tryFindQuickFilter`](DataGrid.md#tryfindquickfilter)

***

### updateFlags()

> `protected` **updateFlags**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L220)

#### Returns

`void`

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:940](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L940)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`updateInterface`](DataGrid.md#updateinterface)

***

### updateItems()

> `protected` **updateItems**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L52)

#### Returns

`void`

***

### updateSelectAll()

> `protected` **updateSelectAll**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L214)

#### Returns

`void`

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L153)

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

Defined in: [src/ui/datagrid/datagrid.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L157)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`useLayoutTimer`](DataGrid.md#uselayouttimer)

***

### usePager()

> `protected` **usePager**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L635)

#### Returns

`boolean`

#### Inherited from

[`DataGrid`](DataGrid.md).[`usePager`](DataGrid.md#usepager)

***

### viewDataChanged()

> `protected` **viewDataChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:523](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L523)

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`viewDataChanged`](DataGrid.md#viewdatachanged)

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

> `static` **createDefaultElement**(): `HTMLDivElement`

Defined in: [src/ui/editors/checktreeeditor.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L33)

#### Returns

`HTMLDivElement`

#### Overrides

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

Defined in: [src/ui/datagrid/datagrid.tsx:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L230)

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
