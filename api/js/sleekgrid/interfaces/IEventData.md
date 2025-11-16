[serenity-is/sleekgrid](../README.md) / IEventData

# Interface: IEventData\<TArgs, TEvent\>

Defined in: [src/core/event.ts:2](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L2)

## Type Parameters

### TArgs

`TArgs` = \{ \}

### TEvent

`TEvent` = \{ \}

## Properties

### args

> **args**: `TArgs`

Defined in: [src/core/event.ts:3](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L3)

***

### defaultPrevented

> **defaultPrevented**: `boolean`

Defined in: [src/core/event.ts:4](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L4)

***

### nativeEvent

> **nativeEvent**: `TEvent`

Defined in: [src/core/event.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L13)

## Methods

### getReturnValue()

> **getReturnValue**(): `any`

Defined in: [src/core/event.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L11)

#### Returns

`any`

***

### getReturnValues()

> **getReturnValues**(): `any`[]

Defined in: [src/core/event.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L12)

#### Returns

`any`[]

***

### isDefaultPrevented()

> **isDefaultPrevented**(): `boolean`

Defined in: [src/core/event.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L8)

#### Returns

`boolean`

***

### isImmediatePropagationStopped()

> **isImmediatePropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L9)

#### Returns

`boolean`

***

### isPropagationStopped()

> **isPropagationStopped**(): `boolean`

Defined in: [src/core/event.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L10)

#### Returns

`boolean`

***

### preventDefault()

> **preventDefault**(): `void`

Defined in: [src/core/event.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L5)

#### Returns

`void`

***

### stopImmediatePropagation()

> **stopImmediatePropagation**(): `void`

Defined in: [src/core/event.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L7)

#### Returns

`void`

***

### stopPropagation()

> **stopPropagation**(): `void`

Defined in: [src/core/event.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L6)

#### Returns

`void`
