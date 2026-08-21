[@serenity-is/sleekgrid](../README.md) / DragItem

# Interface: DragItem

Defined in: [src/core/draggable.ts:19](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L19)

Full drag-state payload passed to drag callbacks; extends [DragPosition](DragPosition.md)
with live deltas and DOM references.

## Extends

- [`DragPosition`](DragPosition.md)

## Properties

### deltaX

> **deltaX**: `number`

Defined in: [src/core/draggable.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L25)

Horizontal delta in pixels since drag start.

***

### deltaY

> **deltaY**: `number`

Defined in: [src/core/draggable.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L27)

Vertical delta in pixels since drag start.

***

### dragHandle

> **dragHandle**: `HTMLElement`

Defined in: [src/core/draggable.ts:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L23)

Element on which the drag gesture started.

***

### dragSource

> **dragSource**: `Document` \| `HTMLElement`

Defined in: [src/core/draggable.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L21)

Element or document that the draggable was bound to.

***

### dragTarget

> **dragTarget**: `HTMLElement`

Defined in: [src/core/draggable.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L29)

Current DOM element under the pointer during the drag.

***

### range

> **range**: [`DragRange`](DragRange.md)

Defined in: [src/core/draggable.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L12)

Logical grid range derived from pointer movement, if applicable.

#### Inherited from

[`DragPosition`](DragPosition.md).[`range`](DragPosition.md#range)

***

### startX

> **startX**: `number`

Defined in: [src/core/draggable.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L8)

Scroll-adjusted X coordinate where the drag started.

#### Inherited from

[`DragPosition`](DragPosition.md).[`startX`](DragPosition.md#startx)

***

### startY

> **startY**: `number`

Defined in: [src/core/draggable.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L10)

Scroll-adjusted Y coordinate where the drag started.

#### Inherited from

[`DragPosition`](DragPosition.md).[`startY`](DragPosition.md#starty)
