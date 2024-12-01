[@serenity-is/sleekgrid](../README.md) / RowMoveManager

# Class: RowMoveManager

## Implements

- [`IPlugin`](../interfaces/IPlugin.md)

## Constructors

### new RowMoveManager()

> **new RowMoveManager**(`options`?): [`RowMoveManager`](RowMoveManager.md)

#### Parameters

##### options?

[`RowMoveManagerOptions`](../interfaces/RowMoveManagerOptions.md)

#### Returns

[`RowMoveManager`](RowMoveManager.md)

#### Defined in

[plugins/rowmovemanager.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowmovemanager.ts#L29)

## Properties

### onBeforeMoveRows

> **onBeforeMoveRows**: [`EventEmitter`](EventEmitter.md)\<`ArgsMoveRows`, [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[plugins/rowmovemanager.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowmovemanager.ts#L26)

***

### onMoveRows

> **onMoveRows**: [`EventEmitter`](EventEmitter.md)\<`ArgsMoveRows`, [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[plugins/rowmovemanager.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowmovemanager.ts#L27)

***

### defaults

> `readonly` `static` **defaults**: [`RowMoveManagerOptions`](../interfaces/RowMoveManagerOptions.md)

#### Defined in

[plugins/rowmovemanager.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowmovemanager.ts#L33)

## Methods

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Implementation of

[`IPlugin`](../interfaces/IPlugin.md).[`destroy`](../interfaces/IPlugin.md#destroy)

#### Defined in

[plugins/rowmovemanager.ts:45](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowmovemanager.ts#L45)

***

### init()

> **init**(`grid`): `void`

#### Parameters

##### grid

[`Grid`](Grid.md)\<`any`\>

#### Returns

`void`

#### Implementation of

[`IPlugin`](../interfaces/IPlugin.md).[`init`](../interfaces/IPlugin.md#init)

#### Defined in

[plugins/rowmovemanager.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowmovemanager.ts#L37)
