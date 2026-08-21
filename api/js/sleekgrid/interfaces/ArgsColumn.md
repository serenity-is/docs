[@serenity-is/sleekgrid](../README.md) / ArgsColumn

# Interface: ArgsColumn

Defined in: [src/core/eventargs.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L11)

Payload for events associated with a specific column.

## Extends

- [`ArgsGrid`](ArgsGrid.md)

## Extended by

- [`ArgsColumnNode`](ArgsColumnNode.md)
- [`ArgsAddNewRow`](ArgsAddNewRow.md)

## Properties

### column

> **column**: [`Column`](Column.md)

Defined in: [src/core/eventargs.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L13)

Column related to the event.

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsGrid`](ArgsGrid.md).[`grid`](ArgsGrid.md#grid)
