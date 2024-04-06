[@serenity-is/sleekgrid](../README.md) / FormatterContext

# Interface: FormatterContext\<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Table of contents

### Properties

- [addAttrs](FormatterContext.md#addattrs)
- [addClass](FormatterContext.md#addclass)
- [cell](FormatterContext.md#cell)
- [column](FormatterContext.md#column)
- [escape](FormatterContext.md#escape)
- [grid](FormatterContext.md#grid)
- [item](FormatterContext.md#item)
- [row](FormatterContext.md#row)
- [tooltip](FormatterContext.md#tooltip)
- [value](FormatterContext.md#value)

## Properties

### addAttrs

• `Optional` **addAttrs**: `Object`

#### Index signature

▪ [key: `string`]: `string`

#### Defined in

[core/formatting.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L5)

___

### addClass

• `Optional` **addClass**: `string`

#### Defined in

[core/formatting.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L6)

___

### cell

• `Optional` **cell**: `number`

#### Defined in

[core/formatting.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L7)

___

### column

• `Optional` **column**: [`Column`](Column.md)\<`TItem`\>

#### Defined in

[core/formatting.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L8)

___

### escape

• `Readonly` **escape**: (`value?`: `any`) => `string`

returns html escaped ctx.value if called without arguments. prefer this over ctx.value to avoid html injection attacks!

#### Type declaration

▸ (`value?`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `value?` | `any` |

##### Returns

`string`

#### Defined in

[core/formatting.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L10)

___

### grid

• `Optional` **grid**: `any`

#### Defined in

[core/formatting.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L11)

___

### item

• `Optional` **item**: `TItem`

#### Defined in

[core/formatting.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L12)

___

### row

• `Optional` **row**: `number`

#### Defined in

[core/formatting.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L13)

___

### tooltip

• `Optional` **tooltip**: `string`

#### Defined in

[core/formatting.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L14)

___

### value

• `Optional` **value**: `any`

when returning a formatter result, prefer ctx.escape() to avoid script injection attacks!

#### Defined in

[core/formatting.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L16)
