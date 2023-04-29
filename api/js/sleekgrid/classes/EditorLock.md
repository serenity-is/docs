[@serenity-is/sleekgrid](../README.md) / EditorLock

# Class: EditorLock

A locking helper to track the active edit controller and ensure that only a single controller
can be active at a time.  This prevents a whole class of state and validation synchronization
issues.  An edit controller (such as SleekGrid) can query if an active edit is in progress
and attempt a commit or cancel before proceeding.

## Table of contents

### Constructors

- [constructor](EditorLock.md#constructor)

### Properties

- [activeEditController](EditorLock.md#activeeditcontroller)

### Methods

- [activate](EditorLock.md#activate)
- [cancelCurrentEdit](EditorLock.md#cancelcurrentedit)
- [commitCurrentEdit](EditorLock.md#commitcurrentedit)
- [deactivate](EditorLock.md#deactivate)
- [isActive](EditorLock.md#isactive)

## Constructors

### constructor

• **new EditorLock**()

## Properties

### activeEditController

• `Private` **activeEditController**: [`EditController`](../interfaces/EditController.md)

#### Defined in

[core/editing.ts:98](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;98)

## Methods

### activate

▸ **activate**(`editController`): `void`

Sets the specified edit controller as the active edit controller (acquire edit lock).
If another edit controller is already active, and exception will be thrown.

**`Method`**

activate

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editController` | [`EditController`](../interfaces/EditController.md) | {EditController} edit controller acquiring the lock |

#### Returns

`void`

#### Defined in

[core/editing.ts:117](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;117)

___

### cancelCurrentEdit

▸ **cancelCurrentEdit**(): `boolean`

Attempts to cancel the current edit by calling "cancelCurrentEdit" method on the active edit
controller and returns whether the edit was successfully cancelled.  If no edit controller is
active, returns true.

**`Method`**

cancelCurrentEdit

#### Returns

`boolean`

#### Defined in

[core/editing.ts:165](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;165)

___

### commitCurrentEdit

▸ **commitCurrentEdit**(): `boolean`

Attempts to commit the current edit by calling "commitCurrentEdit" method on the active edit
controller and returns whether the commit attempt was successful (commit may fail due to validation
errors, etc.).  Edit controller's "commitCurrentEdit" must return true if the commit has succeeded
and false otherwise.  If no edit controller is active, returns true.

**`Method`**

commitCurrentEdit

#### Returns

`boolean`

#### Defined in

[core/editing.ts:154](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;154)

___

### deactivate

▸ **deactivate**(`editController`): `void`

Unsets the specified edit controller as the active edit controller (release edit lock).
If the specified edit controller is not the active one, an exception will be thrown.

**`Method`**

deactivate

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editController` | [`EditController`](../interfaces/EditController.md) | {EditController} edit controller releasing the lock |

#### Returns

`void`

#### Defined in

[core/editing.ts:139](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;139)

___

### isActive

▸ **isActive**(`editController?`): `boolean`

Returns true if a specified edit controller is active (has the edit lock).
If the parameter is not specified, returns true if any edit controller is active.

**`Method`**

isActive

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editController?` | [`EditController`](../interfaces/EditController.md) | {EditController} |

#### Returns

`boolean`

#### Defined in

[core/editing.ts:107](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;107)
