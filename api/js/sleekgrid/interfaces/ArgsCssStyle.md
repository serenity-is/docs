[@serenity-is/sleekgrid](../README.md) / ArgsCssStyle

# Interface: ArgsCssStyle

Defined in: [src/core/eventargs.ts:83](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L83)

Payload for `onCellCssStylesChanged` / cell-style setter events.

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

### hash

> **hash**: [`CellStylesHash`](../type-aliases/CellStylesHash.md)

Defined in: [src/core/eventargs.ts:87](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L87)

Hash of `row -> columnId -> cssClass` describing the new styles.

***

### key

> **key**: `string`

Defined in: [src/core/eventargs.ts:85](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/eventargs.ts#L85)

Style key/bucket name.
