[@serenity-is/sleekgrid](../README.md) / ArgsSort

# Interface: ArgsSort

Defined in: [src/core/eventargs.ts:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L49)

Payload for `onSort` events.

## Extends

- [`ArgsGrid`](ArgsGrid.md)

## Properties

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsGrid`](ArgsGrid.md).[`grid`](ArgsGrid.md#grid)

***

### multiColumnSort

> **multiColumnSort**: `boolean`

Defined in: [src/core/eventargs.ts:51](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L51)

Whether multiple columns are being sorted.

***

### sortAsc

> **sortAsc**: `boolean`

Defined in: [src/core/eventargs.ts:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L53)

Primary sort direction (for single-column sort).

***

### sortCol

> **sortCol**: [`Column`](Column.md)

Defined in: [src/core/eventargs.ts:55](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L55)

Primary sort column (for single-column sort).

***

### sortCols

> **sortCols**: [`ArgsSortCol`](../type-aliases/ArgsSortCol.md)[]

Defined in: [src/core/eventargs.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L57)

All active sort columns for multi-sort.
