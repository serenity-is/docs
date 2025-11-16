[sleekgrid](../README.md) / EditorLock

# Class: EditorLock

Defined in: [src/core/editing.ts:97](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L97)

A locking helper to track the active edit controller and ensure that only a single controller
can be active at a time.  This prevents a whole class of state and validation synchronization
issues.  An edit controller (such as SleekGrid) can query if an active edit is in progress
and attempt a commit or cancel before proceeding.
 EditorLock

## Constructors

### Constructor

> **new EditorLock**(): `EditorLock`

#### Returns

`EditorLock`

## Methods

### activate()

> **activate**(`editController`): `void`

Defined in: [src/core/editing.ts:115](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L115)

Sets the specified edit controller as the active edit controller (acquire edit lock).
If another edit controller is already active, and exception will be thrown.

#### Parameters

##### editController

[`EditController`](../interfaces/EditController.md)

{EditController} edit controller acquiring the lock

#### Returns

`void`

***

### cancelCurrentEdit()

> **cancelCurrentEdit**(): `boolean`

Defined in: [src/core/editing.ts:160](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L160)

Attempts to cancel the current edit by calling "cancelCurrentEdit" method on the active edit
controller and returns whether the edit was successfully cancelled.  If no edit controller is
active, returns true.

#### Returns

`boolean`

***

### commitCurrentEdit()

> **commitCurrentEdit**(): `boolean`

Defined in: [src/core/editing.ts:150](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L150)

Attempts to commit the current edit by calling "commitCurrentEdit" method on the active edit
controller and returns whether the commit attempt was successful (commit may fail due to validation
errors, etc.).  Edit controller's "commitCurrentEdit" must return true if the commit has succeeded
and false otherwise.  If no edit controller is active, returns true.

#### Returns

`boolean`

***

### deactivate()

> **deactivate**(`editController`): `void`

Defined in: [src/core/editing.ts:136](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L136)

Unsets the specified edit controller as the active edit controller (release edit lock).
If the specified edit controller is not the active one, an exception will be thrown.

#### Parameters

##### editController

[`EditController`](../interfaces/EditController.md)

{EditController} edit controller releasing the lock

#### Returns

`void`

***

### isActive()

> **isActive**(`editController?`): `boolean`

Defined in: [src/core/editing.ts:106](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L106)

Returns true if a specified edit controller is active (has the edit lock).
If the parameter is not specified, returns true if any edit controller is active.

#### Parameters

##### editController?

[`EditController`](../interfaces/EditController.md)

{EditController}

#### Returns

`boolean`
