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

[core/event.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L5)

___

### defaultPrevented

• `Optional` **defaultPrevented**: `boolean`

#### Defined in

[core/event.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L8)

___

### originalEvent

• `Optional` **originalEvent**: `any`

#### Defined in

[core/event.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L7)

___

### target

• `Optional` **target**: `EventTarget`

#### Defined in

[core/event.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L6)

___

### type

• `Optional` `Readonly` **type**: `string`

#### Defined in

[core/event.ts:4](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L4)

## Methods

### isDefaultPrevented

▸ `Optional` **isDefaultPrevented**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L12)

___

### isImmediatePropagationStopped

▸ `Optional` **isImmediatePropagationStopped**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L13)

___

### isPropagationStopped

▸ `Optional` **isPropagationStopped**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/event.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L14)

___

### preventDefault

▸ `Optional` **preventDefault**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L9)

___

### stopImmediatePropagation

▸ `Optional` **stopImmediatePropagation**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L11)

___

### stopPropagation

▸ `Optional` **stopPropagation**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L10)
