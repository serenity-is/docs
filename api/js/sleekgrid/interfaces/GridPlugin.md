[@serenity-is/sleekgrid](../README.md) / GridPlugin

# Interface: GridPlugin

Defined in: [src/core/grid-plugin.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L6)

Contract for grid plugins (e.g. selection models, overlays).

## Extended by

- [`IPlugin`](IPlugin.md)
- [`SelectionModel`](SelectionModel.md)

## Properties

### destroy()?

> `optional` **destroy**: () => `void`

Defined in: [src/core/grid-plugin.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L15)

Optional teardown hook; called when the grid or plugin is unregistered.

#### Returns

`void`

***

### pluginName?

> `optional` **pluginName**: `string`

Defined in: [src/core/grid-plugin.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L13)

Optional unique name used by [GridPluginHost.getPluginByName](GridPluginHost.md#getpluginbyname) for lookup.

## Methods

### init()

> **init**(`grid`): `void`

Defined in: [src/core/grid-plugin.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L11)

Called by the grid when the plugin is registered.

#### Parameters

##### grid

[`ISleekGrid`](ISleekGrid.md)

Host grid instance the plugin attaches to.

#### Returns

`void`
