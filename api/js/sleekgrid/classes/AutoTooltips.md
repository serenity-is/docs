[@serenity-is/sleekgrid](../README.md) / AutoTooltips

# Class: AutoTooltips

Defined in: [src/plugins/autotooltips.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L21)

Grid plugin that automatically sets `title` tooltips for truncated cell content.
Handles overflow detection via `clientWidth < scrollWidth` and optional truncation.

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)

## Constructors

### Constructor

> **new AutoTooltips**(`options?`): `AutoTooltips`

Defined in: [src/plugins/autotooltips.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L32)

Creates the plugin.

#### Parameters

##### options?

[`AutoTooltipsOptions`](../interfaces/AutoTooltipsOptions.md)

Partial options merged with [AutoTooltips.defaults](#defaults).

#### Returns

`AutoTooltips`

## Properties

### pluginName

> **pluginName**: `string` = `"AutoTooltips"`

Defined in: [src/plugins/autotooltips.ts:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L101)

Plugin name for lookup via `grid.getPluginByName()`.

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`pluginName`](../interfaces/GridPlugin.md#pluginname)

***

### defaults

> `readonly` `static` **defaults**: [`AutoTooltipsOptions`](../interfaces/AutoTooltipsOptions.md)

Defined in: [src/plugins/autotooltips.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L37)

Default option values.

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/plugins/autotooltips.ts:61](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L61)

Detaches handlers installed by [AutoTooltips.init](#init).

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`destroy`](../interfaces/GridPlugin.md#destroy)

***

### init()

> **init**(`grid`): `void`

Defined in: [src/plugins/autotooltips.ts:48](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L48)

Attaches overflow-tooltip handlers based on current options.

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

Host grid instance.

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`init`](../interfaces/GridPlugin.md#init)
