[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / on

# Function: on()

Adds an event listener (implementation).

## Param

Target element to listen on.

## Param

Event type; may include a `.namespace` suffix.

## Param

Event listener or selector when delegating.

## Param

Delegated handler when `handler` is a selector.

## Call Signature

> **on**\<`K`\>(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L536)

Adds an event listener, with optional delegation and namespace support.

### Type Parameters

#### K

`K` *extends* keyof `HTMLElementEventMap`

### Parameters

#### element

`EventTarget`

Target element to listen on.

#### type

`K`

Event type; may include a `.namespace` suffix (e.g. `"click.myNs"`).

#### listener

(`this`, `ev`) => `any`

Callback to invoke when the event fires.

### Returns

`void`

`void`.

## Call Signature

> **on**(`element`, `type`, `listener`): `void`

Defined in: [src/base/fluent.ts:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L544)

Adds an event listener.

### Parameters

#### element

`EventTarget`

Target element to listen on.

#### type

`string`

Event type; may include a `.namespace` suffix.

#### listener

`EventListener`

Callback to invoke when the event fires.

### Returns

`void`

`void`.

## Call Signature

> **on**(`element`, `type`, `selector`, `delegationHandler`): `void`

Defined in: [src/base/fluent.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L553)

Adds a delegated event listener.

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

Handler invoked when the delegated target matches.

### Returns

`void`

`void`.
