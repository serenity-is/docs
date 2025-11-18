[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / one

# Function: one()

## Call Signature

> **one**\<`K`\>(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L456)

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

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

> **one**(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L457)

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

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

> **one**(`element`, `type`, `selector`, `delegationHandler`): `void`

Defined in: [src/base/fluent.ts:458](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L458)

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

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
