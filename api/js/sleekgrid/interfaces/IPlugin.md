[@serenity-is/sleekgrid](../README.md) / IPlugin

# ~~Interface: IPlugin~~

Defined in: [src/core/grid-plugin.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L22)

Legacy alias for [GridPlugin](GridPlugin.md).

## Deprecated

Use [GridPlugin](GridPlugin.md) instead.

## Extends

- [`GridPlugin`](GridPlugin.md)

## Properties

### ~~destroy()?~~

> `optional` **destroy**: () => `void`

Defined in: [src/core/grid-plugin.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L15)

Optional teardown hook; called when the grid or plugin is unregistered.

#### Returns

`void`

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`destroy`](GridPlugin.md#destroy)

***

### ~~pluginName?~~

> `optional` **pluginName**: `string`

Defined in: [src/core/grid-plugin.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L13)

Optional unique name used by [GridPluginHost.getPluginByName](GridPluginHost.md#getpluginbyname) for lookup.

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`pluginName`](GridPlugin.md#pluginname)

## Methods

### ~~init()~~

> **init**(`grid`): `void`

Defined in: [src/core/grid-plugin.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L11)

Called by the grid when the plugin is registered.

#### Parameters

##### grid

[`ISleekGrid`](ISleekGrid.md)

Host grid instance the plugin attaches to.

#### Returns

`void`

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`init`](GridPlugin.md#init)
