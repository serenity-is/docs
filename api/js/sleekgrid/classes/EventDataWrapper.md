[@serenity-is/sleekgrid](../README.md) / EventDataWrapper

# Class: EventDataWrapper\<TArgs, TEvent\>

Defined in: [src/core/event.ts:118](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L118)

Wraps a native DOM event and a payload object, exposing propagation controls.
Property access for common DOM fields (e.g. `clientX`, `key`, `target`) and arg keys
(`grid`, `row`, `cell`) is dynamically proxied via getters installed by
`initializeEventDataProps()`.

## Type Parameters

### TArgs

`TArgs`

Event payload type.

### TEvent

`TEvent` = \{ \}

Wrapped native event type.

## Implements

- [`IEventData`](../interfaces/IEventData.md)\<`TArgs`, `TEvent`\>

## Constructors

### Constructor

> **new EventDataWrapper**\<`TArgs`, `TEvent`\>(`event?`, `args?`): `EventDataWrapper`\<`TArgs`, `TEvent`\>

Defined in: [src/core/event.ts:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L127)

#### Parameters

##### event?

`TEvent`

##### args?

`TArgs`

#### Returns

`EventDataWrapper`\<`TArgs`, `TEvent`\>

## Accessors

### args

#### Get Signature

> **get** **args**(): `TArgs`

Defined in: [src/core/event.ts:189](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L189)

Payload supplied by the event emitter (e.g. `{row, cell, grid}`).

##### Returns

`TArgs`

Payload supplied by the event emitter (e.g. `{row, cell, grid}`).

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`args`](../interfaces/IEventData.md#args)

***

### defaultPrevented

#### Get Signature

> **get** **defaultPrevented**(): `boolean`

Defined in: [src/core/event.ts:137](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L137)

Whether [IEventData.preventDefault](../interfaces/IEventData.md#preventdefault) has been called.

##### Returns

`boolean`

Whether [IEventData.preventDefault](../interfaces/IEventData.md#preventdefault) has been called.

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`defaultPrevented`](../interfaces/IEventData.md#defaultprevented)

***

### nativeEvent

#### Get Signature

> **get** **nativeEvent**(): `TEvent`

Defined in: [src/core/event.ts:207](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L207)

The wrapped native DOM event, if any.

##### Returns

`TEvent`

The wrapped native DOM event, if any.

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`nativeEvent`](../interfaces/IEventData.md#nativeevent)

## Methods

### addReturnValue()

> **addReturnValue**(`value`): `void`

Defined in: [src/core/event.ts:193](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L193)

#### Parameters

##### value

`any`

#### Returns

`void`

***

### getReturnValue()

> **getReturnValue**(): `any`

Defined in: [src/core/event.ts:203](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L203)

Returns the last non-`undefined` return value from the handlers that have run.

#### Returns

`any`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`getReturnValue`](../interfaces/IEventData.md#getreturnvalue)

***

### getReturnValues()

> **getReturnValues**(): `any`[]

Defined in: [src/core/event.ts:199](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L199)

Returns all return values collected from handlers.

#### Returns

`any`[]

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`getReturnValues`](../interfaces/IEventData.md#getreturnvalues)

***

### isDefaultPrevented()

> **isDefaultPrevented**(): `boolean`

Defined in: [src/core/event.ts:144](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L144)

Returns `true` if [IEventData.preventDefault](../interfaces/IEventData.md#preventdefault) has been called or the native event is default-prevented.

#### Returns

`boolean`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isDefaultPrevented`](../interfaces/IEventData.md#isdefaultprevented)

***

### isImmediatePropagationStopped()

> **isImmediatePropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:185](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L185)

Returns whether [EventDataWrapper.stopImmediatePropagation](#stopimmediatepropagation) was called on this event object.

#### Returns

`boolean`

`true` if immediate propagation was stopped.

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isImmediatePropagationStopped`](../interfaces/IEventData.md#isimmediatepropagationstopped)

***

### isPropagationStopped()

> **isPropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:169](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L169)

Returns whether [EventDataWrapper.stopPropagation](#stoppropagation) was called on this event object.

#### Returns

`boolean`

`true` if propagation was stopped.

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isPropagationStopped`](../interfaces/IEventData.md#ispropagationstopped)

***

### preventDefault()

> **preventDefault**(): `void`

Defined in: [src/core/event.ts:139](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L139)

Prevents the default action associated with the event.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`preventDefault`](../interfaces/IEventData.md#preventdefault)

***

### stopImmediatePropagation()

> **stopImmediatePropagation**(): `void`

Defined in: [src/core/event.ts:176](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L176)

Prevents remaining handlers from being executed and stops DOM propagation.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`stopImmediatePropagation`](../interfaces/IEventData.md#stopimmediatepropagation)

***

### stopPropagation()

> **stopPropagation**(): `void`

Defined in: [src/core/event.ts:160](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L160)

Stops event from propagating up the DOM tree and marks it as propagation-stopped.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`stopPropagation`](../interfaces/IEventData.md#stoppropagation)
