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

[src/base/lookup.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L22)

## Properties

### idField

• **idField**: `string`

#### Defined in

[src/base/lookup.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L10)

[src/base/lookup.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L18)

___

### itemById

• **itemById**: `Object`

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[src/base/lookup.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L9)

[src/base/lookup.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L17)

___

### items

• **items**: `TItem`[]

#### Defined in

[src/base/lookup.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L8)

[src/base/lookup.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L16)

___

### parentIdField

• **parentIdField**: `string`

#### Defined in

[src/base/lookup.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L11)

[src/base/lookup.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L19)

___

### textField

• **textField**: `string`

#### Defined in

[src/base/lookup.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L12)

[src/base/lookup.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L20)

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

[src/base/lookup.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L32)
