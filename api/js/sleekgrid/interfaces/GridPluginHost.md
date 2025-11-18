[@serenity-is/sleekgrid](../README.md) / GridPluginHost

# Interface: GridPluginHost

Defined in: [src/core/grid-plugin.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L14)

## Extended by

- [`ISleekGrid`](ISleekGrid.md)
- [`LayoutHost`](LayoutHost.md)

## Methods

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](GridPlugin.md)

Defined in: [src/core/grid-plugin.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L15)

#### Parameters

##### name

`string`

#### Returns

[`GridPlugin`](GridPlugin.md)

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L16)

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

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
