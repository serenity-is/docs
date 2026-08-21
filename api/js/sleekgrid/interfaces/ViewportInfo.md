[@serenity-is/sleekgrid](../README.md) / ViewportInfo

# Interface: ViewportInfo

Defined in: [src/core/viewportinfo.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L5)

Computed layout metrics for the grid viewport. Calculated during `computeViewportInfo()`
and used to size canvases, set scroll extents and decide virtualization bounds.

## Properties

### footerRowHeight

> **footerRowHeight**: `number`

Defined in: [src/core/viewportinfo.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L27)

Height of the footer row in pixels.

***

### groupingPanelHeight

> **groupingPanelHeight**: `number`

Defined in: [src/core/viewportinfo.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L17)

Height of the grouping panel in pixels.

***

### hasHScroll

> **hasHScroll**: `boolean`

Defined in: [src/core/viewportinfo.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L13)

Whether a horizontal scrollbar is currently present.

***

### hasVScroll

> **hasVScroll**: `boolean`

Defined in: [src/core/viewportinfo.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L11)

Whether a vertical scrollbar is currently present.

***

### headerHeight

> **headerHeight**: `number`

Defined in: [src/core/viewportinfo.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L15)

Height of the column header row in pixels.

***

### headerRowHeight

> **headerRowHeight**: `number`

Defined in: [src/core/viewportinfo.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L25)

Height of the header-row (filter row) in pixels.

***

### height

> **height**: `number`

Defined in: [src/core/viewportinfo.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L7)

Height of the scrollable viewport in pixels.

***

### numVisibleRows

> **numVisibleRows**: `number`

Defined in: [src/core/viewportinfo.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L29)

Number of rows estimated to fit in the current viewport (`ceil(height/rowHeight)+1`).

***

### realScrollHeight

> **realScrollHeight**: `number`

Defined in: [src/core/viewportinfo.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L21)

Actual scrollable height applied to the canvas (capped for very large data sets).

***

### topPanelHeight

> **topPanelHeight**: `number`

Defined in: [src/core/viewportinfo.ts:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L23)

Height of the top panel in pixels.

***

### virtualHeight

> **virtualHeight**: `number`

Defined in: [src/core/viewportinfo.ts:19](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L19)

Total virtual height of all rows (`rowHeight * rowCount`), before capping.

***

### width

> **width**: `number`

Defined in: [src/core/viewportinfo.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewportinfo.ts#L9)

Width of the scrollable viewport in pixels.
