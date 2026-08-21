[@serenity-is/sleekgrid](../README.md) / ArgsColumnNode

# Interface: ArgsColumnNode

Defined in: [src/core/eventargs.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L35)

Payload for events that reference both a column and its DOM node.

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

### node

> **node**: `HTMLElement`

Defined in: [src/core/eventargs.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L37)

Header/footer cell node for the column.
