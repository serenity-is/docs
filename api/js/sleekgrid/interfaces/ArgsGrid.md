[@serenity-is/sleekgrid](../README.md) / ArgsGrid

# Interface: ArgsGrid

Defined in: [src/core/eventargs.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L5)

Base payload for all grid events; carries the originating grid reference.

## Extended by

- [`ArgsColumn`](ArgsColumn.md)
- [`ArgsDrag`](ArgsDrag.md)
- [`ArgsSort`](ArgsSort.md)
- [`ArgsSelectedRowsChange`](ArgsSelectedRowsChange.md)
- [`ArgsScroll`](ArgsScroll.md)
- [`ArgsCssStyle`](ArgsCssStyle.md)
- [`ArgsCell`](ArgsCell.md)
- [`ArgsEditorDestroy`](ArgsEditorDestroy.md)

## Properties

### grid

> **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/eventargs.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L7)

Grid instance that emitted the event.
