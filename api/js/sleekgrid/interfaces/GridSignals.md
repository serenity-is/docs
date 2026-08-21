[@serenity-is/sleekgrid](../README.md) / GridSignals

# Interface: GridSignals

Defined in: [src/core/grid-signals.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L8)

Reactive signals surface for the grid's chrome and pinning state.
Backed by `@serenity-is/domwise` signals and used internally by the grid
and layout engine to drive visibility and pinning.

## Properties

### frozenBottomRows

> `readonly` **frozenBottomRows**: `Signal`\<`number`\>

Defined in: [src/core/grid-signals.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L32)

Number of rows frozen at the bottom of the viewport.

***

### frozenTopRows

> `readonly` **frozenTopRows**: `Signal`\<`number`\>

Defined in: [src/core/grid-signals.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L30)

Number of rows frozen at the top of the viewport.

***

### hideColumnHeader

> `readonly` **hideColumnHeader**: `Computed`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L12)

Inverse of [GridSignals.showColumnHeader](#showcolumnheader); `true` when the header is hidden.

***

### hideFooterRow

> `readonly` **hideFooterRow**: `Computed`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L24)

Inverse of [GridSignals.showFooterRow](#showfooterrow).

***

### hideHeaderRow

> `readonly` **hideHeaderRow**: `Computed`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L20)

Inverse of [GridSignals.showHeaderRow](#showheaderrow).

***

### hideTopPanel

> `readonly` **hideTopPanel**: `Computed`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L16)

Inverse of [GridSignals.showTopPanel](#showtoppanel).

***

### pinnedEndCols

> `readonly` **pinnedEndCols**: `Signal`\<`number`\>

Defined in: [src/core/grid-signals.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L28)

Number of columns pinned to the end (right in LTR, left in RTL) side.

***

### pinnedStartCols

> `readonly` **pinnedStartCols**: `Signal`\<`number`\>

Defined in: [src/core/grid-signals.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L26)

Number of columns pinned to the start (left in LTR, right in RTL) side.

***

### showColumnHeader

> `readonly` **showColumnHeader**: `Signal`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L10)

Whether the column header row is visible.

***

### showFooterRow

> `readonly` **showFooterRow**: `Signal`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L22)

Whether the footer row is visible.

***

### showHeaderRow

> `readonly` **showHeaderRow**: `Signal`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L18)

Whether the header row (filter row) is visible.

***

### showTopPanel

> `readonly` **showTopPanel**: `Signal`\<`boolean`\>

Defined in: [src/core/grid-signals.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-signals.ts#L14)

Whether the top panel row is visible.
