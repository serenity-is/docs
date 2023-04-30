[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / LT

# Class: LT

[corelib/q](../modules/corelib_q.md).LT

## Table of contents

### Constructors

- [constructor](corelib_q.LT.md#constructor)

### Properties

- [key](corelib_q.LT.md#key)
- [empty](corelib_q.LT.md#empty)
- [getDefault](corelib_q.LT.md#getdefault)
- [initializeTextClass](corelib_q.LT.md#initializetextclass)

### Methods

- [get](corelib_q.LT.md#get)
- [toString](corelib_q.LT.md#tostring)
- [add](corelib_q.LT.md#add)

## Constructors

### constructor

• **new LT**(`key`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Defined in

[src/q/localtext.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L99)

## Properties

### key

• `Private` **key**: `string`

#### Defined in

[src/q/localtext.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L99)

___

### empty

▪ `Static` **empty**: [`LT`](corelib_q.LT.md)

#### Defined in

[src/q/localtext.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L97)

___

### getDefault

▪ `Static` **getDefault**: (`key`: `string`, `defaultText`: `string`) => `string`

#### Type declaration

▸ (`key`, `defaultText`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `defaultText` | `string` |

##### Returns

`string`

#### Defined in

[src/q/localtext.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L159)

___

### initializeTextClass

▪ `Static` **initializeTextClass**: (`type`: `any`, `prefix`: `string`) => `void`

#### Type declaration

▸ (`type`, `prefix`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `any` |
| `prefix` | `string` |

##### Returns

`void`

#### Defined in

[src/q/localtext.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L144)

## Methods

### get

▸ **get**(): `string`

#### Returns

`string`

#### Defined in

[src/q/localtext.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L128)

___

### toString

▸ **toString**(): `string`

#### Returns

`string`

#### Defined in

[src/q/localtext.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L136)

___

### add

▸ `Static` **add**(`key`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/q/localtext.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L102)
