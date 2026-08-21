[@serenity-is/sleekgrid](../README.md) / EventSubscriber

# Class: EventSubscriber

Defined in: [src/core/event.ts:277](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L277)

Aggregates subscriptions across multiple emitters and allows bulk unsubscribe.
Useful for plugins/components that subscribe to many grid events and need
a single `unsubscribeAll()` on destroy.

## Constructors

### Constructor

> **new EventSubscriber**(): `EventSubscriber`

#### Returns

`EventSubscriber`

## Methods

### subscribe()

> **subscribe**\<`TArgs`, `TEvent`\>(`event`, `handler`): `this`

Defined in: [src/core/event.ts:286](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L286)

Subscribes `handler` to `event` and tracks the pair for later bulk cleanup.

#### Type Parameters

##### TArgs

`TArgs`

##### TEvent

`TEvent`

#### Parameters

##### event

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEvent`\>

Emitter to subscribe to.

##### handler

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

Handler to register.

#### Returns

`this`

`this` for chaining.

***

### unsubscribe()

> **unsubscribe**\<`TArgs`, `TEvent`\>(`event`, `handler`): `this`

Defined in: [src/core/event.ts:302](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L302)

Unsubscribes a previously tracked handler.

#### Type Parameters

##### TArgs

`TArgs`

##### TEvent

`TEvent`

#### Parameters

##### event

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEvent`\>

Emitter the handler was subscribed to.

##### handler

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

Handler to remove.

#### Returns

`this`

`this` for chaining.

***

### unsubscribeAll()

> **unsubscribeAll**(): `EventSubscriber`

Defined in: [src/core/event.ts:320](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L320)

Unsubscribes all tracked handlers.

#### Returns

`EventSubscriber`

`this` for chaining.
