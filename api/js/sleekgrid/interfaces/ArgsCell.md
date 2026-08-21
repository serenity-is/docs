[@serenity-is/sleekgrid](../README.md) / ArgsCell

# Interface: ArgsCell

Defined in: [src/core/eventargs.ts:91](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L91)

Payload for events scoped to a specific cell.

## Extends

- [`ArgsGrid`](ArgsGrid.md)

## Extended by

- [`ArgsCellChange`](ArgsCellChange.md)
- [`ArgsValidationError`](ArgsValidationError.md)

## Properties

### cell

> **cell**: `number`

Defined in: [src/core/eventargs.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L95)

Cell/column index of the event cell.

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsGrid`](ArgsGrid.md).[`grid`](ArgsGrid.md#grid)

***

### row

> **row**: `number`

Defined in: [src/core/eventargs.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L93)

Row index of the event cell.
