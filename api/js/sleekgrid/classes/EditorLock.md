[@serenity-is/sleekgrid](../README.md) / EditorLock

# Class: EditorLock

Defined in: [src/core/editing.ts:210](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L210)

Locking helper that ensures only a single [EditController](../interfaces/EditController.md) is active at a time.
Prevents concurrent edits and validation races; the grid queries this before
navigating, sorting, or scrolling while an edit is open.

## Constructors

### Constructor

> **new EditorLock**(): `EditorLock`

#### Returns

`EditorLock`

## Methods

### activate()

> **activate**(`editController`): `void`

Defined in: [src/core/editing.ts:228](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L228)

Acquires the edit lock for the given controller.
Throws if another controller already holds the lock or if the controller
does not implement the required methods.

#### Parameters

##### editController

[`EditController`](../interfaces/EditController.md)

Controller acquiring the lock.

#### Returns

`void`

***

### cancelCurrentEdit()

> **cancelCurrentEdit**(): `boolean`

Defined in: [src/core/editing.ts:268](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L268)

Attempts to cancel the current edit via the active controller.

#### Returns

`boolean`

`true` if cancelled (or no edit was active).

***

### commitCurrentEdit()

> **commitCurrentEdit**(): `boolean`

Defined in: [src/core/editing.ts:260](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L260)

Attempts to commit the current edit via the active controller.

#### Returns

`boolean`

`true` if committed (or no edit was active), `false` if validation failed.

***

### deactivate()

> **deactivate**(`editController`): `void`

Defined in: [src/core/editing.ts:249](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L249)

Releases the edit lock held by the given controller.
Throws if the controller is not the currently active one.

#### Parameters

##### editController

[`EditController`](../interfaces/EditController.md)

Controller releasing the lock.

#### Returns

`void`

***

### isActive()

> **isActive**(`editController?`): `boolean`

Defined in: [src/core/editing.ts:218](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L218)

Checks whether an edit controller currently holds the edit lock.

#### Parameters

##### editController?

[`EditController`](../interfaces/EditController.md)

Controller to test; when omitted, returns `true` if *any* controller is active.

#### Returns

`boolean`

Whether the given (or any) controller is active.
