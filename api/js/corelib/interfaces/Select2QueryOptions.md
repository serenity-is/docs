[@serenity-is/corelib](../README.md) / Select2QueryOptions

# Interface: Select2QueryOptions

## Table of contents

### Properties

- [callback](Select2QueryOptions.md#callback)
- [context](Select2QueryOptions.md#context)
- [element](Select2QueryOptions.md#element)
- [matcher](Select2QueryOptions.md#matcher)
- [page](Select2QueryOptions.md#page)
- [term](Select2QueryOptions.md#term)

## Properties

### callback

• `Optional` **callback**: (`p1`: [`Select2Result`](Select2Result.md)) => `void`

#### Type declaration

▸ (`p1`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | [`Select2Result`](Select2Result.md) |

##### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L15)

___

### context

• `Optional` **context**: `any`

#### Defined in

[src/ui/editors/select2.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L14)

___

### element

• `Optional` **element**: [`Select2Element`](../README.md#select2element)

#### Defined in

[src/ui/editors/select2.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L11)

___

### matcher

• `Optional` **matcher**: (`p1`: `any`, `p2`: `any`, `p3?`: `any`) => `boolean`

#### Type declaration

▸ (`p1`, `p2`, `p3?`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `any` |
| `p3?` | `any` |

##### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L16)

___

### page

• `Optional` **page**: `number`

#### Defined in

[src/ui/editors/select2.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L13)

___

### term

• `Optional` **term**: `string`

#### Defined in

[src/ui/editors/select2.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L12)
