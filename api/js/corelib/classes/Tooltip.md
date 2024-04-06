[@serenity-is/corelib](../README.md) / Tooltip

# Class: Tooltip

## Table of contents

### Constructors

- [constructor](Tooltip.md#constructor)

### Properties

- [el](Tooltip.md#el)
- [defaults](Tooltip.md#defaults)
- [existingInstance](Tooltip.md#existinginstance)

### Accessors

- [isAvailable](Tooltip.md#isavailable)

### Methods

- [delayedDispose](Tooltip.md#delayeddispose)
- [delayedHide](Tooltip.md#delayedhide)
- [dispose](Tooltip.md#dispose)
- [hide](Tooltip.md#hide)
- [setTitle](Tooltip.md#settitle)
- [show](Tooltip.md#show)
- [toggle](Tooltip.md#toggle)
- [getInstance](Tooltip.md#getinstance)

## Constructors

### constructor

• **new Tooltip**(`el`, `opt?`): [`Tooltip`](Tooltip.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `opt?` | [`TooltipOptions`](../interfaces/TooltipOptions.md) |

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[../base/dist/index.d.ts:1589](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1589)

## Properties

### el

• `Private` **el**: `any`

#### Defined in

[../base/dist/index.d.ts:1588](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1588)

___

### defaults

▪ `Static` **defaults**: [`TooltipOptions`](../interfaces/TooltipOptions.md)

#### Defined in

[../base/dist/index.d.ts:1590](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1590)

___

### existingInstance

▪ `Static` `Private` **existingInstance**: `any`

#### Defined in

[../base/dist/index.d.ts:1594](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1594)

## Accessors

### isAvailable

• `get` **isAvailable**(): `boolean`

#### Returns

`boolean`

#### Defined in

[../base/dist/index.d.ts:1596](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1596)

## Methods

### delayedDispose

▸ **delayedDispose**(`delay?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `delay?` | `number` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1592](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1592)

___

### delayedHide

▸ **delayedHide**(`delay?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `delay?` | `number` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1593](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1593)

___

### dispose

▸ **dispose**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1591](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1591)

___

### hide

▸ **hide**(): [`Tooltip`](Tooltip.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[../base/dist/index.d.ts:1599](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1599)

___

### setTitle

▸ **setTitle**(`value`): [`Tooltip`](Tooltip.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[../base/dist/index.d.ts:1597](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1597)

___

### show

▸ **show**(): [`Tooltip`](Tooltip.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[../base/dist/index.d.ts:1600](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1600)

___

### toggle

▸ **toggle**(`show`): [`Tooltip`](Tooltip.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `show` | `boolean` |

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[../base/dist/index.d.ts:1598](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1598)

___

### getInstance

▸ **getInstance**(`el`): [`Tooltip`](Tooltip.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[../base/dist/index.d.ts:1595](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1595)
