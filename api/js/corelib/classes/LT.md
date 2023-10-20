[@serenity-is/corelib](../README.md) / LT

# Class: LT

## Table of contents

### Constructors

- [constructor](LT.md#constructor)

### Properties

- [key](LT.md#key)
- [empty](LT.md#empty)
- [getDefault](LT.md#getdefault)
- [initializeTextClass](LT.md#initializetextclass)

### Methods

- [get](LT.md#get)
- [toString](LT.md#tostring)
- [add](LT.md#add)

## Constructors

### constructor

• **new LT**(`key`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Defined in

[src/q/localtext.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L97)

## Properties

### key

• `Private` **key**: `string`

#### Defined in

[src/q/localtext.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L97)

___

### empty

▪ `Static` **empty**: [`LT`](LT.md)

#### Defined in

[src/q/localtext.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L95)

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

[src/q/localtext.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L157)

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

[src/q/localtext.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L142)

## Methods

### get

▸ **get**(): `string`

#### Returns

`string`

#### Defined in

[src/q/localtext.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L126)

___

### toString

▸ **toString**(): `string`

#### Returns

`string`

#### Defined in

[src/q/localtext.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L134)

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

[src/q/localtext.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext.ts#L100)
