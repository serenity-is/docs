[@serenity-is/sleekgrid](../README.md) / IEventData

# Interface: IEventData

## Properties

### currentTarget?

> `optional` **currentTarget**: `EventTarget`

#### Defined in

[core/event.ts:3](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L3)

***

### defaultPrevented?

> `optional` **defaultPrevented**: `boolean`

#### Defined in

[core/event.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L6)

***

### originalEvent?

> `optional` **originalEvent**: `any`

#### Defined in

[core/event.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L5)

***

### target?

> `optional` **target**: `EventTarget`

#### Defined in

[core/event.ts:4](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L4)

***

### type?

> `readonly` `optional` **type**: `string`

#### Defined in

[core/event.ts:2](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L2)

## Methods

### isDefaultPrevented()?

> `optional` **isDefaultPrevented**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L10)

***

### isImmediatePropagationStopped()?

> `optional` **isImmediatePropagationStopped**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L11)

***

### isPropagationStopped()?

> `optional` **isPropagationStopped**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L12)

***

### preventDefault()?

> `optional` **preventDefault**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L7)

***

### stopImmediatePropagation()?

> `optional` **stopImmediatePropagation**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L9)

***

### stopPropagation()?

> `optional` **stopPropagation**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L8)
