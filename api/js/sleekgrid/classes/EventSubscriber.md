[serenity-is/sleekgrid](../README.md) / EventSubscriber

# Class: EventSubscriber

Defined in: [src/core/event.ts:231](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L231)

## Constructors

### Constructor

> **new EventSubscriber**(): `EventSubscriber`

#### Returns

`EventSubscriber`

## Methods

### subscribe()

> **subscribe**\<`TArgs`, `TEvent`\>(`event`, `handler`): `this`

Defined in: [src/core/event.ts:234](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L234)

#### Type Parameters

##### TArgs

`TArgs`

##### TEvent

`TEvent`

#### Parameters

##### event

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEvent`\>

##### handler

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

#### Returns

`this`

***

### unsubscribe()

> **unsubscribe**\<`TArgs`, `TEvent`\>(`event`, `handler`): `this`

Defined in: [src/core/event.ts:244](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L244)

#### Type Parameters

##### TArgs

`TArgs`

##### TEvent

`TEvent`

#### Parameters

##### event

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEvent`\>

##### handler

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

#### Returns

`this`

***

### unsubscribeAll()

> **unsubscribeAll**(): `EventSubscriber`

Defined in: [src/core/event.ts:258](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L258)

#### Returns

`EventSubscriber`
