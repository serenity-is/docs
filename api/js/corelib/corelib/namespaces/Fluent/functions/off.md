[corelib](../../../../README.md) / [Fluent](../README.md) / off

# Function: off()

## Call Signature

> **off**\<`K`\>(`element`, `type`, `listener?`): `void`

Defined in: [src/base/fluent.ts:470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L470)

Removes an event listener from the element.

### Type Parameters

#### K

`K` *extends* keyof `HTMLElementEventMap`

### Parameters

#### element

`EventTarget`

The target element

#### type

`K`

The type of the event. It can include a ".namespace" similar to jQuery.

#### listener?

(`this`, `ev`) => `any`

The event listener to remove.

### Returns

`void`

## Call Signature

> **off**(`element`, `type`, `listener?`): `void`

Defined in: [src/base/fluent.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L471)

Removes an event listener from the element.

### Parameters

#### element

`EventTarget`

The target element

#### type

`string`

The type of the event. It can include a ".namespace" similar to jQuery.

#### listener?

`EventListener`

The event listener to remove.

### Returns

`void`

## Call Signature

> **off**(`element`, `type`, `selector?`, `delegationHandler?`): `void`

Defined in: [src/base/fluent.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L472)

Removes an event listener from the element.

### Parameters

#### element

`EventTarget`

The target element

#### type

`string`

The type of the event. It can include a ".namespace" similar to jQuery.

#### selector?

`string`

#### delegationHandler?

`Function`

### Returns

`void`
