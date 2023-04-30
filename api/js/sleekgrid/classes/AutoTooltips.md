[@serenity-is/sleekgrid](../README.md) / AutoTooltips

# Class: AutoTooltips

## Implements

- [`IPlugin`](../interfaces/IPlugin.md)

## Table of contents

### Constructors

- [constructor](AutoTooltips.md#constructor)

### Properties

- [grid](AutoTooltips.md#grid)
- [options](AutoTooltips.md#options)
- [pluginName](AutoTooltips.md#pluginname)
- [defaults](AutoTooltips.md#defaults)

### Methods

- [destroy](AutoTooltips.md#destroy)
- [handleHeaderMouseEnter](AutoTooltips.md#handleheadermouseenter)
- [handleMouseEnter](AutoTooltips.md#handlemouseenter)
- [init](AutoTooltips.md#init)

## Constructors

### constructor

• **new AutoTooltips**(`options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`AutoTooltipsOptions`](../interfaces/AutoTooltipsOptions.md) |

#### Defined in

[plugins/autotooltips.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L15)

## Properties

### grid

• `Private` **grid**: [`Grid`](Grid.md)<`any`\>

#### Defined in

[plugins/autotooltips.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L12)

___

### options

• `Private` **options**: [`AutoTooltipsOptions`](../interfaces/AutoTooltipsOptions.md)

#### Defined in

[plugins/autotooltips.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L13)

___

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

### handleHeaderMouseEnter

▸ `Private` **handleHeaderMouseEnter**(`e`, `args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |
| `args` | [`ArgsColumn`](../interfaces/ArgsColumn.md) |

#### Returns

`void`

#### Defined in

[plugins/autotooltips.ts:67](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L67)

___

### handleMouseEnter

▸ `Private` **handleMouseEnter**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[plugins/autotooltips.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L44)

___

### init

▸ **init**(`grid`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`Grid`](Grid.md)<`any`\> |

#### Returns

`void`

#### Implementation of

[IPlugin](../interfaces/IPlugin.md).[init](../interfaces/IPlugin.md#init)

#### Defined in

[plugins/autotooltips.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/autotooltips.ts#L26)
