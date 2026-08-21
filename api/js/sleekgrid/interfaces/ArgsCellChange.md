[@serenity-is/sleekgrid](../README.md) / ArgsCellChange

# Interface: ArgsCellChange

Defined in: [src/core/eventargs.ts:99](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L99)

Payload for cell-change events where the row item is known.

## Extends

- [`ArgsCell`](ArgsCell.md)

## Extended by

- [`ArgsCellEdit`](ArgsCellEdit.md)

## Properties

### cell

> **cell**: `number`

Defined in: [src/core/eventargs.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L95)

Cell/column index of the event cell.

#### Inherited from

[`ArgsCell`](ArgsCell.md).[`cell`](ArgsCell.md#cell)

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsCell`](ArgsCell.md).[`grid`](ArgsCell.md#grid)

***

### item

> **item**: `any`

Defined in: [src/core/eventargs.ts:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L101)

Data item at `row`.

***

### row

> **row**: `number`

Defined in: [src/core/eventargs.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L93)

Row index of the event cell.

#### Inherited from

[`ArgsCell`](ArgsCell.md).[`row`](ArgsCell.md#row)
