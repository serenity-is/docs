[@serenity-is/sleekgrid](../README.md) / EventData

# Class: EventData

An event object for passing data to event handlers and letting them control propagation.
<p>This is pretty much identical to how W3C and jQuery implement events.</p>

## Implements

- [`IEventData`](../interfaces/IEventData.md)

## Table of contents

### Constructors

- [constructor](EventData.md#constructor)

### Properties

- [\_isImmediatePropagationStopped](EventData.md#_isimmediatepropagationstopped)
- [\_isPropagationStopped](EventData.md#_ispropagationstopped)

### Methods

- [isImmediatePropagationStopped](EventData.md#isimmediatepropagationstopped)
- [isPropagationStopped](EventData.md#ispropagationstopped)
- [stopImmediatePropagation](EventData.md#stopimmediatepropagation)
- [stopPropagation](EventData.md#stoppropagation)

## Constructors

### constructor

• **new EventData**()

## Properties

### \_isImmediatePropagationStopped

• `Private` **\_isImmediatePropagationStopped**: `boolean` = `false`

#### Defined in

[core/event.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#line&#x3D;23)

___

### \_isPropagationStopped

• `Private` **\_isPropagationStopped**: `boolean` = `false`

#### Defined in

[core/event.ts:22](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#line&#x3D;22)

## Methods

### isImmediatePropagationStopped

▸ **isImmediatePropagationStopped**(): `boolean`

Returns whether stopImmediatePropagation was called on this event object.\

#### Returns

`boolean`

#### Implementation of

[IEventData](../interfaces/IEventData.md).[isImmediatePropagationStopped](../interfaces/IEventData.md#isimmediatepropagationstopped)

#### Defined in

[core/event.ts:50](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#line&#x3D;50)

___

### isPropagationStopped

▸ **isPropagationStopped**(): `boolean`

Returns whether stopPropagation was called on this event object.

#### Returns

`boolean`

#### Implementation of

[IEventData](../interfaces/IEventData.md).[isPropagationStopped](../interfaces/IEventData.md#ispropagationstopped)

#### Defined in

[core/event.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#line&#x3D;36)

___

### stopImmediatePropagation

▸ **stopImmediatePropagation**(): `void`

Prevents the rest of the handlers from being executed.

#### Returns

`void`

#### Implementation of

[IEventData](../interfaces/IEventData.md).[stopImmediatePropagation](../interfaces/IEventData.md#stopimmediatepropagation)

#### Defined in

[core/event.ts:43](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#line&#x3D;43)

___

### stopPropagation

▸ **stopPropagation**(): `void`

Stops event from propagating up the DOM tree.

**`Method`**

stopPropagation

#### Returns

`void`

#### Implementation of

[IEventData](../interfaces/IEventData.md).[stopPropagation](../interfaces/IEventData.md#stoppropagation)

#### Defined in

[core/event.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#line&#x3D;29)
