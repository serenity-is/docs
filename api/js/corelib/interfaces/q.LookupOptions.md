[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / LookupOptions

# Interface: LookupOptions<TItem\>

[q](../modules/q.md).LookupOptions

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Properties

- [idField](q.LookupOptions.md#idfield)
- [parentIdField](q.LookupOptions.md#parentidfield)
- [textField](q.LookupOptions.md#textfield)

### Methods

- [textFormatter](q.LookupOptions.md#textformatter)

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
