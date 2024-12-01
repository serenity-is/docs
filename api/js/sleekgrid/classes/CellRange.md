[@serenity-is/sleekgrid](../README.md) / CellRange

# Class: CellRange

## Constructors

### new CellRange()

> **new CellRange**(`fromRow`, `fromCell`, `toRow`?, `toCell`?): [`CellRange`](CellRange.md)

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

[`CellRange`](CellRange.md)

#### Defined in

[core/cellrange.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L15)

## Properties

### fromCell

> **fromCell**: `number`

#### Defined in

[core/cellrange.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L11)

***

### fromRow

> **fromRow**: `number`

#### Defined in

[core/cellrange.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L10)

***

### toCell

> **toCell**: `number`

#### Defined in

[core/cellrange.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L13)

***

### toRow

> **toRow**: `number`

#### Defined in

[core/cellrange.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L12)

## Methods

### contains()

> **contains**(`row`, `cell`): `boolean`

Returns whether a range contains a given cell.

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`boolean`

#### Defined in

[core/cellrange.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L44)

***

### isSingleCell()

> **isSingleCell**(): `boolean`

Returns whether a range represents a single cell.

#### Returns

`boolean`

#### Defined in

[core/cellrange.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L37)

***

### isSingleRow()

> **isSingleRow**(): `boolean`

Returns whether a range represents a single row.

#### Returns

`boolean`

#### Defined in

[core/cellrange.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L30)

***

### toString()

> **toString**(): `string`

Returns a readable representation of a range.

#### Returns

`string`

#### Defined in

[core/cellrange.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/core/cellrange.ts#L52)
