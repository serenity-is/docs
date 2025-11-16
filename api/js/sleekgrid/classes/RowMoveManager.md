[serenity-is/sleekgrid](../README.md) / RowMoveManager

# Class: RowMoveManager

Defined in: [src/plugins/rowmovemanager.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L21)

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)

## Constructors

### Constructor

> **new RowMoveManager**(`options?`): `RowMoveManager`

Defined in: [src/plugins/rowmovemanager.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L29)

#### Parameters

##### options?

[`RowMoveManagerOptions`](../interfaces/RowMoveManagerOptions.md)

#### Returns

`RowMoveManager`

## Properties

### onBeforeMoveRows

> **onBeforeMoveRows**: [`EventEmitter`](EventEmitter.md)\<[`ArgsMoveRows`](../interfaces/ArgsMoveRows.md), \{ \}\>

Defined in: [src/plugins/rowmovemanager.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L26)

***

### onMoveRows

> **onMoveRows**: [`EventEmitter`](EventEmitter.md)\<[`ArgsMoveRows`](../interfaces/ArgsMoveRows.md), \{ \}\>

Defined in: [src/plugins/rowmovemanager.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L27)

***

### defaults

> `readonly` `static` **defaults**: [`RowMoveManagerOptions`](../interfaces/RowMoveManagerOptions.md)

Defined in: [src/plugins/rowmovemanager.ts:33](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L33)

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/plugins/rowmovemanager.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L46)

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`destroy`](../interfaces/GridPlugin.md#destroy)

***

### init()

> **init**(`grid`): `void`

Defined in: [src/plugins/rowmovemanager.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L37)

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`init`](../interfaces/GridPlugin.md#init)
