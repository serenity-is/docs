[corelib](../README.md) / CheckLookupEditor

# Class: CheckLookupEditor\<TItem, P\>

Defined in: [src/ui/editors/checktreeeditor.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L478)

## Extends

- [`CheckTreeEditor`](CheckTreeEditor.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>, `P`\>

## Type Parameters

### TItem

`TItem` *extends* [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> = `any`

### P

`P` *extends* [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) = [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md)

## Constructors

### Constructor

> **new CheckLookupEditor**\<`TItem`, `P`\>(`props`): `CheckLookupEditor`\<`TItem`, `P`\>

Defined in: [src/ui/editors/checktreeeditor.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L485)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`CheckLookupEditor`\<`TItem`, `P`\>

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`constructor`](CheckTreeEditor.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/checktreeeditor.ts:606](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L606)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`domNode`](CheckTreeEditor.md#domnode)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L47)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`filterBar`](CheckTreeEditor.md#filterbar)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`idPrefix`](CheckTreeEditor.md#idprefix)

***

### onAfterInit

> `readonly` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L68)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onAfterInit`](CheckTreeEditor.md#onafterinit)

***

### onCanSubmit

> `readonly` **onCanSubmit**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onCanSubmit`](CheckTreeEditor.md#oncansubmit)

***

### onDataChanged

> `readonly` **onDataChanged**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L70)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onDataChanged`](CheckTreeEditor.md#ondatachanged)

***

### onFiltering

> `readonly` **onFiltering**: `PubSub`\<[`DataGridFilteringEvent`](../interfaces/DataGridFilteringEvent.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L71)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onFiltering`](CheckTreeEditor.md#onfiltering)

***

### onPersistence

> `readonly` **onPersistence**: `PubSub`\<[`DataGridPersistenceEvent`](../interfaces/DataGridPersistenceEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onPersistence`](CheckTreeEditor.md#onpersistence)

***

### onProcessData

> `readonly` **onProcessData**: `PubSub`\<[`DataGridProcessEvent`](../interfaces/DataGridProcessEvent.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L73)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onProcessData`](CheckTreeEditor.md#onprocessdata)

***

### onSubmitting

> `readonly` **onSubmitting**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L74)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onSubmitting`](CheckTreeEditor.md#onsubmitting)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L55)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`openDialogsAsPanel`](CheckTreeEditor.md#opendialogsaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`options`](CheckTreeEditor.md#options)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L51)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsData`](CheckTreeEditor.md#propertyitemsdata)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L49)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFiltersBar`](CheckTreeEditor.md#quickfiltersbar)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L48)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFiltersDiv`](CheckTreeEditor.md#quickfiltersdiv)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

Defined in: [src/ui/datagrid/datagrid.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L52)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoringSettings`](CheckTreeEditor.md#restoringsettings)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L50)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`slickContainer`](CheckTreeEditor.md#slickcontainer)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L45)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`titleDiv`](CheckTreeEditor.md#titlediv)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L46)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`toolbar`](CheckTreeEditor.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`uniqueName`](CheckTreeEditor.md#uniquename)

***

### view

> **view**: [`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L53)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`view`](CheckTreeEditor.md#view)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/checktreeeditor.ts:479](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L479)

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`[typeInfo]`](CheckTreeEditor.md#typeinfo)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultOptions`](CheckTreeEditor.md#defaultoptions)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`isComponent`](CheckTreeEditor.md#iscomponent)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L67)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onAfterInit`](CheckTreeEditor.md#onafterinit-1)

## Accessors

### allColumns

#### Get Signature

> **get** **allColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1260)

##### Returns

`Column`\<`any`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allColumns`](CheckTreeEditor.md#allcolumns)

***

### cascadeField

#### Get Signature

> **get** **cascadeField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L642)

##### Returns

`string`

#### Set Signature

> **set** **cascadeField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L650)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### cascadeFrom

#### Get Signature

> **get** **cascadeFrom**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L598)

##### Returns

`string`

#### Set Signature

> **set** **cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:634](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L634)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### cascadeValue

#### Get Signature

> **get** **cascadeValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.ts:658](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L658)

##### Returns

`any`

#### Set Signature

> **set** **cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:670](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L670)

##### Parameters

###### value

`any`

##### Returns

`void`

***

### columns

#### Get Signature

> **get** **columns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1261)

##### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`columns`](CheckTreeEditor.md#columns)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`element`](CheckTreeEditor.md#element)

***

### filterField

#### Get Signature

> **get** **filterField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L678)

##### Returns

`string`

#### Set Signature

> **set** **filterField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L686)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### filterValue

#### Get Signature

> **get** **filterValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L694)

##### Returns

`any`

#### Set Signature

> **set** **filterValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L706)

##### Parameters

###### value

`any`

##### Returns

`void`

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`initialSettings`](CheckTreeEditor.md#initialsettings)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`props`](CheckTreeEditor.md#props)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`readOnly`](CheckTreeEditor.md#readonly)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`sleekGrid`](CheckTreeEditor.md#sleekgrid)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`slickGrid`](CheckTreeEditor.md#slickgrid)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`value`](CheckTreeEditor.md#value)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultColumnWidthDelta`](CheckTreeEditor.md#defaultcolumnwidthdelta)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultColumnWidthScale`](CheckTreeEditor.md#defaultcolumnwidthscale)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultPersistanceStorage`](CheckTreeEditor.md#defaultpersistancestorage)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultPersistenceStorage`](CheckTreeEditor.md#defaultpersistencestorage)

***

### defaultRowHeight

#### Get Signature

> **get** `static` **defaultRowHeight**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L59)

##### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultRowHeight`](CheckTreeEditor.md#defaultrowheight)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addBooleanFilter`](CheckTreeEditor.md#addbooleanfilter)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addCssClass`](CheckTreeEditor.md#addcssclass)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addDateRangeFilter`](CheckTreeEditor.md#adddaterangefilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addDateTimeRangeFilter`](CheckTreeEditor.md#adddatetimerangefilter)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1008](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1008)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addFilterSeparator`](CheckTreeEditor.md#addfilterseparator)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addQuickFilter`](CheckTreeEditor.md#addquickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addValidationRule`](CheckTreeEditor.md#addvalidationrule)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`addValidationRule`](CheckTreeEditor.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L150)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`afterInit`](CheckTreeEditor.md#afterinit)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`afterRender`](CheckTreeEditor.md#afterrender)

***

### allDescendantsSelected()

> `protected` **allDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L289)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allDescendantsSelected`](CheckTreeEditor.md#alldescendantsselected)

***

### allItemsSelected()

> `protected` **allItemsSelected**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L278)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allItemsSelected`](CheckTreeEditor.md#allitemsselected)

***

### anyDescendantsSelected()

> `protected` **anyDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L309)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`anyDescendantsSelected`](CheckTreeEditor.md#anydescendantsselected)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`autoRegisteringPlugin`](CheckTreeEditor.md#autoregisteringplugin)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L478)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`bindToSlickEvents`](CheckTreeEditor.md#bindtoslickevents)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L529)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`bindToViewEvents`](CheckTreeEditor.md#bindtoviewevents)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`booleanQuickFilter`](CheckTreeEditor.md#booleanquickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`byId`](CheckTreeEditor.md#byid)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`canFilterColumn`](CheckTreeEditor.md#canfiltercolumn)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`canShowColumn`](CheckTreeEditor.md#canshowcolumn)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.ts:532](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L532)

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`change`](CheckTreeEditor.md#change)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`changeSelect2`](CheckTreeEditor.md#changeselect2)

***

### createColumns()

> `protected` **createColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/editors/checktreeeditor.ts:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L324)

Creates initial column set for this grid. This column set is then passed
to postProcessColumns to adjust widths etc, and then used as the initial
columns for the slickgrid.

#### Returns

`Column`\<`any`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createColumns`](CheckTreeEditor.md#createcolumns)

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L650)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createFilterBar`](CheckTreeEditor.md#createfilterbar)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L250)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createIncludeDeletedButton`](CheckTreeEditor.md#createincludedeletedbutton)

***

### createPager()

> `protected` **createPager**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L668)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createPager`](CheckTreeEditor.md#createpager)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`createQuickFilters`](CheckTreeEditor.md#createquickfilters)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L259)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createQuickSearchInput`](CheckTreeEditor.md#createquicksearchinput)

***

### createSleekColumns()

> `protected` **createSleekColumns**(): `Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L398)

Creates the SleekGrid columns. This method calls createColumns (via getColumns for compatibility) and then post processes them.

#### Returns

`Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

The SleekGrid columns.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSleekColumns`](CheckTreeEditor.md#createsleekcolumns)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:622](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L622)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSlickContainer`](CheckTreeEditor.md#createslickcontainer)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L404)

Override initSleekGrid to add plugins to the sleekgrid

#### Returns

`ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSlickGrid`](CheckTreeEditor.md#createslickgrid)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`createToolbar`](CheckTreeEditor.md#createtoolbar)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L516)

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`createToolbarExtensions`](CheckTreeEditor.md#createtoolbarextensions)

***

### createView()

> `protected` **createView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L626)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createView`](CheckTreeEditor.md#createview)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`dateRangeQuickFilter`](CheckTreeEditor.md#daterangequickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`dateTimeRangeQuickFilter`](CheckTreeEditor.md#datetimerangequickfilter)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`deferRender`](CheckTreeEditor.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:494](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L494)

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`destroy`](CheckTreeEditor.md#destroy)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`determineText`](CheckTreeEditor.md#determinetext)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`editItem`](CheckTreeEditor.md#edititem)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`editItemOfType`](CheckTreeEditor.md#edititemoftype)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`EditLink`](CheckTreeEditor.md#editlink)

***

### enableAdvancedFiltering()

> `protected` **enableAdvancedFiltering**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:639](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L639)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`enableAdvancedFiltering`](CheckTreeEditor.md#enableadvancedfiltering)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L190)

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`ensureQuickFilterBar`](CheckTreeEditor.md#ensurequickfilterbar)

***

### filterItems()

> `protected` **filterItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.ts:554](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L554)

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L376)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`filterStoreChanged`](CheckTreeEditor.md#filterstorechanged)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`findById`](CheckTreeEditor.md#findbyid)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`findQuickFilter`](CheckTreeEditor.md#findquickfilter)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:638](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L638)

#### Returns

`string`

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L594)

#### Returns

`string`

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.ts:654](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L654)

#### Returns

`any`

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:674](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L674)

#### Returns

`string`

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.ts:690](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L690)

#### Returns

`any`

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:399](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L399)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`get_readOnly`](CheckTreeEditor.md#get_readonly)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L486)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getAddButtonCaption`](CheckTreeEditor.md#getaddbuttoncaption)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/editors/checktreeeditor.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L512)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getButtons`](CheckTreeEditor.md#getbuttons)

***

### getCascadeFromValue()

> `protected` **getCascadeFromValue**(`parent`): `any`

Defined in: [src/ui/editors/checktreeeditor.ts:602](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L602)

#### Parameters

##### parent

[`Widget`](Widget.md)\<`any`\>

#### Returns

`any`

***

### ~~getColumns()~~

> `protected` **getColumns**(): `Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:822](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L822)

#### Returns

`Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

#### Deprecated

override createColumns

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumns`](CheckTreeEditor.md#getcolumns)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:784](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L784)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnsKey`](CheckTreeEditor.md#getcolumnskey)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L336)

#### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnWidthDelta`](CheckTreeEditor.md#getcolumnwidthdelta)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L340)

#### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnWidthScale`](CheckTreeEditor.md#getcolumnwidthscale)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCssClass`](CheckTreeEditor.md#getcssclass)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCurrentSettings`](CheckTreeEditor.md#getcurrentsettings)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCustomAttribute`](CheckTreeEditor.md#getcustomattribute)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

Defined in: [src/ui/datagrid/datagrid.tsx:631](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L631)

#### Returns

`any`[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDefaultSortBy`](CheckTreeEditor.md#getdefaultsortby)

***

### getDelimited()

> `protected` **getDelimited**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L305)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDelimited`](CheckTreeEditor.md#getdelimited)

***

### getDescendantsSelected()

> `protected` **getDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L257)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDescendantsSelected`](CheckTreeEditor.md#getdescendantsselected)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getEditValue`](CheckTreeEditor.md#geteditvalue)

***

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/datagrid.tsx:1238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1238)

#### Returns

`HTMLElement`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getElement`](CheckTreeEditor.md#getelement)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1256)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getFilterStore`](CheckTreeEditor.md#getfilterstore)

***

### getGrid()

> **getGrid**(): `ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:1242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1242)

#### Returns

`ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGrid`](CheckTreeEditor.md#getgrid)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:874](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L874)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGridCanLoad`](CheckTreeEditor.md#getgridcanload)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGridField`](CheckTreeEditor.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L44)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIdProperty`](CheckTreeEditor.md#getidproperty)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L570)

#### Parameters

##### include

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIncludeColumns`](CheckTreeEditor.md#getincludecolumns)

***

### getInitialCollapse()

> `protected` **getInitialCollapse**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L156)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getInitialCollapse`](CheckTreeEditor.md#getinitialcollapse)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L183)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getInitialTitle`](CheckTreeEditor.md#getinitialtitle)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:989](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L989)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIsActiveProperty`](CheckTreeEditor.md#getisactiveproperty)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:983](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L983)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIsDeletedProperty`](CheckTreeEditor.md#getisdeletedproperty)

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L303)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

##### index

`number`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemCssClass`](CheckTreeEditor.md#getitemcssclass)

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L307)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

##### index

`number`

#### Returns

`any`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemMetadata`](CheckTreeEditor.md#getitemmetadata)

***

### getItems()

> **getItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L453)

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItems`](CheckTreeEditor.md#getitems)

***

### getItemText()

> `protected` **getItemText**(`ctx`): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L355)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemText`](CheckTreeEditor.md#getitemtext)

***

### getItemType()

> `protected` **getItemType**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:730](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L730)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemType`](CheckTreeEditor.md#getitemtype)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:950](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L950)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getLocalTextDbPrefix`](CheckTreeEditor.md#getlocaltextdbprefix)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:962](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L962)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getLocalTextPrefix`](CheckTreeEditor.md#getlocaltextprefix)

***

### getLookupItems()

> `protected` **getLookupItems**(`lookup`): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L570)

#### Parameters

##### lookup

[`Lookup`](Lookup.md)\<`TItem`\>

#### Returns

`TItem`[]

***

### getLookupKey()

> `protected` **getLookupKey**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L508)

#### Returns

`string`

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

Defined in: [src/ui/datagrid/datagrid.tsx:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L660)

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPagerOptions`](CheckTreeEditor.md#getpageroptions)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1110)

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistedSettings`](CheckTreeEditor.md#getpersistedsettings)

***

### getPersistenceKey()

> `protected` **getPersistenceKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1070](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1070)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistenceKey`](CheckTreeEditor.md#getpersistencekey)

***

### getPersistenceStorage()

> `protected` **getPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1064](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1064)

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistenceStorage`](CheckTreeEditor.md#getpersistencestorage)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L788)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItems`](CheckTreeEditor.md#getpropertyitems)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:792](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L792)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItemsData`](CheckTreeEditor.md#getpropertyitemsdata)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:812](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L812)

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItemsDataAsync`](CheckTreeEditor.md#getpropertyitemsdataasync)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L220)

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getQuickFilters`](CheckTreeEditor.md#getquickfilters)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L255)

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getQuickSearchFields`](CheckTreeEditor.md#getquicksearchfields)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/datagrid/datagrid.tsx:944](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L944)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getRowDefinition`](CheckTreeEditor.md#getrowdefinition)

***

### getSelectAllText()

> `protected` **getSelectAllText**(): `string`

Defined in: [src/ui/editors/checktreeeditor.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L525)

#### Returns

`string`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getSelectAllText`](CheckTreeEditor.md#getselectalltext)

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`

Defined in: [src/ui/editors/checktreeeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L359)

#### Returns

`GridOptions`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getSlickOptions`](CheckTreeEditor.md#getslickoptions)

***

### getTitle()

> **getTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L702)

#### Returns

`string`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getTitle`](CheckTreeEditor.md#gettitle)

***

### getTreeItems()

> `protected` **getTreeItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

Defined in: [src/ui/editors/checktreeeditor.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L574)

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getTreeItems`](CheckTreeEditor.md#gettreeitems)

***

### getView()

> **getView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:1252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1252)

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getView`](CheckTreeEditor.md#getview)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L672)

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getViewOptions`](CheckTreeEditor.md#getviewoptions)

***

### gridPersistenceFlags()

> `protected` **gridPersistenceFlags**(): [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1083)

#### Returns

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`gridPersistenceFlags`](CheckTreeEditor.md#gridpersistenceflags)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridClick`](CheckTreeEditor.md#handlegridclick)

***

### handleGridColumnsReordered()

> `protected` **handleGridColumnsReordered**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L470)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridColumnsReordered`](CheckTreeEditor.md#handlegridcolumnsreordered)

***

### handleGridColumnsResized()

> `protected` **handleGridColumnsResized**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L474)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridColumnsResized`](CheckTreeEditor.md#handlegridcolumnsresized)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridSort`](CheckTreeEditor.md#handlegridsort)

***

### handleViewFilter()

> `protected` **handleViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:537](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L537)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleViewFilter`](CheckTreeEditor.md#handleviewfilter)

***

### handleViewProcessData()

> `protected` **handleViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L546)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleViewProcessData`](CheckTreeEditor.md#handleviewprocessdata)

***

### handleViewSubmit()

> `protected` **handleViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L553)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleViewSubmit`](CheckTreeEditor.md#handleviewsubmit)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`init`](CheckTreeEditor.md#init)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L366)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initializeFilterBar`](CheckTreeEditor.md#initializefilterbar)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L344)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initialPopulate`](CheckTreeEditor.md#initialpopulate)

***

### initSleekGrid()

> `protected` **initSleekGrid**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L122)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initSleekGrid`](CheckTreeEditor.md#initsleekgrid)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:915](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L915)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`internalRefresh`](CheckTreeEditor.md#internalrefresh)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`internalRenderContents`](CheckTreeEditor.md#internalrendercontents)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`invokeSubmitHandlers`](CheckTreeEditor.md#invokesubmithandlers)

***

### isThreeStateHierarchy()

> `protected` **isThreeStateHierarchy**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L118)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`isThreeStateHierarchy`](CheckTreeEditor.md#isthreestatehierarchy)

***

### itemAt()

> **itemAt**(`row`): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)

Defined in: [src/ui/datagrid/datagrid.tsx:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L441)

#### Parameters

##### row

`number`

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemAt`](CheckTreeEditor.md#itemat)

***

### itemId()

> **itemId**(`item`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L445)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Returns

`any`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemId`](CheckTreeEditor.md#itemid)

***

### itemLink()

> `protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:734](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L734)

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

***

### itemSelectedChanged()

> `protected` **itemSelectedChanged**(`item`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L111)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemSelectedChanged`](CheckTreeEditor.md#itemselectedchanged)

***

### layout()

> `protected` **layout**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L161)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`layout`](CheckTreeEditor.md#layout)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`legacyTemplateRender`](CheckTreeEditor.md#legacytemplaterender)

***

### markupReady()

> `protected` **markupReady**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L618)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`markupReady`](CheckTreeEditor.md#markupready)

***

### moveSelectedUp()

> `protected` **moveSelectedUp**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L590)

#### Returns

`boolean`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`moveSelectedUp`](CheckTreeEditor.md#moveselectedup)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onClick`](CheckTreeEditor.md#onclick)

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L584)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

#### Returns

`boolean`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewFilter`](CheckTreeEditor.md#onviewfilter)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/editors/checktreeeditor.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L160)

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewProcessData`](CheckTreeEditor.md#onviewprocessdata)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:609](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L609)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewSubmit`](CheckTreeEditor.md#onviewsubmit)

***

### persistenceLock()

> **persistenceLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1187)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistenceLock`](CheckTreeEditor.md#persistencelock)

***

### persistenceUnlock()

> **persistenceUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1191)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistenceUnlock`](CheckTreeEditor.md#persistenceunlock)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistSettings`](CheckTreeEditor.md#persistsettings)

***

### populateLock()

> `protected` **populateLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:866](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L866)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateLock`](CheckTreeEditor.md#populatelock)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:870](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L870)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateUnlock`](CheckTreeEditor.md#populateunlock)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L646)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateWhenVisible`](CheckTreeEditor.md#populatewhenvisible)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`postProcessColumns`](CheckTreeEditor.md#postprocesscolumns)

***

### prepareSubmit()

> **prepareSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:886](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L886)

Prepares submit arguments in this.view.params by calling this.view.onSubmit if available, or this.handleViewSubmit if not. 
Note that if getGridCanLoad returns false, the prepared arguments might be in a incomplete state.

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`prepareSubmit`](CheckTreeEditor.md#preparesubmit)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsReady`](CheckTreeEditor.md#propertyitemsready)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsToColumns`](CheckTreeEditor.md#propertyitemstocolumns)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFilterChange`](CheckTreeEditor.md#quickfilterchange)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L895)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`refresh`](CheckTreeEditor.md#refresh)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:908](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L908)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`refreshIfNeeded`](CheckTreeEditor.md#refreshifneeded)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`render`](CheckTreeEditor.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`renderContents`](CheckTreeEditor.md#rendercontents)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1000)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`resizeCanvas`](CheckTreeEditor.md#resizecanvas)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoreSettings`](CheckTreeEditor.md#restoresettings)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoreSettingsFrom`](CheckTreeEditor.md#restoresettingsfrom)

***

### rowCount()

> **rowCount**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:449](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L449)

#### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`rowCount`](CheckTreeEditor.md#rowcount)

***

### set\_cascadeField()

> `protected` **set\_cascadeField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L646)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### set\_cascadeFrom()

> `protected` **set\_cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L627)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### set\_cascadeValue()

> `protected` **set\_cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L662)

#### Parameters

##### value

`any`

#### Returns

`void`

***

### set\_filterField()

> `protected` **set\_filterField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L682)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### set\_filterValue()

> `protected` **set\_filterValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L698)

#### Parameters

##### value

`any`

#### Returns

`void`

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:403](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L403)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`set_readOnly`](CheckTreeEditor.md#set_readonly)

***

### setAllSubTreeSelected()

> `protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L261)

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

##### selected

`boolean`

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setAllSubTreeSelected`](CheckTreeEditor.md#setallsubtreeselected)

***

### setCascadeFrom()

> `protected` **setCascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L608)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:585](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L585)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setCriteriaParameter`](CheckTreeEditor.md#setcriteriaparameter)

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

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setEditValue`](CheckTreeEditor.md#seteditvalue)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`setEquality`](CheckTreeEditor.md#setequality)

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L599)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setIncludeColumnsParameter`](CheckTreeEditor.md#setincludecolumnsparameter)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L416)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setInitialSortOrder`](CheckTreeEditor.md#setinitialsortorder)

***

### setItems()

> **setItems**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L457)

#### Parameters

##### value

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setItems`](CheckTreeEditor.md#setitems)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`setTitle`](CheckTreeEditor.md#settitle)

***

### sortItems()

> `protected` **sortItems**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L365)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`sortItems`](CheckTreeEditor.md#sortitems)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1004](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1004)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`subDialogDataChange`](CheckTreeEditor.md#subdialogdatachange)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`syncOrAsyncThen`](CheckTreeEditor.md#syncorasyncthen)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`tryFindQuickFilter`](CheckTreeEditor.md#tryfindquickfilter)

***

### updateFlags()

> `protected` **updateFlags**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L220)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateFlags`](CheckTreeEditor.md#updateflags)

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:940](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L940)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateInterface`](CheckTreeEditor.md#updateinterface)

***

### updateItems()

> `protected` **updateItems**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L503)

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateItems`](CheckTreeEditor.md#updateitems)

***

### updateSelectAll()

> `protected` **updateSelectAll**(): `void`

Defined in: [src/ui/editors/checktreeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L214)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateSelectAll`](CheckTreeEditor.md#updateselectall)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L153)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useAsync`](CheckTreeEditor.md#useasync)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useIdPrefix`](CheckTreeEditor.md#useidprefix)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L157)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useLayoutTimer`](CheckTreeEditor.md#uselayouttimer)

***

### usePager()

> `protected` **usePager**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L635)

#### Returns

`boolean`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`usePager`](CheckTreeEditor.md#usepager)

***

### viewDataChanged()

> `protected` **viewDataChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:523](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L523)

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`viewDataChanged`](CheckTreeEditor.md#viewdatachanged)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`wrapFormatterWithEditLink`](CheckTreeEditor.md#wrapformatterwitheditlink)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`create`](CheckTreeEditor.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

Defined in: [src/ui/editors/checktreeeditor.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.ts#L33)

#### Returns

`HTMLDivElement`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createDefaultElement`](CheckTreeEditor.md#createdefaultelement)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`getWidgetName`](CheckTreeEditor.md#getwidgetname)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemToQuickFilter`](CheckTreeEditor.md#propertyitemtoquickfilter)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`registerClass`](CheckTreeEditor.md#registerclass)

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

[`CheckTreeEditor`](CheckTreeEditor.md).[`registerEditor`](CheckTreeEditor.md#registereditor)
