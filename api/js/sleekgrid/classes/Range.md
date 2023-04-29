[@serenity-is/sleekgrid](../README.md) / Range

# Class: Range

## Table of contents

### Constructors

- [constructor](Range.md#constructor)

### Properties

- [fromCell](Range.md#fromcell)
- [fromRow](Range.md#fromrow)
- [toCell](Range.md#tocell)
- [toRow](Range.md#torow)

### Methods

- [contains](Range.md#contains)
- [isSingleCell](Range.md#issinglecell)
- [isSingleRow](Range.md#issinglerow)
- [toString](Range.md#tostring)

## Constructors

### constructor

• **new Range**(`fromRow`, `fromCell`, `toRow?`, `toCell?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `fromRow` | `number` |
| `fromCell` | `number` |
| `toRow?` | `number` |
| `toCell?` | `number` |

#### Defined in

[core/range.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;15)

## Properties

### fromCell

• **fromCell**: `number`

#### Defined in

[core/range.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;11)

___

### fromRow

• **fromRow**: `number`

#### Defined in

[core/range.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;10)

___

### toCell

• **toCell**: `number`

#### Defined in

[core/range.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;13)

___

### toRow

• **toRow**: `number`

#### Defined in

[core/range.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;12)

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

[core/range.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;44)

___

### isSingleCell

▸ **isSingleCell**(): `boolean`

Returns whether a range represents a single cell.

#### Returns

`boolean`

#### Defined in

[core/range.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;37)

___

### isSingleRow

▸ **isSingleRow**(): `boolean`

Returns whether a range represents a single row.

#### Returns

`boolean`

#### Defined in

[core/range.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;30)

___

### toString

▸ **toString**(): `string`

Returns a readable representation of a range.

#### Returns

`string`

#### Defined in

[core/range.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/core/range.ts#line&#x3D;52)
