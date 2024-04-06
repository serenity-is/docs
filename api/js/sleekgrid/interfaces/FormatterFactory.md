[@serenity-is/sleekgrid](../README.md) / FormatterFactory

# Interface: FormatterFactory\<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Table of contents

### Methods

- [getFormat](FormatterFactory.md#getformat)
- [getFormatter](FormatterFactory.md#getformatter)

## Methods

### getFormat

▸ **getFormat**(`column`): [`ColumnFormat`](../README.md#columnformat)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | [`Column`](Column.md)\<`TItem`\> |

#### Returns

[`ColumnFormat`](../README.md#columnformat)\<`TItem`\>

#### Defined in

[core/formatting.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L31)

___

### getFormatter

▸ **getFormatter**(`column`): [`CompatFormatter`](../README.md#compatformatter)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | [`Column`](Column.md)\<`TItem`\> |

#### Returns

[`CompatFormatter`](../README.md#compatformatter)\<`TItem`\>

#### Defined in

[core/formatting.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L32)
