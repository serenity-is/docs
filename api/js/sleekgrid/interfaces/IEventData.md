[@serenity-is/sleekgrid](../README.md) / IEventData

# Interface: IEventData\<TArgs, TEvent\>

Defined in: [src/core/event.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L7)

Core event object passed to every grid event handler. Mirrors W3C/jQuery event
semantics with propagation and default-prevent controls.

## Type Parameters

### TArgs

`TArgs` = \{ \}

Payload specific to the event.

### TEvent

`TEvent` = \{ \}

Native DOM event wrapped by this object.

## Properties

### args

> **args**: `TArgs`

Defined in: [src/core/event.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L9)

Payload supplied by the event emitter (e.g. `{row, cell, grid}`).

***

### defaultPrevented

> **defaultPrevented**: `boolean`

Defined in: [src/core/event.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L11)

Whether [IEventData.preventDefault](#preventdefault) has been called.

***

### nativeEvent

> **nativeEvent**: `TEvent`

Defined in: [src/core/event.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L36)

The wrapped native DOM event, if any.

## Methods

### getReturnValue()

> **getReturnValue**(): `any`

Defined in: [src/core/event.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L32)

Returns the last non-`undefined` return value from the handlers that have run.

#### Returns

`any`

***

### getReturnValues()

> **getReturnValues**(): `any`[]

Defined in: [src/core/event.ts:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L34)

Returns all return values collected from handlers.

#### Returns

`any`[]

***

### isDefaultPrevented()

> **isDefaultPrevented**(): `boolean`

Defined in: [src/core/event.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L26)

Returns `true` if [IEventData.preventDefault](#preventdefault) has been called or the native event is default-prevented.

#### Returns

`boolean`

***

### isImmediatePropagationStopped()

> **isImmediatePropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L28)

Returns `true` if [IEventData.stopImmediatePropagation](#stopimmediatepropagation) has been called.

#### Returns

`boolean`

***

### isPropagationStopped()

> **isPropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L30)

Returns `true` if [IEventData.stopPropagation](#stoppropagation) has been called.

#### Returns

`boolean`

***

### preventDefault()

> **preventDefault**(): `void`

Defined in: [src/core/event.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L15)

Prevents the default action associated with the event.

#### Returns

`void`

***

### stopImmediatePropagation()

> **stopImmediatePropagation**(): `void`

Defined in: [src/core/event.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L24)

Prevents remaining handlers from being executed. Also stops DOM propagation.

#### Returns

`void`

***

### stopPropagation()

> **stopPropagation**(): `void`

Defined in: [src/core/event.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L20)

Stops the event from bubbling further, but remaining handlers on the same
emitter still run. Also calls `stopPropagation` on the native event when present.

#### Returns

`void`
