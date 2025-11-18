[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / on

# Function: on()

## Call Signature

> **on**\<`K`\>(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L442)

Adds an event listener to the element. It is possible to use delegated events like jQuery.

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

#### listener

(`this`, `ev`) => `any`

The event listener to add.

### Returns

`void`

## Call Signature

> **on**(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L443)

Adds an event listener to the element. It is possible to use delegated events like jQuery.

### Parameters

#### element

`EventTarget`

The target element

#### type

`string`

The type of the event. It can include a ".namespace" similar to jQuery.

#### listener

`EventListener`

The event listener to add.

### Returns

`void`

## Call Signature

> **on**(`element`, `type`, `selector`, `delegationHandler`): `void`

Defined in: [src/base/fluent.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L444)

Adds an event listener to the element. It is possible to use delegated events like jQuery.

### Parameters

#### element

`EventTarget`

The target element

#### type

`string`

The type of the event. It can include a ".namespace" similar to jQuery.

#### selector

`string`

#### delegationHandler

`Function`

### Returns

`void`
