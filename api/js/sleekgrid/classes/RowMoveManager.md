[@serenity-is/sleekgrid](../README.md) / RowMoveManager

# Class: RowMoveManager

Defined in: [src/plugins/rowmovemanager.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L35)

Drag-and-drop plugin that lets users reorder rows via a proxy and guide.
Works only when the target column `behavior` is `"move"` or `"selectAndMove"`.
Emits [RowMoveManager.onBeforeMoveRows](#onbeforemoverows) (cancelable) and [RowMoveManager.onMoveRows](#onmoverows).

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)

## Constructors

### Constructor

> **new RowMoveManager**(`options?`): `RowMoveManager`

Defined in: [src/plugins/rowmovemanager.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L52)

Creates the manager.

#### Parameters

##### options?

[`RowMoveManagerOptions`](../interfaces/RowMoveManagerOptions.md)

Partial options merged with [RowMoveManager.defaults](#defaults).

#### Returns

`RowMoveManager`

## Properties

### onBeforeMoveRows

> **onBeforeMoveRows**: [`EventEmitter`](EventEmitter.md)\<[`ArgsMoveRows`](../interfaces/ArgsMoveRows.md)\>

Defined in: [src/plugins/rowmovemanager.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L44)

Fired before the drop position is accepted; handlers may return `false` to reject the insertion point.

***

### onMoveRows

> **onMoveRows**: [`EventEmitter`](EventEmitter.md)\<[`ArgsMoveRows`](../interfaces/ArgsMoveRows.md)\>

Defined in: [src/plugins/rowmovemanager.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L46)

Fired on successful drop; subscribers should reorder data accordingly.

***

### defaults

> `readonly` `static` **defaults**: [`RowMoveManagerOptions`](../interfaces/RowMoveManagerOptions.md)

Defined in: [src/plugins/rowmovemanager.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L57)

Default option values.

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/plugins/rowmovemanager.ts:77](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L77)

Unsubscribes all grid drag handlers.

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`destroy`](../interfaces/GridPlugin.md#destroy)

***

### init()

> **init**(`grid`): `void`

Defined in: [src/plugins/rowmovemanager.ts:65](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L65)

Subscribes to the grid's drag lifecycle to implement row moving.

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

Host grid instance.

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`init`](../interfaces/GridPlugin.md#init)
