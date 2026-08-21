[@serenity-is/sleekgrid](../README.md) / GridPluginHost

# Interface: GridPluginHost

Defined in: [src/core/grid-plugin.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L29)

Host surface implemented by the grid for managing [GridPlugin](GridPlugin.md) lifetimes.

## Extended by

- [`ISleekGrid`](ISleekGrid.md)
- [`LayoutHost`](LayoutHost.md)

## Methods

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
