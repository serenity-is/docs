[serenity-is/sleekgrid](../README.md) / CellRange

# Class: CellRange

Defined in: [src/core/cellrange.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L8)

## Constructors

### Constructor

> **new CellRange**(`fromRow`, `fromCell`, `toRow?`, `toCell?`): `CellRange`

Defined in: [src/core/cellrange.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L15)

#### Parameters

##### fromRow

`number`

##### fromCell

`number`

##### toRow?

`number`

##### toCell?

`number`

#### Returns

`CellRange`

## Properties

### fromCell

> **fromCell**: `number`

Defined in: [src/core/cellrange.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L11)

***

### fromRow

> **fromRow**: `number`

Defined in: [src/core/cellrange.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L10)

***

### toCell

> **toCell**: `number`

Defined in: [src/core/cellrange.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L13)

***

### toRow

> **toRow**: `number`

Defined in: [src/core/cellrange.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L12)

## Methods

### contains()

> **contains**(`row`, `cell`): `boolean`

Defined in: [src/core/cellrange.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L44)

Returns whether a range contains a given cell.

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`boolean`

***

### isSingleCell()

> **isSingleCell**(): `boolean`

Defined in: [src/core/cellrange.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L37)

Returns whether a range represents a single cell.

#### Returns

`boolean`

***

### isSingleRow()

> **isSingleRow**(): `boolean`

Defined in: [src/core/cellrange.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L30)

Returns whether a range represents a single row.

#### Returns

`boolean`

***

### toString()

> **toString**(): `string`

Defined in: [src/core/cellrange.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L52)

Returns a readable representation of a range.

#### Returns

`string`
