[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / LookupOptions

# Interface: LookupOptions<TItem\>

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Properties

- [idField](LookupOptions.md#idfield)
- [parentIdField](LookupOptions.md#parentidfield)
- [textField](LookupOptions.md#textfield)

### Methods

- [textFormatter](LookupOptions.md#textformatter)

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
