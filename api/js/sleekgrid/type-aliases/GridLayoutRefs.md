[@serenity-is/sleekgrid](../README.md) / GridLayoutRefs

# Type Alias: GridLayoutRefs

> **GridLayoutRefs** = `object`

Defined in: [src/layouts/layout-refs.tsx:39](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L39)

Aggregated refs for all bands and derived pinning/frozen indices.

## Properties

### config

> **config**: `object`

Defined in: [src/layouts/layout-refs.tsx:65](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L65)

Writable config inputs; setters trigger createGridSignalsAndRefs recalculation.

#### colCount?

> `optional` **colCount**: `number`

Total column count driving index calculations.

#### dataLength?

> `optional` **dataLength**: `number`

Total data row count driving frozen calculations.

#### frozenBottomRows?

> `optional` **frozenBottomRows**: `number`

Desired bottom-frozen row count.

#### frozenLimit?

> `optional` **frozenLimit**: `number` \| `null`

Maximum total frozen rows, or `null` to allow all.

#### frozenTopRows?

> `optional` **frozenTopRows**: `number`

Desired top-frozen row count.

#### pinnedEndCols?

> `optional` **pinnedEndCols**: `number`

Desired end-pinned column count.

#### pinnedLimit?

> `optional` **pinnedLimit**: `number` \| `null`

Maximum total pinned columns, or `null` to allow all.

#### pinnedStartCols?

> `optional` **pinnedStartCols**: `number`

Desired start-pinned column count.

***

### end

> `readonly` **end**: [`GridBandRefs`](../interfaces/GridBandRefs.md)

Defined in: [src/layouts/layout-refs.tsx:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L45)

Band refs for the pinned-end side.

***

### frozenBottomFirst

> `readonly` **frozenBottomFirst**: `number`

Defined in: [src/layouts/layout-refs.tsx:63](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L63)

First bottom-frozen row index or `Infinity` when none.

***

### frozenBottomRows

> `readonly` **frozenBottomRows**: `number`

Defined in: [src/layouts/layout-refs.tsx:61](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L61)

Number of bottom-frozen rows.

***

### frozenTopLast

> `readonly` **frozenTopLast**: `number`

Defined in: [src/layouts/layout-refs.tsx:59](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L59)

Last top-frozen row index or `-Infinity` when none.

***

### frozenTopRows

> `readonly` **frozenTopRows**: `number`

Defined in: [src/layouts/layout-refs.tsx:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L57)

Number of top-frozen rows.

***

### main

> `readonly` **main**: [`GridBandRefs`](../interfaces/GridBandRefs.md)

Defined in: [src/layouts/layout-refs.tsx:43](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L43)

Band refs for the main (center, scrollable) band.

***

### pinnedEndCols

> `readonly` **pinnedEndCols**: `number`

Defined in: [src/layouts/layout-refs.tsx:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L53)

Number of columns pinned to the end.

***

### pinnedEndFirst

> `readonly` **pinnedEndFirst**: `number`

Defined in: [src/layouts/layout-refs.tsx:55](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L55)

First pinned-end column index or `Infinity` when none.

***

### pinnedStartCols

> `readonly` **pinnedStartCols**: `number`

Defined in: [src/layouts/layout-refs.tsx:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L49)

Number of columns pinned to the start (derived, bounded by `config`).

***

### pinnedStartLast

> `readonly` **pinnedStartLast**: `number`

Defined in: [src/layouts/layout-refs.tsx:51](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L51)

Last pinned-start column index or `-Infinity` when none.

***

### start

> `readonly` **start**: [`GridBandRefs`](../interfaces/GridBandRefs.md)

Defined in: [src/layouts/layout-refs.tsx:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L41)

Band refs for the pinned-start side.

***

### topPanel?

> `optional` **topPanel**: `HTMLElement`

Defined in: [src/layouts/layout-refs.tsx:47](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L47)

Top panel container element, if rendered.
