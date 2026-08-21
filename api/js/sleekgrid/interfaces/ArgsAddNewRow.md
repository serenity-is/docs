[@serenity-is/sleekgrid](../README.md) / ArgsAddNewRow

# Interface: ArgsAddNewRow

Defined in: [src/core/eventargs.ts:111](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L111)

Payload for `onAddNewRow`.

## Extends

- [`ArgsColumn`](ArgsColumn.md)

## Properties

### column

> **column**: [`Column`](Column.md)

Defined in: [src/core/eventargs.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L13)

Column related to the event.

#### Inherited from

[`ArgsColumn`](ArgsColumn.md).[`column`](ArgsColumn.md#column)

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsColumn`](ArgsColumn.md).[`grid`](ArgsColumn.md#grid)

***

### item

> **item**: `any`

Defined in: [src/core/eventargs.ts:113](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L113)

Provisional new data item being added.
