[@serenity-is/sleekgrid](../README.md) / EventEmitter

# Class: EventEmitter\<TArgs, TEvent\>

Defined in: [src/core/event.ts:173](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L173)

A simple publisher-subscriber implementation.

## Type Parameters

### TArgs

`TArgs` = `any`

### TEvent

`TEvent` = \{ \}

## Constructors

### Constructor

> **new EventEmitter**\<`TArgs`, `TEvent`\>(): `EventEmitter`\<`TArgs`, `TEvent`\>

#### Returns

`EventEmitter`\<`TArgs`, `TEvent`\>

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/core/event.ts:221](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L221)

#### Returns

`void`

***

### notify()

> **notify**(`args?`, `e?`, `scope?`): [`EventData`](../type-aliases/EventData.md)\<`TArgs`, `TEvent`\>

Defined in: [src/core/event.ts:211](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L211)

Fires an event notifying all subscribers.

#### Parameters

##### args?

`TArgs`

{Object} Additional data object to be passed to all handlers.

##### e?

`TEvent`

{EventDataWrapper}
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

[`EventData`](../type-aliases/EventData.md)\<`TArgs`, `TEvent`\>

***

### subscribe()

> **subscribe**(`fn`): `void`

Defined in: [src/core/event.ts:183](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L183)

Adds an event handler to be called when the event is fired.
<p>Event handler will receive two arguments - an <code>EventData</code> and the <code>data</code>
object the event was fired with.<p>

#### Parameters

##### fn

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

{Function} Event handler.

#### Returns

`void`

***

### unsubscribe()

> **unsubscribe**(`fn`): `void`

Defined in: [src/core/event.ts:191](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L191)

Removes an event handler added with <code>subscribe(fn)</code>.

#### Parameters

##### fn

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

{Function} Event handler to be removed.

#### Returns

`void`
