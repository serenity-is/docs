[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / LookupOptions

# Interface: LookupOptions<TItem\>

[corelib/q](../modules/corelib_q.md).LookupOptions

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Properties

- [idField](corelib_q.LookupOptions.md#idfield)
- [parentIdField](corelib_q.LookupOptions.md#parentidfield)
- [textField](corelib_q.LookupOptions.md#textfield)

### Methods

- [textFormatter](corelib_q.LookupOptions.md#textformatter)

## Properties

### idField

• `Optional` **idField**: `string`

#### Defined in

[src/q/lookup.ts:2](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#L2)

___

### parentIdField

• `Optional` **parentIdField**: `string`

#### Defined in

[src/q/lookup.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#L3)

___

### textField

• `Optional` **textField**: `string`

#### Defined in

[src/q/lookup.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#L4)

## Methods

### textFormatter

▸ `Optional` **textFormatter**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`string`

#### Defined in

[src/q/lookup.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/lookup.ts#L5)
