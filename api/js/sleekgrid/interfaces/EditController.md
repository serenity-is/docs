[@serenity-is/sleekgrid](../README.md) / EditController

# Interface: EditController

Defined in: [src/core/editing.ts:192](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L192)

Active edit controller implemented by the grid; managed by [EditorLock](../classes/EditorLock.md).

## Methods

### cancelCurrentEdit()

> **cancelCurrentEdit**(): `boolean`

Defined in: [src/core/editing.ts:202](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L202)

Cancels the current edit if any.

#### Returns

`boolean`

`true` if cancelled or no edit was active.

***

### commitCurrentEdit()

> **commitCurrentEdit**(): `boolean`

Defined in: [src/core/editing.ts:197](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L197)

Commits the current edit if any.

#### Returns

`boolean`

`true` if committed or no edit was active, `false` if validation failed.
