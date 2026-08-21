[@serenity-is/sleekgrid](../README.md) / DraggableOption

# Interface: DraggableOption

Defined in: [src/core/draggable.ts:59](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L59)

Options for the [Draggable](../functions/Draggable.md) helper.

## Properties

### allowDragFrom?

> `optional` **allowDragFrom**: `string`

Defined in: [src/core/draggable.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L70)

When defined, dragging is only allowed when the mousedown target
matches this CSS selector (checked via `Element.matches()`).

***

### allowDragFromClosest?

> `optional` **allowDragFromClosest**: `string`

Defined in: [src/core/draggable.ts:76](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L76)

When defined, dragging is allowed when the mousedown target or one of its
closest ancestors matches this selector (checked via `Element.closest()`).

***

### containerElement?

> `optional` **containerElement**: `Document` \| `HTMLElement`

Defined in: [src/core/draggable.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L64)

Container DOM element to listen for mousedown/touchstart on.
Defaults to `document.body` when omitted.

***

### onDrag()?

> `optional` **onDrag**: (`e`, `dd`) => `boolean` \| `void`

Defined in: [src/core/draggable.ts:103](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L103)

Invoked on every pointer move while dragging.

#### Parameters

##### e

`DragEvent`

Native drag/mouse event.

##### dd

[`DragPosition`](DragPosition.md)

Current drag position and range including live deltas.

#### Returns

`boolean` \| `void`

***

### onDragEnd()?

> `optional` **onDragEnd**: (`e`, `dd`) => `boolean` \| `void`

Defined in: [src/core/draggable.ts:110](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L110)

Invoked when the pointer is released after a drag has started.

#### Parameters

##### e

`DragEvent`

Native drag/mouse event.

##### dd

[`DragPosition`](DragPosition.md)

Final drag position and range.

#### Returns

`boolean` \| `void`

***

### onDragInit()?

> `optional` **onDragInit**: (`e`, `dd`) => `boolean` \| `void`

Defined in: [src/core/draggable.ts:89](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L89)

Invoked on mousedown before any dragging starts. Return `false` to cancel the drag.

#### Parameters

##### e

`DragEvent`

Native drag/mouse event.

##### dd

[`DragPosition`](DragPosition.md)

Current drag position and range.

#### Returns

`boolean` \| `void`

***

### onDragStart()?

> `optional` **onDragStart**: (`e`, `dd`) => `boolean` \| `void`

Defined in: [src/core/draggable.ts:96](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L96)

Invoked the first time the pointer moves after mousedown.

#### Parameters

##### e

`DragEvent`

Native drag/mouse event.

##### dd

[`DragPosition`](DragPosition.md)

Current drag position and range.

#### Returns

`boolean` \| `void`

***

### preventDragFromKeys?

> `optional` **preventDragFromKeys**: (`"altKey"` \| `"ctrlKey"` \| `"metaKey"` \| `"shiftKey"`)[]

Defined in: [src/core/draggable.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/draggable.ts#L82)

Keys that, when pressed during the interaction, prevent draggable events from firing.
Defaults to `['ctrlKey', 'metaKey']` at the call site (e.g. prevents drag when Ctrl is held).
