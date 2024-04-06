[@serenity-is/corelib](../README.md) / Tooltip

# Class: Tooltip

## Table of contents

### Constructors

- [constructor](Tooltip.md#constructor)

### Properties

- [defaults](Tooltip.md#defaults)

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

[src/base/tooltip.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L12)

## Properties

### defaults

▪ `Static` **defaults**: [`TooltipOptions`](../interfaces/TooltipOptions.md)

#### Defined in

[src/base/tooltip.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L36)

## Accessors

### isAvailable

• `get` **isAvailable**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/tooltip.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L76)

## Methods

### delayedDispose

▸ **delayedDispose**(`delay?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `delay` | `number` | `5000` |

#### Returns

`void`

#### Defined in

[src/base/tooltip.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L47)

___

### delayedHide

▸ **delayedHide**(`delay?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `delay` | `number` | `5000` |

#### Returns

`void`

#### Defined in

[src/base/tooltip.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L51)

___

### dispose

▸ **dispose**(): `void`

#### Returns

`void`

#### Defined in

[src/base/tooltip.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L40)

___

### hide

▸ **hide**(): [`Tooltip`](Tooltip.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L111)

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

[src/base/tooltip.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L81)

___

### show

▸ **show**(): [`Tooltip`](Tooltip.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L115)

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

[src/base/tooltip.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L99)

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

[src/base/tooltip.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L68)
