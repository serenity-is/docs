[@serenity-is/sleekgrid](../README.md) / LayoutHost

# Interface: LayoutHost

Defined in: [src/layouts/layout-host.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L7)

## Extends

- `Pick`\<[`ISleekGrid`](ISleekGrid.md), `"getAllColumns"` \| `"getColumns"` \| `"getOptions"` \| `"getContainerNode"` \| `"getDataLength"` \| `"onAfterInit"`\>.[`GridPluginHost`](GridPluginHost.md)

## Properties

### onAfterInit

> `readonly` **onAfterInit**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L16)

#### Inherited from

`Pick.onAfterInit`

***

### refs

> `readonly` **refs**: [`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

Defined in: [src/layouts/layout-host.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L12)

## Methods

### getAllColumns()

> **getAllColumns**(): [`Column`](Column.md)\<`any`\>[]

Defined in: [src/core/isleekgrid.ts:67](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L67)

Returns all columns in the grid, including hidden ones, the order might not match visible columns due to pinning, ordering etc.

#### Returns

[`Column`](Column.md)\<`any`\>[]

#### Inherited from

`Pick.getAllColumns`

***

### getColumns()

> **getColumns**(): [`Column`](Column.md)\<`any`\>[]

Defined in: [src/core/isleekgrid.ts:84](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L84)

Returns only the visible columns in order

#### Returns

[`Column`](Column.md)\<`any`\>[]

#### Inherited from

`Pick.getColumns`

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:85](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L85)

#### Returns

`HTMLElement`

#### Inherited from

`Pick.getContainerNode`

***

### getDataLength()

> **getDataLength**(): `number`

Defined in: [src/core/isleekgrid.ts:89](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L89)

#### Returns

`number`

#### Inherited from

`Pick.getDataLength`

***

### getOptions()

> **getOptions**(): [`GridOptions`](GridOptions.md)\<`any`\>

Defined in: [src/core/isleekgrid.ts:104](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L104)

#### Returns

[`GridOptions`](GridOptions.md)\<`any`\>

#### Inherited from

`Pick.getOptions`

***

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](GridPlugin.md)

Defined in: [src/core/grid-plugin.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L15)

#### Parameters

##### name

`string`

#### Returns

[`GridPlugin`](GridPlugin.md)

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`getPluginByName`](GridPluginHost.md#getpluginbyname)

***

### getSignals()

> **getSignals**(): [`GridSignals`](GridSignals.md)

Defined in: [src/layouts/layout-host.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L9)

#### Returns

[`GridSignals`](GridSignals.md)

***

### getViewportInfo()

> **getViewportInfo**(): [`ViewportInfo`](ViewportInfo.md)

Defined in: [src/layouts/layout-host.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L10)

#### Returns

[`ViewportInfo`](ViewportInfo.md)

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L16)

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`registerPlugin`](GridPluginHost.md#registerplugin)

***

### removeNode()

> **removeNode**(`node`): `void`

Defined in: [src/layouts/layout-host.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-host.ts#L11)

#### Parameters

##### node

`HTMLElement`

#### Returns

`void`

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L17)

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`unregisterPlugin`](GridPluginHost.md#unregisterplugin)
