[@serenity-is/sleekgrid](../README.md) / ArgsSelectedRowsChange

# Interface: ArgsSelectedRowsChange

Defined in: [src/core/eventargs.ts:61](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L61)

Payload for `onSelectedRowsChanged`.

## Extends

- [`ArgsGrid`](ArgsGrid.md)

## Properties

### caller

> **caller**: `any`

Defined in: [src/core/eventargs.ts:71](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L71)

Caller token provided by the code that triggered the selection change.

***

### changedSelectedRows

> **changedSelectedRows**: `number`[]

Defined in: [src/core/eventargs.ts:65](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L65)

Rows that became selected in this change.

***

### changedUnselectedRows

> **changedUnselectedRows**: `number`[]

Defined in: [src/core/eventargs.ts:67](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L67)

Rows that became unselected in this change.

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsGrid`](ArgsGrid.md).[`grid`](ArgsGrid.md#grid)

***

### previousSelectedRows

> **previousSelectedRows**: `number`[]

Defined in: [src/core/eventargs.ts:69](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L69)

Selected rows before the change.

***

### rows

> **rows**: `number`[]

Defined in: [src/core/eventargs.ts:63](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L63)

Currently selected row indices after the change.
