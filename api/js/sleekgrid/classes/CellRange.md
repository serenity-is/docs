[@serenity-is/sleekgrid](../README.md) / CellRange

# Class: CellRange

## Table of contents

### Constructors

- [constructor](CellRange.md#constructor)

### Properties

- [fromCell](CellRange.md#fromcell)
- [fromRow](CellRange.md#fromrow)
- [toCell](CellRange.md#tocell)
- [toRow](CellRange.md#torow)

### Methods

- [contains](CellRange.md#contains)
- [isSingleCell](CellRange.md#issinglecell)
- [isSingleRow](CellRange.md#issinglerow)
- [toString](CellRange.md#tostring)

## Constructors

### constructor

• **new CellRange**(`fromRow`, `fromCell`, `toRow?`, `toCell?`): [`CellRange`](CellRange.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `fromRow` | `number` |
| `fromCell` | `number` |
| `toRow?` | `number` |
| `toCell?` | `number` |

#### Returns

[`CellRange`](CellRange.md)

#### Defined in

[core/cellrange.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L15)

## Properties

### fromCell

• **fromCell**: `number`

#### Defined in

[core/cellrange.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L11)

___

### fromRow

• **fromRow**: `number`

#### Defined in

[core/cellrange.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L10)

___

### toCell

• **toCell**: `number`

#### Defined in

[core/cellrange.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L13)

___

### toRow

• **toRow**: `number`

#### Defined in

[core/cellrange.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L12)

## Methods

### contains

▸ **contains**(`row`, `cell`): `boolean`

Returns whether a range contains a given cell.

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`boolean`

#### Defined in

[core/cellrange.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L44)

___

### isSingleCell

▸ **isSingleCell**(): `boolean`

Returns whether a range represents a single cell.

#### Returns

`boolean`

#### Defined in

[core/cellrange.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L37)

___

### isSingleRow

▸ **isSingleRow**(): `boolean`

Returns whether a range represents a single row.

#### Returns

`boolean`

#### Defined in

[core/cellrange.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L30)

___

### toString

▸ **toString**(): `string`

Returns a readable representation of a range.

#### Returns

`string`

#### Defined in

[core/cellrange.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L52)
