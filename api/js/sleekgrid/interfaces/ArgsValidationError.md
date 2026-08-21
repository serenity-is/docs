[@serenity-is/sleekgrid](../README.md) / ArgsValidationError

# Interface: ArgsValidationError

Defined in: [src/core/eventargs.ts:123](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L123)

Payload for `onValidationError`.

## Extends

- [`ArgsCell`](ArgsCell.md)

## Properties

### cell

> **cell**: `number`

Defined in: [src/core/eventargs.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L95)

Cell/column index of the event cell.

#### Inherited from

[`ArgsCell`](ArgsCell.md).[`cell`](ArgsCell.md#cell)

***

### cellNode

> **cellNode**: `HTMLElement`

Defined in: [src/core/eventargs.ts:129](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L129)

DOM node of the failing cell.

***

### column

> **column**: [`Column`](Column.md)

Defined in: [src/core/eventargs.ts:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L127)

Column being validated.

***

### editor

> **editor**: [`Editor`](Editor.md)

Defined in: [src/core/eventargs.ts:125](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L125)

Editor that failed validation.

***

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.

#### Inherited from

[`ArgsCell`](ArgsCell.md).[`grid`](ArgsCell.md#grid)

***

### row

> **row**: `number`

Defined in: [src/core/eventargs.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L93)

Row index of the event cell.

#### Inherited from

[`ArgsCell`](ArgsCell.md).[`row`](ArgsCell.md#row)

***

### validationResults

> **validationResults**: [`ValidationResult`](ValidationResult.md)

Defined in: [src/core/eventargs.ts:131](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L131)

Validation result containing `valid` flag and message.
