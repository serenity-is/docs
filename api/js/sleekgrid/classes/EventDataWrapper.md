[@serenity-is/sleekgrid](../README.md) / EventDataWrapper

# Class: EventDataWrapper\<TArgs, TEvent\>

Defined in: [src/core/event.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L78)

An event object for passing data to event handlers and letting them control propagation.
<p>This is pretty much identical to how W3C and jQuery implement events.</p>

## Type Parameters

### TArgs

`TArgs`

### TEvent

`TEvent` = \{ \}

## Implements

- [`IEventData`](../interfaces/IEventData.md)\<`TArgs`, `TEvent`\>

## Constructors

### Constructor

> **new EventDataWrapper**\<`TArgs`, `TEvent`\>(`event?`, `args?`): `EventDataWrapper`\<`TArgs`, `TEvent`\>

Defined in: [src/core/event.ts:87](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L87)

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

Defined in: [src/core/event.ts:147](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L147)

##### Returns

`TArgs`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`args`](../interfaces/IEventData.md#args)

***

### defaultPrevented

#### Get Signature

> **get** **defaultPrevented**(): `boolean`

Defined in: [src/core/event.ts:97](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L97)

##### Returns

`boolean`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`defaultPrevented`](../interfaces/IEventData.md#defaultprevented)

***

### nativeEvent

#### Get Signature

> **get** **nativeEvent**(): `TEvent`

Defined in: [src/core/event.ts:165](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L165)

##### Returns

`TEvent`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`nativeEvent`](../interfaces/IEventData.md#nativeevent)

## Methods

### addReturnValue()

> **addReturnValue**(`value`): `void`

Defined in: [src/core/event.ts:151](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L151)

#### Parameters

##### value

`any`

#### Returns

`void`

***

### getReturnValue()

> **getReturnValue**(): `any`

Defined in: [src/core/event.ts:161](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L161)

#### Returns

`any`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`getReturnValue`](../interfaces/IEventData.md#getreturnvalue)

***

### getReturnValues()

> **getReturnValues**(): `any`[]

Defined in: [src/core/event.ts:157](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L157)

#### Returns

`any`[]

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`getReturnValues`](../interfaces/IEventData.md#getreturnvalues)

***

### isDefaultPrevented()

> **isDefaultPrevented**(): `any`

Defined in: [src/core/event.ts:104](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L104)

#### Returns

`any`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isDefaultPrevented`](../interfaces/IEventData.md#isdefaultprevented)

***

### isImmediatePropagationStopped()

> **isImmediatePropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:143](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L143)

Returns whether stopImmediatePropagation was called on this event object.\

#### Returns

`boolean`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isImmediatePropagationStopped`](../interfaces/IEventData.md#isimmediatepropagationstopped)

***

### isPropagationStopped()

> **isPropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L128)

Returns whether stopPropagation was called on this event object.

#### Returns

`boolean`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`isPropagationStopped`](../interfaces/IEventData.md#ispropagationstopped)

***

### preventDefault()

> **preventDefault**(): `void`

Defined in: [src/core/event.ts:99](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L99)

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`preventDefault`](../interfaces/IEventData.md#preventdefault)

***

### stopImmediatePropagation()

> **stopImmediatePropagation**(): `void`

Defined in: [src/core/event.ts:135](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L135)

Prevents the rest of the handlers from being executed.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`stopImmediatePropagation`](../interfaces/IEventData.md#stopimmediatepropagation)

***

### stopPropagation()

> **stopPropagation**(): `void`

Defined in: [src/core/event.ts:120](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L120)

Stops event from propagating up the DOM tree.

#### Returns

`void`

#### Implementation of

[`IEventData`](../interfaces/IEventData.md).[`stopPropagation`](../interfaces/IEventData.md#stoppropagation)
