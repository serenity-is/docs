[@serenity-is/sleekgrid](../README.md) / EventSubscriber

# Class: EventSubscriber\<TArgs, TEventData\>

## Type Parameters

• **TArgs** = `any`

• **TEventData** *extends* [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md)

## Constructors

### new EventSubscriber()

> **new EventSubscriber**\<`TArgs`, `TEventData`\>(): [`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

#### Returns

[`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

## Methods

### subscribe()

> **subscribe**(`event`, `handler`): `this`

#### Parameters

##### event

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEventData`\>

##### handler

(`e`, `args`) => `void`

#### Returns

`this`

#### Defined in

[core/event.ts:118](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L118)

***

### unsubscribe()

> **unsubscribe**(`event`, `handler`): `this`

#### Parameters

##### event

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEventData`\>

##### handler

(`e`, `args`) => `void`

#### Returns

`this`

#### Defined in

[core/event.ts:128](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L128)

***

### unsubscribeAll()

> **unsubscribeAll**(): [`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

#### Returns

[`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

#### Defined in

[core/event.ts:142](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L142)
