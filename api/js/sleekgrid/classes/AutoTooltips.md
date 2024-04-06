[@serenity-is/sleekgrid](../README.md) / AutoTooltips

# Class: AutoTooltips

## Implements

- [`IPlugin`](../interfaces/IPlugin.md)

## Table of contents

### Constructors

- [constructor](AutoTooltips.md#constructor)

### Properties

- [pluginName](AutoTooltips.md#pluginname)
- [defaults](AutoTooltips.md#defaults)

### Methods

- [destroy](AutoTooltips.md#destroy)
- [init](AutoTooltips.md#init)

## Constructors

### constructor

• **new AutoTooltips**(`options?`): [`AutoTooltips`](AutoTooltips.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`AutoTooltipsOptions`](../interfaces/AutoTooltipsOptions.md) |

#### Returns

[`AutoTooltips`](AutoTooltips.md)

#### Defined in

[plugins/autotooltips.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L15)

## Properties

### pluginName

• **pluginName**: `string` = `"AutoTooltips"`

#### Implementation of

[IPlugin](../interfaces/IPlugin.md).[pluginName](../interfaces/IPlugin.md#pluginname)

#### Defined in

[plugins/autotooltips.ts:75](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L75)

___

### defaults

▪ `Static` `Readonly` **defaults**: [`AutoTooltipsOptions`](../interfaces/AutoTooltipsOptions.md)

#### Defined in

[plugins/autotooltips.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L19)

## Methods

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Implementation of

[IPlugin](../interfaces/IPlugin.md).[destroy](../interfaces/IPlugin.md#destroy)

#### Defined in

[plugins/autotooltips.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L36)

___

### init

▸ **init**(`grid`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`Grid`](Grid.md)\<`any`\> |

#### Returns

`void`

#### Implementation of

[IPlugin](../interfaces/IPlugin.md).[init](../interfaces/IPlugin.md#init)

#### Defined in

[plugins/autotooltips.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L26)
