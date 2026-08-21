[@serenity-is/corelib](../README.md) / CheckLookupEditor

# Class: CheckLookupEditor\<TItem, P\>

Defined in: [src/ui/editors/checktreeeditor.tsx:640](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L640)

A [CheckTreeEditor](CheckTreeEditor.md) that populates its tree from a lookup, with optional cascading, filtering and search.

## Extends

- [`CheckTreeEditor`](CheckTreeEditor.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>, `P`\>

## Type Parameters

### TItem

`TItem` *extends* [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\> = `any`

The lookup item type.

### P

`P` *extends* [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md) = [`CheckLookupEditorOptions`](../interfaces/CheckLookupEditorOptions.md)

Widget props type.

## Constructors

### Constructor

> **new CheckLookupEditor**\<`TItem`, `P`\>(`props`): `CheckLookupEditor`\<`TItem`, `P`\>

Defined in: [src/ui/editors/checktreeeditor.tsx:651](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L651)

Creates a check lookup editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`CheckLookupEditor`\<`TItem`, `P`\>

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`constructor`](CheckTreeEditor.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/checktreeeditor.tsx:781](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L781)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`domNode`](CheckTreeEditor.md#domnode)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L57)

The advanced filter bar widget.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`filterBar`](CheckTreeEditor.md#filterbar)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`idPrefix`](CheckTreeEditor.md#idprefix)

***

### onAfterInit

> `readonly` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L113)

Raised after this grid is initialized.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onAfterInit`](CheckTreeEditor.md#onafterinit)

***

### onCanSubmit

> `readonly` **onCanSubmit**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L115)

Raised to determine whether the grid can submit its view.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onCanSubmit`](CheckTreeEditor.md#oncansubmit)

***

### onDataChanged

> `readonly` **onDataChanged**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L117)

Raised when the grid data changes.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onDataChanged`](CheckTreeEditor.md#ondatachanged)

***

### onFiltering

> `readonly` **onFiltering**: `PubSub`\<[`DataGridFilteringEvent`](../interfaces/DataGridFilteringEvent.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L119)

Raised while filtering items in the view.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onFiltering`](CheckTreeEditor.md#onfiltering)

***

### onPersistence

> `readonly` **onPersistence**: `PubSub`\<[`DataGridPersistenceEvent`](../interfaces/DataGridPersistenceEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L121)

Raised before/after persisting or restoring grid settings.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onPersistence`](CheckTreeEditor.md#onpersistence)

***

### onProcessData

> `readonly` **onProcessData**: `PubSub`\<[`DataGridProcessEvent`](../interfaces/DataGridProcessEvent.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L123)

Raised when the view processes a list response.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onProcessData`](CheckTreeEditor.md#onprocessdata)

***

### onSetViewParams

> `readonly` **onSetViewParams**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L127)

Raised after view parameters are prepared for submission.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onSetViewParams`](CheckTreeEditor.md#onsetviewparams)

***

### onSubmitting

> `readonly` **onSubmitting**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L125)

Raised to determine whether the view submit should proceed.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onSubmitting`](CheckTreeEditor.md#onsubmitting)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

Whether dialogs opened from this grid should be shown as panels.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`openDialogsAsPanel`](CheckTreeEditor.md#opendialogsaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`options`](CheckTreeEditor.md#options)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L65)

The property items data for this grid.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsData`](CheckTreeEditor.md#propertyitemsdata)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L61)

The quick filter bar widget.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFiltersBar`](CheckTreeEditor.md#quickfiltersbar)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L59)

The quick filters container element.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFiltersDiv`](CheckTreeEditor.md#quickfiltersdiv)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

Defined in: [src/ui/datagrid/datagrid.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L67)

Counter tracking nested settings restoration.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoringSettings`](CheckTreeEditor.md#restoringsettings)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L63)

The container element that hosts the grid.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`slickContainer`](CheckTreeEditor.md#slickcontainer)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L53)

The title element.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`titleDiv`](CheckTreeEditor.md#titlediv)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L55)

The toolbar widget.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`toolbar`](CheckTreeEditor.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`uniqueName`](CheckTreeEditor.md#uniquename)

***

### view

> **view**: [`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

The remote view used for paging and server communication.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`view`](CheckTreeEditor.md#view)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/checktreeeditor.tsx:641](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L641)

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`[typeInfo]`](CheckTreeEditor.md#typeinfo)

***

### defaultOptions

> `readonly` `static` **defaultOptions**: `object` = `dataGridDefaults`

Defined in: [src/ui/datagrid/datagrid.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L75)

Default options shared by all data grid instances.

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

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`isComponent`](CheckTreeEditor.md#iscomponent)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L111)

Static event raised after any grid is initialized.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onAfterInit`](CheckTreeEditor.md#onafterinit-1)

## Accessors

### allColumns

#### Get Signature

> **get** **allColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1837](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1837)

All columns including hidden ones.

##### Returns

`Column`\<`any`\>[]

All columns from the underlying SleekGrid.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allColumns`](CheckTreeEditor.md#allcolumns)

***

### cascadeField

#### Get Signature

> **get** **cascadeField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:823](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L823)

Returns the field name used for cascading.

##### Returns

`string`

The cascade field.

#### Set Signature

> **set** **cascadeField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L835)

Sets the field name used for cascading.

##### Parameters

###### value

`string`

The cascade field name.

##### Returns

`void`

***

### cascadeFrom

#### Get Signature

> **get** **cascadeFrom**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L773)

Returns the id of the parent editor to cascade from.

##### Returns

`string`

The cascade source id.

#### Set Signature

> **set** **cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L813)

Sets the cascade source.

##### Parameters

###### value

`string`

Id of the parent editor to cascade from.

##### Returns

`void`

***

### cascadeValue

#### Get Signature

> **get** **cascadeValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.tsx:845](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L845)

Returns the current cascade filter value.

##### Returns

`any`

The cascade value.

#### Set Signature

> **set** **cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:861](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L861)

Sets the cascade filter value.

##### Parameters

###### value

`any`

The cascade value to set.

##### Returns

`void`

***

### columns

#### Get Signature

> **get** **columns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1839)

The currently visible columns.

##### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`columns`](CheckTreeEditor.md#columns)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`element`](CheckTreeEditor.md#element)

***

### filterField

#### Get Signature

> **get** **filterField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:871](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L871)

Returns the field name used for filtering.

##### Returns

`string`

The filter field.

#### Set Signature

> **set** **filterField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:883](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L883)

Sets the field name used for filtering.

##### Parameters

###### value

`string`

The filter field name.

##### Returns

`void`

***

### filterValue

#### Get Signature

> **get** **filterValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.tsx:893](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L893)

Returns the current filter value.

##### Returns

`any`

The filter value.

#### Set Signature

> **set** **filterValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:909](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L909)

Sets the filter value.

##### Parameters

###### value

`any`

The filter value to set.

##### Returns

`void`

***

### initialSettings

#### Get Signature

> **get** **initialSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1841](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1841)

The initial persisted settings captured at startup.

##### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

#### Set Signature

> **set** **initialSettings**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1843](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1843)

Sets the initial persisted settings.

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

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`props`](CheckTreeEditor.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1341)

Whether the grid is in read-only mode.

##### Returns

`boolean`

`true` if read-only, otherwise `false`.

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1349)

Sets whether the grid is in read-only mode.

##### Parameters

###### value

`boolean`

`true` to enable read-only mode, `false` to disable.

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`readOnly`](CheckTreeEditor.md#readonly)

***

### sleekGrid

#### Get Signature

> **get** **sleekGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1804)

The underlying SleekGrid instance.

##### Returns

`ISleekGrid`\<`TItem`\>

The current SleekGrid instance.

#### Set Signature

> **set** **sleekGrid**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1809](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1809)

Sets the underlying SleekGrid instance.

##### Parameters

###### value

`ISleekGrid`\<`TItem`\>

SleekGrid instance to set.

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`sleekGrid`](CheckTreeEditor.md#sleekgrid)

***

### slickGrid

#### Get Signature

> **get** **slickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1815](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1815)

##### Deprecated

Use `sleekGrid` or `getGrid()`.

##### Returns

`ISleekGrid`\<`TItem`\>

The underlying SleekGrid instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`slickGrid`](CheckTreeEditor.md#slickgrid)

***

### value

#### Get Signature

> **get** **value**(): `string`[]

Defined in: [src/ui/editors/checktreeeditor.tsx:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L561)

Returns the selected item ids.

##### Returns

`string`[]

Array of selected ids.

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:604](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L604)

Sets the selected item ids.

##### Parameters

###### v

`string`[]

Array of ids to select.

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`value`](CheckTreeEditor.md#value)

***

### defaultColumnWidthDelta

#### Get Signature

> **get** `static` **defaultColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L103)

Default column width delta applied to all grids.

##### Returns

`number`

The current column width delta.

#### Set Signature

> **set** `static` **defaultColumnWidthDelta**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L108)

Sets the default column width delta applied to all grids.

##### Parameters

###### value

`number`

Delta in pixels added to each column width.

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultColumnWidthDelta`](CheckTreeEditor.md#defaultcolumnwidthdelta)

***

### defaultColumnWidthScale

#### Get Signature

> **get** `static` **defaultColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L93)

Default column width scale applied to all grids.

##### Returns

`number`

The current column width scale.

#### Set Signature

> **set** `static` **defaultColumnWidthScale**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L98)

Sets the default column width scale applied to all grids.

##### Parameters

###### value

`number`

Scale factor (e.g. `1.1` for 10% wider).

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultColumnWidthScale`](CheckTreeEditor.md#defaultcolumnwidthscale)

***

### defaultPersistanceStorage

#### Get Signature

> **get** `static` **defaultPersistanceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1849](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1849)

##### Deprecated

Use `defaultPersistenceStorage` — this has a typo.

##### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

The current persistence storage.

#### Set Signature

> **set** `static` **defaultPersistanceStorage**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1854](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1854)

##### Deprecated

Use `defaultPersistenceStorage` — this has a typo.

##### Parameters

###### value

[`SettingStorage`](../interfaces/SettingStorage.md)

Persistence storage to set.

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultPersistanceStorage`](CheckTreeEditor.md#defaultpersistancestorage)

***

### defaultPersistenceStorage

#### Get Signature

> **get** `static` **defaultPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L83)

Default storage used for grid persistence.

##### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

The current persistence storage.

#### Set Signature

> **set** `static` **defaultPersistenceStorage**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L88)

Sets the default storage used for grid persistence.

##### Parameters

###### value

[`SettingStorage`](../interfaces/SettingStorage.md)

Persistence storage to use (e.g. `localStorage`-backed).

##### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultPersistenceStorage`](CheckTreeEditor.md#defaultpersistencestorage)

***

### defaultRowHeight

#### Get Signature

> **get** `static` **defaultRowHeight**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L78)

Default row height used when creating grids.

##### Returns

`number`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`defaultRowHeight`](CheckTreeEditor.md#defaultrowheight)

## Methods

### addBooleanFilter()

> `protected` **addBooleanFilter**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](SelectEditor.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1554](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1554)

Adds a boolean quick filter for the specified field.

#### Parameters

##### field

`string`

Field name.

##### title?

`string`

Optional display title.

##### yes?

`string`

Optional text for the true option.

##### no?

`string`

Optional text for the false option.

#### Returns

[`SelectEditor`](SelectEditor.md)

The created select editor.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addBooleanFilter`](CheckTreeEditor.md#addbooleanfilter)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addCssClass`](CheckTreeEditor.md#addcssclass)

***

### addDateRangeFilter()

> `protected` **addDateRangeFilter**(`field`, `title?`): [`DateEditor`](DateEditor.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1512)

Adds a date range quick filter for the specified field.

#### Parameters

##### field

`string`

Field name.

##### title?

`string`

Optional display title.

#### Returns

[`DateEditor`](DateEditor.md)

The created date editor.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addDateRangeFilter`](CheckTreeEditor.md#adddaterangefilter)

***

### addDateTimeRangeFilter()

> `protected` **addDateTimeRangeFilter**(`field`, `title?`): [`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1532](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1532)

Adds a date-time range quick filter for the specified field.

#### Parameters

##### field

`string`

Field name.

##### title?

`string`

Optional display title.

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

The created date-time editor.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addDateTimeRangeFilter`](CheckTreeEditor.md#adddatetimerangefilter)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1476)

Adds a separator to the quick filter bar.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addFilterSeparator`](CheckTreeEditor.md#addfilterseparator)

***

### addQuickFilter()

> `protected` **addQuickFilter**\<`TWidget`, `P`\>(`opt`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:1502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1502)

Adds a quick filter to the quick filter bar.

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`any`\>

##### P

`P`

#### Parameters

##### opt

[`QuickFilter`](../interfaces/QuickFilter.md)\<`TWidget`, `P`\>

Quick filter definition.

#### Returns

`TWidget`

The created widget instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addQuickFilter`](CheckTreeEditor.md#addquickfilter)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

###### uniqueName?

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addValidationRule`](CheckTreeEditor.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L143)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### uniqueName

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`addValidationRule`](CheckTreeEditor.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L219)

Hook invoked after the grid is initialized and settings are restored.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`afterInit`](CheckTreeEditor.md#afterinit)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L228)

Queues a callback to run after the widget's contents are rendered.

#### Parameters

##### callback

() => `void`

The callback to run after rendering.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`afterRender`](CheckTreeEditor.md#afterrender)

***

### allDescendantsSelected()

> `protected` **allDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L398)

Whether all descendants of an item are selected.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item.

#### Returns

`boolean`

True when all descendants are selected.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allDescendantsSelected`](CheckTreeEditor.md#alldescendantsselected)

***

### allItemsSelected()

> `protected` **allItemsSelected**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L382)

Whether all items are selected.

#### Returns

`boolean`

True when all items are selected.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`allItemsSelected`](CheckTreeEditor.md#allitemsselected)

***

### anyDescendantsSelected()

> `protected` **anyDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:427](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L427)

Whether any descendant of an item is selected.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item.

#### Returns

`boolean`

True when any descendant is selected.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`anyDescendantsSelected`](CheckTreeEditor.md#anydescendantsselected)

***

### autoRegisteringPlugin()

> `protected` **autoRegisteringPlugin**(`args`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L164)

Hook invoked when the grid is registered as an auto-registering plugin.

#### Parameters

##### args

[`AutoRegisterArgs`](../interfaces/AutoRegisterArgs.md)

Auto-registration arguments.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`autoRegisteringPlugin`](CheckTreeEditor.md#autoregisteringplugin)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L697)

Subscribes to the underlying grid events.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`bindToSlickEvents`](CheckTreeEditor.md#bindtoslickevents)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L777)

Subscribes to view events for filtering, submitting, and processing data.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`bindToViewEvents`](CheckTreeEditor.md#bindtoviewevents)

***

### booleanQuickFilter()

> `protected` **booleanQuickFilter**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1566)

Creates a boolean quick filter definition.

#### Parameters

##### field

`string`

Field name.

##### title?

`string`

Optional display title.

##### yes?

`string`

Optional text for the true option.

##### no?

`string`

Optional text for the false option.

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

A quick filter definition.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`booleanQuickFilter`](CheckTreeEditor.md#booleanquickfilter)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L154)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

A [Fluent](../functions/Fluent.md) wrapper for the matching element.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`byId`](CheckTreeEditor.md#byid)

***

### canFilterColumn()

> `protected` **canFilterColumn**(`column`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L526)

Whether the given column can be used in the advanced filter bar.

#### Parameters

##### column

`Column`

Column to check.

#### Returns

`boolean`

True when the column is filterable.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`canFilterColumn`](CheckTreeEditor.md#canfiltercolumn)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.tsx:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L705)

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

Registers a `change` handler on the widget's DOM node.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`change`](CheckTreeEditor.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

Registers a `change` handler that ignores changes originating from
combobox setting values.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`changeSelect2`](CheckTreeEditor.md#changeselect2)

***

### createColumns()

> `protected` **createColumns**(): `Column`\<`any`\>[]

Defined in: [src/ui/editors/checktreeeditor.tsx:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L446)

Creates the grid columns for the tree.

#### Returns

`Column`\<`any`\>[]

The columns.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createColumns`](CheckTreeEditor.md#createcolumns)

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:981](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L981)

Creates the advanced filter bar and initializes its store.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createFilterBar`](CheckTreeEditor.md#createfilterbar)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L369)

Creates the include-deleted toggle button when the row type supports it.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createIncludeDeletedButton`](CheckTreeEditor.md#createincludedeletedbutton)

***

### createPager()

> `protected` **createPager**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1006](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1006)

Creates the pager widget for this grid.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createPager`](CheckTreeEditor.md#createpager)

***

### createQuickFilters()

> `protected` **createQuickFilters**(`filters?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L293)

Creates the quick filter bar with the given filters.

#### Parameters

##### filters?

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Quick filter definitions to render.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createQuickFilters`](CheckTreeEditor.md#createquickfilters)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L385)

Creates the quick search input in the toolbar.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createQuickSearchInput`](CheckTreeEditor.md#createquicksearchinput)

***

### createSleekColumns()

> `protected` **createSleekColumns**(): `Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:571](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L571)

Creates the SleekGrid columns. This method calls createColumns (via getColumns for compatibility) and then post processes them.

#### Returns

`Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

The SleekGrid columns.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSleekColumns`](CheckTreeEditor.md#createsleekcolumns)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:930](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L930)

Creates the container element that hosts the grid.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

The grid container element.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSlickContainer`](CheckTreeEditor.md#createslickcontainer)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L580)

Creates the underlying SleekGrid instance with the processed columns.

#### Returns

`ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The created grid instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createSlickGrid`](CheckTreeEditor.md#createslickgrid)

***

### createToolbar()

> `protected` **createToolbar**(`buttons`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1040](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1040)

Creates the toolbar with the given buttons.

#### Parameters

##### buttons

[`ToolButton`](../interfaces/ToolButton.md)[]

Tool button definitions.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createToolbar`](CheckTreeEditor.md#createtoolbar)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:685](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L685)

Hook for subclasses to add extra toolbar buttons or controls.

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`createToolbarExtensions`](CheckTreeEditor.md#createtoolbarextensions)

***

### createView()

> `protected` **createView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:938](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L938)

Creates the remote view used for paging and server communication.

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The remote view instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createView`](CheckTreeEditor.md#createview)

***

### dateRangeQuickFilter()

> `protected` **dateRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1522)

Creates a date range quick filter definition.

#### Parameters

##### field

`string`

Field name.

##### title?

`string`

Optional display title.

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

A quick filter definition.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`dateRangeQuickFilter`](CheckTreeEditor.md#daterangequickfilter)

***

### dateTimeRangeQuickFilter()

> `protected` **dateTimeRangeQuickFilter**(`field`, `title?`): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1542](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1542)

Creates a date-time range quick filter definition.

#### Parameters

##### field

`string`

Field name.

##### title?

`string`

Optional display title.

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

A quick filter definition.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`dateTimeRangeQuickFilter`](CheckTreeEditor.md#datetimerangequickfilter)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L98)

Determines whether rendering should be deferred until [init](#init) is
called.

#### Returns

`boolean`

True to defer rendering.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`deferRender`](CheckTreeEditor.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:663](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L663)

Cleans up lookup change handlers and delegates to the base destroy.

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`destroy`](CheckTreeEditor.md#destroy)

***

### determineText()

> `protected` **determineText**(`getKey`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1485)

Resolves a localized text using the grid's local text db prefix.

#### Parameters

##### getKey

(`prefix`) => `string`

Callback that builds the text key from the prefix.

#### Returns

`string`

The localized text, or null if not found.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`determineText`](CheckTreeEditor.md#determinetext)

***

### editItem()

> `protected` **editItem**(`entityOrId`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:725](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L725)

Opens an edit dialog for the given entity or id.

#### Parameters

##### entityOrId

`any`

Entity instance or identifier to edit.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`editItem`](CheckTreeEditor.md#edititem)

***

### editItemOfType()

> `protected` **editItemOfType**(`itemType`, `entityOrId`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:734](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L734)

Opens an edit dialog for a specific item type.

#### Parameters

##### itemType

`string`

Item type key.

##### entityOrId

`any`

Entity instance or identifier to edit.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`editItemOfType`](CheckTreeEditor.md#edititemoftype)

***

### EditLink()

> **EditLink**(`props`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:1107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1107)

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

Defined in: [src/ui/datagrid/datagrid.tsx:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L963)

Whether advanced filtering is enabled for this grid.

#### Returns

`boolean`

True when advanced filtering is enabled.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`enableAdvancedFiltering`](CheckTreeEditor.md#enableadvancedfiltering)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L281)

Ensures the quick filter bar exists and returns it.

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

The quick filter bar instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`ensureQuickFilterBar`](CheckTreeEditor.md#ensurequickfilterbar)

***

### filterItems()

> `protected` **filterItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.tsx:727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L727)

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:549](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L549)

Handles filter store changes by persisting settings and refreshing.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`filterStoreChanged`](CheckTreeEditor.md#filterstorechanged)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

`TElement`

The matching element, or null if not found.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`findById`](CheckTreeEditor.md#findbyid)

***

### findQuickFilter()

> `protected` **findQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L344)

Finds a quick filter widget by field name.

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### type

(...`args`) => `TWidget`

Widget constructor type.

##### field

`string`

Field name of the quick filter.

#### Returns

`TWidget`

The widget instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`findQuickFilter`](CheckTreeEditor.md#findquickfilter)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:817](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L817)

#### Returns

`string`

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:767](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L767)

#### Returns

`string`

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.tsx:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L839)

#### Returns

`any`

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:865](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L865)

#### Returns

`string`

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/checktreeeditor.tsx:887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L887)

#### Returns

`any`

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:533](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L533)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`get_readOnly`](CheckTreeEditor.md#get_readonly)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:709](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L709)

Returns the caption for the add/new button.

#### Returns

`string`

The add button caption.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getAddButtonCaption`](CheckTreeEditor.md#getaddbuttoncaption)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/editors/checktreeeditor.tsx:681](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L681)

Returns the toolbar buttons for the editor.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

Tool button definitions.

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getButtons`](CheckTreeEditor.md#getbuttons)

***

### getCascadeFromValue()

> `protected` **getCascadeFromValue**(`parent`): `any`

Defined in: [src/ui/editors/checktreeeditor.tsx:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L777)

#### Parameters

##### parent

[`Widget`](Widget.md)\<`any`\>

#### Returns

`any`

***

### ~~getColumns()~~

> `protected` **getColumns**(): `Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1203)

#### Returns

`Column`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>[]

#### Deprecated

override createColumns

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumns`](CheckTreeEditor.md#getcolumns)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1153)

Returns the columns key used to load property items.

#### Returns

`string`

The columns key, or null for none.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnsKey`](CheckTreeEditor.md#getcolumnskey)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L491)

Returns the width delta applied to all columns.

#### Returns

`number`

The column width delta.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnWidthDelta`](CheckTreeEditor.md#getcolumnwidthdelta)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L499)

Returns the width scale applied to all columns.

#### Returns

`number`

The column width scale.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getColumnWidthScale`](CheckTreeEditor.md#getcolumnwidthscale)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCssClass`](CheckTreeEditor.md#getcssclass)

***

### getCurrentSettings()

> **getCurrentSettings**(`flags?`): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1754](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1754)

Returns the current grid settings snapshot.

#### Parameters

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Optional persistence flags.

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

The current grid settings.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCurrentSettings`](CheckTreeEditor.md#getcurrentsettings)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L220)

Returns a custom attribute applied to the widget's type.

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

The attribute type to look up.

##### inherit

`boolean` = `true`

Whether to search inherited types; defaults to true.

#### Returns

`TAttr`

The matching attribute, or null.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getCustomAttribute`](CheckTreeEditor.md#getcustomattribute)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

Defined in: [src/ui/datagrid/datagrid.tsx:947](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L947)

Returns the default sort order for the grid.

#### Returns

`any`[]

Array of sort descriptors.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDefaultSortBy`](CheckTreeEditor.md#getdefaultsortby)

***

### getDelimited()

> `protected` **getDelimited**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L418)

Returns whether the value is delimited.

#### Returns

`boolean`

True when delimited.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDelimited`](CheckTreeEditor.md#getdelimited)

***

### getDescendantsSelected()

> `protected` **getDescendantsSelected**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L351)

Whether all descendants of an item are selected.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item.

#### Returns

`boolean`

True when all descendants are selected.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getDescendantsSelected`](CheckTreeEditor.md#getdescendantsselected)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L112)

Gets the edit value into a target object.

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item.

##### target

`any`

The target object.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getEditValue`](CheckTreeEditor.md#geteditvalue)

***

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/datagrid.tsx:1788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1788)

Returns the root DOM element of the grid widget.

#### Returns

`HTMLElement`

The grid container element.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getElement`](CheckTreeEditor.md#getelement)

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1829](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1829)

Returns the filter store owned by the grid.

#### Returns

[`FilterStore`](FilterStore.md)

The filter store, or null if no filter bar exists.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getFilterStore`](CheckTreeEditor.md#getfilterstore)

***

### getGrid()

> **getGrid**(): `ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:1796](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1796)

Returns the underlying SleekGrid instance.

#### Returns

`ISleekGrid`\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The grid instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGrid`](CheckTreeEditor.md#getgrid)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1279)

Determines whether the grid can load data, notifying onCanSubmit subscribers.

#### Returns

`boolean`

True when the grid can load.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGridCanLoad`](CheckTreeEditor.md#getgridcanload)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getGridField`](CheckTreeEditor.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L71)

Returns the id property name.

#### Returns

`string`

"id".

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIdProperty`](CheckTreeEditor.md#getidproperty)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(`include`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:846](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L846)

Collects the fields and referenced fields of all columns into the given map.

#### Parameters

##### include

Map to populate with column field names.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIncludeColumns`](CheckTreeEditor.md#getincludecolumns)

***

### getInitialCollapse()

> `protected` **getInitialCollapse**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L228)

Returns the initial collapse state for tree rows.

#### Returns

`boolean`

True when collapsed.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getInitialCollapse`](CheckTreeEditor.md#getinitialcollapse)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L267)

Returns the initial title shown above the grid.

#### Returns

`string`

The title text, or null for no title.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getInitialTitle`](CheckTreeEditor.md#getinitialtitle)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1448)

Returns the is-active property name for this grid.

#### Returns

`string`

The is-active property name.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIsActiveProperty`](CheckTreeEditor.md#getisactiveproperty)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1438)

Returns the is-deleted property name for this grid.

#### Returns

`string`

The is-deleted property name, or undefined.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getIsDeletedProperty`](CheckTreeEditor.md#getisdeletedproperty)

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L443)

Returns the CSS class for a grid row based on its active/deleted state.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The row item.

##### index

`number`

The row index.

#### Returns

`string`

The CSS class name, or an empty string.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemCssClass`](CheckTreeEditor.md#getitemcssclass)

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L453)

Returns row metadata (e.g. CSS classes) for the given item.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The row item.

##### index

`number`

The row index.

#### Returns

`any`

Row metadata object.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemMetadata`](CheckTreeEditor.md#getitemmetadata)

***

### getItems()

> **getItems**(): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:651](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L651)

Returns the items currently displayed in the grid.

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

The grid items.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItems`](CheckTreeEditor.md#getitems)

***

### getItemText()

> `protected` **getItemText**(`ctx`): `FormatterResult`

Defined in: [src/ui/editors/checktreeeditor.tsx:474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L474)

Returns the display text for an item.

#### Parameters

##### ctx

`FormatterContext`

The formatter context.

#### Returns

`FormatterResult`

The item text.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemText`](CheckTreeEditor.md#getitemtext)

***

### getItemType()

> `protected` **getItemType**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1088](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1088)

Returns the item type key for this grid.

#### Returns

`string`

The item type key.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getItemType`](CheckTreeEditor.md#getitemtype)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1393)

Returns the local text database prefix for this grid.

#### Returns

`string`

The local text db prefix.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getLocalTextDbPrefix`](CheckTreeEditor.md#getlocaltextdbprefix)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1409)

Returns the local text prefix for this grid.

#### Returns

`string`

The local text prefix, or undefined.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getLocalTextPrefix`](CheckTreeEditor.md#getlocaltextprefix)

***

### getLookupItems()

> `protected` **getLookupItems**(`lookup`): `TItem`[]

Defined in: [src/ui/editors/checktreeeditor.tsx:743](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L743)

#### Parameters

##### lookup

[`Lookup`](Lookup.md)\<`TItem`\>

#### Returns

`TItem`[]

***

### getLookupKey()

> `protected` **getLookupKey**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:677](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L677)

#### Returns

`string`

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

Defined in: [src/ui/datagrid/datagrid.tsx:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L995)

Returns the pager options for this grid.

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

Pager options.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPagerOptions`](CheckTreeEditor.md#getpageroptions)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1630)

Retrieves the persisted grid settings from storage.

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

The persisted settings, or a promise resolving to them.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistedSettings`](CheckTreeEditor.md#getpersistedsettings)

***

### getPersistenceKey()

> `protected` **getPersistenceKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1603](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1603)

Returns the key used to store grid settings.

#### Returns

`string`

The persistence key.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistenceKey`](CheckTreeEditor.md#getpersistencekey)

***

### getPersistenceStorage()

> `protected` **getPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1593)

Returns the storage used for grid persistence.

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

The persistence storage.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPersistenceStorage`](CheckTreeEditor.md#getpersistencestorage)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1161)

Returns the property items for this grid.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The property items.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItems`](CheckTreeEditor.md#getpropertyitems)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1169)

Loads the property items data, either from script data or local items.

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

The property items data.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItemsData`](CheckTreeEditor.md#getpropertyitemsdata)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1193)

Asynchronously loads the property items data.

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to the property items data.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getPropertyItemsDataAsync`](CheckTreeEditor.md#getpropertyitemsdataasync)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L319)

Returns the quick filter definitions derived from the grid columns.

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Quick filter definitions for columns marked as quick filters.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getQuickFilters`](CheckTreeEditor.md#getquickfilters)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L378)

Returns the quick search fields available for this grid.

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

The quick search fields, or null for none.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getQuickSearchFields`](CheckTreeEditor.md#getquicksearchfields)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1383)

Returns the row definition for this grid.

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

The row definition, or null for none.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getRowDefinition`](CheckTreeEditor.md#getrowdefinition)

***

### getSelectAllText()

> `protected` **getSelectAllText**(): `string`

Defined in: [src/ui/editors/checktreeeditor.tsx:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L698)

Returns the text for the select-all button.

#### Returns

`string`

The select-all text.

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getSelectAllText`](CheckTreeEditor.md#getselectalltext)

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`

Defined in: [src/ui/editors/checktreeeditor.tsx:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L482)

Returns the grid options for the editor.

#### Returns

`GridOptions`

Grid options.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getSlickOptions`](CheckTreeEditor.md#getslickoptions)

***

### getTitle()

> **getTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

Returns the current grid title text.

#### Returns

`string`

The title text, or null if no title is set.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getTitle`](CheckTreeEditor.md#gettitle)

***

### getTreeItems()

> `protected` **getTreeItems**(): `object`[]

Defined in: [src/ui/editors/checktreeeditor.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L747)

Returns the tree items to display.

#### Returns

`object`[]

The tree items.

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`getTreeItems`](CheckTreeEditor.md#gettreeitems)

***

### getView()

> **getView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:1821](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1821)

Returns the remote view used for paging and server communication.

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The remote view instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getView`](CheckTreeEditor.md#getview)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1014](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1014)

Returns the remote view options for this grid.

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`any`\>

Remote view options.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getViewOptions`](CheckTreeEditor.md#getviewoptions)

***

### gridPersistenceFlags()

> `protected` **gridPersistenceFlags**(): [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1620)

Returns the default persistence flags for this grid.

#### Returns

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Grid persistence flags.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`gridPersistenceFlags`](CheckTreeEditor.md#gridpersistenceflags)

***

### handleGridClick()

> `protected` **handleGridClick**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L676)

Handles grid cell click events by delegating to onClick.

#### Parameters

##### e

`CellMouseEvent`

Cell mouse event.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridClick`](CheckTreeEditor.md#handlegridclick)

***

### handleGridColumnsReordered()

> `protected` **handleGridColumnsReordered**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L683)

Persists settings when columns are reordered.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridColumnsReordered`](CheckTreeEditor.md#handlegridcolumnsreordered)

***

### handleGridColumnsResized()

> `protected` **handleGridColumnsResized**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:690](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L690)

Persists settings when columns are resized.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridColumnsResized`](CheckTreeEditor.md#handlegridcolumnsresized)

***

### handleGridSort()

> `protected` **handleGridSort**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:667](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L667)

Handles grid sort events by applying the sort and persisting settings.

#### Parameters

##### e

`GridSortEvent`

Grid sort event.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleGridSort`](CheckTreeEditor.md#handlegridsort)

***

### handleViewFilter()

> `protected` **handleViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:790](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L790)

Filters a view item, notifying the onFiltering subscribers.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item to filter.

#### Returns

`boolean`

True when the item matches.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleViewFilter`](CheckTreeEditor.md#handleviewfilter)

***

### handleViewProcessData()

> `protected` **handleViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L804)

Processes a list response, notifying the onProcessData subscribers.

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The list response.

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The processed response.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleViewProcessData`](CheckTreeEditor.md#handleviewprocessdata)

***

### handleViewSubmit()

> `protected` **handleViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:815](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L815)

Handles view submission, notifying the onSubmitting subscribers.

#### Returns

`boolean`

True when the submit should proceed.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`handleViewSubmit`](CheckTreeEditor.md#handleviewsubmit)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`init`](CheckTreeEditor.md#init)

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L536)

Initializes the filter bar store with the filterable columns.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initializeFilterBar`](CheckTreeEditor.md#initializefilterbar)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:506](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L506)

Performs the initial data population, optionally waiting until visible.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initialPopulate`](CheckTreeEditor.md#initialpopulate)

***

### initSleekGrid()

> `protected` **initSleekGrid**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L185)

Initializes the grid with tree-specific styling.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`initSleekGrid`](CheckTreeEditor.md#initsleekgrid)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1331](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1331)

Performs the actual data refresh by populating the view.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`internalRefresh`](CheckTreeEditor.md#internalrefresh)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`internalRenderContents`](CheckTreeEditor.md#internalrendercontents)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1573](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1573)

Invokes the quick filter submit handlers with the current view params.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`invokeSubmitHandlers`](CheckTreeEditor.md#invokesubmithandlers)

***

### isThreeStateHierarchy()

> `protected` **isThreeStateHierarchy**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L178)

Whether the tree uses a three-state hierarchy.

#### Returns

`boolean`

True when three-state.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`isThreeStateHierarchy`](CheckTreeEditor.md#isthreestatehierarchy)

***

### itemAt()

> **itemAt**(`row`): [`CheckTreeItem`](../interfaces/CheckTreeItem.md)

Defined in: [src/ui/datagrid/datagrid.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L626)

Returns the item at the given row index.

#### Parameters

##### row

`number`

Row index.

#### Returns

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item at that row.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemAt`](CheckTreeEditor.md#itemat)

***

### itemId()

> **itemId**(`item`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L635)

Returns the id of the given item using the grid id property.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item.

#### Returns

`any`

The item id.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemId`](CheckTreeEditor.md#itemid)

***

### itemLink()

> `protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:1101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1101)

Creates a formatter that renders a link to an item.

#### Parameters

##### itemType?

`string`

Item type key; defaults to the grid item type.

##### idField?

`string`

Id field name; defaults to the grid id property.

##### text?

[`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Optional text formatter.

##### cssClass?

(`ctx`) => `string`

Optional CSS class formatter.

##### encode?

`boolean` = `true`

Whether to HTML-encode the link text.

#### Returns

[`Format`](../type-aliases/Format.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

A formatter function.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemLink`](CheckTreeEditor.md#itemlink)

***

### itemSelectedChanged()

> `protected` **itemSelectedChanged**(`item`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L163)

Hook invoked when an item's selection changes.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`itemSelectedChanged`](CheckTreeEditor.md#itemselectedchanged)

***

### layout()

> `protected` **layout**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L241)

Recalculates the grid layout, handling responsive height behavior.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`layout`](CheckTreeEditor.md#layout)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`legacyTemplateRender`](CheckTreeEditor.md#legacytemplaterender)

***

### markupReady()

> `protected` **markupReady**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:922](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L922)

Hook invoked when the grid markup is ready after data changes.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`markupReady`](CheckTreeEditor.md#markupready)

***

### moveSelectedUp()

> `protected` **moveSelectedUp**(): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:763](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L763)

Whether selected items should be moved to the top.

#### Returns

`boolean`

True when moving selected items up.

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`moveSelectedUp`](CheckTreeEditor.md#moveselectedup)

***

### onClick()

> `protected` **onClick**(`e`, `row`, `cell`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L254)

Handles cell clicks, toggling checkboxes and tree expansion.

#### Parameters

##### e

`Event`

Click event.

##### row

`number`

Row index.

##### cell

`number`

Cell index.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onClick`](CheckTreeEditor.md#onclick)

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L757)

Filters view items for the tree hierarchy.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>

The item to filter.

#### Returns

`boolean`

True when the item matches.

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewFilter`](CheckTreeEditor.md#onviewfilter)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

Defined in: [src/ui/editors/checktreeeditor.tsx:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L237)

Processes the list response, setting tree indents.

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The list response.

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>\>

The processed response.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewProcessData`](CheckTreeEditor.md#onviewprocessdata)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:910](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L910)

Hook invoked before the view submits; prepares parameters and checks loadability.

#### Returns

`boolean`

True when the view can load.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`onViewSubmit`](CheckTreeEditor.md#onviewsubmit)

***

### persistenceLock()

> **persistenceLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1720](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1720)

Increments the persistence lock, preventing settings from being persisted.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistenceLock`](CheckTreeEditor.md#persistencelock)

***

### persistenceUnlock()

> **persistenceUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1727)

Decrements the persistence lock.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistenceUnlock`](CheckTreeEditor.md#persistenceunlock)

***

### persistSettings()

> **persistSettings**(`flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1736](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1736)

Persists the current grid settings to storage.

#### Parameters

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Optional persistence flags.

#### Returns

`void` \| `Promise`\<`void`\>

Void or a promise that resolves when the write completes.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`persistSettings`](CheckTreeEditor.md#persistsettings)

***

### populateLock()

> `protected` **populateLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1264)

Locks the view against population.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateLock`](CheckTreeEditor.md#populatelock)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1271)

Unlocks the view population.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateUnlock`](CheckTreeEditor.md#populateunlock)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:974](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L974)

Whether the grid should wait until visible before populating data.

#### Returns

`boolean`

True when population waits for visibility.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`populateWhenVisible`](CheckTreeEditor.md#populatewhenvisible)

***

### postProcessColumns()

> `protected` **postProcessColumns**(`columns`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L466)

Applies defaults and width adjustments to the given columns.

#### Parameters

##### columns

`Column`\<`any`\>[]

Columns to post-process.

#### Returns

`Column`\<`any`\>[]

The processed columns.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`postProcessColumns`](CheckTreeEditor.md#postprocesscolumns)

***

### prepareSubmit()

> **prepareSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1293)

Prepares submit arguments in this.view.params by calling this.view.onSubmit if available, or this.handleViewSubmit if not.
Note that if getGridCanLoad returns false, the prepared arguments might be in an incomplete state.

#### Returns

`boolean`

True when the submit should proceed.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`prepareSubmit`](CheckTreeEditor.md#preparesubmit)

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L178)

Called once property items are available; creates the grid, filter bar,
pager, quick filters, and restores persisted settings.

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Property items and additional items for the grid.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsReady`](CheckTreeEditor.md#propertyitemsready)

***

### propertyItemsToColumns()

> `protected` **propertyItemsToColumns**(`propertyItems`): `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1232)

Converts property items to grid columns, wrapping edit-link columns.

#### Parameters

##### propertyItems

[`PropertyItem`](../interfaces/PropertyItem.md)[]

Property items to convert.

#### Returns

`Column`\<`any`\>[]

The grid columns.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemsToColumns`](CheckTreeEditor.md#propertyitemstocolumns)

***

### quickFilterChange()

> `protected` **quickFilterChange**(`e`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1583](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1583)

Handles quick filter changes by persisting settings and refreshing.

#### Parameters

##### e

`Event`

Change event.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`quickFilterChange`](CheckTreeEditor.md#quickfilterchange)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1305)

Refreshes the grid data, waiting for visibility if configured to do so.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`refresh`](CheckTreeEditor.md#refresh)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1321)

Refreshes the grid if a refresh was requested while hidden.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`refreshIfNeeded`](CheckTreeEditor.md#refreshifneeded)

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L253)

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

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`renderContents`](CheckTreeEditor.md#rendercontents)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1462)

Resizes the underlying grid canvas.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`resizeCanvas`](CheckTreeEditor.md#resizecanvas)

***

### restoreSettings()

> `protected` **restoreSettings**(`settings?`, `flags?`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1655](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1655)

Restores grid settings from the given settings or from storage.

#### Parameters

##### settings?

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

Optional settings to restore; defaults to persisted settings.

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Optional persistence flags.

#### Returns

`void` \| `Promise`\<`void`\>

Void or a promise that resolves when restoration completes.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoreSettings`](CheckTreeEditor.md#restoresettings)

***

### restoreSettingsFrom()

> `protected` **restoreSettingsFrom**(`settings`, `flags?`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1671](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1671)

Restores grid state from a persisted settings snapshot.

#### Parameters

##### settings

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)

The settings to restore.

##### flags?

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Optional persistence flags.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`restoreSettingsFrom`](CheckTreeEditor.md#restoresettingsfrom)

***

### rowCount()

> **rowCount**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L643)

Returns the number of rows in the grid.

#### Returns

`number`

The row count.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`rowCount`](CheckTreeEditor.md#rowcount)

***

### set\_cascadeField()

> `protected` **set\_cascadeField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:829](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L829)

Sets the field name used for cascading.

#### Parameters

##### value

`string`

The cascade field name.

#### Returns

`void`

***

### set\_cascadeFrom()

> `protected` **set\_cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L804)

Sets the cascade source.

#### Parameters

##### value

`string`

Id of the parent editor to cascade from.

#### Returns

`void`

***

### set\_cascadeValue()

> `protected` **set\_cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L851)

Sets the cascade filter value and refreshes items.

#### Parameters

##### value

`any`

The cascade value to set.

#### Returns

`void`

***

### set\_filterField()

> `protected` **set\_filterField**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:877](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L877)

Sets the field name used for filtering.

#### Parameters

##### value

`string`

The filter field name.

#### Returns

`void`

***

### set\_filterValue()

> `protected` **set\_filterValue**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L899)

Sets the filter value and refreshes items.

#### Parameters

##### value

`any`

The filter value to set.

#### Returns

`void`

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:541](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L541)

Sets whether the editor is read-only.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`set_readOnly`](CheckTreeEditor.md#set_readonly)

***

### setAllSubTreeSelected()

> `protected` **setAllSubTreeSelected**(`item`, `selected`): `boolean`

Defined in: [src/ui/editors/checktreeeditor.tsx:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L361)

Sets the selection state of all descendants of an item.

#### Parameters

##### item

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)

The item.

##### selected

`boolean`

The selection state.

#### Returns

`boolean`

True when any item changed.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setAllSubTreeSelected`](CheckTreeEditor.md#setallsubtreeselected)

***

### setCascadeFrom()

> `protected` **setCascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L783)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:864](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L864)

Sets the Criteria view parameter from the active filter store criteria.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setCriteriaParameter`](CheckTreeEditor.md#setcriteriaparameter)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L124)

Sets the edit value from a source object.

#### Parameters

##### source

`any`

The source object.

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setEditValue`](CheckTreeEditor.md#seteditvalue)

***

### setEquality()

> `protected` **setEquality**(`field`, `value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:879](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L879)

Sets an equality filter on the view parameters.

#### Parameters

##### field

`string`

Field name.

##### value

`any`

Equality value.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setEquality`](CheckTreeEditor.md#setequality)

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:886](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L886)

Sets the IncludeColumns view parameter from the grid columns.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setIncludeColumnsParameter`](CheckTreeEditor.md#setincludecolumnsparameter)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L598)

Applies the default sort order to the grid and view.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setInitialSortOrder`](CheckTreeEditor.md#setinitialsortorder)

***

### setItems()

> **setItems**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L659)

Sets the items displayed in the grid.

#### Parameters

##### value

[`CheckTreeItem`](../interfaces/CheckTreeItem.md)\<`TItem`\>[]

The items to display.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setItems`](CheckTreeEditor.md#setitems)

***

### setTitle()

> **setTitle**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1064](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1064)

Sets the grid title text, creating or removing the title element as needed.

#### Parameters

##### value

`string`

The title text, or null to remove the title.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setTitle`](CheckTreeEditor.md#settitle)

***

### setViewParams()

> `protected` **setViewParams**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L899)

Prepares all view parameters and notifies the onSetViewParams subscribers.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`setViewParams`](CheckTreeEditor.md#setviewparams)

***

### sortItems()

> `protected` **sortItems**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L491)

Sorts items, moving selected items to the top.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`sortItems`](CheckTreeEditor.md#sortitems)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1469)

Refreshes the grid when a sub-dialog reports a data change.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`subDialogDataChange`](CheckTreeEditor.md#subdialogdatachange)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L318)

Runs a method synchronously or asynchronously depending on the widget's
`useAsync` flag, then invokes a continuation.

#### Type Parameters

##### T

`T`

#### Parameters

##### syncMethod

() => `T`

The synchronous method to run.

##### asyncMethod

() => `PromiseLike`\<`T`\>

The asynchronous method to run.

##### then

(`v`) => `void`

The continuation invoked with the result.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`syncOrAsyncThen`](CheckTreeEditor.md#syncorasyncthen)

***

### tryFindQuickFilter()

> `protected` **tryFindQuickFilter**\<`TWidget`\>(`type`, `field`): `TWidget`

Defined in: [src/ui/datagrid/datagrid.tsx:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L358)

Tries to find a quick filter widget by field name.

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### type

(...`args`) => `TWidget`

Widget constructor type.

##### field

`string`

Field name of the quick filter.

#### Returns

`TWidget`

The widget instance, or null if not found.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`tryFindQuickFilter`](CheckTreeEditor.md#tryfindquickfilter)

***

### updateFlags()

> `protected` **updateFlags**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L309)

Updates the selection flags for all items.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateFlags`](CheckTreeEditor.md#updateflags)

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1375)

Updates the toolbar interface to reflect the current grid state.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateInterface`](CheckTreeEditor.md#updateinterface)

***

### updateItems()

> `protected` **updateItems**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L672)

Loads the tree items into the view.

#### Returns

`void`

#### Overrides

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateItems`](CheckTreeEditor.md#updateitems)

***

### updateSelectAll()

> `protected` **updateSelectAll**(): `void`

Defined in: [src/ui/editors/checktreeeditor.tsx:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L300)

Updates the select-all button state.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`updateSelectAll`](CheckTreeEditor.md#updateselectall)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L226)

Whether the grid should load property items asynchronously.

#### Returns

`boolean`

True when async loading is used.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useAsync`](CheckTreeEditor.md#useasync)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useIdPrefix`](CheckTreeEditor.md#useidprefix)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L234)

Whether the grid should use the layout timer for responsive resizing.

#### Returns

`boolean`

True when the layout timer is used.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`useLayoutTimer`](CheckTreeEditor.md#uselayouttimer)

***

### usePager()

> `protected` **usePager**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:955](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L955)

Whether the grid should render a pager.

#### Returns

`boolean`

True when paging is enabled.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`usePager`](CheckTreeEditor.md#usepager)

***

### viewDataChanged()

> `protected` **viewDataChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:768](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L768)

Handles view data changes by notifying subscribers and relaying out.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`viewDataChanged`](CheckTreeEditor.md#viewdatachanged)

***

### wrapFormatterWithEditLink()

> `protected` **wrapFormatterWithEditLink**(`column`, `item`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1212)

Wraps a column formatter with an edit link formatter.

#### Parameters

##### column

`Column`

Column to wrap.

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

Property item describing the edit link.

#### Returns

`void`

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`wrapFormatterWithEditLink`](CheckTreeEditor.md#wrapformatterwitheditlink)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

Creates a widget instance from the given params, appending its element to
the container and invoking the init/init callbacks.

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

The widget creation params.

#### Returns

`TWidget`

The created widget instance.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`create`](CheckTreeEditor.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

Defined in: [src/ui/editors/checktreeeditor.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/checktreeeditor.tsx#L52)

Creates the default div element for the check tree editor.

#### Returns

`HTMLDivElement`

The div element.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`createDefaultElement`](CheckTreeEditor.md#createdefaultelement)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L131)

Returns the widget name for a type, used for association and unique names.

#### Parameters

##### type

`Function`

The widget type.

#### Returns

`string`

The widget name.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`getWidgetName`](CheckTreeEditor.md#getwidgetname)

***

### propertyItemToQuickFilter()

> `static` **propertyItemToQuickFilter**(`item`): [`QuickFilter`](../interfaces/QuickFilter.md)\<`any`, `any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L334)

Converts a property item to a quick filter definition.

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

Property item to convert.

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<`any`, `any`\>

The quick filter definition, or null if not applicable.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`propertyItemToQuickFilter`](CheckTreeEditor.md#propertyitemtoquickfilter)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L342)

Registers this type as a class with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

The class type info.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`registerClass`](CheckTreeEditor.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L357)

Registers this type as an editor with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

The editor type info.

#### Inherited from

[`CheckTreeEditor`](CheckTreeEditor.md).[`registerEditor`](CheckTreeEditor.md#registereditor)
