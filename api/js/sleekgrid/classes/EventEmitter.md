[@serenity-is/sleekgrid](../README.md) / EventEmitter

# Class: EventEmitter\<TArgs, TEvent\>

Defined in: [src/core/event.ts:217](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L217)

Lightweight publish–subscribe implementation used for all SleekGrid events.

## Type Parameters

### TArgs

`TArgs` = `any`

Payload type.

### TEvent

`TEvent` = \{ \}

Wrapped native event type.

## Constructors

### Constructor

> **new EventEmitter**\<`TArgs`, `TEvent`\>(): `EventEmitter`\<`TArgs`, `TEvent`\>

#### Returns

`EventEmitter`\<`TArgs`, `TEvent`\>

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/core/event.ts:262](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L262)

Removes all registered handlers.

#### Returns

`void`

***

### notify()

> **notify**(`args?`, `e?`, `scope?`): [`EventData`](../type-aliases/EventData.md)\<`TArgs`, `TEvent`\>

Defined in: [src/core/event.ts:249](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L249)

Fires the event, invoking all subscribers in order until propagation is stopped.

#### Parameters

##### args?

`TArgs`

Payload passed to handlers as `e.args`.

##### e?

`TEvent`

Optional native DOM event to wrap.

##### scope?

`object`

`this` value for handlers; defaults to the emitter itself.

#### Returns

[`EventData`](../type-aliases/EventData.md)\<`TArgs`, `TEvent`\>

The [EventData](../type-aliases/EventData.md) object created for this notification (carries return values and propagation flags).

***

### subscribe()

> **subscribe**(`fn`): `void`

Defined in: [src/core/event.ts:226](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L226)

Registers an event handler to be invoked when the event is fired.
Handlers receive `(eventData, args)` and run in insertion order.

#### Parameters

##### fn

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

Handler to register.

#### Returns

`void`

***

### unsubscribe()

> **unsubscribe**(`fn`): `void`

Defined in: [src/core/event.ts:234](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L234)

Removes a previously registered handler.

#### Parameters

##### fn

[`EventCallback`](../type-aliases/EventCallback.md)\<`TArgs`, `TEvent`\>

Handler to remove; must be the exact function reference passed to [EventEmitter.subscribe](#subscribe).

#### Returns

`void`
