[@serenity-is/sleekgrid](../README.md) / GridBandRefs

# Interface: GridBandRefs

Defined in: [src/layouts/layout-refs.tsx:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L12)

DOM and layout state for a single horizontal band (`start`/`main`/`end`).

## Properties

### canvas

> **canvas**: `object`

Defined in: [src/layouts/layout-refs.tsx:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L20)

Canvas elements per vertical pane.

#### body

> **body**: `HTMLElement`

Main body viewport canvas.

#### bottom?

> `optional` **bottom**: `HTMLElement`

Bottom-frozen pane canvas, if enabled.

#### top?

> `optional` **top**: `HTMLElement`

Top-frozen pane canvas, if enabled.

***

### canvasWidth

> **canvasWidth**: `number`

Defined in: [src/layouts/layout-refs.tsx:33](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L33)

Measured canvas width for this band in pixels.

***

### cellOffset

> `readonly` **cellOffset**: `number`

Defined in: [src/layouts/layout-refs.tsx:31](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L31)

Column index offset for cells inside this band (e.g. pinned count).

***

### footerRowCols?

> `optional` **footerRowCols**: `HTMLElement`

Defined in: [src/layouts/layout-refs.tsx:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L29)

Footer row column container, if rendered.

***

### headerCols?

> `optional` **headerCols**: `HTMLElement`

Defined in: [src/layouts/layout-refs.tsx:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L16)

Header column container for this band, if rendered.

***

### headerRowCols?

> `optional` **headerRowCols**: `HTMLElement`

Defined in: [src/layouts/layout-refs.tsx:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L18)

Header-row (filter row) column container, if rendered.

***

### key

> **key**: [`BandKey`](../type-aliases/BandKey.md)

Defined in: [src/layouts/layout-refs.tsx:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L14)

Band identifier.
