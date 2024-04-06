[@serenity-is/sleekgrid](../README.md) / IEventData

# Interface: IEventData

## Implemented by

- [`EventData`](../classes/EventData.md)

## Table of contents

### Properties

- [currentTarget](IEventData.md#currenttarget)
- [defaultPrevented](IEventData.md#defaultprevented)
- [originalEvent](IEventData.md#originalevent)
- [target](IEventData.md#target)
- [type](IEventData.md#type)

### Methods

- [isDefaultPrevented](IEventData.md#isdefaultprevented)
- [isImmediatePropagationStopped](IEventData.md#isimmediatepropagationstopped)
- [isPropagationStopped](IEventData.md#ispropagationstopped)
- [preventDefault](IEventData.md#preventdefault)
- [stopImmediatePropagation](IEventData.md#stopimmediatepropagation)
- [stopPropagation](IEventData.md#stoppropagation)

## Properties

### currentTarget

• `Optional` **currentTarget**: `EventTarget`

#### Defined in

[core/event.ts:3](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L3)

___

### defaultPrevented

• `Optional` **defaultPrevented**: `boolean`

#### Defined in

[core/event.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L6)

___

### originalEvent

• `Optional` **originalEvent**: `any`

#### Defined in

[core/event.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L5)

___

### target

• `Optional` **target**: `EventTarget`

#### Defined in

[core/event.ts:4](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L4)

___

### type

• `Optional` `Readonly` **type**: `string`

#### Defined in

[core/event.ts:2](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L2)

## Methods

### isDefaultPrevented

▸ **isDefaultPrevented**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L10)

___

### isImmediatePropagationStopped

▸ **isImmediatePropagationStopped**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L11)

___

### isPropagationStopped

▸ **isPropagationStopped**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L12)

___

### preventDefault

▸ **preventDefault**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L7)

___

### stopImmediatePropagation

▸ **stopImmediatePropagation**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L9)

___

### stopPropagation

▸ **stopPropagation**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L8)
