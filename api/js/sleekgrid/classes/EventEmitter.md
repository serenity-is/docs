[@serenity-is/sleekgrid](../README.md) / EventEmitter

# Class: EventEmitter\<TArgs, TEventData\>

A simple publisher-subscriber implementation.

## Type Parameters

• **TArgs** = `any`

• **TEventData** *extends* [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md)

## Constructors

### new EventEmitter()

> **new EventEmitter**\<`TArgs`, `TEventData`\>(): [`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEventData`\>

#### Returns

[`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEventData`\>

## Methods

### clear()

> **clear**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:105](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L105)

***

### notify()

> **notify**(`args`?, `e`?, `scope`?): `any`

Fires an event notifying all subscribers.

#### Parameters

##### args?

`any`

{Object} Additional data object to be passed to all handlers.

##### e?

`TEventData`

{EventData}
     Optional.
     An <code>EventData</code> object to be passed to all handlers.
     For DOM events, an existing W3C/jQuery event object can be passed in.

##### scope?

`object`

{Object}
     Optional.
     The scope ("this") within which the handler will be executed.
     If not specified, the scope will be set to the <code>Event</code> instance.

#### Returns

`any`

#### Defined in

[core/event.ts:93](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L93)

***

### subscribe()

> **subscribe**(`fn`): `void`

Adds an event handler to be called when the event is fired.
<p>Event handler will receive two arguments - an <code>EventData</code> and the <code>data</code>
object the event was fired with.<p>

#### Parameters

##### fn

(`e`, `args`) => `void`

{Function} Event handler.

#### Returns

`void`

#### Defined in

[core/event.ts:65](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L65)

***

### unsubscribe()

> **unsubscribe**(`fn`): `void`

Removes an event handler added with <code>subscribe(fn)</code>.

#### Parameters

##### fn

(`e`, `args`) => `void`

{Function} Event handler to be removed.

#### Returns

`void`

#### Defined in

[core/event.ts:73](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L73)
