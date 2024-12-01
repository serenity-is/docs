[@serenity-is/sleekgrid](../README.md) / EventData

# Class: EventData

An event object for passing data to event handlers and letting them control propagation.
<p>This is pretty much identical to how W3C and jQuery implement events.</p>

## Implements

- [`IEventData`](../interfaces/IEventData.md)

## Constructors

### new EventData()

> **new EventData**(): [`EventData`](EventData.md)

#### Returns

[`EventData`](EventData.md)

## Methods

### isImmediatePropagationStopped()

> **isImmediatePropagationStopped**(): `boolean`

Returns whether stopImmediatePropagation was called on this event object.\

#### Returns

`boolean`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isImmediatePropagationStopped`](../interfaces/IEventData.md#isimmediatepropagationstopped)

#### Defined in

[core/event.ts:47](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L47)

***

### isPropagationStopped()

> **isPropagationStopped**(): `boolean`

Returns whether stopPropagation was called on this event object.

#### Returns

`boolean`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isPropagationStopped`](../interfaces/IEventData.md#ispropagationstopped)

#### Defined in

[core/event.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L33)

***

### stopImmediatePropagation()

> **stopImmediatePropagation**(): `void`

Prevents the rest of the handlers from being executed.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`stopImmediatePropagation`](../interfaces/IEventData.md#stopimmediatepropagation)

#### Defined in

[core/event.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L40)

***

### stopPropagation()

> **stopPropagation**(): `void`

Stops event from propagating up the DOM tree.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`stopPropagation`](../interfaces/IEventData.md#stoppropagation)

#### Defined in

[core/event.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L26)
