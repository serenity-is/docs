[@serenity-is/sleekgrid](../README.md) / ArgsDrag

# Interface: ArgsDrag

Defined in: [src/core/eventargs.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L17)

Payload for drag lifecycle events (drag init/start/drag/end).

## Extends

- [`ArgsGrid`](ArgsGrid.md)

## Properties

### cell

> **cell**: `number`

Defined in: [src/core/eventargs.ts:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L23)

Cell/column index where the drag originated.

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsGrid`](ArgsGrid.md).[`grid`](ArgsGrid.md#grid)

***

### helper

> **helper**: `HTMLElement`

Defined in: [src/core/eventargs.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L27)

Visual helper element following the pointer during the drag.

***

### item

> **item**: `any`

Defined in: [src/core/eventargs.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L25)

Data item at `row`.

***

### mode

> **mode**: `string`

Defined in: [src/core/eventargs.ts:19](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L19)

Drag mode/category (e.g. `"cell"`, `"column"`).

***

### row

> **row**: `number`

Defined in: [src/core/eventargs.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L21)

Row index where the drag originated.
