[@serenity-is/sleekgrid](../README.md) / Draggable

# Function: Draggable()

> **Draggable**(`options`): `object`

Defined in: [src/core/draggable.ts:120](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L120)

Attaches lightweight mouse/touch drag handling to a container element without jQuery.
Listens for mousedown/touchstart on `containerElement` and translates movements
into the `onDrag*` callbacks in [DraggableOption](../interfaces/DraggableOption.md).

## Parameters

### options

[`DraggableOption`](../interfaces/DraggableOption.md)

Configuration controlling drag source, filters and callbacks.

## Returns

Handle with a `destroy` method to remove all listeners.

### destroy()

> **destroy**: () => `void`

Removes all event listeners installed by this draggable instance.

#### Returns

`void`
