[@serenity-is/sleekgrid](../README.md) / CellRange

# Class: CellRange

Defined in: [src/core/cellrange.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L6)

Represents a rectangular range of cells in the grid.
Coordinates are inclusive and automatically normalized so that `from*` is always
the top-left corner and `to*` is the bottom-right corner.

## Constructors

### Constructor

> **new CellRange**(`fromRow`, `fromCell`, `toRow?`, `toCell?`): `CellRange`

Defined in: [src/core/cellrange.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L36)

Creates a new cell range. When `toRow` / `toCell` are omitted the range
represents a single cell at `fromRow` / `fromCell`.

#### Parameters

##### fromRow

`number`

Starting row index.

##### fromCell

`number`

Starting cell/column index.

##### toRow?

`number`

Ending row index; defaults to `fromRow`.

##### toCell?

`number`

Ending cell index; defaults to `fromCell`.

#### Returns

`CellRange`

## Properties

### fromCell

> **fromCell**: `number`

Defined in: [src/core/cellrange.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L16)

Left-most cell/column index of the range (inclusive).

***

### fromRow

> **fromRow**: `number`

Defined in: [src/core/cellrange.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L11)

Top-most row index of the range (inclusive).

***

### toCell

> **toCell**: `number`

Defined in: [src/core/cellrange.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L26)

Right-most cell/column index of the range (inclusive).

***

### toRow

> **toRow**: `number`

Defined in: [src/core/cellrange.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L21)

Bottom-most row index of the range (inclusive).

## Methods

### contains()

> **contains**(`row`, `cell`): `boolean`

Defined in: [src/core/cellrange.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L70)

Tests whether the range contains the given cell.

#### Parameters

##### row

`number`

Row index to test.

##### cell

`number`

Cell/column index to test.

#### Returns

`boolean`

`true` if the cell lies inside the range (inclusive bounds).

***

### isSingleCell()

> **isSingleCell**(): `boolean`

Defined in: [src/core/cellrange.ts:60](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L60)

Returns `true` when the range covers exactly one cell.

#### Returns

`boolean`

Whether the range is a single cell.

***

### isSingleRow()

> **isSingleRow**(): `boolean`

Defined in: [src/core/cellrange.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L52)

Returns `true` when the range spans exactly one row.

#### Returns

`boolean`

Whether the range covers a single row.

***

### toString()

> **toString**(): `string`

Defined in: [src/core/cellrange.ts:80](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellrange.ts#L80)

Returns a human-readable representation, e.g. `"(2:3)"` for a single cell
or `"(0:0 - 4:5)"` for a multi-cell range.

#### Returns

`string`

Readable string for debugging/logging.
