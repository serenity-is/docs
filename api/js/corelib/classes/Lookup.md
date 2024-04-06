[@serenity-is/corelib](../README.md) / Lookup

# Class: Lookup\<TItem\>

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Constructors

- [constructor](Lookup.md#constructor)

### Properties

- [idField](Lookup.md#idfield)
- [itemById](Lookup.md#itembyid)
- [items](Lookup.md#items)
- [parentIdField](Lookup.md#parentidfield)
- [textField](Lookup.md#textfield)

### Methods

- [update](Lookup.md#update)

## Constructors

### constructor

• **new Lookup**\<`TItem`\>(`options`, `items?`): [`Lookup`](Lookup.md)\<`TItem`\>

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`LookupOptions`](../interfaces/LookupOptions.md)\<`TItem`\> |
| `items?` | `TItem`[] |

#### Returns

[`Lookup`](Lookup.md)\<`TItem`\>

#### Defined in

[../base/dist/index.d.ts:1300](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1300)

## Properties

### idField

• **idField**: `string`

#### Defined in

[../base/dist/index.d.ts:1288](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1288)

[../base/dist/index.d.ts:1297](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1297)

___

### itemById

• **itemById**: `Object`

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[../base/dist/index.d.ts:1285](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1285)

[../base/dist/index.d.ts:1294](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1294)

___

### items

• **items**: `TItem`[]

#### Defined in

[../base/dist/index.d.ts:1284](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1284)

[../base/dist/index.d.ts:1293](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1293)

___

### parentIdField

• **parentIdField**: `string`

#### Defined in

[../base/dist/index.d.ts:1289](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1289)

[../base/dist/index.d.ts:1298](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1298)

___

### textField

• **textField**: `string`

#### Defined in

[../base/dist/index.d.ts:1290](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1290)

[../base/dist/index.d.ts:1299](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1299)

## Methods

### update

▸ **update**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem`[] |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1301](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1301)
