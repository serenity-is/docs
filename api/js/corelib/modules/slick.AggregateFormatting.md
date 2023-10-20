[@serenity-is](../README.md) / [Modules](../modules.md) / [slick](slick.md) / AggregateFormatting

# Namespace: AggregateFormatting

[slick](slick.md).AggregateFormatting

## Table of contents

### Functions

- [formatMarkup](slick.AggregateFormatting.md#formatmarkup)
- [formatValue](slick.AggregateFormatting.md#formatvalue)
- [groupTotalsFormatter](slick.AggregateFormatting.md#grouptotalsformatter)

## Functions

### formatMarkup

▸ **formatMarkup**<`TItem`\>(`totals`, `column`, `aggType`): `string`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `totals` | `GroupTotals`<`any`\> |
| `column` | `Column`<`TItem`\> |
| `aggType` | `string` |

#### Returns

`string`

#### Defined in

[src/slick/aggregators.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L146)

___

### formatValue

▸ **formatValue**(`column`, `value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`<`any`\> |
| `value` | `number` |

#### Returns

`string`

#### Defined in

[src/slick/aggregators.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L158)

___

### groupTotalsFormatter

▸ **groupTotalsFormatter**<`TItem`\>(`totals`, `column`): `string`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `totals` | `GroupTotals`<`any`\> |
| `column` | `Column`<`TItem`\> |

#### Returns

`string`

#### Defined in

[src/slick/aggregators.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L180)
