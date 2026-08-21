[@serenity-is/corelib](../README.md) / EntityGrid

# Class: EntityGrid\<TItem, P\>

Defined in: [src/ui/datagrid/entitygrid.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L25)

Base grid for entity-bound data; integrates routing, permissions, dialogs,
toolbar buttons, filtering and service integration on top of [DataGrid](DataGrid.md).
Registered via modern `static override [Symbol.typeInfo] = this.registerClass(...)`.

## Extends

- [`DataGrid`](DataGrid.md)\<`TItem`, `P`\>

## Type Parameters

### TItem

`TItem`

Entity row type.

### P

`P` = \{ \}

Widget props type.

## Constructors

### Constructor

> **new EntityGrid**\<`TItem`, `P`\>(`props`): `EntityGrid`\<`TItem`, `P`\>

Defined in: [src/ui/datagrid/entitygrid.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L32)

Creates an entity grid and wires the route handler.

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Widget props forwarded to [DataGrid](DataGrid.md).

#### Returns

`EntityGrid`\<`TItem`, `P`\>

#### Overrides

[`DataGrid`](DataGrid.md).[`constructor`](DataGrid.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`DataGrid`](DataGrid.md).[`domNode`](DataGrid.md#domnode)

***

### filterBar

> `protected` **filterBar**: [`FilterDisplayBar`](FilterDisplayBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L57)

The advanced filter bar widget.

#### Inherited from

[`DataGrid`](DataGrid.md).[`filterBar`](DataGrid.md#filterbar)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`DataGrid`](DataGrid.md).[`idPrefix`](DataGrid.md#idprefix)

***

### onAfterInit

> `readonly` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L113)

Raised after this grid is initialized.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onAfterInit`](DataGrid.md#onafterinit)

***

### onCanSubmit

> `readonly` **onCanSubmit**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L115)

Raised to determine whether the grid can submit its view.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onCanSubmit`](DataGrid.md#oncansubmit)

***

### onDataChanged

> `readonly` **onDataChanged**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L117)

Raised when the grid data changes.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onDataChanged`](DataGrid.md#ondatachanged)

***

### onFiltering

> `readonly` **onFiltering**: `PubSub`\<[`DataGridFilteringEvent`](../interfaces/DataGridFilteringEvent.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L119)

Raised while filtering items in the view.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onFiltering`](DataGrid.md#onfiltering)

***

### onPersistence

> `readonly` **onPersistence**: `PubSub`\<[`DataGridPersistenceEvent`](../interfaces/DataGridPersistenceEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L121)

Raised before/after persisting or restoring grid settings.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onPersistence`](DataGrid.md#onpersistence)

***

### onProcessData

> `readonly` **onProcessData**: `PubSub`\<[`DataGridProcessEvent`](../interfaces/DataGridProcessEvent.md)\<`TItem`\>\>

Defined in: [src/ui/datagrid/datagrid.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L123)

Raised when the view processes a list response.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onProcessData`](DataGrid.md#onprocessdata)

***

### onSetViewParams

> `readonly` **onSetViewParams**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L127)

Raised after view parameters are prepared for submission.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onSetViewParams`](DataGrid.md#onsetviewparams)

***

### onSubmitting

> `readonly` **onSubmitting**: `PubSub`\<[`DataGridSubmitEvent`](../interfaces/DataGridSubmitEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L125)

Raised to determine whether the view submit should proceed.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onSubmitting`](DataGrid.md#onsubmitting)

***

### openDialogsAsPanel

> **openDialogsAsPanel**: `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L72)

Whether dialogs opened from this grid should be shown as panels.

#### Inherited from

[`DataGrid`](DataGrid.md).[`openDialogsAsPanel`](DataGrid.md#opendialogsaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`DataGrid`](DataGrid.md).[`options`](DataGrid.md#options)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L65)

The property items data for this grid.

#### Inherited from

[`DataGrid`](DataGrid.md).[`propertyItemsData`](DataGrid.md#propertyitemsdata)

***

### quickFiltersBar

> `protected` **quickFiltersBar**: [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L61)

The quick filter bar widget.

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFiltersBar`](DataGrid.md#quickfiltersbar)

***

### quickFiltersDiv

> `protected` **quickFiltersDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L59)

The quick filters container element.

#### Inherited from

[`DataGrid`](DataGrid.md).[`quickFiltersDiv`](DataGrid.md#quickfiltersdiv)

***

### restoringSettings

> `protected` **restoringSettings**: `number`

Defined in: [src/ui/datagrid/datagrid.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L67)

Counter tracking nested settings restoration.

#### Inherited from

[`DataGrid`](DataGrid.md).[`restoringSettings`](DataGrid.md#restoringsettings)

***

### slickContainer

> `protected` **slickContainer**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L63)

The container element that hosts the grid.

#### Inherited from

[`DataGrid`](DataGrid.md).[`slickContainer`](DataGrid.md#slickcontainer)

***

### titleDiv

> `protected` **titleDiv**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L53)

The title element.

#### Inherited from

[`DataGrid`](DataGrid.md).[`titleDiv`](DataGrid.md#titlediv)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L55)

The toolbar widget.

#### Inherited from

[`DataGrid`](DataGrid.md).[`toolbar`](DataGrid.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`DataGrid`](DataGrid.md).[`uniqueName`](DataGrid.md#uniquename)

***

### view

> **view**: [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L69)

The remote view used for paging and server communication.

#### Inherited from

[`DataGrid`](DataGrid.md).[`view`](DataGrid.md#view)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/datagrid/entitygrid.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L26)

#### Overrides

[`DataGrid`](DataGrid.md).[`[typeInfo]`](DataGrid.md#typeinfo)

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

[`DataGrid`](DataGrid.md).[`defaultOptions`](DataGrid.md#defaultoptions)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`DataGrid`](DataGrid.md).[`isComponent`](DataGrid.md#iscomponent)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: `PubSub`\<[`DataGridEvent`](../interfaces/DataGridEvent.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L111)

Static event raised after any grid is initialized.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onAfterInit`](DataGrid.md#onafterinit-1)

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

[`DataGrid`](DataGrid.md).[`allColumns`](DataGrid.md#allcolumns)

***

### columns

#### Get Signature

> **get** **columns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1839)

The currently visible columns.

##### Returns

`Column`\<`TItem`\>[]

#### Inherited from

[`DataGrid`](DataGrid.md).[`columns`](DataGrid.md#columns)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`DataGrid`](DataGrid.md).[`element`](DataGrid.md#element)

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

[`DataGrid`](DataGrid.md).[`initialSettings`](DataGrid.md#initialsettings)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`DataGrid`](DataGrid.md).[`props`](DataGrid.md#props)

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

[`DataGrid`](DataGrid.md).[`readOnly`](DataGrid.md#readonly)

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

[`DataGrid`](DataGrid.md).[`sleekGrid`](DataGrid.md#sleekgrid)

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

[`DataGrid`](DataGrid.md).[`slickGrid`](DataGrid.md#slickgrid)

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

[`DataGrid`](DataGrid.md).[`defaultColumnWidthDelta`](DataGrid.md#defaultcolumnwidthdelta)

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

[`DataGrid`](DataGrid.md).[`defaultColumnWidthScale`](DataGrid.md#defaultcolumnwidthscale)

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

[`DataGrid`](DataGrid.md).[`defaultPersistanceStorage`](DataGrid.md#defaultpersistancestorage)

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

[`DataGrid`](DataGrid.md).[`defaultPersistenceStorage`](DataGrid.md#defaultpersistencestorage)

***

### defaultRowHeight

#### Get Signature

> **get** `static` **defaultRowHeight**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L78)

Default row height used when creating grids.

##### Returns

`number`

#### Inherited from

[`DataGrid`](DataGrid.md).[`defaultRowHeight`](DataGrid.md#defaultrowheight)

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

[`DataGrid`](DataGrid.md).[`addBooleanFilter`](DataGrid.md#addbooleanfilter)

***

### addButtonClick()

> `protected` **addButtonClick**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L284)

Handles the add button click by opening a new-item dialog.

#### Returns

`void`

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addCssClass`](DataGrid.md#addcssclass)

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

[`DataGrid`](DataGrid.md).[`addDateRangeFilter`](DataGrid.md#adddaterangefilter)

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

[`DataGrid`](DataGrid.md).[`addDateTimeRangeFilter`](DataGrid.md#adddatetimerangefilter)

***

### addFilterSeparator()

> `protected` **addFilterSeparator**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1476)

Adds a separator to the quick filter bar.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`addFilterSeparator`](DataGrid.md#addfilterseparator)

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

[`DataGrid`](DataGrid.md).[`addQuickFilter`](DataGrid.md#addquickfilter)

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

[`DataGrid`](DataGrid.md).[`addValidationRule`](DataGrid.md#addvalidationrule)

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

[`DataGrid`](DataGrid.md).[`addValidationRule`](DataGrid.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L219)

Hook invoked after the grid is initialized and settings are restored.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`afterInit`](DataGrid.md#afterinit)

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

[`DataGrid`](DataGrid.md).[`afterRender`](DataGrid.md#afterrender)

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

[`DataGrid`](DataGrid.md).[`autoRegisteringPlugin`](DataGrid.md#autoregisteringplugin)

***

### bindToSlickEvents()

> `protected` **bindToSlickEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L697)

Subscribes to the underlying grid events.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToSlickEvents`](DataGrid.md#bindtoslickevents)

***

### bindToViewEvents()

> `protected` **bindToViewEvents**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L777)

Subscribes to view events for filtering, submitting, and processing data.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`bindToViewEvents`](DataGrid.md#bindtoviewevents)

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

[`DataGrid`](DataGrid.md).[`booleanQuickFilter`](DataGrid.md#booleanquickfilter)

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

[`DataGrid`](DataGrid.md).[`byId`](DataGrid.md#byid)

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

[`DataGrid`](DataGrid.md).[`canFilterColumn`](DataGrid.md#canfiltercolumn)

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

[`DataGrid`](DataGrid.md).[`change`](DataGrid.md#change)

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

[`DataGrid`](DataGrid.md).[`changeSelect2`](DataGrid.md#changeselect2)

***

### createColumns()

> `protected` **createColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L562)

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

Defined in: [src/ui/datagrid/entitygrid.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L502)

Creates a dialog widget for the specified item type, initializing and routing it.

#### Parameters

##### itemType

`string`

Entity type key whose dialog type will be resolved.

##### callback?

(`dlg`) => `void`

Optional callback invoked with the created dialog.

#### Returns

[`Widget`](Widget.md)\<`any`\> \| `PromiseLike`\<[`Widget`](Widget.md)\<`any`\>\>

The dialog instance or a promise that resolves to it.

***

### createFilterBar()

> `protected` **createFilterBar**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L250)

Creates the filter bar and syncs its visibility.

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`createFilterBar`](DataGrid.md#createfilterbar)

***

### createIncludeDeletedButton()

> `protected` **createIncludeDeletedButton**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L369)

Creates the include-deleted toggle button when the row type supports it.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createIncludeDeletedButton`](DataGrid.md#createincludedeletedbutton)

***

### createPager()

> `protected` **createPager**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1006](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1006)

Creates the pager widget for this grid.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createPager`](DataGrid.md#createpager)

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

[`DataGrid`](DataGrid.md).[`createQuickFilters`](DataGrid.md#createquickfilters)

***

### createQuickSearchInput()

> `protected` **createQuickSearchInput**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L385)

Creates the quick search input in the toolbar.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`createQuickSearchInput`](DataGrid.md#createquicksearchinput)

***

### createSleekColumns()

> `protected` **createSleekColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:571](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L571)

Creates the SleekGrid columns. This method calls createColumns (via getColumns for compatibility) and then post processes them.

#### Returns

`Column`\<`TItem`\>[]

The SleekGrid columns.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSleekColumns`](DataGrid.md#createsleekcolumns)

***

### createSlickContainer()

> `protected` **createSlickContainer**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/datagrid/datagrid.tsx:930](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L930)

Creates the container element that hosts the grid.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

The grid container element.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickContainer`](DataGrid.md#createslickcontainer)

***

### createSlickGrid()

> `protected` **createSlickGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L580)

Creates the underlying SleekGrid instance with the processed columns.

#### Returns

`ISleekGrid`\<`TItem`\>

The created grid instance.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createSlickGrid`](DataGrid.md#createslickgrid)

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

[`DataGrid`](DataGrid.md).[`createToolbar`](DataGrid.md#createtoolbar)

***

### createToolbarExtensions()

> `protected` **createToolbarExtensions**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L109)

Creates standard toolbar extensions such as the include-deleted toggle and quick search.

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`createToolbarExtensions`](DataGrid.md#createtoolbarextensions)

***

### createView()

> `protected` **createView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:938](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L938)

Creates the remote view used for paging and server communication.

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

The remote view instance.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createView`](DataGrid.md#createview)

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

[`DataGrid`](DataGrid.md).[`dateRangeQuickFilter`](DataGrid.md#daterangequickfilter)

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

[`DataGrid`](DataGrid.md).[`dateTimeRangeQuickFilter`](DataGrid.md#datetimerangequickfilter)

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

[`DataGrid`](DataGrid.md).[`deferRender`](DataGrid.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L41)

Cleans up the route-fixup handler and delegates to the base destroy.

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`destroy`](DataGrid.md#destroy)

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

[`DataGrid`](DataGrid.md).[`determineText`](DataGrid.md#determinetext)

***

### editItem()

> `protected` **editItem**(`entityOrId`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L292)

Opens an edit dialog for an existing entity or a new instance.

#### Parameters

##### entityOrId

`any`

Entity instance or identifier to edit.

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`editItem`](DataGrid.md#edititem)

***

### editItemOfType()

> `protected` **editItemOfType**(`itemType`, `entityOrId`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L314)

Opens an edit dialog for a specific item type, used for polymorphic entities.

#### Parameters

##### itemType

`string`

Entity type key.

##### entityOrId

`any`

Entity instance or identifier to edit.

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`editItemOfType`](DataGrid.md#edititemoftype)

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

[`DataGrid`](DataGrid.md).[`EditLink`](DataGrid.md#editlink)

***

### enableAdvancedFiltering()

> `protected` **enableAdvancedFiltering**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:963](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L963)

Whether advanced filtering is enabled for this grid.

#### Returns

`boolean`

True when advanced filtering is enabled.

#### Inherited from

[`DataGrid`](DataGrid.md).[`enableAdvancedFiltering`](DataGrid.md#enableadvancedfiltering)

***

### ensureQuickFilterBar()

> `protected` **ensureQuickFilterBar**(): [`QuickFilterBar`](QuickFilterBar.md)

Defined in: [src/ui/datagrid/datagrid.tsx:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L281)

Ensures the quick filter bar exists and returns it.

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)

The quick filter bar instance.

#### Inherited from

[`DataGrid`](DataGrid.md).[`ensureQuickFilterBar`](DataGrid.md#ensurequickfilterbar)

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L258)

Invoked when the filter store changes; refreshes the filter bar visibility.

#### Returns

`void`

#### Overrides

[`DataGrid`](DataGrid.md).[`filterStoreChanged`](DataGrid.md#filterstorechanged)

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

[`DataGrid`](DataGrid.md).[`findById`](DataGrid.md#findbyid)

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

[`DataGrid`](DataGrid.md).[`findQuickFilter`](DataGrid.md#findquickfilter)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1357)

Returns whether the grid is in read-only mode.

#### Returns

`boolean`

True when read-only.

#### Inherited from

[`DataGrid`](DataGrid.md).[`get_readOnly`](DataGrid.md#get_readonly)

***

### getAddButtonCaption()

> `protected` **getAddButtonCaption**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L195)

Returns the caption for the add/new button.

#### Returns

`string`

Localized add button text.

#### Overrides

[`DataGrid`](DataGrid.md).[`getAddButtonCaption`](DataGrid.md#getaddbuttoncaption)

***

### getButtons()

> `protected` **getButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/datagrid/entitygrid.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L203)

Builds the grid toolbar buttons including add, refresh, column picker and filter bar.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

Array of tool button definitions.

#### Overrides

[`DataGrid`](DataGrid.md).[`getButtons`](DataGrid.md#getbuttons)

***

### ~~getColumns()~~

> `protected` **getColumns**(): `Column`\<`TItem`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:1203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1203)

#### Returns

`Column`\<`TItem`\>[]

#### Deprecated

override createColumns

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumns`](DataGrid.md#getcolumns)

***

### getColumnsKey()

> `protected` **getColumnsKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1153)

Returns the columns key used to load property items.

#### Returns

`string`

The columns key, or null for none.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnsKey`](DataGrid.md#getcolumnskey)

***

### getColumnWidthDelta()

> `protected` **getColumnWidthDelta**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L491)

Returns the width delta applied to all columns.

#### Returns

`number`

The column width delta.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthDelta`](DataGrid.md#getcolumnwidthdelta)

***

### getColumnWidthScale()

> `protected` **getColumnWidthScale**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L499)

Returns the width scale applied to all columns.

#### Returns

`number`

The column width scale.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getColumnWidthScale`](DataGrid.md#getcolumnwidthscale)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getCssClass`](DataGrid.md#getcssclass)

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

[`DataGrid`](DataGrid.md).[`getCurrentSettings`](DataGrid.md#getcurrentsettings)

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

[`DataGrid`](DataGrid.md).[`getCustomAttribute`](DataGrid.md#getcustomattribute)

***

### getDefaultSortBy()

> `protected` **getDefaultSortBy**(): `any`[]

Defined in: [src/ui/datagrid/datagrid.tsx:947](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L947)

Returns the default sort order for the grid.

#### Returns

`any`[]

Array of sort descriptors.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getDefaultSortBy`](DataGrid.md#getdefaultsortby)

***

### getDeletePermission()

> `protected` **getDeletePermission**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:424](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L424)

Returns the permission key required to delete a row.

#### Returns

`string`

Delete permission or undefined.

***

### getDialogOptions()

> `protected` **getDialogOptions**(): `any`

Defined in: [src/ui/datagrid/entitygrid.ts:527](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L527)

Returns default options for the primary entity dialog.

#### Returns

`any`

Dialog options.

***

### getDialogOptionsFor()

> `protected` **getDialogOptionsFor**(`itemType`): `any`

Defined in: [src/ui/datagrid/entitygrid.ts:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L536)

Returns dialog options for a specific item type.

#### Parameters

##### itemType

`string`

Entity type key.

#### Returns

`any`

Dialog options for that type.

***

### getDialogType()

> `protected` **getDialogType**(): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/datagrid/entitygrid.ts:563](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L563)

Resolves the dialog type for the primary entity; cached and may be loaded lazily.

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Dialog constructor or a promise that resolves to it.

***

### getDialogTypeFor()

> `protected` **getDialogTypeFor**(`itemType`): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/datagrid/entitygrid.ts:548](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L548)

Resolves the dialog type for the given item type.

#### Parameters

##### itemType

`string`

Entity type key.

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Dialog constructor or a promise that resolves to it.

***

### getDisplayName()

> `protected` **getDisplayName**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L171)

Returns the localized plural display name for the entity.

#### Returns

`string`

Display name for the grid title.

***

### getElement()

> **getElement**(): `HTMLElement`

Defined in: [src/ui/datagrid/datagrid.tsx:1788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1788)

Returns the root DOM element of the grid widget.

#### Returns

`HTMLElement`

The grid container element.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getElement`](DataGrid.md#getelement)

***

### getEntityType()

> `protected` **getEntityType**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L142)

Returns the entity type name derived from the grid class name.

#### Returns

`string`

Entity type (e.g. "Administration.User").

***

### getFilterStore()

> **getFilterStore**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1829](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1829)

Returns the filter store owned by the grid.

#### Returns

[`FilterStore`](FilterStore.md)

The filter store, or null if no filter bar exists.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getFilterStore`](DataGrid.md#getfilterstore)

***

### getGrid()

> **getGrid**(): `ISleekGrid`\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1796](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1796)

Returns the underlying SleekGrid instance.

#### Returns

`ISleekGrid`\<`TItem`\>

The grid instance.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGrid`](DataGrid.md#getgrid)

***

### getGridCanLoad()

> `protected` **getGridCanLoad**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:1279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1279)

Determines whether the grid can load data, notifying onCanSubmit subscribers.

#### Returns

`boolean`

True when the grid can load.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGridCanLoad`](DataGrid.md#getgridcanload)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getGridField`](DataGrid.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1423)

Returns the id property name for this grid.

#### Returns

`string`

The id property name.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIdProperty`](DataGrid.md#getidproperty)

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

[`DataGrid`](DataGrid.md).[`getIncludeColumns`](DataGrid.md#getincludecolumns)

***

### getInitialTitle()

> `protected` **getInitialTitle**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L118)

Returns the initial title for the grid panel.

#### Returns

`string`

Localized plural display name.

#### Overrides

[`DataGrid`](DataGrid.md).[`getInitialTitle`](DataGrid.md#getinitialtitle)

***

### getInsertPermission()

> `protected` **getInsertPermission**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L408)

Returns the permission key required to insert a row.

#### Returns

`string`

Insert permission or undefined if none is configured.

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1448)

Returns the is-active property name for this grid.

#### Returns

`string`

The is-active property name.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsActiveProperty`](DataGrid.md#getisactiveproperty)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1438)

Returns the is-deleted property name for this grid.

#### Returns

`string`

The is-deleted property name, or undefined.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getIsDeletedProperty`](DataGrid.md#getisdeletedproperty)

***

### getItemCssClass()

> `protected` **getItemCssClass**(`item`, `index`): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L443)

Returns the CSS class for a grid row based on its active/deleted state.

#### Parameters

##### item

`TItem`

The row item.

##### index

`number`

The row index.

#### Returns

`string`

The CSS class name, or an empty string.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemCssClass`](DataGrid.md#getitemcssclass)

***

### getItemMetadata()

> `protected` **getItemMetadata**(`item`, `index`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L453)

Returns row metadata (e.g. CSS classes) for the given item.

#### Parameters

##### item

`TItem`

The row item.

##### index

`number`

The row index.

#### Returns

`any`

Row metadata object.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItemMetadata`](DataGrid.md#getitemmetadata)

***

### getItemName()

> `protected` **getItemName**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L184)

Returns the localized singular name for a single entity item.

#### Returns

`string`

Singular display name.

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/ui/datagrid/datagrid.tsx:651](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L651)

Returns the items currently displayed in the grid.

#### Returns

`TItem`[]

The grid items.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getItems`](DataGrid.md#getitems)

***

### getItemType()

> `protected` **getItemType**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L379)

Returns the entity item type key used to resolve dialogs and row definitions.

#### Returns

`string`

Item type key.

#### Overrides

[`DataGrid`](DataGrid.md).[`getItemType`](DataGrid.md#getitemtype)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1393)

Returns the local text database prefix for this grid.

#### Returns

`string`

The local text db prefix.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getLocalTextDbPrefix`](DataGrid.md#getlocaltextdbprefix)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L126)

Resolves the local text prefix for this grid; falls back to the entity type.

#### Returns

`string`

Local text prefix key.

#### Overrides

[`DataGrid`](DataGrid.md).[`getLocalTextPrefix`](DataGrid.md#getlocaltextprefix)

***

### getPagerOptions()

> `protected` **getPagerOptions**(): [`PagerOptions`](../interfaces/PagerOptions.md)

Defined in: [src/ui/datagrid/datagrid.tsx:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L995)

Returns the pager options for this grid.

#### Returns

[`PagerOptions`](../interfaces/PagerOptions.md)

Pager options.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPagerOptions`](DataGrid.md#getpageroptions)

***

### getPersistedSettings()

> `protected` **getPersistedSettings**(): [`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1630)

Retrieves the persisted grid settings from storage.

#### Returns

[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md) \| `Promise`\<[`PersistedGridSettings`](../interfaces/PersistedGridSettings.md)\>

The persisted settings, or a promise resolving to them.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistedSettings`](DataGrid.md#getpersistedsettings)

***

### getPersistenceKey()

> `protected` **getPersistenceKey**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1603](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1603)

Returns the key used to store grid settings.

#### Returns

`string`

The persistence key.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistenceKey`](DataGrid.md#getpersistencekey)

***

### getPersistenceStorage()

> `protected` **getPersistenceStorage**(): [`SettingStorage`](../interfaces/SettingStorage.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1593)

Returns the storage used for grid persistence.

#### Returns

[`SettingStorage`](../interfaces/SettingStorage.md)

The persistence storage.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPersistenceStorage`](DataGrid.md#getpersistencestorage)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1161)

Returns the property items for this grid.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The property items.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItems`](DataGrid.md#getpropertyitems)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1169)

Loads the property items data, either from script data or local items.

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

The property items data.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsData`](DataGrid.md#getpropertyitemsdata)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/datagrid/datagrid.tsx:1193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1193)

Asynchronously loads the property items data.

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to the property items data.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getPropertyItemsDataAsync`](DataGrid.md#getpropertyitemsdataasync)

***

### getQuickFilters()

> `protected` **getQuickFilters**(): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/datagrid.tsx:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L319)

Returns the quick filter definitions derived from the grid columns.

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>[]

Quick filter definitions for columns marked as quick filters.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickFilters`](DataGrid.md#getquickfilters)

***

### getQuickSearchFields()

> `protected` **getQuickSearchFields**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)[]

Defined in: [src/ui/datagrid/datagrid.tsx:378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L378)

Returns the quick search fields available for this grid.

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)[]

The quick search fields, or null for none.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getQuickSearchFields`](DataGrid.md#getquicksearchfields)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1383)

Returns the row definition for this grid.

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

The row definition, or null for none.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getRowDefinition`](DataGrid.md#getrowdefinition)

***

### getService()

> `protected` **getService**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L342)

Returns the service endpoint path for the entity (e.g. "Administration/User").

#### Returns

`string`

Service path derived from the entity type.

***

### getServiceMethod()

> `protected` **getServiceMethod**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L353)

Returns the service method name for listing entities.

#### Returns

`string`

Service method (defaults to "<service>/List").

***

### getServiceUrl()

> `protected` **getServiceUrl**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L361)

Returns the absolute URL for the list service endpoint.

#### Returns

`string`

Resolved service URL.

***

### getSlickOptions()

> `protected` **getSlickOptions**(): `GridOptions`

Defined in: [src/ui/datagrid/datagrid.tsx:1247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1247)

Returns the SleekGrid options for this grid.

#### Returns

`GridOptions`

Grid options.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getSlickOptions`](DataGrid.md#getslickoptions)

***

### getTitle()

> **getTitle**(): `string`

Defined in: [src/ui/datagrid/datagrid.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1052)

Returns the current grid title text.

#### Returns

`string`

The title text, or null if no title is set.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getTitle`](DataGrid.md#gettitle)

***

### getUpdatePermission()

> `protected` **getUpdatePermission**(): `string`

Defined in: [src/ui/datagrid/entitygrid.ts:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L416)

Returns the permission key required to update a row.

#### Returns

`string`

Update permission or undefined.

***

### getView()

> **getView**(): [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1821](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1821)

Returns the remote view used for paging and server communication.

#### Returns

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

The remote view instance.

#### Inherited from

[`DataGrid`](DataGrid.md).[`getView`](DataGrid.md#getview)

***

### getViewOptions()

> `protected` **getViewOptions**(): [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

Defined in: [src/ui/datagrid/entitygrid.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L369)

Returns view options including the service URL.

#### Returns

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

Remote view options with URL populated.

#### Overrides

[`DataGrid`](DataGrid.md).[`getViewOptions`](DataGrid.md#getviewoptions)

***

### gridPersistenceFlags()

> `protected` **gridPersistenceFlags**(): [`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid.tsx:1620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1620)

Returns the default persistence flags for this grid.

#### Returns

[`GridPersistenceFlags`](../interfaces/GridPersistenceFlags.md)

Grid persistence flags.

#### Inherited from

[`DataGrid`](DataGrid.md).[`gridPersistenceFlags`](DataGrid.md#gridpersistenceflags)

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

[`DataGrid`](DataGrid.md).[`handleGridClick`](DataGrid.md#handlegridclick)

***

### handleGridColumnsReordered()

> `protected` **handleGridColumnsReordered**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L683)

Persists settings when columns are reordered.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridColumnsReordered`](DataGrid.md#handlegridcolumnsreordered)

***

### handleGridColumnsResized()

> `protected` **handleGridColumnsResized**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:690](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L690)

Persists settings when columns are resized.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleGridColumnsResized`](DataGrid.md#handlegridcolumnsresized)

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

[`DataGrid`](DataGrid.md).[`handleGridSort`](DataGrid.md#handlegridsort)

***

### handleRoute()

> `protected` **handleRoute**(`e`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L50)

Handles hash-based routing for new/edit dialog invocations.

#### Parameters

##### e

[`HandleRouteEvent`](../interfaces/HandleRouteEvent.md)

Route event containing the hash fragment and navigation metadata.

#### Returns

`void`

***

### handleViewFilter()

> `protected` **handleViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:790](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L790)

Filters a view item, notifying the onFiltering subscribers.

#### Parameters

##### item

`TItem`

The item to filter.

#### Returns

`boolean`

True when the item matches.

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewFilter`](DataGrid.md#handleviewfilter)

***

### handleViewProcessData()

> `protected` **handleViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L804)

Processes a list response, notifying the onProcessData subscribers.

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The list response.

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The processed response.

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewProcessData`](DataGrid.md#handleviewprocessdata)

***

### handleViewSubmit()

> `protected` **handleViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:815](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L815)

Handles view submission, notifying the onSubmitting subscribers.

#### Returns

`boolean`

True when the submit should proceed.

#### Inherited from

[`DataGrid`](DataGrid.md).[`handleViewSubmit`](DataGrid.md#handleviewsubmit)

***

### hasDeletePermission()

> `protected` **hasDeletePermission**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L432)

Checks whether the current user may delete rows.

#### Returns

`boolean`

True when deletion is allowed.

***

### hasInsertPermission()

> `protected` **hasInsertPermission**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L441)

Checks whether the current user may insert rows.

#### Returns

`boolean`

True when insertion is allowed.

***

### hasUpdatePermission()

> `protected` **hasUpdatePermission**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L450)

Checks whether the current user may update rows.

#### Returns

`boolean`

True when updates are allowed.

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`DataGrid`](DataGrid.md).[`init`](DataGrid.md#init)

***

### initDialog()

> `protected` **initDialog**(`dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:468](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L468)

Initializes a dialog bound to the primary item type.

#### Parameters

##### dialog

[`Widget`](Widget.md)\<`any`\>

Dialog instance to initialize.

#### Returns

`void`

***

### initEntityDialog()

> `protected` **initEntityDialog**(`itemType`, `dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L482)

Initializes a dialog for the given item type, wiring data-change and routing.

#### Parameters

##### itemType

`string`

Entity type key.

##### dialog

[`Widget`](Widget.md)\<`any`\>

Dialog instance to initialize.

#### Returns

`void`

***

### initializeFilterBar()

> `protected` **initializeFilterBar**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L536)

Initializes the filter bar store with the filterable columns.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initializeFilterBar`](DataGrid.md#initializefilterbar)

***

### initialPopulate()

> `protected` **initialPopulate**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:506](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L506)

Performs the initial data population, optionally waiting until visible.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initialPopulate`](DataGrid.md#initialpopulate)

***

### initSleekGrid()

> `protected` **initSleekGrid**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L592)

Hook for subclasses to initialize the grid after creation.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`initSleekGrid`](DataGrid.md#initsleekgrid)

***

### internalRefresh()

> `protected` **internalRefresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1331](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1331)

Performs the actual data refresh by populating the view.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`internalRefresh`](DataGrid.md#internalrefresh)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`internalRenderContents`](DataGrid.md#internalrendercontents)

***

### invokeSubmitHandlers()

> `protected` **invokeSubmitHandlers**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1573](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1573)

Invokes the quick filter submit handlers with the current view params.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`invokeSubmitHandlers`](DataGrid.md#invokesubmithandlers)

***

### itemAt()

> **itemAt**(`row`): `TItem`

Defined in: [src/ui/datagrid/datagrid.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L626)

Returns the item at the given row index.

#### Parameters

##### row

`number`

Row index.

#### Returns

`TItem`

The item at that row.

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemAt`](DataGrid.md#itemat)

***

### itemId()

> **itemId**(`item`): `any`

Defined in: [src/ui/datagrid/datagrid.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L635)

Returns the id of the given item using the grid id property.

#### Parameters

##### item

`TItem`

The item.

#### Returns

`any`

The item id.

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemId`](DataGrid.md#itemid)

***

### itemLink()

> `protected` **itemLink**(`itemType?`, `idField?`, `text?`, `cssClass?`, `encode?`): [`Format`](../type-aliases/Format.md)\<`TItem`\>

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

[`Format`](../type-aliases/Format.md)\<`TItem`\>

Optional text formatter.

##### cssClass?

(`ctx`) => `string`

Optional CSS class formatter.

##### encode?

`boolean` = `true`

Whether to HTML-encode the link text.

#### Returns

[`Format`](../type-aliases/Format.md)\<`TItem`\>

A formatter function.

#### Inherited from

[`DataGrid`](DataGrid.md).[`itemLink`](DataGrid.md#itemlink)

***

### layout()

> `protected` **layout**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L241)

Recalculates the grid layout, handling responsive height behavior.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`layout`](DataGrid.md#layout)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`DataGrid`](DataGrid.md).[`legacyTemplateRender`](DataGrid.md#legacytemplaterender)

***

### markupReady()

> `protected` **markupReady**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:922](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L922)

Hook invoked when the grid markup is ready after data changes.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`markupReady`](DataGrid.md#markupready)

***

### newRefreshButton()

> `protected` **newRefreshButton**(`noText?`): [`ToolButton`](../interfaces/ToolButton.md)

Defined in: [src/ui/datagrid/entitygrid.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L268)

Creates a refresh toolbar button.

#### Parameters

##### noText?

`boolean`

When true, only an icon with a hint is shown.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

Tool button definition for refreshing the grid.

***

### onClick()

> `protected` **onClick**(`e`, `row`, `cell`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:749](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L749)

Handles cell clicks, opening edit links when clicked.

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

[`DataGrid`](DataGrid.md).[`onClick`](DataGrid.md#onclick)

***

### onViewFilter()

> `protected` **onViewFilter**(`item`): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:838](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L838)

Hook for subclasses to filter view items.

#### Parameters

##### item

`TItem`

The item to filter.

#### Returns

`boolean`

True when the item should be included.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewFilter`](DataGrid.md#onviewfilter)

***

### onViewProcessData()

> `protected` **onViewProcessData**(`response`): [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/ui/datagrid/datagrid.tsx:829](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L829)

Hook for subclasses to process a list response before it is applied.

#### Parameters

##### response

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The list response.

#### Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The processed response.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewProcessData`](DataGrid.md#onviewprocessdata)

***

### onViewSubmit()

> `protected` **onViewSubmit**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:910](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L910)

Hook invoked before the view submits; prepares parameters and checks loadability.

#### Returns

`boolean`

True when the view can load.

#### Inherited from

[`DataGrid`](DataGrid.md).[`onViewSubmit`](DataGrid.md#onviewsubmit)

***

### persistenceLock()

> **persistenceLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1720](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1720)

Increments the persistence lock, preventing settings from being persisted.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistenceLock`](DataGrid.md#persistencelock)

***

### persistenceUnlock()

> **persistenceUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1727)

Decrements the persistence lock.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`persistenceUnlock`](DataGrid.md#persistenceunlock)

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

[`DataGrid`](DataGrid.md).[`persistSettings`](DataGrid.md#persistsettings)

***

### populateLock()

> `protected` **populateLock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1264)

Locks the view against population.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateLock`](DataGrid.md#populatelock)

***

### populateUnlock()

> `protected` **populateUnlock**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1271)

Unlocks the view population.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateUnlock`](DataGrid.md#populateunlock)

***

### populateWhenVisible()

> `protected` **populateWhenVisible**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:974](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L974)

Whether the grid should wait until visible before populating data.

#### Returns

`boolean`

True when population waits for visibility.

#### Inherited from

[`DataGrid`](DataGrid.md).[`populateWhenVisible`](DataGrid.md#populatewhenvisible)

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

[`DataGrid`](DataGrid.md).[`postProcessColumns`](DataGrid.md#postprocesscolumns)

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

[`DataGrid`](DataGrid.md).[`prepareSubmit`](DataGrid.md#preparesubmit)

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

[`DataGrid`](DataGrid.md).[`propertyItemsReady`](DataGrid.md#propertyitemsready)

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

[`DataGrid`](DataGrid.md).[`propertyItemsToColumns`](DataGrid.md#propertyitemstocolumns)

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

[`DataGrid`](DataGrid.md).[`quickFilterChange`](DataGrid.md#quickfilterchange)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1305)

Refreshes the grid data, waiting for visibility if configured to do so.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refresh`](DataGrid.md#refresh)

***

### refreshIfNeeded()

> `protected` **refreshIfNeeded**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1321)

Refreshes the grid if a refresh was requested while hidden.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`refreshIfNeeded`](DataGrid.md#refreshifneeded)

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

[`DataGrid`](DataGrid.md).[`render`](DataGrid.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`DataGrid`](DataGrid.md).[`renderContents`](DataGrid.md#rendercontents)

***

### resizeCanvas()

> `protected` **resizeCanvas**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1462)

Resizes the underlying grid canvas.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`resizeCanvas`](DataGrid.md#resizecanvas)

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

[`DataGrid`](DataGrid.md).[`restoreSettings`](DataGrid.md#restoresettings)

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

[`DataGrid`](DataGrid.md).[`restoreSettingsFrom`](DataGrid.md#restoresettingsfrom)

***

### routeDialog()

> `protected` **routeDialog**(`itemType`, `dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L388)

Registers hash-based routing for the specified dialog.

#### Parameters

##### itemType

`string`

Entity type key for the dialog.

##### dialog

[`Widget`](Widget.md)\<`any`\>

Dialog widget to route.

#### Returns

`void`

***

### rowCount()

> **rowCount**(): `number`

Defined in: [src/ui/datagrid/datagrid.tsx:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L643)

Returns the number of rows in the grid.

#### Returns

`number`

The row count.

#### Inherited from

[`DataGrid`](DataGrid.md).[`rowCount`](DataGrid.md#rowcount)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1365)

Sets whether the grid is in read-only mode and updates the interface.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`set_readOnly`](DataGrid.md#set_readonly)

***

### setCriteriaParameter()

> `protected` **setCriteriaParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:864](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L864)

Sets the Criteria view parameter from the active filter store criteria.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setCriteriaParameter`](DataGrid.md#setcriteriaparameter)

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

[`DataGrid`](DataGrid.md).[`setEquality`](DataGrid.md#setequality)

***

### setFilterBarVisibility()

> `protected` **setFilterBarVisibility**(): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L237)

Shows or hides the filter bar depending on whether active filters exist.

#### Returns

`void`

***

### setIncludeColumnsParameter()

> `protected` **setIncludeColumnsParameter**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:886](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L886)

Sets the IncludeColumns view parameter from the grid columns.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setIncludeColumnsParameter`](DataGrid.md#setincludecolumnsparameter)

***

### setInitialSortOrder()

> `protected` **setInitialSortOrder**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L598)

Applies the default sort order to the grid and view.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setInitialSortOrder`](DataGrid.md#setinitialsortorder)

***

### setItems()

> **setItems**(`value`): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L659)

Sets the items displayed in the grid.

#### Parameters

##### value

`TItem`[]

The items to display.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setItems`](DataGrid.md#setitems)

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

[`DataGrid`](DataGrid.md).[`setTitle`](DataGrid.md#settitle)

***

### setViewParams()

> `protected` **setViewParams**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:899](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L899)

Prepares all view parameters and notifies the onSetViewParams subscribers.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`setViewParams`](DataGrid.md#setviewparams)

***

### subDialogDataChange()

> `protected` **subDialogDataChange**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1469)

Refreshes the grid when a sub-dialog reports a data change.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`subDialogDataChange`](DataGrid.md#subdialogdatachange)

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

[`DataGrid`](DataGrid.md).[`syncOrAsyncThen`](DataGrid.md#syncorasyncthen)

***

### transferDialogReadOnly()

> `protected` **transferDialogReadOnly**(`dialog`): `void`

Defined in: [src/ui/datagrid/entitygrid.ts:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L459)

Propagates the grid read-only state to a newly created dialog.

#### Parameters

##### dialog

[`Widget`](Widget.md)\<`any`\>

Dialog instance to configure.

#### Returns

`void`

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

[`DataGrid`](DataGrid.md).[`tryFindQuickFilter`](DataGrid.md#tryfindquickfilter)

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:1375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1375)

Updates the toolbar interface to reflect the current grid state.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`updateInterface`](DataGrid.md#updateinterface)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L226)

Whether the grid should load property items asynchronously.

#### Returns

`boolean`

True when async loading is used.

#### Inherited from

[`DataGrid`](DataGrid.md).[`useAsync`](DataGrid.md#useasync)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`DataGrid`](DataGrid.md).[`useIdPrefix`](DataGrid.md#useidprefix)

***

### useLayoutTimer()

> `protected` **useLayoutTimer**(): `boolean`

Defined in: [src/ui/datagrid/datagrid.tsx:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L234)

Whether the grid should use the layout timer for responsive resizing.

#### Returns

`boolean`

True when the layout timer is used.

#### Inherited from

[`DataGrid`](DataGrid.md).[`useLayoutTimer`](DataGrid.md#uselayouttimer)

***

### usePager()

> `protected` **usePager**(): `boolean`

Defined in: [src/ui/datagrid/entitygrid.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/entitygrid.ts#L102)

Indicates whether a pager should be rendered; entity grids use a pager by default.

#### Returns

`boolean`

True when paging is enabled.

#### Overrides

[`DataGrid`](DataGrid.md).[`usePager`](DataGrid.md#usepager)

***

### viewDataChanged()

> `protected` **viewDataChanged**(): `void`

Defined in: [src/ui/datagrid/datagrid.tsx:768](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L768)

Handles view data changes by notifying subscribers and relaying out.

#### Returns

`void`

#### Inherited from

[`DataGrid`](DataGrid.md).[`viewDataChanged`](DataGrid.md#viewdatachanged)

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

[`DataGrid`](DataGrid.md).[`wrapFormatterWithEditLink`](DataGrid.md#wrapformatterwitheditlink)

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

[`DataGrid`](DataGrid.md).[`create`](DataGrid.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

Creates the default DOM element for a widget.

#### Returns

`HTMLElement`

A new `div` element.

#### Inherited from

[`DataGrid`](DataGrid.md).[`createDefaultElement`](DataGrid.md#createdefaultelement)

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

[`DataGrid`](DataGrid.md).[`getWidgetName`](DataGrid.md#getwidgetname)

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

[`DataGrid`](DataGrid.md).[`propertyItemToQuickFilter`](DataGrid.md#propertyitemtoquickfilter)

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

[`DataGrid`](DataGrid.md).[`registerClass`](DataGrid.md#registerclass)

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

[`DataGrid`](DataGrid.md).[`registerEditor`](DataGrid.md#registereditor)
