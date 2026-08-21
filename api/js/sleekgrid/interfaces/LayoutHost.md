[@serenity-is/sleekgrid](../README.md) / LayoutHost

# Interface: LayoutHost

Defined in: [src/layouts/layout-host.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L11)

Minimal host surface exposed to [LayoutEngine](LayoutEngine.md) implementations.
Narrower than [ISleekGrid](ISleekGrid.md); only what layouts need is exposed.

## Extends

- `Pick`\<[`ISleekGrid`](ISleekGrid.md), `"getAllColumns"` \| `"getColumns"` \| `"getOptions"` \| `"getContainerNode"` \| `"getDataLength"` \| `"onAfterInit"`\>.[`GridPluginHost`](GridPluginHost.md)

## Properties

### onAfterInit

> `readonly` **onAfterInit**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L24)

Fired once after `init()` completes. [ArgsGrid](ArgsGrid.md) payload.

#### Inherited from

`Pick.onAfterInit`

***

### refs

> `readonly` **refs**: [`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

Defined in: [src/layouts/layout-host.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L29)

Mutable refs tracking per-band DOM nodes and pinning/frozen state.

## Methods

### getAllColumns()

> **getAllColumns**(): [`Column`](Column.md)\<`any`\>[]

Defined in: [src/core/isleekgrid.ts:170](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L170)

Returns all columns in the grid, including hidden ones; order may differ from visible columns due to pinning/reordering.

#### Returns

[`Column`](Column.md)\<`any`\>[]

#### Inherited from

`Pick.getAllColumns`

***

### getColumns()

> **getColumns**(): [`Column`](Column.md)\<`any`\>[]

Defined in: [src/core/isleekgrid.ts:246](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L246)

Returns only the visible columns in display order.

#### Returns

[`Column`](Column.md)\<`any`\>[]

#### Inherited from

`Pick.getColumns`

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:248](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L248)

Returns the root container element of the grid.

#### Returns

`HTMLElement`

#### Inherited from

`Pick.getContainerNode`

***

### getDataLength()

> **getDataLength**(): `number`

Defined in: [src/core/isleekgrid.ts:265](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L265)

Returns the number of rows in the grid's data source/view.

#### Returns

`number`

#### Inherited from

`Pick.getDataLength`

***

### getOptions()

> **getOptions**(): [`GridOptions`](GridOptions.md)\<`any`\>

Defined in: [src/core/isleekgrid.ts:314](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L314)

Returns the current grid options.

#### Returns

[`GridOptions`](GridOptions.md)\<`any`\>

#### Inherited from

`Pick.getOptions`

***

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](GridPlugin.md)

Defined in: [src/core/grid-plugin.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L35)

Retrieves a plugin by its [GridPlugin.pluginName](GridPlugin.md#pluginname).

#### Parameters

##### name

`string`

Plugin name to look up.

#### Returns

[`GridPlugin`](GridPlugin.md)

The plugin instance, or `null`/`undefined` when not found.

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`getPluginByName`](GridPluginHost.md#getpluginbyname)

***

### getSignals()

> **getSignals**(): [`GridSignals`](GridSignals.md)

Defined in: [src/layouts/layout-host.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L17)

Returns the shared reactive signals controlling visibility/pinning.

#### Returns

[`GridSignals`](GridSignals.md)

Grid signals object.

***

### getViewportInfo()

> **getViewportInfo**(): [`ViewportInfo`](ViewportInfo.md)

Defined in: [src/layouts/layout-host.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L22)

Returns computed viewport metrics (dimensions, scroll flags, heights).

#### Returns

[`ViewportInfo`](ViewportInfo.md)

Current [ViewportInfo](ViewportInfo.md).

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L40)

Registers a plugin and calls its [GridPlugin.init](GridPlugin.md#init).

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

Plugin to register.

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`registerPlugin`](GridPluginHost.md#registerplugin)

***

### removeNode()

> **removeNode**(`node`): `void`

Defined in: [src/layouts/layout-host.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L27)

Removes a DOM node via the grid's configured sanitizer/custom remover.

#### Parameters

##### node

`HTMLElement`

Element to remove.

#### Returns

`void`

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L45)

Unregisters a plugin, calling [GridPlugin.destroy](GridPlugin.md#destroy) if defined.

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

Plugin to remove.

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`unregisterPlugin`](GridPluginHost.md#unregisterplugin)
