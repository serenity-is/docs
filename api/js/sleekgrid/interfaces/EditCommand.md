[@serenity-is/sleekgrid](../README.md) / EditCommand

# Interface: EditCommand

Defined in: [src/core/editing.ts:115](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L115)

Command produced by an editor commit; supports undo/redo when the grid's
`editCommandHandler` queues it.

## Properties

### cell

> **cell**: `number`

Defined in: [src/core/editing.ts:119](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L119)

Cell/column index that was edited.

***

### editor

> **editor**: [`Editor`](Editor.md)

Defined in: [src/core/editing.ts:121](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L121)

Editor instance that produced the change.

***

### execute()

> **execute**: () => `void`

Defined in: [src/core/editing.ts:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L127)

Applies the edit.

#### Returns

`void`

***

### prevSerializedValue

> **prevSerializedValue**: `any`

Defined in: [src/core/editing.ts:125](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L125)

Previous serialized value before the edit.

***

### row

> **row**: `number`

Defined in: [src/core/editing.ts:117](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L117)

Row index that was edited.

***

### serializedValue

> **serializedValue**: `any`

Defined in: [src/core/editing.ts:123](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L123)

New serialized value from the editor.

***

### undo()

> **undo**: () => `void`

Defined in: [src/core/editing.ts:129](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L129)

Reverts the edit.

#### Returns

`void`
