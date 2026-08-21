[@serenity-is/sleekgrid](../README.md) / ArgsCellEdit

# Interface: ArgsCellEdit

Defined in: [src/core/eventargs.ts:105](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L105)

Payload for cell-edit lifecycle events.

## Extends

- [`ArgsCellChange`](ArgsCellChange.md)

## Properties

### cell

> **cell**: `number`

Defined in: [src/core/eventargs.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L95)

Cell/column index of the event cell.

#### Inherited from

[`ArgsCellChange`](ArgsCellChange.md).[`cell`](ArgsCellChange.md#cell)

***

### column

> **column**: [`Column`](Column.md)

Defined in: [src/core/eventargs.ts:107](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L107)

Column definition for `cell`.

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsCellChange`](ArgsCellChange.md).[`grid`](ArgsCellChange.md#grid)

***

### item

> **item**: `any`

Defined in: [src/core/eventargs.ts:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L101)

Data item at `row`.

#### Inherited from

[`ArgsCellChange`](ArgsCellChange.md).[`item`](ArgsCellChange.md#item)

***

### row

> **row**: `number`

Defined in: [src/core/eventargs.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L93)

Row index of the event cell.

#### Inherited from

[`ArgsCellChange`](ArgsCellChange.md).[`row`](ArgsCellChange.md#row)
