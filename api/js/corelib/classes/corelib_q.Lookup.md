[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / Lookup

# Class: Lookup<TItem\>

[corelib/q](../modules/corelib_q.md).Lookup

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Constructors

- [constructor](corelib_q.Lookup.md#constructor)

### Properties

- [idField](corelib_q.Lookup.md#idfield)
- [itemById](corelib_q.Lookup.md#itembyid)
- [items](corelib_q.Lookup.md#items)
- [parentIdField](corelib_q.Lookup.md#parentidfield)
- [textField](corelib_q.Lookup.md#textfield)
- [textFormatter](corelib_q.Lookup.md#textformatter)

### Methods

- [update](corelib_q.Lookup.md#update)

## Constructors

### constructor

• **new Lookup**<`TItem`\>(`options`, `items?`)

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`LookupOptions`](../interfaces/corelib_q.LookupOptions.md)<`TItem`\> |
| `items?` | `TItem`[] |

#### Defined in

[src/q/lookup.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;25)

## Properties

### idField

• **idField**: `string`

#### Defined in

[src/q/lookup.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;11)

[src/q/lookup.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;20)

___

### itemById

• **itemById**: `Object`

#### Index signature

▪ [key: `string`]: `TItem`

#### Defined in

[src/q/lookup.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;10)

[src/q/lookup.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;19)

___

### items

• **items**: `TItem`[]

#### Defined in

[src/q/lookup.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;9)

[src/q/lookup.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;18)

___

### parentIdField

• **parentIdField**: `string`

#### Defined in

[src/q/lookup.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;12)

[src/q/lookup.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;21)

___

### textField

• **textField**: `string`

#### Defined in

[src/q/lookup.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;13)

[src/q/lookup.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;22)

___

### textFormatter

• **textFormatter**: (`item`: `TItem`) => `string`

#### Type declaration

▸ (`item`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

##### Returns

`string`

#### Defined in

[src/q/lookup.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;14)

[src/q/lookup.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;23)

## Methods

### update

▸ `Optional` **update**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem`[] |

#### Returns

`void`

#### Defined in

[src/q/lookup.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#line&#x3D;37)
