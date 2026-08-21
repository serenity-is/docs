[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / one

# Function: one()

Adds a one-time event listener (implementation).

## Param

Target element to listen on.

## Param

Event type; may include a `.namespace` suffix.

## Param

Event listener or selector when delegating.

## Param

Delegated handler when `handler` is a selector.

## Call Signature

> **one**\<`K`\>(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:573](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L573)

Adds a one-time event listener that is automatically removed after the first invocation.

### Type Parameters

#### K

`K` *extends* keyof `HTMLElementEventMap`

### Parameters

#### element

`EventTarget`

Target element to listen on.

#### type

`K`

Event type; may include a `.namespace` suffix.

#### listener

(`this`, `ev`) => `any`

Callback to invoke once when the event fires.

### Returns

`void`

`void`.

## Call Signature

> **one**(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:581](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L581)

Adds a one-time event listener.

### Parameters

#### element

`EventTarget`

Target element to listen on.

#### type

`string`

Event type; may include a `.namespace` suffix.

#### listener

`EventListener`

Callback to invoke once when the event fires.

### Returns

`void`

`void`.

## Call Signature

> **one**(`element`, `type`, `selector`, `delegationHandler`): `void`

Defined in: [src/base/fluent.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L590)

Adds a one-time delegated event listener.

### Parameters

#### element

`EventTarget`

Target element to listen on.

#### type

`string`

Event type; may include a `.namespace` suffix.

#### selector

`string`

CSS selector to delegate to.

#### delegationHandler

`Function`

Handler invoked once when the delegated target matches.

### Returns

`void`

`void`.
